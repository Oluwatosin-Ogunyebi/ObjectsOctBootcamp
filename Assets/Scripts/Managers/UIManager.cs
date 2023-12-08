using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private TMP_Text highScoreTxt;
    [SerializeField] private TMP_Text healthTxt;

    [SerializeField] Player player;

    public void UpdateScore()
    {
        scoreTxt.SetText("Score " + GameManager.GetInstance().scoreManager.GetScore().ToString("00"));
        highScoreTxt.SetText("HighScore " + GameManager.GetInstance().scoreManager.GetHighScore().ToString("00"));
    }
}
