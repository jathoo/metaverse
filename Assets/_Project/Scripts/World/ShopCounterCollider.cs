using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ShopCounterCollider : MonoBehaviour
{
    public static event Action PlayerEnteredShop;
    
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.Instance.GetCurrentState() != GameManager.State.Free) return;
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered shop zone.");
            PlayerEnteredShop?.Invoke();
        }
    }
}
