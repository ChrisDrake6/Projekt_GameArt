using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] AnimationClip animClip;

    [Header("Component References")]
    [SerializeField] Animator animator;
    [SerializeField] GameObject textDisplay;


    private void Awake()
    {
        if(animator == null)
        {
            Debug.LogWarning("No animator set up!");
            animator = GetComponent<Animator>();
        }

        if(animClip.name == "")
        {
            Debug.LogWarning("No animation name set up!");
        }

        if(textDisplay == null)
        {
            Debug.LogWarning("Text display reference not set up!");
        }
    }

    public void PlayAnimation()
    {
        // Start the specified animation, unless it is already playing.
        AnimatorClipInfo[] animatorinfo = this.animator.GetCurrentAnimatorClipInfo(0);
        if (animatorinfo[0].clip.name == animClip.name) return;

        animator.Play(animClip.name);
    }

    public void ShowText()
    {
        textDisplay.SetActive(true);
    }

    public void HideText()
    {
        textDisplay.SetActive(false);
    }
}