using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexBotonePrj
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //call the linq 
        DataClasses1DataContext db = new DataClasses1DataContext();
 

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            var st = new Jucator
            {
                JucatorId = int.Parse(TextBox1.Text),
                Nume = TextBox2.Text,
                Prenume = TextBox3.Text,
                Varsta = int.Parse(TextBox4.Text),
                EchipaID = int.Parse(TextBox5.Text),
            };
            db.Jucators.InsertOnSubmit(st);
            db.SubmitChanges();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succes la inserare!');", true);
            LoadData();
        }
        void LoadData()
        {
            var st = from s in db.Jucators select s;
            GridView1.DataSource = st;
            GridView1.DataBind();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Jucators where s.JucatorId == int.Parse(TextBox1.Text) select s).First();
            
            st.Nume = TextBox2.Text;
            st.Prenume = TextBox3.Text;
            st.Varsta = int.Parse(TextBox4.Text);
            st.EchipaID = int.Parse(TextBox5.Text);
            db.SubmitChanges();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datele au fost schimbate cu succes');", true);
            LoadData();
        }


        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Jucators where s.JucatorId == int.Parse(TextBox1.Text) select s).First();
            TextBox2.Text = st.Nume;
            TextBox3.Text = st.Prenume;
            TextBox4.Text = st.Varsta.ToString();
            TextBox5.Text = st.EchipaID.ToString();
            LoadData();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Jucators where s.JucatorId == int.Parse(TextBox1.Text) select s).First();
            db.Jucators.DeleteOnSubmit(st);
            db.SubmitChanges();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datele au fost sterse');", true);
            LoadData();
        }

        protected void BtnInsertl_Click(object sender, EventArgs e)
        {
            var st1 = new Liga
            {
                LigaId = int.Parse(TextBox6.Text),
                NumeLiga = TextBox7.Text,

            };
            db.Ligas.InsertOnSubmit(st1);
            db.SubmitChanges();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succes la inserare!');", true);
            LoadData2();
        }
        void LoadData2()
        {
            var st2 = from s in db.Ligas select s;
            GridView3.DataSource = st2;
            GridView3.DataBind();
        }
        protected void BtnInseraree_Click(object sender, EventArgs e)
        {
            var st2 = new Echipa
            {
                EchipaId = int.Parse(TextBox8.Text),
                Denumire = TextBox9.Text,
                Liga = int.Parse(TextBox10.Text)

            };
            db.Echipas.InsertOnSubmit(st2);
            db.SubmitChanges();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succes la inserare!');", true);
            LoadData3();
        }
        void LoadData3()
        {
            var st2 = from s in db.Echipas select s;
            GridView2.DataSource = st2;
            GridView2.DataBind();
        }

       
    }
}