using System;
using Amplitude;
using Foundation;
using ObjCRuntime;

namespace Tonestro.Maui.Amplitude.iOS
{
	// @interface AMPIdentify : NSObject
	[BaseType (typeof(NSObject))]
	interface AMPIdentify
	{
		// @property (readonly, nonatomic, strong) NSMutableDictionary * userPropertyOperations;
		[Export ("userPropertyOperations", ArgumentSemantic.Strong)]
		NSMutableDictionary UserPropertyOperations { get; }

		// +(instancetype)identify;
		[Static]
		[Export ("identify")]
		AMPIdentify Identify ();

		// -(AMPIdentify *)add:(NSString *)property value:(NSObject *)value;
		[Export ("add:value:")]
		AMPIdentify Add (string property, NSObject value);

		// -(AMPIdentify *)append:(NSString *)property value:(NSObject *)value;
		[Export ("append:value:")]
		AMPIdentify Append (string property, NSObject value);

		// -(AMPIdentify *)clearAll;
		[Export ("clearAll")]
		[Verify (MethodToProperty)]
		AMPIdentify ClearAll { get; }

		// -(AMPIdentify *)prepend:(NSString *)property value:(NSObject *)value;
		[Export ("prepend:value:")]
		AMPIdentify Prepend (string property, NSObject value);

		// -(AMPIdentify *)set:(NSString *)property value:(NSObject *)value;
		[Export ("set:value:")]
		AMPIdentify Set (string property, NSObject value);

		// -(AMPIdentify *)setOnce:(NSString *)property value:(NSObject *)value;
		[Export ("setOnce:value:")]
		AMPIdentify SetOnce (string property, NSObject value);

		// -(AMPIdentify *)unset:(NSString *)property;
		[Export ("unset:")]
		AMPIdentify Unset (string property);

		// -(AMPIdentify *)preInsert:(NSString *)property value:(NSObject *)value;
		[Export ("preInsert:value:")]
		AMPIdentify PreInsert (string property, NSObject value);

		// -(AMPIdentify *)postInsert:(NSString *)property value:(NSObject *)value;
		[Export ("postInsert:value:")]
		AMPIdentify PostInsert (string property, NSObject value);

		// -(AMPIdentify *)remove:(NSString *)property value:(NSObject *)value;
		[Export ("remove:value:")]
		AMPIdentify Remove (string property, NSObject value);
	}

	// @interface AMPRevenue : NSObject
	[BaseType (typeof(NSObject))]
	interface AMPRevenue
	{
		// @property (readonly, nonatomic, strong) NSString * productId;
		[Export ("productId", ArgumentSemantic.Strong)]
		string ProductId { get; }

		// @property (readonly, nonatomic, strong) NSNumber * price;
		[Export ("price", ArgumentSemantic.Strong)]
		NSNumber Price { get; }

		// @property (readonly, nonatomic) NSInteger quantity;
		[Export ("quantity")]
		nint Quantity { get; }

		// @property (readonly, nonatomic, strong) NSString * revenueType;
		[Export ("revenueType", ArgumentSemantic.Strong)]
		string RevenueType { get; }

