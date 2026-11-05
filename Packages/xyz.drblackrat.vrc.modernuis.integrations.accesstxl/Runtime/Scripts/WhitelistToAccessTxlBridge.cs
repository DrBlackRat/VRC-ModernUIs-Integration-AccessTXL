using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

using Texel;
using DrBlackRat.VRC.ModernUIs.Whitelist.Base;
using UnityEngine.Serialization;

namespace DrBlackRat.VRC.ModernUIs.Integrations
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class WhitelistToAccessTxlBridge : AccessControlUserSource
    {
        [FormerlySerializedAs("whitelistManager")] 
        [SerializeField] private WhitelistGetterBase whitelist;
        private bool connectedToWhitelist = false;
        
        protected override void _Init()
        {
            if (!connectedToWhitelist)
            {
                whitelist._SetUpConnection(this, nameof(_WhitelistUpdated));
                connectedToWhitelist = true;
            }
            base._Init();
        }

        public void _WhitelistUpdated() => _UpdateHandlers(EVENT_REVALIDATE);
        public override bool _ContainsAnyPlayerInWorld() => whitelist._IsPlayerWhitelisted(Networking.LocalPlayer);
        public override bool _ContainsPlayer(VRCPlayerApi player) => whitelist._IsPlayerWhitelisted(player);
        public override bool _ContainsName(string name) => whitelist._IsPlayerWhitelisted(name);
        
        
    }
}

