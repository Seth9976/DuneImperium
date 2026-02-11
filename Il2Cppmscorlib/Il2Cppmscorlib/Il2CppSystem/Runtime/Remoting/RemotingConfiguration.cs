using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200029A RID: 666
	public static class RemotingConfiguration : Object
	{
		// Token: 0x06002A8B RID: 10891 RVA: 0x000E1F68 File Offset: 0x000E0168
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingConfiguration()
		{
			Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr);
			RemotingConfiguration.NativeFieldInfoPtr_applicationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationID");
			RemotingConfiguration.NativeFieldInfoPtr_applicationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationName");
			RemotingConfiguration.NativeFieldInfoPtr_processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "processGuid");
			RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultDelayedConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr__errorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "_errorMode");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_channelTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "channelTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "clientProviderTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "serverProviderTemplates");
			RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670217);
			RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670218);
			RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670219);
			RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670220);
			RemotingConfiguration.NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670221);
			RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670222);
			RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670223);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670224);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670225);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670226);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670227);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670228);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670229);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670230);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670231);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670232);
			RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670233);
			RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100670234);
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000E2204 File Offset: 0x000E0404
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x000E2230 File Offset: 0x000E0430
		public unsafe static string ApplicationName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377124, XrefRangeEnd = 1377128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377128, XrefRangeEnd = 1377134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000E2268 File Offset: 0x000E0468
		public unsafe static string ProcessId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1377147, RefRangeEnd = 1377150, XrefRangeStart = 1377134, XrefRangeEnd = 1377147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000E2294 File Offset: 0x000E0494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377202, RefRangeEnd = 1377203, XrefRangeStart = 1377150, XrefRangeEnd = 1377202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadDefaultDelayedChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000E22BC File Offset: 0x000E04BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377214, RefRangeEnd = 1377215, XrefRangeStart = 1377203, XrefRangeEnd = 1377214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsActivationAllowed(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000E2300 File Offset: 0x000E0500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377229, RefRangeEnd = 1377230, XrefRangeStart = 1377215, XrefRangeEnd = 1377229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivatedClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000E2344 File Offset: 0x000E0544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377244, RefRangeEnd = 1377245, XrefRangeStart = 1377230, XrefRangeEnd = 1377244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WellKnownClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000E2388 File Offset: 0x000E0588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377263, RefRangeEnd = 1377264, XrefRangeStart = 1377245, XrefRangeEnd = 1377263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000E23C0 File Offset: 0x000E05C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377275, RefRangeEnd = 1377276, XrefRangeStart = 1377264, XrefRangeEnd = 1377275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000E23F8 File Offset: 0x000E05F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377294, RefRangeEnd = 1377295, XrefRangeStart = 1377276, XrefRangeEnd = 1377294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000E2430 File Offset: 0x000E0630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377310, RefRangeEnd = 1377311, XrefRangeStart = 1377295, XrefRangeEnd = 1377310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000E2468 File Offset: 0x000E0668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377311, XrefRangeEnd = 1377316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelTemplate(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000E24A0 File Offset: 0x000E06A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377316, XrefRangeEnd = 1377321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterClientProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000E24D8 File Offset: 0x000E06D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377321, XrefRangeEnd = 1377326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000E2510 File Offset: 0x000E0710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377392, RefRangeEnd = 1377393, XrefRangeStart = 1377326, XrefRangeEnd = 1377392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyDelayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000E2554 File Offset: 0x000E0754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377437, RefRangeEnd = 1377438, XrefRangeStart = 1377393, XrefRangeEnd = 1377437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypes(ArrayList types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000E258C File Offset: 0x000E078C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377444, RefRangeEnd = 1377445, XrefRangeStart = 1377438, XrefRangeEnd = 1377444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLocalRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000E25CC File Offset: 0x000E07CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1377472, RefRangeEnd = 1377473, XrefRangeStart = 1377445, XrefRangeEnd = 1377472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCustomErrorsMode(string mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0000E283 File Offset: 0x0000C483
		public RemotingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x000E2604 File Offset: 0x000E0804
		// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x0000E28C File Offset: 0x0000C48C
		public unsafe static string applicationID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000E2624 File Offset: 0x000E0824
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x0000E29E File Offset: 0x0000C49E
		public unsafe static string applicationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000E2644 File Offset: 0x000E0844
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		public unsafe static string processGuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000E2664 File Offset: 0x000E0864
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
		public unsafe static bool defaultConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000E2680 File Offset: 0x000E0880
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public unsafe static bool defaultDelayedConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000E269C File Offset: 0x000E089C
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x0000E2DE File Offset: 0x0000C4DE
		public unsafe static CustomErrorsModes _errorMode
		{
			get
			{
				CustomErrorsModes customErrorsModes;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, (void*)(&customErrorsModes));
				return customErrorsModes;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, (void*)(&value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000E26B8 File Offset: 0x000E08B8
		// (set) Token: 0x06002AAC RID: 10924 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		public unsafe static Hashtable wellKnownClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000E26E0 File Offset: 0x000E08E0
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x0000E2FE File Offset: 0x0000C4FE
		public unsafe static Hashtable activatedClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000E2708 File Offset: 0x000E0908
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0000E310 File Offset: 0x0000C510
		public unsafe static Hashtable wellKnownServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000E2730 File Offset: 0x000E0930
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0000E322 File Offset: 0x0000C522
		public unsafe static Hashtable activatedServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000E2758 File Offset: 0x000E0958
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x0000E334 File Offset: 0x0000C534
		public unsafe static Hashtable channelTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000E2780 File Offset: 0x000E0980
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0000E346 File Offset: 0x0000C546
		public unsafe static Hashtable clientProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x000E27A8 File Offset: 0x000E09A8
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0000E358 File Offset: 0x0000C558
		public unsafe static Hashtable serverProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_applicationID;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeFieldInfoPtr_applicationName;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeFieldInfoPtr_processGuid;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeFieldInfoPtr_defaultConfigRead;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeFieldInfoPtr_defaultDelayedConfigRead;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeFieldInfoPtr__errorMode;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownClientEntries;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeFieldInfoPtr_activatedClientEntries;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownServiceEntries;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeFieldInfoPtr_activatedServiceEntries;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeFieldInfoPtr_channelTemplates;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeFieldInfoPtr_clientProviderTemplates;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeFieldInfoPtr_serverProviderTemplates;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0;
	}
}
