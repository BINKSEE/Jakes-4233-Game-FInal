using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public Text LivesDisplay;

    private void Start()
    {
        // Get the selected number of lives from the PlayerPrefs
        int lives = PlayerPrefs.GetInt("SelectedLives", 3);

        // Update the lives text to display the selected number of lives
        LivesDisplay.text = lives.ToString();
    }
}


