﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsController : MonoBehaviour
{
    public KeyCode Pl1ForwardInput = KeyCode.D;
    public KeyCode Pl1BackInput = KeyCode.A;
    public KeyCode Pl1JumpInput = KeyCode.W;
    public KeyCode PL1AttackInput = KeyCode.Space;


    public KeyCode Pl2ForwardInput = KeyCode.RightArrow;
    public KeyCode Pl2BackInput = KeyCode.LeftArrow;
    public KeyCode Pl2JumpInput = KeyCode.UpArrow;
    public KeyCode Pl2AttackInput = KeyCode.LeftShift;

    

    public Toggle ForwardPl1;
    public Toggle BackPl1;
    public Toggle JumpPl1;
    public Toggle AttackPl1;

    public Toggle ForwardPl2;
    public Toggle BackPl2;
    public Toggle JumpPl2;
    public Toggle AttackPl2;


    string F1string;
    string B1string;
    string J1string;
    string A1string;

    string F2string;
    string B2string;
    string J2string;
    string A2string;


    public Text F1text;
    public Text B1text;
    public Text J1text;
    public Text A1text;

    public Text F2text;
    public Text B2text;
    public Text J2text;
    public Text A2text;


    private int[] values;
    private KeyCode PlayerInput;

    void Start()
    {
        Debug.Log("Awake");
        values = (int[])System.Enum.GetValues(typeof(KeyCode));

        Toggle[] AllToggles = new Toggle[8] { ForwardPl1, BackPl1, JumpPl1, AttackPl1, ForwardPl2, BackPl2, JumpPl2, AttackPl2 };

        KeyCode Pl1ForwardInput = GlobalController.Instance.right1;
        KeyCode Pl1BackInput = GlobalController.Instance.left1;
        KeyCode Pl1JumpInput = GlobalController.Instance.jump1;
        KeyCode PL1AttackInput = GlobalController.Instance.attack1;


        KeyCode Pl2ForwardInput = GlobalController.Instance.right2;
        KeyCode Pl2BackInput = GlobalController.Instance.left2;
        KeyCode Pl2JumpInput = GlobalController.Instance.jump2;
        KeyCode Pl2AttackInput = GlobalController.Instance.attack2;

        KeyCode[] allInputs = new KeyCode[] { Pl1ForwardInput, Pl1BackInput, Pl1JumpInput, PL1AttackInput, Pl2ForwardInput, Pl2BackInput, Pl2JumpInput, Pl2AttackInput};
        Text[] allText = new Text[] { F1text, B1text, J1text, A1text, F2text, B2text, J2text, A2text};

        for (int i = 0; i < allInputs.Length; i++)
        {
            string theInput = allInputs[i].ToString();
            if (theInput.Length <= 5)
            {
                allText[i].fontSize = 60;
            }
            else if (theInput.Length > 5 && theInput.Length <= 9)

            {
                allText[i].fontSize = 40;
            }
            else
            {
                allText[i].fontSize = 38;
            }
            allText[i].text = theInput; 
        }

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
    }

    

    private void Update()
    {
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
                        if (F1string.Length <= 5 )
                        {
                            F1text.fontSize = 60;
                        }
                        else if (F1string.Length > 5 && F1string.Length <= 9)

                        {
                            F1text.fontSize = 40;
                        }
                        else
                        {
                            F1text.fontSize = 38;
                        }
                        F1text.text = F1string;
                        Debug.Log(pInput);
                        ForwardPl1.isOn = false;
                        Pl1ForwardInput = PlayerInput;
                        LeavingControls();
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
                        if (B1string.Length <= 5)
                        {
                            B1text.fontSize = 60;
                        }
                        else if (B1string.Length > 5 && B1string.Length <= 9)

                        {
                            B1text.fontSize = 40;
                        }
                        else
                        {
                            B1text.fontSize = 38;
                        }
                        B1text.text = B1string;
                        Debug.Log(pInput);
                        BackPl1.isOn = false;
                        Pl1BackInput = PlayerInput;
                        LeavingControls();
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
                        if (J1string.Length <= 5)
                        {
                            J1text.fontSize = 60;
                        }
                        else if (J1string.Length > 5 && J1string.Length <= 9)

                        {
                            J1text.fontSize = 40;
                        }
                        else
                        {
                            J1text.fontSize = 38;
                        }
                        J1text.text = J1string;
                        Debug.Log(pInput);
                        JumpPl1.isOn = false;
                        Pl1JumpInput = PlayerInput;
                        LeavingControls();
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
                        if (A1string.Length <= 5)
                        {
                            A1text.fontSize = 60;
                        }
                        else if (A1string.Length > 5 && A1string.Length <= 9)

                        {
                            A1text.fontSize = 40;
                        }
                        else
                        {
                            A1text.fontSize = 38;
                        }
                        A1text.text = A1string;
                        Debug.Log(pInput);
                        AttackPl1.isOn = false;
                        PL1AttackInput = PlayerInput;
                        LeavingControls();
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
                        if (F2string.Length <= 5)
                        {
                            F2text.fontSize = 60;
                        }
                        else if (F2string.Length > 5 && F2string.Length <= 9)

                        {
                            F2text.fontSize = 40;
                        }
                        else
                        {
                            F2text.fontSize = 38;
                        }
                        F2text.text = F2string;
                        Debug.Log(pInput);
                        ForwardPl2.isOn = false;
                        Pl2ForwardInput = PlayerInput;
                        LeavingControls();
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
                        if (B2string.Length <= 5)
                        {
                            B2text.fontSize = 60;
                        }
                        else if (B2string.Length > 5 && B2string.Length <= 9)

                        {
                            B2text.fontSize = 40;
                        }
                        else
                        {
                           B2text.fontSize = 38;
                        }
                        B2text.text = B2string;
                        Debug.Log(pInput);
                        BackPl2.isOn = false;
                        Pl2BackInput = PlayerInput;
                        LeavingControls();
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
                        if (J2string.Length <= 5)
                        {
                            J2text.fontSize = 60;
                        }
                        else if (J2string.Length > 5 && J2string.Length <= 9)

                        {
                            F2text.fontSize = 40;
                        }
                        else
                        {
                            J2text.fontSize = 38;
                        }
                        J2text.text = J2string;
                        Debug.Log(pInput);
                        JumpPl2.isOn = false;
                        Pl2JumpInput = PlayerInput;
                        LeavingControls();
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
                        if (A2string.Length <= 5)
                        {
                            A2text.fontSize = 60;
                        }
                        else if (A2string.Length > 5 && A2string.Length <= 9)

                        {
                            A2text.fontSize = 40;
                        }
                        else
                        {
                            A2text.fontSize = 38;
                        }
                        A2text.text = A2string;
                        Debug.Log(pInput);
                        AttackPl2.isOn = false;
                        Pl2AttackInput = PlayerInput;
                        LeavingControls();
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

    public void LeavingControls()
    {
        Debug.Log("Leaving Controls");
        GlobalController.Instance.jump1 = Pl1JumpInput;
        GlobalController.Instance.left1 = Pl1BackInput;
        GlobalController.Instance.right1 = Pl1ForwardInput;
        GlobalController.Instance.attack1 = PL1AttackInput;
        GlobalController.Instance.jump2 = Pl2JumpInput;
        GlobalController.Instance.left2 = Pl2BackInput;
        GlobalController.Instance.right2 = Pl2ForwardInput;
        GlobalController.Instance.attack2 = Pl2AttackInput;

    }



}
