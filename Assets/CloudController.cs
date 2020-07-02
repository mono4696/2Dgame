using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    Vector3 startPos;
    public float posY_down;
    public float posY_up;
    public float speed;

    public GameObject obj;

    private float interval = 1.5f;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        MakeCloud();
    
    }

    void MakeCloud()
    {
        if (time > interval)
        {
            GameObject cloud = Instantiate(
                obj,
                new Vector3(transform.position.x, Random.Range(8f, 0f), transform.position.z),
                Quaternion.identity
                );
            time = 0f;
            Destroy(cloud, 6f);

        }
        obj.transform.Translate(Vector3.up * speed);
    
    }
}
