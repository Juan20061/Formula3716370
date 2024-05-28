namespace Formula3716370;

/// <summary>
/// Clase que abarca todos los eventos y herencia al Contentpage del cs
/// </summary>
public partial class Suma : ContentPage
{
	/// <summary>
	/// Constructor 
	/// </summary>
	public Suma()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Buton que toma los numeros digitados en los entry y los suma, 
	/// tanto los 2 numeros y el resultados se almacena en una variable 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		//Condicionador que retorna un mensaje de error si no se han ingresado todas las variables
		if(!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text)) 
		{

            #region Variables y Funcion
            double resultado, datoa, datob;
			
            if (Double.TryParse(entry1.Text, out datoa)&& Double.TryParse(entry2.Text, out datob))
			{
                datoa = Convert.ToDouble(entry1.Text);
                datob = Convert.ToDouble(entry2.Text);
                resultado = datob + datoa;
                entry3.Text = resultado.ToString();
			}
			else
			{
				DisplayAlert("Error","No es valido el ingreso de letras solo de numeros","OK");
			}
			
            #endregion
        }
        else
		{
			DisplayAlert("Error", "Introduce todos los numeros","ojk");
		}
    }
}