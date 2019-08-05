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

        if (myTime > 2.0 && myTime < 10.0)
        {
            Steps[0].SetActive(true);
        }

        if (myTime > 10.0 && myTime < 30.0)
        {
            Steps[0].SetActive(false);
            Steps[1].SetActive(true);
        }

        if (myTime > 28.0 && myTime < 30.0)
        {
            Steps[1].SetActive(false);
            Steps[2].SetActive(true);
        }

        if (myTime > 30.0 && myTime < 34.0)
        {
            Steps[2].SetActive(false);
            Steps[3].SetActive(true);
        }

        if (myTime > 34.0 && myTime < 37.0)
        {
            Steps[3].SetActive(false);
            Steps[4].SetActive(true);
        }

        if (myTime > 37.0 && myTime < 42.0)
        {
            Steps[4].SetActive(false);
            Steps[5].SetActive(true);
        }

        if (myTime > 42.0 && myTime < 48.0)
        {
            Steps[5].SetActive(false);
            Steps[6].SetActive(true);
        }

        if (myTime > 48.0 && myTime < 51.0)
        {
            Steps[5].SetActive(false);
            Steps[6].SetActive(true);
        }

    }
}
