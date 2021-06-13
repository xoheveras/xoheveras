using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BaseDateMeneger;

public class SignInMeneger : MonoBehaviour
{
    [Header("Login InputField")]
    public InputField LoginName;
    public InputField LoginPass;
    [Header("Registration InputField")]
    public InputField RegName;
    public InputField RegPass;

    public void ClickLoginBtn()
    {  
        Debug.Log("Кнопка нажата");
        Debug.Log(LoginName.text);
        Debug.Log(LoginPass.text);
    }

    public void ClickRegistrationBtn()
    {  
        Debug.Log("Кнопка нажата");
        Debug.Log(RegName.text);
        Debug.Log(RegPass.text);
    }
}
