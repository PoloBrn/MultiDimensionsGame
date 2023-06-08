using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public new GameObject camera;

    void Start()
    {
        camera.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        camera.transform.rotation = Quaternion.AngleAxis(90f, Vector3.right);
    }


    void Update()
    {
        if (CameraChange.Instance.currentmode == CameraChange.Mode.prem)
        {
            Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
            camera.transform.position = new Vector3(playerPos.x, playerPos.y + 10f, playerPos.z);
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(90f, 0, 0), Time.deltaTime);
        }

        if (CameraChange.Instance.currentmode == CameraChange.Mode.second)
        {
            Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
            camera.transform.position = new Vector3(playerPos.x, playerPos.y + 1f, playerPos.z -10f);
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
        }

    }
}
