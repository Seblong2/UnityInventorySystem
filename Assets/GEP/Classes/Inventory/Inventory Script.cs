using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryScript : MonoBehaviour
{
    InventoryAction InventoryInput;


    private void Awake()
    {
        InventoryInput = new InventoryAction();
    }

    private void OnEnable()
    {
        InventoryInput.Enable();
    }

    private void OnDisable()
    {
        InventoryInput.Disable();
    }

    private void Update()
    {
        NewInputSystem();
    }

    private void NewInputSystem()
    {
        
    }

}
