using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityCommands.CommandSystem
{
    public class Help : ListCommands
    {
        public new string commandName = "Help";

        protected List<string> helpInfo = new List<string>();

        public override void Execute()
        {
            string finalHelp = "--- Help ---";

            for (int i = 0; i < helpInfo.Count; i++)
            {
                finalHelp += "\n" + helpInfo[i];
            }
            Log(finalHelp);
        }

        /// <summary>
        /// Add a command to the help menu.
        /// </summary>
        /// <param name="param1"> The Command itself. Ex: /test </param>
        /// <param name="param2"> Info/Explanation about the command. </param>
        /// /// <param name="sort"> Whether or not you want to sort the list after adding it.</param>
        public override void Add(string param1, string param2, bool sort)
        {
            helpInfo.Add(param1 + " - " + param2);

            if (sort)
                list.Sort();
        }

        // Logs using the command's name
        public override void Log(string text) { Debug.Log(commandName + ": " + text); }

        // Warns using the command's name
        public override void Warning(string text) { Debug.LogWarning(commandName + ": " + text); }

        // Log error using the command's name
        public override void Error(string text) { Debug.LogError(commandName + ": " + text); }
    }
}
