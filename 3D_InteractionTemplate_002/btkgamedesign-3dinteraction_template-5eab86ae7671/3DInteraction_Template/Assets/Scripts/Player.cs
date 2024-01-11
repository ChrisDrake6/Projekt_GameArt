using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Interactable currentInteractable;
    private Camera mainCam;

    private void Awake()
    {
        mainCam = Camera.main;
    }

    private void Update()
    {
        //When the player left-clicks we search for an Interactable, unless we are already in an interaction.
        //In that case we close the displayed text.
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(currentInteractable == null)
            {
                RaycastHit hit;
                Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Interactable foundInteractable = hit.collider.gameObject.GetComponent<Interactable>();

                    if (foundInteractable != null)
                    {
                        // If we found the Interactable component on the clicked object we play its animation and show the text.
                        Debug.Log("Interacted with " + foundInteractable.gameObject.name);
                        currentInteractable = foundInteractable;
                        currentInteractable.PlayAnimation();
                        currentInteractable.ShowText();
                    }
                }
            }
            else
            {
                currentInteractable.HideText();
                currentInteractable = null;
            }
        }

    }
}
