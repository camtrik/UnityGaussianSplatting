using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // translation
        transform.Translate(new Vector3(horizontalMove, 0, verticalMove));

        // rotation by mouse
        if (Input.GetMouseButton(1))
        {
            float horizontalRotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float verticalRotation = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, horizontalRotation);
            transform.Rotate(Vector3.left, verticalRotation);
        }

        // rotation by keyboard
        float horizontalKeyRotation = 0;
        float verticalKeyRotation = 0;
        float rollKeyRotation = 0;

        if (Input.GetKey(KeyCode.J)) // left
            horizontalKeyRotation = -rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.L)) // right
            horizontalKeyRotation = rotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.I)) // up
            verticalKeyRotation = rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.K)) // down
            verticalKeyRotation = -rotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.U)) // roll left
            rollKeyRotation = rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.O)) // roll right
            rollKeyRotation = -rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, horizontalKeyRotation);
        transform.Rotate(Vector3.left, verticalKeyRotation);
        transform.Rotate(Vector3.forward, rollKeyRotation);

    }
}
