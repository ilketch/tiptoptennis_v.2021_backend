using BackEnd.DAL.Entities;
using BackEnd.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Mapper
{
    public class DataMapper
    {
        public NotiziaDTO MapNotiziaToDTO(Notizia notizia)
        {
            NotiziaDTO Dto = new NotiziaDTO();
            Dto.Id = notizia.NotiziaId;
            Dto.Titolo = notizia.Titolo;
            Dto.Data = notizia.Data;
            Dto.Contenuto = notizia.Contenuto;
            Dto.IsDeleted = notizia.IsDeleted;
            Dto.IsVisible = notizia.IsVisible;
            Dto.Espandi = false;
            return Dto;
        }

        public Notizia MapDtoToNotizia(NotiziaDTO dto)
        {
            Notizia entity = new Notizia();
            entity.NotiziaId = dto.Id;
            entity.Titolo = dto.Titolo;
            entity.Data = dto.Data;
            entity.Contenuto = dto.Contenuto;
            entity.IsDeleted = dto.IsDeleted;
            entity.IsVisible = dto.IsVisible;
            return entity;
        }
    }
}
