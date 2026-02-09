using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GamesAlex
{
    internal class Conexion
    {
        //Hola maestro, a todo el codigo le puse comentarios para que se pueda entender mejor, espero que no se vea feo con mucho comentario que le puse 


        //Aqui uso el patron de diseño Singleton (para la conexión)


        //Esta variable guarda la conexión de forma global para que no se abra una nueva cada vez
        private static IMongoDatabase _database;
        //Este es un "candado" de seguridad para que, si el programa hace dos cosas a la vez, 
        //no intente crear dos conexiones al mismo tiempo
        private static readonly object _lock = new object();

        private Conexion() { }


        //Metodo para obtener la base de datos
        public static IMongoDatabase GetDatabase()
        {
            //Si ya esta conectado, nos saltamos todo y la entregamos
            if (_database == null)
            {
                //Ponemos el "candado" para que no se hagan mas de un proceso al mismo tiempo
                lock (_lock)
                {
                    //Volvemos a confirmar si esta conectado (por si otra parte del programa la creó mientras esperábamos el "candado")
                    if (_database == null)
                    {
                        //Configuramos el cliente a mi servidor local de MongoDB
                        var client = new MongoClient("mongodb://localhost:27017");
                        //Le decimos a qué base de datos queremos entrar (GameAlex)
                        _database = client.GetDatabase("GameAlex");
                    }
                }
            }
            //Entregamos la conexión lista para usarse
            return _database;
        }
    }
}
