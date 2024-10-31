using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource ding;

    [ContextMenu("Increase Score")]
   public void addScore(int scoretoadd)
    {
        playerScore+=scoretoadd;
        scoreText.text = playerScore.ToString();
        ding.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("galbird");
    }

}
