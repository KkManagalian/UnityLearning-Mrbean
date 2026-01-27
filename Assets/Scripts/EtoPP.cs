using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EtoPP : MonoBehaviour
{

    private string text;
    private string[] input = {"FUCK", "SHIT", "AHHHHH"};
    private int rand;
    public GameObject inputField;
    public GameObject textField;

    public void getText()
    {
        rand = Random.Range(0, input.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        textField.GetComponent<TMP_Text>().text = input[rand] + " " + text + "!";
    }

}
