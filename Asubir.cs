using System;
using System.ComponentModel;
using System.Drawing;//de aca se definen atributos de las clases de forms, como la fuente y eso
using System.Windows.Forms;//para poder definir el formulario

public class Form1 : Form // creamos una clase que hereda de windows forms, asi que podemos usar sus propiedades y eso
{
	[STAThread]
	public static void Main() //en el metodo Main que es el que se busca para ejecutar se agregan en el .Run el Form1() que creamos
	{
 	 Application.EnableVisualStyles();
 	 Application.Run(new Form1());
	}

	public Label label1; //inicializamos  formas que queremos agregar
	public Label label2;
	public Label label3;
	public Label label4;
	public Label label5;
	public Label label6;
	public Label label7;
	public TextBox textBox1;
	public DateTimePicker dateTimePicker1;
	public ComboBox comboBox1;
	public CheckBox checkBox1;
	public CheckBox checkBox2;
	public CheckBox checkBox3;
	public Button button1;
	public Panel panel1;


	public Form1() // creamos el metodo Form1() o el formulario
	{
		this.Text = "Form1"; //agregamos el titulo a este formulario
		label1 = new Label(); //creamos el objeto de la clase de la forma que deseamos en este caso label()
		label1.Size = new Size(250,20); // definimos el atributo del tamaño mediante la creacion de un objeto que utiliza el metodo Size, donde l priemr parametro es el ancho , y el segundo la altura
		label1.Location = new Point(50,10);// definimos el atributo de la localizacion mediante la creacion de un objeto que utiliza el metodo Point con parametros de dsitancia en x de 60 y distancia en y(desde arriba del formulario) en 10
		label1.Text="Formulario desde consola";// definimos el atributo del texto que queremos que se muestre .
		label1.Font = new Font("Matura MT Script Capitals",13F);// definimos el atributo de la fuente mediante el objeto que utiliza el metodo Font donde de aparametros le decimos el nombre del a fuente y despues el tamaño de esa fuente
		this.Controls.Add(label1); // importante este, para poder agregar la forma que creamos al formulario, son esta linea correria epro no se mostraria nada.
		
		label2 = new Label(); 
		label2.Size = new Size(100,20); 
		label2.Location = new Point(20,70);
		label2.Text="Nombre de Cliente";
		this.Controls.Add(label2);

		
		label3 = new Label(); 
		label3.Size = new Size(40,20); 
		label3.Location = new Point(20,40);
		label3.Text="Fecha";
		this.Controls.Add(label3);

		textBox1 = new TextBox(); // repetimos el procedimiento con cualquier forma
                textBox1.Location = new Point(20,90);
		textBox1.Size = new Size(120,40);
		this.Controls.Add(textBox1);

		dateTimePicker1 = new DateTimePicker();
		dateTimePicker1.Location = new Point(60,40);
		dateTimePicker1.Size = new Size(160,5);
		this.Controls.Add(dateTimePicker1);

		label4 = new Label(); 
		label4.Size = new Size(100,20); 
		label4.Location = new Point(160,70);
		label4.Text="Tipo de prenda";
		this.Controls.Add(label4);
		
		comboBox1 = new ComboBox();
		comboBox1.Location = new Point(160,90);
		comboBox1.Size = new Size(100,40);
		comboBox1.Items.AddRange(new object[] {"Camiseta", // se agregan los elemtos a la combo box que queremos mostrar
                       "Pantalon",
                       "Gorra",
                       "Zapatos",
                       "Interiores",
		       ""}); // ponemos un valor vacio para que despues coja este al hacer click para un nuevo registro
		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // definimos que la combobox solo pueda ser una lista y no se pueda copir ningun texto encima por parte del usuario
		this.Controls.Add(comboBox1);

		panel1 = new Panel();
		panel1.Size = new Size(240,130); 
		panel1.Location = new Point(20,120);
		panel1.BorderStyle = BorderStyle.Fixed3D; // es necesario ponerle borde para que podamos realmente observarlo si no estar presente pero no nos daremos cuenta en dodne esta puesto
		this.Controls.Add(panel1);
		
		checkBox1 = new CheckBox();
		checkBox1.Location = new Point(75,10); // la ubicacion se hace respecto al panel
		checkBox1.Size = new Size(25,25); 
		panel1.Controls.Add(checkBox1); // agregamos las figuras al panel

		label5 = new Label(); 
		label5.Size = new Size(60,30); 
		label5.Location = new Point(20,10);
		label5.Text="¿Cliente antiguo?";
		panel1.Controls.Add(label5);
		
		checkBox2 = new CheckBox();
		checkBox2.Location = new Point(75,50); // la ubicacion ase hace respecto al panel
		checkBox2.Size = new Size(25,25); 
		panel1.Controls.Add(checkBox2); // agregamos las figuras al panel

		label6 = new Label(); 
		label6.Size = new Size(60,30); 
		label6.Location = new Point(20,50);
		label6.Text="¿Paga en efectivo?";
		panel1.Controls.Add(label6);

		checkBox3 = new CheckBox();
		checkBox3.Location = new Point(75,90); // la ubicacion ase hace respecto al panel
		checkBox3.Size = new Size(25,25); 
		panel1.Controls.Add(checkBox3); // agregamos las figuras al panel

		label7 = new Label(); 
		label7.Size = new Size(60,30); 
		label7.Location = new Point(20,90);
		label7.Text="¿Aplica Puntos?";
		panel1.Controls.Add(label7);

		button1 = new Button(); 
    		button1.Size = new Size(75, 75); 
   		button1.Location = new Point(130, 25);
   		button1.Text = "Ingresar Datos";
   		panel1.Controls.Add(button1);
			
		//string estado ="";
		//string pago="";
		//string puntos="";		

		
		//checkBox2.Checked==true	? pago= "Pago en efectivo" : pago= "pago diferente a efectivo";
		//checkBox3.Checked==true ? puntos= "aplica puntos" : puntos= "No aplica puntos";

		button1.Click += new EventHandler(button1_Click); // añadimos el control para que se active el metodo "button1_Click" al hacer click en el boton
		
		
	}

	private void button1_Click(object sender, EventArgs e)// se define un metodo de evento click que al ser este llamado realizara lo que pongamos en el cuerpo
	
	{
		//+ "y hace el "+pago +"y "+ puntos

		string estado = "";
		if(checkBox1.Checked == true){ 
			estado = estado +"cliente antiguo" ;
		}
		else{
			estado = estado +"cliente nuevo" ;
		}
	
		string pago = "";
		if(checkBox1.Checked == true){ 
			pago =  pago + "pago en efectivo" ;
		}
		else{
			pago =  pago + "pago diferente a efectivo" ;
		}

		string puntos = "";
		if(checkBox1.Checked == true){ 
			puntos = puntos + "gana puntos" ;
		}
		else{
			puntos = puntos + "no gana puntos" ;
		}

		MessageBox.Show(" los datos ingresados fueron cliente "+textBox1.Text + " la fecha  " + dateTimePicker1.Text+ " el tipo de prenda que es cogio es " + comboBox1.Text + " es un " + estado + " y hace el " + pago + " y "+ puntos );
		MessageBox.Show(" Tenga buen dia" );

		textBox1.Text = ""; //vacie la textbox
		comboBox1.Text = ""; // vacie la combo box
		checkBox1.Checked=false; // le decimos que quite los check de las checkbox
		checkBox2.Checked=false;
		checkBox3.Checked=false;
	}
	

}