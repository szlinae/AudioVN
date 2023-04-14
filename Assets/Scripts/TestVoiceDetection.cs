using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class TestVoiceDetection : MonoBehaviour
{
    public string[] keywords = new string[] { "Beach", "Carnival", "Camping", "Nothing" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 1;

    public TextMeshProUGUI results;
    public string myWord;
  

    protected PhraseRecognizer recognizer;
    protected string word = " ";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log(recognizer.IsRunning);
        }

        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
    }

    private void Update()
    {
     

        switch (word)
        {
            case "Beach":
                Debug.Log("Beach");
                myWord = "Beach";
                break;
            case "Carnival":
                Debug.Log("Carnival");
                myWord = "Carnival";
                break;
            case "Camping":
                Debug.Log("Camping");
                myWord = "Camping";
                break;
            case "Nothing":
                Debug.Log("Nothing");
                myWord = "Nothing";
                break;
        }

        
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}

