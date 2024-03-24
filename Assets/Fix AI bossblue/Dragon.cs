using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
    public int HP;
    public Slider headthBar;
    public Animator animator;


    private void Update()
    {
        headthBar.value = HP;
    }

    public void TakeDamage1(int damageAmount)
    {
        HP -= damageAmount;
        if (HP < 0 )
        {
            animator.SetTrigger("die");
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
}
