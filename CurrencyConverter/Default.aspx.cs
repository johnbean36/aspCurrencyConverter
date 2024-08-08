using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            LblMessage.Text = "";
            if(TxtUSD.Text == "" || DropDownList1.Text == "")
            {
                LblMessage.Text = "Please enter a value to be converted or select a currecy to convert to";
                return;
            }
            double amount = double.Parse(TxtUSD.Text);
            double can = 1.37;
            double yen = 147.20;
            double euro = 0.92;
            double result;
            if(DropDownList1.Text == "1")
            {
                result = amount * euro;
                LblMessage.Text = $"${amount}.00 USD equals ${result.ToString("0.00")} Euro";
            }
            else if(DropDownList1.Text == "2")
            {
                result = amount * can;
                LblMessage.Text = $"${amount}.00 USD equals ${result.ToString("0.00")} Canadian Dollars";
            }
            else if(DropDownList1.Text == "3")
            {
                result = amount * yen;
                LblMessage.Text = $"${amount}.00 USD equals ${result.ToString("0.00")} Japanese Yen";
            }
        }

        protected void BtnGraph_Click(object sender, EventArgs e)
        {
            ImgGraph.ImageUrl = "images/blank.jpg";
            if (TxtUSD.Text == "" || DropDownList1.Text == "")
            {
                LblMessage.Text = "Please enter a value to be converted or select a currecy to convert to";
                return;
            }
            if (DropDownList1.Text == "1")
            {
                ImgGraph.ImageUrl = "images/UStoEuro.png";
            }
            else if (DropDownList1.Text == "2")
            {
                ImgGraph.ImageUrl = "images/UsDtoCan.png";
            }
            else if (DropDownList1.Text == "3")
            {
                ImgGraph.ImageUrl = "images/USDtoYen.png";
            }
        }
    }
}