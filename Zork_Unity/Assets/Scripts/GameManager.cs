﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFilename = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UniyInputService InputService;

    private Game Game { get; set; }

    [SerializeField]
    private TMP_Text ScoreText;

    [SerializeField]
    private TMP_Text MovesText;

    void Start()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFilename);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);

        Game.Output.WriteLine("Welcome To Zork!");
        Game.CommandManager.PerformCommand(Game, "LOOK");

        for(int i = 0; i < 20; i++)
        {
            Game.Output.WriteLine(0);
        }

        InputService.InputField.Select();
        InputService.InputField.ActivateInputField();
        InputService.InputField.text = string.Empty;
    }

    void Awake()
    {
        InputService.InputField.Select();
        InputService.InputField.ActivateInputField();
        InputService.InputField.text = string.Empty;

        Game.Player.PlayerMoved += mPlayerMoved;
        Game.Player.ScoreChanged += mScoreChanged;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
            }
            InputService.ProcessInput();
            InputService.InputField.text = string.Empty;
        }
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private void mPlayerMoved(object sender, int e)
    {
        MovesText.text = $"Moves: {Game.Player.Moves}";
    }
    private void mScoreChanged(object sender, int e)
    {
        ScoreText.text = $"Score: {Game.Player.Score}";
    }
}
