using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEvent : MonoBehaviour {
    public Text GameScore = null;
    public string tmp_gamescore;

    // Use this for initialization
    void Start() {
        GameScore_Manager(100);
    }
    public void GameScore_Manager(int sc)
    {
        tmp_gamescore = sc.ToString();
        GameScore.text = "Game Score: " + tmp_gamescore;
    }
}