using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private InputField nameInputField;
    public Dropdown LivesDropdown;
    public Slider slider;

    private void Start()
    {
        // Load the player's name from PlayerPrefs
        string playerName = PlayerPrefs.GetString("PlayerName");
        if (!string.IsNullOrEmpty(playerName))
        {
            nameInputField.text = playerName;
        }
    }

    public void OnPlayButtonClicked()
    {
        // Saving the player's name to PlayerPrefs
        PlayerPrefs.SetString("PlayerName", nameInputField.text);

        // Saving the slider value to PlayerPrefs
        PlayerPrefs.SetFloat("TimerValue", slider.value);

        // Get the selected number of lives from the dropdown
        int lives = LivesDropdown.value + 1;

        // Save the selected number of lives to the PlayerPrefs
        PlayerPrefs.SetInt("Lives", lives);

        // Load the game scene
        SceneManager.LoadScene("2Game");
    }
}

