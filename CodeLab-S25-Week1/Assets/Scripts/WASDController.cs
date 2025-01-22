using UnityEngine;

public class WASDController : MonoBehaviour
{
    public KeyCode keyUp = KeyCode.W;
    public KeyCode keyDown = KeyCode.S;
    public KeyCode keyLeft = KeyCode.A;
    public KeyCode keyRight = KeyCode.D;

    public Rigidbody rb;

    public float moveForce = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start!!!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update...");

        if (Input.GetKey(keyUp)) 
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKey(keyDown))
        {
            rb.AddForce(Vector3.back);
        }
        if (Input.GetKey(keyLeft)) 
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(keyRight))
        {
            rb.AddForce(Vector3.right);
        }
        
        
    }
}
