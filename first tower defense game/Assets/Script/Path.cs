using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Path : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;

    private float firstWave = 10;

    private float spawnerTimer = 1f;

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

    private List<GameObject> Wave = new List<GameObject>();
    void Start()
    {
        StartCoroutine(createWave());
    }
    private void Update()
    {
        if (spawnerTimer > 0.2f)
        {
            spawnerTimer -= 0.01f;
        }
        if (waveTimer > 0.2f)
        {
            waveTimer -= 0.005f;
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
                Wave.Add(newEnemy);
                newEnemy.GetComponent<Enemy>().Targets = pathList;
            }
            yield return new WaitForSeconds(waveTimer);
        }


    }
}
