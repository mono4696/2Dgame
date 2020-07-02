using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    float time= 0f;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec;
        float move_x;

        move_x = speed * Time.deltaTime;
        vec = new Vector2(move_x, 0f);
        transform.Translate(-vec);

        time += Time.deltaTime;
        if (time > 9f)
        {
            Destroy(gameObject);
        }
    }
}
