using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : Enemy
{
    
    private void Start()
    {
        if (isRed) speed /= 2;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        SceneManager.LoadScene("Examen");
    }


}
