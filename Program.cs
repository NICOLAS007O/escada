double comprimentoescada, anguloemradiano, anguloemgraus, altura ;
 
 Console.Clear();
 Console.Write("informe o comprimento da escada:   ");
comprimentoescada = Convert.ToDouble(Console.ReadLine());

Console.Write("informe o angulo em (graus) da escada:   ");
anguloemgraus = Convert.ToDouble(Console.ReadLine());

anguloemradiano = anguloemgraus * (Math.PI / 180);

altura = comprimentoescada * Math.Sin(anguloemradiano);
Console.WriteLine($"{altura:N2}");