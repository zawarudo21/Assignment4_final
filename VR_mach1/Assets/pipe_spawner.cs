using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spwaner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawn_pipe();   
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn_pipe();
            timer = 0;
        }
    }

    void spawn_pipe()
    {
        float random_offset = Random.Range(transform.position.y - 2, transform.position.y + 2);
        Instantiate(Pipe, new Vector3(transform.position.x, random_offset, transform.position.z), transform.rotation);
    }

}
