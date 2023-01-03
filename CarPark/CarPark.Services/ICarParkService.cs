namespace CarPark.Services
{
    public interface ICarParkService
    {
        public int createParkingSpace((int, int) parkingSpace);
        public int updateParkingSpace((int, int) parkingSpace);
        public int deleteParkingSpace((int, int) parkingSpace);
    }
}