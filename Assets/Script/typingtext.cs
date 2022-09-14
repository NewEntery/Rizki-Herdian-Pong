using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingtext : MonoBehaviour
{
    public float delay;
    public string fulltext;
    private string Text = "";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Showtext());
    }

    IEnumerator Showtext()
    {
        for(int i = 0; i <= fulltext.Length; i++)
        {
            Text = fulltext.Substring(0, i);
            this.GetComponent<Text>().text = Text;
            yield return new WaitForSeconds(delay);
        }
    }
}
