using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text Text;
    private int totalScore = 50;

    public int TotalScore
    {
        get { return totalScore; }
    }


    // Start is called before the first frame update
    void Start()
    {
        Bullets.GainScore += takeScore;
        Text.text = "scrap: " + TotalScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void takeScore()
    {
        addedScore(10);
    }

    public void addedScore(int score)
    {
        totalScore += score;
        Text.text = "scrap: " + TotalScore;
    }
}
