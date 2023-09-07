using PruebaHerencia;

EmpleadoPorComision empleadoPorComision = new("susana", "López", "222-22-2222", .06M, 10000.00M);
Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoPorComisión con referencia de " +
    "clase base ", "a objeto de clase basae",
    empleadoPorComision.ToString(),
    "Ingresos",empleadoPorComision.ingreso());

EmpleadoBaseMasComision2 EmpleadoBaseMasComision = new("roberto",
    "Pérez", "333-33-3333", .04M, 500.00M, 300.0M);
Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoBaseMasComisión con referencia de " +
    "clase derivada ", "a objeto de clase derivada",
    EmpleadoBaseMasComision.ToString(),
    "Ingresos", EmpleadoBaseMasComision.ingreso());

//EmpleadoBaseMasComision.ventasBrutas = 4000.000M;
