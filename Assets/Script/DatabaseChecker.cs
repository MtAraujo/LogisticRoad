using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class DatabaseChecker : MonoBehaviour
{
    private const string URL = "https://desafio-4.onrender.com/signin";
    private const string API_KEY = "ENTER_YOUR_API_KEY_HERE";
    [SerializeField] private TMP_InputField m_email;
    [SerializeField] private TMP_InputField m_senha;

    public void ChecarCadastro()
    {
        StartCoroutine(ProcuraUsuarioNoBackEnd(URL));
    }

    private IEnumerator ProcuraUsuarioNoBackEnd(string uri)
    {
        string cadastroJSON = JsonUtility.ToJson(new CadastroJSON(m_email.text,m_senha.text));

        using (UnityWebRequest request = UnityWebRequest.Post(uri,cadastroJSON,"application/json")) 
        {   

            request.SetRequestHeader("APIKey", API_KEY);
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log(request.downloadHandler.text);
                SceneManager.LoadScene("Home");
            }
        }
    }
}

public class CadastroJSON
{
    public string email;
    public string password;

    public CadastroJSON(string newEmail, string newSenha)
    {
        email = newEmail;
        password = newSenha;
    }
}
