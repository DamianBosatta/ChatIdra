namespace ChatTP.DTO.Response
{
    public class RoomResponse
    {
        public int id { get; set; }
        public string? NameRoom { get; set; }
        public int idUserRoom { get; set; }
        public virtual ICollection<MessaggeResponse>? Messages { get; set; }

    }
}
