using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : PCInputs
{
    public Vector2 m_speed = new Vector2(10.0f, 10.0f);

    private InputHandler m_input;

    void Awake()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        m_input = gameObject.AddComponent<PCInputs>();
#elif UNITY_ANDRIOD || UNITY_IOS
        m_input = gameObject.AddComponent<TouchInputs>();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        if (m_input == null) return;
        transform.Translate(new Vector3(m_input.GetAxis.x * (m_speed.x * Time.deltaTime),
             m_input.GetAxis.y * (m_speed.y * Time.deltaTime), 0));
    }
}
