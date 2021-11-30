using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region singleton
    public static ScoreManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion

    [SerializeField]
    Text scoreTXT;
    [SerializeField]
    Text finishedTXT;
    int score;

    public void AddToScore()
    {
        score++;
        scoreTXT.text = score.ToString();
        // Finished
        if (score == 10)
        {
            finishedTXT.gameObject.SetActive(true);
            TargetSpawner.instance.StopAllCoroutines();
        }
    }
}
