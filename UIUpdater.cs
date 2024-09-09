using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpdater : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    public void OnEnable()
    {
        _counter.ValueChanged += ShowInfo;
    }

    public void OnDisable()
    {
        _counter.ValueChanged -= ShowInfo;
    }

    private void ShowInfo()
    {
        Debug.Log(_counter.Value);
    }
}
