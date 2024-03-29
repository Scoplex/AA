using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kameraanimasyon : MonoBehaviour
{
    private GameObject yönetici;
    Animator anim;
    void Start()
    {
        yönetici = GameObject.FindGameObjectWithTag("Yonetici");
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        
    }
}