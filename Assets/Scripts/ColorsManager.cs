using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsManager : MonoBehaviour
{
    public GameObject _squarePlayer;


    public void ChangeColors( Button button)
    {
        Color newColor = button.image.color;
        
         _squarePlayer.GetComponent<SpriteRenderer>().color = newColor;

    }
    public void OnButtonPresed(Button button)
    {
        ChangeColors(button);
    }

}
