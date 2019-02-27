using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Entities;

namespace akademik_app
{
    public partial class Dossier: ULPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CheckLogin();
            }

        }


        public bool IsEdit()
        {
            bool ok = false;
            User u = GetCurrentUser();
            u.GetPermissions();

            return ok;

        }
        private void CheckLogin()
        {
            if (!IsLogin())
            {
                Response.Redirect("Home.aspx");
            }

        }


        protected void radgrid_ItemDataBound(object sender, GridItemEventArgs e)
        {
            if ((e.Item is GridEditFormItem) && (e.Item.IsInEditMode))
            {
                GridEditFormItem editItem = (GridEditFormItem)e.Item;
                RadComboBox rc = (RadComboBox)editItem["ep"].Controls[0];
                rc.Width = Unit.Pixel(400);
                rc.Filter = RadComboBoxFilter.Contains;
                //EditCommandColumn ecc = (EditCommandColumn) editItem["EditCommandColumn"].Controls[0];
            }
            if (e.Item is GridDataItem)
            {
                GridDataItem item = (GridDataItem)e.Item;
                //TextBox param_data = (TextBox) item["param_data"].Controls[0];
                //if (param_data.Text == "0" || param_data.Text == null)
                //{
                //    TableCell tc = (TableCell) item["param_data"];
                //    tc.BackColor = Color.Red;
                //}
                //GridNumericColumn param_data = (GridNumericColumn) item["param_data"].Controls[0];
                //TextBox param_data = (TextBox) item["param_data"].Controls[0];
                //TextBox ratio = (TextBox) item["ratio"].Controls[0];
                //param_data.Text = Convert.ToDouble(param_data.Text/ratio.Text);
            }
        }

        protected void radgridDevice_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                radgrid.DataSource = (DataView)dsJournal.Select(DataSourceSelectArguments.Empty);
            }
        }
        protected void radgrid_InsertCommand(object sender, GridCommandEventArgs e)
        {
            GridEditFormInsertItem insertedItem = (GridEditFormInsertItem)e.Item;

            if (e.Item.OwnerTableView.Name == "Dossier")
            {
                Entities.User u = GetCurrentUser();

                
                dsJournal.InsertParameters.Add(new Parameter("employee_id", DbType.Int32, (insertedItem["ep"].Controls[0] as RadComboBox).SelectedValue));
                dsJournal.InsertParameters.Add(new Parameter("comment", DbType.String, (insertedItem["comment"].Controls[0] as TextBox).Text));
                dsJournal.InsertParameters.Add(new Parameter("projects", DbType.String, (insertedItem["projects"].Controls[0] as TextBox).Text));


                dsJournal.Insert();
            }
            e.Item.Edit = false;
            e.Canceled = true;
            radgrid.Rebind();
        }

        protected void radgrid_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            if (e.Item.OwnerTableView.Name == "Dossier")
            {
                string s = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString();
                dsJournal.DeleteParameters.Add(new Parameter("ID", DbType.Int32, s));
                dsJournal.Delete();
            }


            e.Canceled = false;
        }


        protected void radgridServices_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            GridEditableItem updatedItem = (GridEditableItem)e.Item;
            if (e.Item.OwnerTableView.Name == "Dossier")
            {
                string s = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString();

                dsJournal.UpdateParameters.Add(new Parameter("ID", DbType.Int32, s));


                dsJournal.UpdateParameters.Add(new Parameter("employee_id", DbType.Int32, (updatedItem["ep"].Controls[0] as RadComboBox).SelectedValue));
                dsJournal.UpdateParameters.Add(new Parameter("comment", DbType.String, (updatedItem["comment"].Controls[0] as TextBox).Text));
                dsJournal.UpdateParameters.Add(new Parameter("projects", DbType.String, (updatedItem["projects"].Controls[0] as TextBox).Text));

                dsJournal.Update();

            }
            e.Item.Edit = false;
            radgrid.Rebind();
        }


        protected void radgrid_itemcommand(object sender, GridCommandEventArgs e)
        {

        }
    }
}
