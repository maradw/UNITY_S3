using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coins : MonoBehaviour
{
    public static event Action<int> OnCoinCollision;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "reference")
        {
            OnCoinCollision?.Invoke(1);
            Destroy(this.gameObject);
        }


    }
}
