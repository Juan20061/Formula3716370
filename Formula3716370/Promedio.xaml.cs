namespace Formula3716370;

/// <summary>
///  clase que abarca t
/// </summary>
public partial class Promedio : ContentPage
{
    /// <summary>
    /// Constructor de la clase promedio
    /// </summary>
	public Promedio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento que calcula el promedio sumando y diviendo todas las notas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {

        // codigo que pide que todos los entry esten completos para realizar el calculo de lo contrario mandara un mensaje de error
        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text) &&
            !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text)&&!string.IsNullOrEmpty(entry5.Text))
        {
            #region Variables y funcion
            double nota1, nota2, nota3, nota4, nota5, promedio;
            if (Double.TryParse(entry1.Text, out nota1) && Double.TryParse(entry2.Text, out nota2) &&
               (Double.TryParse(entry3.Text, out nota3) && Double.TryParse(entry4.Text, out nota4)))
            {
                // cada variable declarada se sumara y divira entre 5 para retornar el resultado del promedio de las notas 
                 nota1 = Convert.ToDouble(entry1.Text);
                 nota2 = Convert.ToDouble(entry2.Text);
                 nota3 = Convert.ToDouble(entry3.Text);
                 nota4 = Convert.ToDouble(entry4.Text);
                 nota5 = Convert.ToDouble(entry5.Text);
                 promedio = Convert.ToDouble(entry5.Text);
                promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                entry6.Text = promedio.ToString();
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