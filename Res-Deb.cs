using System; 
  
class Program 
{ 
  
    public static void Main(string[] args) 
    {
		string tipoMossa;
		string tipoAvv1;
		string tipoAvv2;
		int rappMossaAvv1 = 0;
		int rappMossaAvv2 = 0;
		Console.WriteLine("Calcolatore Efficacia");
		Console.WriteLine("by Luca Lascialfari\n\n\n\n");
		
		
		
		do 
		{
			Console.Write("Inserire il tipo della mossa che si vuole utilizzare:");
			tipoMossa = Console.ReadLine();
			tipoMossa = tipoMossa.Replace(" ", String.Empty);
			tipoMossa = tipoMossa.ToLower();
		}
		while
		(
			tipoMossa != "acciaio" & tipoMossa != "acqua" & tipoMossa != "buio" & 
			tipoMossa != "coleottero" & tipoMossa != "drago" & tipoMossa != "elettro" & 
			tipoMossa != "erba" & tipoMossa != "folletto" & tipoMossa != "fuoco" & 
			tipoMossa != "ghiaccio" & tipoMossa != "lotta" & tipoMossa != "normale" & 
			tipoMossa != "psico" & tipoMossa != "roccia" & tipoMossa != "spettro" & 
			tipoMossa != "terra" & tipoMossa != "veleno" & tipoMossa != "volante"
		);
		
		
		do
		{
			Console.Write("Inserire il tipo primario del Pokémon avversario:");
			tipoAvv1 = Console.ReadLine();
			tipoAvv1 = tipoAvv1.Replace(" ", String.Empty);
			tipoAvv1 = tipoAvv1.ToLower();
		}
		while
		(
			tipoAvv1 != "acciaio" & tipoAvv1 != "acqua" & tipoAvv1 != "buio" & 
			tipoAvv1 != "coleottero" & tipoAvv1 != "drago" & tipoAvv1 != "elettro" & 
			tipoAvv1 != "erba" & tipoAvv1 != "folletto" & tipoAvv1 != "fuoco" & 
			tipoAvv1 != "ghiaccio" & tipoAvv1 != "lotta" & tipoAvv1 != "normale" & 
			tipoAvv1 != "psico" & tipoAvv1 != "roccia" & tipoAvv1 != "spettro" & 
			tipoAvv1 != "terra" & tipoAvv1 != "veleno" & tipoAvv1 != "volante"
		);
		
		do
		{
			Console.Write("Inserire il tipo secondario del Pokémon avversario:");
			tipoAvv2 = Console.ReadLine();
			tipoAvv2 = tipoAvv2.Replace(" ", String.Empty);
			tipoAvv2 = tipoAvv2.ToLower();
		}
		while
		(
			tipoAvv2 != "acciaio" & tipoAvv2 != "acqua" & tipoAvv2 != "buio" & 
			tipoAvv2 != "coleottero" & tipoAvv2 != "drago" & tipoAvv2 != "elettro" & 
			tipoAvv2 != "erba" & tipoAvv2 != "folletto" & tipoAvv2 != "fuoco" & 
			tipoAvv2 != "ghiaccio" & tipoAvv2 != "lotta" & tipoAvv2 != "normale" & 
			tipoAvv2 != "psico" & tipoAvv2 != "roccia" & tipoAvv2 != "spettro" & 
			tipoAvv2 != "terra" & tipoAvv2 != "veleno" & tipoAvv2 != "volante" &
			tipoAvv2 != "nessuno"
		);
		
		if(
		(tipoMossa == "acciaio" & tipoAvv1 == "folletto") | (tipoMossa == "acciaio" & tipoAvv1 == "ghiaccio") | (tipoMossa == "acciaio" & tipoAvv1 == "roccia") | 
		(tipoMossa == "acqua" & tipoAvv1 == "fuoco") | (tipoMossa == "acqua" & tipoAvv1 == "roccia") | (tipoMossa == "acqua" & tipoAvv1 == "terra") | 
		(tipoMossa == "buio" & tipoAvv1 == "psico") | (tipoMossa == "buio" & tipoAvv1 == "spettro") | 
		(tipoMossa == "coleottero" & tipoAvv1 == "buio") | (tipoMossa == "coleottero" & tipoAvv1 == "erba") | (tipoMossa == "coleottero" & tipoAvv1 == "psico") | 
		(tipoMossa == "drago" & tipoAvv1 == "drago") | 
		(tipoMossa == "elettro" & tipoAvv1 == "acqua") | (tipoMossa == "elettro" & tipoAvv1 == "volante") | 
		(tipoMossa == "erba" & tipoAvv1 == "acqua") | (tipoMossa == "erba" & tipoAvv1 == "roccia") | (tipoMossa == "erba" & tipoAvv1 == "terra") | 
		(tipoMossa == "folletto" & tipoAvv1 == "buio") | (tipoMossa == "folletto" & tipoAvv1 == "drago") | (tipoMossa == "folletto" & tipoAvv1 == "lotta") | 
		(tipoMossa == "fuoco" & tipoAvv1 == "acciaio") | (tipoMossa == "fuoco" & tipoAvv1 == "coleottero") | (tipoMossa == "fuoco" & tipoAvv1 == "erba") | (tipoMossa == "fuoco" & tipoAvv1 == "ghiaccio") | 
		(tipoMossa == "ghiaccio" & tipoAvv1 == "drago") | (tipoMossa == "ghiaccio" & tipoAvv1 == "erba") | (tipoMossa == "ghiaccio" & tipoAvv1 == "terra") | (tipoMossa == "ghiaccio" & tipoAvv1 == "volante") | 
		(tipoMossa == "lotta" & tipoAvv1 == "acciaio") | (tipoMossa == "lotta" & tipoAvv1 == "buio") | (tipoMossa == "lotta" & tipoAvv1 == "ghiaccio") | (tipoMossa == "lotta" & tipoAvv1 == "normale") | (tipoMossa == "lotta" & tipoAvv1 == "roccia") | 
		(tipoMossa == "psico" & tipoAvv1 == "lotta") | (tipoMossa == "psico" & tipoAvv1 == "veleno") | 
		(tipoMossa == "roccia" & tipoAvv1 == "coleottero") | (tipoMossa == "roccia" & tipoAvv1 == "fuoco") | (tipoMossa == "roccia" & tipoAvv1 == "ghiaccio") | (tipoMossa == "roccia" & tipoAvv1 == "volante") | 
		(tipoMossa == "spettro" & tipoAvv1 == "psico") | (tipoMossa == "spettro" & tipoAvv1 == "spettro") | 
		(tipoMossa == "terra" & tipoAvv1 == "acciaio") | (tipoMossa == "terra" & tipoAvv1 == "elettro") | (tipoMossa == "terra" & tipoAvv1 == "fuoco") | (tipoMossa == "terra" & tipoAvv1 == "roccia") | (tipoMossa == "terra" & tipoAvv1 == "veleno") | 
		(tipoMossa == "veleno" & tipoAvv1 == "erba") | (tipoMossa == "veleno" & tipoAvv1 == "folletto") | 
		(tipoMossa == "volante" & tipoAvv1 == "coleottero") | (tipoMossa == "volante" & tipoAvv1 == "erba") | (tipoMossa == "volante" & tipoAvv1 == "lotta")
		)
		{
			rappMossaAvv1 = rappMossaAvv1++;
		}
		else if(
		(tipoMossa == "acciaio" & tipoAvv1 == "acciaio") | (tipoMossa == "acciaio" & tipoAvv1 == "acqua") | (tipoMossa == "acciaio" & tipoAvv1 == "elettro") | (tipoMossa == "acciaio" & tipoAvv1 == "fuoco") | 
		(tipoMossa == "acqua" & tipoAvv1 == "acqua") | (tipoMossa == "acqua" & tipoAvv1 == "drago") | (tipoMossa == "acqua" & tipoAvv1 == "erba") | 
		(tipoMossa == "buio" & tipoAvv1 == "buio") | (tipoMossa == "buio" & tipoAvv1 == "folletto") | (tipoMossa == "buio" & tipoAvv1 == "lotta") | 
		(tipoMossa == "coleottero" & tipoAvv1 == "acciaio") | (tipoMossa == "coleottero" & tipoAvv1 == "folletto") | (tipoMossa == "coleottero" & tipoAvv1 == "fuoco") | (tipoMossa == "coleottero" & tipoAvv1 == "lotta") | (tipoMossa == "coleottero" & tipoAvv1 == "spettro") | (tipoMossa == "coleottero" & tipoAvv1 == "veleno") | (tipoMossa == "coleottero" & tipoAvv1 == "volante") | 
		(tipoMossa == "drago" & tipoAvv1 == "acciaio") | 
		(tipoMossa == "elettro" & tipoAvv1 == "drago") | (tipoMossa == "elettro" & tipoAvv1 == "elettro") | (tipoMossa == "elettro" & tipoAvv1 == "erba") | 
		(tipoMossa == "erba" & tipoAvv1 == "acciaio") | (tipoMossa == "erba" & tipoAvv1 == "coleottero") | (tipoMossa == "erba" & tipoAvv1 == "drago") | (tipoMossa == "erba" & tipoAvv1 == "erba") | (tipoMossa == "erba" & tipoAvv1 == "fuoco") | (tipoMossa == "erba" & tipoAvv1 == "veleno") | (tipoMossa == "erba" & tipoAvv1 == "volante") | 
		(tipoMossa == "folletto" & tipoAvv1 == "acciaio") | (tipoMossa == "folletto" & tipoAvv1 == "fuoco") | (tipoMossa == "folletto" & tipoAvv1 == "veleno") | 
		(tipoMossa == "fuoco" & tipoAvv1 == "acqua") | (tipoMossa == "fuoco" & tipoAvv1 == "drago") | (tipoMossa == "fuoco" & tipoAvv1 == "fuoco") | (tipoMossa == "fuoco" & tipoAvv1 == "roccia") | 
		(tipoMossa == "ghiaccio" & tipoAvv1 == "acciaio") | (tipoMossa == "ghiaccio" & tipoAvv1 == "acqua") | (tipoMossa == "ghiaccio" & tipoAvv1 == "fuoco") | (tipoMossa == "ghiaccio" & tipoAvv1 == "ghiaccio") | 
		(tipoMossa == "lotta" & tipoAvv1 == "coleottero") | (tipoMossa == "lotta" & tipoAvv1 == "folletto") | (tipoMossa == "lotta" & tipoAvv1 == "psico") | (tipoMossa == "lotta" & tipoAvv1 == "veleno") | (tipoMossa == "lotta" & tipoAvv1 == "volante") | 
		(tipoMossa == "normale" & tipoAvv1 == "acciaio") | (tipoMossa == "normale" & tipoAvv1 == "roccia") | 
		(tipoMossa == "psico" & tipoAvv1 == "acciaio") | (tipoMossa == "psico" & tipoAvv1 == "psico") | 
		(tipoMossa == "roccia" & tipoAvv1 == "acciaio") | (tipoMossa == "roccia" & tipoAvv1 == "lotta") | (tipoMossa == "roccia" & tipoAvv1 == "elettro") | 
		(tipoMossa == "spettro" & tipoAvv1 == "buio") | 
		(tipoMossa == "terra" & tipoAvv1 == "coleottero") | (tipoMossa == "terra" & tipoAvv1 == "erba") | 
		(tipoMossa == "veleno" & tipoAvv1 == "acciaio") | (tipoMossa == "veleno" & tipoAvv1 == "roccia") | (tipoMossa == "veleno" & tipoAvv1 == "spettro") | (tipoMossa == "veleno" & tipoAvv1 == "veleno") | 
		(tipoMossa == "volante" & tipoAvv1 == "acciaio") | (tipoMossa == "volante" & tipoAvv1 == "elettro") | (tipoMossa == "volante" & tipoAvv1 == "roccia")
		)
		{
			rappMossaAvv1 = rappMossaAvv1--;
		}
		else if(
		(tipoMossa == "drago" & tipoAvv1 == "folletto") | 
		(tipoMossa == "elettro" & tipoAvv1 == "terra") | 
		(tipoMossa == "lotta" & tipoAvv1 == "spettro") | 
		(tipoMossa == "normale" & tipoAvv1 == "spettro") | 
		(tipoMossa == "psico" & tipoAvv1 == "buio") | 
		(tipoMossa == "spettro" & tipoAvv1 == "normale") | 
		(tipoMossa == "terra" & tipoAvv1 == "volante") | 
		(tipoMossa == "veleno" & tipoAvv1 == "terra")
		)
		{
			rappMossaAvv1 = -10;
		}
		
		if(
		(tipoMossa == "acciaio" & tipoAvv2 == "folletto") | (tipoMossa == "acciaio" & tipoAvv2 == "ghiaccio") | (tipoMossa == "acciaio" & tipoAvv2 == "roccia") | 
		(tipoMossa == "acqua" & tipoAvv2 == "fuoco") | (tipoMossa == "acqua" & tipoAvv2 == "roccia") | (tipoMossa == "acqua" & tipoAvv2 == "terra") | 
		(tipoMossa == "buio" & tipoAvv2 == "psico") | (tipoMossa == "buio" & tipoAvv2 == "spettro") | 
		(tipoMossa == "coleottero" & tipoAvv2 == "buio") | (tipoMossa == "coleottero" & tipoAvv2 == "erba") | (tipoMossa == "coleottero" & tipoAvv2 == "psico") | 
		(tipoMossa == "drago" & tipoAvv2 == "drago") | 
		(tipoMossa == "elettro" & tipoAvv2 == "acqua") | (tipoMossa == "elettro" & tipoAvv2 == "volante") | 
		(tipoMossa == "erba" & tipoAvv2 == "acqua") | (tipoMossa == "erba" & tipoAvv2 == "roccia") | (tipoMossa == "erba" & tipoAvv2 == "terra") | 
		(tipoMossa == "folletto" & tipoAvv2 == "buio") | (tipoMossa == "folletto" & tipoAvv2 == "drago") | (tipoMossa == "folletto" & tipoAvv2 == "lotta") | 
		(tipoMossa == "fuoco" & tipoAvv2 == "acciaio") | (tipoMossa == "fuoco" & tipoAvv2 == "coleottero") | (tipoMossa == "fuoco" & tipoAvv2 == "erba") | (tipoMossa == "fuoco" & tipoAvv2 == "ghiaccio") | 
		(tipoMossa == "ghiaccio" & tipoAvv2 == "drago") | (tipoMossa == "ghiaccio" & tipoAvv2 == "erba") | (tipoMossa == "ghiaccio" & tipoAvv2 == "terra") | (tipoMossa == "ghiaccio" & tipoAvv2 == "volante") | 
		(tipoMossa == "lotta" & tipoAvv2 == "acciaio") | (tipoMossa == "lotta" & tipoAvv2 == "buio") | (tipoMossa == "lotta" & tipoAvv2 == "ghiaccio") | (tipoMossa == "lotta" & tipoAvv2 == "normale") | (tipoMossa == "lotta" & tipoAvv2 == "roccia") | 
		(tipoMossa == "psico" & tipoAvv2 == "lotta") | (tipoMossa == "psico" & tipoAvv2 == "veleno") | 
		(tipoMossa == "roccia" & tipoAvv2 == "coleottero") | (tipoMossa == "roccia" & tipoAvv2 == "fuoco") | (tipoMossa == "roccia" & tipoAvv2 == "ghiaccio") | (tipoMossa == "roccia" & tipoAvv2 == "volante") | 
		(tipoMossa == "spettro" & tipoAvv2 == "psico") | (tipoMossa == "spettro" & tipoAvv2 == "spettro") | 
		(tipoMossa == "terra" & tipoAvv2 == "acciaio") | (tipoMossa == "terra" & tipoAvv2 == "elettro") | (tipoMossa == "terra" & tipoAvv2 == "fuoco") | (tipoMossa == "terra" & tipoAvv2 == "roccia") | (tipoMossa == "terra" & tipoAvv2 == "veleno") | 
		(tipoMossa == "veleno" & tipoAvv2 == "erba") | (tipoMossa == "veleno" & tipoAvv2 == "folletto") | 
		(tipoMossa == "volante" & tipoAvv2 == "coleottero") | (tipoMossa == "volante" & tipoAvv2 == "erba") | (tipoMossa == "volante" & tipoAvv2 == "lotta")
		)
		{
			rappMossaAvv2 = rappMossaAvv2++;
		}
		else if(
		(tipoMossa == "acciaio" & tipoAvv2 == "acciaio") | (tipoMossa == "acciaio" & tipoAvv2 == "acqua") | (tipoMossa == "acciaio" & tipoAvv2 == "elettro") | (tipoMossa == "acciaio" & tipoAvv2 == "fuoco") | 
		(tipoMossa == "acqua" & tipoAvv2 == "acqua") | (tipoMossa == "acqua" & tipoAvv2 == "drago") | (tipoMossa == "acqua" & tipoAvv2 == "erba") | 
		(tipoMossa == "buio" & tipoAvv2 == "buio") | (tipoMossa == "buio" & tipoAvv2 == "folletto") | (tipoMossa == "buio" & tipoAvv2 == "lotta") | 
		(tipoMossa == "coleottero" & tipoAvv2 == "acciaio") | (tipoMossa == "coleottero" & tipoAvv2 == "folletto") | (tipoMossa == "coleottero" & tipoAvv2 == "fuoco") | (tipoMossa == "coleottero" & tipoAvv2 == "lotta") | (tipoMossa == "coleottero" & tipoAvv2 == "spettro") | (tipoMossa == "coleottero" & tipoAvv2 == "veleno") | (tipoMossa == "coleottero" & tipoAvv2 == "volante") | 
		(tipoMossa == "drago" & tipoAvv2 == "acciaio") | 
		(tipoMossa == "elettro" & tipoAvv2 == "drago") | (tipoMossa == "elettro" & tipoAvv2 == "elettro") | (tipoMossa == "elettro" & tipoAvv2 == "erba") | 
		(tipoMossa == "erba" & tipoAvv2 == "acciaio") | (tipoMossa == "erba" & tipoAvv2 == "coleottero") | (tipoMossa == "erba" & tipoAvv2 == "drago") | (tipoMossa == "erba" & tipoAvv2 == "erba") | (tipoMossa == "erba" & tipoAvv2 == "fuoco") | (tipoMossa == "erba" & tipoAvv2 == "veleno") | (tipoMossa == "erba" & tipoAvv2 == "volante") | 
		(tipoMossa == "folletto" & tipoAvv2 == "acciaio") | (tipoMossa == "folletto" & tipoAvv2 == "fuoco") | (tipoMossa == "folletto" & tipoAvv2 == "veleno") | 
		(tipoMossa == "fuoco" & tipoAvv2 == "acqua") | (tipoMossa == "fuoco" & tipoAvv2 == "drago") | (tipoMossa == "fuoco" & tipoAvv2 == "fuoco") | (tipoMossa == "fuoco" & tipoAvv2 == "roccia") | 
		(tipoMossa == "ghiaccio" & tipoAvv2 == "acciaio") | (tipoMossa == "ghiaccio" & tipoAvv2 == "acqua") | (tipoMossa == "ghiaccio" & tipoAvv2 == "fuoco") | (tipoMossa == "ghiaccio" & tipoAvv2 == "ghiaccio") | 
		(tipoMossa == "lotta" & tipoAvv2 == "coleottero") | (tipoMossa == "lotta" & tipoAvv2 == "folletto") | (tipoMossa == "lotta" & tipoAvv2 == "psico") | (tipoMossa == "lotta" & tipoAvv2 == "veleno") | (tipoMossa == "lotta" & tipoAvv2 == "volante") | 
		(tipoMossa == "normale" & tipoAvv2 == "acciaio") | (tipoMossa == "normale" & tipoAvv2 == "roccia") | 
		(tipoMossa == "psico" & tipoAvv2 == "acciaio") | (tipoMossa == "psico" & tipoAvv2 == "psico") | 
		(tipoMossa == "roccia" & tipoAvv2 == "acciaio") | (tipoMossa == "roccia" & tipoAvv2 == "lotta") | (tipoMossa == "roccia" & tipoAvv2 == "elettro") | 
		(tipoMossa == "spettro" & tipoAvv2 == "buio") | 
		(tipoMossa == "terra" & tipoAvv2 == "coleottero") | (tipoMossa == "terra" & tipoAvv2 == "erba") | 
		(tipoMossa == "veleno" & tipoAvv2 == "acciaio") | (tipoMossa == "veleno" & tipoAvv2 == "roccia") | (tipoMossa == "veleno" & tipoAvv2 == "spettro") | (tipoMossa == "veleno" & tipoAvv2 == "veleno") | 
		(tipoMossa == "volante" & tipoAvv2 == "acciaio") | (tipoMossa == "volante" & tipoAvv2 == "elettro") | (tipoMossa == "volante" & tipoAvv2 == "roccia")
		)
		{
			rappMossaAvv2 = rappMossaAvv2--;
		}
		else if(
		(tipoMossa == "drago" & tipoAvv2 == "folletto") | 
		(tipoMossa == "elettro" & tipoAvv2 == "terra") | 
		(tipoMossa == "lotta" & tipoAvv2 == "spettro") | 
		(tipoMossa == "normale" & tipoAvv2 == "spettro") | 
		(tipoMossa == "psico" & tipoAvv2 == "buio") | 
		(tipoMossa == "spettro" & tipoAvv2 == "normale") | 
		(tipoMossa == "terra" & tipoAvv2 == "volante") | 
		(tipoMossa == "veleno" & tipoAvv2 == "terra")
		)
		{
			rappMossaAvv2 = -10;
		}
		int effMossa = rappMossaAvv1 + rappMossaAvv2;
		
		if(effMossa <= -3)
		{
			Console.WriteLine("La mossa non ha effetto sul Pokémon avversario! Scegline una di tipo diverso.");
			Console.ReadLine();
		}
		else
		{
			switch(effMossa)
			{
				case 2:
					Console.WriteLine("La mossa è superefficace! Danno quadruplicato!");
					Console.ReadLine();
					break;
				
				case 1:
					Console.WriteLine("La mossa è superefficace! Danno raddoppiato!");
					Console.ReadLine();
					break;
				
				case 0:
					Console.WriteLine("La mossa è efficace. La mossa farà esattamente il danno previsto.");
					Console.ReadLine();
					break;
				
				case -1:
					Console.WriteLine("La mossa non è molto efficace. La mossa farà la metà del danno previsto.");
					Console.ReadLine();
					break;
				
				case -2:
					Console.WriteLine("La mossa non è molto efficace. La mossa farà un quarto del danno previsto.");
					Console.ReadLine();
					break;
			}
		}
	}
}