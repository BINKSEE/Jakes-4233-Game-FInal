using UnityEngine;
using UnityEngine.UI;

public class PlayerNameText : MonoBehaviour
{
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        string playerName = PlayerPrefs.GetString("PlayerName");
        textComponent.text = "Currently playing: " + playerName;
    }
}


