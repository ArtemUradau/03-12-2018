using System;
using System.Collections.Generic;
using System.IO;

namespace MusicPlayer
{
    public class Player
    {
        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 100;

        private bool _isLocked;
        private bool _isPlaying;

        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }

            private set
            {
                if (value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        public List<Song> Songs { get; } = new List<Song>();
        public Song PlayingSong { get; private set; }

        public event Action<List<Song>, Song, bool, int> SongsListChangedEvent;
        public event Action<List<Song>, Song, bool, int> SongStartedEvent;

        public void VolumeUp()
        {
            if (_isLocked == false)
            {
                Volume++;
            }
        }

        public void VolumeDown()
        {
            if (_isLocked == false)
            {
                Volume--;
            }
        }

        public void VolumeChange( int step)
        {
            if (_isLocked == false)
            {
                Volume += step;
            }
        }

        public void Load(string source)
        {
            var dirInfo = new DirectoryInfo(source);

            if (dirInfo.Exists)
            {
                var files = dirInfo.GetFiles();
                foreach (var file in files)
                {
                    var song = new Song
                    {
                        Path = file.FullName,
                        Name = file.Name
                    };

                    Songs.Add(song);
                }
            }

            SongsListChangedEvent?.Invoke(Songs, null, _isLocked, _volume);
        }

        public void Play()
        {
            if (!_isLocked && Songs.Count > 0)
            {
                _isPlaying = true;
            }

            if (_isPlaying)
            {
                foreach (var song in Songs)
                {
                    PlayingSong = song;
                    SongStartedEvent?.Invoke(Songs, song, _isLocked, _volume);

                    using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
                    {
                        player.SoundLocation = PlayingSong.Path;
                        player.PlaySync();
                    }
                }
            }

            _isPlaying = false;
        }

        public bool Stop()
        {
            if (!_isLocked)
            {
                _isPlaying = false;
            }

            return _isPlaying;
        }

        public void Clear()
        {
            Songs.Clear();
        }

        public void Lock()
        {
            _isLocked = true;
        }
        public void Unlock()
        {
            _isLocked = false;
        }
    }
}
