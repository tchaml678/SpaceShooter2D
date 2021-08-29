using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
  public void PlayButton()
    {
        Application.LoadLevel(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
