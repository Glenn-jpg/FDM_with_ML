// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace FDMML.Model
{
    public class ModelInput
    {
        [ColumnName("xCtrlPt[m]"), LoadColumn(0)]
        public float XCtrlPt_m_ { get; set; }


        [ColumnName("yCtrlPt[m]"), LoadColumn(1)]
        public float YCtrlPt_m_ { get; set; }


        [ColumnName("RightCtrlPt[m]"), LoadColumn(2)]
        public float RightCtrlPt_m_ { get; set; }


        [ColumnName("Displacement[cm]"), LoadColumn(3)]
        public float Displacement_cm_ { get; set; }


    }
}
