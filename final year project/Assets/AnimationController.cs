using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public Transform my3DModel;
    public Transform MyPauseButton;
    public Transform MyResumeButton;
    public float myTime;
    public GameObject[] Steps;

    public int flag = 1;
    public float animation_speed = 1;
    public float animation_change_factor = 0.5f;

    public int Step_index = 0;
    public int StepIndexMax = 7;

    // Start is called before the first frame update 
    void Start()
    {
        animator = my3DModel.GetComponent<Animator>();
        MyPauseButton.gameObject.SetActive(true);
        MyResumeButton.gameObject.SetActive(false);
    }

    public void Animation_Speed_Adjust(float change)
    {
        animation_speed = 1 + change * animation_change_factor;
        animator.speed = animation_speed;
    }

    public void Animation_Jump(float jump_time)
    {
        AnimatorClipInfo[] myAnimatorClip = animator.GetCurrentAnimatorClipInfo(0);

        animator.Play("DH Notation lecture example", -1, (myTime + jump_time) / myAnimatorClip[0].clip.length);
    }

    public void playAnime()
    {
        animator.Play("DH Notation lecture example", -1, 0f);
    }

    public void pauseAnim()
    {
        animator.speed = 0;
        MyResumeButton.gameObject.SetActive(true);
        MyPauseButton.gameObject.SetActive(false);
        //MyPauseButton.GetComponentInChildren<Text>().text = "RESUME";
        //Button btn = MyPauseButton.GetComponent<Button>();
        //btn.onClick.AddListener(resumeAnim);
    }

    public void Resume_btn()
    {
        animator.speed = animation_speed;
        MyPauseButton.gameObject.SetActive(true);
        MyResumeButton.gameObject.SetActive(false);

        if (flag == 0) { flag = 1; }
    }

    void resumeAnim()
    {
        MyPauseButton.GetComponentInChildren<Text>().text = "PAUSE";
        animator.speed = animation_speed;
        Button btn = MyPauseButton.GetComponent<Button>();
        btn.onClick.AddListener(pauseAnim);

        if (flag == 0) { flag = 1; }
    }

    public void Back_MainScene()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        
        AnimatorStateInfo animationState = animator.GetCurrentAnimatorStateInfo(0);
        AnimatorClipInfo[] myAnimatorClip = animator.GetCurrentAnimatorClipInfo(0);

        if (animationState.IsName("DH Notation lecture example"))
        {
            myTime = myAnimatorClip[0].clip.length * animationState.normalizedTime;
        }

        //if (myTime < 2.0)
        //{
        //    Steps[0].SetActive(false);
        //    Steps[1].SetActive(false);
        //    Steps[2].SetActive(false);
        //    Steps[3].SetActive(false);
        //    Steps[4].SetActive(false);
        //    Steps[5].SetActive(false);
        //    Steps[6].SetActive(false);
        //    //Steps[7].SetActive(false);
        //}

        if (myTime > 0 && myTime < 2.0)
        {
            Step_index = 7;
            //Steps[7].SetActive(true);
        }

        if (myTime > 2.0 && myTime < 10.0)
        {
            Step_index = 0;
            //Steps[7].SetActive(false);
            //Steps[0].SetActive(true);

            //if (flag == 1)
            //{
            //    animator.speed = 0;
            //    MyResumeButton.gameObject.SetActive(true);
            //    MyPauseButton.gameObject.SetActive(false);
            //    flag = 0;
            //}
            //else { }
        }

        if (myTime > 10.0 && myTime < 30.0)
        {
            Step_index = 1;
            //Steps[0].SetActive(false);
            //Steps[1].SetActive(true);

            //if (flag == 1)
            //{ pauseAnim();
            //    flag = 0;
            //}
        }

        if (myTime > 28.0 && myTime < 30.0)
        {
            Step_index = 2;
            //Steps[1].SetActive(false);
            //Steps[2].SetActive(true);
            //if (myTime == 28.5) { pauseAnim(); }
        }

        if (myTime > 30.0 && myTime < 34.0)
        {
            Step_index = 3;
            //Steps[2].SetActive(false);
            //Steps[3].SetActive(true);
            //if (myTime == 30.5) { pauseAnim(); }
        }

        if (myTime > 34.0 && myTime < 37.0)
        {
            Step_index = 4;
            //Steps[3].SetActive(false);
            //Steps[4].SetActive(true);
            //if (myTime == 34.5) { pauseAnim(); }
        }

        if (myTime > 37.0 && myTime < 42.0)
        {
            Step_index = 5;
            //Steps[4].SetActive(false);
            //Steps[5].SetActive(true);
            //if (myTime == 37.5) { pauseAnim(); }
        }

        if (myTime > 42.0 && myTime < 48.0)
        {
            Step_index = 6;
            //Steps[5].SetActive(false);
            //Steps[6].SetActive(true);
            //if (myTime == 42.5) { pauseAnim(); }
        }

        if (myTime > 48.0 && myTime < 51.0)
        {
            Step_index = 6;
            //Steps[5].SetActive(false);
            //Steps[6].SetActive(true);
            //if (myTime == 48.5) { pauseAnim(); }
        }

        for (int i = 0; i <= StepIndexMax; i++)
        {
            if (i == Step_index)
            {
                Steps[i].SetActive(true);
            }else
            {
                Steps[i].SetActive(false);
            }
        }

    }
}
