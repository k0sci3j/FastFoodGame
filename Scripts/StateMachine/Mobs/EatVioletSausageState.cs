public partial class EatVioletSausageState : EatenState
{
public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().GetParent<Level>().SickPoints+=1;
    }
}
