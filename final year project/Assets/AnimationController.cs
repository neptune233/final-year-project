using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public Transform my3DModel;
    public Transform MyPauseButton;
    public float myTime;
    public GameObject[] Steps;

    // Start is called before the first frame update 
    void Start()
    {
        animator = my3DModel.GetComponent<Animator>();
    }

    public void playAnime()
    {
        animator.Play("DH Notation lecture example", -1, 0f);
    }

    public void pauseAnim()
    {
        animator.speed = 0;
        MyPauseButton.GetComponentInChildren<Text>().text = "RESUME";
        Button btn = MyPauseButton.GetComponent<Button>();
        btn.onClick.AddListener(resumeAnim);
    }

    void resumeAnim()
    {
        MyPauseButton.GetComponentInChildren<Text>().text = "PAUSE";
        animator.speed = 1;
        Button btn = MyPauseButton.GetComponent<Button>();
        btn.onClick.AddListener(pauseAnim);
    }

    private void Update()
    {
        
        AnimatorStateInfo animationState = animator.GetCurrentAnimatorStateInfo(0);
        AnimatorClipInfo[] myAnimatorClip = animator.GetCurrentAnimatorClipInfo(0);

        if (animationState.IsName("DH Notation lecture example"))
        {
            myTime = myAnimatorClip[0].clip.length * animationState.normalizedTime;
        }

        if (myTime < 3.0)
        {
            Steps[0].SetActive(false);
            Steps[1].SetActive(false);
            Steps[2].SetActive(false);
            Steps[3].SetActive(false);
            Steps[4].SetActive(false);
            Steps[5].SetActive(false);
            Steps[6].SetActive(false);
        }

        if (myTime > 3.0 && myTime < 6.0)
        {
            Steps[0].SetActive(true);
        }

        if (myTime > 6.0 && myTime < 9.0)
        {
            Steps[0].SetActive(false);
            Steps[1].SetActive(true);
        }

        if (myTime > 9.0 && myTime < 12.0)
        {
            Steps[1].SetActive(false);
            Steps[2].SetActive(true);
        }

        if (myTime > 12.0 && myTime < 15.0)
        {
            Steps[2].SetActive(false);
            Steps[3].SetActive(true);
        }

        if (myTime > 15.0 && myTime < 18.0)
        {
            Steps[3].SetActive(false);
            Steps[4].SetActive(true);
        }

        if (myTime > 18.0 && myTime < 21.0)
        {
            Steps[4].SetActive(false);
            Steps[5].SetActive(true);
        }

        if (myTime > 21.0 && myTime < 24.0)
        {
            Steps[5].SetActive(false);
            Steps[6].SetActive(true);
        }

     
    }
}
