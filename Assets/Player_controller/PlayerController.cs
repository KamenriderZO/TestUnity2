using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded = true;
    private Transform player;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = transform;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.Translate(Vector3.forward * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.Translate(Vector3.back * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.Translate(Vector3.left * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.Translate(Vector3.right * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.Rotate(0f, -50f * Time.deltaTime, 0f,Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.Rotate(0f, 50f * Time.deltaTime, 0f, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 1000);    
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Table")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExist(Collision collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Table")
        {
            isGrounded = false;
        }
    }

}

