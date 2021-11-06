using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Champi : MonoBehaviour
{
    public static int lives = 3;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            lives = 3;
            SceneManager.LoadScene("Examen");
        }
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -4) {
            transform.position = new Vector3(Random.Range(-15f, 18f), 8, 0);
            lives--; 
        }
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player") transform.position = new Vector3(Random.Range(-15f, 18f), 8, 0);
    }
}
