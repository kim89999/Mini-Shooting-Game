using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextControl : MonoBehaviour
{

    Text flashingText;

    // Start is called before the first frame update
    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(0.5f);
            flashingText.text = "TAP TO START";
            yield return new WaitForSeconds(0.5f);
        }
    }
}
