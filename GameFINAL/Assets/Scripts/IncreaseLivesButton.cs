using UnityEngine;
using UnityEngine.UI;

public class IncreaseLivesButton : MonoBehaviour
{
    public Text LivesText;
    private static int Lives = 0;

    private void Start()
    {
        // Get the selected number of lives from the PlayerPrefs
        int selectedLives = PlayerPrefs.GetInt("SelectedLives", 3);

        // Set the starting number of lives to the selected number of lives
        Lives = selectedLives;

        LivesText.text = Lives.ToString();
    }

    public void OnIncreaseLivesButtonClicked()
    {
        Lives++;
        LivesText.text = Lives.ToString();
    }

    public static int GetLives()
    {
        return Lives;
    }

    public static void SetLives(int newLives)
    {
        Lives = newLives;
    }
}

