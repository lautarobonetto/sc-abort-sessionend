using Sitecore.Diagnostics;
using Sitecore.Events;
using System;
using System.Security.Policy;

namespace SC_Abort_SessionEnd.Events
{
  public class AbortSessionEnd
  {
    public void OnSessionEnd(object sender, EventArgs args)
    {
      CancelingEvent(args);
    }

    public void OnPostSessionEnd(object sender, EventArgs args)
    {
      CancelingEvent(args);
    }

    private void CancelingEvent(EventArgs args)
    {
      ((SitecoreEventArgs)args).Result.Cancel = true;
      Log.Info("Canceling SessionEnd event", this);
    }
  }
}