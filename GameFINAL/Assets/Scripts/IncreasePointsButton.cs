using UnityEngine;
using UnityEngine.UI;

public class IncreasePointsButton : MonoBehaviour
{
    public Text pointsText;
    private int points = 0;

    private void Start()
    {
        points = PlayerPrefs.GetInt("Points", 0);
        pointsText.text = points.ToString();
    }

    public void OnIncreasePointsButtonClicked()
    {
        points++;
        pointsText.text = points.ToString();
        PlayerPrefs.SetInt("Points", points);
    }

    public static int GetPoints()
    {
        return PlayerPrefs.GetInt("Points", 0);
    }

    public static void SetPoints(int newPoints)
    {
        PlayerPrefs.SetInt("Points", newPoints);
    }
}




