using DialogueEditor;
using UnityEngine;

public class VoiceChoices : MonoBehaviour
{
    public NPCConversation start;
    public NPCConversation beachStart;
    public NPCConversation beach1;
    public NPCConversation beach2;
    public NPCConversation beach3;
    public NPCConversation carnStart;
    public NPCConversation carn1;
    public NPCConversation carn2;
    public NPCConversation carn3;
    public NPCConversation campStart;
    public NPCConversation camp1;
    public NPCConversation camp2;
    public NPCConversation camp3;
    public NPCConversation ending;

    public bool choiceTime;
    public bool beach;
    public bool carn;
    public bool camp;
    public bool end;
    public string currentBranch;

    public GameObject theGuy;
    public TestVoiceDetection voiceScript;

    public string word = " ";



    // Start is called before the first frame update
    void Start()
    {
        voiceScript = theGuy.GetComponent<TestVoiceDetection>();
        ConversationManager.Instance.StartConversation(start);

    }



    void Update()
    {
        word = voiceScript.myWord;

        choiceTime = ConversationManager.Instance.GetBool("choiceTime");

        if (choiceTime)
        {
            Debug.Log("listening");
            if (!beach && !carn && !camp)
            {

                if (word == "Beach")
                {
                    Debug.Log("detected");
                    currentBranch = "Beach";
                    ConversationManager.Instance.StartConversation(beachStart);
                    choiceTime = false;
                    beach = true;
                    carn = false;
                    camp = false;
                    end = false;

                    word = "";
                }
                if (word == "Carnival")
                {
                    Debug.Log("detected");
                    currentBranch = "Carnival";
                    ConversationManager.Instance.StartConversation(carnStart);
                    choiceTime = false;
                    beach = false;
                    carn = true;
                    camp = false;
                    end = false;

                    word = "";
                }
                if (word == "Camping")
                {
                    Debug.Log("detected");
                    currentBranch = "Camping";
                    ConversationManager.Instance.StartConversation(campStart);
                    choiceTime = false;
                    beach = false;
                    carn = false;
                    camp = true;
                    end = false;

                    word = "";
                }
            }
            else if (beach)
            {
                if (end)
                {
                    if (word == "Carnival")
                    {
                        Debug.Log("detected");
                        currentBranch = "Carnival";
                        ConversationManager.Instance.StartConversation(carnStart);
                        choiceTime = false;
                        beach = false;
                        carn = true;
                        camp = false;
                        end = false;

                        word = "";
                    }
                    if (word == "Camping")
                    {
                        Debug.Log("detected");
                        currentBranch = "Camping";
                        ConversationManager.Instance.StartConversation(campStart);
                        choiceTime = false;
                        beach = false;
                        carn = false;
                        camp = true;
                        end = false;

                        word = "";
                    }
                    if (word == "Nothing")
                    {
                        Debug.Log("detected");
                        currentBranch = "Nothing";
                        ConversationManager.Instance.StartConversation(ending);
                        choiceTime = false;
                        beach = false;
                        carn = false;
                        camp = false;


                        word = "";
                    }

                }
                else
                {

                    if (word == "Sick")
                    {
                        Debug.Log("detected");
                        currentBranch = "Sick";
                        ConversationManager.Instance.StartConversation(beach1);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Rain")
                    {
                        Debug.Log("detected");
                        currentBranch = "Rain";
                        ConversationManager.Instance.StartConversation(beach2);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Seagulls")
                    {
                        Debug.Log("detected");
                        currentBranch = "Seagulls";
                        ConversationManager.Instance.StartConversation(beach3);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }

                }
            }
            else if (carn)
            {
                if (end)
                {
                    if (word == "Beach")
                    {
                        Debug.Log("detected");
                        currentBranch = "Beach";
                        ConversationManager.Instance.StartConversation(beachStart);
                        choiceTime = false;
                        beach = true;
                        carn = false;
                        camp = false;
                        end = false;

                        word = "";
                    }
                    if (word == "Camping")
                    {
                        Debug.Log("detected");
                        currentBranch = "Camping";
                        ConversationManager.Instance.StartConversation(campStart);
                        choiceTime = false;
                        beach = false;
                        carn = false;
                        camp = true;
                        end = false;

                        word = "";
                    }
                    if (word == "Nothing")
                    {
                        Debug.Log("detected");
                        currentBranch = "Nothing";
                        ConversationManager.Instance.StartConversation(ending);
                        choiceTime = false;
                        beach = false;
                        carn = false;
                        camp = false;


                        word = "";
                    }

                }
                else
                {
                    if (word == "Rollercoaster")
                    {
                        Debug.Log("detected");
                        currentBranch = "Rollercoaster";
                        ConversationManager.Instance.StartConversation(carn1);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Ferriswheel")
                    {
                        Debug.Log("detected");
                        currentBranch = "Ferriswheel";
                        ConversationManager.Instance.StartConversation(carn2);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Food")
                    {
                        Debug.Log("detected");
                        currentBranch = "Food";
                        ConversationManager.Instance.StartConversation(carn3);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }

                }
            }
            else if (camp)
            {
                if (end)
                {
                    if (word == "Beach")
                    {
                        Debug.Log("detected");
                        currentBranch = "Beach";
                        ConversationManager.Instance.StartConversation(beachStart);
                        choiceTime = false;
                        beach = true;
                        carn = false;
                        camp = false;
                        end = false;

                        word = "";
                    }
                    if (word == "Carnival")
                    {
                        Debug.Log("detected");
                        currentBranch = "Carnival";
                        ConversationManager.Instance.StartConversation(carnStart);
                        choiceTime = false;
                        beach = false;
                        carn = true;
                        camp = false;
                        end = false;

                        word = "";
                    }
                    if (word == "Nothing")
                    {
                        Debug.Log("detected");
                        currentBranch = "Nothing";
                        ConversationManager.Instance.StartConversation(ending);
                        choiceTime = false;
                        beach = false;
                        carn = false;
                        camp = false;


                        word = "";
                    }

                }
                else
                {
                    if (word == "Hiking")
                    {
                        Debug.Log("detected");
                        currentBranch = "Hiking";
                        ConversationManager.Instance.StartConversation(camp1);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Fishing")
                    {
                        Debug.Log("detected");
                        currentBranch = "Fishing";
                        ConversationManager.Instance.StartConversation(camp2);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }
                    if (word == "Campfire")
                    {
                        Debug.Log("detected");
                        currentBranch = "Campfire";
                        ConversationManager.Instance.StartConversation(camp3);
                        choiceTime = false;
                        end = true;

                        word = "";
                    }

                }
            }
        }
    }

}

