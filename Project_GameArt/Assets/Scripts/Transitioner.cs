using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Transitioner : MonoBehaviour
{
    public Animator transition;

    public int targetscene;
    public float switchDelay;

    private void OnMouseDown()
    {
        transition.SetTrigger("toggleTransition");
        Invoke("SwitchScene", switchDelay);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(targetscene);
    }


}
