using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public string keyType;
    public Text KeyNameText;

    //MyCode
    [SerializeField] AudioSource _keyGetSound;
    public bool KeyHave = false;

    void OnEnable()
    {
        KeyNameText.text = keyType;
    }

    void OnTriggerEnter(Collider other)
    {
        var keychain = other.GetComponent<Keychain>();

        //MyCode
        _keyGetSound.Play();
        KeyHave = true;

        if (keychain != null)
        {
            keychain.GrabbedKey(keyType);
            Destroy(gameObject);
        }
    }
}
