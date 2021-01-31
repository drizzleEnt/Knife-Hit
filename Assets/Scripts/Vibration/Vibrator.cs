using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrator : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;

    private void OnEnable()
    {
        _spawner.Lose += OnVibration;
        _spawner.KnifeInLog += OnVibration;
        _spawner.AllKnifesInTarget += OnVibration;
    }

    private void OnDisable()
    {
        _spawner.Lose -= OnVibration;
        _spawner.KnifeInLog -= OnVibration;
        _spawner.AllKnifesInTarget -= OnVibration;
    }

    private void OnVibration()
    {
        Handheld.Vibrate();
    }
}
