using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    private Enemy enemyHp;
    private Shooting shooting;

    private Transform towerTransform;

    private GameObject enemy;

    private Transform lastPos;

    [SerializeField] private int damage;

    [SerializeField] private float speed;

    public static event Action GainScore;
    // Start is called before the first frame update
    void Start()
    {
        towerTransform = gameObject.transform.parent.transform;
        shooting = towerTransform.GetComponent<Shooting>();
        enemy = towerTransform.GetComponent<Shooting>().enemy[0].gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            transform.position = Vector3.MoveTowards(transform.position, lastPos.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, lastPos.position) >= 0.3)
            {
                Destroy(gameObject);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, speed * Time.deltaTime);

        lastPos = enemy.transform;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        enemyHp = other.GetComponent<Enemy>();
        if (other.CompareTag("enemy"))
        {
            enemyHp.EnemyHealth(damage);
            Destroy(gameObject);
        }
        if (enemyHp.health <= 0)
        {
            shooting.enemy.Remove(other.gameObject);
            Destroy(other.gameObject);
            GainScore?.Invoke();
        }
        
    }
}
