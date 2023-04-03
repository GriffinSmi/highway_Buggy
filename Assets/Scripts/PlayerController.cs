using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    [SerializeField] private float maxSpeed;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    //private int count;
    private float horizontalMovement;
    private float verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //count = 0;
        
        //SetCountText();
        winTextObject.SetActive(false);
    }

    void Update()
    {
        Debug.Log(rb.velocity.magnitude);

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }


    // private void OnMove(InputValue movementValue)
    // {
    //     Vector2 movementVector = movementValue.Get<Vector2>();

    //     movementX = movementVector.x;
    //     movementY = movementVector.y;
    // }

    // void SetCountText()
    // {
    //     countText.text = "Count: " + count.ToString();
    //     if(count >= 19)
    //     {
    //         winTextObject.SetActive(true);
    //     }
    // }

    private void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        Vector3 movementDirection = (transform.forward * verticalMovement + transform.right * horizontalMovement).normalized;

        rb.AddForce(movementDirection * speed, ForceMode.Force);

        
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.CompareTag("PickUp"))
    //     {
    //         other.gameObject.SetActive(false);
    //         count = count + 1;

    //         SetCountText();
    //     }

    // }
}
