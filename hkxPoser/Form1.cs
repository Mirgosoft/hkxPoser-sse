using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hkxPoser
{
    public partial class Form1 : Form
    {
        internal Viewer viewer = null;

        public Form1(Settings settings)
        {
            InitializeComponent();

            Flamin.Init(this, timer_Update, button_PlayPausePlayback,
                        checkBox_ShowBones, numericUpDown_MaxFPS,
                        trackBar1, label_TotalFrames, label_Duration, 
                        checkBox_SmoothFrames, label_FPS);

            this.ClientSize = settings.ClientSize;
            viewer = new Viewer(settings);
            viewer.LoadAnimationEvent += delegate(object sender, EventArgs args)
            {
                trackBar1.Maximum = viewer.GetNumFrames()-1;
                trackBar1.Value = 0;
            };
            if (viewer.InitializeGraphics(this))
            {
                timer_Update.Enabled = true;
            }

            Flamin.LoadFormWndSizes();
        }

        private void timer_Update_Tick(object sender, EventArgs e)
        {
            Flamin.UpdateTimeline();
            viewer.Update();
            viewer.Render();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewer.command_man.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewer.command_man.Redo();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "hkx files|*.hkx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string source_file = dialog.FileName;
                viewer.LoadAnimation(source_file);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "out.hkx";
            dialog.Filter = "hkx files|*.hkx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dest_file = dialog.FileName;
                viewer.SaveAnimation(dest_file);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            viewer.SetCurrentPose(trackBar1.Value);
            label_CurrentFrame.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e) {
            Flamin.MoveTrackBarToMouseClickPos(trackBar1, e.X);
        }
        
        private void trackBar1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                Flamin.MoveTrackBarToMouseClickPos(trackBar1, e.X);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string source_file in (string[])e.Data.GetData(DataFormats.FileDrop))
                    viewer.LoadAnimation(source_file);
            }
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
        }

        private void button_PlayPauseAnim_Click(object sender, EventArgs e) {
            Flamin.ToggleAnimationPlayback();
        }
        private void checkBox_SmoothFrames_CheckedChanged(object sender, EventArgs e) {
            Flamin.SetFramesSmoothing(checkBox_SmoothFrames.Checked);
        }

        private void checkBox_ShowBones_CheckedChanged(object sender, EventArgs e) {
            Flamin.SetBonesDisplay(checkBox_ShowBones.Checked);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Flamin.SaveSettings();
        }

        private void numericUpDown_MaxFPS_ValueChanged(object sender, EventArgs e) {
            Flamin.ChangeMaxFPS((int)numericUpDown_MaxFPS.Value);
        }

    }
}
