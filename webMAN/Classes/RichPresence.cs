using DSharpPlus;
using DSharpPlus.Entities;
using System.Threading.Tasks;
using DiscordRPC;
using System;
using System.Windows.Forms;
using Button = DiscordRPC.Button;
using System.Diagnostics;

namespace PSS3.Classes.Discord
{
    public class PS3DiscordClient
    {
        DiscordClient _dcli = null;
        DiscordRpcClient _drpc = null;
        public bool RpcInitialized { get => _drpc.IsInitialized; }
        public async Task<DiscordWebhook> GetWebhook(ulong id, string token)
        {
            return await _dcli.GetWebhookWithTokenAsync(id, token);
        }
        public async void Init(string Token)
        {
            _dcli = new DiscordClient(new DiscordConfiguration() { Intents = DiscordIntents.All, TokenType = TokenType.Bot, Token = Token });
            await _dcli.InitializeAsync();


        }
        //https://discord.com/api/webhooks/1065789549445386242/IIGkSInJimtnBcNJnoPa5B1PFwcBcWk70tyHYTgntsLCqhyx5thRbl4P55cGtkWJS9RA
        public void InitRpc(string appid)
        {
            _drpc = new DiscordRpcClient(appid);
            _drpc.Initialize();
        }
        public RichPresence CreateRPC(string state, string details, Assets assets = null, Button[] Buttons = null, Party party = null, Secrets secrets = null, Timestamps timestamps = null)
        {
            return new RichPresence() { Assets = assets, Details = details, Buttons = Buttons, Party = party, Secrets = secrets, State = state, Timestamps = timestamps };
        }
        public void SetRpc(RichPresence rpc) => _drpc.SetPresence(rpc);
        public void UpdateRpcTimestamps(Timestamps e) => _drpc.CurrentPresence.Timestamps = e;
        public Assets CreateRpcAssets(string large, string small, string largeSubtitle, string smallSubtitle)
        {
            var ass = new Assets();
            ass.LargeImageKey = large;
            ass.SmallImageKey = small;
            ass.LargeImageText = largeSubtitle;
            ass.SmallImageText = smallSubtitle;
            return ass;
        }
        public void OpenInviteLink(string url) => Process.Start(url);
        public void Stop()
        {
            if (_drpc != null)
            {
                _drpc.ClearPresence();
                _drpc.Deinitialize();
                _drpc.Dispose();
            }
        }
        public void ClearPresence()
        {
            if (_drpc != null)
            {
                _drpc.ClearPresence();
            }
        }
    }
}
