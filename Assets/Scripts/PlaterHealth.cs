using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaterHealth : MonoBehaviour
{

    public int maxLives = 3;
    public int curentLives;

    public float invincibleTime = 1.0f;
    public bool isinvincible = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curentLives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            curentLives--;
            Destroy(other.gameObject);

            if (curentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("RestartGame", 3.0f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
