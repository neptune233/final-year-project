Shader "Custom/Outline"
{
	Properties//Variables
	{
		_MainTex("Texture", 2D) = "white"{}
		_Color("Color", Color) = (1,1,1,1)//Allows for a color property.
		_OutlineColor("Outline Color", Color) = (0,0,0,1)
		_OutlineWidth("Outline Width", Range(1.0,5.0)) = 1.01
	}

		CGINCLUDE
#include "UnityCG.cginc"

		struct appdata
	{
		float4 vertex : POSITION;
		float3 normal : NORMAL;
	};

	struct v2f
	{
		float4 pos : POSITION;
		float3 normal : NORMAL;
	};

	float _OutlineWidth;
	float4 _OutlineColor;

	v2f vert(appdata v)
	{
		v.vertex.xyz *= _OutlineWidth;

		v2f o;
		o.pos = UnityObjectToClipPos(v.vertex);
		return o;
	}

	ENDCG

		SubShader
		{
			Tags{ "Queue" = "Transparent"}
			
			Pass
			{
				ZWrite Off//Allows for other render passes to be drawn on top of this pass.

				CGPROGRAM//Allows talk between two languages: shader lab and nvidia C for graphics.
				
				//\===========================================================================================
				//\ Function Defines - defines the name for the vertex and fragment functions
				//\===========================================================================================

				#pragma vertex vert//Define for the building function.

				#pragma fragment frag//Define for coloring function.

				//\===========================================================================================
				//\ Includes
				//\===========================================================================================
				half4 frag(v2f i) : COLOR
				{
					return _OutlineColor;
				}

				//\===========================================================================================
				//\ Structures - Can get data like - vertices's, normal, color, uv.
				//\===========================================================================================

				ENDCG
			}

			Pass
			{
				ZWrite On//Allows talk between two languages: shader lab and nvidia C for graphics.

				//\===========================================================================================
				//\ Function Defines - defines the name for the vertex and fragment functions
				//\===========================================================================================

				Material
				{
					Diffuse[_Color]
					Ambient[_Color]
				}

				Lighting On

				SetTexture[_MainTex]
				{
					ConstantColor[_Color]
				}

				SetTexture[_MainTex]
				{
					Combine previous * primary DOUBLE
				}

			}
		}
}
