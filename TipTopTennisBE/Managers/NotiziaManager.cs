using BackEnd.DAL.Entities;
using BackEnd.DTO;
using BackEnd.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Managers
{
    public class NotiziaManager
    {
        private readonly DataMapper _mapper;
        private readonly ApplicationDBContext _context;

        public NotiziaManager(DataMapper mapper, ApplicationDBContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<NotiziaDTO> GetAll()
        {
            List<NotiziaDTO> notizieDTO = new List<NotiziaDTO>(); 
            foreach(Notizia n in _context.Notizie.ToList())
            {
                notizieDTO.Add(_mapper.MapNotiziaToDTO(n));
            }
            return notizieDTO.OrderByDescending(x => x.Data).ToList();
        }


        public NotiziaDTO GetSingle(int id)
        {
            var notizia = _context.Notizie.SingleOrDefault(x => x.NotiziaId == id);
            if (notizia != null)
            {
                return _mapper.MapNotiziaToDTO(notizia);
            }
            return null;
        }

        public bool Add(NotiziaDTO notiziadto)
        {
            Notizia notizia = _mapper.MapDtoToNotizia(notiziadto);
            _context.Add(notizia);
            return _context.SaveChanges() > 0;
        }

        public bool Update(NotiziaDTO notiziadto)
        {
            var toupdate = _context.Notizie.Find(notiziadto.Id);
            if (toupdate != null)
            {
                toupdate.Titolo = _mapper.MapDtoToNotizia(notiziadto).Titolo;
                toupdate.Data = _mapper.MapDtoToNotizia(notiziadto).Data;
                toupdate.Contenuto = _mapper.MapDtoToNotizia(notiziadto).Contenuto;

                _context.Update(toupdate);
            }
            return _context.SaveChanges() > 0;
        }

        public bool SetVisible(int id)
        {
            var notizia = _context.Notizie.Find(id);
            if (notizia != null)
            {
                notizia.IsVisible = true;
                _context.Update(notizia);
                return _context.SaveChanges() > 0;
            }
            return false;
        }
        public bool SetInvisible(int id)
        {
            var notizia = _context.Notizie.Find(id);
            if (notizia != null)
            {
                notizia.IsVisible = false;
                _context.Update(notizia);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool PutIntoRecycleBin(int id)
        {
            var notizia = _context.Notizie.Find(id);
            if (notizia != null)
            {
                notizia.IsDeleted = true;
                _context.Update(notizia);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool RemoveFromRecycleBin(int id)
        {
            var notizia = _context.Notizie.Find(id);
            if (notizia != null)
            {
                notizia.IsDeleted = false;
                _context.Update(notizia);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var todelete = _context.Notizie.Find(id);
            if (todelete != null)
            {
                _context.Remove(todelete);
                return _context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
