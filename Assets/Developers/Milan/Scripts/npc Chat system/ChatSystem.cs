using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatSystem : MonoBehaviour
{
    [Header("Refrences.")]
    [SerializeField] private DialogueData _dialogueData;

    [SerializeField] private GameObject _dialoguePanel;
    [SerializeField] private TextMeshProUGUI _dialogueText;
    [SerializeField] private GameObject _continueButton;

    [SerializeField] private TextMeshProUGUI _npcName;
    [SerializeField] private Image _npcImage;

    private int _index;
    private bool _playerIsClose;

    private void Start()
    {
        _npcName.text = _dialogueData.CharacterName;
        _npcImage.sprite = _dialogueData.CharacterImage;
    }

    private void Update()
    {
        if (!_playerIsClose) return;
        if (Input.GetKeyDown(KeyCode.E) || Input.touchCount > 0)
        {
            if (_dialoguePanel.activeInHierarchy)
            {
                ZeroText();
            }
            else
            {
                _dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if(_dialogueText.text == _dialogueData.Dialogue[_index])
        {
            _continueButton.SetActive(true);
        }
    }

    public void ZeroText()
    {
        _dialogueText.text = "";
        _index = 0;
        _dialoguePanel.SetActive(false);

    }

    private IEnumerator Typing()
    {
        foreach (char letter in _dialogueData.Dialogue[_index].ToCharArray())
        {
            _dialogueText.text += letter;
            yield return new WaitForSeconds(_dialogueData.WordSpeed);
        }
    }

    public void NextLine()
    {
        _continueButton.SetActive(false);

        if (_index < _dialogueData.Dialogue.Length - 1)
        {
            _index++;
            _dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            ZeroText();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerIsClose = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerIsClose = false;
            ZeroText();
        }
    }
}
