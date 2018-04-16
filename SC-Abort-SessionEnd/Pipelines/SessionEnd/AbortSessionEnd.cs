using Sitecore.Pipelines.PreprocessRequest;

namespace SC_Abort_SessionEnd.Pipelines.SessionEnd
{
  public class AbortSessionEnd : PreprocessRequestProcessor
  {
    public override void Process(PreprocessRequestArgs args)
    {
      Sitecore.Diagnostics.Assert.ArgumentNotNull(args, "args");
      args.AbortPipeline();
      return;
    }
  }
}