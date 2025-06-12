namespace Assignment_10._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblGPA = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtGPA = new TextBox();
            txtAddress = new TextBox();
            btnCreateStudent = new Button();
            btnJSONSer = new Button();
            btnJSONDES = new Button();
            btnXMLSER = new Button();
            XMLDES = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ButtonFace;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(149, 69);
            lblId.Name = "lblId";
            lblId.Size = new Size(84, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Student ID";
            lblId.UseMnemonic = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonFace;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(149, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(110, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Student Name";
            lblName.UseMnemonic = false;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.ButtonFace;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(149, 183);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(125, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Student Address";
            lblAddress.UseMnemonic = false;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.BackColor = SystemColors.ButtonFace;
            lblGPA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGPA.Location = new Point(149, 237);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(98, 20);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "Student GPA";
            lblGPA.UseMnemonic = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(507, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(246, 27);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(507, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 27);
            txtName.TabIndex = 5;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(507, 237);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(246, 27);
            txtGPA.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(507, 176);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.BackColor = SystemColors.ActiveBorder;
            btnCreateStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateStudent.Location = new Point(364, 308);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(140, 51);
            btnCreateStudent.TabIndex = 8;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = false;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // 
            // btnJSONSer
            // 
            btnJSONSer.BackColor = SystemColors.ActiveBorder;
            btnJSONSer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJSONSer.Location = new Point(181, 398);
            btnJSONSer.Name = "btnJSONSer";
            btnJSONSer.Size = new Size(159, 33);
            btnJSONSer.TabIndex = 9;
            btnJSONSer.Text = "JSON Serialize";
            btnJSONSer.UseVisualStyleBackColor = false;
            btnJSONSer.Click += btnJSONSer_Click;
            // 
            // btnJSONDES
            // 
            btnJSONDES.BackColor = SystemColors.ActiveBorder;
            btnJSONDES.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJSONDES.Location = new Point(183, 454);
            btnJSONDES.Name = "btnJSONDES";
            btnJSONDES.Size = new Size(157, 33);
            btnJSONDES.TabIndex = 10;
            btnJSONDES.Text = "JSON Deserialize";
            btnJSONDES.UseVisualStyleBackColor = false;
            btnJSONDES.Click += btnJSONDES_Click;
            // 
            // btnXMLSER
            // 
            btnXMLSER.BackColor = SystemColors.ActiveBorder;
            btnXMLSER.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXMLSER.Location = new Point(544, 398);
            btnXMLSER.Name = "btnXMLSER";
            btnXMLSER.Size = new Size(155, 33);
            btnXMLSER.TabIndex = 11;
            btnXMLSER.Text = "XML Serialize";
            btnXMLSER.UseVisualStyleBackColor = false;
            btnXMLSER.Click += btnXMLSER_Click;
            // 
            // XMLDES
            // 
            XMLDES.BackColor = SystemColors.ActiveBorder;
            XMLDES.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XMLDES.Location = new Point(544, 454);
            XMLDES.Name = "XMLDES";
            XMLDES.Size = new Size(155, 33);
            XMLDES.TabIndex = 12;
            XMLDES.Text = "XML Deserialize";
            XMLDES.UseVisualStyleBackColor = false;
            XMLDES.Click += XMLDES_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 617);
            Controls.Add(XMLDES);
            Controls.Add(btnXMLSER);
            Controls.Add(btnJSONDES);
            Controls.Add(btnJSONSer);
            Controls.Add(btnCreateStudent);
            Controls.Add(txtAddress);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblGPA);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private Label lblGPA;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtGPA;
        private TextBox txtAddress;
        private Button btnCreateStudent;
        private Button btnJSONSer;
        private Button btnJSONDES;
        private Button btnXMLSER;
        private Button XMLDES;
    }
}
