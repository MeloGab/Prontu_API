namespace Prontu_API.Models.Response
{
    public class Response<T>
    {
        public T? Date { get; set; }
        public string Mensage { get; set; } = String.Empty;
        public bool Status { get; set; } = true;
    }
}
