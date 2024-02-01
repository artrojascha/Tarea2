string salir = "", nombre;
int cedula, tipo, operarios = 0, tecnicos = 0, profesionales = 0;
float horas, monto, aumento_operario, salario_bruto_operario, salario_neto_operario, acumulado_salario_neto_operario = 0, aumento_tecnico, salario_bruto_tecnico, salario_neto_tecnico, acumulado_salario_neto_tecnico = 0, aumento_profesional, salario_bruto_profesional, salario_neto_profesional, acumulado_salario_neto_profesional = 0, deduccion_CCSS;

while (salir != "Si")
{
    Console.WriteLine("Digite el número de cédula del colaborador (debe ser un número sin espacios ni guiones):");
    cedula = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite el nombre del colaborador:");
    nombre = Console.ReadLine();
    Console.WriteLine("Digitar 1 para operario, 2 para Tecnico o 3 para Profesional");
    tipo = int.Parse(Console.ReadLine());
    if (tipo > 3 || tipo < 1)
    {
        while (tipo > 3 || tipo < 1)
        {
            Console.WriteLine("Digitar 1 para operario, 2 para Tecnico o 3 para Profesional");
            tipo = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Digite la cantidad de horas laboradas:");
    horas = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite el monto por hora del colaborador:");
    monto = float.Parse(Console.ReadLine());
    Console.WriteLine("El número de cédula del colaborador es: {0}", cedula);
    Console.WriteLine("El nombre del colaborador es: {0}", nombre);
    Console.WriteLine("El tipo de empleado: {0}", tipo);
    Console.WriteLine("El monto por hora del colaborador es: {0}", monto);
    Console.WriteLine("La cantidad de horas laboradas es de: {0}", horas);
    Console.WriteLine("El salario ordinario es de: {0}", monto * horas);
    if (tipo == 1)
    {
        aumento_operario = 0.15f * monto * horas;
        Console.WriteLine("El aumento es de: {0}", aumento_operario);
        salario_bruto_operario = 1.15f * monto * horas;
        Console.WriteLine("El salario bruto es de: {0}", salario_bruto_operario);
        deduccion_CCSS = 9.17f / 100 * salario_bruto_operario;
        Console.WriteLine("La deducción de CCSS es de: {0}", deduccion_CCSS);
        salario_neto_operario = salario_bruto_operario - deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_operario);
        operarios++;
        acumulado_salario_neto_operario = acumulado_salario_neto_operario + salario_neto_operario;
    }
    if (tipo == 2)
    {
        aumento_tecnico = 0.10f * monto * horas;
        Console.WriteLine("El aumento es de: {0}", aumento_tecnico);
        salario_bruto_tecnico = 1.10f * monto * horas;
        Console.WriteLine("El salario bruto es de: {0}", salario_bruto_tecnico);
        deduccion_CCSS = 9.17f / 100 * salario_bruto_tecnico;
        Console.WriteLine("La deducción de CCSS es de: {0}", deduccion_CCSS);
        salario_neto_tecnico = salario_bruto_tecnico - deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_tecnico);
        tecnicos++;
        acumulado_salario_neto_tecnico = acumulado_salario_neto_tecnico + salario_neto_tecnico;
    }
    if (tipo == 3)
    {
        aumento_profesional = 0.05f * monto * horas;
        Console.WriteLine("El aumento es de: {0}", aumento_profesional);
        salario_bruto_profesional = 1.05f * monto * horas;
        Console.WriteLine("El salario bruto es de: {0}", salario_bruto_profesional);
        deduccion_CCSS = 9.17f / 100 * salario_bruto_profesional;
        Console.WriteLine("La deducción de CCSS es de: {0}", deduccion_CCSS);
        salario_neto_profesional = salario_bruto_profesional - deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_profesional);
        profesionales++;
        acumulado_salario_neto_profesional = acumulado_salario_neto_profesional + salario_neto_profesional;
    }
    Console.WriteLine("Desea salir (Si/No)");
    salir = Console.ReadLine();
}

Console.WriteLine("La cantidad de operarios es: {0}", operarios);
Console.WriteLine("El acumulado de salario neto de operarios es de: {0}", acumulado_salario_neto_operario);
if (operarios > 1)
{
    Console.WriteLine("El promedio de salario neto de operarios es de: {0}", acumulado_salario_neto_operario / operarios);
}
else
{
    Console.WriteLine("El promedio de salario neto de operarios es de: {0}", acumulado_salario_neto_operario);
}
Console.WriteLine("La cantidad de técnicos es: {0}", tecnicos);
Console.WriteLine("El acumulado de salario neto de tecnicos es de: {0}", acumulado_salario_neto_tecnico);
if (tecnicos > 1)
{
    Console.WriteLine("El promedio de salario neto de tecnicos es de: {0}", acumulado_salario_neto_tecnico / tecnicos);
}
else
{
    Console.WriteLine("El promedio de salario neto de tecnicos es de: {0}", acumulado_salario_neto_tecnico);
}
Console.WriteLine("La cantidad de profesionales es: {0}", profesionales);
Console.WriteLine("El acumulado de salario neto de profesionales es de: {0}", acumulado_salario_neto_profesional);
if (profesionales > 1)
{
    Console.WriteLine("El promedio de salario neto de profesionales es de: {0}", acumulado_salario_neto_profesional / profesionales);
}
else
{
    Console.WriteLine("El promedio de salario neto de profesionales es de: {0}", acumulado_salario_neto_profesional);
}
