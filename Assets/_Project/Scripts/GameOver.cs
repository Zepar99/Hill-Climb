using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver = false;
    [SerializeField] private GameObject GameoverUI;
    [SerializeField] private GameObject player;
    public CarController car;


    void update()
    {
        if (car != null)
        {
            Debug.Log(car.fuel);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Ground") || car.fuel <= 0)
        {
            GameIsOver = true;
            GameoverUI.SetActive(true);
            gameOver();
        }
    }

    private void gameOver()
    {
        GameIsOver = true;
        GameoverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        GameIsOver = false;
        GameoverUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
