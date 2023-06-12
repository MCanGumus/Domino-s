using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform karakter; // Takip edilecek karakterin referansý

    private Vector3 offset; // Kamera ile karakter arasýndaki baþlangýç mesafesi

    private void Start()
    {
        // Kamera ile karakter arasýndaki baþlangýç mesafesini kaydet
        offset = transform.position - karakter.position;
    }

    private void LateUpdate()
    {
        // Kameranýn karakterin pozisyonunu takip etmesi
        transform.position = karakter.position + offset;
    }
}
