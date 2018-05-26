﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : Module
{
    public override void Update()
    {
        // Run
        if(Input.GetKeyDown(KeyCode.LeftShift)&& !_player._isRun)
        {
            _player._isRun = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift)&& _player._isRun)
        {
            _player._isRun = false;
        }

        // Move
        if (_player._isMove)
        {
            _player._forwardSpeed = Input.GetAxis("Vertical");
            _player._forwardSpeed = Mathf.Clamp(_player._forwardSpeed, -_player._MaxforwardSpeed, _player._MaxforwardSpeed);

            if (_player._forwardSpeed > _player._MaxforwardSpeed / 2 && _player._isRun)
                _player._forwardSpeed += _player._MaxforwardSpeed;

            _player._sideSpeed = Input.GetAxis("Horizontal");
            _player._sideSpeed = Mathf.Clamp(_player._sideSpeed, -_player._MaxsideSpeed, _player._MaxsideSpeed);

        }

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))// && _player.GetComponent<CharacterController>().isGrounded)
        {
            _player._list[(int)eModCount.MOVE].Jump();
        }
        // Attack
        if (Input.GetMouseButtonDown(0) && !_player._isAttack)
        {
            _player._isAttack = true;
        }

        // Inventory
        if (Input.GetKeyDown(KeyCode.I) && _player._InventoryManager._Object.activeSelf)
        {
            _player._isCamera = true;
            _player._InventoryManager._Object.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.I) && !_player._InventoryManager._Object.activeSelf)
        {
            _player._isCamera = false;
            _player._InventoryManager._Object.SetActive(true);
        }
    }
 
}
