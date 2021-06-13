using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        Order Order { get; set; }
        User CurrentUser { get; set; }
        List<Table> Tables { get; set; }

        TableService tableService;
        OrderService orderService;


        public TableOverview()
        {
            InitializeComponent();
            //CurrentUser = user;
            tableService = new TableService();
            orderService = new OrderService();
            //ables = tableService.GetAllTables();
            DisplayTables();
        }

        // This method is for displaying the tables 
        // Inside pnlTables
        private void DisplayTables()
        {
            pnlTables.Controls.Clear();
            Tables = tableService.GetAllTables();
            int column, row = 0 , i = 1;
            foreach(Table table in Tables)
            {
               
                column = i%2 == 0 ? 1 : 0;
                switch (i)
                {
                    case 1:
                        row = 0;
                        break;
                    case 2:
                        row = 0;
                        break;
                    case 3:
                        row = 1;
                        break;
                    case 4:
                        row = 1;
                        break;
                    case 5:
                        row = 2;
                        break;
                    case 6:
                        row = 2;
                        break;
                    case 7:
                        row = 3;
                        break;
                    case 8:
                        row = 3;
                        break;
                    case 9:
                        row = 4;
                        break;
                    case 10:
                        row = 4;
                        break;
                    default:
                        break;
                }
                // Create a button
                Button btnTable = new Button()
                {
                    Text = $"Table {table.Id}",
                    Width = 150,
                    Height = 60,
                    Tag = table
                };

                // Button properties based on table status
                switch (table.Status)
                {
                    case TableStatus.Empty:
                        btnTable.Text += "\n Seat Customer";
                        btnTable.BackColor = Color.Green;
                        btnTable.Click += new EventHandler(this.SeatCustomer);
                        break;
                    case TableStatus.Reserved:
                        btnTable.Text += "\n Create Order";
                        btnTable.BackColor = Color.Yellow;
                        btnTable.Click += new EventHandler(this.CreateOrder);

                        break;
                    case TableStatus.Ordered:
                        btnTable.Text += "\n View Order";
                        btnTable.BackColor = Color.Orange;
                        btnTable.Click += new EventHandler(this.ViewOrder);

                        break;
                    default:
                        break;
                    }

                

                pnlTables.Controls.Add(btnTable, column, row);
                i++;
            }
        }

        private void SeatCustomer(object sender, EventArgs e)
        {
            Table table = (Table)(sender as Button).Tag;
            tableService.SetStatusToReserved(table);
            DisplayTables();
        }
    
        private void CreateOrder(object sender, EventArgs e)
        {
            Table table = (Table)(sender as Button).Tag;
            tableService.SetStatusToOrdered(table);
            //orderService.CreateOrder(CurrentUser, new Bill(), table);
            DisplayTables();
        }
    
        private void ViewOrder(object sender, EventArgs e)
        {
            
        }
    }
}
