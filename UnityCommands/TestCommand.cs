using UnityEngine;
using System.Collections;
using System;

namespace UnityCommands.CommandSystem
{
    public class TestCommand : Command
    {
        public new string commandName = "Test Command";

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override void Log(string text)
        {
            Debug.Log(commandName + ": " + text);
        }

        public override void Error(string text)
        {
            Debug.Log(commandName + ": " + text);
        }

        public override void Warning(string text)
        {
            Debug.Log(commandName + ": " + text);
        }
    }
}
