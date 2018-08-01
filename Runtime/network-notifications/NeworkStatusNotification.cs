using BeatThat.Notifications;
using UnityEngine.Networking;

namespace BeatThat.NetworkNotifications
{
    using N = NotificationBus;
    using Opts = NotificationReceiverOptions;
    public static class NetworkNotification 
    {
        public const string WEB_REQUEST_STARTED = "NETWORK_NOTIFICATION_WEB_REQUEST_STARTED";
        public static void WebRequestStarted(UnityWebRequest www, Opts opts = Opts.DontRequireReceiver)
        {
            N.Send(WEB_REQUEST_STARTED, www, opts);
        }

        public const string WEB_REQUEST_RECEIVED_RESPONSE = "NETWORK_NOTIFICATION_WEB_REQUEST_RECEIVED_RESPONSE";
        public static void WebRequestReceivedResponse(UnityWebRequest www, Opts opts = Opts.DontRequireReceiver)
        {
            N.Send(WEB_REQUEST_RECEIVED_RESPONSE, www, opts);
        }

        public const string WEB_REQUEST_NETWORK_ERROR = "NETWORK_NOTIFICATION_WEB_REQUEST_NETWORK_ERROR";
        public static void WebRequestNetworkError(UnityWebRequest www, Opts opts = Opts.DontRequireReceiver)
        {
            N.Send(WEB_REQUEST_NETWORK_ERROR, www, opts);
        }
    }
}

