using UnityEngine;

public class PlayerSelectorMovement : MonoBehaviour
{
    public Vector3 playerPosition;
    public Vector3 playerBackup;
    public float walkSpeed = 10;

    void Start()
    {
        // Masquer la souris
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -walkSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-walkSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        }
    }
}
