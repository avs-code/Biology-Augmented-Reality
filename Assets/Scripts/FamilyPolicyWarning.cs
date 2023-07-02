using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPolicyWarning : MonoBehaviour
{
    [SerializeField] Canvas policyMessage;

 public void OkButton()
    {
        policyMessage.enabled = false;
    }
}
