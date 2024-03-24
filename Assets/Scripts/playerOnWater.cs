using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOnWater : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("PlayerOnWater", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("PlayerOnWater", false);
        }
    }
}
