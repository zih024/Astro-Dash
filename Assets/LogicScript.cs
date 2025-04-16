using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnScript>().StopSpawning();

        PipeMoves[] pipes = FindObjectsOfType<PipeMoves>();
        foreach(PipeMoves pipe in pipes)
        {
            Destroy(pipe.gameObject);
        }
    }

}
