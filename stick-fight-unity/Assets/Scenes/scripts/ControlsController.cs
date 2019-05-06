﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsController : MonoBehaviour
{
    KeyCode Pl1ForwardInput = KeyCode.D;
    KeyCode Pl1BackInput = KeyCode.A;
    KeyCode Pl1JumpInput = KeyCode.W;
    KeyCode PL1AttackInput = KeyCode.Space;
    KeyCode Pl1BlockInput = KeyCode.B;

    KeyCode Pl2ForwardInput = KeyCode.RightArrow;
    KeyCode Pl2BackInput = KeyCode.LeftArrow;
    KeyCode Pl2JumpInput = KeyCode.UpArrow;
    KeyCode Pl2AttackInput = KeyCode.RightControl;
    KeyCode Pl2BlockInput = KeyCode.RightShift;
    

    public Toggle ForwardPl1;
    public Toggle BackPl1;
    public Toggle JumpPl1;
    public Toggle AttackPl1;
    public Toggle BlockPl1;
    public Toggle ForwardPl2;
    public Toggle BackPl2;
    public Toggle JumpPl2;
    public Toggle AttackPl2;
    public Toggle BlockPl2;

    string F1string;
    string B1string;
    string J1string;
    string A1string;
    string BL1string;
    string F2string;
    string B2string;
    string J2string;
    string A2string;
    string BL2string;

    public Text F1text;
    public Text B1text;
    public Text J1text;
    public Text A1text;
    public Text BL1text;
    public Text F2text;
    public Text B2text;
    public Text J2text;
    public Text A2text;
    public Text BL2text;

    private int[] values;
    private KeyCode PlayerInput;

    void Awake()
    {
        values = (int[])System.Enum.GetValues(typeof(KeyCode));

        Toggle[] AllToggles = new Toggle[10] { ForwardPl1, BackPl1, JumpPl1, AttackPl1, BlockPl1, ForwardPl2, BackPl2, JumpPl2, AttackPl2, BlockPl2 };

        ForwardPl1.onValueChanged.AddListener(delegate
        {
            ToggleChange(ForwardPl1,AllToggles);
        });
        BackPl1.onValueChanged.AddListener(delegate
        {
            ToggleChange(BackPl1,AllToggles);
        });
        JumpPl1.onValueChanged.AddListener(delegate
        {
            ToggleChange(JumpPl1,AllToggles);
        });
        AttackPl1.onValueChanged.AddListener(delegate
        {
            ToggleChange(AttackPl1,AllToggles);
        });
        BlockPl1.onValueChanged.AddListener(delegate
        {
            ToggleChange(BlockPl1,AllToggles);
        });
        ForwardPl2.onValueChanged.AddListener(delegate
        {
            ToggleChange(ForwardPl2,AllToggles);
        });
        BackPl2.onValueChanged.AddListener(delegate
        {
            ToggleChange(BackPl2,AllToggles);
        });
        JumpPl2.onValueChanged.AddListener(delegate
        {
            ToggleChange(JumpPl2,AllToggles);
        });
        AttackPl2.onValueChanged.AddListener(delegate
        {
            ToggleChange(AttackPl2,AllToggles);
        });
        BlockPl2.onValueChanged.AddListener(delegate
        {
            ToggleChange(BlockPl2,AllToggles);
        });
    }

    

    private void Update()
    {

        if (Input.GetKeyDown(Pl1ForwardInput))
        {
            Debug.Log("PL1 Forward Pressed");
        }
        if (Input.GetKeyDown(PL1AttackInput))
        {
            Debug.Log("PL1 Attack Pressed");
        }
        if (ForwardPl1.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    Debug.Log("input recieved");
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        Debug.Log("input is not mouse");
                        F1string = PlayerInput.ToString();
                        F1text.text = F1string;
                        Debug.Log(pInput);
                        ForwardPl1.isOn = false;
                        Pl1ForwardInput = PlayerInput;

                    }
                }
            }
        }
        if (BackPl1.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        B1string = PlayerInput.ToString();
                        B1text.text = B1string;
                        Debug.Log(pInput);
                        BackPl1.isOn = false;
                        Pl1BackInput = PlayerInput;
                    }
                }
            }
        }
        if (JumpPl1.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        J1string = PlayerInput.ToString();
                        J1text.text = J1string;
                        Debug.Log(pInput);
                        JumpPl1.isOn = false;
                        Pl1JumpInput = PlayerInput;
                    }
                }
            }
        }
        if (AttackPl1.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        A1string = PlayerInput.ToString();
                        A1text.text = A1string;
                        Debug.Log(pInput);
                        AttackPl1.isOn = false;
                        PL1AttackInput = PlayerInput;
                    }
                }
            }
        }
        if (BlockPl1.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        BL1string = PlayerInput.ToString();
                        BL1text.text = BL1string;
                        Debug.Log(pInput);
                        BlockPl1.isOn = false;
                        Pl1BlockInput = PlayerInput;
                    }
                }
            }
        }
        if (ForwardPl2.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        F2string = PlayerInput.ToString();
                        F2text.text = F2string;
                        Debug.Log(pInput);
                        ForwardPl2.isOn = false;
                        Pl2ForwardInput = PlayerInput;
                    }
                }
            }
        }
        if (BackPl2.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        B2string = PlayerInput.ToString();
                        B2text.text = B2string;
                        Debug.Log(pInput);
                        BackPl2.isOn = false;
                        Pl2BackInput = PlayerInput;
                    }
                }
            }
        }
        if (JumpPl2.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        J2string = PlayerInput.ToString();
                        J2text.text = J2string;
                        Debug.Log(pInput);
                        JumpPl2.isOn = false;
                        Pl2JumpInput = PlayerInput;
                    }
                }
            }
        }
        if (AttackPl2.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        A2string = PlayerInput.ToString();
                        A2text.text = A2string;
                        Debug.Log(pInput);
                        AttackPl2.isOn = false;
                        Pl2AttackInput = PlayerInput;
                    }
                }
            }
        }
        if (BlockPl2.isOn == true)
        {
            foreach (KeyCode pInput in values)
            {
                if (Input.GetKey(pInput))
                {
                    PlayerInput = pInput;
                    if (PlayerInput != KeyCode.Mouse0)
                    {
                        BL2string = PlayerInput.ToString();
                        BL2text.text = F2string;
                        Debug.Log(pInput);
                        BlockPl2.isOn = false;
                        Pl2BlockInput = PlayerInput;
                    }
                }
            }
        }



    }

    void ToggleChange(Toggle change, Toggle[] alltoggles)
    {
        Debug.Log("toggle was toggled");
        for (int i = 0; i < alltoggles.Length; i++)
        {
            if (alltoggles[i] != change)
            {
                alltoggles[i].isOn = false;
            }
        }
        if (change.isOn == true)
        {
            change.image.color = Color.cyan;
        }
        else
        {
            change.image.color = Color.white;
        }
    }



}
