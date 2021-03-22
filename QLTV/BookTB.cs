using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class BookTB : DraggableForm
    {
        SQLManager sQLManager;
        DataGridView TBRef;
        public BookTB(DataGridView bookTB)
        {
            InitializeComponent();
            TBRef = bookTB;
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
                GetBookDataToTB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetBookDataToTB()
        {
            sQLManager.getDataToDataGridView("exec LaySach", bookToAddTB);
            bookToAddTB.Columns[0].HeaderText = "Mã sách";
            bookToAddTB.Columns[1].HeaderText = "Tên sách";
            bookToAddTB.Columns[2].HeaderText = "Thể loại";
            bookToAddTB.Columns[3].HeaderText = "Số lượng tồn";
            mydefine.ResizeDataTB(bookToAddTB);
            bookAddedToRentTB.ColumnCount = 4;
            bookAddedToRentTB.Columns[0].Name = "Mã sách";
            bookAddedToRentTB.Columns[1].Name = "Tên sách";
            bookAddedToRentTB.Columns[2].Name = "Thể loại";
            bookAddedToRentTB.Columns[3].Name = "Số lượng mượn";
        }

        private void addToRentBTN_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in bookToAddTB.Rows)
            {
                if (bookID.Text == row.Cells[0].Value.ToString())
                {
                    if(nOfBooks.Value>0&&nOfBooks.Value<= (int)row.Cells[3].Value)
                    {
                        string[] rowData = new string[] { bookID.Text, row.Cells[1].Value.ToString(),
                                                        row.Cells[2].Value.ToString(), nOfBooks.Value.ToString()};
                        bookAddedToRentTB.Rows.Add(rowData);
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai số lượng cho mượn");
                    }    
                    break;
                }

            }
        }

        private void delFromRentBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bookAddedToRentTB.Rows)
            {
                if (bookID.Text == row.Cells[0].Value.ToString())
                {
                    bookToAddTB.Rows.Remove(row);
                    break;
                }
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            TBRef.Columns.Clear();
            TBRef.Rows.Clear();
            TBRef.Refresh();
            for (int i = 0; i < bookAddedToRentTB.Columns.Count; i++)
            {
                TBRef.Columns.Add(i.ToString(),bookAddedToRentTB.Columns[i].HeaderText);
            }
            for (int j = 0; j < bookAddedToRentTB.Rows.Count-1; j++)
            {
                try
                {
                    int nOfCells = bookAddedToRentTB.Rows[j].Cells.Count;
                    string[] data = new string[nOfCells];
                    for (int k = 0; k < nOfCells; k++)
                    {
                        data[k] = bookAddedToRentTB.Rows[j].Cells[k].Value.ToString();
                    }
                    TBRef.Rows.Add(data);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bookToAddTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookID.Text = bookToAddTB.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
        private void bookAddedToRentTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookID.Text = bookAddedToRentTB.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
