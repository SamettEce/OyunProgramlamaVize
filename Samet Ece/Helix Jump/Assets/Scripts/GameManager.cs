using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void gameScore(int ringScore) { // top her halkadan geçtiğinde 25 puan yazdırılır
        score = ringScore;
        scoreText.text = score.ToString(); 
    }
    
    public void restartGame() { //top çarparsa sahneyi geri yükler oyyun yeniden başlar
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
