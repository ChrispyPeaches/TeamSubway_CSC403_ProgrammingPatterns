/// <summary>
/// Context
/// </summary>
public class PlayPauseMusicButtonContext
{
    /// <summary>
    /// An representation of the types of icons that can be displayed
    /// </summary>
    public enum DisplayedIcon
    {
        Play,
        Pause
    }

    /// <summary>
    /// The icon currently being displayed as the button
    /// </summary>
    public DisplayedIcon displayedIcon { get; set; }

    /// <summary>
    /// The state variable
    /// </summary>
    public IMusicState musicState { get; set; }

    /// <summary>
    /// We assume the only way to start playing music is by clicking
    /// a song to play. Therefore, the state when the button is
    /// instantiated would be <see cref="MusicPlayingState"/>
    /// </summary>
    public PlayPauseMusicButtonContext()
    {
        musicState = new MusicPlayingState(this);
        musicState.DisplayIcon();
    }

    /// <summary>
    /// When the button is clicked, switch the state variable to
    /// the opposite type.
    /// </summary>
    public void ClickButton()
    {
        if (musicState.GetType() == typeof(MusicPlayingState))
        {
            musicState = new MusicPausedState(this);
        }
        else
        {
            musicState = new MusicPlayingState(this);
        }
        musicState.DisplayIcon();
    }
}