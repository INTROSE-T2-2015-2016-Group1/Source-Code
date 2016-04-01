using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace introse_project.Libs
{
    class SearchManager
    {
        private static SearchManager theInstance = new SearchManager();

        private SearchManager() { }

        public void searchForm(DataGridView dataGridView, String formType, String input)
        {

        }
    }
}
