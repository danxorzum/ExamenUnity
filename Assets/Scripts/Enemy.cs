using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Enemy : MonoBehaviour
{
    public float speed=2;
    public bool isRed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (isRed && transform.position.y < -4)
            SceneManager.LoadScene("Examen");
        if (transform.position.y < -4) ResetPosition();
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(Random.Range(-15f,18f), 8, 0);
    }

    virtual public void DoSomething() { }
}
