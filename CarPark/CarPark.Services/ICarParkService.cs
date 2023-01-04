namespace CarPark.Services
{
    public interface ICarParkService
    {
        public int spaceRequest((string story, int number) space);
        public int spaceResponse((string id, string story, int number, string status) space);
        public int checkinResponse((int id, DateTime timestamp) checkin);
        public int checkinRequest((int id, DateTime duration, string price) checkin);
    }
}