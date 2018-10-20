using Repository.Entities;
using Repository.Interfaces;
using System;

namespace Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IRepository<Album> _albumRepository;
        private IRepository<Author> _authorRepository;
        private IRepository<Genre> _genreRepository;
        private IRepository<Singer> _singerRepository;
        private IRepository<Song> _songRepository;
        private IRepository<SongAlbum> _songAlbumRepository;
        private IRepository<User> _userRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IRepository<Album> AlbumRepository
        {
            get
            {
                if (_albumRepository == null)
                {
                    _albumRepository = new Repository<Album>(_context);
                }
                return _albumRepository;
            }
        }
        public IRepository<Author> AuthorRepository
        {
            get
            {
                if (_authorRepository == null)
                {
                    _authorRepository = new Repository<Author>(_context);
                }
                return _authorRepository;
            }
        }

        public IRepository<Genre> GenreRepository => throw new NotImplementedException();

        public IRepository<Singer> SingerRepository => throw new NotImplementedException();

        public IRepository<Song> SongRepository => throw new NotImplementedException();

        public IRepository<SongAlbum> SongAlbumRepository => throw new NotImplementedException();

        public IRepository<User> UserRepository => throw new NotImplementedException();

        public void Refresh()
        {
            //_context.Rollback();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
