using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    private float countdownTime = 0f;

    private void Start()
    {
        countdownTime = PlayerPrefs.GetFloat("countdownTime", 60f);
        SetTimerText(countdownTime);
    }

    private void Update()
    {
        countdownTime -= Time.deltaTime;
        if (countdownTime <= 0f)
        {
            countdownTime = 0f;
            // Handle timer expired
        }
        SetTimerText(countdownTime);
    }

    private void SetTimerText(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}


