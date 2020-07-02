using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudEffect : MonoBehaviour
{
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (effect != null)
        {
            Instantiate(
                effect,
                collision.transform.position,
                Quaternion.identity
                );
        }
    }
}
