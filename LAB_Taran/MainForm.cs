using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_CarDealer;

namespace WinFormsApp_Example
{
	public partial class MainForm : Form
	{
		public List<Car> Cars { get; set; }
		public class Helper
		{
			public static Stopwatch stopwatch = new Stopwatch();
			public static void StartStopWatch() { stopwatch.Start(); }
			public void SaveTxt(string path, List<Car> cars)
			{
				List<string> carTxt = new List<string>();
				foreach (var car in cars)
				{
					carTxt.Add(car.Id + "|" + car.Brand + "|" + car.Model + "|" + car.CountryOfBilding + "|" + car.Nayavnost + "|" + car.EngineVolume);
				}
				System.IO.File.WriteAllLines(path, carTxt);
			}
			public static List<Car> LoadTxt(string path)
			{
				List<Car> cars = new List<Car>();
				string[] carsTxt = System.IO.File.ReadAllLines(path);
				foreach (var car in carsTxt)
				{
					var oneCar = car.Split('|');
					int id = Convert.ToInt32(oneCar[0]);
					string brand = oneCar[1];
					string model = oneCar[2];
					double engine = Convert.ToDouble(oneCar[3]);
					string country = oneCar[4];			
					cars.Add(new InAvaible(id, brand, model, engine, country));
				}
				return cars;
			}
			public static void SaveJson(string path, List<Car> cars)
			{
				var serializedCars = JsonSerializer.Serialize(cars);
				System.IO.File.WriteAllText(path, serializedCars);
			}
			public static List<Car> LoadJson(string path)
			{
				var deserializedCars = System.IO.File.ReadAllText(path);
				var cars = JsonSerializer.Deserialize<List<Car>>(deserializedCars);
				return cars;
			}
		}
		public MainForm()
		{
			InitializeComponent();
			
			Cars = new List<Car>
			{
				new InAvaible(1, "Volkswagen","Passat B8", 2 ,countryofbuild: "Germany"),
				new InAvaible(2, "Ford", "Fusion", 2,countryofbuild:"America"),
				new InAvaible(3, "Bugatti", "Divo", 5,countryofbuild:"Britan"),
				new InAvaible(4, "McLaren","Senna", 2,countryofbuild : "Italy"),
				new InAvaible(5, "Porche", "Tycan", 3,countryofbuild : "Germany"),
				new InAvaible(6, "McLaren","720S", 6,countryofbuild:"Italy"),
				new InAvaible(7, "Bugatti", "Chiron", 8,countryofbuild : "Britan"),
				new InAvaible(8, "Lamborghini", "Evo", 4,countryofbuild : "Britan"),
				new InAvaible(9, "Lamborghini", "Huracan", 5,countryofbuild:"Britan"),
				new InAvaible(10, "Lamborghini", "Aventador", 6,countryofbuild:"Britan")
			};
			CarBindingSource.DataSource = Cars;

		}
		private void toolStripAdd_Click(object sender, EventArgs e)
		{
			var maxId = Cars.Count == 0 ? 0 : Cars.Max(w => w.Id);
			var newCarForm = new FormAddNewCar(maxId);
			if (newCarForm.ShowDialog() == DialogResult.OK)
			{
				CarBindingSource.Add(newCarForm.NewCarings);
				MessageBox.Show(@"Додано нове авто");
			}
			else
			{
				MessageBox.Show(@"Додавання нового авто скасовано");
			}
			
		}

