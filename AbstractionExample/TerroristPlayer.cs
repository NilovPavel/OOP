using AbstractionExample;

internal class TerroristPlayer : HumanPlayer, IPlayer
{
    public TerroristPlayer(string name) : base(name)
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