using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    public Rigidbody body;
    public Transform player;
    public Vector3 offset;
    private float x_,y_,z_;
    //public float wtf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_ = offset.x;//(2f)*(body.velocity.y/5f);
        y_ = offset.y;//offset.y*(body.velocity.y/5f);
        z_ = offset.z;//offset.z;

        //wtf = y_;

        transform.position = new Vector3 (player.position.x + x_, player.position.y + y_, player.position.z + z_);
    }
}
