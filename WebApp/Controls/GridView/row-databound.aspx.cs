﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls.GridView
{
    public partial class row_databound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gv1.DataSource = Enumerable.Range(0, 10);
            this.gv1.RowDataBound += new GridViewRowEventHandler(gv1_RowDataBound);
            this.gv1.DataBind();
            
        }

        void gv1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal lt = new Literal() { Text = string.Format(" Index {0} ", e.Row.RowIndex.ToString()) };
                PlaceHolder ph1 = (PlaceHolder)e.Row.FindControl("placeHolder1");
                ph1.Controls.Add(lt);
            }
        }
    }
}