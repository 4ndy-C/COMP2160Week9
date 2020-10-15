using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class coin : MonoBehaviour
{
    Rigidbody rb;
    Collider collider;
    public ScoreKeeper scorer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            scorer.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
