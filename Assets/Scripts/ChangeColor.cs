using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;
    
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ChangeColorRed()
    {
        _renderer.material.color = new Color(1, 0, 0);
    }

    public void ChangeColorBlack()
    {
        _renderer.material.color = new Color(0, 0, 0);
    }
}
