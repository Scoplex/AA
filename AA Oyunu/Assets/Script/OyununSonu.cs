using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyununSonu : MonoBehaviour
{
    public GameObject D�nenB�y�k�ember;
    public GameObject SpawnLokasyonu;
    public void OyunuBitir()
    {
        D�nenB�y�k�ember.GetComponent<DonenCember>().enabled = false;
        SpawnLokasyonu.GetComponent<KucukCubukSpawner>().enabled = false;
    }
}
