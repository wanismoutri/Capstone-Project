using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingWall : MonoBehaviour
{
    public Transform targetPosition;
    public float speed = 2f;
    private bool isClosing = false;
    public void StartClosing()
    {
        isClosing = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isClosing)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }
}
