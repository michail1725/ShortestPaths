using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Graph;

namespace CourseProject
{
  public partial class MainForm : Form
  {
    DrawGraph graph;
    List<Apex> apex;
    List<Edge> edge;
    int apex_count = 0, deltaX = 0, deltaY = 0, ind = 0;
    int first_use_apex, second_use_apex;
    int[,] matrix;
    int[] edge_of_two_apex = { -1, -1 };
    int[] single_edge = { -1, -1 };
    int begin_apex = -1;
    int end_apex = -1;
    bool imfromfile = false;
    bool status = false;
    List<char> true_way;

    public MainForm()
    {
      InitializeComponent();
      apex = new List<Apex>();
      graph = new DrawGraph(mainSheet.Width, mainSheet.Height);
      edge = new List<Edge>();
      mainSheet.Image = graph.GetBitmap();
    }

    private void chooseItem_Click(object sender, EventArgs e)//выбрать
    {
      chooseItem.Enabled = false;
      if (label2.Enabled == false)
      {
        createApex.Enabled = true;
        delete.Enabled = true;
      }
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();

    }
    private void createApex_Click(object sender, EventArgs e)//добавить
    {
      chooseItem.Enabled = true;
      createApex.Enabled = false;
      if (apex.Count > 1)
      {
        connect.Enabled = true;
      }
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
    }
    private void connect_Click(object sender, EventArgs e)//соединить
    {
      chooseItem.Enabled = true;
      delete.Enabled = true;
      createApex.Enabled = true;
      connect.Enabled = false;
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
      first_use_apex = -1;
      second_use_apex = -1;
    }
    private void delete_Click(object sender, EventArgs e)//удалить
    {
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
      createApex.Enabled = true;
      connect.Enabled = true;
      delete.Enabled = false;
      chooseItem.Enabled = true;
    }
    private void delete_all_Click(object sender, EventArgs e)//Удалить все
    {
      var deleteDilog = MessageBox.Show("Вы действительно хотите полностью удалить граф?", "Полное удаление графа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (deleteDilog == DialogResult.Yes)
      {
        imfromfile = false;
        edge_of_two_apex[0] = -1;
        edge_of_two_apex[1] = -1;
        single_edge[0] = -1;
        single_edge[1] = -1;
        begin_apex = -1;
        end_apex = -1;
        apex_count = 0;
        apex.Clear();
        edge.Clear();
        graph.ClearSheet();
        DisplayMatrix.Rows.Clear();
        WayList.Items.Clear();
        mainSheet.Image = graph.GetBitmap();

        openToolStripMenuItem.Enabled = true;
        reset.Enabled = false;
        createApex.Visible = true;
        connect.Visible = true;
        delete.Visible = true;
        connect.Enabled = false;
        createApex.Enabled = true;
        delete.Enabled = false;
        chooseItem.Enabled = false;
        label8.Enabled = false;
        label4.Enabled = false;
        label2.Enabled = false;
        label9.Visible = false;
        label10.Visible = false;
        label12.Visible = false;
        label13.Visible = false;
        label14.Enabled = false;
        label15.Enabled = false;
        label9.Enabled = true;
        label3.Enabled = false;
        label10.Enabled = true;
        label6.Enabled = false;
        result_label.Visible = false;
        chooseItem.Visible = true;
        result_label.Text = "0";
        label11.Enabled = false;
        label12.Enabled = true;
        label13.Enabled = true;
        accept_weight_btn.Enabled = false;
        stopChanges.Enabled = false;
        weight_box.Enabled = false;
        useThisGraph.Enabled = false;
        retry_choice.Enabled = false;
        Calculate.Enabled = false;
        saveToolStripMenuItem.Enabled = false;
        }
    }
    private void useThisGraph_Click(object sender, EventArgs e)//Использовать граф
    {
      openToolStripMenuItem.Enabled = false;
      stopChanges.Enabled = true;
      createApex.Visible = false;
      connect.Visible = false;
      delete.Visible = false;
      label8.Enabled = true;
      label4.Enabled = true;
      label2.Enabled = true;
      useThisGraph.Enabled = false;
      delete.Enabled = false;
      createApex.Enabled = false;
      connect.Enabled = false;

      matrix = new int[apex.Count, apex.Count];
      graph.FillAdjacencyMatrix(edge, apex, matrix,imfromfile);
      DisplayMatrix.Rows.Clear();
      DisplayMatrix.RowCount = apex.Count+1;
      DisplayMatrix.ColumnCount = apex.Count+1;
     
       for (int i = 0; i < apex.Count; i++)
        if (i < 26)
        {
            DisplayMatrix.Rows[i + 1].Cells[0].Value = (char)('A' + i);
            DisplayMatrix.Rows[0].Cells[i + 1].Value = (char)('A' + i);
        }
        else
        {
            char cur_alfa = 'A';
            int tmp = (i - 25) / 99;
            string over = ((char)(cur_alfa + tmp)).ToString() + ((i - 24) - 99 * tmp);
            DisplayMatrix.Rows[i + 1].Cells[0].Value = over;
            DisplayMatrix.Rows[0].Cells[i + 1].Value = over;
            
        }
      for (int i = 0; i < apex.Count; i++)
      {
        for (int j = 0; j < apex.Count; j++)
          DisplayMatrix.Rows[i+1].Cells[j+1].Value = matrix[i, j];
      }
    }

    private void mainSheet_MouseClick(object sender, MouseEventArgs e)
    {
      if (chooseItem.Enabled == false && apex.Count > 0 && chooseItem.Visible == true)
      {

        for (int i = 0; i < apex.Count; i++)
        {
          if (Math.Pow((apex[i].coordinate_x - e.X), 2) + Math.Pow((apex[i].coordinate_y - e.Y), 2) <= graph.R * graph.R)
          {
            graph.ClearSheet();
            if (label11.Enabled == true)
            {
              graph.DrawAllGraph(apex, edge);
              mainSheet.Image = graph.GetBitmap();
              if (edge_of_two_apex[0] == -1)
              {
                end_apex = -1;
                edge_of_two_apex[0] = 1;
                begin_apex = i;
                label13.Visible = true;
                if (i < 26)
                {
                    label13.Text = ((char)('A' + i)).ToString();
                }
                else
                {
                    char cur_alfa = 'A';
                    int tmp = (i - 25) / 99;
                    string over = ((char)(cur_alfa + tmp)).ToString() + ((i - 24) - 99 * tmp);
                    label13.Text = over;
                }
                Calculate.Enabled = false;
                label12.Text = null;
              }
              else if (edge_of_two_apex[1] == -1)
              {
                edge_of_two_apex[1] = 1;
                end_apex = i;
                label12.Visible = true;
                if (i < 26)
                {
                    label12.Text = ((char)('A' + i)).ToString();
                }
                else
                {
                    char cur_alfa = 'A';
                    int tmp = (i - 25) / 99;
                    string over = ((char)(cur_alfa + tmp)).ToString() + ((i - 24) - 99 * tmp);
                    label12.Text = over;
                }
                Calculate.Enabled = true;
              }
              graph.DrawSearchApex(apex[begin_apex].coordinate_x, apex[begin_apex].coordinate_y);
              if (end_apex != -1)
              {
                if (begin_apex == end_apex)
                {
                  MessageBox.Show("Выбрана одна и та же вершина. Выберите две различные вершины.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  graph.ClearSheet();
                  graph.DrawAllGraph(apex, edge);
                  mainSheet.Image = graph.GetBitmap();
                  begin_apex = -1;
                  end_apex = -1;
                  edge_of_two_apex[1] = -1;
                  edge_of_two_apex[0] = -1;
                  label12.Text = null;
                  label13.Text = null;
                  return;
                }
                graph.DrawSearchApex(apex[end_apex].coordinate_x, apex[end_apex].coordinate_y);
                edge_of_two_apex[0] = -1;
                edge_of_two_apex[1] = -1;
              }
            }
            else if (label2.Enabled == true)
            {
              graph.DrawAllGraph(apex, edge);
              mainSheet.Image = graph.GetBitmap();
              if (edge_of_two_apex[0] == -1)
              {
                single_edge[1] = -1;
                edge_of_two_apex[0] = 1;
                single_edge[0] = i;
                label9.Visible = true;
                if (i < 26)
                {
                    label9.Text = ((char)('A' + i)).ToString();
                }
                else
                {
                    char cur_alfa = 'A';
                    int tmp = (i - 25) / 99;
                    string over = ((char)(cur_alfa + tmp)).ToString() + ((i - 24) - 99 * tmp);
                    label9.Text = over;
                }
                label10.Text = null;
                accept_weight_btn.Enabled = false;
                weight_box.Enabled = false;
              }
              else if (edge_of_two_apex[1] == -1)
              {
                edge_of_two_apex[1] = 1;
                single_edge[1] = i;
              }
              graph.DrawCorrectApex(apex[single_edge[0]].coordinate_x, apex[single_edge[0]].coordinate_y);
              if (single_edge[1] != -1)
              {
                if (single_edge[1] == single_edge[0])
                {
                  MessageBox.Show("Выбрана одна и та же вершина. Выберите две различные вершины, которые соединены общим путем.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  graph.ClearSheet();
                  graph.DrawAllGraph(apex, edge);
                  mainSheet.Image = graph.GetBitmap();
                  single_edge[0] = -1;
                  single_edge[1] = -1;
                  edge_of_two_apex[1] = -1;
                  edge_of_two_apex[0] = -1;
                  label10.Text = null;
                  label9.Text = null;
                  return;
                }
                else if (matrix[single_edge[0], single_edge[1]] == 0)
                {
                  MessageBox.Show("Данный путь не существует. Выберите пару связанных вершин!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  graph.ClearSheet();
                  graph.DrawAllGraph(apex, edge);
                  mainSheet.Image = graph.GetBitmap();
                  single_edge[0] = -1;
                  single_edge[1] = -1;
                  edge_of_two_apex[1] = -1;
                  edge_of_two_apex[0] = -1;
                  label10.Text = null;
                  label9.Text = null;
                  return;

                }

                graph.DrawCorrectApex(apex[single_edge[1]].coordinate_x, apex[single_edge[1]].coordinate_y);
                label10.Visible = true;
                if (i < 26)
                {
                    label10.Text = ((char)('A' + i)).ToString();
                }
                else
                {
                    char cur_alfa = 'A';
                    int tmp = (i - 25) / 99;
                    string over = ((char)(cur_alfa + tmp)).ToString() + ((i - 24) - 99 * tmp);
                    label10.Text = over;
                }
                accept_weight_btn.Enabled = true;
                weight_box.Enabled = true;
                edge_of_two_apex[1] = -1;
                edge_of_two_apex[0] = -1;
              }
            }
            else
            {
              if (apex.Count > 1)
              {
                connect.Enabled = true;
              }
              graph.DrawAllGraph(apex, edge);
              mainSheet.Image = graph.GetBitmap();
              graph.DrawSelectedApex(apex[i].coordinate_x, apex[i].coordinate_y);
            }


          }
        }
      }
      else if (createApex.Enabled == false && createApex.Visible == true)
      {
        chooseItem.Enabled = true;
        delete.Enabled = true;
        reset.Enabled = true;
        for (int i = 0; i < apex.Count; i++)
        {
          if (Math.Pow((apex[i].coordinate_x - e.X), 2) + Math.Pow((apex[i].coordinate_y - e.Y), 2) <= graph.R * graph.R)
          {
            MessageBox.Show("Произошло наложение вершин. Поставте вершину в другое место", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }
        }
        apex.Add(new Apex(e.X, e.Y));
        if (apex.Count > 1)
        {
          saveToolStripMenuItem.Enabled = true;
          connect.Enabled = true;
        }
        graph.DrawApex(e.X, e.Y, apex.Count);
        mainSheet.Image = graph.GetBitmap();
      }
      else if (connect.Enabled == false && connect.Visible == true)
      {
        for (int i = 0; i < apex.Count; i++)
        {
          if (Math.Pow((apex[i].coordinate_x - e.X), 2) + Math.Pow((apex[i].coordinate_y - e.Y), 2) <= graph.R * graph.R)
          {
            graph.DrawAllGraph(apex, edge);
            mainSheet.Image = graph.GetBitmap();
            if (first_use_apex == -1)
            {
              first_use_apex = i;
              second_use_apex = -1;
            }
            else if (second_use_apex == -1)
            {
              second_use_apex = i;
            }
            graph.DrawBridgeApex(apex[first_use_apex].coordinate_x, apex[first_use_apex].coordinate_y);
            if (second_use_apex != -1)
            {
              if (second_use_apex != first_use_apex)
              {
                for (int j = 0; j < edge.Count; j++)
                {
                  if ((edge[j].first_apex == first_use_apex && edge[j].second_apex == second_use_apex) || (edge[j].first_apex == second_use_apex && edge[j].second_apex == first_use_apex))
                  {
                    MessageBox.Show("Данные вершины уже соединены. Выберите другую пару вершин", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    graph.ClearSheet();
                    graph.DrawAllGraph(apex, edge);
                    mainSheet.Image = graph.GetBitmap();
                    first_use_apex = -1;
                    second_use_apex = -1;
                    return;
                  }
                }


                edge.Add(new Edge(first_use_apex, second_use_apex, 0));
                useThisGraph.Enabled = true;
                graph.DrawEdge(apex[first_use_apex], apex[second_use_apex], edge[edge.Count - 1], edge.Count - 1);
                graph.ClearSheet();
                graph.DrawAllGraph(apex, edge);
                mainSheet.Image = graph.GetBitmap();
                first_use_apex = -1;
                second_use_apex = -1;
              }
              else
              {
                MessageBox.Show("Выбрана одна и та же вершина. Выберите разные вершины", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                graph.ClearSheet();
                graph.DrawAllGraph(apex, edge);
                mainSheet.Image = graph.GetBitmap();
                first_use_apex = -1;
                second_use_apex = -1;
              }
              break;

            }

          }
        }
      }
      else if (delete.Enabled == false && delete.Visible == true)
      {
        bool deleted = false;
        for (int i = 0; i < apex.Count; i++)
        {
          if (Math.Pow((apex[i].coordinate_x - e.X), 2) + Math.Pow((apex[i].coordinate_y - e.Y), 2) <= graph.R * graph.R)
          {
            for (int j = 0; j < edge.Count; j++)
            {
              if ((edge[j].first_apex == i) || (edge[j].second_apex == i))
              {
                edge.RemoveAt(j);
                if (edge.Count == 0)
                {
                  useThisGraph.Enabled = false;
                }
                j--;
              }
              else
              {
                if (edge[j].first_apex > i)
                  edge[j].first_apex--;
                if (edge[j].second_apex > i)
                  edge[j].second_apex--;
              }
            }
            apex.RemoveAt(i);
            if (apex.Count == 0)
            {
              delete.Enabled = false;
              chooseItem.Enabled = false;
              connect.Enabled = false;
              createApex.Enabled = true;
              saveToolStripMenuItem.Enabled = false;
            }
            if (apex.Count == 1)
            {
              chooseItem.Enabled = false;
              connect.Enabled = false;
            }
            deleted = true;
            break;
          }
        }
        if (!deleted)
        {
          for (int i = 0; i < edge.Count; i++)
          {
            if (((e.X - apex[edge[i].first_apex].coordinate_x) * (apex[edge[i].second_apex].coordinate_y - apex[edge[i].first_apex].coordinate_y) / (apex[edge[i].second_apex].coordinate_x - apex[edge[i].first_apex].coordinate_x) + apex[edge[i].first_apex].coordinate_y) <= (e.Y + 4) &&
                    ((e.X - apex[edge[i].first_apex].coordinate_x) * (apex[edge[i].second_apex].coordinate_y - apex[edge[i].first_apex].coordinate_y) / (apex[edge[i].second_apex].coordinate_x - apex[edge[i].first_apex].coordinate_x) + apex[edge[i].first_apex].coordinate_y) >= (e.Y - 4))
            {
              if ((apex[edge[i].first_apex].coordinate_x <= apex[edge[i].second_apex].coordinate_x && apex[edge[i].first_apex].coordinate_x <= e.X && e.X <= apex[edge[i].second_apex].coordinate_x) ||
                  (apex[edge[i].first_apex].coordinate_x >= apex[edge[i].second_apex].coordinate_x && apex[edge[i].first_apex].coordinate_x >= e.X && e.X >= apex[edge[i].second_apex].coordinate_x))
              {
                edge.RemoveAt(i);
                deleted = true;
                if (edge.Count == 0)
                {
                  useThisGraph.Enabled = false;
                }
                break;
              }
            }

          }
        }

        if (deleted)
        {

          graph.ClearSheet();
          graph.DrawAllGraph(apex, edge);
          mainSheet.Image = graph.GetBitmap();
        }
      }
    }
    private void stopChanges_Click(object sender, EventArgs e)
    {
      edge_of_two_apex[1] = -1;
      edge_of_two_apex[0] = -1;
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
      stopChanges.Enabled = false;
      label11.Enabled = true;
      label14.Enabled = true;
      label15.Enabled = true;
      label8.Enabled = false;
      label4.Enabled = false;
      label2.Enabled = false;
      label9.Enabled = false;
      label10.Enabled = false;
      label9.Visible = false;
      label10.Visible = false;
      accept_weight_btn.Enabled = false;
      weight_box.Enabled = false;
    }

    private void Calculate_Click(object sender, EventArgs e)
    {
      chooseItem.Visible = false;
      Calculate.Enabled = false;
      retry_choice.Enabled = true;
      reset.Enabled = true;
      true_way = new List<char>();
      string way = " ";
      string tmp;
      tmp = graph.RunDijkstraAlgorithm(apex, matrix, begin_apex, end_apex, true_way).ToString();
      if (int.Parse(tmp) == int.MaxValue) {
        MessageBox.Show("Не удалось найти возможный путь между выбранными вершинами. Выберите другую пару вершин.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        edge_of_two_apex[0] = -1;
        edge_of_two_apex[1] = -1;
        graph.ClearSheet();
        graph.DrawAllGraph(apex, edge);
        mainSheet.Image = graph.GetBitmap();
        label11.Enabled = true;
        label14.Enabled = true;
        label15.Enabled = true;
        label13.Visible = false;
        label12.Visible = false;
        chooseItem.Visible = true;
        return;
      } 
      result_label.Text = tmp;
      for (int i = 0; i < true_way.Count - 1; i++)
      {
        way += true_way[i];
        if(char.IsLetter(true_way[i+1]))
        way += '-';
      }
      way += true_way[true_way.Count - 1];
      WayList.Items.Add(way);
      result_label.Visible = true;
      label6.Enabled = true;
      label3.Enabled = true;
    }

    private void mainSheet_MouseUp(object sender, MouseEventArgs e)
    {
      status = false;
    }

    private void mainSheet_MouseDown(object sender, MouseEventArgs e)
    {
      if (chooseItem.Enabled == false && apex.Count > 0)
      {
        for (int i = 0; i < apex.Count; i++)
        {
          if (Math.Pow((apex[i].coordinate_x - e.X), 2) + Math.Pow((apex[i].coordinate_y - e.Y), 2) <= graph.R * graph.R)
          {
            status = true;
            ind = i;
            deltaX = e.X - apex[i].coordinate_x;
            deltaY = e.Y - apex[i].coordinate_y;
          }
        }
      }
    }

    private void mainSheet_MouseMove(object sender, MouseEventArgs e)
    {
      if (label2.Enabled == false && label11.Enabled == false)
      {
        if (status == true) //Если "перемещение включено"
        {
          apex[ind].coordinate_x = e.X + deltaX; // изменяем координаты
          apex[ind].coordinate_y = e.Y + deltaY;
          mainSheet.Invalidate();
        }
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (mainSheet.Image != null) //если в pictureBox есть изображение
      {
        //создание диалогового окна "save как..", для сохранения изображения
        SaveFileDialog savedialog = new SaveFileDialog();
        savedialog.Title = "save граф как...";
        //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
        savedialog.OverwritePrompt = true;
        //отображать ли предупреждение, если пользователь указывает несуществующий путь
        savedialog.CheckPathExists = true;
        //список форматов файла, отображаемый в поле "Тип файла"
        savedialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        //отображается ли кнопка "Справка" в диалоговом окне
        savedialog.ShowHelp = true;
        if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
        {
          try
          {
            // запись в файл
            using (FileStream fstream = new FileStream(@savedialog.FileName, FileMode.Create))
            {
              string text = apex.Count.ToString() + " ";
              for (int i = 0; i < apex.Count; i++)
              {
                text += apex[i].coordinate_x.ToString() + " " + apex[i].coordinate_y.ToString() + " ";
              }
              text += edge.Count.ToString() + " ";
              for (int i = 0; i < edge.Count; i++)
              {
                text += edge[i].first_apex.ToString() + " " + edge[i].second_apex.ToString() + " " + edge[i].edge_weight.ToString() + " ";
              }
              // преобразуем строку в байты
              byte[] array = System.Text.Encoding.Default.GetBytes(text);
              // запись массива байтов в файл
              fstream.Write(array, 0, array.Length);
            }
          }
          catch
          {
            MessageBox.Show("Невозможно сохранить граф", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (mainSheet.Image != null) //если в pictureBox есть изображение
      {
        //создание диалогового окна "save как..", для сохранения изображения
        SaveFileDialog savedialog = new SaveFileDialog();
        savedialog.Title = "save картинку как...";
        //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
        savedialog.OverwritePrompt = true;
        //отображать ли предупреждение, если пользователь указывает несуществующий путь
        savedialog.CheckPathExists = true;
        //список форматов файла, отображаемый в поле "Тип файла"
        savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
        //отображается ли кнопка "Справка" в диалоговом окне
        savedialog.ShowHelp = true;
        if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
        {
          try
          {
            mainSheet.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
          }
          catch
          {
            MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
      if (mainSheet.Image != null) //если в pictureBox есть изображение
      {
        //создание диалогового окна "save как..", для сохранения изображения
        OpenFileDialog opendialog = new OpenFileDialog();
        opendialog.Title = "open граф";
        //отображать ли предупреждение, если пользователь указывает несуществующий путь
        opendialog.CheckPathExists = true;
        //список форматов файла, отображаемый в поле "Тип файла"
        opendialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        //отображается ли кнопка "Справка" в диалоговом окне
        opendialog.ShowHelp = true;
        if (opendialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
        {
          try
          {
            using (FileStream fstream = File.OpenRead(@opendialog.FileName))
            {
              apex.Clear();
              edge.Clear();
              imfromfile = true;
              // преобразуем строку в байты
              byte[] array = new byte[fstream.Length];
              // считываем данные
              fstream.Read(array, 0, array.Length);

              string str = System.Text.Encoding.Default.GetString(array);
              string[] words = str.Split(' ');
              int[] stream = new int[words.Length - 1];
              for (int i = 0; i < words.Length - 1; i++)
              {
                stream[i] = Int32.Parse(words[i]);
              }
              int apex_count_tmp = stream[0];
              apex_count = 0;
              for (int i = 1; i < (apex_count_tmp * 2 + 1); i += 2)
              {
                apex_count++;
                apex.Add(new Apex(stream[i], stream[i + 1]));
                graph.DrawApex(stream[i], stream[i + 1], apex.Count);
                mainSheet.Image = graph.GetBitmap();
              }
              int edge_count_tmp = stream[apex_count_tmp * 2 + 1];
              for (int i = apex_count_tmp * 2 + 2; i < ((apex_count_tmp * 2 + 2) + edge_count_tmp * 3); i += 3)
              {
                edge.Add(new Edge(stream[i], stream[i + 1], 0));
                graph.DrawEdge(apex[stream[i]], apex[stream[i + 1]], edge[edge.Count - 1], edge.Count - 1);
                mainSheet.Image = graph.GetBitmap();
                edge[edge.Count - 1].edge_weight = stream[i + 2];
              }
              graph.ClearSheet();
              graph.DrawAllGraph(apex, edge);
              mainSheet.Image = graph.GetBitmap();
              reset.Enabled = true;
              if (apex.Count > 1)
              {
                  saveToolStripMenuItem.Enabled = true;
                  connect.Enabled = true;
                  delete.Enabled = true;
              }
              else if (apex.Count >= 1) {
                  delete.Enabled = true;
              }
              createApex.Enabled = true;
              if (edge.Count > 0) {
                  useThisGraph.Enabled = true;
              }
              else
                  useThisGraph.Enabled = false;
              
              }
          }
          catch
          {
            MessageBox.Show("Невозможно открыть граф", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void retry_choice_Click(object sender, EventArgs e)
    {
      chooseItem.Visible = true;
      edge_of_two_apex[0] = -1;
      edge_of_two_apex[1] = -1;
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
      label11.Enabled = true;
      label14.Enabled = true;
      label15.Enabled = true;
      label13.Visible = false;
      label12.Visible = false;
    }

    private void weight_box_KeyPress(object sender, KeyPressEventArgs e)
    {
      char number = e.KeyChar;
      if (!Char.IsDigit(number) && number != 8)
      {
        e.Handled = true;
      }
    }


    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void accept_weight_btn_Click(object sender, EventArgs e)
    {
      int tmp = int.Parse(weight_box.Text);
      if (tmp < 1)
      {
        MessageBox.Show("Неверное значение веса. Введите другое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      graph.ClearSheet();
      graph.DrawAllGraph(apex, edge);
      mainSheet.Image = graph.GetBitmap();
      label10.Text = null;
      label9.Text = null;
      accept_weight_btn.Enabled = false;
      weight_box.Enabled = false;
      int k = graph.FillWeight(edge, apex, tmp, single_edge[0], single_edge[1]);
      int f = single_edge[0]; int j = single_edge[1];
      matrix[f, j] = edge[k].edge_weight;
      matrix[j, f] = matrix[f, j];
      DisplayMatrix.Rows[f + 1].Cells[j + 1].Value = matrix[f,j];
      DisplayMatrix.Rows[j + 1].Cells[f + 1].Value = matrix[f, j];
       weight_box.Text = null;
      MessageBox.Show("Вес успешно введен." +
      " Нажмите ОК чтобы продолжить");
    }
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.ShowDialog();
    }
  }
}

