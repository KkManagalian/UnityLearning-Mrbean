using UnityEngine;
using UnityEngine.UI;

public class Pults : MonoBehaviour
{
    public GameObject Background;
    public GameObject Bean;
    public GameObject ChannelR;
    public GameObject SoundUp;
    public GameObject SoundDown;
    public Sprite[] characterSprite;

    public void TurnOn()
    {
        if(Background.activeSelf==false)
            Background.SetActive(true);
        else
        {
            Background.SetActive(false);
            Bean.SetActive(false);
        }
    }
    public void ChangeBackground(int Kanals)
    {
        Background.GetComponent<Image>().sprite = characterSprite[Kanals];

        if (Bean.activeSelf == false)
            Bean.SetActive(true);
        else
        {
            Bean.SetActive(false);
        }
    }
}
