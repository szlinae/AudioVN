using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public Sprite[] Images;
    public SpriteRenderer backgroundIMG;
    public GameObject theGuy;
    public TestVoiceDetection voiceScript;
    public string theWord; 

    // Start is called before the first frame update
    void Start()
    {
        voiceScript = theGuy.GetComponent<TestVoiceDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        
        theWord = voiceScript.myWord;
          switch (theWord)
        {
            case "Beach":
                break;
            case "Carnival":
                break;
            case "Camping":
                break;
            case "Nothing":
                break;
        }
    }
}
