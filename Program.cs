AvisosTrafico av1 = new();
AvisosTrafico av2 = new("Transito CABA", "Sancion por exceso de velocidad ARS15,000", "24/5/2020");
AvisosTrafico av3 = new();

av1.MostarAviso();
WriteLine();
WriteLine(av2.GetFecha());  
WriteLine();
av2.MostarAviso();
av2.MostarAviso();
av3.MostarAviso();
av3.MostarAviso();