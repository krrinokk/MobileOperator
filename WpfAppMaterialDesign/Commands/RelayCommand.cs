using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfAppMaterialDesign.Commands
{
    /// <summary>
    /// Реализация команды без конкретизации метода выполнения. 
    /// Методы CanExecute и Execute передаются в конструктор.
    /// Возможно написание отдельного класса для конкретной команды, в таком случае
    /// упомянутые выше команды необходимо будет реализовавать в явном виде
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Конструктор команды без явного указания методов выполнения и активности
        /// </summary>
        /// <param name="execute">Метод, выполняемый при вызове команды</param>
        /// <param name="canExecute">Метод, возвращающий логическое значение, определяющее
        /// доступна ли команда. Если = null, команда доступна всегда</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
