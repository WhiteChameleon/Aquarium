using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSwitcher : MonoBehaviour
{
    [SerializeField] private string[] _disableTags;
    [SerializeField] private string[] _uselessDialogTags;
    private DialogueStory _dialogueStory;
    private DialogueStory _dialogueStoryTag;
    void Start()
    {
        _dialogueStory = FindObjectOfType<DialogueStory>(true);
        _dialogueStory.ChangedStory += Disable;
        _dialogueStory.ChangedStory += UselessDialog;
    }
    private async void Disable(DialogueStory.Story story)
    {
        if (_disableTags.All(disableTag => story.Tag != disableTag)) return;
        await Task.Delay(1000);
        _dialogueStory.gameObject.SetActive(false);
    }
    private async void UselessDialog(DialogueStory.Story story)
    {
        if (_uselessDialogTags.All(disableTag => story.Tag != disableTag)) return;
        await Task.Delay(10);
    }
}
