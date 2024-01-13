using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCombine : MonoBehaviour
{
    [SerializeField] private List<MeshRenderer> _meshRenderersList = new List<MeshRenderer>();
    [SerializeField] private Material _lightColorMaterial;
    [SerializeField] private Material _darkColorMaterial;
    
    private List<Material> _materialsList = new List<Material>();

    private void Start()
    {
        GetCombineMaterials();
    }

    private void GetCombineMaterials()
    {
        List<Material> materialsList = new List<Material>();
        
        for (int i = 0; i < _meshRenderersList.Count; i++)
        {
            for (int j = 0; j < _meshRenderersList[i].sharedMaterials.Length; j++)
            {
                materialsList.Add(_meshRenderersList[i].sharedMaterials[j]);
            }
        }

        for (int i = 0; i < materialsList.Count; i++)
        {
            if (materialsList[i] == _lightColorMaterial || materialsList[i] == _darkColorMaterial)
            {
                _materialsList.Add(materialsList[i]);
            }
        }
    }

    public void SetRandomColor(Color randomColor)
    {
        foreach (var material in _materialsList)
        {
            material.color = randomColor;
        }
    }
}
