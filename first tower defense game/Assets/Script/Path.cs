using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public GameObject Prefab;

    private float firstWave = 10;

    [SerializeField] public List<Transform> pathList = new List<Transform>();

    private List<GameObject> Wave = new List<GameObject>();

    // Start is called before the first frame update
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
            newEnemy.GetComponent<Enemy>().targets = pathList;
            yield return new WaitForSeconds (1f);

        }
      
    }
}
