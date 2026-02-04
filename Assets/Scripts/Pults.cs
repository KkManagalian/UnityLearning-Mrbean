using UnityEngine;
using UnityEngine.UI;

public class Pults : MonoBehaviour
{
    public GameObject Background;
    public GameObject Bean;
    public GameObject Pipe;
    public GameObject Bean2D;
    public GameObject Teddy;
    public AudioClip[] Sound;
    public AudioSource sfxSource;
    public Sprite[] characterSprite;

    public void TurnOn()
    {
        if(Background.activeSelf==false)
            Background.SetActive(true);
        else
        {
            Background.SetActive(false);
            Bean.SetActive(false);
            Bean2D.SetActive(false);
            Teddy.SetActive(false);
        }
    }
    public void ChangeBackground(int Kanals)
    {
        sfxSource.Pause();
        Background.GetComponent<Image>().sprite = characterSprite[Kanals];

        if (Bean.activeSelf == false)
        {
            Bean.SetActive(true);
            Bean2D.SetActive(false);
            Teddy.SetActive(false);
            sfxSource.PlayOneShot(Sound[Kanals]);

        }
        else
        {
            Bean.SetActive(false);
            Bean2D.SetActive(true);
            Teddy.SetActive(true);
            sfxSource.PlayOneShot(Sound[Kanals]);
        }
    }

}
