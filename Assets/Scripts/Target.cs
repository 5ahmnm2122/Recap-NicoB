using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnMouseDown()
    {
        ScoreManager.instance.AddToScore();
        Destroy(this.gameObject);
    }
}
