using UnityEngine;
using UnityEngine.UI;

public class DecreasePointsButton : MonoBehaviour
{
    public Text pointsText;
    public IncreasePointsButton increasePointsButton;

    public void OnDecreasePointsButtonClicked()
    {
        int points = IncreasePointsButton.GetPoints();
        if (points > 0)
        {
            points--;
            IncreasePointsButton.SetPoints(points);
            pointsText.text = points.ToString();
        }
    }
}





