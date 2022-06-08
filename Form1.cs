namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblHipotenusa;
    TextBox? txtHipotenusa;
    Label? lblLado;
    TextBox? txtLado;
    Label? lblBase;
    TextBox? txtBase;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;

    public Form1()
    {
        InitializeComponent();
        InicializaComponentes();
        cmbCalculo.SelectedItem="Perimetro";
        cmbFiguras.SelectedItem="Cuadrado";

    }
    private void InicializaComponentes(){
        this.Size = new Size(300,350);
        //Eqtiqueta figura
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10,10);
        //ComboBox figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10,40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValuesChanged);

        //Eqtiqueta calculo
        lblCalculo = new Label();
        lblCalculo.Text = "Calculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150,10);
        //ComboBox calculo
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Perimetro");
        cmbCalculo.Items.Add("Area");
        cmbCalculo.Location = new Point(150,40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValuesChanged);
        
        //Eqtiqueta Base
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10,120);
        lblBase.Visible= false;
        //TextBox base
        txtBase = new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location = new Point(60,115);
        txtBase.Visible = false;

        //Eqtiqueta Altura
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10,80);
        lblAltura.Visible= false;
        //TextBox Altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location = new Point(60,75);
        txtAltura.Visible = false;
        
        //Eqtiqueta Hipotenusa
        lblHipotenusa = new Label();
        lblHipotenusa.Text = "Hipot.";
        lblHipotenusa.AutoSize = true;
        lblHipotenusa.Location = new Point(10,160);
        lblHipotenusa.Visible= false;
        //TextBox Hipotenusa
        txtHipotenusa = new TextBox();
        txtHipotenusa.Size = new Size(100,20);
        txtHipotenusa.Location = new Point(60,155);
        txtHipotenusa.Visible = false;

        //Eqtiqueta Lado
        lblLado = new Label();
        lblLado.Text = "Lado";
        lblLado.AutoSize = true;
        lblLado.Location = new Point(10,200);
        lblLado.Visible= false;
        //TextBox Lado
        txtLado = new TextBox();
        txtLado.Size = new Size(100,20);
        txtLado.Location = new Point(60,195);
        txtLado.Visible = false;

        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location= new Point(170,200);
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

        //Eqtiqueta Resultado
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10,280);
        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location = new Point(70,275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(lblHipotenusa);
        this.Controls.Add(lblLado);
        this.Controls.Add(txtLado);
        this.Controls.Add(txtHipotenusa);
        this.Controls.Add(txtBase);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
    }
    private void cmbCalculo_ValuesChanged(object sender, EventArgs e){
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=false;
                txtBase.Visible=false;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=false;
                txtBase.Visible=false;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=true;
                txtHipotenusa.Visible=true;
                txtLado.Visible=true;
                lblLado.Visible=true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
        }
    }
    private void cmbFiguras_ValuesChanged(object sender, EventArgs e){
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=false;
                txtBase.Visible=false;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                lblLado.Visible=false;
                txtLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=false;
                txtBase.Visible=false;
                lblHipotenusa.Visible=false;
                lblHipotenusa.Visible=false;
                lblLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                lblLado.Visible=false;
                txtLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro"){
                lblAltura.Visible=false;
                txtAltura.Visible=false;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=true;
                txtHipotenusa.Visible=true;
                txtLado.Visible=true;
                lblLado.Visible=true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Area"){
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible=true;
                txtBase.Visible=true;
                lblHipotenusa.Visible=false;
                txtHipotenusa.Visible=false;
                txtLado.Visible=false;
                lblLado.Visible=false;
            }
        }
        
    }

    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo = cmbCalculo.SelectedIndex.ToString();
        int altura = 0;
        int basesita = 0;
        int hipotenusa = 0;
        int lado = 0;
        
        if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Perimetro")
        {
            if (txtAltura.Text != "")
            {
                altura = Convert.ToInt32(txtAltura.Text);
                txtResultado.Text = (altura*4).ToString();
            }    
        }

        if (cmbFiguras.SelectedItem.ToString() == "Cuadrado"&&cmbCalculo.SelectedItem.ToString()=="Area")
        {
            if (txtAltura.Text != "")
            {
                altura = Convert.ToInt32(txtAltura.Text);
                txtResultado.Text = (altura*altura).ToString();
            }    
        }

        if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro")
        {
            if (txtAltura.Text != "" && txtBase.Text != "")
            {
                altura = Convert.ToInt32(txtAltura.Text);
                basesita = Convert.ToInt32(txtBase.Text);
                txtResultado.Text = (2*(altura+basesita)).ToString();
            }
        }

        if (cmbFiguras.SelectedItem.ToString() == "Rectangulo"&&cmbCalculo.SelectedItem.ToString()=="Area")
        {
            if (txtAltura.Text != "" && txtBase.Text != "")
            {
                altura = Convert.ToInt32(txtAltura.Text);
                basesita = Convert.ToInt32(txtBase.Text);
                txtResultado.Text = (basesita*altura).ToString();
            }
        }

        if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Perimetro")
        {
            if (txtLado.Text != "" && txtBase.Text != "" && txtHipotenusa.Text != "")
            {
                lado = Convert.ToInt32(txtLado.Text);
                basesita = Convert.ToInt32(txtBase.Text);
                hipotenusa = Convert.ToInt32(txtHipotenusa.Text);
                txtResultado.Text = (basesita+hipotenusa+lado).ToString();
            }
        }

        if (cmbFiguras.SelectedItem.ToString() == "Triangulo"&&cmbCalculo.SelectedItem.ToString()=="Area")
        {
            if (txtAltura.Text != "" && txtBase.Text != "")
            {
                altura = Convert.ToInt32(txtAltura.Text);
                basesita = Convert.ToInt32(txtBase.Text);
                txtResultado.Text = ((basesita*altura)/2).ToString();
            }
        }
    }
}
