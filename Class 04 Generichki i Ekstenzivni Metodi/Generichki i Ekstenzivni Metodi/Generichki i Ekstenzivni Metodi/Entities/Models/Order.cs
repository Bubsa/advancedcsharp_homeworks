namespace Generichki_i_Ekstenzivni_Metodi.Entities.Models
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"{Id}) {Receiver} - {Address}";
        }
    }
}
