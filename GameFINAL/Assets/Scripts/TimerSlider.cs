using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        // Set the slider value to the previous selected time, if any
        if (PlayerPrefs.HasKey("SelectedTime"))
        {
            slider.value = PlayerPrefs.GetFloat("SelectedTime");
        }
        else
        {
            slider.value = 60f; // Default value
        }
    }

    public void SaveSelectedTime()
    {
        // Save the selected time to a PlayerPrefs key
        PlayerPrefs.SetFloat("SelectedTime", slider.value);
    }
}

