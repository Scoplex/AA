using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kameraanimasyon : MonoBehaviour
{
    private GameObject y�netici;
    Animator anim;
    void Start()
    {
        y�netici = GameObject.FindGameObjectWithTag("Yonetici");
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        
    }
}