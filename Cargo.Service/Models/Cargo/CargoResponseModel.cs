namespace Cargo.Service.Models.Cargo
{
    public class CargoResponseModel
    {
        public int Id { get; set; }
        public string ConsignataryName { get; set; }
        public string ConsignatarySurname { get; set; }
        public string ConsignataryAddress { get; set; }
        public string ConsignataryPhoneNumber { get; set; }

        public string ShipperName { get; set; }
        public string ShipperSurname { get; set; }
        public string ShipperAddress { get; set; }
        public string ShipperPhoneNumber { get; set; }

        public int? TypeId { get; set; }
    }
}
