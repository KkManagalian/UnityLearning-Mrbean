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
}
