namespace Command
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// MainApp startup class for Real-World 
    /// Command Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    internal abstract class Command
    {
        public abstract void Execute();

        public abstract void UnExecute();
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    internal class CalculatorCommand : Command
    {
        private readonly Calculator _calculator;

        private int _operand;

        private char _operator;

        // Constructor
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Gets operator
        public char Operator
        {
            set
            {
                this._operator = value;
            }
        }

        // Get operand
        public int Operand
        {
            set
            {
                this._operand = value;
            }
        }

        // Execute new command
        public override void Execute()
        {
            this._calculator.Operation(this._operator, this._operand);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            this._calculator.Operation(this.Undo(this._operator), this._operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    internal class Calculator
    {
        private int _curr;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    this._curr += operand;
                    break;
                case '-':
                    this._curr -= operand;
                    break;
                case '*':
                    this._curr *= operand;
                    break;
                case '/':
                    this._curr /= operand;
                    break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", this._curr, @operator, operand);
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    internal class User
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();

        private readonly List<Command> _commands = new List<Command>();

        private int _current;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (this._current < this._commands.Count - 1)
                {
                    Command command = this._commands[this._current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (this._current > 0)
                {
                    Command command = this._commands[--this._current];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(this._calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            this._commands.Add(command);
            this._current++;
        }
    }
}