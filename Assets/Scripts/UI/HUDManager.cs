using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI speedText;

    public void UpdateHP (int currentHP, int maxHP)
    {
        hpText.text = $"{currentHP} / {maxHP}";
    }

    public void UpdateSpeed(float currentSpeed)
    {
        speedText.text = $"{currentSpeed}";
    }

    


}
