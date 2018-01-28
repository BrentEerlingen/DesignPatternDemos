using System;

namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// defines a binding between a Receiver object (Calculator) and an action
    /// implements Execute by invoking the corresponding operation(s) on Receiver (Calculator)
    /// </summary>
    public class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            get => _operator;
        }

        public int Operand
        {
            get => _operand;
        }

        // Execute new command
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
                        ArgumentException("@operator");
            }
        }
    }
}