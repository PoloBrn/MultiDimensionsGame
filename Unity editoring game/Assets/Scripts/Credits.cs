using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    private float scrollSpeed = 1f; // vitesse de d�filement des cr�dits
    private RectTransform creditsRectTransform; // r�f�rence au RectTransform du Canvas des cr�dits

    private void Start()
    {
        creditsRectTransform = GetComponentInChildren<RectTransform>(); // obtenir la r�f�rence au RectTransform du Canvas des cr�dits
    }

    private void Update()
    {
        // d�placer le RectTransform du Canvas des cr�dits verticalement en fonction de la vitesse de d�filement
        creditsRectTransform.Translate(Vector3.up * Time.deltaTime * scrollSpeed);
    }
}
