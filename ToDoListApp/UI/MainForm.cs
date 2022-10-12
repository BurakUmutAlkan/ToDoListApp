using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Data;
using ToDoListApp.Data.Entities;

namespace ToDoListApp
{
    public partial class MainForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public MainForm()
        {
            InitializeComponent();
            GetToDos();
        }

        #region Methods

        private void GetToDos()
        {
            dgvTaskList.DataSource = db.ToDos.Select(toDo => new { toDo.Name, toDo.IsDone }).OrderBy(toDo => toDo.IsDone).ToList();
        }

        private ToDo CreateToDo()
        {
            return new ToDo() { Name = txtTaskName.Text.Trim() };
        }

        private void AddToDo(ToDo toDo)
        {
            db.ToDos.Add(toDo);
            db.SaveChanges();
        }

        private ToDo GetSelectedToDo()
        {
            string taskName = dgvTaskList.SelectedRows[0].Cells[0].Value.ToString();
            return db.ToDos.FirstOrDefault(toDo => toDo.Name == taskName);
            //return dgvTaskList.SelectedCells[0].Tag as ToDo;
        }

        private void UpdateIsDoneStateOfToDo(ToDo toDo)
        {
            if (toDo.IsDone)
                toDo.IsDone = false;
            else
                toDo.IsDone = true;

            db.SaveChanges();
        }

        #endregion

        #region Events

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddToDo(CreateToDo());
            GetToDos();
        }

        private void dgvTaskList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateIsDoneStateOfToDo(GetSelectedToDo());
            GetToDos();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
