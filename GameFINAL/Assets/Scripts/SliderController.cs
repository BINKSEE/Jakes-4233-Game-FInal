using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider timerSlider;

    private void Start()
    {
        timerSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        PlayerPrefs.SetFloat("countdownTime", value);
    }
}

