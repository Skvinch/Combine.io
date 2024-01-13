using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<ItemCombine> _itemCombinesList = new List<ItemCombine>();
    [SerializeField] private List<Color> _combineColorsList = new List<Color>();

    private void Start()
    {
        //SetCombineColors();
    }

    private void SetCombineColors()
    {
        foreach (var combine in _itemCombinesList)
        {
            int randIndex = Random.Range(0, _combineColorsList.Count);
            combine.SetRandomColor(_combineColorsList[randIndex]);
            
            _combineColorsList.RemoveAt(randIndex);
        }
    }
}
