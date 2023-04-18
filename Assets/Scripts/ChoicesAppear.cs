using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using static Unity.Burst.Intrinsics.X86.Avx;
using TMPro;
using JetBrains.Annotations;

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
    public float initialFade = 0.001f;
    public Color invisible =Color.black;
    


    // Start is called before the first frame update
    void Start()
    {

        vcscript = scriptref.GetComponent<VoiceChoices>();
        invisible.a = 0f;


        BeachText.CrossFadeAlpha(0f, initialFade, false);
        CarnivalText.CrossFadeAlpha(0f, initialFade, false);
        CampingText.CrossFadeAlpha(0f, initialFade, false);
        RainText.CrossFadeAlpha(0f, initialFade, false);
        SickText.CrossFadeAlpha(0f, initialFade, false);
        SeagullsText.CrossFadeAlpha(0f, initialFade, false);
        RollercoasterText.CrossFadeAlpha(0f, initialFade, false);
        FerriswheelText.CrossFadeAlpha(0f, initialFade, false);
        FoodText.CrossFadeAlpha(0f, initialFade, false);
        HikingText.CrossFadeAlpha(0f, initialFade, false);
        FishingText.CrossFadeAlpha(0f, initialFade, false);
        CampfireText.CrossFadeAlpha(0f, initialFade, false);
        NothingText.CrossFadeAlpha(0f, initialFade, false);

        word = vcscript.word;
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





    }

    // Update is called once per frame
    void Update()

    {

        
        if (word == "Beach" || word == "Carnival" || word == "Camping" || word == "Nothing")
        {
             BeachText.CrossFadeAlpha(0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(0f, fadeTime, false);
            CampingText.CrossFadeAlpha(0f, fadeTime, false);
           NothingText.CrossFadeAlpha(0f, fadeTime, false);

            BeachText.canvasRenderer.SetAlpha(0);
            CarnivalText.canvasRenderer.SetAlpha(0);
            CampingText.canvasRenderer.SetAlpha(0);
            NothingText.canvasRenderer.SetAlpha(0);

        }
        if (word == "Seagulls" || word == "Rain" || word == "Sick")
        {
            SeagullsText.CrossFadeAlpha(0f, fadeTime, false);
            RainText.CrossFadeAlpha(0f, fadeTime, false);
            SickText.CrossFadeAlpha(0f, fadeTime, false);
            BeachText.CrossFadeAlpha(0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(0f, fadeTime, false);
            CampingText.CrossFadeAlpha(0f, fadeTime, false);
            NothingText.CrossFadeAlpha(0f, fadeTime, false);

            SeagullsText.canvasRenderer.SetAlpha(0);
            RainText.canvasRenderer.SetAlpha(0);
            SickText.canvasRenderer.SetAlpha(0);
            

        }
        if (word == "Rollercoaster" || word == "Ferriswheel" || word == "Food")
        {
            FerriswheelText.CrossFadeAlpha(0f, fadeTime, false);
            RollercoasterText.CrossFadeAlpha(0f, fadeTime, false);
            FoodText.CrossFadeAlpha(0f, fadeTime, false);

            FerriswheelText.canvasRenderer.SetAlpha(0);
            RollercoasterText.canvasRenderer.SetAlpha(0);
            FoodText.canvasRenderer.SetAlpha(0);
           


        }
        if (word == "Hiking" || word == "Fishing" || word == "Campfire")
        {
            

            HikingText.CrossFadeAlpha(0f, fadeTime, false);
            FishingText.CrossFadeAlpha(0f, fadeTime, false);
            CampfireText.CrossFadeAlpha(0f, fadeTime, false);

            HikingText.canvasRenderer.SetAlpha(0);
            FishingText.canvasRenderer.SetAlpha(0);
            CampfireText.canvasRenderer.SetAlpha(0);




        }

        listening = vcscript.choiceTime;
        word = vcscript.word;
        if (listening)
        {
            if (!vcscript.beach && !vcscript.carn && !vcscript.camp)
            {
               StartCoroutine(FirstChoicesAppear());


            }
         
            if (word=="Beach")
            {
                StartCoroutine(BeachChoicesAppear());


            }
            if (word == "Carnival")
            {
                StartCoroutine(CarnChoicesAppear());


            }
            if (word == "Camping")
            {
                StartCoroutine(CampChoicesAppear());


            }
            if (word == "Fishing" || word == "Hiking" || word == "Campfire")
            {
                StartCoroutine(AftCampChoicesAppear());


            }
            if (word == "Rollercoaster" || word == "Ferriswheel" || word == "Food")
            {
                StartCoroutine(AftCarnChoicesAppear());


            }
            if (word == "Rain" || word == "Sick" || word == "Seagulls")
            {
                StartCoroutine(AftBeachChoicesAppear());


            }


        }
    

        IEnumerator FirstChoicesAppear()
        {
            yield return new WaitForSeconds(3);
            BeachText.CrossFadeAlpha(1.0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampingText.CrossFadeAlpha(1.0f, fadeTime, false);
        }

        IEnumerator BeachChoicesAppear()
        {
            yield return new WaitForSeconds(4);
            SickText.CrossFadeAlpha(1.0f, fadeTime, false);
            SeagullsText.CrossFadeAlpha(1.0f, fadeTime, false);
            RainText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        
        IEnumerator CarnChoicesAppear()
        {
            yield return new WaitForSeconds(4);
            RollercoasterText.CrossFadeAlpha(1.0f, fadeTime, false);
            FerriswheelText.CrossFadeAlpha(1.0f, fadeTime, false);
            FoodText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        IEnumerator CampChoicesAppear()
        {
            yield return new WaitForSeconds(3);
            HikingText.CrossFadeAlpha(1.0f, fadeTime, false);
            FishingText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampfireText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        
        IEnumerator AftBeachChoicesAppear()
        {
            yield return new WaitForSeconds(1);
            NothingText.CrossFadeAlpha(1.0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampingText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        IEnumerator AftCarnChoicesAppear()
        {
            yield return new WaitForSeconds(1);
            BeachText.CrossFadeAlpha(1.0f, fadeTime, false);
            NothingText.CrossFadeAlpha(1.0f, fadeTime, false);
            CampingText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
        IEnumerator AftCampChoicesAppear()
        {
            yield return new WaitForSeconds(1);
            BeachText.CrossFadeAlpha(1.0f, fadeTime, false);
            CarnivalText.CrossFadeAlpha(1.0f, fadeTime, false);
            NothingText.CrossFadeAlpha(1.0f, fadeTime, false);
        }
    }
}
