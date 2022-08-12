protected void Page_Load(Object Sender, EventArgs e){
  if(!IsPostBack){
  Load_Record();
  }
}

sqlConnection con = new sqlconnection("Data Source= Pratik; Intial Catalog= MyDb; User ID= demo; Password=demo@123");

protected void ButtonClick1(object sender, EventArgs e){
 con.Open();
  sqlCommand comm = new sqlCommand("Insert into MyDb  ('"+int.Parse(TextBox1.Text)+"', '"+TextBox2.Text+"', '"+DropDownList1.SelectedValue+"', '"+TextBox3.Text+"', '"+TextBox4.Text+"')", con);
 comm.ExecuteNonQuery();
 
 con.Close();
 Message.Show("Successfully Inserted");
 Load_Record();
}

void Load_Record(){
    sqlCommand comm = new sqlCommand("Select * from MyDb");
    sqlAdapter d  = new sqlAdapter(comm);
    DataTable dt = new DataTable();
    d.Fill(dt);
    GridView1.DataSource = dt;
    GridView1.DataBind();
}
protected void ButtonClick2(object sender, EventArgs e){
 con.Open();
  sqlCommand comm = new sqlCommand("Upadate MyDb SET Studentid = '"+int.Parse(TextBox1.Text)+"',StudentName = '"+TextBox2.Text+"', City = '"+DropDownList1.SelectedValue+"', College = '"+TextBox3.Text+"', Course =  '"+TextBox4.Text+"')", con);
 comm.ExecuteNonQuery();
 
 con.Close();
 Message.Show("Successfully Updated");
 Load_Record();
}

protected void ButtonClick3(object sender, EventArgs e){
 con.Open();
  sqlCommand comm = new sqlCommand("Delete from MyDb where Studentid = '"+int.Parse(TextBox1.Text)+"'", con);
 comm.ExecuteNonQuery();
 
 con.Close();
 Message.Show("Successfully Deleted");
 Load_Record();
}

protected void ButtonClick4(object sender, EventArgs e){
 
  sqlCommand comm = new sqlCommand("Select * from MyDb where Studentid ='"+int.Parse(TextBox1.Text)+"'", con );
    sqlAdapter d  = new sqlAdapter(comm);
    DataTable dt = new DataTable();
    d.Fill(dt);
    GridView1.DataSource = dt;
    GridView1.DataBind();
    
}

