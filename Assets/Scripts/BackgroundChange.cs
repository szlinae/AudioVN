using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public GameObject intro;
    public GameObject car;

    public GameObject theGuy;
    public TestVoiceDetection voiceScript;
    public string theWord; 

    // Start is called before the first frame update
    void Start()
    {
        voiceScript = theGuy.GetComponent<TestVoiceDetection>();
        car.SetActive(false);
        intro.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        theWord = voiceScript.myWord;
          switch (theWord)
        {
            case "Beach":
                intro.SetActive(false);
                car.SetActive(true);
                break;
            case "Carnival":
                intro.SetActive(false);
                car.SetActive(true);
                break;
            case "Camping":
                intro.SetActive(false);
                car.SetActive(true);
                break;
            case "Nothing":
                car.SetActive(false);
                intro.SetActive(true);
                break;
        }
    }
}
