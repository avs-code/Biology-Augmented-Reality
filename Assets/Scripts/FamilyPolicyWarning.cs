using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPolicyWarning : MonoBehaviour
{
    [SerializeField] Canvas CanvasPolicyMessage;
    [SerializeField] GameObject canvasExitButton; // Referencia al Canvas que contiene el botón de salida

    public void OkButton()
    {
        // Desactiva el mensaje de advertencia PolicyMessage
        CanvasPolicyMessage.enabled = false;

        // Verifica si ExitButton.Instance no es null
        if (ExitButton.Instance != null)
        {
            // Llama al método para activar el botón de salida
            ExitButton.Instance.ShowExitButton();
        }
        else
        {
            Debug.LogError("ExitButton.Instance is null. Make sure the ExitButton script is properly initialized.");
        }

        // Activa el CanvasExitButton
        if (canvasExitButton != null)
        {
            canvasExitButton.SetActive(true);
        }
        else
        {
            Debug.LogError("canvasExitButton is not assigned in the Inspector.");
        }
    }
}
