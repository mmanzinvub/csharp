using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroApp {
    public class Pomodoro {
        public Pomodoro(int workDurationInMinutes, int restDurationInMinutes){
            //inicijalizacija
            WorkInProgress = true;
            WorkDurationInSeconds = workDurationInMinutes * 60;
            RestDurationInSeconds = restDurationInMinutes * 60;

            Seconds = 25 * 60;
        }

        //override ToString generated
        public override string ToString()
        {
            return string.Format("{0}:{1:00}", Seconds / 60, Seconds % 60);
        }

        public void Update()
        {
            Seconds--;
            if (Seconds <= 0)
            {
                WorkInProgress = !WorkInProgress;
                if (WorkInProgress)
                {
                    Seconds = RestDurationInSeconds;
                }
                else
                {
                    Seconds = WorkDurationInSeconds;
                }
            }
        }

        public bool WorkInProgress { get; set; }
        public int Seconds { get; set; }
        public int WorkDurationInSeconds { get; set; }
        public int RestDurationInSeconds { get; set; }

    }
}
