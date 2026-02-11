using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class AppLinkingConfiguration : Object
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000324C File Offset: 0x0000144C
		// Note: this type is marked as 'beforefieldinit'.
		static AppLinkingConfiguration()
		{
			Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "AppLinkingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr);
			AppLinkingConfiguration.NativeFieldInfoPtr__steamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_steamId");
			AppLinkingConfiguration.NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_displayName");
			AppLinkingConfiguration.NativeFieldInfoPtr__globalConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_globalConfiguration");
			AppLinkingConfiguration.NativeFieldInfoPtr__customDeepLinkingProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_customDeepLinkingProtocols");
			AppLinkingConfiguration.NativeFieldInfoPtr__testDeepLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_testDeepLinks");
			AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_automaticDeferralExe");
			AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExeDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "_automaticDeferralExeDebug");
			AppLinkingConfiguration.NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferral_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663339);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferral_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663340);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferralForDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663341);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferralForDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663342);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_SteamId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663343);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_SteamId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663344);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663345);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663346);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663347);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663348);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_DebugDeeplinks_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663349);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_DebugDeeplinks_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663350);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_CustomDeepLinkingProtocols_Public_get_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663351);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_CustomDeepLinkingProtocols_Public_set_Void_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663352);
			AppLinkingConfiguration.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663353);
			AppLinkingConfiguration.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663354);
			AppLinkingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663355);
			AppLinkingConfiguration.NativeMethodInfoPtr_EnsureAllPlats_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663356);
			AppLinkingConfiguration.NativeMethodInfoPtr_GetPlatformDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663357);
			AppLinkingConfiguration.NativeMethodInfoPtr_GetPlatformDomainProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663358);
			AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomOrDefault_Private_List_1_LinkInformation_SupportedPlatforms_Func_2_PlatformLinkingConfiguration_List_1_LinkInformation_Boolean_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663359);
			AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663360);
			AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomDomainAssociation_Public_List_1_LinkInformation_SupportedPlatforms_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663361);
			AppLinkingConfiguration.NativeMethodInfoPtr_ActivatePlatformOverride_Public_Void_SupportedPlatforms_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663362);
			AppLinkingConfiguration.NativeMethodInfoPtr_DeactivatePlatformOverride_Public_Void_SupportedPlatforms_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663363);
			AppLinkingConfiguration.NativeMethodInfoPtr_EnsureAllPlats_Private_Il2CppReferenceArray_1_PlatformLinkingConfiguration_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, 100663364);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003510 File Offset: 0x00001710
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000354C File Offset: 0x0000174C
		public unsafe bool StandaloneWindowsLinuxAutoDeferral
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferral_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferral_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000358C File Offset: 0x0000178C
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000035C8 File Offset: 0x000017C8
		public unsafe bool StandaloneWindowsLinuxAutoDeferralForDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferralForDebug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferralForDebug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003608 File Offset: 0x00001808
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00003640 File Offset: 0x00001840
		public unsafe string SteamId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_SteamId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_SteamId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003684 File Offset: 0x00001884
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000036C4 File Offset: 0x000018C4
		public unsafe List<LinkInformation> DeepLinkingProtocols
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374429, RefRangeEnd = 374430, XrefRangeStart = 374429, XrefRangeEnd = 374430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240469, XrefRangeEnd = 1240471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe List<LinkInformation> DomainProtocols
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 374430, RefRangeEnd = 374432, XrefRangeStart = 374430, XrefRangeEnd = 374432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240471, XrefRangeEnd = 1240473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000378C File Offset: 0x0000198C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000037CC File Offset: 0x000019CC
		public unsafe Il2CppStringArray DebugDeeplinks
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_DebugDeeplinks_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_DebugDeeplinks_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003810 File Offset: 0x00001A10
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00003850 File Offset: 0x00001A50
		public unsafe Il2CppReferenceArray<PlatformLinkingConfiguration> CustomDeepLinkingProtocols
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_CustomDeepLinkingProtocols_Public_get_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlatformLinkingConfiguration>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240473, XrefRangeEnd = 1240476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_CustomDeepLinkingProtocols_Public_set_Void_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003894 File Offset: 0x00001A94
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000038CC File Offset: 0x00001ACC
		public unsafe string DisplayName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003910 File Offset: 0x00001B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240476, XrefRangeEnd = 1240503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppLinkingConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000394C File Offset: 0x00001B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240503, XrefRangeEnd = 1240506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureAllPlats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_EnsureAllPlats_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003980 File Offset: 0x00001B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240522, RefRangeEnd = 1240524, XrefRangeStart = 1240506, XrefRangeEnd = 1240522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LinkInformation> GetPlatformDeepLinkingProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref plat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_GetPlatformDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000039DC File Offset: 0x00001BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240524, XrefRangeEnd = 1240540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LinkInformation> GetPlatformDomainProtocols(SupportedPlatforms plat, bool includeDefault = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref plat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_GetPlatformDomainProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003A38 File Offset: 0x00001C38
		[CallerCount(0)]
		public unsafe List<LinkInformation> GetCustomOrDefault(SupportedPlatforms plat, Func<PlatformLinkingConfiguration, List<LinkInformation>> func, bool includeDefault, List<LinkInformation> global)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref plat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDefault;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(global);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomOrDefault_Private_List_1_LinkInformation_SupportedPlatforms_Func_2_PlatformLinkingConfiguration_List_1_LinkInformation_Boolean_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[CallerCount(0)]
		public unsafe List<LinkInformation> GetCustomDeepLinkingProtocols(SupportedPlatforms value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003B04 File Offset: 0x00001D04
		[CallerCount(0)]
		public unsafe List<LinkInformation> GetCustomDomainAssociation(SupportedPlatforms value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_GetCustomDomainAssociation_Public_List_1_LinkInformation_SupportedPlatforms_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003B50 File Offset: 0x00001D50
		[CallerCount(0)]
		public unsafe void ActivatePlatformOverride(SupportedPlatforms value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_ActivatePlatformOverride_Public_Void_SupportedPlatforms_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003B90 File Offset: 0x00001D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240540, XrefRangeEnd = 1240543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivatePlatformOverride(SupportedPlatforms value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_DeactivatePlatformOverride_Public_Void_SupportedPlatforms_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240566, RefRangeEnd = 1240569, XrefRangeStart = 1240543, XrefRangeEnd = 1240566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<PlatformLinkingConfiguration> EnsureAllPlats(Il2CppReferenceArray<PlatformLinkingConfiguration> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.NativeMethodInfoPtr_EnsureAllPlats_Private_Il2CppReferenceArray_1_PlatformLinkingConfiguration_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlatformLinkingConfiguration>>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002152 File Offset: 0x00000352
		public AppLinkingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003C20 File Offset: 0x00001E20
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000215B File Offset: 0x0000035B
		public unsafe string _steamId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__steamId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__steamId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000217A File Offset: 0x0000037A
		public unsafe string _displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003C70 File Offset: 0x00001E70
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002199 File Offset: 0x00000399
		public unsafe PlatformLinkingConfiguration _globalConfiguration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__globalConfiguration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformLinkingConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__globalConfiguration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003CA0 File Offset: 0x00001EA0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000021B8 File Offset: 0x000003B8
		public unsafe Il2CppReferenceArray<PlatformLinkingConfiguration> _customDeepLinkingProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__customDeepLinkingProtocols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlatformLinkingConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__customDeepLinkingProtocols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003CD0 File Offset: 0x00001ED0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000021D7 File Offset: 0x000003D7
		public unsafe Il2CppStringArray _testDeepLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__testDeepLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__testDeepLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003D00 File Offset: 0x00001F00
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe bool _automaticDeferralExe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExe)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003D28 File Offset: 0x00001F28
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002211 File Offset: 0x00000411
		public unsafe bool _automaticDeferralExeDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExeDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppLinkingConfiguration.NativeFieldInfoPtr__automaticDeferralExeDebug)) = value;
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__steamId;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__displayName;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__globalConfiguration;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__customDeepLinkingProtocols;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__testDeepLinks;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr__automaticDeferralExe;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr__automaticDeferralExeDebug;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferral_Public_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferral_Public_set_Void_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_StandaloneWindowsLinuxAutoDeferralForDebug_Public_get_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_StandaloneWindowsLinuxAutoDeferralForDebug_Public_set_Void_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_get_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_set_SteamId_Public_set_Void_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugDeeplinks_Public_get_Il2CppStringArray_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugDeeplinks_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomDeepLinkingProtocols_Public_get_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_CustomDeepLinkingProtocols_Public_set_Void_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAllPlats_Internal_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformDomainProtocols_Public_List_1_LinkInformation_SupportedPlatforms_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomOrDefault_Private_List_1_LinkInformation_SupportedPlatforms_Func_2_PlatformLinkingConfiguration_List_1_LinkInformation_Boolean_List_1_LinkInformation_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomDeepLinkingProtocols_Public_List_1_LinkInformation_SupportedPlatforms_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomDomainAssociation_Public_List_1_LinkInformation_SupportedPlatforms_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_ActivatePlatformOverride_Public_Void_SupportedPlatforms_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_DeactivatePlatformOverride_Public_Void_SupportedPlatforms_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAllPlats_Private_Il2CppReferenceArray_1_PlatformLinkingConfiguration_Il2CppReferenceArray_1_PlatformLinkingConfiguration_0;

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("ImaginationOverflow.UniversalDeepLinking.AppLinkingConfiguration+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600015B RID: 347 RVA: 0x0000754C File Offset: 0x0000574C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppLinkingConfiguration>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr);
				AppLinkingConfiguration.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, "<>9");
				AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, "<>9__33_0");
				AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, "<>9__34_0");
				AppLinkingConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, 100663366);
				AppLinkingConfiguration.__c.NativeMethodInfoPtr__GetPlatformDeepLinkingProtocols_b__33_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, 100663367);
				AppLinkingConfiguration.__c.NativeMethodInfoPtr__GetPlatformDomainProtocols_b__34_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr, 100663368);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x000075F0 File Offset: 0x000057F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppLinkingConfiguration.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x0000762C File Offset: 0x0000582C
			[CallerCount(0)]
			public unsafe List<LinkInformation> _GetPlatformDeepLinkingProtocols_b__33_0(PlatformLinkingConfiguration c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.__c.NativeMethodInfoPtr__GetPlatformDeepLinkingProtocols_b__33_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x0000767C File Offset: 0x0000587C
			[CallerCount(0)]
			public unsafe List<LinkInformation> _GetPlatformDomainProtocols_b__34_0(PlatformLinkingConfiguration c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppLinkingConfiguration.__c.NativeMethodInfoPtr__GetPlatformDomainProtocols_b__34_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
				}
			}

			// Token: 0x0600015F RID: 351 RVA: 0x0000278A File Offset: 0x0000098A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000160 RID: 352 RVA: 0x000076CC File Offset: 0x000058CC
			// (set) Token: 0x06000161 RID: 353 RVA: 0x00002793 File Offset: 0x00000993
			public unsafe static AppLinkingConfiguration.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppLinkingConfiguration.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000162 RID: 354 RVA: 0x000076F4 File Offset: 0x000058F4
			// (set) Token: 0x06000163 RID: 355 RVA: 0x000027A5 File Offset: 0x000009A5
			public unsafe static Func<PlatformLinkingConfiguration, List<LinkInformation>> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlatformLinkingConfiguration, List<LinkInformation>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000164 RID: 356 RVA: 0x0000771C File Offset: 0x0000591C
			// (set) Token: 0x06000165 RID: 357 RVA: 0x000027B7 File Offset: 0x000009B7
			public unsafe static Func<PlatformLinkingConfiguration, List<LinkInformation>> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlatformLinkingConfiguration, List<LinkInformation>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppLinkingConfiguration.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000EF RID: 239
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000F0 RID: 240
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x040000F2 RID: 242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000F3 RID: 243
			private static readonly IntPtr NativeMethodInfoPtr__GetPlatformDeepLinkingProtocols_b__33_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0;

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeMethodInfoPtr__GetPlatformDomainProtocols_b__34_0_Internal_List_1_LinkInformation_PlatformLinkingConfiguration_0;
		}
	}
}
