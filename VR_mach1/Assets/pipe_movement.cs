using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move_script : MonoBehaviour
{
    public float speed = -2.0f;
    //public float time_till_death = 3.0f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;


        if(transform.position.x > 20.0f)
        {
            Destroy(gameObject);
        }

    }
            
  
}
