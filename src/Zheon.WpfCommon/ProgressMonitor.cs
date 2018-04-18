using System.Threading;
using System.Threading.Tasks;

namespace Zheon.WpfCommon
{
    /// <summary>
    /// Defines a generic thread-safe simple Progress Monitor.
    /// </summary>
    public sealed class ProgressMonitor : ObservableObject
    {
        private int _current;
        private string _description;
        private int _total;

        public int Current => _current;

        public string Description
        {
            get => _description;
            set
            {
                if (value == _description)
                {
                    return;
                }

                _description = value;
                OnPropertyChanged();
            }
        }

        public int Total
        {
            get => _total;
            set
            {
                if (value == _total)
                {
                    return;
                }

                _total = value;
                OnPropertyChanged();
            }
        }

        public void Increment()
        {
            Interlocked.Increment(ref _current);
            OnPropertyChanged(nameof(Current));
        }

        public async Task IncrementAsync()
        {
            await Task.Run(() =>
                {
                    Interlocked.Increment(ref _current);
                })
                .ContinueWith(c =>
                {
                    OnPropertyChanged(nameof(Current));
                }, TaskScheduler.Default);
        }
    }
}