using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaTekBot.Features
{
    public class ExperienceChecker : IDisposable
    {
        private Timer ExperienceTimer;
        private Tibia Client;

        public ulong _LastExperience = 0;

        public ExperienceChecker(Kernel kernel)
        {
            this.Client = kernel.Client;
            _Active = false;
            ExperienceTimer = new Timer(1000, -1);
            ExperienceTimer.Execute += ExperienceTimer_Execute;
        }

        private bool _Active = false;
        public bool Active {
            get
            {
                return _Active;
            }
            set
            {
                _Active = value;
                if (value)
                {
                    ExperienceTimer.Start();
                } else
                {
                    ExperienceTimer.Stop();
                    Client.Title = "TibiaTek Bot";
                }
            }
        }
 
        private void ExperienceTimer_Execute(object sender, EventArgs e)
        {
            if (Client.IsConnected && Active)
            {
                if (Client.LocalPlayer.Level == 0 || Client.LocalPlayer.Experience == 0)
                {
                    return;
                }
                ulong experience = Client.LocalPlayer.Experience;
                //if (_LastExperience == experience)
                //{
                //    return;
                //}
                //_LastExperience = experience;
                uint level = Client.LocalPlayer.Level;
                ulong currentLevelExp = Utilities.ConvertLevelToExperience(level);
                ulong nextLevelExp = Utilities.ConvertLevelToExperience(level + 1);
                double percentToGo = (experience - currentLevelExp) * 100.0 / (nextLevelExp - currentLevelExp);
                
                string title = String.Format("TibiaTek Bot - {0} - Exp. For Level {1}: {2:0,0} ({3:0}% to go)", Client.LocalPlayer.Name, level + 1, nextLevelExp - experience, Math.Ceiling(100.0 - percentToGo));
                uint rate = Client.LocalPlayer.ExperienceRate;
                if (rate > 0)
                {
                    double hours = (nextLevelExp - experience) / (double)rate;                  
                    double minutes = (hours - Math.Floor(hours)) * 60.0;
                    hours = Math.Floor(hours);
                    if (hours >= 1)
                    {
                        title += String.Format(" - Level Up In {0:,0}h {1:00}m @ {2:0,0} exp/hr", hours, minutes, rate);
                    }
                    else
                    {
                        title += String.Format(" - Level Up In {0:0}m @ {1:0,0} exp/hr", minutes, rate);
                    }
                    
                }
                Client.Title = title;

            }
            else
            {
                Client.Title = "TibiaTek Bot";
            }

            

            //ulong nextLevelExp = Utilities.ConvertLevelToExperience()
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (ExperienceTimer != null && ExperienceTimer.Running)
                    {
                        ExperienceTimer.Stop();                        
                    }
                    ExperienceTimer.Dispose();
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ExperienceChecker() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
