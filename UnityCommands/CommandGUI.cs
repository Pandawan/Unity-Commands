using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityCommands.GUISystem
{

    public class CommandGUI : MonoBehaviour
    {

        public string[] chat = new string[6];
        private List<string> log = new List<string>();

        void OnGUI()
        {
            GUI.Box(new Rect(new Rect(Screen.width / 2 - 220, Screen.height / 2 - 100, 440, 200)), "Enter a Command");

            GUIStyle style = GUI.skin.GetStyle("Label");
            style.normal.textColor = Color.white;

            for (int i = 0; i < chat.Length; i++)
            {
                GUI.Label(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 60 + (i * 20), 400, 20), i + " "+ chat[i]);
            }
        }

        public void Add(string param)
        {
            log.Add(param);

            for (int i = 0; i < chat.Length; i++)
            {
                if (i != 5)
                {
                    chat[i] = chat[i + 1];
                }
            }

            chat[5] = param;
        }

        public void DisplayList ()
        {
            for (int i = 0; i < chat.Length; i++)
            {
                Debug.Log(chat[i]);
            }
        }
    }
}
