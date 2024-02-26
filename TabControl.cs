tabControl1.TabPages.Add("Pestanya 1");
tabControl1.TabPages.Add("Pestanya 2");
tabControl1.TabPages.Add("Pestanya 3");

private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
{
  MessageBox.Show("Pestanya seleccionada: " + tabControl1.SelectedIndex.ToString());
}
