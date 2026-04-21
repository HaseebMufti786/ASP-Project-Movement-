using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DeathCounter.ResetDeaths();
 
            SceneManager.LoadScene(1);
        }
    }
}