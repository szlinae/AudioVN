using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class FadeOutScript : MonoBehaviour
{   
    public Image blackbox;
    public bool ending;
    public float fadeTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        blackbox.canvasRenderer.SetAlpha(0);
        ending = ConversationManager.Instance.GetBool("Ending");
    }

    // Update is called once per frame
    void Update()
    {
        if (ending)
        {
            StartCoroutine(FadeOut());
        }
        IEnumerator FadeOut()
        {
            yield return new WaitForSeconds(1);
            blackbox.CrossFadeAlpha(1.0f, fadeTime, false);
        }
    }
}
