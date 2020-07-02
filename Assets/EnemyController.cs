using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bullet;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //1秒毎に実行
        if (time > 1f)
        {
            time -= 1f;

            GameObject obj;
            obj = Instantiate(bullet);
            obj.transform.position = transform.position;

            float height= Random.Range(-3f, 3f);
            float amp = Random.Range(-6f, -3f);
            transform.position = new Vector3(amp, height, 0f);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P_Bullet")
        {
            Destroy(gameObject);
        }
    }

}
