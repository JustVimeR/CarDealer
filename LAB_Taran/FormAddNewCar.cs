namespace WinFormsApp_Example
{
	public partial class FormAddNewCar : Form
	{
		public Car NewCarings { get; private set; }
		private int _newId;

		public FormAddNewCar(int maxId)
		{
			InitializeComponent();
			_newId = maxId++;
			comboBoxCarType.SelectedIndex = 0;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				var count = Convert.ToDouble(textBoxFuelCons.Text);
				if (comboBoxCarType.SelectedItem.ToString() == "Нема в наявнсті")
				{
					NewCarings = new NotAvaileble(_newId, textBoxBrand.Text, textBoxModel.Text ,count, textBoxCountryOfBilding.Text);
				}
				else
				{
					NewCarings = new InAvaible(_newId, textBoxBrand.Text, textBoxModel.Text, count, textBoxCountryOfBilding.Text);
				}
				DialogResult = DialogResult.OK;
				Close();
			}
			catch
			{
				MessageBox.Show(@"Неуспішна валідація даних!");
			}
		}

	}
}