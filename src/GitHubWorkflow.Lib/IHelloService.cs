namespace GitHubPackageDemo.Lib
{
    public interface IHelloService
    {
        string UserName { get; set; }

        string GetHelloMessage();
    }
}
