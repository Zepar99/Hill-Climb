using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver = false;
    [SerializeField] private GameObject GameoverUI;
    private CarController car;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            gameOver();
        }
    }

    private void gameOver()
    {
        GameIsOver = true;
        GameoverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    private void Restart()
    {
        GameIsOver = false;
        GameoverUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Quit()
    {
        Application.Quit();
    }
}
