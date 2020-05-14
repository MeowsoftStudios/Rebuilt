using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menuscript : MonoBehaviour
{
   public void OnClickPlay()
   {
        SceneManager.LoadScene("Lv1");
   }
    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnClickBonus()
    {
        SceneManager.LoadScene("BonusGame");
    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
