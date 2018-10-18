using MusicPlayer.Data.Entities;

namespace MusicPlayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Album> AlbumRepository { get; }
        IRepository<Author> AuthorRepository { get; }
        IRepository<Genre> GenreRepository { get; }
        IRepository<Singer> SingerRepository { get; }
        IRepository<Song> SongRepository { get; }
        IRepository<SongAlbum> SongAlbumRepository { get; }
        IRepository<User> UserRepository { get; }

        void Refresh();

        void Commit();
    }
}
