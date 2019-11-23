namespace HumanBehaviorModelling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_Connection = new System.Windows.Forms.TabPage();
            this.label_connectionState = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_nextStep = new System.Windows.Forms.Button();
            this.dataGridView_agentParameters = new System.Windows.Forms.DataGridView();
            this.listBox_Agents = new System.Windows.Forms.ListBox();
            this.button_updInfo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage_Visual = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlMain.SuspendLayout();
            this.tabPage_Connection.SuspendLayout();
            this.tabPage_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_agentParameters)).BeginInit();
            this.tabPage_Visual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage_Connection);
            this.tabControlMain.Controls.Add(this.tabPage_View);
            this.tabControlMain.Controls.Add(this.tabPage_Visual);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(985, 637);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage_Connection
            // 
            this.tabPage_Connection.Controls.Add(this.label_connectionState);
            this.tabPage_Connection.Controls.Add(this.button_connect);
            this.tabPage_Connection.Controls.Add(this.label3);
            this.tabPage_Connection.Controls.Add(this.label2);
            this.tabPage_Connection.Controls.Add(this.label1);
            this.tabPage_Connection.Controls.Add(this.textBox3);
            this.tabPage_Connection.Controls.Add(this.textBox2);
            this.tabPage_Connection.Controls.Add(this.textBox1);
            this.tabPage_Connection.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Connection.Name = "tabPage_Connection";
            this.tabPage_Connection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connection.Size = new System.Drawing.Size(977, 611);
            this.tabPage_Connection.TabIndex = 0;
            this.tabPage_Connection.Text = "Подключение";
            this.tabPage_Connection.UseVisualStyleBackColor = true;
            // 
            // label_connectionState
            // 
            this.label_connectionState.AutoSize = true;
            this.label_connectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_connectionState.Location = new System.Drawing.Point(383, 40);
            this.label_connectionState.Name = "label_connectionState";
            this.label_connectionState.Size = new System.Drawing.Size(190, 17);
            this.label_connectionState.TabIndex = 7;
            this.label_connectionState.Text = "Состояние: Не подключено";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(185, 228);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 36);
            this.button_connect.TabIndex = 6;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "123";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "neo4j";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "7687";
            // 
            // tabPage_View
            // 
            this.tabPage_View.Controls.Add(this.label7);
            this.tabPage_View.Controls.Add(this.label6);
            this.tabPage_View.Controls.Add(this.button_nextStep);
            this.tabPage_View.Controls.Add(this.dataGridView_agentParameters);
            this.tabPage_View.Controls.Add(this.listBox_Agents);
            this.tabPage_View.Controls.Add(this.button_updInfo);
            this.tabPage_View.Controls.Add(this.textBox4);
            this.tabPage_View.Location = new System.Drawing.Point(4, 22);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_View.Size = new System.Drawing.Size(977, 611);
            this.tabPage_View.TabIndex = 1;
            this.tabPage_View.Text = "Рабочая область";
            this.tabPage_View.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(180, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество шагов:";
            // 
            // button_nextStep
            // 
            this.button_nextStep.Location = new System.Drawing.Point(29, 228);
            this.button_nextStep.Name = "button_nextStep";
            this.button_nextStep.Size = new System.Drawing.Size(100, 44);
            this.button_nextStep.TabIndex = 4;
            this.button_nextStep.Text = "Следующий шаг";
            this.button_nextStep.UseVisualStyleBackColor = true;
            this.button_nextStep.Click += new System.EventHandler(this.button_nextStep_Click);
            // 
            // dataGridView_agentParameters
            // 
            this.dataGridView_agentParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_agentParameters.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_agentParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_agentParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_agentParameters.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_agentParameters.Location = new System.Drawing.Point(258, 34);
            this.dataGridView_agentParameters.Name = "dataGridView_agentParameters";
            this.dataGridView_agentParameters.Size = new System.Drawing.Size(683, 387);
            this.dataGridView_agentParameters.TabIndex = 3;
            // 
            // listBox_Agents
            // 
            this.listBox_Agents.FormattingEnabled = true;
            this.listBox_Agents.Location = new System.Drawing.Point(29, 34);
            this.listBox_Agents.Name = "listBox_Agents";
            this.listBox_Agents.Size = new System.Drawing.Size(120, 95);
            this.listBox_Agents.TabIndex = 2;
            this.listBox_Agents.SelectedIndexChanged += new System.EventHandler(this.listBox_Agents_SelectedIndexChanged);
            // 
            // button_updInfo
            // 
            this.button_updInfo.Location = new System.Drawing.Point(29, 157);
            this.button_updInfo.Name = "button_updInfo";
            this.button_updInfo.Size = new System.Drawing.Size(100, 44);
            this.button_updInfo.TabIndex = 1;
            this.button_updInfo.Text = "Показать инфо об агентах";
            this.button_updInfo.UseVisualStyleBackColor = true;
            this.button_updInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // tabPage_Visual
            // 
            this.tabPage_Visual.Controls.Add(this.label5);
            this.tabPage_Visual.Controls.Add(this.label4);
            this.tabPage_Visual.Controls.Add(this.chart2);
            this.tabPage_Visual.Controls.Add(this.chart1);
            this.tabPage_Visual.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Visual.Name = "tabPage_Visual";
            this.tabPage_Visual.Size = new System.Drawing.Size(977, 611);
            this.tabPage_Visual.TabIndex = 2;
            this.tabPage_Visual.Text = "Визуализация";
            this.tabPage_Visual.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(531, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "График среднего количества пищи у агента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "График среднего уровня сытости агентов";
            // 
            // chart2
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(472, 32);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(509, 583);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 32);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(466, 579);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 637);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_Connection.ResumeLayout(false);
            this.tabPage_Connection.PerformLayout();
            this.tabPage_View.ResumeLayout(false);
            this.tabPage_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_agentParameters)).EndInit();
            this.tabPage_Visual.ResumeLayout(false);
            this.tabPage_Visual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_Connection;
        private System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_connectionState;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_updInfo;
        private System.Windows.Forms.ListBox listBox_Agents;
        private System.Windows.Forms.DataGridView dataGridView_agentParameters;
        private System.Windows.Forms.Button button_nextStep;
        private System.Windows.Forms.TabPage tabPage_Visual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

