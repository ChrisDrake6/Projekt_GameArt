using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Transitioner : MonoBehaviour
{
    public Animator transition;

    public GameObject currentScene;
    public GameObject targetScene;

    public float switchDelay;

    private void OnMouseDown()
    {
        transition.SetTrigger("toggleTransition");
        Invoke("SwitchScene", switchDelay);
    }
    void SwitchScene()
    {
        currentScene.SetActive(false);
        targetScene.SetActive(true);
    }


}
