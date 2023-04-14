using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Windows.Speech;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class VoiceChoices : MonoBehaviour
{
    public NPCConversation myConvo;
 

    public bool intro;
    public bool beach;
    public bool camp;
    public bool carn;
    public bool end;

    public GameObject theGuy;
    public TestVoiceDetection voiceScript;
    public GameObject[] choices = new GameObject[] { };
    protected string word = " ";



    // Start is called before the first frame update
    void Start()
    {
        voiceScript = theGuy.GetComponent<TestVoiceDetection>();
        ConversationManager.Instance.StartConversation(myConvo);

    }
 


    void Update()
    {
        word = voiceScript.myWord;
        choices = GameObject.FindGameObjectsWithTag("Choices");
        Debug.Log(choices.Length);

        if (choices.Length > 0)
        {
            Debug.Log("listening");
            if (word == "Beach")
            {
                Debug.Log("detected");
                Debug.Log(choices[0]);
                choices[0].GetComponent<Button>().onClick.Invoke();
                

            }
            if (word == "Carnival")
            {
                Debug.Log("detected");
                choices[1].GetComponent<Button>().onClick.Invoke();

            }



        }
    }
}
