using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAxe : MonoBehaviour
{
    public Vector3 objectPosition;
    public Collision collision;
    public Vector3 Backup;

    void Start()
    {
        Vector3 objectPosition = transform.position;
        Backup = objectPosition;
    }

    void Update()
    {
        /*if(collision.CompareTag("Player"))
        {
            en gros faudra au début afficher d'appuyer sur la touche pour changer de DPour avant et après l'obstacle (tuto)
        }*/

        if (Camera.main.orthographic == true)
        {
            transform.position = new Vector3(Backup.x, Backup.y, 0);
        }

        if (Camera.main.orthographic == false)
        {
            transform.position = new Vector3 (Backup.x, Backup.y, Backup.z);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player") && other.transform.parent != transform.GetChild(0).parent)
        {
            other.transform.SetParent(transform.parent);
        }
    }
}
