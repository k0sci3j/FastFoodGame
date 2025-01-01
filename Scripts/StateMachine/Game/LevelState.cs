public partial class LevelState : State
{
    public override void Ready()
    {
        base.Ready();
		GameVariables.Instance.CurrentLevel = 1;
		GameVariables.Instance.LastPoints = 0;
    }
    public void OnLevelGameOver()
	{
		fsm.ChangeTo("OverState");
	}
	public void OnLevelNextLevel()
	{
		fsm.ChangeTo("NextLevelState");
	}
}
