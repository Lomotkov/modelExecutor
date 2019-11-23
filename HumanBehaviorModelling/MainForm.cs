using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4j.Driver.V1;
using System.Windows.Forms.DataVisualization.Charting;

namespace HumanBehaviorModelling
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        private int countOfSteps = 0;
        public MainForm()
        {
            InitializeComponent();
            chartWorkObject = new ChartWork();
            agentInstances = new List<string>();

        }
        ChartWork chartWorkObject;
        NeoDataLoader neoDataLoader;
        List<String> agentInstances;

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text);
                this.label_connectionState.Text = "Успешно подключено.";
            }

            catch (Exception ex)
            {
                this.label_connectionState.Text = "Не удалось подключиться.\nПроверьте введённые данные\nи подключение к интернету.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output();
        }

        private void listBox_Agents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listBox_Agents.SelectedItem.ToString().Split(' ')[2];
            FillDataGridView(id);
        }

        private void Output()
        {
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                textBox4.Text = neoDataLoader.GetNumberOfAgents();
                agentInstances = new List<string>();
                agentInstances = neoDataLoader.GetAllAgentsInstancesId();
                this.listBox_Agents.Items.Clear();
                foreach (String str in agentInstances)
                    this.listBox_Agents.Items.Add("Человек. ID: " + str);
                this.dataGridView_agentParameters.DataSource = new object();
            }
        }

        private void FillDataGridView(string agentID)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                string stateID = neoDataLoader.GetParameterValue(agentID, "Состояние");
                parameters.Add("Состояние №", stateID + " ("
                                + neoDataLoader.GetParameterValue(stateID, "name") + ")");
                parameters.Add("Сытость: ", neoDataLoader.GetParameterValue(agentID, "Сытость"));
                parameters.Add("X ", neoDataLoader.GetParameterValue(agentID, "X"));
                parameters.Add("Y ", neoDataLoader.GetParameterValue(agentID, "Y"));
                //List<String> ownedItemsId = neoDataLoader.GetRelatedNodesIdList("Принадлежит", agentID);
                //foreach (string item in ownedItemsId)
                //{
                //    parameters.Add("Владеет предметом " + "Пища"/*neoDataLoader.GetNodeLabels(item).First()*/, 
                //                    neoDataLoader.GetParameterValue(item, "Количество"));
                //}
                parameters.Add("Владеет предметом Пища: ", neoDataLoader.GetParameterValue(agentID, "Пища"));
                parameters.Add("Формула на текущем состоянии:", neoDataLoader.GetParameterValue(stateID, "comment"));
                List<String> relatedStatesId = neoDataLoader.GetStatesInWhichNodeGoes(stateID);
                foreach (string state in relatedStatesId)
                    parameters.Add("Переход в состояние " + neoDataLoader.GetParameterValue(state, "name"), neoDataLoader.GetRelationshipBetweenStatementsParameterValue(stateID, state, "comment"));
            }
            //dataGridView1.Rows.Add(parameters)
            foreach (DataGridViewColumn c in dataGridView_agentParameters.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 18F, GraphicsUnit.Pixel);
            }
            dataGridView_agentParameters.DataSource = parameters.ToArray();
            dataGridView_agentParameters.Refresh();
        }

        public void Algorithm()
        {
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                agentInstances = neoDataLoader.GetAllAgentsInstancesId();
            }

            foreach (string agentID in agentInstances)
            {
                // Получаем формулу на текущем состоянии
                string currentStateID;
                string currentStateFormula;
                using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
                {
                    currentStateID = neoDataLoader.GetParameterValue(agentID, "Состояние");
                    currentStateFormula = neoDataLoader.GetParameterValue(currentStateID, "comment");
                }
                // Парсим формулу и применяем её (надо сделать проверку может ли она быть применена)
                
                FormulaParser(currentStateFormula, agentID);
                try
                {
                    if (currentStateID.Equals("1"))
                    { //1 = Перемещение (Это костыль) 
                        neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text);
                        moving(System.Convert.ToInt32(neoDataLoader.GetParameterValue(agentID, "X")), System.Convert.ToInt32(neoDataLoader.GetParameterValue(agentID, "Y")), agentID);
                    }
                }
                catch (FormatException)
                {
                    // the FormatException is thrown when the string text does 
                    // not represent a valid integer.
                }
                catch (OverflowException)
                {
                    // the OverflowException is thrown when the string is a valid integer, 
                    // but is too large for a 32 bit integer.  Use Convert.ToInt64 in
                    // this case.
                }
                //Здесь делаем проверку перехода в другое состояние и, если можем перейти, переходим
                TransitionParser(); ////// Заглушка
            }
        }

        //Разбираем формулу на состоянии
        private void FormulaParser(string formula, string id)
        {
            string[] expressions = formula.Split(new char[] { '(', ')' });
            foreach (string s in expressions)
            {
                if ((s != "") && (s != " ")) // Отсекаем лишшнее
                {
                    string[] exprComponents = s.Split(new char[] { ' ' }); // Массив по идее состоит из трёх элементов, и имеет вид "Атрибут" "Оператор(+= = -=)" "Значение"
                    FormulaApply(exprComponents, id);
                }
            }
        }

        private void FormulaApply(string[] mas, string id)
        {
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                if (mas.Length != 3)
                {
                    textBox4.Text = "Формула неверная";
                    return;
                }

                string paramValue = neoDataLoader.GetParameterValue(id, mas[0]);
                switch (mas[1])
                {
                    case "-=":
                        int result1 = Convert.ToInt32(paramValue) - Convert.ToInt32(mas[2]);
                        neoDataLoader.SetNodeParameter(id, mas[0], result1.ToString());
                        break;
                    case "=":
                        neoDataLoader.SetNodeParameter(id, mas[0], mas[2]);
                        break;
                    case "+=":
                        int result2 = Convert.ToInt32(paramValue) + Convert.ToInt32(mas[2]);
                        neoDataLoader.SetNodeParameter(id, mas[0], result2.ToString());
                        break;
                }
            }
        }

        public void moving(int X, int Y, string agentId) {
            neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text);
            neoDataLoader.SetNodeParameter(agentId, "X", (X += rnd.Next(2)).ToString());
            neoDataLoader.SetNodeParameter(agentId, "Y", (Y += rnd.Next(2)).ToString());
        }

        public void TransitionParser()
        {
            //List<String> relatedStatesId = neoDataLoader.GetStatesInWhichNodeGoes(stateID);
            //foreach (string state in relatedStatesId)
            //    parameters.Add("Переход в состояние " + neoDataLoader.GetParameterValue(state, "name"), neoDataLoader.GetRelationshipBetweenStatementsParameterValue(stateID, state, "comment"));
        }

        public double CalculateAverageSatiety()
        {
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                List<string> agentsID = neoDataLoader.GetAllAgentsInstancesId();
                double sum = 0;
                foreach (string agent in agentsID)
                    sum += Convert.ToDouble(neoDataLoader.GetParameterValue(agent, "Сытость"));
                sum /= agentsID.Count();
                return sum;
            }
        }

        public double CalculateAverageFood() // Здесь дичайшие костыли
        {
            using (neoDataLoader = new NeoDataLoader("bolt://localhost:" + textBox1.Text, textBox2.Text, textBox3.Text))
            {
                List<string> agentsID = neoDataLoader.GetAllAgentsInstancesId();
                double sum = 0;
                foreach (string agent in agentsID)
                {
                    sum += Convert.ToDouble(
                        neoDataLoader.GetStatementResult(
                            "match(n) where id(n) = " + agent + " return n.Пища"
                            ).Single()[0].As<string>());
                }
                sum /= agentsID.Count();
                return sum;
            }
        }

        private void button_nextStep_Click(object sender, EventArgs e)
        {
            Algorithm();
            Output();
            chartWorkObject.averageSatiety.Add(CalculateAverageSatiety());
            chartWorkObject.averageFood.Add(CalculateAverageFood());
            showAVGFoodDiagram();
            showAVGSateityDiagram();
            countOfSteps++;
            label7.Text = countOfSteps.ToString();
        }


        private void showAVGSateityDiagram() {
            ChartArea chartArea = new ChartArea("MyChart");
            var series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.Font = new Font("Courier New", 40.0f, FontStyle.Italic);
            chart1.Series[0] = series;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Name = "Средний уровень сытости";
                    chart1.Series[0].Points.Clear();
                    for (int i = 0; i < chartWorkObject.averageSatiety.Count; i++)
                        chart1.Series[0].Points.AddXY(i, chartWorkObject.averageSatiety[i]);
        }
        private void showAVGFoodDiagram() {
            var series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.Font = new Font("Courier New", 40.0f, FontStyle.Italic);
            chart2.Series[0] = series;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].Name = "Среднее количество пищи у агента";
                    chart2.Series[0].Points.Clear();
                    for (int i = 0; i < chartWorkObject.averageFood.Count; i++)
                        chart2.Series[0].Points.AddXY(i, chartWorkObject.averageFood[i]);
        }
    }
}
