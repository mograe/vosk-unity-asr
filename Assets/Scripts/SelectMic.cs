using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectMic : MonoBehaviour
{
    [SerializeField] TMP_Dropdown _dropdown;
    [SerializeField] VoiceProcessor _voiceProcessor;

    private void Start()
    {
        _dropdown.AddOptions(_voiceProcessor.Devices);
        _dropdown.onValueChanged.AddListener(OnChangeMic);
    }

    private void OnChangeMic(int index)
    {
        _voiceProcessor.ChangeDevice(index);
    }
}
