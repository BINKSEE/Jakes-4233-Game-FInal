using UnityEngine;
using UnityEngine.SceneManagement;

public class StopButton : MonoBehaviour
{
    public void OnStopButtonClicked()
    {
        SceneManager.LoadScene("3Exit");
    }
}

