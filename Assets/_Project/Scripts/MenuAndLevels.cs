using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuAndLevels : MonoBehaviour
{
    private void StartGame()
    {
        SceneManager.LoadScene("Grass");
    }
    private void QuitGame()
    {
        Application.Quit();
    }
    private void LevelChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelChange();
        }
    }
}
