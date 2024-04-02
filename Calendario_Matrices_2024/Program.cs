// Actividad de Calendario Matrices 2024:

// Título de la Ventana de Ejecución:
Console.Title = "Calendario Matrices 2024 - Desarrollado por Jorge L";

bool menuPrincipal = true;

// Ciclo Do While para Menú Principal:
do
{
    Console.WriteLine("======================================================");
    Console.WriteLine("////////////////// CALENDARIO 2024 ///////////////////");
    Console.WriteLine("======================================================");
    Console.WriteLine("[1]. Consultar Mes de Enero");
    Console.WriteLine("[2]. Consultar Mes de Febrero");
    Console.WriteLine("[3]. Consultar Mes de Marzo");
    Console.WriteLine("[4]. Consultar Mes de Abril");
    Console.WriteLine("[5]. Consultar Mes de Mayo");
    Console.WriteLine("[6]. Consultar Mes de Junio");
    Console.WriteLine("[7]. Consultar Mes de Julio");
    Console.WriteLine("[8]. Consultar Mes de Agosto");
    Console.WriteLine("[9]. Consultar Mes de Septiembre");
    Console.WriteLine("[10]. Consultar Mes de Octubre");
    Console.WriteLine("[11]. Consultar Mes de Noviembre");
    Console.WriteLine("[12]. Consultar Mes de Diciembre");
    Console.WriteLine("[13]. Consultar Todo el Calendario");
    Console.WriteLine("[14]. Salir del Programa");
    Console.WriteLine("======================================================");

    // Matriz de Enero (1):
    string[,] matriz_enero = new string[10, 40];
    int op;
    matriz_enero[0, 0] = "==";
    matriz_enero[0, 1] = "==";
    matriz_enero[0, 2] = "==";
    matriz_enero[0, 3] = "==";
    matriz_enero[0, 4] = "==";
    matriz_enero[0, 5] = "==";
    matriz_enero[0, 6] = "==";
    matriz_enero[1, 0] = "||";
    matriz_enero[1, 1] = "||";
    matriz_enero[1, 2] = "E";
    matriz_enero[1, 3] = "N";
    matriz_enero[1, 4] = "E";
    matriz_enero[1, 5] = "R";
    matriz_enero[1, 6] = "O";
    matriz_enero[1, 7] = "||";
    matriz_enero[1, 8] = "||";
    matriz_enero[2, 1] = "==";
    matriz_enero[2, 2] = "==";
    matriz_enero[2, 3] = "==";
    matriz_enero[2, 4] = "==";
    matriz_enero[2, 5] = "==";
    matriz_enero[2, 6] = "==";
    matriz_enero[2, 7] = "==";
    matriz_enero[3, 0] = "Lu";
    matriz_enero[3, 1] = "Ma";
    matriz_enero[3, 2] = "Mi";
    matriz_enero[3, 3] = "Ju";
    matriz_enero[3, 4] = "Vi";
    matriz_enero[3, 5] = "Sa";
    matriz_enero[3, 6] = "Do";
    matriz_enero[4, 1] = "1 ";
    matriz_enero[4, 2] = "2 ";
    matriz_enero[4, 3] = "3 ";
    matriz_enero[4, 4] = "4 ";
    matriz_enero[4, 5] = "5 ";
    matriz_enero[4, 6] = "6 ";
    matriz_enero[4, 7] = "7 ";
    matriz_enero[5, 1] = "8";
    matriz_enero[5, 2] = " 9";
    matriz_enero[5, 3] = "10";
    matriz_enero[5, 4] = "11";
    matriz_enero[5, 5] = "12";
    matriz_enero[5, 6] = "13";
    matriz_enero[5, 7] = "14";
    matriz_enero[6, 0] = "15";
    matriz_enero[6, 1] = "16";
    matriz_enero[6, 2] = "17";
    matriz_enero[6, 3] = "18";
    matriz_enero[6, 4] = "19";
    matriz_enero[6, 5] = "20";
    matriz_enero[6, 6] = "21";
    matriz_enero[7, 0] = "22";
    matriz_enero[7, 1] = "23";
    matriz_enero[7, 2] = "24";
    matriz_enero[7, 3] = "25";
    matriz_enero[7, 4] = "26";
    matriz_enero[7, 5] = "27";
    matriz_enero[7, 6] = "28";
    matriz_enero[8, 0] = "29";
    matriz_enero[8, 1] = "30";
    matriz_enero[8, 2] = "31";
    matriz_enero[8, 3] = "  ";
    matriz_enero[8, 4] = "  ";
    matriz_enero[8, 5] = "  ";
    matriz_enero[8, 6] = "  ";

    // Matriz de Febrero (2):
    string[,] matriz_febrero = new string[10, 40];

    matriz_febrero[0, 11] = "==";
    matriz_febrero[0, 12] = "==";
    matriz_febrero[0, 13] = "==";
    matriz_febrero[0, 14] = "==";
    matriz_febrero[0, 15] = "==";
    matriz_febrero[0, 16] = "==";
    matriz_febrero[0, 17] = "==";
    matriz_febrero[1, 11] = "|||";
    matriz_febrero[1, 12] = "F";
    matriz_febrero[1, 13] = "E";
    matriz_febrero[1, 14] = "B";
    matriz_febrero[1, 15] = "R";
    matriz_febrero[1, 16] = "E";
    matriz_febrero[1, 17] = "R";
    matriz_febrero[1, 18] = "O";
    matriz_febrero[1, 19] = "|||";
    matriz_febrero[2, 12] = "==";
    matriz_febrero[2, 13] = "==";
    matriz_febrero[2, 14] = "==";
    matriz_febrero[2, 15] = "==";
    matriz_febrero[2, 16] = "==";
    matriz_febrero[2, 17] = "==";
    matriz_febrero[2, 18] = "==";
    matriz_febrero[3, 11] = "Lu";
    matriz_febrero[3, 12] = "Ma";
    matriz_febrero[3, 13] = "Mi";
    matriz_febrero[3, 14] = "Ju";
    matriz_febrero[3, 15] = "Vi";
    matriz_febrero[3, 16] = "Sa";
    matriz_febrero[3, 17] = "Do";
    matriz_febrero[4, 12] = " ";
    matriz_febrero[4, 13] = " ";
    matriz_febrero[4, 14] = " ";
    matriz_febrero[4, 15] = " ";
    matriz_febrero[4, 16] = " 1 ";
    matriz_febrero[4, 17] = "2 ";
    matriz_febrero[4, 18] = "3 ";
    matriz_febrero[4, 19] = "4 ";
    matriz_febrero[5, 12] = "5";
    matriz_febrero[5, 13] = " 6";
    matriz_febrero[5, 14] = " 7";
    matriz_febrero[5, 15] = " 8";
    matriz_febrero[5, 16] = " 9";
    matriz_febrero[5, 17] = "10";
    matriz_febrero[5, 18] = "11";
    matriz_febrero[6, 11] = "12";
    matriz_febrero[6, 12] = "13";
    matriz_febrero[6, 13] = "14";
    matriz_febrero[6, 14] = "15";
    matriz_febrero[6, 15] = "16";
    matriz_febrero[6, 16] = "17";
    matriz_febrero[6, 17] = "18";
    matriz_febrero[7, 11] = "19";
    matriz_febrero[7, 12] = "20";
    matriz_febrero[7, 13] = "21";
    matriz_febrero[7, 14] = "22";
    matriz_febrero[7, 15] = "23";
    matriz_febrero[7, 16] = "24";
    matriz_febrero[7, 17] = "25";
    matriz_febrero[8, 11] = "26";
    matriz_febrero[8, 12] = "27";
    matriz_febrero[8, 13] = "28";
    matriz_febrero[8, 14] = "29";
    matriz_febrero[8, 15] = "  ";
    matriz_febrero[8, 16] = " ";
    matriz_febrero[8, 17] = " ";
    matriz_febrero[8, 18] = " ";

    // Matriz de Marzo (3):
    string[,] matriz_marzo = new string[10, 40];

    matriz_marzo[0, 22] = "==";
    matriz_marzo[0, 23] = "==";
    matriz_marzo[0, 24] = "==";
    matriz_marzo[0, 25] = "==";
    matriz_marzo[0, 26] = "==";
    matriz_marzo[0, 27] = "==";
    matriz_marzo[0, 28] = "==";
    matriz_marzo[1, 22] = "||";
    matriz_marzo[1, 23] = "||";
    matriz_marzo[1, 24] = "M";
    matriz_marzo[1, 25] = "A";
    matriz_marzo[1, 26] = "R";
    matriz_marzo[1, 27] = "Z";
    matriz_marzo[1, 28] = "O";
    matriz_marzo[1, 29] = "||";
    matriz_marzo[1, 30] = "||";
    matriz_marzo[2, 23] = "==";
    matriz_marzo[2, 24] = "==";
    matriz_marzo[2, 25] = "==";
    matriz_marzo[2, 26] = "==";
    matriz_marzo[2, 27] = "==";
    matriz_marzo[2, 28] = "==";
    matriz_marzo[2, 29] = "==";
    matriz_marzo[3, 22] = "Lu";
    matriz_marzo[3, 23] = "Ma";
    matriz_marzo[3, 24] = "Mi";
    matriz_marzo[3, 25] = "Ju";
    matriz_marzo[3, 26] = "Vi";
    matriz_marzo[3, 27] = "Sa";
    matriz_marzo[3, 28] = "Do";
    matriz_marzo[4, 24] = " ";
    matriz_marzo[4, 25] = " ";
    matriz_marzo[4, 26] = " ";
    matriz_marzo[4, 27] = " ";
    matriz_marzo[4, 28] = " ";
    matriz_marzo[4, 29] = " 1";
    matriz_marzo[4, 30] = " 2";
    matriz_marzo[4, 31] = " 3";
    matriz_marzo[5, 23] = "4";
    matriz_marzo[5, 24] = " 5";
    matriz_marzo[5, 25] = " 6";
    matriz_marzo[5, 26] = " 7";
    matriz_marzo[5, 27] = " 8";
    matriz_marzo[5, 28] = " 9";
    matriz_marzo[5, 29] = "10";
    matriz_marzo[6, 22] = "11";
    matriz_marzo[6, 23] = "12";
    matriz_marzo[6, 24] = "13";
    matriz_marzo[6, 25] = "14";
    matriz_marzo[6, 26] = "15";
    matriz_marzo[6, 27] = "16";
    matriz_marzo[6, 28] = "17";
    matriz_marzo[7, 22] = "18";
    matriz_marzo[7, 23] = "19";
    matriz_marzo[7, 24] = "20";
    matriz_marzo[7, 25] = "21";
    matriz_marzo[7, 26] = "22";
    matriz_marzo[7, 27] = "23";
    matriz_marzo[7, 28] = "24";
    matriz_marzo[8, 22] = "25";
    matriz_marzo[8, 23] = "26";
    matriz_marzo[8, 24] = "27";
    matriz_marzo[8, 25] = "28";
    matriz_marzo[8, 26] = "29";
    matriz_marzo[8, 27] = "30";
    matriz_marzo[8, 28] = "31";

    // Matriz de Abril (4):
    string[,] matriz_abril = new string[10, 50];

    matriz_abril[0, 33] = "==";
    matriz_abril[0, 34] = "==";
    matriz_abril[0, 35] = "==";
    matriz_abril[0, 36] = "==";
    matriz_abril[0, 37] = "==";
    matriz_abril[0, 38] = "==";
    matriz_abril[0, 39] = "==";
    matriz_abril[1, 33] = "||";
    matriz_abril[1, 34] = "||";
    matriz_abril[1, 35] = "A";
    matriz_abril[1, 36] = "B";
    matriz_abril[1, 37] = "R";
    matriz_abril[1, 38] = "I";
    matriz_abril[1, 39] = "L";
    matriz_abril[1, 40] = "||";
    matriz_abril[1, 41] = "||";
    matriz_abril[2, 34] = "==";
    matriz_abril[2, 35] = "==";
    matriz_abril[2, 36] = "==";
    matriz_abril[2, 37] = "==";
    matriz_abril[2, 38] = "==";
    matriz_abril[2, 39] = "==";
    matriz_abril[2, 40] = "==";
    matriz_abril[3, 33] = "Lu";
    matriz_abril[3, 34] = "Ma";
    matriz_abril[3, 35] = "Mi";
    matriz_abril[3, 36] = "Ju";
    matriz_abril[3, 37] = "Vi";
    matriz_abril[3, 38] = "Sa";
    matriz_abril[3, 39] = "Do";
    matriz_abril[4, 33] = " 1";
    matriz_abril[4, 34] = " 2";
    matriz_abril[4, 35] = " 3";
    matriz_abril[4, 36] = " 4";
    matriz_abril[4, 37] = " 5";
    matriz_abril[4, 38] = " 6";
    matriz_abril[4, 39] = " 7";
    matriz_abril[5, 33] = " 8";
    matriz_abril[5, 34] = " 9";
    matriz_abril[5, 35] = "10";
    matriz_abril[5, 36] = "11";
    matriz_abril[5, 37] = "12";
    matriz_abril[5, 38] = "13";
    matriz_abril[5, 39] = "14";
    matriz_abril[6, 33] = "15";
    matriz_abril[6, 34] = "16";
    matriz_abril[6, 35] = "17";
    matriz_abril[6, 36] = "18";
    matriz_abril[6, 37] = "19";
    matriz_abril[6, 38] = "20";
    matriz_abril[6, 39] = "21";
    matriz_abril[7, 33] = "22";
    matriz_abril[7, 34] = "23";
    matriz_abril[7, 35] = "24";
    matriz_abril[7, 36] = "25";
    matriz_abril[7, 37] = "26";
    matriz_abril[7, 38] = "27";
    matriz_abril[7, 39] = "28";
    matriz_abril[8, 33] = "29";
    matriz_abril[8, 34] = "30";
    matriz_abril[8, 35] = " ";
    matriz_abril[8, 36] = " ";
    matriz_abril[8, 37] = " ";
    matriz_abril[8, 38] = " ";
    matriz_abril[8, 39] = " ";

    // Matriz de Mayo (5):
    string[,] matriz_mayo = new string[20, 50];

    matriz_mayo[10, 0] = "==";
    matriz_mayo[10, 1] = "==";
    matriz_mayo[10, 2] = "==";
    matriz_mayo[10, 3] = "==";
    matriz_mayo[10, 4] = "==";
    matriz_mayo[10, 5] = "==";
    matriz_mayo[10, 6] = "==";
    matriz_mayo[11, 0] = "||";
    matriz_mayo[11, 1] = "|| ";
    matriz_mayo[11, 2] = "M";
    matriz_mayo[11, 3] = "A";
    matriz_mayo[11, 4] = "Y";
    matriz_mayo[11, 5] = "O";
    matriz_mayo[11, 6] = "||";
    matriz_mayo[11, 7] = "||";
    matriz_mayo[12, 0] = "==";
    matriz_mayo[12, 1] = "==";
    matriz_mayo[12, 2] = "==";
    matriz_mayo[12, 3] = "==";
    matriz_mayo[12, 4] = "==";
    matriz_mayo[12, 5] = "==";
    matriz_mayo[12, 6] = "==";
    matriz_mayo[13, 0] = "Lu";
    matriz_mayo[13, 1] = "Ma";
    matriz_mayo[13, 2] = "Mi";
    matriz_mayo[13, 3] = "Ju";
    matriz_mayo[13, 4] = "Vi";
    matriz_mayo[13, 5] = "Sa";
    matriz_mayo[13, 6] = "Do";
    matriz_mayo[14, 0] = "  ";
    matriz_mayo[14, 1] = "  ";
    matriz_mayo[14, 2] = " 1";
    matriz_mayo[14, 3] = " 2";
    matriz_mayo[14, 4] = " 3";
    matriz_mayo[14, 5] = " 4";
    matriz_mayo[14, 6] = " 5";
    matriz_mayo[15, 0] = " 6 ";
    matriz_mayo[15, 1] = "7 ";
    matriz_mayo[15, 2] = "8 ";
    matriz_mayo[15, 3] = "9";
    matriz_mayo[15, 4] = "10";
    matriz_mayo[15, 5] = "11";
    matriz_mayo[15, 6] = "12";
    matriz_mayo[16, 0] = "13";
    matriz_mayo[16, 1] = "14";
    matriz_mayo[16, 2] = "15";
    matriz_mayo[16, 3] = "16";
    matriz_mayo[16, 4] = "17";
    matriz_mayo[16, 5] = "18";
    matriz_mayo[16, 6] = "19";
    matriz_mayo[17, 0] = "20";
    matriz_mayo[17, 1] = "21";
    matriz_mayo[17, 2] = "22";
    matriz_mayo[17, 3] = "23";
    matriz_mayo[17, 4] = "24";
    matriz_mayo[17, 5] = "25";
    matriz_mayo[17, 6] = "26";
    matriz_mayo[18, 0] = "27";
    matriz_mayo[18, 1] = "28";
    matriz_mayo[18, 2] = "29";
    matriz_mayo[18, 3] = "30";
    matriz_mayo[18, 4] = "31";
    matriz_mayo[18, 5] = "  ";
    matriz_mayo[18, 6] = "  ";

    // Matriz de Junio (6):
    string[,] matriz_junio = new string[20, 50];

    matriz_junio[10, 11] = "==";
    matriz_junio[10, 12] = "==";
    matriz_junio[10, 13] = "==";
    matriz_junio[10, 14] = "==";
    matriz_junio[10, 15] = "==";
    matriz_junio[10, 16] = "==";
    matriz_junio[10, 17] = "==";
    matriz_junio[11, 11] = "||";
    matriz_junio[11, 12] = "||";
    matriz_junio[11, 13] = "J";
    matriz_junio[11, 14] = "U";
    matriz_junio[11, 15] = "N";
    matriz_junio[11, 16] = "I";
    matriz_junio[11, 17] = "O";
    matriz_junio[11, 18] = "||";
    matriz_junio[11, 19] = "||";
    matriz_junio[12, 11] = "==";
    matriz_junio[12, 12] = "==";
    matriz_junio[12, 13] = "==";
    matriz_junio[12, 14] = "==";
    matriz_junio[12, 15] = "==";
    matriz_junio[12, 16] = "==";
    matriz_junio[12, 17] = "==";
    matriz_junio[13, 11] = "Lu";
    matriz_junio[13, 12] = "Ma";
    matriz_junio[13, 13] = "Mi";
    matriz_junio[13, 14] = "Ju";
    matriz_junio[13, 15] = "Vi";
    matriz_junio[13, 16] = "Sa";
    matriz_junio[13, 17] = "Do";
    matriz_junio[14, 11] = "  ";
    matriz_junio[14, 12] = "  ";
    matriz_junio[14, 13] = "  ";
    matriz_junio[14, 14] = "  ";
    matriz_junio[14, 15] = "  ";
    matriz_junio[14, 16] = " 1";
    matriz_junio[14, 17] = " 2";
    matriz_junio[15, 11] = " 3 ";
    matriz_junio[15, 12] = "4 ";
    matriz_junio[15, 13] = "5 ";
    matriz_junio[15, 14] = "6 ";
    matriz_junio[15, 15] = "7 ";
    matriz_junio[15, 16] = "8 ";
    matriz_junio[15, 17] = "9 ";
    matriz_junio[16, 11] = "10";
    matriz_junio[16, 12] = "11";
    matriz_junio[16, 13] = "12";
    matriz_junio[16, 14] = "13";
    matriz_junio[16, 15] = "14";
    matriz_junio[16, 16] = "15";
    matriz_junio[16, 17] = "16";
    matriz_junio[17, 11] = "17";
    matriz_junio[17, 12] = "18";
    matriz_junio[17, 13] = "19";
    matriz_junio[17, 14] = "20";
    matriz_junio[17, 15] = "21";
    matriz_junio[17, 16] = "22";
    matriz_junio[17, 17] = "23";
    matriz_junio[18, 11] = "24";
    matriz_junio[18, 12] = "25";
    matriz_junio[18, 13] = "26";
    matriz_junio[18, 14] = "27";
    matriz_junio[18, 15] = "28";
    matriz_junio[18, 16] = "29";
    matriz_junio[18, 17] = "30";

    // Matriz de Julio (7):
    string[,] matriz_julio = new string[20, 50];

    matriz_julio[10, 22] = "==";
    matriz_julio[10, 23] = "==";
    matriz_julio[10, 24] = "==";
    matriz_julio[10, 25] = "==";
    matriz_julio[10, 26] = "==";
    matriz_julio[10, 27] = "==";
    matriz_julio[10, 28] = "==";
    matriz_julio[11, 22] = "||";
    matriz_julio[11, 23] = "||";
    matriz_julio[11, 24] = "J";
    matriz_julio[11, 25] = "U";
    matriz_julio[11, 26] = "L";
    matriz_julio[11, 27] = "I";
    matriz_julio[11, 28] = "O";
    matriz_julio[11, 29] = "||";
    matriz_julio[11, 30] = "|";
    matriz_julio[12, 22] = "==";
    matriz_julio[12, 23] = "==";
    matriz_julio[12, 24] = "==";
    matriz_julio[12, 25] = "==";
    matriz_julio[12, 26] = "==";
    matriz_julio[12, 27] = "==";
    matriz_julio[12, 28] = "==";
    matriz_julio[13, 22] = "Lu";
    matriz_julio[13, 23] = "Ma";
    matriz_julio[13, 24] = "Mi";
    matriz_julio[13, 25] = "Ju";
    matriz_julio[13, 26] = "Vi";
    matriz_julio[13, 27] = "Sa";
    matriz_julio[13, 28] = "Do";
    matriz_julio[14, 22] = " 1";
    matriz_julio[14, 23] = " 2";
    matriz_julio[14, 24] = " 3";
    matriz_julio[14, 25] = " 4";
    matriz_julio[14, 26] = " 5";
    matriz_julio[14, 27] = " 6";
    matriz_julio[14, 28] = " 7";
    matriz_julio[15, 23] = "8 ";
    matriz_julio[15, 24] = "9";
    matriz_julio[15, 25] = "10";
    matriz_julio[15, 26] = "11";
    matriz_julio[15, 27] = "12";
    matriz_julio[15, 28] = "13";
    matriz_julio[15, 29] = "14";
    matriz_julio[16, 22] = "15";
    matriz_julio[16, 23] = "16";
    matriz_julio[16, 24] = "17";
    matriz_julio[16, 25] = "18";
    matriz_julio[16, 26] = "19";
    matriz_julio[16, 27] = "20";
    matriz_julio[16, 28] = "21";
    matriz_julio[17, 22] = "22";
    matriz_julio[17, 23] = "23";
    matriz_julio[17, 24] = "24";
    matriz_julio[17, 25] = "25";
    matriz_julio[17, 26] = "26";
    matriz_julio[17, 27] = "27";
    matriz_julio[17, 28] = "28";
    matriz_julio[18, 22] = "29";
    matriz_julio[18, 23] = "30";
    matriz_julio[18, 24] = "31";
    matriz_julio[18, 25] = "  ";
    matriz_julio[18, 26] = "  ";
    matriz_julio[18, 27] = "  ";
    matriz_julio[18, 28] = "  ";

    // Matriz de Agosto (8):
    string[,] matriz_agosto = new string[20, 50];

    matriz_agosto[10, 33] = "==";
    matriz_agosto[10, 34] = "==";
    matriz_agosto[10, 35] = "==";
    matriz_agosto[10, 36] = "==";
    matriz_agosto[10, 37] = "==";
    matriz_agosto[10, 38] = "==";
    matriz_agosto[10, 39] = "==";
    matriz_agosto[11, 33] = "|||";
    matriz_agosto[11, 34] = " A";
    matriz_agosto[11, 35] = "G";
    matriz_agosto[11, 36] = "O";
    matriz_agosto[11, 37] = "S";
    matriz_agosto[11, 38] = "T";
    matriz_agosto[11, 39] = "O";
    matriz_agosto[11, 40] = " |||";
    matriz_agosto[11, 41] = " ";
    matriz_agosto[12, 33] = "==";
    matriz_agosto[12, 34] = "==";
    matriz_agosto[12, 35] = "==";
    matriz_agosto[12, 36] = "==";
    matriz_agosto[12, 37] = "==";
    matriz_agosto[12, 38] = "==";
    matriz_agosto[12, 39] = "==";
    matriz_agosto[13, 33] = "Lu";
    matriz_agosto[13, 34] = "Ma";
    matriz_agosto[13, 35] = "Mi";
    matriz_agosto[13, 36] = "Ju";
    matriz_agosto[13, 37] = "Vi";
    matriz_agosto[13, 38] = "Sa";
    matriz_agosto[13, 39] = "Do";
    matriz_agosto[14, 33] = "  ";
    matriz_agosto[14, 34] = "  ";
    matriz_agosto[14, 35] = "  ";
    matriz_agosto[14, 36] = " 1";
    matriz_agosto[14, 37] = " 2";
    matriz_agosto[14, 38] = " 3";
    matriz_agosto[14, 39] = " 4";
    matriz_agosto[15, 33] = " 5 ";
    matriz_agosto[15, 34] = "6";
    matriz_agosto[15, 35] = " 7";
    matriz_agosto[15, 36] = " 8";
    matriz_agosto[15, 37] = " 9";
    matriz_agosto[15, 38] = "10";
    matriz_agosto[15, 39] = "11";
    matriz_agosto[16, 33] = "12";
    matriz_agosto[16, 34] = "13";
    matriz_agosto[16, 35] = "14";
    matriz_agosto[16, 36] = "15";
    matriz_agosto[16, 37] = "16";
    matriz_agosto[16, 38] = "17";
    matriz_agosto[16, 39] = "18";
    matriz_agosto[17, 33] = "19";
    matriz_agosto[17, 34] = "20";
    matriz_agosto[17, 35] = "21";
    matriz_agosto[17, 36] = "22";
    matriz_agosto[17, 37] = "23";
    matriz_agosto[17, 38] = "24";
    matriz_agosto[17, 39] = "25";
    matriz_agosto[18, 33] = "26";
    matriz_agosto[18, 34] = "27";
    matriz_agosto[18, 35] = "27";
    matriz_agosto[18, 36] = "28";
    matriz_agosto[18, 37] = "29";
    matriz_agosto[18, 38] = "30";
    matriz_agosto[18, 39] = "31";

    // Matriz de Septiembre (9):
    string[,] matriz_septiembre = new string[30, 50];

    matriz_septiembre[20, 0] = "==";
    matriz_septiembre[20, 1] = "==";
    matriz_septiembre[20, 2] = "==";
    matriz_septiembre[20, 3] = "==";
    matriz_septiembre[20, 4] = "==";
    matriz_septiembre[20, 5] = "==";
    matriz_septiembre[20, 6] = "==";
    matriz_septiembre[21, 0] = "";
    matriz_septiembre[21, 1] = "S";
    matriz_septiembre[21, 2] = "E";
    matriz_septiembre[21, 3] = "P";
    matriz_septiembre[21, 4] = "T";
    matriz_septiembre[21, 5] = "I";
    matriz_septiembre[21, 6] = "E";
    matriz_septiembre[21, 7] = "M";
    matriz_septiembre[21, 8] = "B";
    matriz_septiembre[21, 9] = "R";
    matriz_septiembre[21, 10] = "E";
    matriz_septiembre[22, 0] = "==";
    matriz_septiembre[22, 1] = "==";
    matriz_septiembre[22, 2] = "==";
    matriz_septiembre[22, 3] = "==";
    matriz_septiembre[22, 4] = "==";
    matriz_septiembre[22, 5] = "==";
    matriz_septiembre[22, 6] = "==";
    matriz_septiembre[23, 0] = "Lu";
    matriz_septiembre[23, 1] = "Ma";
    matriz_septiembre[23, 2] = "Mi";
    matriz_septiembre[23, 3] = "Ju";
    matriz_septiembre[23, 4] = "Vi";
    matriz_septiembre[23, 5] = "Sa";
    matriz_septiembre[23, 6] = "Do";
    matriz_septiembre[24, 0] = "  ";
    matriz_septiembre[24, 1] = "  ";
    matriz_septiembre[24, 2] = "  ";
    matriz_septiembre[24, 3] = "  ";
    matriz_septiembre[24, 4] = "  ";
    matriz_septiembre[24, 5] = "  ";
    matriz_septiembre[24, 6] = " 1";
    matriz_septiembre[25, 0] = " 2";
    matriz_septiembre[25, 1] = " 3";
    matriz_septiembre[25, 2] = " 4";
    matriz_septiembre[25, 3] = " 5";
    matriz_septiembre[25, 4] = " 6";
    matriz_septiembre[25, 5] = " 7";
    matriz_septiembre[25, 6] = " 8";
    matriz_septiembre[26, 0] = " 9";
    matriz_septiembre[26, 1] = "10";
    matriz_septiembre[26, 2] = "11";
    matriz_septiembre[26, 3] = "12";
    matriz_septiembre[26, 4] = "13";
    matriz_septiembre[26, 5] = "14";
    matriz_septiembre[26, 6] = "15";
    matriz_septiembre[27, 0] = "16";
    matriz_septiembre[27, 1] = "17";
    matriz_septiembre[27, 2] = "18";
    matriz_septiembre[27, 3] = "19";
    matriz_septiembre[27, 4] = "20";
    matriz_septiembre[27, 5] = "21";
    matriz_septiembre[27, 6] = "22";
    matriz_septiembre[28, 0] = "23";
    matriz_septiembre[28, 1] = "24";
    matriz_septiembre[28, 2] = "25";
    matriz_septiembre[28, 3] = "26";
    matriz_septiembre[28, 4] = "27";
    matriz_septiembre[28, 5] = "28";
    matriz_septiembre[28, 6] = "29";
    matriz_septiembre[29, 0] = "30";
    matriz_septiembre[29, 1] = "  ";
    matriz_septiembre[29, 2] = "  ";
    matriz_septiembre[29, 3] = "  ";
    matriz_septiembre[29, 4] = "  ";
    matriz_septiembre[29, 5] = "  ";
    matriz_septiembre[29, 6] = "  \n";

    // Matriz de Octubre (10):
    string[,] matriz_octubre = new string[30, 50];

    matriz_octubre[20, 11] = "==";
    matriz_octubre[20, 12] = "==";
    matriz_octubre[20, 13] = "==";
    matriz_octubre[20, 14] = "==";
    matriz_octubre[20, 15] = "==";
    matriz_octubre[20, 16] = "==";
    matriz_octubre[20, 17] = "==";
    matriz_octubre[21, 11] = "|||";
    matriz_octubre[21, 12] = "O";
    matriz_octubre[21, 13] = "C";
    matriz_octubre[21, 14] = "T";
    matriz_octubre[21, 15] = "U";
    matriz_octubre[21, 16] = "B";
    matriz_octubre[21, 17] = "R";
    matriz_octubre[21, 18] = "E";
    matriz_octubre[21, 19] = "||";
    matriz_octubre[22, 11] = "==";
    matriz_octubre[22, 12] = "==";
    matriz_octubre[22, 13] = "==";
    matriz_octubre[22, 14] = "==";
    matriz_octubre[22, 15] = "==";
    matriz_octubre[22, 16] = "==";
    matriz_octubre[22, 17] = "==";
    matriz_octubre[23, 11] = "Lu";
    matriz_octubre[23, 12] = "Ma";
    matriz_octubre[23, 13] = "Mi";
    matriz_octubre[23, 14] = "Ju";
    matriz_octubre[23, 15] = "Vi";
    matriz_octubre[23, 16] = "Sa";
    matriz_octubre[23, 17] = "Do";
    matriz_octubre[24, 11] = "  ";
    matriz_octubre[24, 12] = " 1";
    matriz_octubre[24, 13] = " 2";
    matriz_octubre[24, 14] = " 3";
    matriz_octubre[24, 15] = " 4";
    matriz_octubre[24, 16] = " 5";
    matriz_octubre[24, 17] = " 6";
    matriz_octubre[25, 11] = " 7";
    matriz_octubre[25, 12] = " 8";
    matriz_octubre[25, 13] = " 9";
    matriz_octubre[25, 14] = "10";
    matriz_octubre[25, 15] = "11";
    matriz_octubre[25, 16] = "12";
    matriz_octubre[25, 17] = "13";
    matriz_octubre[26, 11] = "14";
    matriz_octubre[26, 12] = "15";
    matriz_octubre[26, 13] = "16";
    matriz_octubre[26, 14] = "17";
    matriz_octubre[26, 15] = "18";
    matriz_octubre[26, 16] = "19";
    matriz_octubre[26, 17] = "20";
    matriz_octubre[27, 11] = "21";
    matriz_octubre[27, 12] = "22";
    matriz_octubre[27, 13] = "23";
    matriz_octubre[27, 14] = "24";
    matriz_octubre[27, 15] = "25";
    matriz_octubre[27, 16] = "26";
    matriz_octubre[27, 17] = "27";
    matriz_octubre[28, 11] = "28";
    matriz_octubre[28, 12] = "29";
    matriz_octubre[28, 13] = "30";
    matriz_octubre[28, 14] = "31";
    matriz_octubre[28, 15] = "  ";
    matriz_octubre[28, 16] = "  ";
    matriz_octubre[28, 17] = "  ";
    matriz_octubre[29, 11] = "  ";
    matriz_octubre[29, 12] = "  ";
    matriz_octubre[29, 13] = "  ";
    matriz_octubre[29, 14] = "  ";
    matriz_octubre[29, 15] = "  ";
    matriz_octubre[29, 16] = "  ";
    matriz_octubre[29, 17] = "  ";

    // Matriz de Noviembre (11):
    string[,] matriz_noviembre = new string[40, 50];

    matriz_noviembre[20, 22] = "==";
    matriz_noviembre[20, 23] = "==";
    matriz_noviembre[20, 24] = "==";
    matriz_noviembre[20, 25] = "==";
    matriz_noviembre[20, 26] = "==";
    matriz_noviembre[20, 27] = "==";
    matriz_noviembre[20, 28] = "==";
    matriz_noviembre[21, 22] = "|";
    matriz_noviembre[21, 23] = "N";
    matriz_noviembre[21, 24] = "O";
    matriz_noviembre[21, 25] = "V";
    matriz_noviembre[21, 26] = "I";
    matriz_noviembre[21, 27] = "E";
    matriz_noviembre[21, 28] = "M";
    matriz_noviembre[21, 29] = "B";
    matriz_noviembre[21, 30] = "R";
    matriz_noviembre[21, 31] = "E";
    matriz_noviembre[21, 32] = "|";
    matriz_noviembre[22, 22] = "==";
    matriz_noviembre[22, 23] = "==";
    matriz_noviembre[22, 24] = "==";
    matriz_noviembre[22, 25] = "==";
    matriz_noviembre[22, 26] = "==";
    matriz_noviembre[22, 27] = "==";
    matriz_noviembre[22, 28] = "==";
    matriz_noviembre[23, 22] = "Lu";
    matriz_noviembre[23, 23] = "Ma";
    matriz_noviembre[23, 24] = "Mi";
    matriz_noviembre[23, 25] = "Ju";
    matriz_noviembre[23, 26] = "Vi";
    matriz_noviembre[23, 27] = "Sa";
    matriz_noviembre[23, 28] = "Do";
    matriz_noviembre[24, 22] = "  ";
    matriz_noviembre[24, 23] = "  ";
    matriz_noviembre[24, 24] = "  ";
    matriz_noviembre[24, 25] = "  ";
    matriz_noviembre[24, 26] = " 1";
    matriz_noviembre[24, 27] = " 2";
    matriz_noviembre[24, 28] = " 3";
    matriz_noviembre[25, 22] = " 4";
    matriz_noviembre[25, 23] = " 5";
    matriz_noviembre[25, 24] = " 6";
    matriz_noviembre[25, 25] = " 7";
    matriz_noviembre[25, 26] = " 8";
    matriz_noviembre[25, 27] = " 9";
    matriz_noviembre[25, 28] = "10";
    matriz_noviembre[26, 22] = "11";
    matriz_noviembre[26, 23] = "12";
    matriz_noviembre[26, 24] = "13";
    matriz_noviembre[26, 25] = "14";
    matriz_noviembre[26, 26] = "15";
    matriz_noviembre[26, 27] = "16";
    matriz_noviembre[26, 28] = "17";
    matriz_noviembre[27, 22] = "18";
    matriz_noviembre[27, 23] = "19";
    matriz_noviembre[27, 24] = "20";
    matriz_noviembre[27, 25] = "21";
    matriz_noviembre[27, 26] = "22";
    matriz_noviembre[27, 27] = "23";
    matriz_noviembre[27, 28] = "24";
    matriz_noviembre[28, 22] = "25";
    matriz_noviembre[28, 23] = "26";
    matriz_noviembre[28, 24] = "27";
    matriz_noviembre[28, 25] = "28";
    matriz_noviembre[28, 26] = "29";
    matriz_noviembre[28, 27] = "30";
    matriz_noviembre[28, 28] = "  ";
    matriz_noviembre[29, 22] = "  ";
    matriz_noviembre[29, 23] = "  ";
    matriz_noviembre[29, 24] = "  ";
    matriz_noviembre[29, 25] = "  ";
    matriz_noviembre[29, 26] = "  ";
    matriz_noviembre[29, 27] = "  ";
    matriz_noviembre[29, 28] = "  ";

    // Matriz de Diciembre (12):
    string[,] matriz_diciembre = new string[40, 60];

    matriz_diciembre[20, 33] = "==";
    matriz_diciembre[20, 34] = "==";
    matriz_diciembre[20, 35] = "==";
    matriz_diciembre[20, 36] = "==";
    matriz_diciembre[20, 37] = "==";
    matriz_diciembre[20, 38] = "==";
    matriz_diciembre[20, 39] = "==";
    matriz_diciembre[21, 32] = "|";
    matriz_diciembre[21, 33] = "D";
    matriz_diciembre[21, 34] = "I";
    matriz_diciembre[21, 35] = "C";
    matriz_diciembre[21, 36] = "I";
    matriz_diciembre[21, 37] = "E";
    matriz_diciembre[21, 38] = "M";
    matriz_diciembre[21, 39] = "B";
    matriz_diciembre[21, 40] = "R";
    matriz_diciembre[21, 41] = "E";
    matriz_diciembre[21, 42] = "|";
    matriz_diciembre[22, 33] = "==";
    matriz_diciembre[22, 34] = "==";
    matriz_diciembre[22, 35] = "==";
    matriz_diciembre[22, 36] = "==";
    matriz_diciembre[22, 37] = "==";
    matriz_diciembre[22, 38] = "==";
    matriz_diciembre[22, 39] = "==";
    matriz_diciembre[23, 33] = "Lu";
    matriz_diciembre[23, 34] = "Ma";
    matriz_diciembre[23, 35] = "Mi";
    matriz_diciembre[23, 36] = "Ju";
    matriz_diciembre[23, 37] = "Vi";
    matriz_diciembre[23, 38] = "Sa";
    matriz_diciembre[23, 39] = "Do";
    matriz_diciembre[24, 33] = "  ";
    matriz_diciembre[24, 34] = "  ";
    matriz_diciembre[24, 35] = "  ";
    matriz_diciembre[24, 36] = "  ";
    matriz_diciembre[24, 37] = "  ";
    matriz_diciembre[24, 38] = "  ";
    matriz_diciembre[24, 39] = " 1";
    matriz_diciembre[25, 33] = " 2";
    matriz_diciembre[25, 34] = " 3";
    matriz_diciembre[25, 35] = " 4";
    matriz_diciembre[25, 36] = " 5";
    matriz_diciembre[25, 37] = " 6";
    matriz_diciembre[25, 38] = " 7";
    matriz_diciembre[25, 39] = " 8";
    matriz_diciembre[26, 33] = " 9";
    matriz_diciembre[26, 34] = "10";
    matriz_diciembre[26, 35] = "11";
    matriz_diciembre[26, 36] = "12";
    matriz_diciembre[26, 37] = "13";
    matriz_diciembre[26, 38] = "14";
    matriz_diciembre[26, 39] = "15";
    matriz_diciembre[27, 33] = "16";
    matriz_diciembre[27, 34] = "17";
    matriz_diciembre[27, 35] = "18";
    matriz_diciembre[27, 36] = "19";
    matriz_diciembre[27, 37] = "20";
    matriz_diciembre[27, 38] = "21";
    matriz_diciembre[27, 39] = "22";
    matriz_diciembre[28, 33] = "23";
    matriz_diciembre[28, 34] = "24";
    matriz_diciembre[28, 35] = "25";
    matriz_diciembre[28, 36] = "26";
    matriz_diciembre[28, 37] = "27";
    matriz_diciembre[28, 38] = "28";
    matriz_diciembre[28, 39] = "29";
    matriz_diciembre[29, 33] = "30";
    matriz_diciembre[29, 34] = "31";
    matriz_diciembre[29, 35] = "  ";
    matriz_diciembre[29, 36] = "  ";
    matriz_diciembre[29, 37] = "  ";
    matriz_diciembre[29, 38] = "  ";
    matriz_diciembre[29, 39] = "  ";

    // Creación de Matrices [Filas, Columnas]:
    string[,] matriz = new string[30, 100];

    // Creación de Fila 0 (=)
    matriz[0, 0] = "==";
    matriz[0, 1] = "==";
    matriz[0, 2] = "==";
    matriz[0, 3] = "==";
    matriz[0, 4] = "==";
    matriz[0, 5] = "==";
    matriz[0, 6] = "==";
    matriz[0, 7] = "  ";
    matriz[0, 8] = "  ";
    matriz[0, 9] = "  ";
    matriz[0, 10] = "  ";

    matriz[0, 11] = "==";
    matriz[0, 12] = "==";
    matriz[0, 13] = "==";
    matriz[0, 14] = "==";
    matriz[0, 15] = "==";
    matriz[0, 16] = "==";
    matriz[0, 17] = "==";
    matriz[0, 18] = "  ";
    matriz[0, 19] = "  ";
    matriz[0, 20] = "  ";
    matriz[0, 21] = "  ";

    matriz[0, 22] = "==";
    matriz[0, 23] = "==";
    matriz[0, 24] = "==";
    matriz[0, 25] = "==";
    matriz[0, 26] = "==";
    matriz[0, 27] = "==";
    matriz[0, 28] = "==";
    matriz[0, 29] = "  ";
    matriz[0, 30] = "  ";
    matriz[0, 31] = "  ";
    matriz[0, 32] = "  ";

    matriz[0, 33] = "==";
    matriz[0, 34] = "==";
    matriz[0, 35] = "==";
    matriz[0, 36] = "==";
    matriz[0, 37] = "==";
    matriz[0, 38] = "==";
    matriz[0, 39] = "==";

    // Creación de Fila 1 (== ENERO ==)
    matriz[1, 0] = "||";
    matriz[1, 1] = "||";
    matriz[1, 2] = "E";
    matriz[1, 3] = "N";
    matriz[1, 4] = "E";
    matriz[1, 5] = "R";
    matriz[1, 6] = "O";
    matriz[1, 7] = "||";
    matriz[1, 8] = "||";
    matriz[1, 9] = "  ";
    matriz[1, 10] = "  ";
    matriz[1, 11] = "  ";
    matriz[1, 12] = "  ";

    // Creación de Fila 1 (== FEBRERO ==)
    matriz[1, 13] = "||";
    matriz[1, 14] = "F";
    matriz[1, 15] = "E";
    matriz[1, 16] = "B";
    matriz[1, 17] = "R";
    matriz[1, 18] = "E";
    matriz[1, 19] = "R";
    matriz[1, 20] = "O";
    matriz[1, 21] = "||";
    matriz[1, 22] = "  ";
    matriz[1, 23] = "  ";
    matriz[1, 24] = "  ";
    matriz[1, 25] = "  ";

    // Creación de Fila 1 (== MARZO ==)
    matriz[1, 26] = "||";
    matriz[1, 27] = "||";
    matriz[1, 28] = "M";
    matriz[1, 29] = "A";
    matriz[1, 30] = "R";
    matriz[1, 31] = "Z";
    matriz[1, 32] = "O";
    matriz[1, 33] = "||";
    matriz[1, 34] = "||";
    matriz[1, 35] = "  ";
    matriz[1, 36] = "  ";
    matriz[1, 37] = "  ";
    matriz[1, 38] = "  ";

    // Creación de Fila 1 (== ABRIL ==)
    matriz[1, 39] = "||";
    matriz[1, 40] = "||";
    matriz[1, 41] = "A";
    matriz[1, 42] = "B";
    matriz[1, 43] = "R";
    matriz[1, 44] = "I";
    matriz[1, 45] = "L";
    matriz[1, 46] = "||";

    // Creación de Fila 2 (=)
    matriz[2, 1] = "==";
    matriz[2, 2] = "==";
    matriz[2, 3] = "==";
    matriz[2, 4] = "==";
    matriz[2, 5] = "==";
    matriz[2, 6] = "==";
    matriz[2, 7] = "==";
    matriz[2, 8] = "  ";
    matriz[2, 9] = "  ";
    matriz[2, 10] = "  ";
    matriz[2, 11] = "  ";

    matriz[2, 12] = "==";
    matriz[2, 13] = "==";
    matriz[2, 14] = "==";
    matriz[2, 15] = "==";
    matriz[2, 16] = "==";
    matriz[2, 17] = "==";
    matriz[2, 18] = "==";
    matriz[2, 19] = "  ";
    matriz[2, 20] = "  ";
    matriz[2, 21] = "  ";
    matriz[2, 22] = "  ";

    matriz[2, 23] = "==";
    matriz[2, 24] = "==";
    matriz[2, 25] = "==";
    matriz[2, 26] = "==";
    matriz[2, 27] = "==";
    matriz[2, 28] = "==";
    matriz[2, 29] = "==";
    matriz[2, 30] = "  ";
    matriz[2, 31] = "  ";
    matriz[2, 32] = "  ";
    matriz[2, 33] = "  ";

    matriz[2, 34] = "==";
    matriz[2, 35] = "==";
    matriz[2, 36] = "==";
    matriz[2, 37] = "==";
    matriz[2, 38] = "==";
    matriz[2, 39] = "==";
    matriz[2, 40] = "==";

    // Creación de Fila 3 (Días de la Semana Enero)
    matriz[3, 0] = "Lu";
    matriz[3, 1] = "Ma";
    matriz[3, 2] = "Mi";
    matriz[3, 3] = "Ju";
    matriz[3, 4] = "Vi";
    matriz[3, 5] = "Sa";
    matriz[3, 6] = "Do";
    matriz[3, 7] = "  ";
    matriz[3, 8] = "  ";
    matriz[3, 9] = "  ";
    matriz[3, 10] = "  ";

    // Creación de Fila 3 (Días de la Semana Febrero)
    matriz[3, 11] = "Lu";
    matriz[3, 12] = "Ma";
    matriz[3, 13] = "Mi";
    matriz[3, 14] = "Ju";
    matriz[3, 15] = "Vi";
    matriz[3, 16] = "Sa";
    matriz[3, 17] = "Do";
    matriz[3, 18] = "  ";
    matriz[3, 19] = "  ";
    matriz[3, 20] = "  ";
    matriz[3, 21] = "  ";

    // Creación de Fila 3 (Días de la Semana Marzo)
    matriz[3, 22] = "Lu";
    matriz[3, 23] = "Ma";
    matriz[3, 24] = "Mi";
    matriz[3, 25] = "Ju";
    matriz[3, 26] = "Vi";
    matriz[3, 27] = "Sa";
    matriz[3, 28] = "Do";
    matriz[3, 29] = "  ";
    matriz[3, 30] = "  ";
    matriz[3, 31] = "  ";
    matriz[3, 32] = "  ";

    // Creación de Fila 3 (Días de la Semana Abril)
    matriz[3, 33] = "Lu";
    matriz[3, 34] = "Ma";
    matriz[3, 35] = "Mi";
    matriz[3, 36] = "Ju";
    matriz[3, 37] = "Vi";
    matriz[3, 38] = "Sa";
    matriz[3, 39] = "Do";

    // Días de Enero:
    matriz[4, 1] = "1 ";
    matriz[4, 2] = "2 ";
    matriz[4, 3] = "3 ";
    matriz[4, 4] = "4 ";
    matriz[4, 5] = "5 ";
    matriz[4, 6] = "6 ";
    matriz[4, 7] = "7 ";
    matriz[4, 8] = "  ";
    matriz[4, 9] = "  ";
    matriz[4, 10] = "  ";
    matriz[4, 11] = "  ";

    // Días de Febrero:
    matriz[4, 12] = " ";
    matriz[4, 13] = " ";
    matriz[4, 14] = " ";
    matriz[4, 15] = " ";
    matriz[4, 16] = "1 ";
    matriz[4, 17] = "2 ";
    matriz[4, 18] = "3 ";
    matriz[4, 19] = "4 ";
    matriz[4, 20] = "  ";
    matriz[4, 21] = "  ";
    matriz[4, 22] = "  ";
    matriz[4, 23] = "  ";

    // Días de Marzo:
    matriz[4, 24] = " ";
    matriz[4, 25] = " ";
    matriz[4, 26] = " ";
    matriz[4, 27] = " ";
    matriz[4, 28] = " ";
    matriz[4, 29] = " ";
    matriz[4, 30] = "1 ";
    matriz[4, 31] = "2 ";
    matriz[4, 32] = "3 ";
    matriz[4, 33] = "  ";
    matriz[4, 34] = "  ";
    matriz[4, 35] = "  ";
    matriz[4, 36] = "  ";

    // Días de Abril:
    matriz[4, 37] = " 1";
    matriz[4, 38] = " 2";
    matriz[4, 39] = " 3";
    matriz[4, 40] = " 4";
    matriz[4, 41] = " 5";
    matriz[4, 42] = " 6";
    matriz[4, 43] = " 7";

    // Días de Enero:
    matriz[5, 1] = "8";
    matriz[5, 2] = " 9";
    matriz[5, 3] = "10";
    matriz[5, 4] = "11";
    matriz[5, 5] = "12";
    matriz[5, 6] = "13";
    matriz[5, 7] = "14";
    matriz[5, 8] = "  ";
    matriz[5, 9] = "  ";
    matriz[5, 10] = "  ";
    matriz[5, 11] = "  ";

    // Días de Febrero:
    matriz[5, 12] = "5";
    matriz[5, 13] = " 6";
    matriz[5, 14] = " 7";
    matriz[5, 15] = " 8";
    matriz[5, 16] = " 9";
    matriz[5, 17] = " 10";
    matriz[5, 18] = "11";
    matriz[5, 19] = "  ";
    matriz[5, 20] = "  ";
    matriz[5, 21] = "  ";
    matriz[5, 22] = "  ";

    // Días de Marzo:
    matriz[5, 23] = "4";
    matriz[5, 24] = " 5";
    matriz[5, 25] = " 6";
    matriz[5, 26] = " 7";
    matriz[5, 27] = " 8";
    matriz[5, 28] = " 9";
    matriz[5, 29] = " 10";
    matriz[5, 30] = "  ";
    matriz[5, 31] = "  ";
    matriz[5, 32] = "  ";
    matriz[5, 33] = "  ";

    // Días de Abril:
    matriz[5, 34] = " 8";
    matriz[5, 35] = " 9";
    matriz[5, 36] = "10";
    matriz[5, 37] = "11";
    matriz[5, 38] = "12";
    matriz[5, 39] = "13";
    matriz[5, 40] = "14";

    // Días de Enero:
    matriz[6, 0] = "15";
    matriz[6, 1] = "16";
    matriz[6, 2] = "17";
    matriz[6, 3] = "18";
    matriz[6, 4] = "19";
    matriz[6, 5] = "20";
    matriz[6, 6] = "21";
    matriz[6, 7] = "  ";
    matriz[6, 8] = "  ";
    matriz[6, 9] = "  ";
    matriz[6, 10] = "  ";

    // Días de Febrero:
    matriz[6, 11] = "12";
    matriz[6, 12] = "13";
    matriz[6, 13] = "14";
    matriz[6, 14] = "15";
    matriz[6, 15] = "16";
    matriz[6, 16] = "17";
    matriz[6, 17] = "18";
    matriz[6, 18] = "  ";
    matriz[6, 19] = "  ";
    matriz[6, 20] = "  ";
    matriz[6, 21] = "  ";

    // Días de Marzo:
    matriz[6, 22] = "11";
    matriz[6, 23] = "12";
    matriz[6, 24] = "13";
    matriz[6, 25] = "14";
    matriz[6, 26] = "15";
    matriz[6, 27] = "16";
    matriz[6, 28] = "17";
    matriz[6, 29] = "  ";
    matriz[6, 30] = "  ";
    matriz[6, 31] = "  ";
    matriz[6, 32] = "  ";

    // Días de Abril:
    matriz[6, 33] = "15";
    matriz[6, 34] = "16";
    matriz[6, 35] = "17";
    matriz[6, 36] = "18";
    matriz[6, 37] = "19";
    matriz[6, 38] = "20";
    matriz[6, 39] = "21";

    // Días de Enero:
    matriz[7, 0] = "22";
    matriz[7, 1] = "23";
    matriz[7, 2] = "24";
    matriz[7, 3] = "25";
    matriz[7, 4] = "26";
    matriz[7, 5] = "27";
    matriz[7, 6] = "28";
    matriz[7, 7] = "  ";
    matriz[7, 8] = "  ";
    matriz[7, 9] = "  ";
    matriz[7, 10] = "  ";

    // Días de Febrero:
    matriz[7, 11] = "19";
    matriz[7, 12] = "20";
    matriz[7, 13] = "21";
    matriz[7, 14] = "22";
    matriz[7, 15] = "23";
    matriz[7, 16] = "24";
    matriz[7, 17] = "25";
    matriz[7, 18] = "  ";
    matriz[7, 19] = "  ";
    matriz[7, 20] = "  ";
    matriz[7, 21] = "  ";

    // Días de Marzo:
    matriz[7, 22] = "18";
    matriz[7, 23] = "19";
    matriz[7, 24] = "20";
    matriz[7, 25] = "21";
    matriz[7, 26] = "22";
    matriz[7, 27] = "23";
    matriz[7, 28] = "24";
    matriz[7, 29] = "  ";
    matriz[7, 30] = "  ";
    matriz[7, 31] = "  ";
    matriz[7, 32] = "  ";

    // Días de Abril:
    matriz[7, 33] = "22";
    matriz[7, 34] = "23";
    matriz[7, 35] = "24";
    matriz[7, 36] = "25";
    matriz[7, 37] = "26";
    matriz[7, 38] = "27";
    matriz[7, 39] = "28";

    // Días de Enero:
    matriz[8, 0] = "29";
    matriz[8, 1] = "30";
    matriz[8, 2] = "31";
    matriz[8, 3] = "  ";
    matriz[8, 4] = "  ";
    matriz[8, 5] = "  ";
    matriz[8, 6] = "  ";
    matriz[8, 7] = "  ";
    matriz[8, 8] = "  ";
    matriz[8, 9] = "  ";
    matriz[8, 10] = "  ";

    // Días de Febrero:
    matriz[8, 11] = "26";
    matriz[8, 12] = "27";
    matriz[8, 13] = "28";
    matriz[8, 14] = "29";
    matriz[8, 15] = "  ";
    matriz[8, 16] = " ";
    matriz[8, 17] = " ";
    matriz[8, 18] = " ";
    matriz[8, 19] = "  ";
    matriz[8, 20] = "  ";
    matriz[8, 21] = "  ";
    matriz[8, 22] = "  ";

    //* Días de Marzo:
    matriz[8, 23] = "25";
    matriz[8, 24] = "26";
    matriz[8, 25] = "27";
    matriz[8, 26] = "28";
    matriz[8, 27] = "29";
    matriz[8, 28] = "30";
    matriz[8, 29] = "31";
    matriz[8, 30] = "  ";
    matriz[8, 31] = "  ";
    matriz[8, 32] = "  ";
    matriz[8, 33] = "  ";

    // Días de Abril:
    matriz[8, 34] = "29";
    matriz[8, 35] = "30";
    matriz[8, 36] = " ";
    matriz[8, 37] = " ";
    matriz[8, 38] = " ";
    matriz[8, 39] = " ";
    matriz[8, 40] = " ";

    // Espacios entre primeros 4 meses:
    matriz[9, 0] = "  ";
    matriz[9, 1] = "  ";
    matriz[9, 2] = "  ";
    matriz[9, 3] = "  ";
    matriz[9, 4] = "  ";
    matriz[9, 5] = "  ";
    matriz[9, 6] = "  ";
    matriz[9, 7] = "  ";
    matriz[9, 8] = "  ";
    matriz[9, 9] = "  ";
    matriz[9, 10] = "  ";

    // Espacios entre primeros 4 meses:
    matriz[9, 11] = "  ";
    matriz[9, 12] = "  ";
    matriz[9, 13] = "  ";
    matriz[9, 14] = "  ";
    matriz[9, 15] = "  ";
    matriz[9, 16] = "  ";
    matriz[9, 17] = "  ";
    matriz[9, 18] = "  ";
    matriz[9, 19] = "  ";
    matriz[9, 20] = "  ";
    matriz[9, 21] = "  ";

    // Espacios entre primeros 4 meses:
    matriz[9, 22] = "  ";
    matriz[9, 23] = "  ";
    matriz[9, 24] = "  ";
    matriz[9, 25] = "  ";
    matriz[9, 26] = "  ";
    matriz[9, 27] = "  ";
    matriz[9, 28] = "  ";
    matriz[9, 29] = "  ";
    matriz[9, 30] = "  ";
    matriz[9, 31] = "  ";
    matriz[9, 32] = "  ";

    // Espacios entre primeros 4 meses:
    matriz[9, 33] = "  ";
    matriz[9, 34] = "  ";
    matriz[9, 35] = "  ";
    matriz[9, 36] = "  ";
    matriz[9, 37] = "  ";
    matriz[9, 38] = "  ";
    matriz[9, 39] = "  ";

    // Diseño Mayo:
    matriz[10, 0] = "==";
    matriz[10, 1] = "==";
    matriz[10, 2] = "==";
    matriz[10, 3] = "==";
    matriz[10, 4] = "==";
    matriz[10, 5] = "==";
    matriz[10, 6] = "==";
    matriz[10, 7] = "  ";
    matriz[10, 8] = "  ";
    matriz[10, 9] = "  ";
    matriz[10, 10] = "  ";

    // Diseño Junio:
    matriz[10, 11] = "==";
    matriz[10, 12] = "==";
    matriz[10, 13] = "==";
    matriz[10, 14] = "==";
    matriz[10, 15] = "==";
    matriz[10, 16] = "==";
    matriz[10, 17] = "==";
    matriz[10, 18] = "  ";
    matriz[10, 19] = "  ";
    matriz[10, 20] = "  ";
    matriz[10, 21] = "  ";

    // Diseño Julio:
    matriz[10, 22] = "==";
    matriz[10, 23] = "==";
    matriz[10, 24] = "==";
    matriz[10, 25] = "==";
    matriz[10, 26] = "==";
    matriz[10, 27] = "==";
    matriz[10, 28] = "==";
    matriz[10, 29] = "  ";
    matriz[10, 30] = "  ";
    matriz[10, 31] = "  ";
    matriz[10, 32] = "  ";

    // Diseño Agosto:
    matriz[10, 33] = "==";
    matriz[10, 34] = "==";
    matriz[10, 35] = "==";
    matriz[10, 36] = "==";
    matriz[10, 37] = "==";
    matriz[10, 38] = "==";
    matriz[10, 39] = "==";

    // Diseño Mayo:
    matriz[11, 0] = "||";
    matriz[11, 1] = "|| ";
    matriz[11, 2] = "M";
    matriz[11, 3] = "A";
    matriz[11, 4] = "Y";
    matriz[11, 5] = "O";
    matriz[11, 6] = "||";
    matriz[11, 7] = "||";
    matriz[11, 8] = "  ";
    matriz[11, 9] = "  ";
    matriz[11, 10] = "  ";
    matriz[11, 11] = "  ";

    // Diseño Junio:
    matriz[11, 12] = "||";
    matriz[11, 13] = "||";
    matriz[11, 14] = "J";
    matriz[11, 15] = "U";
    matriz[11, 16] = "N";
    matriz[11, 17] = "I";
    matriz[11, 18] = "O";
    matriz[11, 19] = "||";
    matriz[11, 20] = "|";
    matriz[11, 21] = "  ";
    matriz[11, 22] = "  ";
    matriz[11, 23] = "  ";
    matriz[11, 24] = "  ";

    // Diseño Julio:
    matriz[11, 25] = "||";
    matriz[11, 26] = "||";
    matriz[11, 27] = "J";
    matriz[11, 28] = "U";
    matriz[11, 29] = "L";
    matriz[11, 30] = "I";
    matriz[11, 31] = "O";
    matriz[11, 32] = "||";
    matriz[11, 33] = "|";
    matriz[11, 34] = "  ";
    matriz[11, 35] = "  ";
    matriz[11, 36] = "  ";
    matriz[11, 37] = "  ";

    // Diseño Agosto:
    matriz[11, 38] = "|||";
    matriz[11, 39] = " A";
    matriz[11, 40] = "G";
    matriz[11, 41] = "O";
    matriz[11, 42] = "S";
    matriz[11, 43] = "T";
    matriz[11, 44] = "O";
    matriz[11, 45] = " |||";
    matriz[11, 46] = " ";

    // Diseño Mayo:
    matriz[12, 0] = "==";
    matriz[12, 1] = "==";
    matriz[12, 2] = "==";
    matriz[12, 3] = "==";
    matriz[12, 4] = "==";
    matriz[12, 5] = "==";
    matriz[12, 6] = "==";
    matriz[12, 7] = "  ";
    matriz[12, 8] = "  ";
    matriz[12, 9] = "  ";
    matriz[12, 10] = "  ";

    // Diseño Junio:
    matriz[12, 11] = "==";
    matriz[12, 12] = "==";
    matriz[12, 13] = "==";
    matriz[12, 14] = "==";
    matriz[12, 15] = "==";
    matriz[12, 16] = "==";
    matriz[12, 17] = "==";
    matriz[12, 18] = "  ";
    matriz[12, 19] = "  ";
    matriz[12, 20] = "  ";
    matriz[12, 21] = "  ";

    // Diseño Julio:
    matriz[12, 22] = "==";
    matriz[12, 23] = "==";
    matriz[12, 24] = "==";
    matriz[12, 25] = "==";
    matriz[12, 26] = "==";
    matriz[12, 27] = "==";
    matriz[12, 28] = "==";
    matriz[12, 29] = "  ";
    matriz[12, 30] = "  ";
    matriz[12, 31] = "  ";
    matriz[12, 32] = "  ";

    // Diseño Agosto:
    matriz[12, 33] = "==";
    matriz[12, 34] = "==";
    matriz[12, 35] = "==";
    matriz[12, 36] = "==";
    matriz[12, 37] = "==";
    matriz[12, 38] = "==";
    matriz[12, 39] = "==";

    // Días de Mayo:
    matriz[13, 0] = "Lu";
    matriz[13, 1] = "Ma";
    matriz[13, 2] = "Mi";
    matriz[13, 3] = "Ju";
    matriz[13, 4] = "Vi";
    matriz[13, 5] = "Sa";
    matriz[13, 6] = "Do";
    matriz[13, 7] = "  ";
    matriz[13, 8] = "  ";
    matriz[13, 9] = "  ";
    matriz[13, 10] = "  ";

    // Días de Junio:
    matriz[13, 11] = "Lu";
    matriz[13, 12] = "Ma";
    matriz[13, 13] = "Mi";
    matriz[13, 14] = "Ju";
    matriz[13, 15] = "Vi";
    matriz[13, 16] = "Sa";
    matriz[13, 17] = "Do";
    matriz[13, 18] = "  ";
    matriz[13, 19] = "  ";
    matriz[13, 20] = "  ";
    matriz[13, 21] = "  ";

    // Días de Julio:
    matriz[13, 22] = "Lu";
    matriz[13, 23] = "Ma";
    matriz[13, 24] = "Mi";
    matriz[13, 25] = "Ju";
    matriz[13, 26] = "Vi";
    matriz[13, 27] = "Sa";
    matriz[13, 28] = "Do";
    matriz[13, 29] = "  ";
    matriz[13, 30] = "  ";
    matriz[13, 31] = "  ";
    matriz[13, 32] = "  ";

    // Días de Agosto:
    matriz[13, 33] = "Lu";
    matriz[13, 34] = "Ma";
    matriz[13, 35] = "Mi";
    matriz[13, 36] = "Ju";
    matriz[13, 37] = "Vi";
    matriz[13, 38] = "Sa";
    matriz[13, 39] = "Do";

    // Días de Mayo:
    matriz[14, 0] = "  ";
    matriz[14, 1] = "  ";
    matriz[14, 2] = " 1";
    matriz[14, 3] = " 2";
    matriz[14, 4] = " 3";
    matriz[14, 5] = " 4";
    matriz[14, 6] = " 5";
    matriz[14, 7] = "  ";
    matriz[14, 8] = "  ";
    matriz[14, 9] = "  ";
    matriz[14, 10] = "  ";

    // Días de Junio:
    matriz[14, 11] = "  ";
    matriz[14, 12] = "  ";
    matriz[14, 13] = "  ";
    matriz[14, 14] = "  ";
    matriz[14, 15] = "  ";
    matriz[14, 16] = " 1";
    matriz[14, 17] = " 2";
    matriz[14, 18] = "  ";
    matriz[14, 19] = "  ";
    matriz[14, 20] = "  ";
    matriz[14, 21] = "  ";

    // Días de Julio:
    matriz[14, 22] = " 1";
    matriz[14, 23] = " 2";
    matriz[14, 24] = " 3";
    matriz[14, 25] = " 4";
    matriz[14, 26] = " 5";
    matriz[14, 27] = " 6";
    matriz[14, 28] = " 7";
    matriz[14, 29] = "  ";
    matriz[14, 30] = "  ";
    matriz[14, 31] = "  ";
    matriz[14, 32] = "  ";

    // Días de Agosto:
    matriz[14, 33] = "  ";
    matriz[14, 34] = "  ";
    matriz[14, 35] = "  ";
    matriz[14, 36] = " 1";
    matriz[14, 37] = " 2";
    matriz[14, 38] = " 3";
    matriz[14, 39] = " 4";

    // Días de Mayo:
    matriz[15, 0] = " 6 ";
    matriz[15, 1] = "7 ";
    matriz[15, 2] = "8 ";
    matriz[15, 3] = "9";
    matriz[15, 4] = "10";
    matriz[15, 5] = "11";
    matriz[15, 6] = "12";
    matriz[15, 7] = "  ";
    matriz[15, 8] = "  ";
    matriz[15, 9] = "  ";
    matriz[15, 10] = "  ";

    // Días de Junio:
    matriz[15, 11] = " 3 ";
    matriz[15, 12] = "4 ";
    matriz[15, 13] = "5 ";
    matriz[15, 14] = "6 ";
    matriz[15, 15] = "7 ";
    matriz[15, 16] = "8 ";
    matriz[15, 17] = "9 ";
    matriz[15, 18] = "  ";
    matriz[15, 19] = "  ";
    matriz[15, 20] = "  ";
    matriz[15, 21] = "  ";

    // Días de Julio:
    matriz[15, 22] = "8 ";
    matriz[15, 23] = "9";
    matriz[15, 24] = "10";
    matriz[15, 25] = "11";
    matriz[15, 26] = "12";
    matriz[15, 27] = "13";
    matriz[15, 28] = "14";
    matriz[15, 29] = "  ";
    matriz[15, 30] = "  ";
    matriz[15, 31] = "  ";
    matriz[15, 32] = "  ";

    // Días de Agosto:
    matriz[15, 33] = " 5 ";
    matriz[15, 34] = "6";
    matriz[15, 35] = " 7";
    matriz[15, 36] = " 8";
    matriz[15, 37] = " 9";
    matriz[15, 38] = "10";
    matriz[15, 39] = "11";

    // Días de Mayo:
    matriz[16, 0] = "13";
    matriz[16, 1] = "14";
    matriz[16, 2] = "15";
    matriz[16, 3] = "16";
    matriz[16, 4] = "17";
    matriz[16, 5] = "18";
    matriz[16, 6] = "19";
    matriz[16, 7] = "  ";
    matriz[16, 8] = "  ";
    matriz[16, 9] = "  ";
    matriz[16, 10] = "  ";

    // Días de Junio:
    matriz[16, 11] = "10";
    matriz[16, 12] = "11";
    matriz[16, 13] = "12";
    matriz[16, 14] = "13";
    matriz[16, 15] = "14";
    matriz[16, 16] = "15";
    matriz[16, 17] = "16";
    matriz[16, 18] = "  ";
    matriz[16, 19] = "  ";
    matriz[16, 20] = "  ";
    matriz[16, 21] = "  ";

    // Días de Julio:
    matriz[16, 22] = "15";
    matriz[16, 23] = "16";
    matriz[16, 24] = "17";
    matriz[16, 25] = "18";
    matriz[16, 26] = "19";
    matriz[16, 27] = "20";
    matriz[16, 28] = "21";
    matriz[16, 29] = "  ";
    matriz[16, 30] = "  ";
    matriz[16, 31] = "  ";
    matriz[16, 32] = "  ";

    // Días de Agosto:
    matriz[16, 33] = "12";
    matriz[16, 34] = "13";
    matriz[16, 35] = "14";
    matriz[16, 36] = "15";
    matriz[16, 37] = "16";
    matriz[16, 38] = "17";
    matriz[16, 39] = "18";

    // Días de Mayo:
    matriz[17, 0] = "20";
    matriz[17, 1] = "21";
    matriz[17, 2] = "22";
    matriz[17, 3] = "23";
    matriz[17, 4] = "24";
    matriz[17, 5] = "25";
    matriz[17, 6] = "26";
    matriz[17, 7] = "  ";
    matriz[17, 8] = "  ";
    matriz[17, 9] = "  ";
    matriz[17, 10] = "  ";

    // Días de Junio:
    matriz[17, 11] = "17";
    matriz[17, 12] = "18";
    matriz[17, 13] = "19";
    matriz[17, 14] = "20";
    matriz[17, 15] = "21";
    matriz[17, 16] = "22";
    matriz[17, 17] = "23";
    matriz[17, 18] = "  ";
    matriz[17, 19] = "  ";
    matriz[17, 20] = "  ";
    matriz[17, 21] = "  ";

    // Días de Julio:
    matriz[17, 22] = "22";
    matriz[17, 23] = "23";
    matriz[17, 24] = "24";
    matriz[17, 25] = "25";
    matriz[17, 26] = "26";
    matriz[17, 27] = "27";
    matriz[17, 28] = "28";
    matriz[17, 29] = "  ";
    matriz[17, 30] = "  ";
    matriz[17, 31] = "  ";
    matriz[17, 32] = "  ";

    // Días de Agosto:
    matriz[17, 33] = "19";
    matriz[17, 34] = "20";
    matriz[17, 35] = "21";
    matriz[17, 36] = "22";
    matriz[17, 37] = "23";
    matriz[17, 38] = "24";
    matriz[17, 39] = "25";

    // Días de Mayo:
    matriz[18, 0] = "27";
    matriz[18, 1] = "28";
    matriz[18, 2] = "29";
    matriz[18, 3] = "30";
    matriz[18, 4] = "31";
    matriz[18, 5] = "  ";
    matriz[18, 6] = "  ";
    matriz[18, 7] = "  ";
    matriz[18, 8] = "  ";
    matriz[18, 9] = "  ";
    matriz[18, 10] = "  ";

    // Días de Junio:
    matriz[18, 11] = "24";
    matriz[18, 12] = "25";
    matriz[18, 13] = "26";
    matriz[18, 14] = "27";
    matriz[18, 15] = "28";
    matriz[18, 16] = "29";
    matriz[18, 17] = "30";
    matriz[18, 18] = "  ";
    matriz[18, 19] = "  ";
    matriz[18, 20] = "  ";
    matriz[18, 21] = "  ";

    // Días de Julio:
    matriz[18, 22] = "29";
    matriz[18, 23] = "30";
    matriz[18, 24] = "31";
    matriz[18, 25] = "  ";
    matriz[18, 26] = "  ";
    matriz[18, 27] = "  ";
    matriz[18, 28] = "  ";
    matriz[18, 29] = "  ";
    matriz[18, 30] = "  ";
    matriz[18, 31] = "  ";
    matriz[18, 32] = "  ";

    // Días de Agosto:
    matriz[18, 33] = "26";
    matriz[18, 34] = "27";
    matriz[18, 35] = "27";
    matriz[18, 36] = "28";
    matriz[18, 37] = "29";
    matriz[18, 38] = "30";
    matriz[18, 39] = "31";

    // Diseño Vacío Septiembre:
    matriz[19, 0] = "  ";
    matriz[19, 1] = "  ";
    matriz[19, 2] = "  ";
    matriz[19, 3] = "  ";
    matriz[19, 4] = "  ";
    matriz[19, 5] = "  ";
    matriz[19, 6] = "  ";
    matriz[19, 7] = "  ";
    matriz[19, 8] = "  ";
    matriz[19, 9] = "  ";
    matriz[19, 10] = "  ";

    // Diseño Vacío Octubre:
    matriz[19, 11] = "  ";
    matriz[19, 12] = "  ";
    matriz[19, 13] = "  ";
    matriz[19, 14] = "  ";
    matriz[19, 15] = "  ";
    matriz[19, 16] = "  ";
    matriz[19, 17] = "  ";
    matriz[19, 18] = "  ";
    matriz[19, 19] = "  ";
    matriz[19, 20] = "  ";
    matriz[19, 21] = "  ";

    // Diseño Vacío Noviembre:
    matriz[19, 22] = "  ";
    matriz[19, 23] = "  ";
    matriz[19, 24] = "  ";
    matriz[19, 25] = "  ";
    matriz[19, 26] = "  ";
    matriz[19, 27] = "  ";
    matriz[19, 28] = "  ";
    matriz[19, 29] = "  ";
    matriz[19, 30] = "  ";
    matriz[19, 31] = "  ";
    matriz[19, 32] = "  ";

    // Diseño Vacío Diciembre:
    matriz[19, 33] = "  ";
    matriz[19, 34] = "  ";
    matriz[19, 35] = "  ";
    matriz[19, 36] = "  ";
    matriz[19, 37] = "  ";
    matriz[19, 38] = "  ";
    matriz[19, 39] = "  ";

    // Diseño Mes de Septiembre:
    matriz[20, 0] = "==";
    matriz[20, 1] = "==";
    matriz[20, 2] = "==";
    matriz[20, 3] = "==";
    matriz[20, 4] = "==";
    matriz[20, 5] = "==";
    matriz[20, 6] = "==";
    matriz[20, 7] = "  ";
    matriz[20, 8] = "  ";
    matriz[20, 9] = "  ";
    matriz[20, 10] = "  ";

    // Diseño Mes de Octubre:
    matriz[20, 11] = "==";
    matriz[20, 12] = "==";
    matriz[20, 13] = "==";
    matriz[20, 14] = "==";
    matriz[20, 15] = "==";
    matriz[20, 16] = "==";
    matriz[20, 17] = "==";
    matriz[20, 18] = "  ";
    matriz[20, 19] = "  ";
    matriz[20, 20] = "  ";
    matriz[20, 21] = "  ";

    // Diseño Mes de Noviembre:
    matriz[20, 22] = "==";
    matriz[20, 23] = "==";
    matriz[20, 24] = "==";
    matriz[20, 25] = "==";
    matriz[20, 26] = "==";
    matriz[20, 27] = "==";
    matriz[20, 28] = "==";
    matriz[20, 29] = "  ";
    matriz[20, 30] = "  ";
    matriz[20, 31] = "  ";
    matriz[20, 32] = "  ";

    // Diseño Mes de Diciembre:
    matriz[20, 33] = "==";
    matriz[20, 34] = "==";
    matriz[20, 35] = "==";
    matriz[20, 36] = "==";
    matriz[20, 37] = "==";
    matriz[20, 38] = "==";
    matriz[20, 39] = "==";

    // Diseño de Septiembre (=):
    matriz[21, 0] = "";
    matriz[21, 1] = "S";
    matriz[21, 2] = "E";
    matriz[21, 3] = "P";
    matriz[21, 4] = "T";
    matriz[21, 5] = "I";
    matriz[21, 6] = "E";
    matriz[21, 7] = "M";
    matriz[21, 8] = "B";
    matriz[21, 9] = "R";
    matriz[21, 10] = "E";
    matriz[21, 11] = "  ";
    matriz[21, 12] = "  ";
    matriz[21, 13] = "  ";
    matriz[21, 14] = "  ";

    // Diseño de Octubre (=):
    matriz[21, 15] = "|||";
    matriz[21, 16] = "O";
    matriz[21, 17] = "C";
    matriz[21, 18] = "T";
    matriz[21, 19] = "U";
    matriz[21, 20] = "B";
    matriz[21, 21] = "R";
    matriz[21, 22] = "E";
    matriz[21, 23] = "||";
    matriz[21, 24] = "  ";
    matriz[21, 25] = "  ";
    matriz[21, 26] = "  ";
    matriz[21, 27] = "  ";

    // Diseño de Noviembre (=):
    matriz[21, 28] = "|";
    matriz[21, 29] = "N";
    matriz[21, 30] = "O";
    matriz[21, 31] = "V";
    matriz[21, 32] = "I";
    matriz[21, 33] = "E";
    matriz[21, 34] = "M";
    matriz[21, 35] = "B";
    matriz[21, 36] = "R";
    matriz[21, 37] = "E ";
    matriz[21, 38] = "  ";
    matriz[21, 39] = "  ";
    matriz[21, 40] = "  ";
    matriz[21, 41] = "  ";

    // Diseño de Diciembre (=):
    matriz[21, 42] = "|";
    matriz[21, 43] = "D";
    matriz[21, 44] = "I";
    matriz[21, 45] = "C";
    matriz[21, 46] = "I";
    matriz[21, 47] = "E";
    matriz[21, 48] = "M";
    matriz[21, 49] = "B";
    matriz[21, 50] = "R";
    matriz[21, 51] = "E";
    matriz[21, 52] = "|";

    // Diseño de Septiembre (=):
    matriz[22, 0] = "==";
    matriz[22, 1] = "==";
    matriz[22, 2] = "==";
    matriz[22, 3] = "==";
    matriz[22, 4] = "==";
    matriz[22, 5] = "==";
    matriz[22, 6] = "==";
    matriz[22, 7] = "  ";
    matriz[22, 8] = "  ";
    matriz[22, 9] = "  ";
    matriz[22, 10] = "  ";

    // Diseño de Octubre (=):
    matriz[22, 11] = "==";
    matriz[22, 12] = "==";
    matriz[22, 13] = "==";
    matriz[22, 14] = "==";
    matriz[22, 15] = "==";
    matriz[22, 16] = "==";
    matriz[22, 17] = "==";
    matriz[22, 18] = "  ";
    matriz[22, 19] = "  ";
    matriz[22, 20] = "  ";
    matriz[22, 21] = "  ";

    // Diseño de Noviembre (=):
    matriz[22, 22] = "==";
    matriz[22, 23] = "==";
    matriz[22, 24] = "==";
    matriz[22, 25] = "==";
    matriz[22, 26] = "==";
    matriz[22, 27] = "==";
    matriz[22, 28] = "==";
    matriz[22, 29] = "  ";
    matriz[22, 30] = "  ";
    matriz[22, 31] = "  ";
    matriz[22, 32] = "  ";

    // Diseño de Diciembre (=):
    matriz[22, 33] = "==";
    matriz[22, 34] = "==";
    matriz[22, 35] = "==";
    matriz[22, 36] = "==";
    matriz[22, 37] = "==";
    matriz[22, 38] = "==";
    matriz[22, 39] = "==";

    // Días de la Semana Septiembre:
    matriz[23, 0] = "Lu";
    matriz[23, 1] = "Ma";
    matriz[23, 2] = "Mi";
    matriz[23, 3] = "Ju";
    matriz[23, 4] = "Vi";
    matriz[23, 5] = "Sa";
    matriz[23, 6] = "Do";
    matriz[23, 7] = "  ";
    matriz[23, 8] = "  ";
    matriz[23, 9] = "  ";
    matriz[23, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[23, 11] = "Lu";
    matriz[23, 12] = "Ma";
    matriz[23, 13] = "Mi";
    matriz[23, 14] = "Ju";
    matriz[23, 15] = "Vi";
    matriz[23, 16] = "Sa";
    matriz[23, 17] = "Do";
    matriz[23, 18] = "  ";
    matriz[23, 19] = "  ";
    matriz[23, 20] = "  ";
    matriz[23, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[23, 22] = "Lu";
    matriz[23, 23] = "Ma";
    matriz[23, 24] = "Mi";
    matriz[23, 25] = "Ju";
    matriz[23, 26] = "Vi";
    matriz[23, 27] = "Sa";
    matriz[23, 28] = "Do";
    matriz[23, 29] = "  ";
    matriz[23, 30] = "  ";
    matriz[23, 31] = "  ";
    matriz[23, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[23, 33] = "Lu";
    matriz[23, 34] = "Ma";
    matriz[23, 35] = "Mi";
    matriz[23, 36] = "Ju";
    matriz[23, 37] = "Vi";
    matriz[23, 38] = "Sa";
    matriz[23, 39] = "Do";

    // Días de la Semana Septiembre:
    matriz[24, 0] = "  ";
    matriz[24, 1] = "  ";
    matriz[24, 2] = "  ";
    matriz[24, 3] = "  ";
    matriz[24, 4] = "  ";
    matriz[24, 5] = "  ";
    matriz[24, 6] = " 1";
    matriz[24, 7] = "  ";
    matriz[24, 8] = "  ";
    matriz[24, 9] = "  ";
    matriz[24, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[24, 11] = "  ";
    matriz[24, 12] = " 1";
    matriz[24, 13] = " 2";
    matriz[24, 14] = " 3";
    matriz[24, 15] = " 4";
    matriz[24, 16] = " 5";
    matriz[24, 17] = " 6";
    matriz[24, 18] = "  ";
    matriz[24, 19] = "  ";
    matriz[24, 20] = "  ";
    matriz[24, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[24, 22] = "  ";
    matriz[24, 23] = "  ";
    matriz[24, 24] = "  ";
    matriz[24, 25] = "  ";
    matriz[24, 26] = " 1";
    matriz[24, 27] = " 2";
    matriz[24, 28] = " 3";
    matriz[24, 29] = "  ";
    matriz[24, 30] = "  ";
    matriz[24, 31] = "  ";
    matriz[24, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[24, 33] = "  ";
    matriz[24, 34] = "  ";
    matriz[24, 35] = "  ";
    matriz[24, 36] = "  ";
    matriz[24, 37] = "  ";
    matriz[24, 38] = "  ";
    matriz[24, 39] = " 1";

    // Días de la Semana Septiembre:
    matriz[25, 0] = " 2";
    matriz[25, 1] = " 3";
    matriz[25, 2] = " 4";
    matriz[25, 3] = " 5";
    matriz[25, 4] = " 6";
    matriz[25, 5] = " 7";
    matriz[25, 6] = " 8";
    matriz[25, 7] = "  ";
    matriz[25, 8] = "  ";
    matriz[25, 9] = "  ";
    matriz[25, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[25, 11] = " 7";
    matriz[25, 12] = " 8";
    matriz[25, 13] = " 9";
    matriz[25, 14] = "10";
    matriz[25, 15] = "11";
    matriz[25, 16] = "12";
    matriz[25, 17] = "13";
    matriz[25, 18] = "  ";
    matriz[25, 19] = "  ";
    matriz[25, 20] = "  ";
    matriz[25, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[25, 22] = " 4";
    matriz[25, 23] = " 5";
    matriz[25, 24] = " 6";
    matriz[25, 25] = " 7";
    matriz[25, 26] = " 8";
    matriz[25, 27] = " 9";
    matriz[25, 28] = "10";
    matriz[25, 29] = "  ";
    matriz[25, 30] = "  ";
    matriz[25, 31] = "  ";
    matriz[25, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[25, 33] = " 2";
    matriz[25, 34] = " 3";
    matriz[25, 35] = " 4";
    matriz[25, 36] = " 5";
    matriz[25, 37] = " 6";
    matriz[25, 38] = " 7";
    matriz[25, 39] = " 8";

    // Días de la Semana Septiembre:
    matriz[26, 0] = " 9";
    matriz[26, 1] = "10";
    matriz[26, 2] = "11";
    matriz[26, 3] = "12";
    matriz[26, 4] = "13";
    matriz[26, 5] = "14";
    matriz[26, 6] = "15";
    matriz[26, 7] = "  ";
    matriz[26, 8] = "  ";
    matriz[26, 9] = "  ";
    matriz[26, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[26, 11] = "14";
    matriz[26, 12] = "15";
    matriz[26, 13] = "16";
    matriz[26, 14] = "17";
    matriz[26, 15] = "18";
    matriz[26, 16] = "19";
    matriz[26, 17] = "20";
    matriz[26, 18] = "  ";
    matriz[26, 19] = "  ";
    matriz[26, 20] = "  ";
    matriz[26, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[26, 22] = "11";
    matriz[26, 23] = "12";
    matriz[26, 24] = "13";
    matriz[26, 25] = "14";
    matriz[26, 26] = "15";
    matriz[26, 27] = "16";
    matriz[26, 28] = "17";
    matriz[26, 29] = "  ";
    matriz[26, 30] = "  ";
    matriz[26, 31] = "  ";
    matriz[26, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[26, 33] = " 9";
    matriz[26, 34] = "10";
    matriz[26, 35] = "11";
    matriz[26, 36] = "12";
    matriz[26, 37] = "13";
    matriz[26, 38] = "14";
    matriz[26, 39] = "15";

    // Días de la Semana Septiembre:
    matriz[27, 0] = "16";
    matriz[27, 1] = "17";
    matriz[27, 2] = "18";
    matriz[27, 3] = "19";
    matriz[27, 4] = "20";
    matriz[27, 5] = "21";
    matriz[27, 6] = "22";
    matriz[27, 7] = "  ";
    matriz[27, 8] = "  ";
    matriz[27, 9] = "  ";
    matriz[27, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[27, 11] = "21";
    matriz[27, 12] = "22";
    matriz[27, 13] = "23";
    matriz[27, 14] = "24";
    matriz[27, 15] = "25";
    matriz[27, 16] = "26";
    matriz[27, 17] = "27";
    matriz[27, 18] = "  ";
    matriz[27, 19] = "  ";
    matriz[27, 20] = "  ";
    matriz[27, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[27, 22] = "18";
    matriz[27, 23] = "19";
    matriz[27, 24] = "20";
    matriz[27, 25] = "21";
    matriz[27, 26] = "22";
    matriz[27, 27] = "23";
    matriz[27, 28] = "24";
    matriz[27, 29] = "  ";
    matriz[27, 30] = "  ";
    matriz[27, 31] = "  ";
    matriz[27, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[27, 33] = "16";
    matriz[27, 34] = "17";
    matriz[27, 35] = "18";
    matriz[27, 36] = "19";
    matriz[27, 37] = "20";
    matriz[27, 38] = "21";
    matriz[27, 39] = "22";

    // Días de la Semana Septiembre:
    matriz[28, 0] = "23";
    matriz[28, 1] = "24";
    matriz[28, 2] = "25";
    matriz[28, 3] = "26";
    matriz[28, 4] = "27";
    matriz[28, 5] = "28";
    matriz[28, 6] = "29";
    matriz[28, 7] = "  ";
    matriz[28, 8] = "  ";
    matriz[28, 9] = "  ";
    matriz[28, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[28, 11] = "28";
    matriz[28, 12] = "29";
    matriz[28, 13] = "30";
    matriz[28, 14] = "31";
    matriz[28, 15] = "  ";
    matriz[28, 16] = "  ";
    matriz[28, 17] = "  ";
    matriz[28, 18] = "  ";
    matriz[28, 19] = "  ";
    matriz[28, 20] = "  ";
    matriz[28, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[28, 22] = "25";
    matriz[28, 23] = "26";
    matriz[28, 24] = "27";
    matriz[28, 25] = "28";
    matriz[28, 26] = "29";
    matriz[28, 27] = "30";
    matriz[28, 28] = "  ";
    matriz[28, 29] = "  ";
    matriz[28, 30] = "  ";
    matriz[28, 31] = "  ";
    matriz[28, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[28, 33] = "23";
    matriz[28, 34] = "24";
    matriz[28, 35] = "25";
    matriz[28, 36] = "26";
    matriz[28, 37] = "27";
    matriz[28, 38] = "28";
    matriz[28, 39] = "29";

    // Días de la Semana Septiembre:
    matriz[29, 0] = "30";
    matriz[29, 1] = "  ";
    matriz[29, 2] = "  ";
    matriz[29, 3] = "  ";
    matriz[29, 4] = "  ";
    matriz[29, 5] = "  ";
    matriz[29, 6] = "  ";
    matriz[29, 7] = "  ";
    matriz[29, 8] = "  ";
    matriz[29, 9] = "  ";
    matriz[29, 10] = "  ";

    // Días de la Semana Octubre:
    matriz[29, 11] = "  ";
    matriz[29, 12] = "  ";
    matriz[29, 13] = "  ";
    matriz[29, 14] = "  ";
    matriz[29, 15] = "  ";
    matriz[29, 16] = "  ";
    matriz[29, 17] = "  ";
    matriz[29, 18] = "  ";
    matriz[29, 19] = "  ";
    matriz[29, 20] = "  ";
    matriz[29, 21] = "  ";

    // Días de la Semana Noviembre:
    matriz[29, 22] = "  ";
    matriz[29, 23] = "  ";
    matriz[29, 24] = "  ";
    matriz[29, 25] = "  ";
    matriz[29, 26] = "  ";
    matriz[29, 27] = "  ";
    matriz[29, 28] = "  ";
    matriz[29, 29] = "  ";
    matriz[29, 30] = "  ";
    matriz[29, 31] = "  ";
    matriz[29, 32] = "  ";

    // Días de la Semana Diciembre:
    matriz[29, 33] = "30";
    matriz[29, 34] = "31";
    matriz[29, 35] = "  ";
    matriz[29, 36] = "  ";
    matriz[29, 37] = "  ";
    matriz[29, 38] = "  ";
    matriz[29, 39] = "  \n";

    Console.Write("[*] Ingrese la opción deseada: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    // Limpiar Pantalla:
    Console.Clear();

    // Menú de Opciones:
    switch (opcion)
    {
        // Mes de Enero:
        case 1:
            MostrarMatriz(matriz_enero);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[+] El mes de Enero tiene un solo feriado: \n - 1 de Enero (Año nuevo).\n");
            Console.ResetColor();          
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case = Console.ReadLine();
            Console.Clear();
            if (op_case == "2")
            {
                menuPrincipal = false;
            }
            break;
       
        // Mes de Febrero:
        case 2:
            MostrarMatriz(matriz_febrero);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("[-] El mes de Febrero NO tiene Feriados.\n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case2 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Marzo:
        case 3:
            MostrarMatriz(matriz_marzo);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("[-] El mes de Marzo tiene 3 Feriados: \n - 29 de Marzo (Viernes Santo).\n - 30 de Marzo (Sábado Santo). \n - 31 de Marzo (Domingo Santo). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case3 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Abril:
        case 4:
            MostrarMatriz(matriz_abril);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Abril NO tiene Feriados.\n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case4 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Mayo:
        case 5:
            MostrarMatriz(matriz_mayo);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Mayo tiene dos Feriados: \n - 1 de Mayo (Día del Trabajador). \n - 21 de Mayo (Día de las Glorias Navales). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case5 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Junio:
        case 6:
            MostrarMatriz(matriz_junio);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Junio tiene tres Feriados: \n - 9 de Junio (POR CONFIRMAR) -> (Elecciones Primarias Alcaldes y Gobernadores). \n - 20 de Junio (Día de los Pueblos Indígenas). \n - 29 de Junio (San Pedro y San Pablo). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case6 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Julio:
        case 7:
            MostrarMatriz(matriz_julio);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Julio tiene un Feriado: \n - 16 de Julio (Día de la Virgen del Carmen). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case7 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Agosto:
        case 8:
            MostrarMatriz(matriz_agosto);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("[-] El mes de Agosto tiene un Feriado: \n - 15 de Agosto (Asunción de la Virgen). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case8 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Septiembre:
        case 9:
            MostrarMatriz(matriz_septiembre);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Septiembre tiene un Feriado: \n - 18 de Septiembre (Independencia Nacional). \n - 19 de Septiembre (Día de las Glorias del Ejército). \n - 20 de Septiembre (Feriado Adicional Fiestas Patrias). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case9 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Octubre:
        case 10:
            MostrarMatriz(matriz_octubre);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Octubre tiene tres Feriados: \n - 12 de Octubre (Encuentro de Dos mundos). \n - 27 de Octubre (Elecciones Municipales, Consejeros Regionales y Gobernadores Regionales). \n - 31 de Octubre (Día de las Iglesias Evangélicas y Protestantes). \n");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case10 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Noviembre:
        case 11:
            MostrarMatriz(matriz_noviembre);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Noviembre tiene dos Feriados: \n - 1 de Noviembre (Día de todos los Santos). \n - 24 de Noviembre (POR CONFIRMAR) - (Segunda Vuelta Elección Gobernadores Regionales). \n ");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case11 = Console.ReadLine();
            Console.Clear();
            break;

        // Mes de Diciembre:
        case 12:
            MostrarMatriz(matriz_diciembre);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] El mes de Diciembre tiene dos Feriados: \n - 8 de Diciembre (Inmaculada Concepción). \n - 25 de Diciembre (Navitividad del Señor). \n ");
            Console.ResetColor();
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case12 = Console.ReadLine();
            Console.Clear();
            break;

        // Mostrar todo el Calendario:
        case 13:
            MostrarMatriz(matriz);
            Console.Write("[+] Escribe cualquier tecla para regresar: ");
            string op_case13 = Console.ReadLine();
            Console.Clear();
            break;

        // Salir del Programa:
        case 14:
            menuPrincipal = false;
            break;
        default:
            Console.WriteLine("OPCIÓN INVÁLIDA!! VUELVA A INTENTARLO!!");
            break;

    }
            // Recorrer Matrices:
            static void MostrarMatriz(string[,] matriz)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

} while (menuPrincipal);

