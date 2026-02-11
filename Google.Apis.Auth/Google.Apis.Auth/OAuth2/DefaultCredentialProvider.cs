using System;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200000C RID: 12
	public class DefaultCredentialProvider : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00008798 File Offset: 0x00006998
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultCredentialProvider()
		{
			Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "DefaultCredentialProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr);
			DefaultCredentialProvider.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "Logger");
			DefaultCredentialProvider.NativeFieldInfoPtr_CredentialEnvironmentVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "CredentialEnvironmentVariable");
			DefaultCredentialProvider.NativeFieldInfoPtr_WellKnownCredentialsFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "WellKnownCredentialsFile");
			DefaultCredentialProvider.NativeFieldInfoPtr_AppdataEnvironmentVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "AppdataEnvironmentVariable");
			DefaultCredentialProvider.NativeFieldInfoPtr_HomeEnvironmentVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "HomeEnvironmentVariable");
			DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "CloudSDKConfigDirectoryWindows");
			DefaultCredentialProvider.NativeFieldInfoPtr_HelpPermalink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "HelpPermalink");
			DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryUnix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "CloudSDKConfigDirectoryUnix");
			DefaultCredentialProvider.NativeFieldInfoPtr_cachedCredentialTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "cachedCredentialTask");
			DefaultCredentialProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663442);
			DefaultCredentialProvider.NativeMethodInfoPtr_GetDefaultCredentialAsync_Public_Task_1_GoogleCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663443);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialAsync_Private_Task_1_GoogleCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663444);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromFile_Private_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663445);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromStream_Internal_GoogleCredential_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663446);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromJson_Internal_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663447);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromParameters_Private_Static_GoogleCredential_JsonCredentialParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663448);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateUserCredentialFromParameters_Private_Static_UserCredential_JsonCredentialParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663449);
			DefaultCredentialProvider.NativeMethodInfoPtr_CreateServiceAccountCredentialFromParameters_Private_Static_ServiceAccountCredential_JsonCredentialParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663450);
			DefaultCredentialProvider.NativeMethodInfoPtr_GetWellKnownCredentialFilePath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663451);
			DefaultCredentialProvider.NativeMethodInfoPtr_GetEnvironmentVariable_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663452);
			DefaultCredentialProvider.NativeMethodInfoPtr_GetStream_Protected_Virtual_New_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, 100663453);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000896C File Offset: 0x00006B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153308, XrefRangeEnd = 1153322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultCredentialProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000089A8 File Offset: 0x00006BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153322, XrefRangeEnd = 1153326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<GoogleCredential> GetDefaultCredentialAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_GetDefaultCredentialAsync_Public_Task_1_GoogleCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleCredential>>(intPtr3) : null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000089E8 File Offset: 0x00006BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153326, XrefRangeEnd = 1153340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<GoogleCredential> CreateDefaultCredentialAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialAsync_Private_Task_1_GoogleCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleCredential>>(intPtr3) : null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008A28 File Offset: 0x00006C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1153361, RefRangeEnd = 1153363, XrefRangeStart = 1153340, XrefRangeEnd = 1153361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleCredential CreateDefaultCredentialFromFile(string credentialPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(credentialPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromFile_Private_GoogleCredential_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008A78 File Offset: 0x00006C78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1153385, RefRangeEnd = 1153389, XrefRangeStart = 1153363, XrefRangeEnd = 1153385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleCredential CreateDefaultCredentialFromStream(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromStream_Internal_GoogleCredential_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008AC8 File Offset: 0x00006CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1153411, RefRangeEnd = 1153412, XrefRangeStart = 1153389, XrefRangeEnd = 1153411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleCredential CreateDefaultCredentialFromJson(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromJson_Internal_GoogleCredential_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008B18 File Offset: 0x00006D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1153439, RefRangeEnd = 1153441, XrefRangeStart = 1153412, XrefRangeEnd = 1153439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential CreateDefaultCredentialFromParameters(JsonCredentialParameters credentialParameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credentialParameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateDefaultCredentialFromParameters_Private_Static_GoogleCredential_JsonCredentialParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008B5C File Offset: 0x00006D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1153473, RefRangeEnd = 1153474, XrefRangeStart = 1153441, XrefRangeEnd = 1153473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UserCredential CreateUserCredentialFromParameters(JsonCredentialParameters credentialParameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credentialParameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateUserCredentialFromParameters_Private_Static_UserCredential_JsonCredentialParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008BA0 File Offset: 0x00006DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1153503, RefRangeEnd = 1153504, XrefRangeStart = 1153474, XrefRangeEnd = 1153503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceAccountCredential CreateServiceAccountCredentialFromParameters(JsonCredentialParameters credentialParameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credentialParameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_CreateServiceAccountCredentialFromParameters_Private_Static_ServiceAccountCredential_JsonCredentialParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008BE4 File Offset: 0x00006DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153504, XrefRangeEnd = 1153548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetWellKnownCredentialFilePath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider.NativeMethodInfoPtr_GetWellKnownCredentialFilePath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008C1C File Offset: 0x00006E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153548, XrefRangeEnd = 1153549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetEnvironmentVariable(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultCredentialProvider.NativeMethodInfoPtr_GetEnvironmentVariable_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008C70 File Offset: 0x00006E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153549, XrefRangeEnd = 1153553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream GetStream(string filePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultCredentialProvider.NativeMethodInfoPtr_GetStream_Protected_Virtual_New_Stream_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002374 File Offset: 0x00000574
		public DefaultCredentialProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00008CCC File Offset: 0x00006ECC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000237D File Offset: 0x0000057D
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00008CF4 File Offset: 0x00006EF4
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000238F File Offset: 0x0000058F
		public unsafe static string CredentialEnvironmentVariable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_CredentialEnvironmentVariable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_CredentialEnvironmentVariable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00008D14 File Offset: 0x00006F14
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023A1 File Offset: 0x000005A1
		public unsafe static string WellKnownCredentialsFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_WellKnownCredentialsFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_WellKnownCredentialsFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008D34 File Offset: 0x00006F34
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023B3 File Offset: 0x000005B3
		public unsafe static string AppdataEnvironmentVariable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_AppdataEnvironmentVariable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_AppdataEnvironmentVariable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00008D54 File Offset: 0x00006F54
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000023C5 File Offset: 0x000005C5
		public unsafe static string HomeEnvironmentVariable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_HomeEnvironmentVariable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_HomeEnvironmentVariable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00008D74 File Offset: 0x00006F74
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023D7 File Offset: 0x000005D7
		public unsafe static string CloudSDKConfigDirectoryWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryWindows, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryWindows, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00008D94 File Offset: 0x00006F94
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000023E9 File Offset: 0x000005E9
		public unsafe static string HelpPermalink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_HelpPermalink, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_HelpPermalink, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00008DB4 File Offset: 0x00006FB4
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000023FB File Offset: 0x000005FB
		public unsafe static string CloudSDKConfigDirectoryUnix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryUnix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultCredentialProvider.NativeFieldInfoPtr_CloudSDKConfigDirectoryUnix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00008DD4 File Offset: 0x00006FD4
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe Lazy<Task<GoogleCredential>> cachedCredentialTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider.NativeFieldInfoPtr_cachedCredentialTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<Task<GoogleCredential>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider.NativeFieldInfoPtr_cachedCredentialTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_CredentialEnvironmentVariable;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_WellKnownCredentialsFile;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_AppdataEnvironmentVariable;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_HomeEnvironmentVariable;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_CloudSDKConfigDirectoryWindows;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_HelpPermalink;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_CloudSDKConfigDirectoryUnix;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_cachedCredentialTask;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCredentialAsync_Public_Task_1_GoogleCredential_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultCredentialAsync_Private_Task_1_GoogleCredential_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultCredentialFromFile_Private_GoogleCredential_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultCredentialFromStream_Internal_GoogleCredential_Stream_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultCredentialFromJson_Internal_GoogleCredential_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultCredentialFromParameters_Private_Static_GoogleCredential_JsonCredentialParameters_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_CreateUserCredentialFromParameters_Private_Static_UserCredential_JsonCredentialParameters_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_CreateServiceAccountCredentialFromParameters_Private_Static_ServiceAccountCredential_JsonCredentialParameters_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetWellKnownCredentialFilePath_Private_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Protected_Virtual_New_String_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetStream_Protected_Virtual_New_Stream_String_0;

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("Google.Apis.Auth.OAuth2.DefaultCredentialProvider+<CreateDefaultCredentialAsync>d__11")]
		public sealed class _CreateDefaultCredentialAsync_d__11 : ValueType
		{
			// Token: 0x06000430 RID: 1072 RVA: 0x000153B0 File Offset: 0x000135B0
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateDefaultCredentialAsync_d__11()
			{
				Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultCredentialProvider>.NativeClassPtr, "<CreateDefaultCredentialAsync>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr);
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, "<>1__state");
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, "<>t__builder");
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, "<>4__this");
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, "<>u__1");
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, 100663455);
				DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr, 100663456);
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00015454 File Offset: 0x00013654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153183, XrefRangeEnd = 1153302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x0001548C File Offset: 0x0001368C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153302, XrefRangeEnd = 1153308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0000408F File Offset: 0x0000228F
			public _CreateDefaultCredentialAsync_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00004098 File Offset: 0x00002298
			public _CreateDefaultCredentialAsync_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x000154D4 File Offset: 0x000136D4
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x000040AA File Offset: 0x000022AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x000154FC File Offset: 0x000136FC
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x000040C5 File Offset: 0x000022C5
			public AsyncTaskMethodBuilder<GoogleCredential> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<GoogleCredential>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleCredential>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleCredential>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001552C File Offset: 0x0001372C
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x000040F3 File Offset: 0x000022F3
			public unsafe DefaultCredentialProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultCredentialProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001555C File Offset: 0x0001375C
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x00004112 File Offset: 0x00002312
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCredentialProvider._CreateDefaultCredentialAsync_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
