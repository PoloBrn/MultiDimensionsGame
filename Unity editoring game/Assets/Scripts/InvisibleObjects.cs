using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleObjects : MonoBehaviour
{
    public GameObject objectToHide;

    void Update()
    {
        if (CameraChange.Instance.currentmode == CameraChange.Mode.second)
        {
            objectToHide.SetActive(false);
            objectToHide.GetComponent<Collider>().enabled = true;
        }
        else
        {
            objectToHide.SetActive(true);
        }
    }
}
