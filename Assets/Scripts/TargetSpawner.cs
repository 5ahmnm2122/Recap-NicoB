using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject targetPrefab;
    [SerializeField]
    Canvas mainCanvas;

    private void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        int posX = Random.Range(-Screen.width / 2, Screen.width / 2);
        int posY = Random.Range(-Screen.height / 2, Screen.height / 2);
        GameObject instance = Instantiate(targetPrefab, mainCanvas.transform);
        instance.GetComponent<RectTransform>().localPosition = new Vector2(posX, posY);
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnTarget());
    }

}
