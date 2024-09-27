using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ApplyInteractableEvents : MonoBehaviour
{
    public Color highlightColor = Color.yellow; // Hover color
    private bool isBeingHeld = false; // Indicate if object is being held

    private void Start()
    {
        // Find objects 
        XRGrabInteractable[] interactables = FindObjectsOfType<XRGrabInteractable>();

        foreach (XRGrabInteractable interactable in interactables)
        {
            Renderer objectRenderer = interactable.GetComponent<Renderer>();

            if (objectRenderer != null)
            {
                Color originalColor = objectRenderer.material.color;

                interactable.hoverEntered.AddListener((HoverEnterEventArgs args) =>
                {
                    if (!isBeingHeld)
                    {
                        objectRenderer.material.color = highlightColor;
                    }
                });

                interactable.hoverExited.AddListener((HoverExitEventArgs args) =>
                {
                    if (!isBeingHeld)
                    {
                        objectRenderer.material.color = originalColor;
                    }
                });

                interactable.selectEntered.AddListener((SelectEnterEventArgs args) =>
                {
                    isBeingHeld = true;
                    objectRenderer.material.color = originalColor;
                });

                interactable.selectExited.AddListener((SelectExitEventArgs args) =>
                {
                    isBeingHeld = false;
                });
            }
        }
    }
}
