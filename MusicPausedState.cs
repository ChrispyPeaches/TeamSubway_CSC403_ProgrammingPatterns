/// <summary>
/// Music paused concrete state
/// </summary>
public class MusicPausedState : IMusicState
{
    public PlayPauseMusicButtonContext PlayMusicButton { get; set; }

    public MusicPausedState(PlayPauseMusicButtonContext playMusicButton)
    {
        PlayMusicButton = playMusicButton;
    }

    /// <summary>
    /// Display the play button
    /// </summary>
    public void DisplayIcon()
    {
        PlayMusicButton.displayedIcon = PlayPauseMusicButtonContext.DisplayedIcon.Play;
        Console.Clear();
        Console.Write(@"
    Pla
    PlayPl
    PlayPlayP
    PlayPlayPlay
    PlayPlayPlayPla
    PlayPlayPlayPlayP
    PlayPlayPlayPla
    PlayPlayPlay
    PlayPlayP
    PlayPl
    Pla

    ");
    }
}