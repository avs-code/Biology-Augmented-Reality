using UnityEngine;


public class IgeActivation : MonoBehaviour
{
    public ParticleSystem[] histaminas;
    [SerializeField] Animator m_Animator;
    [SerializeField] GameObject pollenTarget;
    [SerializeField] GameObject pollenAnimation;
    [SerializeField] GameObject igeTarget;
    [SerializeField] GameObject igeAnimation;


    void Start()
    {
        histaminas = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem histaminas in histaminas)
        {
            histaminas.Stop();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the Collider's name is "Pollen" enable particle system (histamina)
        if (other.gameObject.tag == "pollen")
        {

            igeTarget.SetActive(false);
            pollenTarget.SetActive(false);
            igeAnimation.SetActive(true);
            pollenAnimation.SetActive(true);

            m_Animator.SetTrigger("Pollen");

            foreach (ParticleSystem histamina in histaminas)
            {
                histamina.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "pollen")
        {

            igeTarget.SetActive(true);
            pollenTarget.SetActive(true);
            igeAnimation.SetActive(false);
            pollenAnimation.SetActive(false);

            m_Animator.ResetTrigger("Pollen");

            foreach (ParticleSystem histaminas in histaminas)
            {
                histaminas.Stop();
            }
        }
    }
}
