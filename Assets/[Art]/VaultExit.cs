using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VaultExit : MonoBehaviour
{
    public GameObject scorePopup;
    public TextMeshProUGUI scoreText;
    public GameObject resetCube;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && VaultEntry.hasEnteredVault)
        {
            scorePopup.SetActive(true);
            scoreText.text = "You escaped with " + bagscript.score + " points!";
            resetCube.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
