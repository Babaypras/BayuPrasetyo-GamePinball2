using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text text;

    public Scoring scoring;
    private void Update()
    {
        text.text = scoring.score.ToString();
        
    }

}
