using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;

public class MainMenuScript : MonoBehaviour
{

    public TMP_InputField userInput;
    public TextMeshProUGUI welcomeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OnButtonClick()
    {
        welcomeText.text = "Welcome " + userInput.text;
    }
    
}
