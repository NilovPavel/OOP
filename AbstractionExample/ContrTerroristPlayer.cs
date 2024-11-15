using AbstractionExample;

internal class ContrTerroristPlayer : HumanPlayer, IPlayer
{
    public ContrTerroristPlayer(string name) : base(name)
    {
    }

    public override void SaySomethngToOtherPlayer()
    {
        throw new NotImplementedException();
    }

    string IPlayer.Shoot()
    {
        throw new NotImplementedException();
    }
}