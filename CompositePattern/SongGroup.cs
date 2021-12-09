using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class SongGroup : SongComponent
    {
        private readonly string groupName;
        private readonly string groupDescription;
        IList<SongComponent> songComponents = new List<SongComponent>();

        public SongGroup(string groupName, string groupDescription)
        {
            this.groupName = groupName;
            this.groupDescription = groupDescription;
        }

        public override SongComponent Add(SongComponent songComponent)
        {
            songComponents.Add(songComponent);
            return songComponent;
        }

        public override SongComponent Remove(SongComponent songComponent)
        {
            songComponents.Remove(songComponent);
            return songComponent;
        }

        public string GroupName { get { return groupName; } }
        public string GroupDescription { get { return groupDescription; } }

        public override void DisplaySongInfo()
        {
            Console.WriteLine($"{GroupName} {GroupDescription}");

            IEnumerator<SongComponent> enumerator = songComponents.GetEnumerator();
            do
            {
                SongComponent songComponent = enumerator.Current;
                if(songComponent != null)
                {
                    songComponent.DisplaySongInfo();
                }
            } while (enumerator.MoveNext());

        }
    }
}
