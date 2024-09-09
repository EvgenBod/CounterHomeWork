using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _coroutine;
    private WaitForSeconds _delay;

    public int Value { get; private set; }
    public event Action ValueChanged;

    private void Start()
    {
        float amount = 0.5f;

        _delay = new WaitForSeconds(amount);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(IncrementCounter());

                return;
            }

            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator IncrementCounter()
    {
        while (enabled)
        {
            Value++;

            ValueChanged?.Invoke();
            yield return _delay;
        }
    }
}
