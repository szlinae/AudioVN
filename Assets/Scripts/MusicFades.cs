using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFades : MonoBehaviour
{
    public VoiceChoices voiceChoices;
    public GameObject currentBranch;
    public string current;
    public string theWord;

    public AudioClip beachNoise;
    public AudioClip carnivalNoise;
    public AudioClip campingNoise;

    void Start()
    {

    }


    void Update()
    {
        current = voiceChoices.currentBranch;
        if (theWord != voiceChoices.currentBranch)
        {
            theWord = voiceChoices.currentBranch;
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
}
