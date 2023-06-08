using UnityEngine;
using System.Collections;

public class CameraAnimation : MonoBehaviour
{
    public CapsuleCollider capsuleCollider;
    public new Animation animation;
    public float delay = 0.5f;
    private bool condition = false;
    public new Camera camera;
    public Camera playerCam;

    void Start()
    {
        camera.enabled = false;
    }

    private void Update()
    {
        PlayAnimation();
    }

    private void PlayAnimation()
    {
        if (capsuleCollider.CompareTag("InterractUI") && condition == false && Input.GetKeyDown(KeyCode.E))
        {
            playerCam.enabled = false;
            camera.enabled = true;
            animation.Play();
            condition = true;
        }
        if (condition && !animation.isPlaying)
        {
            playerCam.enabled = true;
            camera.enabled = false;
            condition = false;
        }
    }
}
