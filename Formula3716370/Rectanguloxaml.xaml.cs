namespace Formula3716370;

/// <summary>
/// clase que abarca toos los eventos 
/// </summary>
public partial class Rectanguloxaml : ContentPage
{
    /// <summary>
    /// Constructor vacio de la clase
    /// </summary>
	public Rectanguloxaml()
	{
		InitializeComponent();
	}

    /// <summary>
    ///  Segun la base y altura que escriba el boton al ser ejecutado mostrara los resultados del perimetro y la base
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {

            double Base, Altura, perimetro, superficie;
           

            if (Double.TryParse(entry1.Text, out Base) && Double.TryParse(entry2.Text, out Altura)&&
                (Double.TryParse(entry3.Text, out perimetro) && Double.TryParse(entry4.Text, out superficie)))
            {
                Base = Convert.ToDouble(entry1.Text);
                Altura = Convert.ToDouble(entry2.Text);
                perimetro = Convert.ToDouble(entry3.Text);
                superficie = Convert.ToDouble(entry4.Text);

                perimetro = 2 * (Base + Altura);

                entry3.Text = perimetro.ToString();


                superficie = Base * Altura;
                entry4.Text = superficie.ToString();

                DisplayAlert("Resultados", $"El perímetro del rectángulo es: {perimetro}\nLa superficie del rectángulo es: {superficie}", "OK");

            }
            else
            {
                DisplayAlert("Error", "No es valido el ingreso de letras solo de numeros", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "OK");
        }
    }
}