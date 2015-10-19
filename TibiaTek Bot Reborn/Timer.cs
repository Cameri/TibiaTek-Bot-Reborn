using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TibiaTekBot
{
    class Timer : IDisposable
    {
        private System.Threading.Timer _Timer;
        public bool Running { get; private set; }

        public event EventHandler Execute;

        private int _Period = 1000;
        public int Period {
            get
            {
                return _Period;
            }
            set
            {
                _Period = value;
                _Timer.Change(Running ? value : Timeout.Infinite, value);
            }
        }

        public Timer(int period = 0, int dueTime = Timeout.Infinite)
        {
            Running = (dueTime != Timeout.Infinite);
            _Period = period;
            _Timer = new System.Threading.Timer(new TimerCallback(Tick), this, dueTime, period);
        }

        public void Start(int dueTime = 0)
        {
            Running = true;
            _Timer.Change(dueTime, _Period);
        }

        public void Stop()
        {
            Running = false;
            _Timer.Change(Timeout.Infinite, 0);
        }

        private void Tick(object state)
        {
            if (!Running)
            {
                return;
            }
            lock (this)
            {
                if (Execute != null)
                {
                    Execute.Invoke(state, new EventArgs());
                }
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Stop();
                    _Timer.Dispose();
                }
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Timer() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
