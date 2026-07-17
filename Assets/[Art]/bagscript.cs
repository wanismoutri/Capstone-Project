using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class bagscript : MonoBehaviour
{
    public static int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        XRGrabInteractable grab = other.GetComponent<XRGrabInteractable>();
        if (grab != null && grab.isSelected)
        {
            if(other.gameObject.CompareTag("Silver"))
            {
                score += 50;
                Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("Gold"))
            {
                score += 125;
                Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("Diamonds"))
            {
                score += 300;
                Destroy(other.gameObject);
            }

            Debug.Log("Score: " + score);
        }
    }
}
