using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DefaultExecutionOrder(-10)]

public class PCInputs : InputHandler
{
    public  GameObject bullet;
    public float speed;
    public float cd = 0.4f;

    float _tcd;

    private void Start()
    {
        _tcd = Time.timeSinceLevelLoad;
    }
    void Update()
    {
        m_axis = new Vector2(Input.GetAxis("Horizontal"),0);
        m_fireButton = Input.GetButton("Jump");

        if (m_fireButton && _tcd+cd <  Time.timeSinceLevelLoad ) { 
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 180));
            _tcd = Time.timeSinceLevelLoad;
        }
            
        transform.Translate(m_axis * speed * Time.deltaTime);
    }
}
