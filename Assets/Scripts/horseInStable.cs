using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseInStable : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("playerEntered", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("playerEntered", false);
        }
    }
}
