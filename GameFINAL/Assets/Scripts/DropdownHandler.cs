using UnityEngine;
using UnityEngine.UI;


public class DropdownHandler : MonoBehaviour
{
    public Dropdown dropdown;

    public void Start()
    {
        // Add listener to the dropdown component
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    public void OnDropdownValueChanged(int value)
    {
        // Save the selected value to PlayerPrefs
        PlayerPrefs.SetInt("SelectedLives", (value + 1));
        PlayerPrefs.Save();

        // Print the saved value to the console for debugging
        Debug.Log("Selected Lives: " + (value + 1));
    }
}



