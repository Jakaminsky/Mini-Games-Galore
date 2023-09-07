using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyMovement : MonoBehaviour
{
    [SerializeField] private CinemachineDollyCart _dollyCart;

    public static float speed = 0f;

    private void Update()
    {
        _dollyCart.m_Speed = speed;
    }
}
