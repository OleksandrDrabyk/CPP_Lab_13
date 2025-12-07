using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private TSklad MySklad;
		public static string GlStringParameter;

		private void Form1_Load(object sender, EventArgs e)
		{
			MySklad = new TSklad(); // створюємо екземпляр класу TSklad
									// Прив'яжемо DataGridView, що на формі Form1 до SkladView, який поставлено на таблицю TabSklad:
			DGSklad.DataSource = MySklad.TabSklad;

			MySklad.CreateDovGrupa(); // Створимо довідник груп
									  // Створимо для групи товару стовпчик типу DataGridViewComboBoxColumn
			MySklad.AddComboGrupa(DGSklad);

			// Створимо список елементів комбобоксу із рядків таблиця довідника груп 
			foreach (DataRow r in MySklad.DovGrupa.Rows) // Для кожного рядка rr із таблиці DovGrupa
			{
				string s = (string)r["Група"];
				CBGrupa.Items.Add(r["Група"]); // Додаємо у "випадайку" контрола ComboBox елементи із довідника
			}



			MySklad.CreateDovProvider(); // Створимо довідник груп
										 // Створимо для групи товару стовпчик типу DataGridViewComboBoxColumn
			MySklad.AddComboProvider(DGSklad);
			foreach (DataRow r in MySklad.DovProvider.Rows) // Для кожного рядка rr із таблиці DovGrupa
			{
				string s = (string)r["Постачальник"];
				CBPostachalnik.Items.Add(r["Постачальник"]); // Додаємо у "випадайку" контрола ComboBox елементи із довідника
			}

			MySklad.CreateDovMeasure(); // Створимо довідник груп
										 // Створимо для групи товару стовпчик типу DataGridViewComboBoxColumn
			MySklad.AddComboMeasure(DGSklad);

			foreach (DataRow r in MySklad.DovMeasure.Rows) // Для кожного рядка rr із таблиці DovGrupa
			{
				string s = (string)r["Од.виміру"];
				CBOdVymiry.Items.Add(r["Од.виміру"]); // Додаємо у "випадайку" контрола ComboBox елементи із довідника
			}

		}

		private void BAddRowToTable_Click(object sender, EventArgs e)
		{
			// Значення ціни і кількості слід перетворити із текстового формату у формат Decimal та int32
			// Оскільки користувач може ввести невідповідну інформацію, то слід використати механізм try catch
			Decimal pPcina = 0;
			Int32 pKilkist = 0;
			try
			{
				if (TBCina.Text != "")
					pPcina = Convert.ToDecimal(TBCina.Text);
			}
			catch
			{
				MessageBox.Show("Введіть у поле ціни числове значення");
				return;
			}
			try
			{
				if (TBKilkist.Text != "")
					pKilkist = Convert.ToInt32(TBKilkist.Text);
			}
			catch
			{
				MessageBox.Show("Введіть у поле кількості числове значення");
				return;
			}
			MySklad.TSkladAddRow(CBGrupa.Text, TBNazva.Text, TBVyrobnyk.Text, CBPostachalnik.Text, CBOdVymiry.Text, pKilkist, pPcina, DateTime.Now.ToShortTimeString() + "  " + DateTime.Now.ToShortDateString());

			MySklad.SetSumy(DGSkladSum);        // Оновити підсумки
		}
		
		private void записатиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MySklad.ZapTabFile();
			MessageBox.Show("Таблиця записана");
		}

		private void зчитатиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MySklad.ReadTabFile(DGSkladSum);
		}

		private void DGSklad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			int i, j; decimal vart, kilk, cin;
			i = e.RowIndex; // Індекс рядка
			j = e.ColumnIndex; // Індекс стовпця
			if (i < 0) return; // Якщо i < 0 або j < 0, то це – заголовок стовпця або рядка
			if (j < 0) return;
			if ((DGSklad.Columns[j].Name == "Кількість") ^ (DGSklad.Columns[j].Name == "Ціна"))
			// Якщо змінювалась ціна або кількість
			{
				try // Спробуємо, бо, можливо, введено не числа у поле ціни або кількості
				{
					cin = (decimal)DGSklad.Rows[i].Cells["Ціна"].Value;
					kilk = Convert.ToDecimal((Int32)DGSklad.Rows[i].Cells["Кількість"].Value);
					vart = kilk * cin; // Вартість
					DGSklad.Rows[i].Cells["Вартість"].Value = vart; // Записуємо вартість у комірку гріда
				}
				catch { }
			}
			MySklad.SetSumy(DGSkladSum); // Оновимо підсумки
		}

		private void встановитиФільтрToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form FiltrDialog = new FServ(); // Створюємо екземпляр форми FServ і назвемо його FiltrDialog
											// Встановимо текст заголовку форми FServ
			FiltrDialog.Text = "Введіть критерій фільтруванна - наприклад: Група = 'Книги' & Ціна < 70";
			GlStringParameter = MySklad.FiltrCriteria;
			/* Відкриємо форму у режимі діалогу. Це означає, що наступний оператор, що слідує за оператором FiltrDialog.ShowDialog(); буде 
			виконуватись лише після того, як буде закрито форму, яку викликали */
			FiltrDialog.ShowDialog();
			MySklad.TSkladValFiltr(GlStringParameter, DGSklad); // Виклик методу встановлення фільтру
		}

		private void знятиФільтрToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GlStringParameter = ""; // Відмінити фільтрування таблиці
			MySklad.TSkladValFiltr(GlStringParameter, DGSklad);
		}

		private void встановитиКритерійСортуванняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form SortDialog = new FServ(); // Створюємо екземпляр форми FServ і називаємо його SortDialog
										   // Встановимо текст заголовку форми FServ
			SortDialog.Text = "Введіть критерій сортування - наприклад: Виробник, Ціна Desc";
			GlStringParameter = MySklad.SortCriteria;
			/* Відкриємо форму у режимі діалогу. Це означає, що оператор, який слідує за оператором FiltrDialog.ShowDialog(); буде 
			виконуватись лише після того, як буде закрито форму, яку було викликано (тут – SortDialog) */
			SortDialog.ShowDialog();
			MySklad.TSkladValSort(GlStringParameter, DGSklad, DGSkladSum);
		}

		private void сортуватиПоГрупіToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GlStringParameter = "Група, Назва";
			MySklad.TSkladValSort(GlStringParameter, DGSklad, DGSkladSum);
		}

        private void пошукПоНазвіToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string sNazva; // Встановимо текст заголовку форми FServ
			Form SeekDialog = new FServ(); // Створюємо екземпляр форми FServ і називаємо його SeekDialog
			SeekDialog.Text = "Введіть назву:";
			/* Відкриваємо форму у режимі діалогу. Це означає, що що оператор, який слідує за оператором SeekDialog.ShowDialog(); буде 
			виконуватись лише після того, коли буде закрито форму, яку було викликано (тут SeekDialog) */
			SeekDialog.ShowDialog();
			MySklad.SeekNazva(GlStringParameter, DGSklad);
		}

		private void DGSklad_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			/* Тут е – екземпляр класу DataGridViewCellValidatingEventArgs, аргумент, який передає значення індексів комірки, у яку вводили
			дані. e.rowindex – індекс рядка; e.columnindex – індекс стовпця; e.FormattedValue – значення введених у комірку даних */
			{
				decimal cin; Int32 kilk;
				if (DGSklad.Columns[e.ColumnIndex].Name == "Ціна") // Якщо змінювалась ціна 
				{
					if (DGSklad.Rows[e.RowIndex].IsNewRow)
					{
						return;
					} // Не можна перевіряти дані у новому рядку
					  // Перевіряємо, чи введені дані можна трактувати як десяткове число
					if (!decimal.TryParse(e.FormattedValue.ToString(), out cin))
					// Метод TryParse поверне значення true, якщо можна і false, якщо ні. e.FormattedValue – введене значення
					{
						MessageBox.Show("Введіть, будь ласка, числове значення у поле ціни .");
						// e.Cancel = true; - Відмінити введення не правильного значення
					}
				}
				if (DGSklad.Columns[e.ColumnIndex].Name == "Кількість") // Якщо змінювалась кількість
				{
					if (DGSklad.Rows[e.RowIndex].IsNewRow)
					{ return; } // Не можна перевіряти дані у новому рядку
								// Перевіряємо, чи введені дані можна трактувати як ціле число
								// Метод TryParse поверне значення true, якщо можна і false, якщо ні. e.FormattedValue – введене значення
					if (!Int32.TryParse(e.FormattedValue.ToString(), out kilk))
					{
						MessageBox.Show("Введіть,будь ласка, ціле числове значення у поле кількості.");
						e.Cancel = true; // Відмінити введення не правильного значення
					}
				}
			}
		}
    }
}
