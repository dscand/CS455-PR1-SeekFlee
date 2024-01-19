using UnityEngine;
using TMPro;

public class UiScore : MonoBehaviour
{

    public Transform Player;
    public TextMeshProUGUI Score;

    void Update()
    {
        Score.text = Player.position.z.ToString("0");
    }
}
