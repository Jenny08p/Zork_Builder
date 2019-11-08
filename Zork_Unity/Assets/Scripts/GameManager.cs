using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFilename = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    private Game Game { get; set; }

    void Start()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFilename);
        Game = Game.Load(gameFileAsset.text, OutputService);

        Game.Output.WriteLine("Welcome To Zork!");
        Game.CommandManager.PerformCommand(Game, "LOOK");
    }

    void Update()
    {
        
    }
}
