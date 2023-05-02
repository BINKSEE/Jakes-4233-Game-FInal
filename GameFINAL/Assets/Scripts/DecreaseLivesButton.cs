using UnityEngine;
using UnityEngine.UI;

public class DecreaseLivesButton : MonoBehaviour
{
    public Text LivesText;
    public IncreaseLivesButton increaseLivesButton;

    public void OnDecreaseLivesButtonClicked()
    {
        int Lives = IncreaseLivesButton.GetLives();
        if (Lives > 0)
        {
            Lives--;
            IncreaseLivesButton.SetLives(Lives);
            LivesText.text = Lives.ToString();
        }
    }
}
