using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public static int deaths = 0;
    public static DeathCounter instance;

    [SerializeField] private TextMeshProUGUI deathText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public static void AddDeath()
    {
        deaths++;
        instance.UpdateUI();
    }

    public static void ResetDeaths()
    {
        deaths = 0;
        instance.UpdateUI();
    }

    public void UpdateUI()
    {
        deathText.text = "Deaths: " + deaths;
    }
}