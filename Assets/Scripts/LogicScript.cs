using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    [SerializeField] NumberField score;
    [SerializeField] GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int s)
    {
        score.AddNumber(s);
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
