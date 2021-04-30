using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Win();
    }
}
