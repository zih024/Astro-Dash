using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public SpiralCamera cameraSpiral;
    private int nextSpiralScore = 10;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
        if (playerScore >= nextSpiralScore && !cameraSpiral.IsSpinning())
        {   
            cameraSpiral.StartCoroutine(cameraSpiral.TemporarySpiral(1));
            nextSpiralScore += 10;
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnScript>().StopSpawning();

        PipeMoves[] pipes = Object.FindObjectsByType<PipeMoves>(FindObjectsSortMode.None);
        foreach(PipeMoves pipe in pipes)
        {
            Destroy(pipe.gameObject);
        }
    }

}
