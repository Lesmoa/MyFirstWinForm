using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTable
{
    public partial class TableInterface: UserControl
    {
        private TableController theController;
        public TableInterface()
        {
            InitializeComponent();
            theController = new TableController(this);
            theController.BindControls(cboMemberID, cboCourse, dgvTimeTable);
            cboCourse.Enabled = false;
            cboStartTime.Enabled = false;
            btnConfirm.Enabled = false;
            btnReset.Enabled = false;
            btnEcport.Enabled = false;
        }

        private void dgvTimeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void courseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TableInterface_Load(object sender, EventArgs e)
        {

        }


        private void dgvTimeTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // draw time to row header cell
            if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);//location and draw parts.
                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);//move the intent from rectangle
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 6).ToString().PadLeft(2, '0') + ":00",//intent
                    e.CellStyle.Font,//font
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);//measure and render text 
                e.Handled = true;
            }
        }

        private void cboMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = theController.showMemberName(cboMemberID);
            cboCourse.Enabled = true;
            cboStartTime.Enabled = false;
            btnConfirm.Enabled = false;
            btnReset.Enabled = false;
            btnEcport.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableControllerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            theController.showStartTime(cboCourse, cboStartTime);
            cboStartTime.Enabled = true;
            btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            theController.confirm(cboCourse, cboStartTime, dgvTimeTable);
            btnReset.Enabled = true;
            btnEcport.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            theController.reset(dgvTimeTable);
        }

        private void btnEcport_Click(object sender, EventArgs e)
        {
            theController.exportToExcel(dgvTimeTable);
        }
    }
}
