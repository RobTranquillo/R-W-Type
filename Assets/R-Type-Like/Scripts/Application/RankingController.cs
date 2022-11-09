using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class RankingController : MonoBehaviour
{
    public string domain = "https://rw-type.boogiedev.net/ranking/index.php";

#if UNITY_EDITOR
    public bool useTestingDomain = true;
    public string testingDomain = "https://rw-type.boogiedev.net/ranking/index.php";
#endif
#if UNITY_PLAYER
    bool useTestingDomain = false;
#endif

    public TMPro.TMP_Text playerName;
    public TMPro.TMP_Text playerScore;
    public TMPro.TMP_Text ranking;

    public int maxRankingPlaces = 8;

    private string _playerName = "";
    private PlayerScoreData playerScoreData;
    private InputKeyboard inputKeyboard;

    //#################################
    private class Player
    {
        public string name;
        public float score;
    }


    //#################################   

    private void OnEnable()
    {
        playerScoreData = FindObjectOfType<PlayerScoreData>();
        playerScore.text = "Score: " + playerScoreData.Score().ToString();
        LoadRanking();
    }

    public void WriteRankToDatabase()
    {        
        string request = $"{domain}?name={playerName.text}&score={playerScoreData.Score()}";
        StartCoroutine(GetRequest(request));
    }


    private void LoadRanking()
    {
        if (useTestingDomain)
            domain = testingDomain;
        StartCoroutine(GetRequest(domain));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    BuildPlayersList(webRequest.downloadHandler.text);               
                    break;
            }
        }
    }

    private void BuildPlayersList(string text)
    {
        List<string> lines = text.Split("\n").ToList();
        if (lines.Count > maxRankingPlaces)
            lines = lines.GetRange(0, maxRankingPlaces);

        ranking.text = "";
        foreach (string line in lines)
        {
            string[] fields = line.Split(":");
            if (fields.Length != 2)
                continue;
            ranking.text += $"{fields[0]} : {fields[1]}\n";
        }
    }
}
