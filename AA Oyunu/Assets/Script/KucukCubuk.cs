using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk : MonoBehaviour
{
    Rigidbody2D rb;
    public float h�z;
    public bool hareketk�s�tl�m�;
    public GameObject y�netici;
    void Start()
    {
        y�netici = GameObject.FindGameObjectWithTag("Yonetici");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hareketk�s�tl�m� == false)
        {
            rb.MovePosition(rb.position + Vector2.up * h�z * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DonenBuyukCember")
        {
            transform.SetParent(col.transform);
            hareketk�s�tl�m� = true;
        }
        if (col.gameObject.tag == "KucukCember")
        {
            y�netici.GetComponent<OyununSonu>().OyunuBitir();
            Application.LoadLevel(1);
        }
    }
}