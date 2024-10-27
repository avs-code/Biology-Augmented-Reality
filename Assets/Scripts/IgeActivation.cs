using UnityEngine;


public class IgeActivation : MonoBehaviour
{
    public ParticleSystem[] histaminas;
    [Header("Animator")]
    [SerializeField] Animator m_Animator;
    [Header("Targets")]
    [SerializeField] GameObject pollenTarget;
    [SerializeField] GameObject igeTarget;
    [Header("Animations")]
    [SerializeField] GameObject[] pollenAnimations;
    [SerializeField] GameObject[] igeAnimations;

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

            foreach (GameObject igeAnimation in igeAnimations)
            {
                igeAnimation.SetActive(true);
            }

            foreach (GameObject pollenAnimation in pollenAnimations)
            {
                pollenAnimation.SetActive(true);
            }

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

            foreach (GameObject igeAnimation in igeAnimations)
            {
                igeAnimation.SetActive(false);
            }

            foreach (GameObject pollenAnimation in pollenAnimations)
            {
                pollenAnimation.SetActive(false);
            }

            m_Animator.ResetTrigger("Pollen");

            foreach (ParticleSystem histaminas in histaminas)
            {
                histaminas.Stop();
            }
        }
    }
}
