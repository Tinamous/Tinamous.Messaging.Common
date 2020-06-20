using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Enums
{
    /// <summary>
    /// Message source. Used for example to indicate the source of a measurement (web, mqtt, ---- bot).
    /// </summary>
    public enum Source
    {
          /// <summary>
        /// Status post came via the website.
        /// </summary>
        Web = 0,

        /// <summary>
        /// Status post came via email.
        /// </summary>
        Email = 1,

        /// <summary>
        /// Status post came via SMS message.
        /// </summary>
        Sms = 2,

        /// <summary>
        /// From MQTT Broker
        /// </summary>
        Mqtt = 3,

        /// <summary>
        /// From COAP server
        /// </summary>
        Coap = 4,

        /// <summary>
        /// From ParticleBot
        /// </summary>
        ParticleBot = 5,

        /// <summary>
        /// From Nest (thermostate/smoke alarm)
        /// </summary>
        Nest = 6,

        /// <summary>
        /// From NetAtMo (weather station
        /// </summary>
        NetAtMo = 7,

        /// <summary>
        /// Notification service (e.g. raising of alert/status ports)
        /// </summary>
        Notifier = 8, 

        /// <summary>
        /// WeMo Cloud bot
        /// </summary>
        WeMoBot = 9,

        /// <summary>
        /// Alerts service
        /// </summary>
        Alerts = 10,

        /// <summary>
        /// Events service
        /// </summary>
        Events = 11,

        /// <summary>
        /// Membership service
        /// </summary>
        Membership = 12,

        /// <summary>
        /// Status service
        /// </summary>
        Status = 13,

        /// <summary>
        /// Measurements service
        /// </summary>
        Measurements = 14,

        /// <summary>
        /// Lifx Bot
        /// </summary>
        LifxBot = 15,

        VirtualDeviceBot = 16,

        MailBot = 17,

        Media = 18,

        IFTTTBot = 19,

        ExportBot = 20,

        CoapServer = 21,

        AwsIoTBot = 22,

        ApiTestBot = 23,

        MSHealthBot = 24,

        [Obsolete("Use 'Nest'")]
        NestBot = 25,

        PubNubBot = 26,

        Reports = 27,

        Scheduler = 28,

        RssBot = 29,

        Search = 30,

        ServiceMonitor = 31,

        SimpleBots = 32,

        TwitterBot = 33,

        WithingsBot = 34,

        SigfoxBot = 35,

        AzureIoTBot = 36,

        TheThingsNetworkBot = 37,

        LoRaWanBot = 38,

        AwsDrsBot = 39,

        OnionBot = 40,

        AlexaBot = 41,

        CommandService = 42,

        LocationService  = 43,

        DeviceReportingService = 44,

        // NB: If adding don't forget to update the domain enum as well

        /// <summary>
        /// Status post came via an application identified by the SourceId
        /// </summary>
        App = 1000,

        /// <summary>
        /// Admin website
        /// </summary>
        WebAdmin = 2000,

        /// <summary>
        /// Landing (www.) website (i.e. not an account based site).
        /// </summary>
        WebWWW = 2001,

        /// <summary>
        /// Other web properties (i.e. not an account based site).
        /// </summary>
        WebOther = 2002,

        /// <summary>
        /// from a general robot.
        /// </summary>
        GeneralBot = 2000,

        Unknown = 100000,
    }
}