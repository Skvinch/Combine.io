using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;
    [SerializeField] private GameObject _chickenPrefab;
    [SerializeField] private int _amountToPool;

    private List<GameObject> _pooledChickens = new List<GameObject>();
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < _amountToPool; i++)
        {
            GameObject chicken = Instantiate(_chickenPrefab, transform);
            //chicken.SetActive(false);
            _pooledChickens.Add(chicken);
        }
    }

    public GameObject GetPooledChicken()
    {
        for (int i = 0; i < _pooledChickens.Count; i++)
        {
            if (!_pooledChickens[i].activeInHierarchy)
            {
                return _pooledChickens[i];
            }
        }
        return null;
    }
}
