using AutoMapper;
using CinemaProject.Halls;
using CinemaProject.Seats;

namespace CinemaProject;

public class CinemaProjectApplicationAutoMapperProfile : Profile
{
    public CinemaProjectApplicationAutoMapperProfile()
    {
        CreateMap<Hall, HallDto>();
        CreateMap<CreateHallDto, Hall>();
        CreateMap<UpdateHallDto, Hall>();

        CreateMap<Seat, SeatDto>();
        CreateMap<CreateSeatDto, Seat>();
        CreateMap<UpdateSeatDto, Seat>();
    }
}
