using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityCommands.CommandSystem
{
    public abstract class Command
    {
        protected string commandName = "Unknown Command";

        // Execute any action you want, override this with whatever you want to do when the command is executed
        public abstract void Execute();

        // Logs using the command's name
        public virtual void Log(string text) { Debug.Log(commandName + ": " + text); }

        // Warns using the command's name
        public virtual void Warning(string text) { Debug.LogWarning(commandName + ": " + text); }

        // Log error using the command's name
        public virtual void Error(string text) { Debug.LogError(commandName + ": " + text); }
    }

    public abstract class ListCommands : Command
    {
        protected List<string> list = new List<string>();

        /// <summary>
        /// Add an item to the list
        /// </summary>
        /// <param name="text"></param>
        /// <param name="sort"> Whether or not you want to sort the list after adding it</param>
        public virtual void Add (string text, bool sort)
        {
            list.Add(text);
            if (sort) 
                list.Sort();
        }

        /// <summary>
        /// Add one item to the list. Ex: "Param1 - Param 2"
        /// </summary>
        /// <param name="param1"> Anything...</param>
        /// <param name="param2"> Anything...</param>
        /// /// <param name="sort"> Whether or not you want to sort the list after adding it.</param>
        public virtual void Add(string param1, string param2, bool sort)
        {
            list.Add(param1 + " - " + param2);
            if (sort)
                list.Sort();
        }
    }
}
