using UnityEngine;
using UnityEngine.UI;

public class Pults : MonoBehaviour
{
    public GameObject Background;
    public GameObject ChannelL;
    public GameObject ChannelR;
    public GameObject SoundUp;
    public GameObject SoundDown;
    public Sprite[] characterSprite;
    public int Kanals;

    public void TurnOn()
    {
        if(Background != true)
            Background.SetActive(true);
        else
        {
            Background.SetActive(false);
        }
        

    }
    public void ChangeBackground()
    {
        Background.GetComponent<Image>().sprite = characterSprite[Kanals];
    }
}
