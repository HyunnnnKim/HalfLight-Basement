﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using HalfLife.Input;
using HalfLife.Movement;

namespace HalfLife.Output
{
    public class InputLog : MonoBehaviour
    {
        #region Private Variables
            private TextMeshPro inputLog;
            private ControllerInput ci;
            private string _inputLogText;
        #endregion

        #region BuiltIn Methods
            void Start()
            {
                ci = ControllerInput.Instance;
                inputLog = GetComponent<TextMeshPro>();
            }

            void Update()
            {
                _inputLogText = "INPUT\n";
                _inputLogText += "-----------------------------------------------------\n";
                _inputLogText += "            Left Hand            Right Hand\n";
                _inputLogText += "-----------------------------------------------------\n";
                _inputLogText += "P2DV\t:  " + ci.getLeftHand.primary2DValue + "\t\t" + ci.getRightHand.primary2DValue + "\n";
                _inputLogText += "P2DP\t:  " + ci.getLeftHand.primary2DPressed + "\t\t" + ci.getRightHand.primary2DPressed + "\n";
                _inputLogText += "TRIG\t:  " + ci.getLeftHand.triggerButtonPressed + "\t\t" + ci.getRightHand.triggerButtonPressed + "\n";
                _inputLogText += "GRIP\t:  " + ci.getLeftHand.gripButtonPressed + "\t\t" + ci.getRightHand.gripButtonPressed + "\n";
                _inputLogText += "PBTN\t:  " + ci.getLeftHand.primaryButtonPressed + "\t\t" + ci.getRightHand.primaryButtonPressed + "\n";
                _inputLogText += "SBTN\t:  " + ci.getLeftHand.secondaryButtonPressed + "\t\t" + ci.getRightHand.secondaryButtonPressed + "\n";
                _inputLogText += "-----------------------------------------------------\n\n";
                
                inputLog.text = _inputLogText;
            }
        #endregion
    }    
}