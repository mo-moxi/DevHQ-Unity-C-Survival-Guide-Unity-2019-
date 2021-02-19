using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[System.Serializable]
public class CatFact
{
    public string fact;
    public int length;
}

public class DownloadCatFacts : MonoBehaviour
{
    [SerializeField] private string url;
    private Text _text;
    private IEnumerator Start()
    {
        _text = GetComponent<Text>();
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("Success!");
                Debug.Log("Data: " + request.downloadHandler.text);
                var json = request.downloadHandler.text;
                var catFact = JsonUtility.FromJson<CatFact>(json);
                _text.text = catFact.fact;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
