using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPlayer : MonoBehaviour
{
    public Transform right;
    public Transform left;

    public void Start()
    {
        ///m_upperLimit = GameManager.instance.UpperLimit;
       // m_bottomLimit = GameManager.instance.BottomLimit;
    }

    private void LateUpdate()
    {

        if (transform.position.x < left.position.x)
        {
            transform.position =  new Vector3(left.position.x,transform.position.y,transform.position.z);
        }
        else if (transform.position.x > right.position.x)
        {
            transform.position =  new Vector3(right.position.x,transform.position.y,transform.position.z);
        }
  
    }
}
