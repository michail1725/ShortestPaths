namespace CourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.createApex = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.useThisGraph = new System.Windows.Forms.Button();
            this.mainSheet = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.accept_weight_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.stopChanges = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.chooseItem = new System.Windows.Forms.Button();
            this.Выбрать = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.WayList = new System.Windows.Forms.ListBox();
            this.retry_choice = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.DisplayMatrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSheet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нахождение кратчайшего пути на графе";
            // 
            // createApex
            // 
            this.createApex.BackColor = System.Drawing.Color.Bisque;
            this.createApex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createApex.BackgroundImage")));
            this.createApex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createApex.Location = new System.Drawing.Point(3, 122);
            this.createApex.Name = "createApex";
            this.createApex.Size = new System.Drawing.Size(40, 43);
            this.createApex.TabIndex = 5;
            this.toolTip1.SetToolTip(this.createApex, "Добавить вершину");
            this.createApex.UseVisualStyleBackColor = false;
            this.createApex.Click += new System.EventHandler(this.createApex_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.Bisque;
            this.connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connect.BackgroundImage")));
            this.connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connect.Enabled = false;
            this.connect.Location = new System.Drawing.Point(3, 177);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(40, 41);
            this.connect.TabIndex = 6;
            this.toolTip2.SetToolTip(this.connect, "Соединить пункты");
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Bisque;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(3, 229);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(40, 40);
            this.delete.TabIndex = 7;
            this.toolTip3.SetToolTip(this.delete, "Удалить");
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Bisque;
            this.reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset.BackgroundImage")));
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(3, 278);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(40, 42);
            this.reset.TabIndex = 8;
            this.toolTip4.SetToolTip(this.reset, "Удалить всё");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(622, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите расстояние:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(580, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Матричное представление путей:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 35);
            this.label6.TabIndex = 22;
            this.label6.Text = "Кратчайший путь равен:";
            // 
            // result_label
            // 
            this.result_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.Color.Transparent;
            this.result_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.result_label.Location = new System.Drawing.Point(359, 614);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(30, 35);
            this.result_label.TabIndex = 23;
            this.result_label.Text = "0";
            this.result_label.Visible = false;
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate.BackColor = System.Drawing.Color.Bisque;
            this.Calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculate.BackgroundImage")));
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Calculate.Enabled = false;
            this.Calculate.Location = new System.Drawing.Point(622, 498);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(187, 69);
            this.Calculate.TabIndex = 25;
            this.toolTip5.SetToolTip(this.Calculate, "Произвести расчет");
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // useThisGraph
            // 
            this.useThisGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useThisGraph.BackColor = System.Drawing.Color.Bisque;
            this.useThisGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("useThisGraph.BackgroundImage")));
            this.useThisGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.useThisGraph.Enabled = false;
            this.useThisGraph.Location = new System.Drawing.Point(551, 67);
            this.useThisGraph.Name = "useThisGraph";
            this.useThisGraph.Size = new System.Drawing.Size(40, 41);
            this.useThisGraph.TabIndex = 26;
            this.useThisGraph.UseVisualStyleBackColor = false;
            this.useThisGraph.Click += new System.EventHandler(this.useThisGraph_Click);
            // 
            // mainSheet
            // 
            this.mainSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSheet.BackColor = System.Drawing.Color.Cornsilk;
            this.mainSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSheet.Location = new System.Drawing.Point(49, 67);
            this.mainSheet.MaximumSize = new System.Drawing.Size(1800, 1024);
            this.mainSheet.MinimumSize = new System.Drawing.Size(498, 510);
            this.mainSheet.Name = "mainSheet";
            this.mainSheet.Size = new System.Drawing.Size(498, 510);
            this.mainSheet.TabIndex = 0;
            this.mainSheet.TabStop = false;
            this.mainSheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainSheet_MouseClick);
            this.mainSheet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainSheet_MouseDown);
            this.mainSheet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainSheet_MouseMove);
            this.mainSheet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainSheet_MouseUp);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(609, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "От:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(698, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "До:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exportToolStripMenuItem.Text = "Экспорт";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.closeToolStripMenuItem.Text = "Закрыть программу";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(640, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(738, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // weight_box
            // 
            this.weight_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weight_box.Enabled = false;
            this.weight_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.weight_box.Location = new System.Drawing.Point(613, 114);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(79, 20);
            this.weight_box.TabIndex = 38;
            this.weight_box.Tag = "";
            this.weight_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_box_KeyPress);
            // 
            // accept_weight_btn
            // 
            this.accept_weight_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accept_weight_btn.BackColor = System.Drawing.Color.Bisque;
            this.accept_weight_btn.Enabled = false;
            this.accept_weight_btn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept_weight_btn.Location = new System.Drawing.Point(698, 110);
            this.accept_weight_btn.Name = "accept_weight_btn";
            this.accept_weight_btn.Size = new System.Drawing.Size(101, 26);
            this.accept_weight_btn.TabIndex = 39;
            this.accept_weight_btn.Text = "Принять";
            this.accept_weight_btn.UseVisualStyleBackColor = false;
            this.accept_weight_btn.Click += new System.EventHandler(this.accept_weight_btn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(617, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Найти кратчайший путь:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(747, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(707, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 21);
            this.label14.TabIndex = 42;
            this.label14.Text = "До:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(618, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 21);
            this.label15.TabIndex = 41;
            this.label15.Text = "От: ";
            // 
            // stopChanges
            // 
            this.stopChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopChanges.BackColor = System.Drawing.Color.Bisque;
            this.stopChanges.Enabled = false;
            this.stopChanges.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopChanges.Location = new System.Drawing.Point(613, 138);
            this.stopChanges.Name = "stopChanges";
            this.stopChanges.Size = new System.Drawing.Size(186, 27);
            this.stopChanges.TabIndex = 45;
            this.stopChanges.Text = "Закончить заполнение";
            this.stopChanges.UseVisualStyleBackColor = false;
            this.stopChanges.Click += new System.EventHandler(this.stopChanges_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(650, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 46;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // chooseItem
            // 
            this.chooseItem.BackColor = System.Drawing.Color.Bisque;
            this.chooseItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseItem.BackgroundImage")));
            this.chooseItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chooseItem.Enabled = false;
            this.chooseItem.Location = new System.Drawing.Point(3, 67);
            this.chooseItem.Name = "chooseItem";
            this.chooseItem.Size = new System.Drawing.Size(40, 41);
            this.chooseItem.TabIndex = 2;
            this.Выбрать.SetToolTip(this.chooseItem, "Выбрать");
            this.chooseItem.UseVisualStyleBackColor = false;
            this.chooseItem.Click += new System.EventHandler(this.chooseItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(651, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Путь наглядно:";
            // 
            // WayList
            // 
            this.WayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WayList.FormattingEnabled = true;
            this.WayList.Location = new System.Drawing.Point(622, 619);
            this.WayList.Name = "WayList";
            this.WayList.Size = new System.Drawing.Size(187, 30);
            this.WayList.TabIndex = 49;
            // 
            // retry_choice
            // 
            this.retry_choice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.retry_choice.BackColor = System.Drawing.Color.Bisque;
            this.retry_choice.BackgroundImage = global::CourseProject.Properties.Resources.png_repeat;
            this.retry_choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.retry_choice.Enabled = false;
            this.retry_choice.Location = new System.Drawing.Point(814, 444);
            this.retry_choice.Name = "retry_choice";
            this.retry_choice.Size = new System.Drawing.Size(40, 40);
            this.retry_choice.TabIndex = 50;
            this.toolTip6.SetToolTip(this.retry_choice, "Выбрать другие вершины");
            this.retry_choice.UseVisualStyleBackColor = false;
            this.retry_choice.Click += new System.EventHandler(this.retry_choice_Click);
            // 
            // DisplayMatrix
            // 
            this.DisplayMatrix.AllowUserToAddRows = false;
            this.DisplayMatrix.AllowUserToDeleteRows = false;
            this.DisplayMatrix.AllowUserToResizeColumns = false;
            this.DisplayMatrix.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DisplayMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DisplayMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayMatrix.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DisplayMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DisplayMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DisplayMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayMatrix.ColumnHeadersVisible = false;
            this.DisplayMatrix.EnableHeadersVisualStyles = false;
            this.DisplayMatrix.GridColor = System.Drawing.SystemColors.Control;
            this.DisplayMatrix.Location = new System.Drawing.Point(589, 192);
            this.DisplayMatrix.Name = "DisplayMatrix";
            this.DisplayMatrix.ReadOnly = true;
            this.DisplayMatrix.RowHeadersVisible = false;
            this.DisplayMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DisplayMatrix.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DisplayMatrix.Size = new System.Drawing.Size(260, 199);
            this.DisplayMatrix.TabIndex = 51;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::CourseProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 696);
            this.Controls.Add(this.retry_choice);
            this.Controls.Add(this.WayList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.stopChanges);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.accept_weight_btn);
            this.Controls.Add(this.weight_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.useThisGraph);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.createApex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseItem);
            this.Controls.Add(this.mainSheet);
            this.Controls.Add(this.DisplayMatrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(877, 735);
            this.Name = "MainForm";
            this.Text = "Кратчайшие пути. Графы.";
            ((System.ComponentModel.ISupportInitialize)(this.mainSheet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createApex;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button useThisGraph;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.Button accept_weight_btn;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button stopChanges;
        private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button chooseItem;
    private System.Windows.Forms.ToolTip Выбрать;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ToolTip toolTip2;
    private System.Windows.Forms.ToolTip toolTip3;
    private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox WayList;
        private System.Windows.Forms.Button retry_choice;
    private System.Windows.Forms.ToolTip toolTip5;
    private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.DataGridView DisplayMatrix;
    }
}