		private void toolStripRemove_Click(object sender, EventArgs e)   //Search auto by criteria
		{
			try
			{
				if (dataGridView.Rows.Count == 0)
				{
					MessageBox.Show("Нема рядків");
				}
				else
				{
					try
					{
						if (toolStripComboBoxSearch.SelectedItem.ToString() == "Марка")
						{
							var CarListSearch = from carl in Cars
												where carl.Brand == toolStripTextBoxSearch.Text
												select carl;
							CarBindingSource.DataSource = CarListSearch;
						}
						else if (toolStripComboBoxSearch.SelectedItem.ToString() == "Країна виробництва")
						{
							var CarListSearch = from carl in Cars
												where carl.CountryOfBilding == toolStripTextBoxSearch.Text.ToString()
												select carl;
							CarBindingSource.DataSource = CarListSearch;

						}
						else if (toolStripComboBoxSearch.SelectedItem.ToString() == "Об'єм мотора")
						{
							int value1;
							string a = toolStripTextBoxSearch.Text.ToString();
							int.TryParse(string.Join("", a.Where(c => char.IsDigit(c))), out value1);
							var CarListSearch = from carl in Cars
												where carl.EngineVolume == "Обєм мотора: " + value1 + " л."
												select carl;
							CarBindingSource.DataSource = CarListSearch;
						}
                    }
                    catch
                    {
						MessageBox.Show("Помилка!");
                    }
				}
			}
			catch
			{
				MessageBox.Show(@"Неуспішна валідація даних!");
			}
			
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)  //refresh
		{
			CarBindingSource.DataSource = Cars;
			
		}

		private void toolStripButtonSellCar_Click(object sender, EventArgs e)   //Sell Car
		{
			var carSell = dataGridView.CurrentRow.Cells[3].Value.ToString();
			if(carSell == "В наявності")
            {
				MessageBox.Show("Машину продано");
				carSell = "Продано";
				dataGridView.CurrentRow.Cells[3].Value = carSell;
			}
			else if(carSell == "Продано")
            {
				MessageBox.Show("Машину повернули");
				carSell = "В наявності";
				dataGridView.CurrentRow.Cells[3].Value = carSell;
            }
			else if (carSell == "Нема в наявності")
			{
				MessageBox.Show("Замінено на протилежний статус");
				carSell = "В наявності";
				dataGridView.CurrentRow.Cells[3].Value = carSell;
			}
			else
            {
				MessageBox.Show("замінено на статус: Нема в наявності");
				carSell = "Нема в наявності";
				dataGridView.CurrentRow.Cells[3].Value = carSell;
			}
		}

		private void toolStripLabel1_Click(object sender, EventArgs e) //удаление
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				CarBindingSource.RemoveCurrent();
			}
			
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Helper.StartStopWatch();
			
		}

        private void toolStripButtonSaveToFile_Click(object sender, EventArgs e) //Save to .txt
        {

            FileStream fs = new FileStream("input.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
			int value;
			for (int i = 0; i < Cars.Count; i++)
            {
				string a = Cars[i].EngineVolume.ToString();
				int.TryParse(string.Join("", a.Where(c => char.IsDigit(c))), out value);
				sw.WriteLine(Cars[i].Id + "|" + Cars[i].Brand + "|" + Cars[i].Model + "|" + value + "|" + Cars[i].CountryOfBilding);
            }
            sw.Close();
        }

        private void toolStripSaveJson_Click(object sender, EventArgs e) //Save to .json
        {
			Helper.SaveJson("input.json", Cars);
		}
       
        private void toolStripDownloadJson_Click(object sender, EventArgs e) //Download .json
        {
			Cars = Helper.LoadJson("input.json");
			CarBindingSource.DataSource = Cars;
		}
		
		private void toolStripButtonDownloadTxt_Click(object sender, EventArgs e) //Download .txt
		{
			Cars = Helper.LoadTxt("input.txt");
			CarBindingSource.DataSource = Cars;
		}

        private void toolStripButtonAbout_Click(object sender, EventArgs e) //about
        {
            var newAbout = new WinFormsApp_CarDealer.AboutLab();
			newAbout.ShowDialog();
			
		}

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			RedactForm redactForm = new RedactForm(this);
			redactForm.textBoxFBrand.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
			redactForm.textBoxFModel.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
			redactForm.textBoxFCountry.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
			redactForm.textBoxFNayavnost.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
			redactForm.textBoxFMotor.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
			
			redactForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			labelTimer.Text = ((int)Helper.stopwatch.Elapsed.TotalSeconds).ToString();
		}
    }
}