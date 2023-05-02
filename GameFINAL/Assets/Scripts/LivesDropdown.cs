using UnityEngine;
using UnityEngine.UI;

public class LivesDropdown : MonoBehaviour
{
    public Dropdown dropdown;

    void Start()
    {
        dropdown.ClearOptions(); // Clear the current options

        // Add options for numbers 1-9
        for (int i = 1; i <= 9; i++)
        {
            dropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        }

        // Set the default value to 3
        dropdown.value = 2;
    }

    public void OnValueChanged()
    {
        // Save the selected value to PlayerPrefs
        int lives = dropdown.value + 1;
        PlayerPrefs.SetInt("Lives", lives);
    }
}

