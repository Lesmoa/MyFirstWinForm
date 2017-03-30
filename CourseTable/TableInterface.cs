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
    /// <summary>
    /// (partial) Design interface form
    /// </summary>
    public partial class TableInterface: UserControl
    {
        private TableController theController;

        /// <summary>
        /// Init interface form, call Binding method and set widgets usabilities.
        /// </summary>
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

        /// <summary>
        /// Set DataGridView row name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTimeTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 6).ToString().PadLeft(2, '0') + ":00",
                    e.CellStyle.Font,
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Set widgets usabilities and call showMemberName method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = theController.showMemberName(cboMemberID);
            cboCourse.Enabled = true;
            cboStartTime.Enabled = false;
            btnConfirm.Enabled = false;
            btnReset.Enabled = false;
            btnEcport.Enabled = false;
        }

        /// <summary>
        /// call showStartTime method and set widgets usabilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            theController.showStartTime(cboCourse, cboStartTime);
            cboStartTime.Enabled = true;
            btnConfirm.Enabled = true;
        }

        /// <summary>
        /// Call confirm method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            theController.confirm(cboCourse, cboStartTime, dgvTimeTable);
            btnReset.Enabled = true;
            btnEcport.Enabled = true;
        }

        /// <summary>
        /// Call Reset method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            theController.reset(dgvTimeTable);
        }

        /// <summary>
        /// Call Export to Excel method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEcport_Click(object sender, EventArgs e)
        {
            theController.exportToExcel(dgvTimeTable);
        }
    }
}
