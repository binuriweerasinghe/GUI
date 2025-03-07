namespace FitEaseDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnWorkoutPlan = new System.Windows.Forms.Button();
            this.btnMealPlan = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWorkout = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.txtExercise = new System.Windows.Forms.TextBox();
            this.lstExercises = new System.Windows.Forms.ListBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnUpdateExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorkoutPlan
            // 
            this.btnWorkoutPlan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnWorkoutPlan.Location = new System.Drawing.Point(158, 53);
            this.btnWorkoutPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWorkoutPlan.Name = "btnWorkoutPlan";
            this.btnWorkoutPlan.Size = new System.Drawing.Size(56, 19);
            this.btnWorkoutPlan.TabIndex = 0;
            this.btnWorkoutPlan.Text = "Workout Plan";
            this.btnWorkoutPlan.UseVisualStyleBackColor = true;
            // 
            // btnMealPlan
            // 
            this.btnMealPlan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMealPlan.Location = new System.Drawing.Point(303, 53);
            this.btnMealPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMealPlan.Name = "btnMealPlan";
            this.btnMealPlan.Size = new System.Drawing.Size(56, 19);
            this.btnMealPlan.TabIndex = 1;
            this.btnMealPlan.Text = "Meal Plan";
            this.btnMealPlan.UseVisualStyleBackColor = true;
            this.btnMealPlan.Click += new System.EventHandler(this.btnMealPlan_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProfile.Location = new System.Drawing.Point(303, 232);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(56, 19);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(303, 195);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 19);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWorkout
            // 
            this.lblWorkout.AutoSize = true;
            this.lblWorkout.Location = new System.Drawing.Point(79, 89);
            this.lblWorkout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkout.Name = "lblWorkout";
            this.lblWorkout.Size = new System.Drawing.Size(75, 13);
            this.lblWorkout.TabIndex = 4;
            this.lblWorkout.Text = "Workout Plan:";
            this.lblWorkout.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(319, 89);
            this.lblBreakfast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(55, 13);
            this.lblBreakfast.TabIndex = 5;
            this.lblBreakfast.Text = "Breakfast:";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(319, 120);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(40, 13);
            this.lblLunch.TabIndex = 6;
            this.lblLunch.Text = "Lunch:";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(318, 153);
            this.lblDinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(41, 13);
            this.lblDinner.TabIndex = 7;
            this.lblDinner.Text = "Dinner:";
            // 
            // txtExercise
            // 
            this.txtExercise.Location = new System.Drawing.Point(158, 86);
            this.txtExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExercise.Name = "txtExercise";
            this.txtExercise.Size = new System.Drawing.Size(76, 20);
            this.txtExercise.TabIndex = 8;
            // 
            // lstExercises
            // 
            this.lstExercises.FormattingEnabled = true;
            this.lstExercises.Location = new System.Drawing.Point(158, 109);
            this.lstExercises.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(91, 69);
            this.lstExercises.TabIndex = 9;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(158, 184);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(56, 19);
            this.btnAddExercise.TabIndex = 10;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.Location = new System.Drawing.Point(158, 208);
            this.btnDeleteExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteExercise.TabIndex = 11;
            this.btnDeleteExercise.Text = "Delete Exercise";
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // btnUpdateExercise
            // 
            this.btnUpdateExercise.Location = new System.Drawing.Point(158, 232);
            this.btnUpdateExercise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateExercise.Name = "btnUpdateExercise";
            this.btnUpdateExercise.Size = new System.Drawing.Size(56, 19);
            this.btnUpdateExercise.TabIndex = 12;
            this.btnUpdateExercise.Text = "Update Exercise";
            this.btnUpdateExercise.UseVisualStyleBackColor = true;
            this.btnUpdateExercise.Click += new System.EventHandler(this.btnUpdateExercise_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnUpdateExercise);
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.lstExercises);
            this.Controls.Add(this.txtExercise);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.lblWorkout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnMealPlan);
            this.Controls.Add(this.btnWorkoutPlan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorkoutPlan;
        private System.Windows.Forms.Button btnMealPlan;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWorkout;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.TextBox txtExercise;
        private System.Windows.Forms.ListBox lstExercises;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnDeleteExercise;
        private System.Windows.Forms.Button btnUpdateExercise;
    }
}