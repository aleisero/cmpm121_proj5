using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody capsuleBody;
    private float acc = 10f;
    //private float maxSpeed = 25f;
    private bool firstPOV = true;

    private void Start()
    {
        capsuleBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //https://docs.unity3d.com/ScriptReference/Input.GetAxis.html

        if (Input.GetAxis("Vertical") < 0)
        {
            //backwards
            capsuleBody.AddForce(transform.forward * -acc);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            //forward
            capsuleBody.AddForce(transform.forward * acc);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            //left
            capsuleBody.AddForce(transform.right * -acc);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            //right
            capsuleBody.AddForce(transform.right * acc);
        }

        //camera controls - rotate capsule
        //A to rotate camera left 
        //D to rotate camera
        if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - Mathf.PI - 0.2f, transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + Mathf.PI + 0.2f, transform.eulerAngles.z);
        }

    }
}
