using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GamesAlex
{
    internal class VideojuegoRepository
    {
        //Hola maestro, a todo el codigo le puse comentarios para que se pueda entender mejor, espero que no se vea feo con mucho comentario que le puse 

        //Aqui uso el patron de diseño Repository (que es como un intermediario mi base de datos y mi forms


        //Esta variable representa la colección en MongoDB
        private readonly IMongoCollection<Videojuego> _collection;

        //Al crear el Repositorio, nos conectamos a la colección "Inventario"
        public VideojuegoRepository()
        {
            //Usamos nuestra la clase "Conexión" para obtener la conexión
            var database = Conexion.GetDatabase();
            _collection = database.GetCollection<Videojuego>("Inventario");
        }

        //Metodo para agregar
        public string Insertar(Videojuego juego)
        {
            //Buscamos si ya existe uno con mismo nombre Y plataforma
            var existe = _collection.Find(x => x.Nombre == juego.Nombre && x.Plataforma == juego.Plataforma).FirstOrDefault();

            if (existe != null)
            {
                //Si lo encuentra, detiene todo y avisa que ya existe
                return "El videojuego ya existe en esta plataforma.";
            }

            //Si no existe, lo guarda en la base de datos
            _collection.InsertOne(juego);
            return "¡Agregado con éxito!";
        }

        //Metodo para verlos a todos
        public List<Videojuego> ObtenerTodos()
        {
            //Traemos todos los documentos de la colección y los convertimos en una lista
            return _collection.Find(_ => true).ToList();
        }

        //Método para eliminar
        public void Eliminar(string id)
        {
            //Busca el documento por su ID único y lo borra
            _collection.DeleteOne(x => x.Id == id);
        }

        //Método para actualizar
        public string Actualizar(Videojuego juego)
        {
            //Verificamos que al cambiar el nombre, no choque con otro juego igual
            var existe = _collection.Find(x => x.Nombre == juego.Nombre &&
                                               x.Plataforma == juego.Plataforma &&
                                               x.Id != juego.Id).FirstOrDefault();

            if (existe != null)
            {
                return "Error: Ya existe otro registro con ese nombre y plataforma.";
            }

            //Reemplazamos los datos viejos por los nuevos usando el ID
            _collection.ReplaceOne(x => x.Id == juego.Id, juego);
            return "¡Actualizado con éxito!";
        }
    }
}
