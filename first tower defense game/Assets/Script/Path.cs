using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Path : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;

    private float firstWave = 10;

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

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator createWave()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < firstWave; i++)
        {
            GameObject newEnemy = Instantiate(Prefab);
            Wave.Add(newEnemy);
            newEnemy.GetComponent<Enemy>().Targets = pathList;
            yield return new WaitForSeconds (1f);

        }
      
    }
}
