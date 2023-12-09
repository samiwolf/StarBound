using StarBound.Models.Dto;

namespace StarBound.Data
{
    public static class StarShipStore
    {
        public static List<StarShipDto> starShipList = 
            new List<StarShipDto>
            {    
                new StarShipDto {Id=1, Name="Explorer"},
                new StarShipDto {Id=2, Name="Rover"},
                new StarShipDto {Id=3, Name="Wanderer"}
            };
    }
}