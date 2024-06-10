namespace OnlineStore.Domain.Entities
{
    
    /// Representa un Pedido en el dominio del negocio.
    
    public class Pedido
    {
        
        /// Identificador único del Pedido.
        
        public long Id { get; set; }

        
        /// Descripción del Pedido.
        
        public string Descripcion { get; set; }

        
        /// Estado actual del Pedido.
        
        public string Estado { get; set; }

        
        /// Inicializa una nueva instancia de la clase Pedido con una descripción dada.
        
        /// Descripción del Pedido.
        public Pedido(string descripcion)
        {
            Descripcion = descripcion;
            Estado = "PENDIENTE"; // Al iniciar, el pedido está pendiente.
        }

        
        /// Marca el Pedido como completado.
        
        public void CompletarPedido()
        {
            Estado = "COMPLETADO";
        }
    }
}
