using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded=true;
    public float gameDelay = 2f;
    public void EndGame()
    {
        if (isGameEnded)
        {
            isGameEnded = false;
            print("Game ended");
            Invoke(nameof(Restart), gameDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
