using BlazorMusicCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Data.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly AlbumMusicCatalogContext _context;
        public AlbumService(AlbumMusicCatalogContext context)
        {
            _context = context;

        }
        public Task<bool> DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbumdetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
