namespace Formula3716370;
/// <summary>
/// clase que herada del ContentPage que pertenece al xmal 
/// </summary>
public partial class Cuadrado : ContentPage
{
    /// <summary>
    /// Costructor vacio de la clase
    /// </summary>
	public Cuadrado()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Calcula el cuadrado y el cubo de un numero positivo 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {

        // es de ingresar un numeros para el calculo de lo contrario enviara un mensaje de error
        if (!string.IsNullOrEmpty(entry1.Text))
        {

            #region Variables y funciones
            double num1, calculo, cubo;

            if (Double.TryParse(entry1.Text, out num1) && Double.TryParse(entry2.Text, out calculo) &&
              (Double.TryParse(entry3.Text, out cubo)))
            {
                // se declara 3 varaibles una que tendra el numero y las otras que realizaran el calculo y lo guardaran
                num1 = Convert.ToDouble(entry1.Text);
                calculo = Convert.ToDouble(entry2.Text);
                cubo = Convert.ToDouble(entry3.Text);


                calculo = (num1 * num1);
                cubo = (num1) * (num1) * (num1);


                entry2.Text = calculo.ToString();
                entry3.Text = cubo.ToString();

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