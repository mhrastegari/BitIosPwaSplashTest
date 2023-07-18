using Pulumi;
using BitIosPwaSplashTest.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
