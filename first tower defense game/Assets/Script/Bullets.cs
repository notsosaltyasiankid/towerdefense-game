using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    private Enemy enemyHp;
    private Shooting shooting;

    private Transform towerTransform;

    private GameObject enemy;

    [SerializeField] private int damage;

    [SerializeField] private float speed;
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
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, speed * Time.deltaTime);
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
   
        }
    }
}
