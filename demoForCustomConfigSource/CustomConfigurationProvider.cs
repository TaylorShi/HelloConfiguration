using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace demoForExtSource
{
    internal class CustomConfigurationProvider : ConfigurationProvider
    {
        readonly Timer timer;

        public CustomConfigurationProvider(): base()
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 3000;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 加载数据
            Load(true);
        }

        public override void Load()
        {
            // 加载数据
            Load(false);
        }

        void Load(bool reload)
        {
            this.Data["lastTime"] = DateTime.Now.ToString();
            if (reload)
            {
                base.OnReload();
            }
        }
    }
}
