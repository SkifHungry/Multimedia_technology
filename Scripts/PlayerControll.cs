using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControll : MonoBehaviour
{
    private Animator myAnimator;
    private NavMeshAgent myAgent;
    bool is_ground;
    bool ismove;
    Rigidbody player;
    public float force = 250;
    public float forceL = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        player = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast(ray, out rh, 0.25f))
        {
            is_ground = true;
        }
        else
        {
            is_ground = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            player.AddForce(Vector3.up * force, ForceMode.Impulse);
            
            myAnimator.SetTrigger("HumanoidJumpUp");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.Play("Run");  
        Jump();
    }
}
