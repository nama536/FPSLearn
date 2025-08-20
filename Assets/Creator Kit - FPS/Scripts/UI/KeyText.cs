using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour
{
    //All MyCode
    [SerializeField] Text _keyText;
    private int _keyJudge;
    private int _clearkeyJudge;
    private bool _keyBool;
    private GameSystem _gameSystem;

    [SerializeField] Text _enemyCountText;
    private int _enemyCount;

    void Start()
    {
        _gameSystem = FindObjectOfType<GameSystem>();

        _keyText.enabled = false;
        _keyBool = true;
    }

    void Update()
    {
        _keyJudge = _gameSystem.KeyJudge;
        _clearkeyJudge = _gameSystem.ClearKeyJudge;

        if (_keyJudge == _clearkeyJudge && _keyBool == true)
        {
            _keyText.enabled = true;
            Invoke("TextFalse", 4f);
            _keyBool = false;
        }

        _enemyCount = _clearkeyJudge - _keyJudge;
        _enemyCountText.text = "残り敵数 " + _enemyCount + "体";
    }

    void TextFalse()
    {
        _keyText.enabled = false;
    }
}
