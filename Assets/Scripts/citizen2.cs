using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class citizen2 : MonoBehaviour
{
    public float speed;
    private bool go = true;
    public int Limit = 33;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= Limit && go)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            if (transform.position.x > Limit)
            {
                go = !go;
            }
        }
        else if (transform.position.x >= -Limit && !go)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (transform.position.x < -Limit)
            {
                go = !go;
            }
        }
    }
}
