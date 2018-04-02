using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Zheon.WpfCommon.Annotations;

namespace Zheon.WpfCommon
{
    public abstract class ObservableObject : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}