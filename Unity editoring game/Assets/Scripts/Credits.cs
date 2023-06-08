using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    private float scrollSpeed = 1f; // vitesse de défilement des crédits
    private RectTransform creditsRectTransform; // référence au RectTransform du Canvas des crédits

    private void Start()
    {
        creditsRectTransform = GetComponentInChildren<RectTransform>(); // obtenir la référence au RectTransform du Canvas des crédits
    }

    private void Update()
    {
        // déplacer le RectTransform du Canvas des crédits verticalement en fonction de la vitesse de défilement
        creditsRectTransform.Translate(Vector3.up * Time.deltaTime * scrollSpeed);
    }
}
