using System.Collections.Generic;
using System.Drawing;


namespace Graph
{

  class Apex
  {
    public int coordinate_x, coordinate_y;

    public Apex(int coordinate_x, int coordinate_y)
    {
      this.coordinate_x = coordinate_x;
      this.coordinate_y = coordinate_y;
    }
  }

  class Edge
  {
    public int first_apex, second_apex, edge_weight;

    public Edge(int first_apex, int second_apex, int edge_weight)
    {
      this.edge_weight = edge_weight;
      this.first_apex = first_apex;
      this.second_apex = second_apex;
    }
  }

  class DrawGraph
  {
    public int R = 20;
    Bitmap bitmap;
    Pen pen_black;
    Pen pen_red;
    Pen pen_gold;
    Pen pen_blue;
    Pen pen_lime;
    Pen pen_orange;
    Graphics graphics_drawning;
    Font font;
    Brush brush_object;
    PointF point;


    public DrawGraph(int width, int height)
    {
      bitmap = new Bitmap(1800, 1024);
      graphics_drawning = Graphics.FromImage(bitmap);
      ClearSheet();
      pen_orange = new Pen(Color.OrangeRed);
      pen_black = new Pen(Color.Black);
      pen_black.Width = 2;
      pen_red = new Pen(Color.Red);
      pen_red.Width = 2;
      pen_gold = new Pen(Color.DarkGoldenrod);
      pen_gold.Width = 2;
      pen_blue = new Pen(Color.Blue);
      pen_blue.Width = 2;
      pen_lime = new Pen(Color.Lime);
      pen_lime.Width = 2;
      font = new Font("Comic Sans MS", 15);
      brush_object = Brushes.Black;
    }



    public Bitmap GetBitmap()
    {
      return bitmap;
    }



    public void ClearSheet()
    {
      graphics_drawning.Clear(Color.Cornsilk);
    }

