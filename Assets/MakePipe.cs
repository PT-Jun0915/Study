using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDif;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeDif)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(2.0f, 9.0f), 0);
            timer = 0;
            Destroy(newpipe, 7.0f);
        }
    }
}
