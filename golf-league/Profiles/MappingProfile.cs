using AutoMapper;
using golf_league.ViewModels;
using golf_league.Models;

namespace golf_league.Profiles
{
    public class MappingProfile: Profile
    {
       public MappingProfile()
        {
            CreateMap<PlayerScoreDetailsViewModel, Score>()
            .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(src => src.PlayerId))
            .ForMember(dest => dest.DatePlayed, opt => opt.MapFrom(src => src.DatePlayed))
            .ForMember(dest => dest.Index, opt => opt.MapFrom(src => src.Index))
            .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
            .ForMember(dest => dest.Differential, opt => opt.MapFrom(src => src.Differential));

            CreateMap<HoleDetailViewModel, ScoreDetail>()
            .ForMember(dest => dest.HoleId, opt => opt.MapFrom(src => src.HoleId))
            .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Score));
        }
    }
}
