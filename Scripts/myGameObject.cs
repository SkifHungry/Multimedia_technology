using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGameObject : MonoBehaviour
{
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ob1, new Vector3(-2.82f, 0.5f, 0f), transform.rotation);
        Instantiate(ob2, new Vector3(0.213643f, 0.5f, 0f), transform.rotation);
        Instantiate(ob3, new Vector3(2.8f, 0.5f, 0f), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
