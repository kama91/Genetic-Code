using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneticCode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowToGridView(IReadOnlyList<GeneticCode.GeneticStruct> geneticStructs)
        {
            if (geneticStructs == null) return;
            
            _gridView.RowCount = geneticStructs.Count;
            
            for (var i = 0; i < _gridView.RowCount; i++)
            {
                for (var j = 0; j < _gridView.ColumnCount; j++)
                {
                    _gridView.Rows[i].Cells[0].Value = i + 1;
                    switch (j)
                    {
                        case 1:
                            _gridView.Rows[i].Cells[j].Value = $"{geneticStructs[i].A}";
                            break;
                        case 2:
                            _gridView.Rows[i].Cells[j].Value = $"{geneticStructs[i].B}";
                            break;
                        case 3:
                            _gridView.Rows[i].Cells[j].Value = $"{geneticStructs[i].C}";
                            break;
                    }
                }
            }
        }

        private void _btnGenerate_Click_1(object sender, EventArgs e)
        {
            var xValues = new[] { 0.0, 0.2, 0.4, 0.6, 0.8, 1.0, 1.2, 1.4, 1.6, 1.8, 2.0 };
            var yValues = new[]  { 0.57, 0.70, 0.89, 1.10, 1.32, 1.50, 1.58, 1.40, 1.32, 1.10, 0.90 };

            var genCode = new GeneticCode
            {
                XValues = xValues,
                YValues = yValues
            };

            var primaryParents = genCode.GenerateParentPersons();
            var remainingParents =
                genCode.RemoveBestTenParents(primaryParents, genCode.FindIndexTenBestParents(primaryParents));
            ShowToGridView(genCode.GenerateChildren(remainingParents));
        }
    }
}
