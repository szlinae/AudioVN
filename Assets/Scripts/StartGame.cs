using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;
public class StartGame : MonoBehaviour
{
    public string[] keywords = new string[] { "Start" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 1;

    public TextMeshProUGUI results;
    public string myWord;
    public GameObject loading;


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
        // results.text = "You said: <b>" + word + "</b>";
    }

    private void Update()
    {
        if (word == "Start")
        {
            loading.SetActive(true);
            SceneManager.LoadScene("gameScene");

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
