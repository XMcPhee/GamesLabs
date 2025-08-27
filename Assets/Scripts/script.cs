using UnityEngine;
using TMPro;

public class WelcomeScript : MonoBehaviour
{

    public TMP_InputField userName;
    public TextMeshProUGUI textField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OnButtonClick()
    {
        textField.text = "Welcome " + userName.text;
    }
    
}
