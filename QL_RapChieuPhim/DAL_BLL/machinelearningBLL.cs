using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord;
using Accord.Math;
using System.Data;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;
using Accord.Math.Optimization.Losses;

namespace DAL_BLL
{
    public class machinelearningBLL
    {
        public machinelearningBLL()
        {

        }

        public bool Lean(string file, List<DataST> dt)
        {
            try
            {
                DataTable data = new DataTable();
                data.Columns.Add("sothich1", "sothich2", "sothich3", "output");
               
                foreach (DataST i in dt)
                {
                    data.Rows.Add(i.sothich1, i.sothich2, i.sothich3, i.output);
                }
                var codebook = new Codification(data);

                DataTable symbols = codebook.Apply(data);
                int[][] inputs = symbols.ToArray<int>("sothich1", "sothich2", "sothich3");
                int[] outputs = symbols.ToArray<int>("output");


                var id3learning = new ID3Learning()
                {
                    new DecisionVariable("sothich1",     9),
                    new DecisionVariable("sothich2", 9),
                    new DecisionVariable("sothich3",    9)
                };

                DecisionTree tree = id3learning.Learn(inputs, outputs);
                tree.Save(file);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
