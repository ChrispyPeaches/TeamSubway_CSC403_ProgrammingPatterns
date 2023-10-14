/// <summary>
/// Music playing concrete state
/// </summary>
public class MusicPlayingState : IMusicState
{
    public PlayPauseMusicButtonContext PlayMusicButton { get; set; }

    public MusicPlayingState(PlayPauseMusicButtonContext playMusicButton)
    {
        PlayMusicButton = playMusicButton;
    }

    /// <summary>
    /// Display the pause button
    /// </summary>
    public void DisplayIcon()
    {
        PlayMusicButton.displayedIcon = PlayPauseMusicButtonContext.DisplayedIcon.Pause;
        Console.Clear();
        Console.Write(@"
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau
    PausePau    PausePau

    ");
    }
}