using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace lab_12
{
	class TSklad
	{
		public DataTable TabSklad = new DataTable();
		public DataView SkladView;
		public string FiltrCriteria; // Поле для зберігання критерію фільтрування
		public string SortCriteria; // Поле для зберігання критерію сортування

		public DataGridViewComboBoxColumn cGrupaCB;
		public DataTable DovGrupa = new DataTable();

		public TSklad()
		{
			/* Створюємо стовпці таблиці. Тут cNpp, cNameGroup, cNameProduct, cProduser, cCount, cPrise, cVartist - назви 
			об'єктів типу DataColumn, а кириличні слова у лапках - значення їхніх властивості ColumName. Назва стовпця ColumName може бути і 
			кириличною */
			DataColumn cNpp = new DataColumn("N_пп");
			DataColumn cNameGroup = new DataColumn("Група");
			DataColumn cNameProduct = new DataColumn("Назва");
			DataColumn cProduser = new DataColumn("Виробник");
			DataColumn cCount = new DataColumn("Кількість");
			DataColumn cPrise = new DataColumn("Ціна");
			DataColumn cVartist = new DataColumn("Вартість");
			// Оголошуємо типи даних, що будуть зберігатись у стовпцях
			cNpp.DataType = System.Type.GetType("System.Int32");
			cNameGroup.DataType = System.Type.GetType("System.String");
			cProduser.DataType = System.Type.GetType("System.String");
			cCount.DataType = System.Type.GetType("System.Int32");
			cPrise.DataType = System.Type.GetType("System.Decimal");
			cVartist.DataType = System.Type.GetType("System.Decimal");
			// Додаємо стовпці до таблиці
			TabSklad.Columns.Add(cNpp);
			TabSklad.Columns.Add(cNameGroup);
			TabSklad.Columns.Add(cNameProduct);
			TabSklad.Columns.Add(cProduser);
			TabSklad.Columns.Add(cPrise);
			TabSklad.Columns.Add(cCount);
			TabSklad.Columns.Add(cVartist);

			SkladView = new DataView(TabSklad); // Створюємо змінну типу DataView для можливості фільтрування і сортування
		}

		public void TSkladAddRow(string pNameGroup, string pNameProduct, string pProduser, int pCount,
								 decimal pPrise)
		{
			int nn;
			nn = TabSklad.Rows.Count;
			// Оголошуємо змінну rowSklad як рядок таблиці TabSklad
			// Такий рядок буде містити поля з тими ж назвами, що й стовпці таблиці
			DataRow rowSklad = TabSklad.NewRow();
			rowSklad["N_пп"] = nn++; // Присвоюємо полям значення, які отримані через параметри
			rowSklad["Група"] = pNameGroup;
			rowSklad["Назва"] = pNameProduct;
			rowSklad["Виробник"] = pProduser;
			rowSklad["Ціна"] = pPrise;
			rowSklad["Кількість"] = pCount;
			rowSklad["Вартість"] = pCount * pPrise;
			TabSklad.Rows.Add(rowSklad); // Додаємо сформований рядок до таблиці
			/* Ми могли б звертатись до відповідного поля рядка таблиці через його числовий індекс починаючи з 0. Наприклад, рядок rowSklad["N_пп"] = 
			nn++; можна переписати у вигляді rowSklad[0] = nn++;, а рядок rowSklad["Виробник"] = pProduser; – переписати так: rowSklad[3] = pProduser; */
		}

		public void ColumnPropSet(DataGridView DGV)
		{
			/* Цей метод задає деякі властивості стовпцям. Тут встановлено заголовки стовпців, хоча вони і по замовчуванню були б такі, що перейшли б із 
			назв стовпців таблиці */
			DGV.Columns["N_пп"].HeaderText = "№ п/п";
			DGV.Columns["Група"].HeaderText = "Група";
			DGV.Columns["Назва"].HeaderText = "Назва";
			DGV.Columns["Виробник"].HeaderText = "Виробник";
			DGV.Columns["Ціна"].HeaderText = "Ціна";
			DGV.Columns["Кількість"].HeaderText = "Кількість";
			DGV.Columns["Вартість"].HeaderText = "Вартість";
			// Оскільки номер і вартість формуються програмно, то заборонимо користувачу вводити у них дані 
			DGV.Columns["N_пп"].ReadOnly = true;
			DGV.Columns["Вартість"].ReadOnly = true;
			DGV.Columns["N_пп"].Width = 40; // Задаємо ширини стовпців
			DGV.Columns["Група"].Width = 100;
			DGV.Columns["Назва"].Width = 160;
			DGV.Columns["Виробник"].Width = 160;
			DGV.Columns["Ціна"].Width = 70;
			DGV.Columns["Кількість"].Width = 70;
			DGV.Columns["Вартість"].Width = 70;
			// Встановимо колір першого стовпця у зелений
			// Цей оператор теж лише для ілюстрації можливості встановлення кольорів стовпців
			DGV.Columns[0].DefaultCellStyle.BackColor = Color.Green;
		}

		public void ZapTabFile() // ZapTabFile – метод для записування таблиці у текстовий файл із назвою FtabSklad.txt
		{
			string sNameFile, textRow;
			// Визначимо за допомогою методу Directory.GetCurrentDirectory() ім’я каталогу із *.exe-файлом проекту, для
			// наступного записування туди нашої таблиці 
			string sdir = Directory.GetCurrentDirectory();
			sNameFile = sdir + @"\FTabSklad.txt"; // Ім’я файлу з таблицею
			try // Пробуємо виконати
			{
				if (File.Exists(sNameFile)) // Якщо такий файл існує, то знищимо його і створитмо новий
				{
					File.Delete(sNameFile);
				}
				// Створимо екземпляр класу StreamWriter, який записуватиме рядки у текстовий файл 
				using (StreamWriter sw = new StreamWriter(sNameFile))
				{
					foreach (DataRow rr in TabSklad.Rows)
					{
						/* Для кожного рядка rr із таблиці TabSklad побудуємо текстовий образ рядка, об’єднуючи значення полів таблиці у один рядок і 
						розділяючи їх символом “;”*/
						textRow = rr["Група"] + ";" + rr["Назва"] + ";" + rr["Виробник"] + ";" +
						Convert.ToString(rr["Кількість"]) + ";" + Convert.ToString(rr["Ціна"]);
						sw.WriteLine(textRow); // Записуємо рядок у файл
					}
				}
			}
			catch (Exception e) // Якщо не вдалось записати, видаємо повідомлення про помилку
			{
				MessageBox.Show("Таблиця не записана");
			}
		}

		public void ReadTabFile(DataGridView DGS) // Метод для читання рядків з текстового файлу і додавання їх до таблиці
		{										  // Тут DGS – грід для виведення підсумків
			string sNameFile, textRow;
			string pGrupa, pNazva, pVyrobnyk, sKilkist, sCina; int pKilkist; decimal PCina; int i, ip;
			// Визначаємо каталог із файлом , у який нами було записано таблицю
			TabSklad.Rows.Clear(); // Очищаємо усі попередні рядки таблиці, які можливо були туди заведені
			string sdir = Directory.GetCurrentDirectory();
			sNameFile = sdir + @"\FTabSklad.txt"; // Це повне ім’я файлу, який містить таблицю
			using (StreamReader sr = new StreamReader(sNameFile))
			{
				while (sr.Peek() >= 0) // Читаємо рядки доти, доки вони є у файлі, sr - StreamReader
				{
					pGrupa = ""; pNazva = ""; pVyrobnyk = ""; sKilkist = ""; sCina = "";
					textRow = sr.ReadLine();
					/* StreamReader запише у змінну textRow черговий рядок файлу. Оскільки поля, при записуванні у файл, ми розділяли символом ';', то 
					тепер шукаємо його за допомогою методу IndexOf для типу string */
					i = textRow.IndexOf(';') - 1;
					for (int j = 0; j <= i; j++) // Перші символи від 0 до і-1 – це група товару, то
					{
						pGrupa = pGrupa + textRow[j]; // переписуємо їх у змінну pGrupa
					}
					ip = i + 2; // Запам'ятовуємо позицію першого розділювача
					i = textRow.IndexOf(';', ip) - 1; // Знаходимо наступний розділювач
					for (int j = ip; j <= i; j++)
					{
						pNazva = pNazva + textRow[j];
					} // Символи від ip до і-1 – назва товару
					ip = i + 2; // Запам'ятовуємо позицію другого розділювача
					i = textRow.IndexOf(';', ip) - 1; // Знаходимо наступний розділювач
					for (int j = ip; j <= i; j++)
					{
						pVyrobnyk = pVyrobnyk + textRow[j]; // Символи від ip до і-1 – виробник товару
					}
					ip = i + 2; // Запам’ятовуємо позицію третього розділювача
					i = textRow.IndexOf(';', ip) - 1; // Знаходимо наступний розділювач
					for (int j = ip; j <= i; j++)
					{
						sKilkist = sKilkist + textRow[j]; // Символи від ip до і-1 – кількість товару
					}
					ip = i + 2; // Запам'ятовуємо позицію четвертого розділювача
					for (int j = ip; j <= textRow.Length - 1; j++)
					{
						sCina = sCina + textRow[j]; // Символи від ip до кінця рядка – ціна товару
					}
					// Перетворюємо рядкові значення кількості і ціни відповідно у int32 і Decimal
					pKilkist = Convert.ToInt32(sKilkist);
					PCina = Convert.ToDecimal(sCina);
					// Додаємо новий рядок до таблиці використовуючи метод TSkladAddRow
					TSkladAddRow(pGrupa, pNazva, pVyrobnyk, pKilkist, PCina);

					SetSumy(DGS);	// Оновити підсумки
				}
			}
		}



		public void TSkladValFiltr(String PFilter, DataGridView DGV)
		// TSkladValFiltr – метод для накладання на нашу табилцю і, відповідно на DataGridView, фільтру по значеннях стовпців
		{
			try
			{
				SkladView.RowFilter = PFilter; // Встановлюємо значення фільтру
				FiltrCriteria = PFilter;
				DGV.DataSource = SkladView; // Призначаємо гріду – SkladView, як джерело даних
			}
			catch
			{
				MessageBox.Show("Введений Фільтр не правильний");
				return;
			}
		}

		public void TSkladValSort(String PSort, DataGridView DGV, DataGridView DGVSum)
		// TSkladValSort – метод для встановлення порядку сортування 
		{
			try
			{
				SkladView.Sort = PSort; // Встановлюємо критерій сортування
				SortCriteria = PSort;
				DGV.DataSource = SkladView; // Назначаємо гріду DGV – SkladView, як джерело даних
				DGV.Refresh();
			}
			catch
			{
				MessageBox.Show("Введений критерій сортування не правильний");
				return;
			}
		}

		public void SeekNazva(string sNazva, DataGridView DGV)
		{
			int nn; // nn – номер шуканого рядка
			nn = -5; // Від'ємне значення буде у нас означати, що рядок з шуканою назвою не знайдено
			for (int i = 0; i < DGV.Rows.Count; i++) // Для кожного рядка rr із DGV
			{
				if ((string)DGV.Rows[i].Cells["Назва"].Value == sNazva)
				{
					nn = i; // Якщо назви співпали, то ми знайшли шуканий рядок. Записуємо його номер у nn і виходимо з циклу
					break;
				}
			}
			if (nn >= 0) // Якщо рядок знайдено, то показуємо його і виділяємо
			{
				DGV.FirstDisplayedCell = DGV.Rows[nn].Cells["Назва"];
				DGV.Rows[nn].Selected = true; // Виділити знайдений рядок
				DGV.CurrentCell = DGV.Rows[nn].Cells["Назва"]; // Встановимо знайдений рядок як поточний
			}
			else
			{
				MessageBox.Show("Значення не знайдено");
			}
		}



		public void SetSumy(DataGridView DGV)
		// Створюємо таблицю для підсумків, запишемо у неї підсумки і призначимо цю таблицю джерелом даних для DGV
		{
			string sGrupa, ssort;
			decimal DSuma;
			int i;
			DataTable TabSkladSum = new DataTable(); // Оголошуємо public-змінну TabSkladSum типу DataTable
													 // Таблиця підсумків буде складатись із 2 стовпців - група та вартість.
			DataColumn cNameGroupS = new DataColumn("Група ");
			DataColumn cVartistS = new DataColumn("Вартість ");
			// Оголошуємо типи даних, що будуть зберігатись у стовпцях
			cNameGroupS.DataType = System.Type.GetType("System.String");
			cVartistS.DataType = System.Type.GetType("System.Decimal");
			// Додаєм стовпці до таблиці
			TabSkladSum.Columns.Add(cNameGroupS);
			TabSkladSum.Columns.Add(cVartistS);
			ssort = SkladView.Sort; // Запам’ятаємо можливо заданий користувачем критерій сортування
			SkladView.Sort = "Група"; // Встановимо сортування по групах товару. SkladView.Count – кількість рядків
			i = 0;
			while (i < SkladView.Count) // Цикл для всіх рядків із таблиці TabSklad, що впорядкована по групах
			{
				sGrupa = (string)SkladView[i]["Група"]; // Обираємо чергову групу товару
				DSuma = 0.0M; // Обнулюємо значення суми вартостей для кожної групи
				while ((i < SkladView.Count) & (sGrupa == (string)SkladView[i]["Група"]))
				{
					try // Можливо у якомусь рядку не записана вартість, тому скористаємось засобами try - catch
					{
						DSuma = DSuma + (decimal)SkladView[i]["Вартість"]; // Накопичуємо суму вартостей по групі
					}
					catch
					{
						SkladView[i]["Вартість"] = 0M;
					}
					i = i + 1;
					if (i == SkladView.Count) { break; }
				}
				DataRow rowSkladSum = TabSkladSum.NewRow(); // Створюємо новий рядок у таблиці підсумків
				rowSkladSum["Група "] = sGrupa; // Записуємо значення назви групи
				rowSkladSum["Вартість "] = DSuma; // Записуємо значення суми вартостей по групі
				TabSkladSum.Rows.Add(rowSkladSum); // Додаємо сформований рядок до таблиці підсумків
			}
			DGV.DataSource = TabSkladSum; // Призначаємо TabSkladSum як джерело даних для гріда
			SkladView.Sort = SortCriteria; // Відновимо критерій сортування, тому що для сум було встановлено сортування по групі
		}


		// Створимо таблицю для довідника груп, запишемо у неї дані звичайним присвоєнням
		public void CreateDovGrupa()
		{
			// Оголошуємо public-змінну TabSkladSum типу DataTable
			// Таблиця DovGrupa буде складатись із одного стовпця – назва групи товару.
			DataColumn cNameGroup = new DataColumn("Група");
			// Оголошуємо тип даних, які будуть зберігатись у стовпці
			cNameGroup.DataType = System.Type.GetType("System.String");
			DovGrupa.Columns.Add(cNameGroup); // Додаємо стовпець до таблиці
			DataRow rowSklad0 = DovGrupa.NewRow();
			rowSklad0[cNameGroup] = "Книги";
			DovGrupa.Rows.Add(rowSklad0); // Додаємо сформований рядок до таблиці
			DataRow rowSklad1 = DovGrupa.NewRow();
			rowSklad1[cNameGroup] = "CD";
			DovGrupa.Rows.Add(rowSklad1); // Додаємо сформований рядок до таблиці
			DataRow rowSklad2 = DovGrupa.NewRow();
			rowSklad2[cNameGroup] = "DVD";
			DovGrupa.Rows.Add(rowSklad2); // Додаємо сформований рядок до таблиці
			DataRow rowSklad3 = DovGrupa.NewRow();
			rowSklad3[cNameGroup] = "Мобілки";
			DovGrupa.Rows.Add(rowSklad3); // Додаємо сформований рядок до таблиці
			DataRow rowSklad4 = DovGrupa.NewRow();
			rowSklad4[cNameGroup] = "Плеєри";
			DovGrupa.Rows.Add(rowSklad4); // Додаємо сформований рядок до таблиці
			DataRow rowSklad5 = DovGrupa.NewRow();
			rowSklad5[cNameGroup] = "Аксессуари";
			DovGrupa.Rows.Add(rowSklad5); // Додаємо сформований рядок до таблиці
			DataRow rowSklad6 = DovGrupa.NewRow();
			rowSklad6[cNameGroup] = "Дисплеї";
			DovGrupa.Rows.Add(rowSklad6); // Додаємо сформований рядок до таблиці
			DataRow rowSklad7 = DovGrupa.NewRow();
			rowSklad7[cNameGroup] = "Корпуси";
			DovGrupa.Rows.Add(rowSklad7); // Додаємо сформований рядок до таблиці
			DataRow rowSklad8 = DovGrupa.NewRow();
			rowSklad8[cNameGroup] = "Блоки живлення";
			DovGrupa.Rows.Add(rowSklad8); // Додаємо сформований рядок до таблиці
			DataRow rowSklad9 = DovGrupa.NewRow();
			rowSklad9[cNameGroup] = "Клавіатури";
			DovGrupa.Rows.Add(rowSklad9); // Додаємо сформований рядок до таблиці
			int nn = DovGrupa.Rows.Count;
		}


		public void AddComboGrupa(DataGridView DGV)
		{
			// Створимо екземпляр DataGridViewComboBoxColumn
			DataGridViewComboBoxColumn cGrupaCB = new DataGridViewComboBoxColumn();
			// Джерело даних для нового стовпця – стовпець з іменем "Група" у таблиці-джерелі даних.
			cGrupaCB.DataPropertyName = "Група";
			cGrupaCB.Name = "cNameGroupComb"; // Назва нового стовпця
			cGrupaCB.HeaderText = "Група"; // Заголовок на гріді нового стовпця
			cGrupaCB.DropDownWidth = 200; // Ширина "випадайки"
			cGrupaCB.Width = 120; // Ширина стовпця
			cGrupaCB.MaxDropDownItems = 7; // Кількість рядків випадайки, які одночасно будуть видимі
			cGrupaCB.FlatStyle = FlatStyle.Flat;
			cGrupaCB.ValueType = System.Type.GetType("System.string"); // Тип даних нового стовпця
			String s; Int32 n;
			n = DovGrupa.Rows.Count;
			// Тут DovGrupa – таблиця-довідник, яка містить допустимі значення назви групи товару
			foreach (DataRow r in DovGrupa.Rows) // Для кожного рядка r із таблиці DovGrupa
			{
				s = (string)r["Група"];
				cGrupaCB.Items.AddRange(r["Група"]); // Додаємо у "випадайку" елементи із довідника
			}
			DGV.Columns.Add(cGrupaCB); // Додаємо новий стовбець до гріда
									   // Перезаписати значення комірок із старого стовпця у новий
			String ss;
			// Для кожного рядка rr контрола DGV типу DataGridView
			foreach (DataGridViewRow rrr in DGV.Rows)
			{
				ss = (string)rrr.Cells["Група"].Value; // ss – значення комірки назви групи у старому стовпці
													   // Перезаписуєм значення комірки старого стовпця у комірку нового стовпця
				rrr.Cells["Група"].Value = rrr.Cells["Група"].Value;
			}
			DGV.Columns.Remove("Група"); // Вилучаємо старий стовбець типу DataGridViewTextBoxColumn
			DGV.Columns["cNameGroupcomb"].Name = "Група"; // Перейменовуємо новий у старе ім’я
			DGV.Columns["Група"].DisplayIndex = 1; // Встановлюємо порядок виведення стовпця у гріді
			DGV.Refresh(); // Оновлюємо DataGridView
		}
	}
}

