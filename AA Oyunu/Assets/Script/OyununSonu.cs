using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyununSonu : MonoBehaviour
{
    public GameObject DönenBüyükÇember;
    public GameObject SpawnLokasyonu;
    public void OyunuBitir()
    {
        DönenBüyükÇember.GetComponent<DonenCember>().enabled = false;
        SpawnLokasyonu.GetComponent<KucukCubukSpawner>().enabled = false;
    }
}
