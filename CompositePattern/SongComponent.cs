using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal abstract class SongComponent
    {
        public virtual SongComponent Add(SongComponent songComponent)
        {
            throw new NotImplementedException();
        }

        public virtual SongComponent Remove(SongComponent songComponent)
        {
            throw new NotImplementedException();
        }

        public virtual string SongName { get { throw new NotImplementedException(); } }
        public virtual string BandName { get { throw new NotImplementedException(); } }
        public virtual int YearRealeased { get { throw new NotImplementedException(); } }

        public abstract void DisplaySongInfo();
    }
}
