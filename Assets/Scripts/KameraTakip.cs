using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform karakter; // Takip edilecek karakterin referans�

    private Vector3 offset; // Kamera ile karakter aras�ndaki ba�lang�� mesafesi

    private void Start()
    {
        // Kamera ile karakter aras�ndaki ba�lang�� mesafesini kaydet
        offset = transform.position - karakter.position;
    }

    private void LateUpdate()
    {
        // Kameran�n karakterin pozisyonunu takip etmesi
        transform.position = karakter.position + offset;
    }
}
