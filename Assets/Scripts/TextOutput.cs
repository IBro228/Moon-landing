using UnityEngine;
using TMPro;
public class TextOutput : MonoBehaviour
{
    public GameObject textDisplay;
    public void textout(int a)
    {
        //textDisplay.GetComponent<Text>().text = a.ToString();
        textDisplay.GetComponent<TextMeshProUGUI>().text = a.ToString();
    }
    public void textout(float a)
    {
        //textDisplay.GetComponent<Text>().text = a.ToString();
        textDisplay.GetComponent<TextMeshProUGUI>().text = a.ToString();
    }
}
