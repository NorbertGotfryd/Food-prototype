using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;

    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI scoreText;
    public int scorePoints;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        scoreText.text = scorePoints.ToString();
        hpText.text = Player.instance.hpPoints.ToString();
    }


}
