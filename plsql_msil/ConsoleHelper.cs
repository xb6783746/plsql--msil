using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil
{
    public class ConsoleHelper
    {

        private class Command
        {
            public Command(string command)
            {
                this.command = command;
                this.args = new List<string>();
            }

            public string command;
            public List<string> args;
        }

        public ConsoleHelper() :this("-")
        {

        }
        public ConsoleHelper(string commandPrefix)
        {
            this.commandPrefix = commandPrefix;
            commands = new Dictionary<string, Action<List<string>>>();
        }

        private string commandPrefix;
        private Dictionary<string, Action<List<string>>> commands;

        public ConsoleHelper Register(string command, Action<List<string>> action)
        {
            commands[commandPrefix + command] = action;

            return this;
        }

        public void Parse(string[] arr)
        {

            if(arr.Length > 0 && !IsCommand(arr[0]))
            {
                return;
            }

            List<Command> comms = new List<Command>();
            Command current = null;

            foreach(var item in arr)
            {
                if(IsCommand(item))
                {
                    current = new Command(item);

                    comms.Add(current);
                }
                else
                {
                    current.args.Add(item);
                }
            }

            foreach(var item in comms)
            {
                if(commands.ContainsKey(item.command))
                {

                    commands[item.command](item.args);
                }
                else
                {
                    //
                }
            }
        }

        private bool IsCommand(string str)
        {
            return str != null && str.StartsWith(commandPrefix);
        }


    }
}
