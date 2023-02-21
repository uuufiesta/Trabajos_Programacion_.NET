// Se calculara la paga de un trabajador con impuesto y sin impuesto

string nombre;
int horas;
float paga, tasa, impuesto, pagabruta, paganeta;

Console.WriteLine("Calculando la paga de un trabajador");
Console.WriteLine("Dame el nombre de tu trabajador");
nombre = Console.ReadLine();
Console.WriteLine($"Dame las horas que trabajo {nombre}");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor de la paga por hora");
paga = float.Parse(Console.ReadLine());
tasa = (float)0.10;
pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

Console.WriteLine("Resumen de pagos:");
Console.WriteLine($"El trabajador {nombre} que trabajo {horas} horas a una tasa de interes de {tasa} " +
                  $"tiene una paga bruta de {pagabruta} de la cual {impuesto} corresponde a impuestos " +
                  $"por lo que su paga neta será {paganeta}");