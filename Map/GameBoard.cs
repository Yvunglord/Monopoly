using Monopoly.Map.Fields;
using Monopoly.Map.GameProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Map
{
    public class GameBoard
    {
        private static IGameElement[] fields;

        public static void InitializeBoard()
        {
            fields = new IGameElement[40];

            fields[0] = new GoField();
            fields[1] = new Property("Житная ул.", "Коричневый", 60, 2, new int[] { 50, 50, 50, 50 }, 50, new int[] { 10, 30, 90, 160, 250 }, 450);
            fields[2] = new CommunityChestField();
            fields[3] = new Property("Нагатинская ул.", "Коричневый", 80, 4, new int[] { 50, 50, 50, 50 }, 50, new int[] { 20, 60, 180, 320, 450 }, 450);
            fields[4] = new TaxField();
            fields[5] = new Railroad("Рижская железная дорога", 200, 25);
            fields[6] = new Property("Варшавское шоссе", "Светло-голубой", 100, 6, new int[] { 50, 50, 50, 50 }, 50, new int[] { 30, 90, 270, 400, 550 }, 450);
            fields[7] = new ChanceField();
            fields[8] = new Property("Ул. Огарева", "Светло-голубой", 100, 6, new int[] { 50, 50, 50, 50 }, 50, new int[] { 30, 90, 270, 400, 550 }, 450);
            fields[9] = new Property("Первая Парковая ул.", "Светло-голубой", 120, 8, new int[] { 50, 50, 50, 50 }, 50, new int[] { 40, 100, 300, 450, 600 }, 450);
            fields[10] = new InJailField();
            fields[11] = new Property("Ул. Полянка", "Розовый", 140, 10, new int[] { 100, 100, 100, 100 }, 100, new int[] { 50, 150, 450, 625, 750 }, 450);
            fields[12] = new ElectricCompanyField();
            fields[13] = new Property("Ул. Сретенка", "Розовый", 140, 10, new int[] { 100, 100, 100, 100 }, 100, new int[] { 50, 150, 450, 625, 750 }, 450);
            fields[14] = new Property("Ростовская наб.", "Розовый", 160, 12, new int[] { 100, 100, 100, 100 }, 100, new int[] { 60, 180, 500, 700, 900 }, 450);
            fields[15] = new Railroad("Курская железная дорога", 200, 25);
            fields[16] = new Property("Рязанский проспект", "Оранжевый", 180, 14, new int[] { 100, 100, 100, 100 }, 100, new int[] { 70, 200, 550, 750, 950 }, 450);
            fields[17] = new CommunityChestField();
            fields[18] = new Property("Ул. Вавилова", "Оранжевый", 180, 14, new int[] { 100, 100, 100, 100 }, 100, new int[] { 70, 200, 550, 750, 950 }, 450);
            fields[19] = new Property("Рыблевское шоссе", "Оранжевый", 200, 16, new int[] { 100, 100, 100, 100 }, 100, new int[] { 80, 220, 600, 800, 1000 }, 450);
            fields[20] = new FreeParkingField();
            fields[21] = new Property("Тверская ул.", "Красный", 220, 18, new int[] { 150, 150, 150, 150 }, 150, new int[] { 90, 250, 700, 875, 1050 }, 450);
            fields[22] = new ChanceField();
            fields[23] = new Property("Пушкинская ул.", "Красный", 220, 18, new int[] { 150, 150, 150, 150 }, 150, new int[] { 90, 250, 700, 875, 1050 }, 450);
            fields[24] = new Property("Площадь маяковского", "Красный", 240, 20, new int[] { 150, 150, 150, 150 }, 150, new int[] { 100, 300, 750, 925, 1100 }, 450);
            fields[25] = new Railroad("Казанская железная дорога", 200, 25);
            fields[26] = new Property("Ул. Грузинский вал", "Желтый", 260, 22, new int[] { 150, 150, 150, 150 }, 150, new int[] { 110, 330, 800, 975, 1150 }, 450);
            fields[27] = new Property("Новинский бульв.", "Желтый", 260, 22, new int[] { 150, 150, 150, 150 }, 150, new int[] { 110, 330, 800, 975, 1150 }, 450);
            fields[28] = new WaterWorksField();
            fields[29] = new Property("Смоленская площадь", "Желтый", 280, 24, new int[] { 150, 150, 150, 150 }, 150, new int[] { 120, 360, 850, 1025, 1200 }, 450);
            fields[30] = new GoToJailField();
            fields[31] = new Property("Ул. Щусева", "Зеленый", 300, 26, new int[] { 200, 200, 200, 200 }, 200, new int[] { 130, 390, 900, 1100, 1275 }, 450);
            fields[32] = new Property("Гоголевский бульв.", "Зеленый", 300, 26, new int[] { 200, 200, 200, 200 }, 200, new int[] { 130, 390, 900, 1100, 1275 }, 450);
            fields[33] = new CommunityChestField();
            fields[34] = new Property("Кутузовский просп.", "Зеленый", 320, 28, new int[] { 200, 200, 200, 200 }, 200, new int[] { 150, 450, 1000, 1200, 1400 }, 450);
            fields[35] = new Railroad("Ленинградская железная дорога", 200, 25);
            fields[36] = new ChanceField();
            fields[37] = new Property("Ул. Малая Бронная", "Темно-синий", 350, 35, new int[] { 200, 200, 200, 200 }, 200, new int[] { 200, 600, 1400, 1700, 2000 }, 450);
            fields[38] = new TaxField();
            fields[39] = new Property("Арбат", "Темно-синий", 400, 50, new int[] { 200, 200, 200, 200 }, 200, new int[] { 200, 600, 1400, 1700, 2000 }, 450);
        }

        public static IGameElement GetField(int position)
        {
            return fields[position];
        }

        public static IGameElement[] GetAllFields()
        {
            return fields;
        }
    }
}
