using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPolicyWarning : MonoBehaviour
{
    [SerializeField] Canvas policyMessage;

    public void OkButton()
    {
        // Desactiva el mensaje de advertencia PolicyMessage
        policyMessage.enabled = false;
        // Llama al método para activar el botón de salida
        ExitButton.Instance.ShowExitButton();
    }
}
