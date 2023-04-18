using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject scriptref;
    public bool listening;
    public VoiceChoices vcscript;
    public string word = "";

    public GameObject BeachAudioPlayer;
    public GameObject CarnivalAudioPlayer;
    public GameObject CampingAudioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        BeachAudioPlayer.SetActive(false);
        CarnivalAudioPlayer.SetActive(false);
        CampingAudioPlayer.SetActive(false);
        vcscript = scriptref.GetComponent<VoiceChoices>();
        
    }

    // Update is called once per frame
    void Update()
    {
        word = vcscript.word;
        switch (word)
        {
            case "Beach":
                BeachAudioPlayer.SetActive(true);
                break;
            case "Carnival":
                CarnivalAudioPlayer.SetActive(true);
                break;
            case "Camping":
                CampingAudioPlayer.SetActive(true);
                break;
            default:
                break;
        }
    }
}
