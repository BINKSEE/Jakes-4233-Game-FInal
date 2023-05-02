using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    public void OnReplayButtonClicked()
    {
        // Set points to 0
        IncreasePointsButton.SetPoints(0);

        // Load the game scene
        SceneManager.LoadScene("2Game");
    }
}

