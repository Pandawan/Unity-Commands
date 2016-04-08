using UnityEngine;
using System.Collections;
using UnityCommands.CommandSystem;
using UnityCommands.GUISystem;


public class Test : MonoBehaviour
{
    Command cmdTest = new TestCommand();
    ListCommands cmdHelp = new Help();
    CommandGUI cmdGUI = new CommandGUI();

    void Start()
    {
        //cmdTest.Log("Test");
        cmdHelp.Add("Test Command", "Test", true);
        cmdHelp.Add("Test Command 2", "Test 2", true);
        cmdHelp.Execute();

        cmdGUI.Add("Hola 0");
        cmdGUI.Add("Hola 1");
        cmdGUI.Add("Hola 2");
        cmdGUI.Add("Hola 3");
        cmdGUI.Add("Hola 4");
        cmdGUI.Add("Hola 5");



        cmdGUI.DisplayList();
    }
}
