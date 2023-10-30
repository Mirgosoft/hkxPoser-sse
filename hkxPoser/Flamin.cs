using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hkxPoser
{
    public static class Flamin
    {
        static Form1 _mainForm = null;
        static Timer _timerUpdate = null;
        static Button _playPauseButton = null;
        static CheckBox _checkBox_ShowBones = null;
        static CheckBox _checkBox_SmoothFrames = null;
        static TrackBar _trackBar_Timeline = null;
        static NumericUpDown _numeric_MaxFPS = null;
        static Label _labelTotalFrames = null;
        static Label _labelDuration = null;
        static Label _label_FPS = null;

        static hkaAnimation _anim = null;

        static bool _bShowBones = true;
        static bool _bAnimIsPlaying = false;
        static bool _bSmoothFrames = false;
        static int _maxFPS = 30;

        #region Timer Values

        static float _animFrameTime = 1f; // Время между кадрами самой анимации.
        static float _animCurrTime = 0f; // Текущее временная точка в анимации.
        static float _animCurrFrame = 0f;// Точное положение тек. кадра, даже если он между кадрами.

        #endregion

        // Под временные данные.
        static hkaPose _pose_Temp = new hkaPose();
        static hkaPose _pose_1 = new hkaPose();
        static hkaPose _pose_2 = new hkaPose();


        public static void Init(Form1 main_form, Timer timer_update,
                                Button play_pause_button, CheckBox checkbox_show_bones,
                                NumericUpDown numeric_MaxFPS, TrackBar trackBar_Timeline,
                                Label label_total_frames, Label label_duration,
                                CheckBox checkBox_SmoothFrames, Label label_FPS)
        {
            _mainForm = main_form;
            _timerUpdate = timer_update;
            _playPauseButton = play_pause_button;
            _checkBox_SmoothFrames = checkBox_SmoothFrames;
            _checkBox_ShowBones = checkbox_show_bones;
            _numeric_MaxFPS = numeric_MaxFPS;
            _trackBar_Timeline = trackBar_Timeline;
            _labelTotalFrames = label_total_frames;
            _labelDuration = label_duration;
            _label_FPS = label_FPS;
            FlaminGeneral.OnUpdateCounter += (object obj, EventArgs e) => {
                _label_FPS.Text = "FPS: " + FlaminGeneral.TimesPerSecond;
            };
            LoadSettings();
        }

        public static void SetAnimation(hkaAnimation anim) {
            _anim = anim;
            _animFrameTime = _anim.duration / _anim.numOriginalFrames;
            _animCurrTime = 0f;
            _labelTotalFrames.Text = "Frames: " + _anim.numOriginalFrames; 
            _labelDuration.Text = "Duration: " + _anim.duration.ToString("0.0#####") + " s";

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("##################################################");
            Console.WriteLine("##             New Animation Loaded             ##");
            Console.WriteLine("##################################################");
            Console.WriteLine("");
            Console.WriteLine("Duration: " + anim.duration);
            Console.WriteLine("Frames: " + anim.numOriginalFrames);
            Console.WriteLine("Transforms num: " + anim.numTransforms);
            Console.WriteLine("");
            Console.WriteLine("Annotations ("+ anim.annotations.Length+ ") : ");
            foreach (Annotation annotation in anim.annotations) 
                Console.WriteLine(annotation.time.ToString("0.0000") 
                    + "   " + annotation.text );
            Console.WriteLine("");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("");
        }

        public static void UpdateTimeline() {
            FlaminGeneral.UpdateDeltaTime();

            if (!_bAnimIsPlaying)
                return;

            _animCurrTime += FlaminGeneral.DeltaSeconds;
            _animCurrTime = _animCurrTime % _anim.duration;
            _animCurrFrame = _animCurrTime / _anim.duration * (_anim.numOriginalFrames - 1);

            int new_frame = (int)_animCurrFrame;

            int curr_frame = _trackBar_Timeline.Value;
            if (new_frame == curr_frame) {
                if (!_bSmoothFrames)
                    return;
                _mainForm.viewer.SetCurrentPose(new_frame);
            }
            _trackBar_Timeline.Value = new_frame;
        }

        /// <summary>
        /// Попытка рассчитать промежуточный кадр, если требуется
        /// </summary>
        /// <param name="default_frame_i"></param>
        public static hkaPose TryGetAccuratePose(int default_frame_i) {
            FlaminGeneral.PlusCounter();/////////////////

            if (!_bAnimIsPlaying || !_bSmoothFrames)
                return _anim.pose[default_frame_i];

            if (_animCurrFrame > (_anim.numOriginalFrames - 1) || _animCurrFrame < 0f)
                return _anim.pose[default_frame_i];

            // Если всё хорошо, то берём 2 кадра (до и после тек. временной точки).
            int pose_1_i = (int)(_animCurrFrame);
            int pose_2_i = (int)(Math.Ceiling(_animCurrFrame));

            _pose_1 = _anim.pose[pose_1_i];
            _pose_2 = _anim.pose[pose_2_i];

            float influence = _animCurrFrame % 1; // Степерь близости к  _pose_2, чем к _pose_1.

            int count_bones = Math.Min(_pose_1.transforms.Length, _pose_2.transforms.Length);
            if (_pose_Temp.transforms == null || count_bones != _pose_Temp.transforms.Length) {
                _pose_Temp.transforms = new Transform[count_bones];
                for (int i = 0; i < count_bones; i++)
                    _pose_Temp.transforms[i] = new Transform();
                //Console.WriteLine("Recreated Pose Transforms Array.");
            }
            
            // Интерполяция между кадрами.
            for (int i = 0; i < count_bones; i++) {
                _pose_Temp.transforms[i].translation = SharpDX.Vector3.Lerp(
                    _pose_1.transforms[i].translation, 
                    _pose_2.transforms[i].translation, 
                    influence
                    );
                _pose_Temp.transforms[i].rotation = SharpDX.Quaternion.Slerp(
                    _pose_1.transforms[i].rotation,
                    _pose_2.transforms[i].rotation,
                    influence
                    );
                _pose_Temp.transforms[i].scale = (_pose_2.transforms[i].scale - _pose_1.transforms[i].scale) 
                    * influence + _pose_1.transforms[i].scale;
            }

            return _pose_Temp;
        }

        public static void MoveTimelineToFrame(int frame_num) {
            if (_anim == null)
                return;
            frame_num = frame_num % (_anim.numOriginalFrames - 1);
            _animCurrTime = ((float)frame_num / (_anim.numOriginalFrames - 1) * _anim.duration);
        }

        public static void SetAnimPlayback(bool state) {
            _bAnimIsPlaying = state;
            _playPauseButton.Text = state ? "Pause" : "Play";
            if (_bAnimIsPlaying)
                MoveTimelineToFrame(_trackBar_Timeline.Value);
        }
        public static void ToggleAnimationPlayback() => SetAnimPlayback(!_bAnimIsPlaying);
        public static bool IsAnimPlaying() => _bAnimIsPlaying;

        public static void SetBonesDisplay(bool state, bool forced = false) {
            if (forced) {
                _checkBox_ShowBones.Checked = state;
                return;
            }
            _bShowBones = state;
        }
        public static bool IsShowedBones() => _bShowBones;

        public static void SetFramesSmoothing(bool state, bool forced = false) {
            if (forced) {
                _checkBox_SmoothFrames.Checked = state;
                return;
            }
            _bSmoothFrames = state;
        }

        public static void ChangeMaxFPS(int fps_max, bool forced = false) {
            if (forced)
                _numeric_MaxFPS.Value = fps_max;
            _maxFPS = fps_max;
            _timerUpdate.Interval = (int)(1000.0f / fps_max);
        }

        public static void MoveTrackBarToMouseClickPos(TrackBar track_bar, int a_mouseX)
        {
            int frame = Convert.ToInt32(((double)a_mouseX / (double)track_bar.Width) 
                                            * (track_bar.Maximum - track_bar.Minimum));
            if (frame > track_bar.Maximum)
                frame = track_bar.Maximum;
            else if (frame < track_bar.Minimum)
                frame = track_bar.Minimum;

            MoveTimelineToFrame(frame);
            track_bar.Value = frame;
        }

        #region Settings

        public static void SaveSettings() {
            Properties.Settings.Default.bones_displaying = _bShowBones;
            Properties.Settings.Default.is_playing = _bAnimIsPlaying;
            Properties.Settings.Default.max_fps = _maxFPS;
            Properties.Settings.Default.smooth_frames = _bSmoothFrames;

            int wnd_w = _mainForm.Width;
            int wnd_h = _mainForm.Height;
            if (wnd_w < 600) wnd_w = 600;
            if (wnd_h < 300) wnd_h = 300;
            Properties.Settings.Default.wnd_w = wnd_w;
            Properties.Settings.Default.wnd_h = wnd_h;

            Properties.Settings.Default.Save();
        }

        static void LoadSettings() {
            SetBonesDisplay(Properties.Settings.Default.bones_displaying, true);
            SetAnimPlayback(Properties.Settings.Default.is_playing);
            ChangeMaxFPS(Properties.Settings.Default.max_fps, true);
            SetFramesSmoothing(Properties.Settings.Default.smooth_frames, true);
        }

        public static void LoadFormWndSizes() {
            int wnd_w = Properties.Settings.Default.wnd_w;
            int wnd_h = Properties.Settings.Default.wnd_h;
            if (wnd_w > Screen.PrimaryScreen.Bounds.Width)
                wnd_w = Screen.PrimaryScreen.Bounds.Width;
            if (wnd_h > Screen.PrimaryScreen.Bounds.Height)
                wnd_h = Screen.PrimaryScreen.Bounds.Height;
            _mainForm.Width = wnd_w;
            _mainForm.Height = wnd_h;
        }

        #endregion
    }
}
