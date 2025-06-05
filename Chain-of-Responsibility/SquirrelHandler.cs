namespace Chain_of_Responsibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll est the {request.ToString()}. \n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}