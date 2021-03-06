﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using Excel = Microsoft.Office.Interop.Excel;

namespace CourseTable
{
    /// <summary>
    /// controller the interface and entity classes
    /// </summary>
    class TableController
    {
        private TableInterface _theInterface;
        private Course _theCourse;
        private Member _theMember;
        private BindingList<CourseTime> _controlList;
        private StreamReader sr;
        private List<Member> _memberList;
        private List<Course> _courseList;
        private List<Course> _distinctCourseList;
        private List<Course> _courseTimeList;

        /// <summary>
        /// Init and call methods to load data from txt documents
        /// </summary>
        /// <param name="newInterface"></param>
        public TableController(TableInterface newInterface)
        {
            _theInterface = newInterface;
            selectMemberID();
            selectCourse();
        }

        /// <summary>
        /// Parse string into array of fields.
        /// </summary>
        /// <param name="newRecord"></param>
        /// <returns></returns>
        public string[] getFields(string newRecord)
        {
            char separator = ',';
            string[] temp = newRecord.Split(separator);
            return temp;
        }

        /// <summary>
        /// Load Member records from txt and parse into MemberID and MemberName
        /// </summary>
        public void selectMemberID()
        {
            sr = new StreamReader("C:\\Temp\\CourseTable\\MemberList.txt");
            _memberList = new List<Member>();

            _theMember = new Member();
            _theMember.MemberName = "";
            _memberList.Add(_theMember);

            try
            {
                string listRecord;
                while ((listRecord = sr.ReadLine()) != null)
                {
                    _theMember = new Member();
                    string[] temp = getFields(listRecord);
                    _theMember.MemberID = temp[0];
                    _theMember.MemberName = temp[1];
                    _memberList.Add(_theMember);
                }
            }
            catch (IOException)
            {
                Write("Exception caught while reading the MemberList file.");
            }
        }

        /// <summary>
        /// Show Member Name by selected MemberID 
        /// </summary>
        /// <param name="cboMemberID"></param>
        /// <returns></returns>
        public string showMemberName(ComboBox cboMemberID)
        {
            for (int i = 0; i < _memberList.Count; i++)
            {
                if (cboMemberID.SelectedValue != null && cboMemberID.SelectedValue.Equals(_memberList[i].MemberID))
                {
                    return _memberList[i].MemberName;
                }
            }

            return "";
        }

        /// <summary>
        /// Load Course records from txt and parse into fields
        /// </summary>
        public void selectCourse()
        {
            sr = new StreamReader("C:\\Temp\\CourseTable\\CourseList.txt");


            _theCourse = new Course();
            _theCourse.Name = "";
            _courseList = new List<Course>();
            _distinctCourseList = new List<Course>();
            _distinctCourseList.Add(_theCourse);

            try
            {
                string listRecord;
                while ((listRecord = sr.ReadLine()) != null)
                {
                    _theCourse = new Course();
                    bool flag = false;
                    string[] temp = getFields(listRecord);
                    _theCourse.CourseID = temp[0];
                    _theCourse.Name = temp[1];
                    _theCourse.CourseDay = temp[2];
                    _theCourse.StartTime = temp[3];
                    _courseList.Add(_theCourse);

                    foreach (Course tmp in _distinctCourseList)
                    {
                        if (tmp.Name.Equals(_theCourse.Name))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag != true)
                    {
                        _distinctCourseList.Add(_theCourse);
                    }
                }
            }
            catch (IOException)
            {
                Write("Exception caught while reading the MemberList file.");
            }
        }

        /// <summary>
        /// Provide optional course time by selected course name
        /// </summary>
        /// <param name="cboCourse"></param>
        /// <param name="cboStartTime"></param>
        public void showStartTime(ComboBox cboCourse, ComboBox cboStartTime)
        {
            _courseTimeList = new List<Course>();
            _courseTimeList = _courseList.FindAll((Course c) => c.CourseID.Equals(cboCourse.SelectedValue));
            cboStartTime.DataSource = _courseTimeList;
            cboStartTime.ValueMember = "DisplayTime";
            cboStartTime.DisplayMember = "DisplayTime";

        }

        /// <summary>
        /// Binding datasourse to widgets(cboMemberID/cboCourse/dgvTimeTable)
        /// </summary>
        /// <param name="cboMemberID"></param>
        /// <param name="cboCourse"></param>
        /// <param name="dgvTimeTable"></param>
        public void BindControls(ComboBox cboMemberID, ComboBox cboCourse, DataGridView dgvTimeTable)
        {
            cboMemberID.DataSource = _memberList;
            cboMemberID.ValueMember = "MemberID";
            cboMemberID.DisplayMember = "MemberID";

            cboCourse.DataSource = _distinctCourseList;
            cboCourse.ValueMember = "CourseID";
            cboCourse.DisplayMember = "Name";

            _controlList = new BindingList<CourseTime>();
            CourseTime couseTimeEntity;
            for (int i = 0; i < 15; i++)
            {
                couseTimeEntity = new CourseTime();
                _controlList.Add(couseTimeEntity);
            }

            dgvTimeTable.DataSource = _controlList;
        }

