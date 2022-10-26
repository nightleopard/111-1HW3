using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3{
    public partial class Test : System.Web.UI.Page {
        string[] = s_Vegetable = new string[2] {"蔬菜", "水果"};
        string[,] s_fruit = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e){
        if (!IsPostBack) {
            for (int i_Ct=0; i_Ct< s_Vegetable.Length; i_Ct++)
            {
                ListItem s_V = new ListItem();
                s_V.Text = s_V.Value = s_Vegetable[i_Ct];

                ddl_Category.Items.Add(s_V);
            }
            mt_GenSecondList();
        }
    }

    protected void mt_GenSecondList()
    {
        int i_ind = ddl_Category.SelectedIndex;
        ddl_Food.Items.Clear();
        for (int i_Ct=0; i_Ct< s_fruit.GetLength(1); i_Ct++) {
            ListItem s_V = new ListItem();
            s_V.Text = s_V.Value = s_fruit[i_ind, i_Ct];

            ddl_Category.Items.Add(s_V);
        }
    }
}