using System;
using System.Diagnostics;

namespace hkxPoser
{
    static class FlaminGeneral
    {
        public static float DeltaTime = 0f;     // в мсек.
        public static float DeltaTicks = 0f;    // в тиках (мсек * 10000);
        public static float DeltaSeconds = 0f;  // в сек.

        public static int TimesPerSecond = 0; // Сколько раз за секунду сработает ф-ция PlusCounter();


        static Stopwatch _stopWatch = new Stopwatch();

        public static void UpdateDeltaTime()
        {
            DeltaTicks = _stopWatch.ElapsedTicks;
            DeltaTime = DeltaTicks / 10000f;
            DeltaSeconds = DeltaTicks / 10000000;
            _counterPerSecond_Time += DeltaTime;
            VerifyCounter();
            _stopWatch.Restart();
        }


        #region Counter Per Second

        static int _counterPerSecond = 0;
        static float _counterPerSecond_Time = 0f;

        public static void PlusCounter() {
            _counterPerSecond++;
            VerifyCounter();
        }

        public static void VerifyCounter() {
            if (_counterPerSecond_Time < 1000f)
                return;
            TimesPerSecond = _counterPerSecond;
            UpdateCounter(TimesPerSecond);
            _counterPerSecond = 0;
            _counterPerSecond_Time = 0f;
        }

        static void UpdateCounter(int count_frames_to_show) {
            if (OnUpdateCounter != null)
                OnUpdateCounter(null, EventArgs.Empty);
        }

        public static event EventHandler OnUpdateCounter;


        #endregion
    }
}