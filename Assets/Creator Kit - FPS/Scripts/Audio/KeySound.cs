using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySound : MonoBehaviour
{
    [SerializeField] Key _key;
    [SerializeField] AudioSource _keyGetSound;
    [SerializeField] AudioClip audioClip;
    private bool _keyHave;
    private bool _ikkaidake = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _keyHave = _key.KeyHave;

        if (_keyHave == true && _ikkaidake == true)
        {
            _keyGetSound.PlayOneShot(audioClip);
            _ikkaidake = false;
        }
    }
}
