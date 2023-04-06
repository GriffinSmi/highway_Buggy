using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public float leftRightSpeed = 5.0f;


    public float speed = 10.0f;
    [SerializeField] private float maxSpeed;
    public TextMeshProUGUI scoreText;
    //public GameObject winTextObject;

    private Rigidbody rb;
    //private int score;
    private float horizontalMovement;
    private float verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //score = 0;
        
        //SetScoreText();
        //winTextObject.SetActive(false);
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

// ----------------------------------------------------------------------------------------------------------------------------------------------------
// Scoring somewhat like the roll a ball project
// ----------------------------------------------------------------------------------------------------------------------------------------------------

    // void SetScoreText()
    // {
    //     scoreText.text = "Score: " + score.ToString();
    //     if(score >= 19)
    //     {
    //         winTextObject.SetActive(true);
    //     }
    // }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Mouse Y") > 0)
        {
            if (this.gameObject.transform.position.x > levelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetAxis("Mouse Y") < 0)
        {
            if (this.gameObject.transform.position.x < levelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }


        //--------------------------------------------------------------------------------------------------------
        //Might not need this vvvvvv

        //horizontalMovement = (Input.GetAxis("Mouse Y"));
        //verticalMovement = Input.GetAxis("Vertical");

        //Vector3 movementDirection = (transform.forward * -verticalMovement + transform.right * -horizontalMovement).normalized;

        //rb.AddForce(movementDirection * speed, ForceMode.Force);
        //--------------------------------------------------------------------------------------------------------
        
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.CompareTag("PickUp"))
    //     {
    //         other.gameObject.SetActive(false);
    //         score = score + 1;

    //         SetScoreText();
    //     }

    // }
}
