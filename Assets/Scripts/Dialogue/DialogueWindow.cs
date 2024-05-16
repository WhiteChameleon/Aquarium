using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueWindow : MonoBehaviour
{
    private TMP_Text _text;
    private DialogueStory _dialogueStory;

    void Awake()
    {
        _text = GetComponent<TMP_Text>();
        _dialogueStory = FindObjectOfType<DialogueStory>();
        _dialogueStory.ChangedStory += ChangeAnswers;
    }

    private void ChangeAnswers(DialogueStory.Story story) => _text.text = story.Text;
}
