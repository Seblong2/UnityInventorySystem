using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryScript : MonoBehaviour
{
    public InputAction openInventory;


    private void OnEnable()
    {
        openInventory.Enable();
        openInventory
    }

    private void OnDisable()
    {
        openInventory.Disable();
    }

    private void ToggleUI()
    {
        
    }

}
