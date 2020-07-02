using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float time = 0f;
    public float speed;
    public float angle;
    public float limitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rad;
        Vector2 vec;
        float move_x;
        float move_y;

        rad = angle * Mathf.Deg2Rad;

        move_x = Mathf.Cos(rad) * speed * Time.deltaTime;
        move_y = Mathf.Sin(rad) * speed * Time.deltaTime;
        vec = new Vector2(move_x, move_y);
        transform.Translate(vec);

        time += Time.deltaTime;
        if (time > 9f)
        {
            Destroy(gameObject);
        }
        

    }
}
