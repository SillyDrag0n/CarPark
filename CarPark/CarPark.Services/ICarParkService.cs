namespace CarPark.Services
{
    public interface ICarParkService
    {
        public int spaceRequest((string story, int number) parkingSpace);
        public int spaceResponse((string id, string story, int number, string status) parkingSpace);
        public int checkinResponse((int id, DateTime timestamp) parkingSpace);
        public int checkinRequest((int id, DateTime duration, string price) parkingSpace);
    }
}