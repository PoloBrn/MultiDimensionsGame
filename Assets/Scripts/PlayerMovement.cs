using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 10;

    public Vector3 playerPosition;
    public Vector3 playerBackup;
    private Vector3 lastPlatformPosition;

    public float jumpHeight = 5f;
    public bool isGrounded;

 void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, 1f);
    }

    void Update()
    {
        Vector3 playerPosition = transform.position;
        if (CameraChange.Instance.currentmode != CameraChange.Mode.second)
        {   
            Vector3 position = transform.position;
            position.z = 0;
            transform.position = position;
        }
        if (CameraChange.Instance.currentmode != CameraChange.Mode.prem && Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        }

        if (CameraChange.Instance.currentmode != CameraChange.Mode.prem &&Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, - walkSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(- walkSpeed * Time.deltaTime, 0, 0);
        }
        //Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
        // Vérifier si le joueur est sur une plateforme et mettre à jour sa position sur l'axe z
        if (transform.parent != null && transform.parent.position != lastPlatformPosition) 
        {
            transform.position += transform.parent.position - lastPlatformPosition;
            transform.position = transform.parent.position;
            transform.position += new Vector3(0,1,0); //Correction de trajectoire sur l'axe y afin qu'il ne soit pas dans le composant parent 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Mettre le joueur en tant qu'enfant de la plateforme lorsqu'il la touche
        if (collision.gameObject.tag == "Ground") 
        {
            transform.parent = collision.transform;
            lastPlatformPosition = collision.transform.position;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Retirer le joueur de l'enfant de la plateforme lorsqu'il la quitte
        if (collision.gameObject.tag == "Ground") 
        {
            transform.parent = null;
        }
    }
}
