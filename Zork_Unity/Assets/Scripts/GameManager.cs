using System.Collections;
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

    [SerializeField]
    private TMP_Text LocationText;

    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFilename);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);

        Game.Player.PlayerMoved += PlayerMoved;
        Game.Player.ScoreChanged += ScoreChanged;

        ScoreText.text = $"Score: {Game.Player.Score}";
        MovesText.text = $"Moves: {Game.Player.Moves}";
        LocationText.text = $"Location: {Game.Player.Location}";
    }

    void Start()
    {
        Game.Output.WriteLine("Welcome To Zork!");
        Game.CommandManager.PerformCommand(Game, "LOOK");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
                InputService.ProcessInput();
                LocationText.text = $"Location: {Game.Player.Location}";
            }
            InputService.InputField.text = string.Empty;
            InputService.InputField.ActivateInputField();
            InputService.InputField.Select();
        }

        if((Game.IsRunning == false)||(Input.GetKey("escape")))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private void PlayerMoved(object sender, int e)
    {
        MovesText.text = $"Moves: {Game.Player.Moves}";
    }
    private void ScoreChanged(object sender, int e)
    {
        ScoreText.text = $"Score: {Game.Player.Score}";
    }
}
