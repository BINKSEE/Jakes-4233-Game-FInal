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
            slider.value = 90f; // Default value of 90
        }
    }

    public void SaveSelectedTime()
    {
        // Save the selected time to a PlayerPrefs key
        PlayerPrefs.SetFloat("SelectedTime", slider.value);
        //couldnt get this to work. Couldnt load slider values
    }
}

