using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public GameObject sprites;
    public GameObject active;
    Transform[] allChildren;


   // public GameObject theGuy;
    
    public VoiceChoices voiceChoices;
    public GameObject currentBranch;
    public string current;
    public string theWord;

    // Start is called before the first frame update
    void Start()
    {
        
        allChildren = sprites.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            child.gameObject.SetActive(false);
        }
        sprites.SetActive(true);
        active = sprites.transform.Find("Intro").gameObject;
        active.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        current = voiceChoices.currentBranch;
        if (theWord != voiceChoices.currentBranch)
        {
            theWord = voiceChoices.currentBranch;
            switch (theWord)
            {
                case "Beach":

                    active.SetActive(false);
                    active = sprites.transform.Find("Beach_Car").gameObject;
                    active.SetActive(true);


                    break;
                case "Sick":
                    active.SetActive(false);
                    active = sprites.transform.Find("BeachVomit").gameObject;
                    active.SetActive(true);


                    break;
                case "Seagulls":
                    active.SetActive(false);
                    active = sprites.transform.Find("BeachBird").gameObject;
                    active.SetActive(true);


                    break;
                case "Rain":
                    active.SetActive(false);

                    active = sprites.transform.Find("BeachRain").gameObject;
                    active.SetActive(true);


                    break;
                case "Carnival":
                    active.SetActive(false);
                    active = sprites.transform.Find("CarnivalIntro").gameObject;
                    active.SetActive(true);


                    break;
                case "Rollercoaster":
                    active.SetActive(false);
                    active = sprites.transform.Find("CarnivalRollercoaster").gameObject;
                    active.SetActive(true);


                    break;
                case "Ferriswheel":
                    active.SetActive(false);
                    active = sprites.transform.Find("CarnivalFerriswheel").gameObject;
                    active.SetActive(true);


                    break;
                case "Food":
                    active.SetActive(false);
                    active = sprites.transform.Find("CarnivalFood").gameObject;
                    active.SetActive(true);


                    break;
                case "Camping":
                    active.SetActive(false);
                    active = sprites.transform.Find("Beach_Car").gameObject;
                    active.SetActive(true);


                    break;
                case "Fishing":
                    active.SetActive(false);
                    active = sprites.transform.Find("CampingFishing").gameObject;
                    active.SetActive(true);


                    break;
                case "Hiking":
                    active.SetActive(false);
                    active = sprites.transform.Find("CampingHiking").gameObject;
                    active.SetActive(true);


                    break;
                case "Campfire":
                    active.SetActive(false);
                    active = sprites.transform.Find("CampingCampfire").gameObject;
                    active.SetActive(true);


                    break;
                case "Nothing":
                    active.SetActive(false);
                    active = sprites.transform.Find("Intro").gameObject;
                    active.SetActive(true);


                    break;

            }
        }
    }
}
