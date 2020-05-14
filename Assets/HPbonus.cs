using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HPbonus : MonoBehaviour
{

    public int maxhpbonus;
    public int currenthpbonus;
    public Slider slider;
    public Gradient gradient;
    public Image fill;



    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int hp)
    {
        slider.value = hp;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    void Update()
    {
        SetHealth(currenthpbonus);

        if (currenthpbonus == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}