using ConVar;
using Harmony;

public class ExamplePatch
{
    [HarmonyPatch(typeof(ConVar.Chat), "sayAs")]
    private class PlayerPatch
    {
        [HarmonyPrefix]
        private static void Prefix(Chat.ChatChannel targetChannel, ulong userId, string username, string message, BasePlayer player = null)
        {
            Chat.Broadcast(message);
        }
    }
}