using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;

    public GameObject player;

    public CanvasGroup exitBackgroundImageCanvasGroup;

    bool m_IsPlayerAtExit;

    float m_Timer;

    void Update()
    {
        if(m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject ==player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void EndLevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration; 
    }
}
