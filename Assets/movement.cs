using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody body;
    private float spd = 2.0f;
    private bool[] keys = {false,false,false,false, false,false, false,false};

    // Start is called before the first frame update
    void Start()
    {
        body.angularVelocity += Vector3.up * (70.0f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        #region input
        if (Input.GetKeyDown(KeyCode.A)){keys[0] = true;}
        if (Input.GetKeyUp(KeyCode.A))  {keys[0] = false;}

        if (Input.GetKeyDown(KeyCode.D)){keys[1] = true;}
        if (Input.GetKeyUp(KeyCode.D))  {keys[1] = false;}

        if (Input.GetKeyDown(KeyCode.W)){keys[2] = true;}
        if (Input.GetKeyUp(KeyCode.W))  {keys[2] = false;}

        if (Input.GetKeyDown(KeyCode.S)){keys[3] = true;}
        if (Input.GetKeyUp(KeyCode.S))  {keys[3] = false;}

        if (Input.GetKeyDown(KeyCode.Q)){keys[4] = true;}
        if (Input.GetKeyUp(KeyCode.Q))  {keys[4] = false;}

        if (Input.GetKeyDown(KeyCode.E)){keys[5] = true;}
        if (Input.GetKeyUp(KeyCode.E))  {keys[5] = false;}

        if (Input.GetKeyDown(KeyCode.Z)){keys[6] = true;}
        if (Input.GetKeyUp(KeyCode.Z))  {keys[6] = false;}

        if (Input.GetKeyDown(KeyCode.X)){keys[7] = true;}
        if (Input.GetKeyUp(KeyCode.X))  {keys[7] = false;}
        #endregion

        if (keys[0]) //A
        {
            body.velocity += Vector3.left * spd * Time.deltaTime;
        }
        if (keys[1]) //D
        {
            body.velocity += Vector3.right * spd * Time.deltaTime;
        }
        if (keys[2]) //W
        {
            body.velocity += Vector3.forward * spd * Time.deltaTime;
        }
        if (keys[3]) //S
        {
            body.velocity += Vector3.back * spd * Time.deltaTime;
        }
        if (keys[4]) //Q
        {   
            body.angularVelocity += Vector3.up * spd * Time.deltaTime;
        }
        if (keys[5]) //E
        {   
            body.angularVelocity += Vector3.down * spd * Time.deltaTime;
        }
        if (keys[6]) //Z
        {   
            body.velocity += Vector3.up * spd * Time.deltaTime;
        }
        if (keys[7]) //X
        {   
            body.velocity += Vector3.down * spd * Time.deltaTime;
        }

    }
}
