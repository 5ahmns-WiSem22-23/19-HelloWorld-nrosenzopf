using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HelloWorldUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TextMeshProUGUI finalText;

    public void LoadText()
    {
        finalText.text = inputText.text;
    }
}
