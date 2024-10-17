using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text Text;
    private int totalScore;


    // Start is called before the first frame update
    void Start()
    {
        Bullets.GainScore += takeScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void takeScore()
    {
        addedScore(10);
    }

    void addedScore(int score)
    {
        totalScore += score;
        Text.text = "Score: " + totalScore;
    }
}
