using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace GamesAlex
{
    public partial class Form1 : Form
    {

        //Hola maestro, a todo el codigo le puse comentarios para que se pueda entender mejor, espero que no se vea feo con mucho comentario que le puse 
        public Form1()
        {
            InitializeComponent();
        }

        //Variable global para el repositorio
        VideojuegoRepository repo = new VideojuegoRepository();

        // Función para actualizar la tabla con los juegos
        public void ActualizarTabla()
        {
            //Pedimos los datos al repositorio
            var lista = repo.ObtenerTodos();

            //Evitamos que Windows Forms cree columnas extras a la derecha,
            //para que no ponga una columna extra de "id" al final 
            Inventario.AutoGenerateColumns = false;

            //Refrescamos la lista
            Inventario.DataSource = null;
            Inventario.DataSource = lista;

            //Ocultamos el ID de MongoDB para que no se vea en la tabla
            if (Inventario.Columns["Id"] != null)
                Inventario.Columns["Id"].Visible = false;
        }



        //Boton para agregar videojuego
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validamos que Nombre, Plataforma y Categoría tengan selección/texto
            if (string.IsNullOrWhiteSpace(Nom.Text) ||
                Pla.SelectedIndex == -1 ||
                Cat.SelectedIndex == -1)
            {
                //Si falta algo, avisamos al usuario y detenemos el proceso
                MessageBox.Show("Por favor, completa todos los campos (Nombre, Plataforma y Categoría).");
                return;
            }

            //Aquí usamos la "plantilla/clase" Videojuego para guardar lo que el usuario escribió en la pantalla.
            var nuevo = new Videojuego
            {
                Nombre = Nom.Text,
                Plataforma = Pla.Text,
                Precio = (double)Pre.Value,
                Stock = (int)Sto.Value,
                Categoria = Cat.Text
            };

            //Le damos los datos del videojuego, para que se inserte en Inventario
            string resultado = repo.Insertar(nuevo);
            MessageBox.Show(resultado);


            //Si todo salió bien, refrescamos la tabla para ver el nuevo juego y limpiamos los cuadros de texto.
            if (resultado == "¡Agregado con éxito!")
            {
                ActualizarTabla();
                btnLimpiar_Click(null, null); //Reutilizamos el botón de limpiar para dejar todo listo para el siguiente juego
            }
        }


        //Boton para actualizar videojuego
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Revisamos si el campo invisible 'txtId' tiene datos. Si está vacío, 
            //significa que el usuario no ha hecho clic en ninguna fila de la tabla.
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona un videojuego de la tabla para actualizar.");
                return;
            }

            //Nos aseguramos de que no hayan borrado el nombre o la plataforma antes de guardar.
            if (string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Pla.Text))
            {
                MessageBox.Show("Nombre y Plataforma no pueden estar vacíos.");
                return;
            }

            //Creamos un objeto con los datos que están actualmente en los cuadros de texto.
            var juegoEditado = new Videojuego
            {
                Id = txtId.Text, //Aquí usamos el ID guardado, para poder identificar al juego
                Nombre = Nom.Text,
                Plataforma = Pla.Text,
                Precio = (double)Pre.Value,
                Stock = (int)Sto.Value,
                Categoria = Cat.Text
            };

            //Reemplazamos los datos en la base de datos.
            string resultado = repo.Actualizar(juegoEditado);
            MessageBox.Show(resultado);

            if (resultado == "¡Actualizado con éxito!")
            {
                ActualizarTabla(); //Actualizamos la tabla
                btnLimpiar_Click(null, null); //Limpiamos todo
                btnAgregar.Enabled = true; //Activamos el boton de agregar
            }
        }


        //Boton para limpiar

        //Simplemente limpiamos los campos y quitar el color si hay alguna fila seleccionada
        //Asi como volver a activar el boton agregar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            Nom.Clear();
            txtId.Clear(); 
            Pla.SelectedIndex = -1;
            Cat.SelectedIndex = -1;
            Pre.Value = 0;
            Sto.Value = 0;
            btnAgregar.Enabled = true;
            Inventario.ClearSelection();

            Nom.Focus();
        }

        //Boton para buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verificamos que el usuario haya escrito algo en el nombre y seleccionado una plataforma.
            if (string.IsNullOrWhiteSpace(BuscarNom.Text) || BuscarPla.SelectedIndex == -1)
            {
                MessageBox.Show("Debes ingresar un nombre y seleccionar una plataforma para buscar.");
                return;
            }


            //Convertimos el texto a minúsculas para que no importe si escriben con mayúsculas
            string nombreBusqueda = BuscarNom.Text.ToLower();
            string plataformaBusqueda = BuscarPla.Text;


            // Variable para saber si tuvimos éxito
            bool encontrado = false;


            //Revisamos cada una de las filas que tiene mi inventario
            foreach (DataGridViewRow fila in Inventario.Rows)
            {
                //Validamos que la fila no esté vacía
                if (fila.Cells["Nombre"].Value != null && fila.Cells["Plataforma"].Value != null)
                {
                    string nombreFila = fila.Cells["Nombre"].Value.ToString().ToLower();
                    string plataformaFila = fila.Cells["Plataforma"].Value.ToString();

                    //Si el nombre de la fila contiene lo que buscamos Y la plataforma es exacta
                    if (nombreFila.Contains(nombreBusqueda) && plataformaFila == plataformaBusqueda)
                    {
                        // Pintamos la fila de color azul cielo para que resalte
                        fila.DefaultCellStyle.BackColor = Color.SkyBlue;
                        fila.DefaultCellStyle.ForeColor = Color.Black;

                        //Hace scroll automático hasta la fila encontrada
                        Inventario.FirstDisplayedScrollingRowIndex = fila.Index;
                        encontrado = true;
                    }
                    else
                    {
                        //Resetea el color de las que no coinciden
                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }

            //Mensaje de error si no hubo coincidencias
            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún videojuego con esos criterios.");
            }
        }


        //Boton para eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay al menos una fila seleccionada
            if (Inventario.SelectedRows.Count > 0)
            {
                // Obtenemos el Videojuego de la fila seleccionada
                var juegoSeleccionado = (Videojuego)Inventario.SelectedRows[0].DataBoundItem;
                DataGridViewRow fila = Inventario.SelectedRows[0];

                if (juegoSeleccionado != null)
                {
                    //Pintar de rojo y preguntar (usamos los datos del objeto)
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.ForeColor = Color.White;

                    DialogResult primeraConfirmacion = MessageBox.Show(
                        $"¿Estás seguro de que quieres eliminar {juegoSeleccionado.Nombre}?",
                        "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (primeraConfirmacion == DialogResult.Yes)
                    {
                        //Segunda confirmación
                        DialogResult segundaConfirmacion = MessageBox.Show(
                            "Esta acción es permanente. ¿Confirmas la eliminación definitiva?",
                            "CONFIRMACIÓN FINAL", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                        if (segundaConfirmacion == DialogResult.Yes)
                        {
                            //Usamos el Id del objeto directamente
                            repo.Eliminar(juegoSeleccionado.Id);
                            MessageBox.Show("Videojuego eliminado del inventario.");
                            ActualizarTabla();
                            btnLimpiar_Click(null, null);
                        }
                        else
                        {
                            //Si dice que no, quitamos el color rojo
                            fila.DefaultCellStyle.BackColor = Color.White;
                            fila.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        //Si dice que no, quitamos el color rojo
                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                //Si no seleccionó nada, le avisamos.
                MessageBox.Show("Por favor, selecciona una fila en la tabla primero.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Siempre que se abra el programa, la tabla ya tendra los datos que tiene la coleccion
            ActualizarTabla();

            //Bloqueamos que escriban cosas que no deberian en el precio y el stock
            Pre.InterceptArrowKeys = true;
            Sto.InterceptArrowKeys = true;

            //Si el usuario escribe algo inválido, el control regrese al valor mínimo (0)
            Pre.Value = 0;
            Sto.Value = 0;
        }

        private void Inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validamos que el clic sea en una fila con datos (y no en el encabezado)
            if (e.RowIndex >= 0)
            {
                //Obtenemos el Videojuego de esa fila
                var juegoSeleccionado = (Videojuego)Inventario.Rows[e.RowIndex].DataBoundItem;

                if (juegoSeleccionado != null)
                {
                    //Guardamos el Id de forma secreta 
                    txtId.Text = juegoSeleccionado.Id;

                    //Llenamos todos los campos del formulario con los datos del juego.
                    Nom.Text = juegoSeleccionado.Nombre;
                    Pla.Text = juegoSeleccionado.Plataforma;
                    Pre.Value = (decimal)juegoSeleccionado.Precio;
                    Sto.Value = juegoSeleccionado.Stock;
                    Cat.Text = juegoSeleccionado.Categoria;

                    //Deshabilitamos el botón "Agregar" para evitar crear un duplicado por error.
                    //Así obligamos al usuario a usar el botón de "Actualizar".
                    btnAgregar.Enabled = false;
                }
            }
        }



        //Detallitos que agregue para hacer mas logico y funcional el programa
        private void Sto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitimos números (Char.IsDigit) y la tecla de borrar (Control)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla (no deja que se escriba)
            }
        }

        private void Pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números y teclas de control (borrar)
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }

            // Si presiona el punto, revisamos que no exista otro ya puesto
            if (e.KeyChar == '.')
            {
                // Si ya hay un punto en el texto, bloqueamos este nuevo punto
                if (Pre.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                // Bloqueamos cualquier otra cosa (incluyendo el signo menos '-')
                e.Handled = true;
            }
        }

        private void Sto_Leave(object sender, EventArgs e)
        {
            // Al salir del cuadro, forzamos que el valor se refresque
            // El control NumericUpDown automáticamente elimina los ceros a la izquierda al procesar el Value
            Sto.Value = Sto.Value;
        }

        private void Pre_Leave(object sender, EventArgs e)
        {
            // Esto obliga al control a re-formatear el texto
            // Ejemplo para que se entienda lo que dije: Si escribieron 000120.23, al salir se verá 120.23
            Pre.Value = Pre.Value;
        }
    }
}
