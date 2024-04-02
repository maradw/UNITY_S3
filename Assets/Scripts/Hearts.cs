using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hearts : MonoBehaviour
{
    public static event Action<float> OnHeartCollision;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "reference")
        {
            OnHeartCollision?.Invoke(1f);
            Destroy(this.gameObject);
        }


    }

}
