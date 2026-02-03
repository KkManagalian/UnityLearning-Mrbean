using System;
using System.Collections;
using UnityEngine;

public class DonutDropper : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float bakeInterval = 1.0f;
    float minPoz, maxPoz;
    Transform ovenTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ovenTransform = GetComponent<Transform>();
    }

    public void BakeDonut(bool state)
    {
        if (state)
            StartCoroutine(Bake());
        else
            StopAllCoroutines();
    }

    IEnumerator Bake()
    {
        while (true){
            minPoz = ovenTransform.position.x - 40.0f;
            maxPoz = ovenTransform.position.x + 40.0f;
            float randPoz = UnityEngine.Random.Range(minPoz, maxPoz);
            Vector2 spawnPoz = new Vector2(randPoz, ovenTransform.position.y);

            int donutIndex = UnityEngine.Random.Range(0, donutPrefabs.Length);
            Instantiate(donutPrefabs[donutIndex], spawnPoz, Quaternion.identity, ovenTransform);
            yield return new WaitForSeconds(bakeInterval);
        }
    }
}