		// @property (readonly, nonatomic, strong) NSData * receipt;
		[Export ("receipt", ArgumentSemantic.Strong)]
		NSData Receipt { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * properties;
		[Export ("properties", ArgumentSemantic.Strong)]
		NSDictionary Properties { get; }

		// +(instancetype)revenue;
		[Static]
		[Export ("revenue")]
		AMPRevenue Revenue ();

		// -(BOOL)isValidRevenue;
		[Export ("isValidRevenue")]
		[Verify (MethodToProperty)]
		bool IsValidRevenue { get; }

		// -(AMPRevenue *)setProductIdentifier:(NSString *)productIdentifier;
		[Export ("setProductIdentifier:")]
		AMPRevenue SetProductIdentifier (string productIdentifier);

		// -(AMPRevenue *)setQuantity:(NSInteger)quantity;
		[Export ("setQuantity:")]
		AMPRevenue SetQuantity (nint quantity);

		// -(AMPRevenue *)setPrice:(NSNumber *)price;
		[Export ("setPrice:")]
		AMPRevenue SetPrice (NSNumber price);

		// -(AMPRevenue *)setRevenueType:(NSString *)revenueType;
		[Export ("setRevenueType:")]
		AMPRevenue SetRevenueType (string revenueType);

		// -(AMPRevenue *)setReceipt:(NSData *)receipt;
		[Export ("setReceipt:")]
		AMPRevenue SetReceipt (NSData receipt);

		// -(AMPRevenue *)setEventProperties:(NSDictionary *)eventProperties;
		[Export ("setEventProperties:")]
		AMPRevenue SetEventProperties (NSDictionary eventProperties);

		// -(NSDictionary *)toNSDictionary;
		[Export ("toNSDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary ToNSDictionary { get; }
	}

	// @interface AMPTrackingOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface AMPTrackingOptions
	{
		// @property (readonly, nonatomic, strong) NSMutableSet * disabledFields;
		[Export ("disabledFields", ArgumentSemantic.Strong)]
		NSMutableSet DisabledFields { get; }

		// -(AMPTrackingOptions *)disableCarrier;
		[Export ("disableCarrier")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableCarrier { get; }

		// -(AMPTrackingOptions *)disableCity;
		[Export ("disableCity")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableCity { get; }

		// -(AMPTrackingOptions *)disableCountry;
		[Export ("disableCountry")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableCountry { get; }

		// -(AMPTrackingOptions *)disableDeviceManufacturer;
		[Export ("disableDeviceManufacturer")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableDeviceManufacturer { get; }

		// -(AMPTrackingOptions *)disableDeviceModel;
		[Export ("disableDeviceModel")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableDeviceModel { get; }

		// -(AMPTrackingOptions *)disableDMA;
		[Export ("disableDMA")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableDMA { get; }

		// -(AMPTrackingOptions *)disableIDFA;
		[Export ("disableIDFA")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableIDFA { get; }

		// -(AMPTrackingOptions *)disableIDFV;
		[Export ("disableIDFV")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableIDFV { get; }

		// -(AMPTrackingOptions *)disableIPAddress;
		[Export ("disableIPAddress")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableIPAddress { get; }

		// -(AMPTrackingOptions *)disableLanguage;
		[Export ("disableLanguage")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableLanguage { get; }

		// -(AMPTrackingOptions *)disableLatLng;
		[Export ("disableLatLng")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableLatLng { get; }

		// -(AMPTrackingOptions *)disableOSName;
		[Export ("disableOSName")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableOSName { get; }

		// -(AMPTrackingOptions *)disableOSVersion;
		[Export ("disableOSVersion")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableOSVersion { get; }

		// -(AMPTrackingOptions *)disablePlatform;
		[Export ("disablePlatform")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisablePlatform { get; }

		// -(AMPTrackingOptions *)disableRegion;
		[Export ("disableRegion")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableRegion { get; }

		// -(AMPTrackingOptions *)disableVersionName;
		[Export ("disableVersionName")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions DisableVersionName { get; }

		// -(BOOL)shouldTrackCarrier;
		[Export ("shouldTrackCarrier")]
		[Verify (MethodToProperty)]
		bool ShouldTrackCarrier { get; }

		// -(BOOL)shouldTrackCity;
		[Export ("shouldTrackCity")]
		[Verify (MethodToProperty)]
		bool ShouldTrackCity { get; }

		// -(BOOL)shouldTrackCountry;
		[Export ("shouldTrackCountry")]
		[Verify (MethodToProperty)]
		bool ShouldTrackCountry { get; }

		// -(BOOL)shouldTrackDeviceManufacturer;
		[Export ("shouldTrackDeviceManufacturer")]
		[Verify (MethodToProperty)]
		bool ShouldTrackDeviceManufacturer { get; }

		// -(BOOL)shouldTrackDeviceModel;
		[Export ("shouldTrackDeviceModel")]
		[Verify (MethodToProperty)]
		bool ShouldTrackDeviceModel { get; }

		// -(BOOL)shouldTrackDMA;
		[Export ("shouldTrackDMA")]
		[Verify (MethodToProperty)]
		bool ShouldTrackDMA { get; }

		// -(BOOL)shouldTrackIDFA;
		[Export ("shouldTrackIDFA")]
		[Verify (MethodToProperty)]
		bool ShouldTrackIDFA { get; }

		// -(BOOL)shouldTrackIDFV;
		[Export ("shouldTrackIDFV")]
		[Verify (MethodToProperty)]
		bool ShouldTrackIDFV { get; }

		// -(BOOL)shouldTrackIPAddress;
		[Export ("shouldTrackIPAddress")]
		[Verify (MethodToProperty)]
		bool ShouldTrackIPAddress { get; }

		// -(BOOL)shouldTrackLanguage;
		[Export ("shouldTrackLanguage")]
		[Verify (MethodToProperty)]
		bool ShouldTrackLanguage { get; }

		// -(BOOL)shouldTrackLatLng;
		[Export ("shouldTrackLatLng")]
		[Verify (MethodToProperty)]
		bool ShouldTrackLatLng { get; }

		// -(BOOL)shouldTrackOSName;
		[Export ("shouldTrackOSName")]
		[Verify (MethodToProperty)]
		bool ShouldTrackOSName { get; }

		// -(BOOL)shouldTrackOSVersion;
		[Export ("shouldTrackOSVersion")]
		[Verify (MethodToProperty)]
		bool ShouldTrackOSVersion { get; }

		// -(BOOL)shouldTrackPlatform;
		[Export ("shouldTrackPlatform")]
		[Verify (MethodToProperty)]
		bool ShouldTrackPlatform { get; }

		// -(BOOL)shouldTrackRegion;
		[Export ("shouldTrackRegion")]
		[Verify (MethodToProperty)]
		bool ShouldTrackRegion { get; }

		// -(BOOL)shouldTrackVersionName;
		[Export ("shouldTrackVersionName")]
		[Verify (MethodToProperty)]
		bool ShouldTrackVersionName { get; }

		// -(NSMutableDictionary *)getApiPropertiesTrackingOption;
		[Export ("getApiPropertiesTrackingOption")]
		[Verify (MethodToProperty)]
		NSMutableDictionary ApiPropertiesTrackingOption { get; }

		// -(AMPTrackingOptions *)mergeIn:(AMPTrackingOptions *)options;
		[Export ("mergeIn:")]
		AMPTrackingOptions MergeIn (AMPTrackingOptions options);

		// +(instancetype)options;
		[Static]
		[Export ("options")]
		AMPTrackingOptions Options ();

		// +(AMPTrackingOptions *)forCoppaControl;
		[Static]
		[Export ("forCoppaControl")]
		[Verify (MethodToProperty)]
		AMPTrackingOptions ForCoppaControl { get; }

		// +(AMPTrackingOptions *)copyOf:(AMPTrackingOptions *)origin;
		[Static]
		[Export ("copyOf:")]
		AMPTrackingOptions CopyOf (AMPTrackingOptions origin);
	}

	// typedef NSString * _Nonnull (^AMPAdSupportBlock)();
	delegate string AMPAdSupportBlock ();

	// typedef NSDictionary * _Nullable (^AMPLocationInfoBlock)();
	delegate NSDictionary AMPLocationInfoBlock ();

	// @interface Amplitude : NSObject
	[BaseType (typeof(NSObject))]
	interface Amplitude
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull apiKey;
		[Export ("apiKey")]
		string ApiKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull deviceId;
		[Export ("deviceId")]
		string DeviceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable instanceName;
		[NullAllowed, Export ("instanceName")]
		string InstanceName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable propertyListPath;
		[NullAllowed, Export ("propertyListPath")]
		string PropertyListPath { get; }

		// @property (assign, readwrite, nonatomic) BOOL optOut;
		[Export ("optOut")]
		bool OptOut { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL useDynamicConfig;
		[Export ("useDynamicConfig")]
		bool UseDynamicConfig { get; set; }

		// @property (assign, nonatomic) int eventUploadThreshold;
		[Export ("eventUploadThreshold")]
		int EventUploadThreshold { get; set; }

		// @property (assign, nonatomic) int eventUploadMaxBatchSize;
		[Export ("eventUploadMaxBatchSize")]
		int EventUploadMaxBatchSize { get; set; }

		// @property (assign, nonatomic) int eventMaxCount;
		[Export ("eventMaxCount")]
		int EventMaxCount { get; set; }

		// @property (assign, nonatomic) int eventUploadPeriodSeconds;
		[Export ("eventUploadPeriodSeconds")]
		int EventUploadPeriodSeconds { get; set; }

		// @property (assign, nonatomic) long minTimeBetweenSessionsMillis;
		[Export ("minTimeBetweenSessionsMillis")]
		nint MinTimeBetweenSessionsMillis { get; set; }

		// @property (assign, nonatomic) BOOL trackingSessionEvents;
		[Export ("trackingSessionEvents")]
		bool TrackingSessionEvents { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable libraryName;
		[NullAllowed, Export ("libraryName")]
		string LibraryName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable libraryVersion;
		[NullAllowed, Export ("libraryVersion")]
		string LibraryVersion { get; set; }

		// @property (nonatomic, strong) AMPAdSupportBlock _Nullable adSupportBlock;
		[NullAllowed, Export ("adSupportBlock", ArgumentSemantic.Strong)]
		AMPAdSupportBlock AdSupportBlock { get; set; }

		// @property (nonatomic, strong) AMPLocationInfoBlock _Nullable locationInfoBlock;
		[NullAllowed, Export ("locationInfoBlock", ArgumentSemantic.Strong)]
		AMPLocationInfoBlock LocationInfoBlock { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull contentTypeHeader;
		[Export ("contentTypeHeader")]
		string ContentTypeHeader { get; }

		// +(Amplitude * _Nonnull)instance;
		[Static]
		[Export ("instance")]
		[Verify (MethodToProperty)]
		Amplitude Instance { get; }

		// +(Amplitude * _Nonnull)instanceWithName:(NSString * _Nullable)instanceName;
		[Static]
		[Export ("instanceWithName:")]
		Amplitude InstanceWithName ([NullAllowed] string instanceName);

		// -(void)initializeApiKey:(NSString * _Nonnull)apiKey;
		[Export ("initializeApiKey:")]
		void InitializeApiKey (string apiKey);

		// -(void)initializeApiKey:(NSString * _Nonnull)apiKey userId:(NSString * _Nullable)userId;
		[Export ("initializeApiKey:userId:")]
		void InitializeApiKey (string apiKey, [NullAllowed] string userId);

		// -(void)logEvent:(NSString * _Nonnull)eventType;
		[Export ("logEvent:")]
		void LogEvent (string eventType);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties;
		[Export ("logEvent:withEventProperties:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties outOfSession:(BOOL)outOfSession;
		[Export ("logEvent:withEventProperties:outOfSession:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties, bool outOfSession);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups;
		[Export ("logEvent:withEventProperties:withGroups:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups outOfSession:(BOOL)outOfSession;
		[Export ("logEvent:withEventProperties:withGroups:outOfSession:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, bool outOfSession);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups withLongLongTimestamp:(long long)longLongTimestamp outOfSession:(BOOL)outOfSession;
		[Export ("logEvent:withEventProperties:withGroups:withLongLongTimestamp:outOfSession:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, long longLongTimestamp, bool outOfSession);

		// -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups withTimestamp:(NSNumber * _Nonnull)timestamp outOfSession:(BOOL)outOfSession;
		[Export ("logEvent:withEventProperties:withGroups:withTimestamp:outOfSession:")]
		void LogEvent (string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, NSNumber timestamp, bool outOfSession);

		// -(void)logRevenue:(NSNumber * _Nonnull)amount __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
		[Export ("logRevenue:")]
		void LogRevenue (NSNumber amount);

		// -(void)logRevenue:(NSString * _Nullable)productIdentifier quantity:(NSInteger)quantity price:(NSNumber * _Nonnull)price __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
		[Export ("logRevenue:quantity:price:")]
		void LogRevenue ([NullAllowed] string productIdentifier, nint quantity, NSNumber price);

		// -(void)logRevenue:(NSString * _Nullable)productIdentifier quantity:(NSInteger)quantity price:(NSNumber * _Nonnull)price receipt:(NSData * _Nullable)receipt __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
		[Export ("logRevenue:quantity:price:receipt:")]
		void LogRevenue ([NullAllowed] string productIdentifier, nint quantity, NSNumber price, [NullAllowed] NSData receipt);

		// -(void)logRevenueV2:(AMPRevenue * _Nonnull)revenue;
		[Export ("logRevenueV2:")]
		void LogRevenueV2 (AMPRevenue revenue);

		// -(void)identify:(AMPIdentify * _Nonnull)identify;
		[Export ("identify:")]
		void Identify (AMPIdentify identify);

		// -(void)identify:(AMPIdentify * _Nonnull)identify outOfSession:(BOOL)outOfSession;
		[Export ("identify:outOfSession:")]
		void Identify (AMPIdentify identify, bool outOfSession);

		// -(void)setUserProperties:(NSDictionary * _Nonnull)userProperties;
		[Export ("setUserProperties:")]
		void SetUserProperties (NSDictionary userProperties);

		// -(void)setUserProperties:(NSDictionary * _Nonnull)userProperties replace:(BOOL)replace __attribute__((deprecated("Use `- setUserProperties` instead. In earlier versions of the SDK, `replace: YES` replaced the in-memory userProperties dictionary with the input. However, userProperties are no longer stored in memory, so the flag does nothing.")));
		[Export ("setUserProperties:replace:")]
		void SetUserProperties (NSDictionary userProperties, bool replace);

		// -(void)clearUserProperties;
		[Export ("clearUserProperties")]
		void ClearUserProperties ();

		// -(void)setGroup:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName;
		[Export ("setGroup:groupName:")]
		void SetGroup (string groupType, NSObject groupName);

		// -(void)groupIdentifyWithGroupType:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName groupIdentify:(AMPIdentify * _Nonnull)groupIdentify;
		[Export ("groupIdentifyWithGroupType:groupName:groupIdentify:")]
		void GroupIdentifyWithGroupType (string groupType, NSObject groupName, AMPIdentify groupIdentify);

		// -(void)groupIdentifyWithGroupType:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName groupIdentify:(AMPIdentify * _Nonnull)groupIdentify outOfSession:(BOOL)outOfSession;
		[Export ("groupIdentifyWithGroupType:groupName:groupIdentify:outOfSession:")]
		void GroupIdentifyWithGroupType (string groupType, NSObject groupName, AMPIdentify groupIdentify, bool outOfSession);

		// -(void)setUserId:(NSString * _Nullable)userId;
		[Export ("setUserId:")]
		void SetUserId ([NullAllowed] string userId);

		// -(void)setUserId:(NSString * _Nullable)userId startNewSession:(BOOL)startNewSession;
		[Export ("setUserId:startNewSession:")]
		void SetUserId ([NullAllowed] string userId, bool startNewSession);

		// -(void)setDeviceId:(NSString * _Nonnull)deviceId;
		[Export ("setDeviceId:")]
		void SetDeviceId (string deviceId);

		// -(void)setOffline:(BOOL)offline;
		[Export ("setOffline:")]
		void SetOffline (bool offline);

		// -(void)useAdvertisingIdForDeviceId;
		[Export ("useAdvertisingIdForDeviceId")]
		void UseAdvertisingIdForDeviceId ();

		// -(void)setTrackingOptions:(AMPTrackingOptions * _Nonnull)options;
		[Export ("setTrackingOptions:")]
		void SetTrackingOptions (AMPTrackingOptions options);

		// -(void)enableCoppaControl;
		[Export ("enableCoppaControl")]
		void EnableCoppaControl ();

		// -(void)disableCoppaControl;
		[Export ("disableCoppaControl")]
		void DisableCoppaControl ();

		// -(void)setServerUrl:(NSString * _Nonnull)serverUrl;
		[Export ("setServerUrl:")]
		void SetServerUrl (string serverUrl);

		// -(void)setContentTypeHeader:(NSString * _Nonnull)contentType;
		[Export ("setContentTypeHeader:")]
		void SetContentTypeHeader (string contentType);

		// -(void)setBearerToken:(NSString * _Nonnull)token;
		[Export ("setBearerToken:")]
		void SetBearerToken (string token);

		// -(void)printEventsCount;
		[Export ("printEventsCount")]
		void PrintEventsCount ();

		// -(NSString * _Nonnull)getDeviceId;
		[Export ("getDeviceId")]
		[Verify (MethodToProperty)]
		string DeviceId { get; }

		// -(void)regenerateDeviceId;
		[Export ("regenerateDeviceId")]
		void RegenerateDeviceId ();

		// -(long long)getSessionId;
		[Export ("getSessionId")]
		[Verify (MethodToProperty)]
		long SessionId { get; }

		// -(void)setSessionId:(long long)timestamp;
		[Export ("setSessionId:")]
		void SetSessionId (long timestamp);

		// -(void)uploadEvents;
		[Export ("uploadEvents")]
		void UploadEvents ();

		// -(BOOL)startOrContinueSession:(long long)timestamp;
		[Export ("startOrContinueSession:")]
		bool StartOrContinueSession (long timestamp);

		// -(NSString * _Nonnull)getContentTypeHeader;
		[Export ("getContentTypeHeader")]
		[Verify (MethodToProperty)]
		string ContentTypeHeader { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kAMPSessionStartEvent;
		[Field ("kAMPSessionStartEvent", "__Internal")]
		NSString kAMPSessionStartEvent { get; }

		// extern NSString *const _Nonnull kAMPSessionEndEvent;
		[Field ("kAMPSessionEndEvent", "__Internal")]
		NSString kAMPSessionEndEvent { get; }

		// extern NSString *const _Nonnull kAMPRevenueEvent;
		[Field ("kAMPRevenueEvent", "__Internal")]
		NSString kAMPRevenueEvent { get; }
	}

	// @interface SSLPinning (Amplitude)
	[Category]
	[BaseType (typeof(Amplitude))]
	interface Amplitude_SSLPinning
	{
	}
}
