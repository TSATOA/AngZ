using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField inputField_ID;
    public Button Button_Login;

    private string user = "User";

    public string sceneName;
    public void LoginButtonClick()
    {
        if(inputField_ID.text == user) //추후 중복 아이디 확인 코드 작성
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
