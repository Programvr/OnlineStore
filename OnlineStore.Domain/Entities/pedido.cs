namespace OnlineStore.Domain.Entities
{
    public class Pedido
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Pedido(string descripcion)
        {
            Descripcion = descripcion;
            Estado = "PENDIENTE";
        }

        public void CompletarPedido()
        {
            Estado = "COMPLETADO";
        }
    }
}
