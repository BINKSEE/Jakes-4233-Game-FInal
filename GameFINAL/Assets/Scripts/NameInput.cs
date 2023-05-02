using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField nameInputField;
    
    // This method is called when the 'PLAY' button is clicked in the intro scene
    public void OnPlayButtonClicked()
    {
        // Save the inputted name to PlayerPrefs
        PlayerPrefs.SetString("PlayerName", nameInputField.text);

        // Load the game scene
        SceneManager.LoadScene("2Game");
    }
}

