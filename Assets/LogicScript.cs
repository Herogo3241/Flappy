using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{



    public int playerScore;
    public Text ScoreText;
    public GameObject gameoverscreen;
    
    [ContextMenu("Increase score")]
    public void addscore(int scoreToadd)
    {

        playerScore = playerScore + scoreToadd;
        ScoreText.text = playerScore.ToString();



    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }







}
