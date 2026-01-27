using UnityEngine;
using UnityEngine.UI;

public class Enabler : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject granny;
    public GameObject left;
    public GameObject right;
    public GameObject flip;
    public GameObject characterImg;
    public Sprite[] characterSprite;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void ToggleBean(bool value)
    {

        bean.SetActive(value);
        left.GetComponent<Toggle>().interactable = value;
        right.GetComponent<Toggle>().interactable = value;

    }

    public void Left(bool value)
    {
        bean.transform.localScale = new Vector2(1, 1);

    }
    public void Right(bool value)
    {
        bean.transform.localScale = new Vector2(-1, 1);

    }

    public void Flip(bool value)
    {
        if (left.GetComponent<Toggle>().interactable = value)
        {
            bean.transform.localScale = new Vector2(1, 1);
        }
        else
        {
            bean.transform.localScale = new Vector2(-1, 1);
        }
    }


    public void ToggleTeddy(bool value)
    {

        teddy.SetActive(value);

    }
    public void ToggleCar(bool value)
    {

        car.SetActive(value);

    }
    public void ToggleGranny(bool value)
    {

        granny.SetActive(value);

    }

    public void ChangeCharacterImage(int index)
    {
        characterImg.GetComponent<Image>().sprite = characterSprite[index];
    }

    public void ChangeRotation()
    {
        float rotationValue = rotationSlider.GetComponent<Slider>().value;
        characterImg.transform.localRotation = Quaternion.Euler(0, 0, 360 * rotationValue);
    }
    public void ChangeSize()
    {
        float sizeValue = sizeSlider.GetComponent<Slider>().value;
        characterImg.transform.localScale = new Vector2(1f * sizeValue, 1f * sizeValue);
    }
}