        /// <summary>
        /// Add specified course to relevant table cell
        /// </summary>
        /// <param name="cboCourse"></param>
        /// <param name="cboStartTime"></param>
        /// <param name="dgvTimeTable"></param>
        public void confirm(ComboBox cboCourse, ComboBox cboStartTime, DataGridView dgvTimeTable)
        {
            if (!string.IsNullOrEmpty(cboCourse.Text) && !string.IsNullOrEmpty(cboStartTime.Text))
            {
                string courseName = cboCourse.Text; ;
                string displayTime = cboStartTime.SelectedValue.ToString();
                char separator = ' ';
                string[] temp = displayTime.Split(separator);
                string courseDay = temp[1];
                string sTime = temp[0].Substring(0, 2);
                int intTime = int.Parse(sTime);


                if (courseDay == "Monday")
                {
                    if (_controlList[intTime - 6].Mon == null)
                    {
                        _controlList[intTime - 6].Mon = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Tuesday")
                {
                    if (_controlList[intTime - 6].Tue == null)
                    {
                        _controlList[intTime - 6].Tue = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Wednesday")
                {
                    if (_controlList[intTime - 6].Wed == null)
                    {
                        _controlList[intTime - 6].Wed = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Thursday")
                {
                    if (_controlList[intTime - 6].Thu == null)
                    {
                        _controlList[intTime - 6].Thu = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Friday")
                {
                    if (_controlList[intTime - 6].Fri == null)
                    {
                        _controlList[intTime - 6].Fri = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Saturday")
                {
                    if (_controlList[intTime - 6].Sat == null)
                    {
                        _controlList[intTime - 6].Sat = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else if (courseDay == "Sunday")
                {
                    if (_controlList[intTime - 6].Sun == null)
                    {
                        _controlList[intTime - 6].Sun = courseName;
                    }
                    else
                    {
                        MessageBox.Show("You have a course at this time already!", "Warning!");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose the Course Time!", "Warning!");
                }
            }
            else
            {
                MessageBox.Show("Please select the Course and StartTime!", "Warning!");
            }
            dgvTimeTable.Refresh();
        }

        /// <summary>
        /// Reset time table
        /// </summary>
        /// <param name="dgvTimeTable"></param>
        public void reset(DataGridView dgvTimeTable)
        {
            foreach (CourseTime c in _controlList)
            {
                c.Mon = null;
                c.Tue = null;
                c.Wed = null;
                c.Thu = null;
                c.Fri = null;
                c.Sat = null;
                c.Sun = null;
                dgvTimeTable.Refresh();
            }
        }

        /// <summary>
        /// Export to Excel
        /// </summary>
        /// <param name="dgvTimeTable"></param>
        public void exportToExcel(DataGridView dgvTimeTable)
        {
            int colCount = 0;
            try
            {
                if (dgvTimeTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data!", "Warning!", MessageBoxButtons.OK);
                    return;
                }
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                excel.Workbooks.Add(true);

                for (int i = 0; i < dgvTimeTable.Columns.Count; i++)
                {
                    if (dgvTimeTable.Columns[i].Visible)
                    {
                        colCount = colCount + 1;
                    }
                }

                string[] colName = new string[colCount];
                int index = 0;
                for (int i = 0; i < dgvTimeTable.Columns.Count; i++)
                {
                    if (dgvTimeTable.Columns[i].Visible)
                    {
                        colName[index] = dgvTimeTable.Columns[i].HeaderText;
                        index = index + 1;
                    }
                }
                for (int i = 0; i < 15; i++)
                {
                    excel.Cells[i + 2, 1] = (i + 6).ToString().PadLeft(2, '0') + ":00";
                }

                for (int i = 0; i < colCount; i++)
                {
                    excel.Cells[1, i + 2] = colName[i];
                    if (dgvTimeTable.Columns[i].ValueType == typeof(DateTime))
                    {
                        Excel.Range headRange = excel.Cells[1, i - 1] as Excel.Range;
                        headRange.ColumnWidth = 22;
                    }
                }

                for (int i = 0; i < dgvTimeTable.Rows.Count; i++)
                {
                    int columnIndex = 0;
                    for (int j = 0; j < dgvTimeTable.Columns.Count; j++)
                    {
                        if (dgvTimeTable.Columns[j].Visible)
                        {
                            columnIndex = columnIndex + 1;
                            if (dgvTimeTable[j, i].ValueType == typeof(string))
                            {
                                if (dgvTimeTable[j, i].Value == null)
                                {
                                    excel.Cells[i + 2, columnIndex + 1] = "";
                                }
                                else
                                {
                                    excel.Cells[i + 2, columnIndex + 1] = dgvTimeTable[j, i].Value.ToString();
                                }
                            }
                            else
                            {
                                if (dgvTimeTable[j, i].Value == null)
                                {
                                    excel.Cells[i + 2, columnIndex + 1] = "";
                                }
                                else
                                {
                                    excel.Cells[i + 2, columnIndex + 1] = dgvTimeTable[j, i].Value.ToString();
                                }
                            }
                        }
                    }
                }
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = true;
                excel = null;
                MessageBox.Show("Export successfully！", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
