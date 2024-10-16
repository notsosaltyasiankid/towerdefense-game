using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]private GameObject prefab;
    public List<GameObject> enemy;
    private bool InRadius = false;
    private float timeElapsed;
    [SerializeField]private float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        InRadius = enemy.Count > 0;
        if (InRadius && timeElapsed > cooldown)
        {
            shoot();
            timeElapsed = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            enemy.Add(other.gameObject);
        }
    }
    void shoot()
    {
        Instantiate(prefab);
    }
}
