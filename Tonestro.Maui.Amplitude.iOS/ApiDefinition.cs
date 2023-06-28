using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Tonestro.Maui.Amplitude.iOS
{
    // @interface AMPConfigManager : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPConfigManager
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull ingestionEndpoint;
        [Export("ingestionEndpoint", ArgumentSemantic.Strong)]
        string IngestionEndpoint { get; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AMPConfigManager SharedInstance();

        // -(void)refresh:(void (^ _Nonnull)(void))completionHandler;
        [Export("refresh:")]
        void Refresh(Action completionHandler);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const kAMPLibrary;
        [Field("kAMPLibrary", "__Internal")]
        NSString kAMPLibrary { get; }

        // extern NSString *const kAMPVersion;
        [Field("kAMPVersion", "__Internal")]
        NSString kAMPVersion { get; }

        // extern NSString *const kAMPUnknownLibrary;
        [Field("kAMPUnknownLibrary", "__Internal")]
        NSString kAMPUnknownLibrary { get; }

        // extern NSString *const kAMPUnknownVersion;
        [Field("kAMPUnknownVersion", "__Internal")]
        NSString kAMPUnknownVersion { get; }

        // extern NSString *const kAMPPlatform;
        [Field("kAMPPlatform", "__Internal")]
        NSString kAMPPlatform { get; }

        // extern NSString *const kAMPOSName;
        [Field("kAMPOSName", "__Internal")]
        NSString kAMPOSName { get; }

        // extern NSString *const kAMPEventLogDomain;
        [Field("kAMPEventLogDomain", "__Internal")]
        NSString kAMPEventLogDomain { get; }

        // extern NSString *const kAMPEventLogUrl;
        [Field("kAMPEventLogUrl", "__Internal")]
        NSString kAMPEventLogUrl { get; }

        // extern NSString *const kAMPContentTypeHeader;
        [Field("kAMPContentTypeHeader", "__Internal")]
        NSString kAMPContentTypeHeader { get; }

        // extern NSString *const kAMPDyanmicConfigUrl;
        [Field("kAMPDyanmicConfigUrl", "__Internal")]
        NSString kAMPDyanmicConfigUrl { get; }

        // extern NSString *const kAMPDefaultInstance;
        [Field("kAMPDefaultInstance", "__Internal")]
        NSString kAMPDefaultInstance { get; }

        // extern const int kAMPEventUploadThreshold;
        [Field("kAMPEventUploadThreshold", "__Internal")]
        int kAMPEventUploadThreshold { get; }

        // extern const int kAMPEventUploadMaxBatchSize;
        [Field("kAMPEventUploadMaxBatchSize", "__Internal")]
        int kAMPEventUploadMaxBatchSize { get; }

        // extern const int kAMPEventMaxCount;
        [Field("kAMPEventMaxCount", "__Internal")]
        int kAMPEventMaxCount { get; }

        // extern const int kAMPEventRemoveBatchSize;
        [Field("kAMPEventRemoveBatchSize", "__Internal")]
        int kAMPEventRemoveBatchSize { get; }

        // extern const int kAMPEventUploadPeriodSeconds;
        [Field("kAMPEventUploadPeriodSeconds", "__Internal")]
        int kAMPEventUploadPeriodSeconds { get; }

        // extern const long kAMPMinTimeBetweenSessionsMillis;
        [Field("kAMPMinTimeBetweenSessionsMillis", "__Internal")]
        nint kAMPMinTimeBetweenSessionsMillis { get; }

        // extern const int kAMPMaxStringLength;
        [Field("kAMPMaxStringLength", "__Internal")]
        int kAMPMaxStringLength { get; }

        // extern const int kAMPMaxPropertyKeys;
        [Field("kAMPMaxPropertyKeys", "__Internal")]
        int kAMPMaxPropertyKeys { get; }

        // extern NSString *const IDENTIFY_EVENT;
        [Field("IDENTIFY_EVENT", "__Internal")]
        NSString IDENTIFY_EVENT { get; }

        // extern NSString *const GROUP_IDENTIFY_EVENT;
        [Field("GROUP_IDENTIFY_EVENT", "__Internal")]
        NSString GROUP_IDENTIFY_EVENT { get; }

        // extern NSString *const AMP_OP_ADD;
        [Field("AMP_OP_ADD", "__Internal")]
        NSString AMP_OP_ADD { get; }

        // extern NSString *const AMP_OP_APPEND;
        [Field("AMP_OP_APPEND", "__Internal")]
        NSString AMP_OP_APPEND { get; }

        // extern NSString *const AMP_OP_CLEAR_ALL;
        [Field("AMP_OP_CLEAR_ALL", "__Internal")]
        NSString AMP_OP_CLEAR_ALL { get; }

        // extern NSString *const AMP_OP_PREPEND;
        [Field("AMP_OP_PREPEND", "__Internal")]
        NSString AMP_OP_PREPEND { get; }

        // extern NSString *const AMP_OP_SET;
        [Field("AMP_OP_SET", "__Internal")]
        NSString AMP_OP_SET { get; }

        // extern NSString *const AMP_OP_SET_ONCE;
        [Field("AMP_OP_SET_ONCE", "__Internal")]
        NSString AMP_OP_SET_ONCE { get; }

        // extern NSString *const AMP_OP_UNSET;
        [Field("AMP_OP_UNSET", "__Internal")]
        NSString AMP_OP_UNSET { get; }

        // extern NSString *const AMP_OP_PREINSERT;
        [Field("AMP_OP_PREINSERT", "__Internal")]
        NSString AMP_OP_PREINSERT { get; }

        // extern NSString *const AMP_OP_POSTINSERT;
        [Field("AMP_OP_POSTINSERT", "__Internal")]
        NSString AMP_OP_POSTINSERT { get; }

        // extern NSString *const AMP_OP_REMOVE;
        [Field("AMP_OP_REMOVE", "__Internal")]
        NSString AMP_OP_REMOVE { get; }

        // extern NSString *const AMP_REVENUE_PRODUCT_ID;
        [Field("AMP_REVENUE_PRODUCT_ID", "__Internal")]
        NSString AMP_REVENUE_PRODUCT_ID { get; }

        // extern NSString *const AMP_REVENUE_QUANTITY;
        [Field("AMP_REVENUE_QUANTITY", "__Internal")]
        NSString AMP_REVENUE_QUANTITY { get; }

        // extern NSString *const AMP_REVENUE_PRICE;
        [Field("AMP_REVENUE_PRICE", "__Internal")]
        NSString AMP_REVENUE_PRICE { get; }

        // extern NSString *const AMP_REVENUE_REVENUE_TYPE;
        [Field("AMP_REVENUE_REVENUE_TYPE", "__Internal")]
        NSString AMP_REVENUE_REVENUE_TYPE { get; }

        // extern NSString *const AMP_REVENUE_RECEIPT;
        [Field("AMP_REVENUE_RECEIPT", "__Internal")]
        NSString AMP_REVENUE_RECEIPT { get; }

        // extern NSString *const AMP_TRACKING_OPTION_CARRIER;
        [Field("AMP_TRACKING_OPTION_CARRIER", "__Internal")]
        NSString AMP_TRACKING_OPTION_CARRIER { get; }

        // extern NSString *const AMP_TRACKING_OPTION_CITY;
        [Field("AMP_TRACKING_OPTION_CITY", "__Internal")]
        NSString AMP_TRACKING_OPTION_CITY { get; }

        // extern NSString *const AMP_TRACKING_OPTION_COUNTRY;
        [Field("AMP_TRACKING_OPTION_COUNTRY", "__Internal")]
        NSString AMP_TRACKING_OPTION_COUNTRY { get; }

        // extern NSString *const AMP_TRACKING_OPTION_DEVICE_MANUFACTURER;
        [Field("AMP_TRACKING_OPTION_DEVICE_MANUFACTURER", "__Internal")]
        NSString AMP_TRACKING_OPTION_DEVICE_MANUFACTURER { get; }

        // extern NSString *const AMP_TRACKING_OPTION_DEVICE_MODEL;
        [Field("AMP_TRACKING_OPTION_DEVICE_MODEL", "__Internal")]
        NSString AMP_TRACKING_OPTION_DEVICE_MODEL { get; }

        // extern NSString *const AMP_TRACKING_OPTION_DMA;
        [Field("AMP_TRACKING_OPTION_DMA", "__Internal")]
        NSString AMP_TRACKING_OPTION_DMA { get; }

        // extern NSString *const AMP_TRACKING_OPTION_IDFA;
        [Field("AMP_TRACKING_OPTION_IDFA", "__Internal")]
        NSString AMP_TRACKING_OPTION_IDFA { get; }

        // extern NSString *const AMP_TRACKING_OPTION_IDFV;
        [Field("AMP_TRACKING_OPTION_IDFV", "__Internal")]
        NSString AMP_TRACKING_OPTION_IDFV { get; }

        // extern NSString *const AMP_TRACKING_OPTION_IP_ADDRESS;
        [Field("AMP_TRACKING_OPTION_IP_ADDRESS", "__Internal")]
        NSString AMP_TRACKING_OPTION_IP_ADDRESS { get; }

        // extern NSString *const AMP_TRACKING_OPTION_LANGUAGE;
        [Field("AMP_TRACKING_OPTION_LANGUAGE", "__Internal")]
        NSString AMP_TRACKING_OPTION_LANGUAGE { get; }

        // extern NSString *const AMP_TRACKING_OPTION_LAT_LNG;
        [Field("AMP_TRACKING_OPTION_LAT_LNG", "__Internal")]
        NSString AMP_TRACKING_OPTION_LAT_LNG { get; }

        // extern NSString *const AMP_TRACKING_OPTION_OS_NAME;
        [Field("AMP_TRACKING_OPTION_OS_NAME", "__Internal")]
        NSString AMP_TRACKING_OPTION_OS_NAME { get; }

        // extern NSString *const AMP_TRACKING_OPTION_OS_VERSION;
        [Field("AMP_TRACKING_OPTION_OS_VERSION", "__Internal")]
        NSString AMP_TRACKING_OPTION_OS_VERSION { get; }

        // extern NSString *const AMP_TRACKING_OPTION_PLATFORM;
        [Field("AMP_TRACKING_OPTION_PLATFORM", "__Internal")]
        NSString AMP_TRACKING_OPTION_PLATFORM { get; }

        // extern NSString *const AMP_TRACKING_OPTION_REGION;
        [Field("AMP_TRACKING_OPTION_REGION", "__Internal")]
        NSString AMP_TRACKING_OPTION_REGION { get; }

        // extern NSString *const AMP_TRACKING_OPTION_VERSION_NAME;
        [Field("AMP_TRACKING_OPTION_VERSION_NAME", "__Internal")]
        NSString AMP_TRACKING_OPTION_VERSION_NAME { get; }
    }

    // @interface AMPDatabaseHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPDatabaseHelper
    {
        // @property (readonly, nonatomic, strong) NSString * databasePath;
        [Export("databasePath", ArgumentSemantic.Strong)]
        string DatabasePath { get; }

        // +(AMPDatabaseHelper *)getDatabaseHelper;
        [Static]
        [Export("getDatabaseHelper")]
        AMPDatabaseHelper DatabaseHelper { get; }

        // +(AMPDatabaseHelper *)getDatabaseHelper:(NSString *)instanceName;
        [Static]
        [Export("getDatabaseHelper:")]
        AMPDatabaseHelper GetDatabaseHelper(string instanceName);

        // -(BOOL)createTables;
        [Export("createTables")]
        bool CreateTables();

        // -(BOOL)dropTables;
        [Export("dropTables")]
        bool DropTables();

        // -(BOOL)upgrade:(int)oldVersion newVersion:(int)newVersion;
        [Export("upgrade:newVersion:")]
        bool Upgrade(int oldVersion, int newVersion);

        // -(BOOL)resetDB:(BOOL)deleteDB;
        [Export("resetDB:")]
        bool ResetDB(bool deleteDB);

        // -(BOOL)deleteDB;
        [Export("deleteDB")]
        bool DeleteDB();

        // -(BOOL)addEvent:(NSString *)event;
        [Export("addEvent:")]
        bool AddEvent(string @event);

        // -(BOOL)addIdentify:(NSString *)identify;
        [Export("addIdentify:")]
        bool AddIdentify(string identify);

        // -(NSMutableArray *)getEvents:(long long)upToId limit:(long long)limit;
        [Export("getEvents:limit:")]
        NSMutableArray GetEvents(long upToId, long limit);

        // -(NSMutableArray *)getIdentifys:(long long)upToId limit:(long long)limit;
        [Export("getIdentifys:limit:")]
        NSMutableArray GetIdentifys(long upToId, long limit);

        // -(int)getEventCount;
        [Export("getEventCount")]
        int EventCount { get; }

        // -(int)getIdentifyCount;
        [Export("getIdentifyCount")]
        int IdentifyCount { get; }

        // -(int)getTotalEventCount;
        [Export("getTotalEventCount")]
        int TotalEventCount { get; }

        // -(BOOL)removeEvents:(long long)maxId;
        [Export("removeEvents:")]
        bool RemoveEvents(long maxId);

        // -(BOOL)removeIdentifys:(long long)maxIdentifyId;
        [Export("removeIdentifys:")]
        bool RemoveIdentifys(long maxIdentifyId);

        // -(BOOL)removeEvent:(long long)eventId;
        [Export("removeEvent:")]
        bool RemoveEvent(long eventId);

        // -(BOOL)removeIdentify:(long long)identifyId;
        [Export("removeIdentify:")]
        bool RemoveIdentify(long identifyId);

        // -(long long)getNthEventId:(long long)n;
        [Export("getNthEventId:")]
        long GetNthEventId(long n);

        // -(long long)getNthIdentifyId:(long long)n;
        [Export("getNthIdentifyId:")]
        long GetNthIdentifyId(long n);

        // -(BOOL)insertOrReplaceKeyValue:(NSString *)key value:(NSString *)value;
        [Export("insertOrReplaceKeyValue:value:")]
        bool InsertOrReplaceKeyValue(string key, string value);

        // -(BOOL)insertOrReplaceKeyLongValue:(NSString *)key value:(NSNumber *)value;
        [Export("insertOrReplaceKeyLongValue:value:")]
        bool InsertOrReplaceKeyLongValue(string key, NSNumber value);

        // -(NSString *)getValue:(NSString *)key;
        [Export("getValue:")]
        string GetValue(string key);

        // -(NSNumber *)getLongValue:(NSString *)key;
        [Export("getLongValue:")]
        NSNumber GetLongValue(string key);
    }

    // @interface AMPDeviceInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPDeviceInfo
    {
        // @property (readonly, nonatomic, strong) NSString * appVersion;
        [Export("appVersion", ArgumentSemantic.Strong)]
        string AppVersion { get; }

        // @property (readonly, nonatomic, strong) NSString * osName;
        [Export("osName", ArgumentSemantic.Strong)]
        string OsName { get; }

        // @property (readonly, nonatomic, strong) NSString * osVersion;
        [Export("osVersion", ArgumentSemantic.Strong)]
        string OsVersion { get; }

        // @property (readonly, nonatomic, strong) NSString * manufacturer;
        [Export("manufacturer", ArgumentSemantic.Strong)]
        string Manufacturer { get; }

        // @property (readonly, nonatomic, strong) NSString * model;
        [Export("model", ArgumentSemantic.Strong)]
        string Model { get; }

        // @property (readonly, nonatomic, strong) NSString * carrier;
        [Export("carrier", ArgumentSemantic.Strong)]
        string Carrier { get; }

        // @property (readonly, nonatomic, strong) NSString * country;
        [Export("country", ArgumentSemantic.Strong)]
        string Country { get; }

        // @property (readonly, nonatomic, strong) NSString * language;
        [Export("language", ArgumentSemantic.Strong)]
        string Language { get; }

        // @property (readonly, nonatomic, strong) NSString * vendorID;
        [Export("vendorID", ArgumentSemantic.Strong)]
        string VendorID { get; }

        // +(NSString *)generateUUID;
        [Static]
        [Export("generateUUID")]
        string GenerateUUID();
    }

    // @interface AMPIdentify : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPIdentify
    {
        // @property (readonly, nonatomic, strong) NSMutableDictionary * userPropertyOperations;
        [Export("userPropertyOperations", ArgumentSemantic.Strong)]
        NSMutableDictionary UserPropertyOperations { get; }

        // +(instancetype)identify;
        [Static]
        [Export("identify")]
        AMPIdentify Identify();

        // -(AMPIdentify *)add:(NSString *)property value:(NSObject *)value;
        [Export("add:value:")]
        AMPIdentify Add(string property, NSObject value);

        // -(AMPIdentify *)append:(NSString *)property value:(NSObject *)value;
        [Export("append:value:")]
        AMPIdentify Append(string property, NSObject value);

        // -(AMPIdentify *)clearAll;
        [Export("clearAll")]
        AMPIdentify ClearAll();

        // -(AMPIdentify *)prepend:(NSString *)property value:(NSObject *)value;
        [Export("prepend:value:")]
        AMPIdentify Prepend(string property, NSObject value);

        // -(AMPIdentify *)set:(NSString *)property value:(NSObject *)value;
        [Export("set:value:")]
        AMPIdentify Set(string property, NSObject value);

        // -(AMPIdentify *)setOnce:(NSString *)property value:(NSObject *)value;
        [Export("setOnce:value:")]
        AMPIdentify SetOnce(string property, NSObject value);

        // -(AMPIdentify *)unset:(NSString *)property;
        [Export("unset:")]
        AMPIdentify Unset(string property);

        // -(AMPIdentify *)preInsert:(NSString *)property value:(NSObject *)value;
        [Export("preInsert:value:")]
        AMPIdentify PreInsert(string property, NSObject value);

        // -(AMPIdentify *)postInsert:(NSString *)property value:(NSObject *)value;
        [Export("postInsert:value:")]
        AMPIdentify PostInsert(string property, NSObject value);

        // -(AMPIdentify *)remove:(NSString *)property value:(NSObject *)value;
        [Export("remove:value:")]
        AMPIdentify Remove(string property, NSObject value);
    }

    // @interface AMPRevenue : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPRevenue
    {
        // @property (readonly, nonatomic, strong) NSString * productId;
        [Export("productId", ArgumentSemantic.Strong)]
        string ProductId { get; }

        // @property (readonly, nonatomic, strong) NSNumber * price;
        [Export("price", ArgumentSemantic.Strong)]
        NSNumber Price { get; }

        // @property (readonly, nonatomic) NSInteger quantity;
        [Export("quantity")]
        nint Quantity { get; }

        // @property (readonly, nonatomic, strong) NSString * revenueType;
        [Export("revenueType", ArgumentSemantic.Strong)]
        string RevenueType { get; }

        // @property (readonly, nonatomic, strong) NSData * receipt;
        [Export("receipt", ArgumentSemantic.Strong)]
        NSData Receipt { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * properties;
        [Export("properties", ArgumentSemantic.Strong)]
        NSDictionary Properties { get; }

        // +(instancetype)revenue;
        [Static]
        [Export("revenue")]
        AMPRevenue Revenue();

        // -(BOOL)isValidRevenue;
        [Export("isValidRevenue")]
        bool IsValidRevenue { get; }

        // -(AMPRevenue *)setProductIdentifier:(NSString *)productIdentifier;
        [Export("setProductIdentifier:")]
        AMPRevenue SetProductIdentifier(string productIdentifier);

        // -(AMPRevenue *)setQuantity:(NSInteger)quantity;
        [Export("setQuantity:")]
        AMPRevenue SetQuantity(nint quantity);

        // -(AMPRevenue *)setPrice:(NSNumber *)price;
        [Export("setPrice:")]
        AMPRevenue SetPrice(NSNumber price);

        // -(AMPRevenue *)setRevenueType:(NSString *)revenueType;
        [Export("setRevenueType:")]
        AMPRevenue SetRevenueType(string revenueType);

        // -(AMPRevenue *)setReceipt:(NSData *)receipt;
        [Export("setReceipt:")]
        AMPRevenue SetReceipt(NSData receipt);

        // -(AMPRevenue *)setEventProperties:(NSDictionary *)eventProperties;
        [Export("setEventProperties:")]
        AMPRevenue SetEventProperties(NSDictionary eventProperties);

        // -(NSDictionary *)toNSDictionary;
        [Export("toNSDictionary")]
        NSDictionary ToNSDictionary();
    }

    // @interface AMPTrackingOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPTrackingOptions
    {
        // @property (readonly, nonatomic, strong) NSMutableSet * disabledFields;
        [Export("disabledFields", ArgumentSemantic.Strong)]
        NSMutableSet DisabledFields { get; }

        // -(AMPTrackingOptions *)disableCarrier;
        [Export("disableCarrier")]
        AMPTrackingOptions DisableCarrier();

        // -(AMPTrackingOptions *)disableCity;
        [Export("disableCity")]
        AMPTrackingOptions DisableCity();

        // -(AMPTrackingOptions *)disableCountry;
        [Export("disableCountry")]
        AMPTrackingOptions DisableCountry();

        // -(AMPTrackingOptions *)disableDeviceManufacturer;
        [Export("disableDeviceManufacturer")]
        AMPTrackingOptions DisableDeviceManufacturer();

        // -(AMPTrackingOptions *)disableDeviceModel;
        [Export("disableDeviceModel")]
        AMPTrackingOptions DisableDeviceModel();

        // -(AMPTrackingOptions *)disableDMA;
        [Export("disableDMA")]
        AMPTrackingOptions DisableDMA();

        // -(AMPTrackingOptions *)disableIDFA;
        [Export("disableIDFA")]
        AMPTrackingOptions DisableIDFA();

        // -(AMPTrackingOptions *)disableIDFV;
        [Export("disableIDFV")]
        AMPTrackingOptions DisableIDFV();

        // -(AMPTrackingOptions *)disableIPAddress;
        [Export("disableIPAddress")]
        AMPTrackingOptions DisableIPAddress();

        // -(AMPTrackingOptions *)disableLanguage;
        [Export("disableLanguage")]
        AMPTrackingOptions DisableLanguage();

        // -(AMPTrackingOptions *)disableLatLng;
        [Export("disableLatLng")]
        AMPTrackingOptions DisableLatLng();

        // -(AMPTrackingOptions *)disableOSName;
        [Export("disableOSName")]
        AMPTrackingOptions DisableOSName();

        // -(AMPTrackingOptions *)disableOSVersion;
        [Export("disableOSVersion")]
        AMPTrackingOptions DisableOSVersion();

        // -(AMPTrackingOptions *)disablePlatform;
        [Export("disablePlatform")]
        AMPTrackingOptions DisablePlatform();

        // -(AMPTrackingOptions *)disableRegion;
        [Export("disableRegion")]
        AMPTrackingOptions DisableRegion();

        // -(AMPTrackingOptions *)disableVersionName;
        [Export("disableVersionName")]
        AMPTrackingOptions DisableVersionName();

        // -(BOOL)shouldTrackCarrier;
        [Export("shouldTrackCarrier")]
        bool ShouldTrackCarrier();

        // -(BOOL)shouldTrackCity;
        [Export("shouldTrackCity")]
        bool ShouldTrackCity();

        // -(BOOL)shouldTrackCountry;
        [Export("shouldTrackCountry")]
        bool ShouldTrackCountry();

        // -(BOOL)shouldTrackDeviceManufacturer;
        [Export("shouldTrackDeviceManufacturer")]
        bool ShouldTrackDeviceManufacturer();

        // -(BOOL)shouldTrackDeviceModel;
        [Export("shouldTrackDeviceModel")]
        bool ShouldTrackDeviceModel();

        // -(BOOL)shouldTrackDMA;
        [Export("shouldTrackDMA")]
        bool ShouldTrackDMA();

        // -(BOOL)shouldTrackIDFA;
        [Export("shouldTrackIDFA")]
        bool ShouldTrackIDFA();

        // -(BOOL)shouldTrackIDFV;
        [Export("shouldTrackIDFV")]
        bool ShouldTrackIDFV();

        // -(BOOL)shouldTrackIPAddress;
        [Export("shouldTrackIPAddress")]
        bool ShouldTrackIPAddress();

        // -(BOOL)shouldTrackLanguage;
        [Export("shouldTrackLanguage")]
        bool ShouldTrackLanguage();

        // -(BOOL)shouldTrackLatLng;
        [Export("shouldTrackLatLng")]
        bool ShouldTrackLatLng();

        // -(BOOL)shouldTrackOSName;
        [Export("shouldTrackOSName")]
        bool ShouldTrackOSName();

        // -(BOOL)shouldTrackOSVersion;
        [Export("shouldTrackOSVersion")]
        bool ShouldTrackOSVersion();

        // -(BOOL)shouldTrackPlatform;
        [Export("shouldTrackPlatform")]
        bool ShouldTrackPlatform();

        // -(BOOL)shouldTrackRegion;
        [Export("shouldTrackRegion")]
        bool ShouldTrackRegion();

        // -(BOOL)shouldTrackVersionName;
        [Export("shouldTrackVersionName")]
        bool ShouldTrackVersionName();

        // -(NSMutableDictionary *)getApiPropertiesTrackingOption;
        [Export("getApiPropertiesTrackingOption")]
        NSMutableDictionary ApiPropertiesTrackingOption();

        // -(AMPTrackingOptions *)mergeIn:(AMPTrackingOptions *)options;
        [Export("mergeIn:")]
        AMPTrackingOptions MergeIn(AMPTrackingOptions options);

        // +(instancetype)options;
        [Static]
        [Export("options")]
        AMPTrackingOptions Options();

        // +(AMPTrackingOptions *)forCoppaControl;
        [Static]
        [Export("forCoppaControl")]
        AMPTrackingOptions ForCoppaControl();

        // +(AMPTrackingOptions *)copyOf:(AMPTrackingOptions *)origin;
        [Static]
        [Export("copyOf:")]
        AMPTrackingOptions CopyOf(AMPTrackingOptions origin);
    }

    // typedef NSString * _Nonnull (^AMPAdSupportBlock)();
    delegate string AMPAdSupportBlock();

    // typedef NSDictionary * _Nullable (^AMPLocationInfoBlock)();
    delegate NSDictionary AMPLocationInfoBlock();

    // @interface Amplitude : NSObject
    [BaseType(typeof(NSObject))]
    interface Amplitude
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull apiKey;
        [Export("apiKey")]
        string ApiKey { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable userId;
        [NullAllowed, Export("userId")]
        string UserId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable instanceName;
        [NullAllowed, Export("instanceName")]
        string InstanceName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable propertyListPath;
        [NullAllowed, Export("propertyListPath")]
        string PropertyListPath { get; }

        // @property (assign, readwrite, nonatomic) BOOL optOut;
        [Export("optOut")]
        bool OptOut { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL useDynamicConfig;
        [Export("useDynamicConfig")]
        bool UseDynamicConfig { get; set; }

        // @property (assign, nonatomic) int eventUploadThreshold;
        [Export("eventUploadThreshold")]
        int EventUploadThreshold { get; set; }

        // @property (assign, nonatomic) int eventUploadMaxBatchSize;
        [Export("eventUploadMaxBatchSize")]
        int EventUploadMaxBatchSize { get; set; }

        // @property (assign, nonatomic) int eventMaxCount;
        [Export("eventMaxCount")]
        int EventMaxCount { get; set; }

        // @property (assign, nonatomic) int eventUploadPeriodSeconds;
        [Export("eventUploadPeriodSeconds")]
        int EventUploadPeriodSeconds { get; set; }

        // @property (assign, nonatomic) long minTimeBetweenSessionsMillis;
        [Export("minTimeBetweenSessionsMillis")]
        nint MinTimeBetweenSessionsMillis { get; set; }

        // @property (assign, nonatomic) BOOL trackingSessionEvents;
        [Export("trackingSessionEvents")]
        bool TrackingSessionEvents { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable libraryName;
        [NullAllowed, Export("libraryName")]
        string LibraryName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable libraryVersion;
        [NullAllowed, Export("libraryVersion")]
        string LibraryVersion { get; set; }

        // @property (nonatomic, strong) AMPAdSupportBlock _Nullable adSupportBlock;
        [NullAllowed, Export("adSupportBlock", ArgumentSemantic.Strong)]
        AMPAdSupportBlock AdSupportBlock { get; set; }

        // @property (nonatomic, strong) AMPLocationInfoBlock _Nullable locationInfoBlock;
        [NullAllowed, Export("locationInfoBlock", ArgumentSemantic.Strong)]
        AMPLocationInfoBlock LocationInfoBlock { get; set; }

        // +(Amplitude * _Nonnull)instance;
        [Static]
        [Export("instance")]
        Amplitude Instance { get; }

        // +(Amplitude * _Nonnull)instanceWithName:(NSString * _Nullable)instanceName;
        [Static]
        [Export("instanceWithName:")]
        Amplitude InstanceWithName([NullAllowed] string instanceName);

        // -(void)initializeApiKey:(NSString * _Nonnull)apiKey;
        [Export("initializeApiKey:")]
        void InitializeApiKey(string apiKey);

        // -(void)initializeApiKey:(NSString * _Nonnull)apiKey userId:(NSString * _Nullable)userId;
        [Export("initializeApiKey:userId:")]
        void InitializeApiKey(string apiKey, [NullAllowed] string userId);

        // -(void)logEvent:(NSString * _Nonnull)eventType;
        [Export("logEvent:")]
        void LogEvent(string eventType);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties;
        [Export("logEvent:withEventProperties:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties outOfSession:(BOOL)outOfSession;
        [Export("logEvent:withEventProperties:outOfSession:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties, bool outOfSession);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups;
        [Export("logEvent:withEventProperties:withGroups:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups outOfSession:(BOOL)outOfSession;
        [Export("logEvent:withEventProperties:withGroups:outOfSession:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, bool outOfSession);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups withLongLongTimestamp:(long long)longLongTimestamp outOfSession:(BOOL)outOfSession;
        [Export("logEvent:withEventProperties:withGroups:withLongLongTimestamp:outOfSession:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, long longLongTimestamp, bool outOfSession);

        // -(void)logEvent:(NSString * _Nonnull)eventType withEventProperties:(NSDictionary * _Nullable)eventProperties withGroups:(NSDictionary * _Nullable)groups withTimestamp:(NSNumber * _Nonnull)timestamp outOfSession:(BOOL)outOfSession;
        [Export("logEvent:withEventProperties:withGroups:withTimestamp:outOfSession:")]
        void LogEvent(string eventType, [NullAllowed] NSDictionary eventProperties, [NullAllowed] NSDictionary groups, NSNumber timestamp, bool outOfSession);

        // -(void)logRevenue:(NSNumber * _Nonnull)amount __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
        [Export("logRevenue:")]
        void LogRevenue(NSNumber amount);

        // -(void)logRevenue:(NSString * _Nullable)productIdentifier quantity:(NSInteger)quantity price:(NSNumber * _Nonnull)price __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
        [Export("logRevenue:quantity:price:")]
        void LogRevenue([NullAllowed] string productIdentifier, nint quantity, NSNumber price);

        // -(void)logRevenue:(NSString * _Nullable)productIdentifier quantity:(NSInteger)quantity price:(NSNumber * _Nonnull)price receipt:(NSData * _Nullable)receipt __attribute__((deprecated("Use `logRevenueV2` and `AMPRevenue` instead")));
        [Export("logRevenue:quantity:price:receipt:")]
        void LogRevenue([NullAllowed] string productIdentifier, nint quantity, NSNumber price, [NullAllowed] NSData receipt);

        // -(void)logRevenueV2:(AMPRevenue * _Nonnull)revenue;
        [Export("logRevenueV2:")]
        void LogRevenueV2(AMPRevenue revenue);

        // -(void)identify:(AMPIdentify * _Nonnull)identify;
        [Export("identify:")]
        void Identify(AMPIdentify identify);

        // -(void)identify:(AMPIdentify * _Nonnull)identify outOfSession:(BOOL)outOfSession;
        [Export("identify:outOfSession:")]
        void Identify(AMPIdentify identify, bool outOfSession);

        // -(void)setUserProperties:(NSDictionary * _Nonnull)userProperties;
        [Export("setUserProperties:")]
        void SetUserProperties(NSDictionary userProperties);

        // -(void)setUserProperties:(NSDictionary * _Nonnull)userProperties replace:(BOOL)replace __attribute__((deprecated("Use `- setUserProperties` instead. In earlier versions of the SDK, `replace: YES` replaced the in-memory userProperties dictionary with the input. However, userProperties are no longer stored in memory, so the flag does nothing.")));
        [Export("setUserProperties:replace:")]
        void SetUserProperties(NSDictionary userProperties, bool replace);

        // -(void)clearUserProperties;
        [Export("clearUserProperties")]
        void ClearUserProperties();

        // -(void)setGroup:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName;
        [Export("setGroup:groupName:")]
        void SetGroup(string groupType, NSObject groupName);

        // -(void)groupIdentifyWithGroupType:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName groupIdentify:(AMPIdentify * _Nonnull)groupIdentify;
        [Export("groupIdentifyWithGroupType:groupName:groupIdentify:")]
        void GroupIdentifyWithGroupType(string groupType, NSObject groupName, AMPIdentify groupIdentify);

        // -(void)groupIdentifyWithGroupType:(NSString * _Nonnull)groupType groupName:(NSObject * _Nonnull)groupName groupIdentify:(AMPIdentify * _Nonnull)groupIdentify outOfSession:(BOOL)outOfSession;
        [Export("groupIdentifyWithGroupType:groupName:groupIdentify:outOfSession:")]
        void GroupIdentifyWithGroupType(string groupType, NSObject groupName, AMPIdentify groupIdentify, bool outOfSession);

        // -(void)setUserId:(NSString * _Nullable)userId;
        [Export("setUserId:")]
        void SetUserId([NullAllowed] string userId);

        // -(void)setUserId:(NSString * _Nullable)userId startNewSession:(BOOL)startNewSession;
        [Export("setUserId:startNewSession:")]
        void SetUserId([NullAllowed] string userId, bool startNewSession);

        // -(void)setOffline:(BOOL)offline;
        [Export("setOffline:")]
        void SetOffline(bool offline);

        // -(void)useAdvertisingIdForDeviceId;
        [Export("useAdvertisingIdForDeviceId")]
        void UseAdvertisingIdForDeviceId();

        // -(void)setTrackingOptions:(AMPTrackingOptions * _Nonnull)options;
        [Export("setTrackingOptions:")]
        void SetTrackingOptions(AMPTrackingOptions options);

        // -(void)enableCoppaControl;
        [Export("enableCoppaControl")]
        void EnableCoppaControl();

        // -(void)disableCoppaControl;
        [Export("disableCoppaControl")]
        void DisableCoppaControl();

        // -(void)setServerUrl:(NSString * _Nonnull)serverUrl;
        [Export("setServerUrl:")]
        void SetServerUrl(string serverUrl);

        // -(void)setBearerToken:(NSString * _Nonnull)token;
        [Export("setBearerToken:")]
        void SetBearerToken(string token);

        // -(void)printEventsCount;
        [Export("printEventsCount")]
        void PrintEventsCount();

        [Export("deviceId")]
        string DeviceId { [Bind("getDeviceId")] get; set; }

        // -(void)regenerateDeviceId;
        [Export("regenerateDeviceId")]
        void RegenerateDeviceId();

        // -(long long)getSessionId;
        [Export("getSessionId")]
        long SessionId { get; }

        // -(void)setSessionId:(long long)timestamp;
        [Export("setSessionId:")]
        void SetSessionId(long timestamp);

        // -(void)uploadEvents;
        [Export("uploadEvents")]
        void UploadEvents();

        // -(BOOL)startOrContinueSession:(long long)timestamp;
        [Export("startOrContinueSession:")]
        bool StartOrContinueSession(long timestamp);

        [Export("contentTypeHeader")]
        string ContentTypeHeader { [Bind("getContentTypeHeader")] get; set; }
    }

    [Static]
    partial interface SessionEventConstants
    {
        // extern NSString *const _Nonnull kAMPSessionStartEvent;
        [Field("kAMPSessionStartEvent", "__Internal")]
        NSString kAMPSessionStartEvent { get; }

        // extern NSString *const _Nonnull kAMPSessionEndEvent;
        [Field("kAMPSessionEndEvent", "__Internal")]
        NSString kAMPSessionEndEvent { get; }

        // extern NSString *const _Nonnull kAMPRevenueEvent;
        [Field("kAMPRevenueEvent", "__Internal")]
        NSString kAMPRevenueEvent { get; }
    }

    // @interface SSLPinning (Amplitude)
    [Category]
    [BaseType(typeof(Amplitude))]
    interface Amplitude_SSLPinning
    {
    }

    // @interface  (Amplitude)
    [Category]
    [BaseType(typeof(Amplitude))]
    interface Amplitude_
    {
        [Export("apiKey")]
        string GetApiKey();

        [Export("setApiKey:")]
        void SetApiKey(string apiKey);

        [Export("instanceName")]
        string GetInstanceName();

        [Export("setInstanceName:")]
        void SetInstanceName(string instanceName);
    }

    // @interface AMPUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface AMPUtils
    {
        // +(NSString *)generateUUID;
        [Static]
        [Export("generateUUID")]
        string GenerateUUID();

        // +(id)makeJSONSerializable:(id)obj;
        [Static]
        [Export("makeJSONSerializable:")]
        NSObject MakeJSONSerializable(NSObject obj);

        // +(BOOL)isEmptyString:(NSString *)str;
        [Static]
        [Export("isEmptyString:")]
        bool IsEmptyString(string str);

        // +(NSDictionary *)validateGroups:(NSDictionary *)obj;
        [Static]
        [Export("validateGroups:")]
        NSDictionary ValidateGroups(NSDictionary obj);

        // +(NSString *)platformDataDirectory;
        [Static]
        [Export("platformDataDirectory")]
        string PlatformDataDirectory { get; }

        // +(UIApplication *)getSharedApplication;
        [Static]
        [Export("getSharedApplication")]
        UIApplication SharedApplication { get; }

        // +(NSInteger)barBottomOffset;
        [Static]
        [Export("barBottomOffset")]
        nint BarBottomOffset { get; }

        // +(CGFloat)statusBarHeight;
        [Static]
        [Export("statusBarHeight")]
        nfloat StatusBarHeight { get; }

        // +(UIWindow *)getKeyWindow;
        [Static]
        [Export("getKeyWindow")]
        UIWindow KeyWindow { get; }
    }
}
