﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    Animator myAnim;
    
    public GameObject instanceWeapon;
	public GameObject hitbox;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ///neste if/else é onde o jogador liga e desliga a arma, deve ser por aqui que deves meter a animação
        if(Input.GetMouseButtonDown(0))
        {
            instanceWeapon.SetActive(true);
			hitbox.SetActive(true);
            myAnim.SetBool("isAttacking", true);

        } else {
            
            instanceWeapon.SetActive(false);
			hitbox.SetActive(false);
            myAnim.SetBool("isAttacking", false);
        }
    }
}
