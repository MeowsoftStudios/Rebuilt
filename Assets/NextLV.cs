using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NextLV : MonoBehaviour
{
    public Sprite LV2;
    public Sprite LV3;
    public Sprite LV4;
    public Sprite LV5;
    private SpriteRenderer sr;
    public static int oldhp = 5;
    public int maxhp;
    public int currenthp;
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public NextLV lvbar;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetMaxHealth(oldhp);
    }
    public void SetOldHp(int ohp)
    {
        oldhp = ohp;
    }
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
        lvbar.SetHealth(currenthp);

        if(currenthp == 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    public void SpriteSw()
    {
        if (currenthp == 4)
        {
            sr.sprite = LV2;
        }
        if (currenthp == 3)
        {
            sr.sprite = LV3;
        }
        if (currenthp == 2)
        {
            sr.sprite = LV4;
        }
        if (currenthp == 1)
        {
            sr.sprite = LV5;
        }
        
    }
}
