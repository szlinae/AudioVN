using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using static Unity.Burst.Intrinsics.X86.Avx;
using TMPro;

public class ChoicesAppear : MonoBehaviour
{
    public GameObject scriptref;
    public bool listening;
    public VoiceChoices vcscript;
    public string word = "";

    public TextMeshProUGUI BeachText;
    public TextMeshProUGUI CarnivalText;
    public TextMeshProUGUI CampingText;
    public TextMeshProUGUI RainText;
    public TextMeshProUGUI SickText;
    public TextMeshProUGUI SeagullsText;
    public TextMeshProUGUI RollercoasterText;
    public TextMeshProUGUI FerriswheelText;
    public TextMeshProUGUI FoodText;
    public TextMeshProUGUI HikingText;
    public TextMeshProUGUI FishingText;
    public TextMeshProUGUI CampfireText;
    public TextMeshProUGUI NothingText;

    public GameObject beachTxt;
    public GameObject carnTxt;
    public GameObject campTxt;
    public GameObject rainTxt;
    public GameObject sickTxt;
    public GameObject seagullsTxt;
    public GameObject rollercoasterTxt;
    public GameObject ferriswheelTxt;
    public GameObject foodTxt;
    public GameObject hikingTxt;
    public GameObject fishingTxt;
    public GameObject campfireTxt;
    public GameObject nothingTxt;

    public float fadeTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        vcscript = scriptref.GetComponent<VoiceChoices>();
        beachTxt.SetActive(true);
        carnTxt.SetActive(true);
        campTxt.SetActive(true);
        rainTxt.SetActive(true);
        sickTxt.SetActive(true);
        seagullsTxt.SetActive(true);
        rollercoasterTxt.SetActive(true);
        ferriswheelTxt.SetActive(true);
        foodTxt.SetActive(true);
        hikingTxt.SetActive(true);
        fishingTxt.SetActive(true);
        campfireTxt.SetActive(true);
        nothingTxt.SetActive(true);


        BeachText.canvasRenderer.SetAlpha(0);
        CarnivalText.canvasRenderer.SetAlpha(0);
        CampingText.canvasRenderer.SetAlpha(0);
        RainText.canvasRenderer.SetAlpha(0);
        SickText.canvasRenderer.SetAlpha(0);
        SeagullsText.canvasRenderer.SetAlpha(0);
        RollercoasterText.canvasRenderer.SetAlpha(0);
        FerriswheelText.canvasRenderer.SetAlpha(0);
        FoodText.canvasRenderer.SetAlpha(0);
        HikingText.canvasRenderer.SetAlpha(0);
        FishingText.canvasRenderer.SetAlpha(0);
        CampfireText.canvasRenderer.SetAlpha(0);
        NothingText.canvasRenderer.SetAlpha(0);



    }

    // Update is called once per frame
    void Update()

    {
        listening = vcscript.choiceTime;
        word = vcscript.word;
        if (listening)
        {
            if (!vcscript.beach && !vcscript.carn && !vcscript.camp)
            {
                StartCoroutine(FirstChoicesAppear());


            }
            if (vcscript.beach)
            {
                StartCoroutine(BeachChoicesAppear());


            }
            if (vcscript.carn)
            {
                StartCoroutine(CarnChoicesAppear());


            }
            if (vcscript.camp)
            {
                StartCoroutine(CampChoicesAppear());


            }


        }
        if (vcscript.beach || vcscript.carn || vcscript.camp)
        {
            beachTxt.SetActive(false);
            carnTxt.SetActive(false);
            campTxt.SetActive(false);

            BeachText.canvasRenderer.SetAlpha(0);
            CarnivalText.canvasRenderer.SetAlpha(0);
            CampingText.canvasRenderer.SetAlpha(0);

        }
        if (vcscript.beach1 || vcscript.beach2 || vcscript.beach3)
        {
            seagullsTxt.SetActive(false);
            rainTxt.SetActive(false);
            sickTxt.SetActive(false);

            BeachText.canvasRenderer.SetAlpha(0);
            CarnivalText.canvasRenderer.SetAlpha(0);
            CampingText.canvasRenderer.SetAlpha(0);

        }

        IEnumerator FirstChoicesAppear()
        {
            yield return new WaitForSeconds(5);
            BeachText.CrossFadeAlpha(1.0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampingText.CrossFadeAlpha(1.0f, fadeTime, false);
        }

        IEnumerator BeachChoicesAppear()
        {
            yield return new WaitForSeconds(5);
            SickText.CrossFadeAlpha(1.0f, fadeTime, false);
            SeagullsText.CrossFadeAlpha(1.0f, fadeTime, false);
            RainText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        IEnumerator CarnChoicesAppear()
        {
            yield return new WaitForSeconds(5);
            RollercoasterText.CrossFadeAlpha(1.0f, fadeTime, false);
            FerriswheelText.CrossFadeAlpha(1.0f, fadeTime, false);
            FoodText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        IEnumerator CampChoicesAppear()
        {
            yield return new WaitForSeconds(5);
            HikingText.CrossFadeAlpha(1.0f, fadeTime, false);
            FishingText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampfireText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
    }
}
