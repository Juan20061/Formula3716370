namespace Formula3716370;

/// <summary>
/// Clase con todos los eventos y variables 
/// </summary>
public partial class Expresion : ContentPage
{
    /// <summary>
    /// Constructor de la clase vacio
    /// </summary>
	public Expresion()
	{
		InitializeComponent();
	}


    /// <summary>
    /// Boton con la funcion de retornar la respuesta de una expresion matematica 
    /// por medio de 2 variables que contienen el numero y es nesario digitar los 2 numeros de lo contrario 
    /// retornara un mensaje de error 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
        {
            #region Variables y funcion
            double num1, num2, expresion;
            if (Double.TryParse(entry1.Text, out num1) && Double.TryParse(entry2.Text, out num2) &&
             (Double.TryParse(entry3.Text, out expresion)))
            {
                //declaracion de varibles y logica de la funcion que tendran
                num1 = Convert.ToDouble(entry1.Text);
                num2 = Convert.ToDouble(entry2.Text);
                expresion = Convert.ToDouble(entry3.Text);

                expresion = Math.Pow(num1 + num2, 2) / 2;

                entry3.Text = expresion.ToString();

            }
            else
            {
                DisplayAlert("Error", "No es valido el ingreso de letras solo de numeros", "OK");
            }

            #endregion
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "OK");
        }
    }
}