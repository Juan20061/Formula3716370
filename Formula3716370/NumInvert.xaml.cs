namespace Formula3716370;


///<Summary>
///    <Createddate>25/05/2024</Createddate>
///     <company>Practica 8 NET MAUI</company>
///      <lastmodificationdate>26/05/2024</lastmodificationdate>
///     <lastmodificationdescription>
///       Programa que invirte el orden de los numeros 
///        agregados
///      </lastmodificationdescription>
///</Summary>
public partial class NumInvert : ContentPage
{
    /// <summary>
    /// Constructor vacio
    /// </summary>
    public NumInvert()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Guarda los numeros digitados y al presionar el boton invierte el orden de estos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        // Verificar que todas las entradas tengan valores de lo contrario retornara un mensaje de 
        //error
        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text)
            && !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text))
        {
            #region variables  

            double datoA,datoB,datoC,datoD;
            if (Double.TryParse(entry1.Text, out datoA) && Double.TryParse(entry2.Text, out datoB) &&
              (Double.TryParse(entry3.Text, out datoC) && Double.TryParse(entry4.Text, out datoD)))
            {
                datoA = Convert.ToDouble(entry1.Text);
                datoB = Convert.ToDouble(entry2.Text);
                datoC = Convert.ToDouble(entry3.Text);
                datoD = Convert.ToDouble(entry4.Text);
                double[] numeros = { datoA, datoB, datoC, datoD };

                entry5.Text = string.Join(", ", numeros);

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