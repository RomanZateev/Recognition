﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Recognition
{
    public partial class MainForm : Form
    {
        static public string pathSessions = @"stats/sessions.json";

        //Сгенерированные сессии
        static public List<Session> Sessions = new List<Session>();

        static readonly List<string> Methods = new List<string> { 
            "Ближайшего соседа"
        };

        static readonly List<string> Distance = new List<string> {
            "Евклидово расстояние",
            "Евклидово расстояние + частотность",
            "Манхэттенское расстояние",
            "Манхэттенское расстояние + частотность"
        };

        public MainForm()
        {
            InitializeComponent();

            openFileDialog.Filter = "All files (*.*)|*.*|Text files(*.txt)|*.txt|JSON files(*.json)|*.json";

            foreach (string d in Distance)
                ChooseMethod.Items.Add(d);

            foreach (string m in Methods)
                ChooseMethod.Items.Add(m);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var SelectedSessionIndex = SessionIndex.Text;
            var SelectedMethod = ChooseMethod.SelectedItem;

            if (SelectedSessionIndex == "")
            {
                MessageBox.Show("Выберите номер сессии");
                return;
            }

            if (SelectedMethod == null)
            {
                MessageBox.Show("Выберите метод идентификации");
                return;
            }

            //распознавание
            MetricsCalculation metricsCalculation = new MetricsCalculation(pathSessions);

            metricsCalculation.RecognitionMethodCalculation(SelectedMethod.ToString(), Convert.ToInt32(SelectedSessionIndex.ToString()));
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathSessions = openFileDialog.FileName;
                Sessions = JsonConvert.DeserializeObject<List<Session>>(File.ReadAllText(pathSessions));
                AllSessions.Text = Sessions.Count().ToString();
            }
        }

        private void MethodsAccuracy_Click(object sender, EventArgs e)
        {
            ErrorsCalculation errors = new ErrorsCalculation();

            var data = errors.Calculate();

            errors.ErrorsForm(data);
        }
    }
}
