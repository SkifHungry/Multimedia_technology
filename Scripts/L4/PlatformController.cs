using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject[] Prefabs = new GameObject[4];
    
    public float speed = 4f;

    //bool is_ground;
    //bool ismove;
    //Rigidbody player;         
    //public float force = 250;
    //public float forceL = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Rigidbody>();
    }

    //public void Jump()
    //{
    //    Ray ray = new Ray(gameObject.transform.position, Vector3.down);
    //    RaycastHit rh;
    //    if (Physics.Raycast(ray, out rh, 0.25f))
    //    {
    //        is_ground = true;
    //    }
    //    else
    //    {
    //        is_ground = false;
    //    }

    //    if (Input.GetKeyDown(KeyCode.Space) && is_ground)
    //    {
    //        player.AddForce(Vector3.up * force);
    //    }
    //}

    //public void Move()
    //{
    //    if (transform.position.z >= -0.45f && transform.position.z <= 0.45f)
    //    {
    //        if (Input.GetKeyDown(KeyCode.LeftArrow))
    //        {
    //            player.AddForce(Vector3.forward * forceL);
    //        }

    //        if (Input.GetKeyDown(KeyCode.RightArrow))
    //        {
    //            player.AddForce(Vector3.back * forceL);
    //        }
    //    }

        
    //}

    // Update is called once per frame
    void Update()
    {
        GameObject[] Platforms = GameObject.FindGameObjectsWithTag("Platform");
        
        for (int i = 0; i < Platforms.Length; i++)
        {
            Platforms[i].transform.position = new Vector3(Platforms[i].transform.position.x - (Time.deltaTime * speed), 0f);
            if (Platforms[i].transform.position.x < -11.4f)
            {
                Destroy(Platforms[i]);
                Instantiate(Prefabs[Random.Range(0, 3)], new Vector3(14.965f, 0f, 0f), transform.rotation);
            }
        }

        //Jump();
        //Move();
    }
}
