using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SupervisorWebService.Five9SupervisorService;
using System.ServiceModel;
using System.Threading;
using System.ServiceModel.Security;

namespace SupervisorWebService
{

    public class GetStatisticsUpdateThread
    {
        public GetStatisticsUpdateThread(WsSupervisorClient client, long lastTimestamp)
        {
            this.supervisorClient = client;
            this.lastTimestamp = lastTimestamp;
        }

        public const long LONG_POLLING_TIMEOUT = 5000L;

        private WsSupervisorClient supervisorClient = null;
        private long lastTimestamp = 0;

        public delegate void LastTimestampChangedEventHandler(LastTimestampChangedEventArgs e);
        public event LastTimestampChangedEventHandler LastTimestampChanged;

        public delegate void StatisticChangedEventHandler(StatisticChangedEventArgs e);
        public event StatisticChangedEventHandler StatisticChanged;

        public void Run()
        {
            while (true)
            {
                Five9SupervisorService.getStatisticsUpdate statistics
                    = new Five9SupervisorService.getStatisticsUpdate();
                statistics.statisticTypeSpecified = true;
                statistics.statisticType = statisticType.AgentState;
                statistics.longPollingTimeout = LONG_POLLING_TIMEOUT;
                statistics.previousTimestamp = this.lastTimestamp;

                try
                {
                    Log("getStatisticsUpdate started, timeout: " + LONG_POLLING_TIMEOUT);
                    DateTime pollStart = DateTime.Now;
                    Five9SupervisorService.getStatisticsUpdateResponse resp
                        = supervisorClient.getStatisticsUpdate(statistics);

                    if (resp.@return == null)
                    {
                        Log("getStatisticsUpdate type: " + statistics.statisticType.ToString()
                            + " - empty response");
                    }
                    else
                    {
                        Five9SupervisorService.statisticsUpdate statistics_return = resp.@return;
                        // track last update timestamp
                        this.lastTimestamp = statistics_return.lastTimestamp;
                        LastTimestampChanged(new LastTimestampChangedEventArgs(this.lastTimestamp));
                        StatisticChanged(new StatisticChangedEventArgs(statistics_return));

                        // ensure we don't overrun the API quota limits during periods 
                        // of quick statistic updates. Standard limits are 12 updates
                        // per statistic per minute, or every 5 seconds.
                        double pollTime = DateTime.Now.Subtract(pollStart).TotalMilliseconds;
                        //Log("pollTime: " + pollTime);
                        if (pollTime < LONG_POLLING_TIMEOUT)
                        {
                            double pollWait = LONG_POLLING_TIMEOUT - pollTime;
                            //Log("pollWait: " + pollWait);
                            Thread.Sleep((int)pollWait);
                        }
                    }
                }
                catch (MessageSecurityException mse)
                {
                    Log("MessageSecurityException: " + mse.Message);
                }
                catch (FaultException ex)
                {
                    Log("FaultException: Code: " + ex.Code + ", Reason: " + ex.Reason);
                }
            }
        }

        public class LastTimestampChangedEventArgs : EventArgs
        {
            public LastTimestampChangedEventArgs(long Timestamp)
            {
                this.Timestamp = Timestamp;
            }

            public long Timestamp { get; set; }
        }

        public class StatisticChangedEventArgs : EventArgs
        {
            public StatisticChangedEventArgs(Five9SupervisorService.statisticsUpdate update)
            {
                this.Update = update;
            }

            public Five9SupervisorService.statisticsUpdate Update { get; set; }
        }

        private void Log(string msg)
        {
            // method takes care of 
            // cross-thread invoke
            Form1.Log(msg);
        }
    }
}
