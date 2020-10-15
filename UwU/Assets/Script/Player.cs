using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    int playerMovement = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = playerMovement * Time.deltaTime * Input.GetAxis("Horizontal");
        float zMovement = playerMovement * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(xMovement, 0, zMovement);
    }
}
