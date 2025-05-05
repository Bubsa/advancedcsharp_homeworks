namespace Generichki_i_Ekstenzivni_Metodi.Entities.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
