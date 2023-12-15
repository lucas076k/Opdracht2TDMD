namespace HueApp;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();

		collectionView.ItemsSource = GetCountries();
		//collectionView.ItemsSource = new List<Country>();
	}

	private List<Country> GetCountries()
	{
		return new List<Country>
		{
			new Country{ CountryName = "United States", IsoCode = "USA", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.britannica.com%2F33%2F4833-004-828A9A84%2FFlag-United-States-of-America.jpg&tbnid=9_fGmcqEwb07VM&vet=12ahUKEwjC46KSg_uCAxWNi_0HHRVLATEQMygAegQIARBR..i&imgrefurl=https%3A%2F%2Fwww.britannica.com%2Ftopic%2Fflag-of-the-United-States-of-America&docid=BbtEgbitYlyayM&w=800&h=416&q=usa%20flag&ved=2ahUKEwjC46KSg_uCAxWNi_0HHRVLATEQMygAegQIARBR"},
			new Country{ CountryName = "Canada", IsoCode = "CAN", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fd%2Fd9%2FFlag_of_Canada_%2528Pantone%2529.svg%2F255px-Flag_of_Canada_%2528Pantone%2529.svg.png&tbnid=D4CGdmwbdIuQZM&vet=12ahUKEwjNid3Cg_uCAxVsiP0HHaBkAVQQMygAegQIARBS..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_Canada&docid=wnrQLybKH7cqKM&w=255&h=128&q=canada%20flag&ved=2ahUKEwjNid3Cg_uCAxVsiP0HHaBkAVQQMygAegQIARBS"},
			new Country{ CountryName = "United Kingdom", IsoCode = "UK", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fa%2Fa5%2FFlag_of_the_United_Kingdom_%25281-2%2529.svg%2F255px-Flag_of_the_United_Kingdom_%25281-2%2529.svg.png&tbnid=C7PTB2xVC1S-tM&vet=12ahUKEwi1_qj7g_uCAxVNjf0HHbDDASYQMygAegQIARBO..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_the_United_Kingdom&docid=tnCmFGNKCq54gM&w=255&h=128&q=uk%20flag&ved=2ahUKEwi1_qj7g_uCAxVNjf0HHbDDASYQMygAegQIARBO"},
			new Country{ CountryName = "Germany", IsoCode = "DEU", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2Fb%2Fba%2FFlag_of_Germany.svg%2F1200px-Flag_of_Germany.svg.png&tbnid=eGPpZv3LXCAx7M&vet=12ahUKEwjnwY6hhPuCAxUthP0HHWFqDSEQMygAegQIARBK..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_Germany&docid=hr0hpZMrkMGl8M&w=1200&h=720&itg=1&q=germany%20flag&ved=2ahUKEwjnwY6hhPuCAxUthP0HHWFqDSEQMygAegQIARBK"},
			new Country{ CountryName = "Australia", IsoCode = "AUS", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb9%2FFlag_of_Australia.svg%2F1280px-Flag_of_Australia.svg.png&tbnid=v3seyTY1meAPZM&vet=12ahUKEwj-163BhPuCAxU9yAIHHUDoCiQQMygAegQIARBN..i&imgrefurl=https%3A%2F%2Fnl.m.wikipedia.org%2Fwiki%2FBestand%3AFlag_of_Australia.svg&docid=UBC8DEgTPxKaHM&w=1280&h=640&q=australia%20flag&ved=2ahUKEwj-163BhPuCAxU9yAIHHUDoCiQQMygAegQIARBN"},
			new Country{ CountryName = "France", IsoCode = "FRA", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2Fc%2Fc3%2FFlag_of_France.svg%2F800px-Flag_of_France.svg.png&tbnid=bZGzX-8Zim-6uM&vet=12ahUKEwiak6jjhPuCAxXD5wIHHRRdBJEQMygAegQIARBM..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_France&docid=UKv18rECULhF4M&w=800&h=533&q=france%20flag&ved=2ahUKEwiak6jjhPuCAxXD5wIHHRRdBJEQMygAegQIARBM"},
			new Country{ CountryName = "Italy", IsoCode = "ITA", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2F0%2F03%2FFlag_of_Italy.svg%2F220px-Flag_of_Italy.svg.png&tbnid=hd2gf1gaADd8jM&vet=12ahUKEwjmlNGUhfuCAxUQiP0HHUHdCmkQMygAegQIARBO..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_Italy&docid=jux9eKOMuj3rJM&w=220&h=147&q=italy%20flag&ved=2ahUKEwjmlNGUhfuCAxUQiP0HHUHdCmkQMygAegQIARBO"},
			new Country{ CountryName = "Sweden", IsoCode = "SWE", FlagUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2F4%2F4c%2FFlag_of_Sweden.svg%2F1200px-Flag_of_Sweden.svg.png&tbnid=GvyE5HXyHyH1yM&vet=12ahUKEwjZ2MiyhfuCAxWJ7rsIHfAWA6gQMygAegQIARBQ..i&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFlag_of_Sweden&docid=5E9DUlRP-_QJpM&w=1200&h=750&q=sweden%20flag&ved=2ahUKEwjZ2MiyhfuCAxWJ7rsIHfAWA6gQMygAegQIARBQ"}
		};
	}
}