    public void DrawApex(int coordinate_x, int coordinate_y, int tag_name)
    {
      graphics_drawning.FillEllipse(Brushes.White, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
      graphics_drawning.DrawEllipse(pen_black, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
      point = new PointF(coordinate_x - 9, coordinate_y - 9);
      if (tag_name < 27)
      {
        graphics_drawning.DrawString(((char)('A' + tag_name - 1)).ToString(), font, brush_object, point);
      }
      else
      {
        point = new PointF(coordinate_x - 21, coordinate_y - 9);
        char cur_alfa = 'A';
        int tmp = (tag_name - 26) / 99;
        string over = ((char)(cur_alfa + tmp)).ToString() + ((tag_name - 25) - 99 * tmp);
        graphics_drawning.DrawString(over, font, brush_object, point);
      }

    }
    public void DrawBridgeApex(int coordinate_x, int coordinate_y)
    {
      graphics_drawning.DrawEllipse(pen_orange, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
    }
    public void DrawSelectedApex(int coordinate_x, int coordinate_y)
    {
      graphics_drawning.DrawEllipse(pen_red, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
    }
    public void DrawCorrectApex(int coordinate_x, int coordinate_y)
    {
      graphics_drawning.DrawEllipse(pen_blue, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
    }
    public void DrawSearchApex(int coordinate_x, int coordinate_y)
    {
      graphics_drawning.DrawEllipse(pen_lime, (coordinate_x - R), (coordinate_y - R), 2 * R, 2 * R);
    }
    public void DrawEdge(Apex first_apex, Apex second_apex, Edge edge, int number_of_edge)
    {
      if (edge.first_apex != edge.second_apex)
      {
        graphics_drawning.DrawLine(pen_gold, first_apex.coordinate_x, first_apex.coordinate_y, second_apex.coordinate_x, second_apex.coordinate_y);
        point = new PointF((first_apex.coordinate_x + second_apex.coordinate_x) / 2, (first_apex.coordinate_y + second_apex.coordinate_y) / 2);
        graphics_drawning.DrawString(((int)(1 + number_of_edge)).ToString(), font, brush_object, point);

        DrawApex(first_apex.coordinate_x, first_apex.coordinate_y, edge.first_apex + 1);
        DrawApex(second_apex.coordinate_x, second_apex.coordinate_y, edge.second_apex + 1);
      }
    }

    public void DrawAllGraph(List<Apex> apex, List<Edge> edge)
    {

      for (int i = 0; i < edge.Count; i++)
      {

        graphics_drawning.DrawLine(pen_gold, apex[edge[i].first_apex].coordinate_x, apex[edge[i].first_apex].coordinate_y, apex[edge[i].second_apex].coordinate_x, apex[edge[i].second_apex].coordinate_y);
        point = new PointF((apex[edge[i].first_apex].coordinate_x + apex[edge[i].second_apex].coordinate_x) / 2, (apex[edge[i].first_apex].coordinate_y + apex[edge[i].second_apex].coordinate_y) / 2);
        graphics_drawning.DrawString(((int)(1 + i)).ToString(), font, brush_object, point);

      }
      for (int i = 0; i < apex.Count; i++)
      {
        DrawApex(apex[i].coordinate_x, apex[i].coordinate_y, i + 1);
      }
    }
    public void FillAdjacencyMatrix(List<Edge> edge, List<Apex> apex, int[,] matrix, bool imfromfile)
    {
      for (int i = 0; i < apex.Count; i++)
        for (int j = 0; j < apex.Count; j++)
          if (imfromfile)
          {
            if (matrix[i, j] != 0)
              continue;
            else
              matrix[i, j] = 0;
          }
          else
            matrix[i, j] = 0;

      for (int i = 0; i < edge.Count; i++)
      {
        if (imfromfile)
        {
          if (edge[i].edge_weight != 0)
          {
            matrix[edge[i].first_apex, edge[i].second_apex] = edge[i].edge_weight;
            matrix[edge[i].second_apex, edge[i].first_apex] = edge[i].edge_weight;
          }
          else
          {
            matrix[edge[i].first_apex, edge[i].second_apex] = 1;
            matrix[edge[i].second_apex, edge[i].first_apex] = 1;
            edge[i].edge_weight = 1;
          }
        }
        else
        {
          matrix[edge[i].first_apex, edge[i].second_apex] = 1;
          matrix[edge[i].second_apex, edge[i].first_apex] = 1;
          edge[i].edge_weight = 1;
        }
      }
    }

    public int FillWeight(List<Edge> edge, List<Apex> apex, int user_weight, int selected1, int selected2)
    {
      int index = 0;
      for (int i = 0; i < edge.Count; i++)
      {
        if (edge[i].first_apex == selected1)
        {
          if (edge[i].second_apex == selected2)
          {
            edge[i].edge_weight = user_weight;
            index = i;
          }
        }
        else if (edge[i].first_apex == selected2)
        {
          if (edge[i].second_apex == selected1)
          {
            edge[i].edge_weight = user_weight;
            index = i;
          }
        }
      }
      return index;
    }
    public int RunDijkstraAlgorithm(List<Apex> apex, int[,] graph, int src, int end_apex, List<char> true_way)
    {
      int[] dist = new int[apex.Count]; //пути присваиваемые вершине
      bool[] sptSet = new bool[apex.Count]; // посещена вершина или нет
      for (int i = 0; i < apex.Count; i++)
      {
        dist[i] = int.MaxValue;
        sptSet[i] = false;
      }
      dist[src] = 0;  // src - начальная вершина
      for (int count = 0; count < apex.Count - 1; count++)
      {
        int u = FindMinDistance(apex, dist, sptSet); // индекс вершины из которой ищем путь (меняется)
        sptSet[u] = true;
        for (int v = 0; v < apex.Count; v++) // dist v - вес следующей вершины изначально бесконечность
        {
          if ((!sptSet[v] && graph[u, v] != 0) && (dist[u] != int.MaxValue) && (dist[u] + graph[u, v] < dist[v]))
          {
            dist[v] = dist[u] + graph[u, v]; // присваиваем вершине вес ребра + вес той из которой пришли
          }
        }
      }
      if (dist[end_apex] != int.MaxValue)
        DiscoverRealWay(apex, end_apex, dist, graph, true_way, src);  // вычитаем вес текущей из рассчитаного и сравниваем 
      return dist[end_apex]; // с весом предыдущей
    }

    int FindMinDistance(List<Apex> apex, int[] dist, bool[] sptSet)
    {
      int min = int.MaxValue, min_index = -1;
      for (int v = 0; v < apex.Count; v++)
        if (sptSet[v] == false && dist[v] <= min)
        {
          min = dist[v];
          min_index = v;
        }
      return min_index;
    }

    void DiscoverRealWay(List<Apex> apex, int end_apex, int[] dist, int[,] matrix, List<char> true_way, int begin_apex)
    {
      int[] necessary_points = new int[apex.Count]; // массив посещенных вершин
      necessary_points[0] = end_apex; // начальный элемент - конечная вершина
      int k = 1; // индекс предыдущей вершины
      int weight = dist[end_apex]; // вес конечной вершины

      while (end_apex != begin_apex) // пока не дошли до начальной вершины
      {
        for (int i = 0; i < apex.Count; i++) // просматриваем все вершины
          if (matrix[end_apex, i] != 0)   // если связь есть
          {
            int tmp = weight - matrix[end_apex, i]; // определяем вес пути из предыдущей вершины
            if (tmp == dist[i]) // если вес совпал с рассчитанным
            {                 // значит из этой вершины и был переход
              weight = tmp; // сохраняем новый вес
              end_apex = i;       // сохраняем предыдущую вершину
              necessary_points[k] = i; // и записываем ее в массив
              k++;
            }
          }
      }
      for (int i = k - 1; i >= 0; i--)
      {
        if (necessary_points[i] < 26)
        {
          true_way.Add((char)('A' + necessary_points[i]));
        }
        else
        {
          char cur_alfa = 'A';
          int tmp = (necessary_points[i] - 25) / 99;
          true_way.Add((char)(cur_alfa + tmp));
          true_way.Add((char)(((((necessary_points[i] - 24) - 99 * tmp) / 10)) + '0'));
          true_way.Add((char)(((((necessary_points[i] - 24) - 99 * tmp) % 10)) + '0'));
        }

      }
    }
  }
}


