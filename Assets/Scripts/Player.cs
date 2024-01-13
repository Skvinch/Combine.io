using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Joystick _joystick;
    [SerializeField] private List<MeshRenderer> _meshRenderersList;

    private List<Material> _materialsList = new List<Material>();
    private void Start()
    {
        
    }

    // void Update()
    // {
    //     float xMovement = _joystick.Horizontal();
    //     float zMovement = _joystick.Vertical();
    //     
    //     transform.position += new Vector3(xMovement, 0, zMovement) * _speed * Time.deltaTime;
    // }

    
}
