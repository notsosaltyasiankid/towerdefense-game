using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Wave : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;

    private float firstWave = 10;

    private float spawnerTimer = 2f;

    private float waveTimer = 10f;

    private bool spawn = true;

    [SerializeField] private List<Transform> pathList = new List<Transform>();
    public List<Transform> PathList
    {
        get
        {
            return pathList;
        }
    }
    private List<GameObject> wave = new List<GameObject>();
    void Start()
    {
        StartCoroutine(createWave());
    }
    private void Update()
    {
        if (spawnerTimer > 0.3f)
        {
            spawnerTimer -= 0.0001f;
        }
        if (waveTimer > 0.2f)
        {
            waveTimer -= 0.0008f;
        }

    }
    IEnumerator createWave()
    {
        while (spawn)
        {
            for (int i = 0; i < firstWave; i++)
            {
                yield return new WaitForSeconds(spawnerTimer);
                GameObject newEnemy = Instantiate(Prefab);
                wave.Add(newEnemy);
                newEnemy.GetComponent<Enemy>().Targets = pathList;
            }
            yield return new WaitForSeconds(waveTimer);
        }


    }
}
