using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public float rotationSpeed = 90f;  // Rotation speed
    public float moveSpeed = 5f;      // Movement speed
    public float jumpForce = 5f;      // Jump force
    public float scaleSpeed = 0.5f;   // Scale speed (how fast to increase/decrease size)

    private Vector3 originalPosition;  // Store original position
    private Vector3 originalScale;     // Store original scale
    private Quaternion originalRotation; // Store original rotation (using Quaternion)
    private bool isJumping = false;    // To check if the character is currently jumping

    private Rigidbody rb;              // Reference to Rigidbody for jumping

    void Start()
    {
        // Store the original position, scale, and rotation when the game starts
        originalPosition = transform.position;
        originalScale = transform.localScale;
        originalRotation = transform.rotation; // Save the original rotation
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component for jumping functionality
    }

    // Function to move the character down (along the Y-axis)
    public void MoveDown()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);  // Move down along Y-axis
    }

    // Function to move the character up (along the Y-axis)
    public void MoveUp()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.World);  // Move up along Y-axis
    }

    // Function to rotate the character to the right (clockwise)
    public void RotateRight()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);  // Rotate around Y-axis
    }

    // Function to rotate the character to the left (counterclockwise)
    public void RotateLeft()
    {
        transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);  // Rotate around Y-axis
    }

    // Function to decrease the character's position (move back along Z-axis)
    public void Decrease()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);  // Move back along Z-axis
    }

    // Function to increase the character's position (move forward along Z-axis)
    public void Increase()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);  // Move forward along Z-axis
    }

    // Function to move the character left (along the X-axis)
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.World);  // Move left along X-axis
    }

    // Function to move the character right (along the X-axis)
    public void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);  // Move right along X-axis
    }

    // Function to make the character jump (move up along Y-axis)
    public void Jump()
    {
        if (!isJumping)  // If the character is not already jumping
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  // Apply an upward force to simulate a jump
            isJumping = true;
        }
    }

    // Function to scale the character up (enlarge)
    public void IncreaseSize()
    {
        transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;  // Increase size
    }

    // Function to scale the character down (shrink)
    public void DecreaseSize()
    {
        transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;  // Decrease size
    }

    // Function to reset the position, scale, and rotation of the character
    public void ResetCharacter()
    {
        transform.position = originalPosition;        // Reset position to the original value
        transform.localScale = originalScale;         // Reset scale to the original value
        transform.rotation = originalRotation;       // Reset rotation to the original value
    }

    // Function to detect when the character touches the ground again (for jumping logic)
    void OnCollisionEnter(Collision collision)
    {
        // If the character touches the ground, they are no longer jumping
        if (collision.collider.CompareTag("Ground"))
        {
            isJumping = false;  // Reset the jumping flag when character touches the ground
        }
    }
}
