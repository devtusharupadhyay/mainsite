using Microsoft.AspNetCore.Components;

namespace AngWater.Pages
{
    public partial class Channel: ComponentBase
    {
        private int _id;
        [Parameter]
        public int Id 
        { 
            get 
            {
                return _id;
            }
            set 
            {
                _id = value;

                if (_id == 1)
                {
                    ActiveChannel = Tabs.Channel1;
                    ChannelURI = "https://video.ibm.com/embed/24088760?autoplay=true";
                }
                if (_id == 2)
                {
                    ActiveChannel = Tabs.Channel2;
                    ChannelURI = "https://video.ibm.com/embed/23750985?autoplay=true";
                }
                if (_id == 3)
                {
                    ActiveChannel = Tabs.Channel3;
                    ChannelURI = "https://video.ibm.com/embed/24088761?autoplay=true";
                }
                if (_id == 4)
                {
                    ActiveChannel = Tabs.Channel4;
                    ChannelURI = "https://video.ibm.com/embed/24066306?autoplay=true";
                }

                StateHasChanged();
            }
        }

        public int BottomChannelId { get; set; }

        public string ChannelURI { get; set; }

        public Tabs ActiveChannel { get; set; }

        private void BottomChannelClicked(int bottomChannel)
        {
            BottomChannelId = bottomChannel;
            StateHasChanged();
        }
    }

    public enum Tabs
    {
        Channel1,
        Channel2,
        Channel3,
        Channel4
    }
}
