using ConVar;
using Harmony;

public class ExamplePatch
{
    [HarmonyPatch(typeof(ConVar.Chat), "sayAs")]
    private class PlayerPatch
    {
        [HarmonyPrefix]
        private static void Prefix(string username, string message)
        {
            Chat.Broadcast(username + " says " + message);
        }
    }
}