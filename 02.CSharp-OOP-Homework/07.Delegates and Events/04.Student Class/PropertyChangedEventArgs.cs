using System;

namespace _04.Student_Class
{
    public class PropertyChangedEventArgs : EventArgs
    {
        private string propertyName;
        private dynamic oldValue;
        private dynamic newValue;

        public PropertyChangedEventArgs(string propertyName,dynamic oldValue,dynamic newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }
}
