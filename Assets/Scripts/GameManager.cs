using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [SerializeField]
    private Transform m_rightLimit, m_leftLimit;

    private LevelManager m_currentLevelManager;
    public GameObject UpperLimit => m_currentLevelManager.UpperLimit;
    public GameObject BottomLimit => m_currentLevelManager.BottomLimit;


    public Vector3 GetRightLimit
    {
        get { return m_rightLimit.position; }
    }
    public Vector3 GetLeftLimit
    {
        get { return m_leftLimit.position; }
    }
    

    public void LevelInitialization(LevelManager lm)
    {
        m_currentLevelManager = lm;
    }
    public void Start()
    {
        instance = this;
        
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
