using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Metadata;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200009B RID: 155
	public class LocalizationSettings : ScriptableObject
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x000262A8 File Offset: 0x000244A8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationSettings()
		{
			Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "LocalizationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr);
			LocalizationSettings.NativeFieldInfoPtr_ConfigName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "ConfigName");
			LocalizationSettings.NativeFieldInfoPtr_ConfigEditorLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "ConfigEditorLocale");
			LocalizationSettings.NativeFieldInfoPtr_IgnoreSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "IgnoreSettings");
			LocalizationSettings.NativeFieldInfoPtr_LocaleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "LocaleLabel");
			LocalizationSettings.NativeFieldInfoPtr_PreloadLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "PreloadLabel");
			LocalizationSettings.NativeFieldInfoPtr_m_StartupSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_StartupSelectors");
			LocalizationSettings.NativeFieldInfoPtr_m_AvailableLocales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_AvailableLocales");
			LocalizationSettings.NativeFieldInfoPtr_m_AssetDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_AssetDatabase");
			LocalizationSettings.NativeFieldInfoPtr_m_StringDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_StringDatabase");
			LocalizationSettings.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_Metadata");
			LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocaleIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_ProjectLocaleIdentifier");
			LocalizationSettings.NativeFieldInfoPtr_m_PreloadBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_PreloadBehavior");
			LocalizationSettings.NativeFieldInfoPtr_m_InitializeSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_InitializeSynchronously");
			LocalizationSettings.NativeFieldInfoPtr_m_InitializingOperationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_InitializingOperationHandle");
			LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_SelectedLocaleAsync");
			LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_ProjectLocale");
			LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "m_SelectedLocaleChanged");
			LocalizationSettings.NativeFieldInfoPtr__IsChangingSelectedLocale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "<IsChangingSelectedLocale>k__BackingField");
			LocalizationSettings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "s_Instance");
			LocalizationSettings.NativeMethodInfoPtr_get_IsChangingSelectedLocale_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664639);
			LocalizationSettings.NativeMethodInfoPtr_set_IsChangingSelectedLocale_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664640);
			LocalizationSettings.NativeMethodInfoPtr_get_HasSelectedLocaleChangedSubscribers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664641);
			LocalizationSettings.NativeMethodInfoPtr_add_OnSelectedLocaleChanged_Public_add_Void_Action_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664642);
			LocalizationSettings.NativeMethodInfoPtr_remove_OnSelectedLocaleChanged_Public_rem_Void_Action_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664643);
			LocalizationSettings.NativeMethodInfoPtr_get_HasSettings_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664644);
			LocalizationSettings.NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664645);
			LocalizationSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664646);
			LocalizationSettings.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664647);
			LocalizationSettings.NativeMethodInfoPtr_get_StartupLocaleSelectors_Public_Static_get_List_1_IStartupLocaleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664648);
			LocalizationSettings.NativeMethodInfoPtr_get_AvailableLocales_Public_Static_get_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664649);
			LocalizationSettings.NativeMethodInfoPtr_set_AvailableLocales_Public_Static_set_Void_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664650);
			LocalizationSettings.NativeMethodInfoPtr_get_AssetDatabase_Public_Static_get_LocalizedAssetDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664651);
			LocalizationSettings.NativeMethodInfoPtr_set_AssetDatabase_Public_Static_set_Void_LocalizedAssetDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664652);
			LocalizationSettings.NativeMethodInfoPtr_get_StringDatabase_Public_Static_get_LocalizedStringDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664653);
			LocalizationSettings.NativeMethodInfoPtr_set_StringDatabase_Public_Static_set_Void_LocalizedStringDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664654);
			LocalizationSettings.NativeMethodInfoPtr_get_Metadata_Public_Static_get_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664655);
			LocalizationSettings.NativeMethodInfoPtr_get_SelectedLocale_Public_Static_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664656);
			LocalizationSettings.NativeMethodInfoPtr_set_SelectedLocale_Public_Static_set_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664657);
			LocalizationSettings.NativeMethodInfoPtr_get_SelectedLocaleAsync_Public_Static_get_AsyncOperationHandle_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664658);
			LocalizationSettings.NativeMethodInfoPtr_add_SelectedLocaleChanged_Public_Static_add_Void_Action_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664659);
			LocalizationSettings.NativeMethodInfoPtr_remove_SelectedLocaleChanged_Public_Static_rem_Void_Action_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664660);
			LocalizationSettings.NativeMethodInfoPtr_get_ProjectLocale_Public_Static_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664661);
			LocalizationSettings.NativeMethodInfoPtr_set_ProjectLocale_Public_Static_set_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664662);
			LocalizationSettings.NativeMethodInfoPtr_get_InitializeSynchronously_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664663);
			LocalizationSettings.NativeMethodInfoPtr_set_InitializeSynchronously_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664664);
			LocalizationSettings.NativeMethodInfoPtr_get_PreloadBehavior_Public_Static_get_PreloadBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664665);
			LocalizationSettings.NativeMethodInfoPtr_set_PreloadBehavior_Public_Static_set_Void_PreloadBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664666);
			LocalizationSettings.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664667);
			LocalizationSettings.NativeMethodInfoPtr_ValidateSettingsExist_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664668);
			LocalizationSettings.NativeMethodInfoPtr_GetInitializationOperation_Public_Virtual_New_AsyncOperationHandle_1_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664669);
			LocalizationSettings.NativeMethodInfoPtr_get_IsPlayingOrWillChangePlaymode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664670);
			LocalizationSettings.NativeMethodInfoPtr_get_IsPlaying_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664671);
			LocalizationSettings.NativeMethodInfoPtr_get_Platform_Internal_Virtual_New_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664672);
			LocalizationSettings.NativeMethodInfoPtr_GetStartupLocaleSelectors_Public_List_1_IStartupLocaleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664673);
			LocalizationSettings.NativeMethodInfoPtr_SetAvailableLocales_Public_Void_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664674);
			LocalizationSettings.NativeMethodInfoPtr_GetAvailableLocales_Public_Virtual_New_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664675);
			LocalizationSettings.NativeMethodInfoPtr_SetAssetDatabase_Public_Void_LocalizedAssetDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664676);
			LocalizationSettings.NativeMethodInfoPtr_GetAssetDatabase_Public_Virtual_New_LocalizedAssetDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664677);
			LocalizationSettings.NativeMethodInfoPtr_SetStringDatabase_Public_Void_LocalizedStringDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664678);
			LocalizationSettings.NativeMethodInfoPtr_GetStringDatabase_Public_Virtual_New_LocalizedStringDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664679);
			LocalizationSettings.NativeMethodInfoPtr_GetMetadata_Public_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664680);
			LocalizationSettings.NativeMethodInfoPtr_SendLocaleChangedEvents_Internal_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664681);
			LocalizationSettings.NativeMethodInfoPtr_InitializeAndCallSelectedLocaleChangedCoroutine_Private_IEnumerator_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664682);
			LocalizationSettings.NativeMethodInfoPtr_InvokeSelectedLocaleChanged_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664683);
			LocalizationSettings.NativeMethodInfoPtr_SelectActiveLocale_Private_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664684);
			LocalizationSettings.NativeMethodInfoPtr_SelectLocaleUsingStartupSelectors_FamOrAssem_Virtual_New_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664685);
			LocalizationSettings.NativeMethodInfoPtr_SetSelectedLocale_Public_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664686);
			LocalizationSettings.NativeMethodInfoPtr_GetSelectedLocaleAsync_Public_Virtual_New_AsyncOperationHandle_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664687);
			LocalizationSettings.NativeMethodInfoPtr_GetSelectedLocale_Public_Virtual_New_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664688);
			LocalizationSettings.NativeMethodInfoPtr_OnLocaleRemoved_Public_Virtual_New_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664689);
			LocalizationSettings.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664690);
			LocalizationSettings.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664691);
			LocalizationSettings.NativeMethodInfoPtr_GetInstanceDontCreateDefault_Public_Static_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664692);
			LocalizationSettings.NativeMethodInfoPtr_GetOrCreateSettings_Private_Static_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664693);
			LocalizationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664694);
			LocalizationSettings.NativeMethodInfoPtr__GetSelectedLocaleAsync_b__87_0_Private_AsyncOperationHandle_1_Locale_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, 100664695);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000268C8 File Offset: 0x00024AC8
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00026904 File Offset: 0x00024B04
		public unsafe bool IsChangingSelectedLocale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_IsChangingSelectedLocale_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_IsChangingSelectedLocale_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00026944 File Offset: 0x00024B44
		public unsafe bool HasSelectedLocaleChangedSubscribers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075245, XrefRangeEnd = 1075246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_HasSelectedLocaleChangedSubscribers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00026980 File Offset: 0x00024B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075246, XrefRangeEnd = 1075249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSelectedLocaleChanged(Action<Locale> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_add_OnSelectedLocaleChanged_Public_add_Void_Action_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000269C4 File Offset: 0x00024BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075249, XrefRangeEnd = 1075252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSelectedLocaleChanged(Action<Locale> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_remove_OnSelectedLocaleChanged_Public_rem_Void_Action_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00026A08 File Offset: 0x00024C08
		public unsafe static bool HasSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1075267, RefRangeEnd = 1075268, XrefRangeStart = 1075252, XrefRangeEnd = 1075267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_HasSettings_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00026A38 File Offset: 0x00024C38
		public unsafe static AsyncOperationHandle<LocalizationSettings> InitializationOperation
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1075269, RefRangeEnd = 1075277, XrefRangeStart = 1075268, XrefRangeEnd = 1075269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_LocalizationSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<LocalizationSettings>(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00026A64 File Offset: 0x00024C64
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00026A98 File Offset: 0x00024C98
		public unsafe static LocalizationSettings Instance
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1075296, RefRangeEnd = 1075337, XrefRangeStart = 1075277, XrefRangeEnd = 1075296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075337, XrefRangeEnd = 1075341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_LocalizationSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00026AD0 File Offset: 0x00024CD0
		public unsafe static List<IStartupLocaleSelector> StartupLocaleSelectors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075341, XrefRangeEnd = 1075342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_StartupLocaleSelectors_Public_Static_get_List_1_IStartupLocaleSelector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IStartupLocaleSelector>>(intPtr3) : null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00026B04 File Offset: 0x00024D04
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00026B38 File Offset: 0x00024D38
		public unsafe static ILocalesProvider AvailableLocales
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1075344, RefRangeEnd = 1075348, XrefRangeStart = 1075342, XrefRangeEnd = 1075344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_AvailableLocales_Public_Static_get_ILocalesProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalesProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075348, XrefRangeEnd = 1075351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_AvailableLocales_Public_Static_set_Void_ILocalesProvider_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00026B70 File Offset: 0x00024D70
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00026BA4 File Offset: 0x00024DA4
		public unsafe static LocalizedAssetDatabase AssetDatabase
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1075353, RefRangeEnd = 1075357, XrefRangeStart = 1075351, XrefRangeEnd = 1075353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_AssetDatabase_Public_Static_get_LocalizedAssetDatabase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedAssetDatabase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075357, XrefRangeEnd = 1075360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_AssetDatabase_Public_Static_set_Void_LocalizedAssetDatabase_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00026BDC File Offset: 0x00024DDC
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00026C10 File Offset: 0x00024E10
		public unsafe static LocalizedStringDatabase StringDatabase
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1075362, RefRangeEnd = 1075374, XrefRangeStart = 1075360, XrefRangeEnd = 1075362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_StringDatabase_Public_Static_get_LocalizedStringDatabase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedStringDatabase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075374, XrefRangeEnd = 1075377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_StringDatabase_Public_Static_set_Void_LocalizedStringDatabase_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00026C48 File Offset: 0x00024E48
		public unsafe static MetadataCollection Metadata
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075377, XrefRangeEnd = 1075378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_Metadata_Public_Static_get_MetadataCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00026C7C File Offset: 0x00024E7C
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00026CB0 File Offset: 0x00024EB0
		public unsafe static Locale SelectedLocale
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1075380, RefRangeEnd = 1075384, XrefRangeStart = 1075378, XrefRangeEnd = 1075380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_SelectedLocale_Public_Static_get_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1075387, RefRangeEnd = 1075388, XrefRangeStart = 1075384, XrefRangeEnd = 1075387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_SelectedLocale_Public_Static_set_Void_Locale_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00026CE8 File Offset: 0x00024EE8
		public unsafe static AsyncOperationHandle<Locale> SelectedLocaleAsync
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1075389, RefRangeEnd = 1075405, XrefRangeStart = 1075388, XrefRangeEnd = 1075389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_SelectedLocaleAsync_Public_Static_get_AsyncOperationHandle_1_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<Locale>(intPtr);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00026D14 File Offset: 0x00024F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075410, RefRangeEnd = 1075411, XrefRangeStart = 1075405, XrefRangeEnd = 1075410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_SelectedLocaleChanged(Action<Locale> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_add_SelectedLocaleChanged_Public_Static_add_Void_Action_1_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00026D4C File Offset: 0x00024F4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1075416, RefRangeEnd = 1075423, XrefRangeStart = 1075411, XrefRangeEnd = 1075416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_SelectedLocaleChanged(Action<Locale> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_remove_SelectedLocaleChanged_Public_Static_rem_Void_Action_1_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00026D84 File Offset: 0x00024F84
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00026DB8 File Offset: 0x00024FB8
		public unsafe static Locale ProjectLocale
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1075441, RefRangeEnd = 1075445, XrefRangeStart = 1075423, XrefRangeEnd = 1075441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_ProjectLocale_Public_Static_get_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075445, XrefRangeEnd = 1075455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_ProjectLocale_Public_Static_set_Void_Locale_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00026DF0 File Offset: 0x00024FF0
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00026E20 File Offset: 0x00025020
		public unsafe static bool InitializeSynchronously
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075455, XrefRangeEnd = 1075456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_InitializeSynchronously_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075456, XrefRangeEnd = 1075457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_InitializeSynchronously_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00026E54 File Offset: 0x00025054
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00026E84 File Offset: 0x00025084
		public unsafe static PreloadBehavior PreloadBehavior
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1075458, RefRangeEnd = 1075459, XrefRangeStart = 1075457, XrefRangeEnd = 1075458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_PreloadBehavior_Public_Static_get_PreloadBehavior_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075459, XrefRangeEnd = 1075460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_set_PreloadBehavior_Public_Static_set_Void_PreloadBehavior_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00026EB8 File Offset: 0x000250B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075460, XrefRangeEnd = 1075469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00026EF4 File Offset: 0x000250F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075484, RefRangeEnd = 1075486, XrefRangeStart = 1075469, XrefRangeEnd = 1075484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateSettingsExist(string error = "")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_ValidateSettingsExist_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00026F2C File Offset: 0x0002512C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075486, XrefRangeEnd = 1075519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<LocalizationSettings> GetInitializationOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetInitializationOperation_Public_Virtual_New_AsyncOperationHandle_1_LocalizationSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<LocalizationSettings>(intPtr);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00026F70 File Offset: 0x00025170
		public unsafe bool IsPlayingOrWillChangePlaymode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_IsPlayingOrWillChangePlaymode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00026FAC File Offset: 0x000251AC
		public unsafe bool IsPlaying
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1075523, RefRangeEnd = 1075529, XrefRangeStart = 1075519, XrefRangeEnd = 1075523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_get_IsPlaying_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00026FE8 File Offset: 0x000251E8
		public unsafe virtual RuntimePlatform Platform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075529, XrefRangeEnd = 1075533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_get_Platform_Internal_Virtual_New_get_RuntimePlatform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00027030 File Offset: 0x00025230
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IStartupLocaleSelector> GetStartupLocaleSelectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_GetStartupLocaleSelectors_Public_List_1_IStartupLocaleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IStartupLocaleSelector>>(intPtr3) : null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00027070 File Offset: 0x00025270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvailableLocales(ILocalesProvider available)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(available);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SetAvailableLocales_Public_Void_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000270B4 File Offset: 0x000252B4
		[CallerCount(0)]
		public unsafe virtual ILocalesProvider GetAvailableLocales()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetAvailableLocales_Public_Virtual_New_ILocalesProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalesProvider>(intPtr3) : null;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00027100 File Offset: 0x00025300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssetDatabase(LocalizedAssetDatabase database)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SetAssetDatabase_Public_Void_LocalizedAssetDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00027144 File Offset: 0x00025344
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalizedAssetDatabase GetAssetDatabase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetAssetDatabase_Public_Virtual_New_LocalizedAssetDatabase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedAssetDatabase>(intPtr3) : null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00027190 File Offset: 0x00025390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStringDatabase(LocalizedStringDatabase database)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SetStringDatabase_Public_Void_LocalizedStringDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000271D4 File Offset: 0x000253D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalizedStringDatabase GetStringDatabase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetStringDatabase_Public_Virtual_New_LocalizedStringDatabase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedStringDatabase>(intPtr3) : null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00027220 File Offset: 0x00025420
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataCollection GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_GetMetadata_Public_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00027260 File Offset: 0x00025460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075553, RefRangeEnd = 1075554, XrefRangeStart = 1075533, XrefRangeEnd = 1075553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLocaleChangedEvents(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SendLocaleChangedEvents_Internal_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000272A4 File Offset: 0x000254A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075554, XrefRangeEnd = 1075560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InitializeAndCallSelectedLocaleChangedCoroutine(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_InitializeAndCallSelectedLocaleChangedCoroutine_Private_IEnumerator_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000272F4 File Offset: 0x000254F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075560, XrefRangeEnd = 1075578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSelectedLocaleChanged(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_InvokeSelectedLocaleChanged_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00027338 File Offset: 0x00025538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075588, RefRangeEnd = 1075590, XrefRangeStart = 1075578, XrefRangeEnd = 1075588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale SelectActiveLocale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SelectActiveLocale_Private_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00027378 File Offset: 0x00025578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075590, XrefRangeEnd = 1075623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale SelectLocaleUsingStartupSelectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_SelectLocaleUsingStartupSelectors_FamOrAssem_Virtual_New_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000273C4 File Offset: 0x000255C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075659, RefRangeEnd = 1075660, XrefRangeStart = 1075623, XrefRangeEnd = 1075659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_SetSelectedLocale_Public_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00027408 File Offset: 0x00025608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075660, XrefRangeEnd = 1075688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<Locale> GetSelectedLocaleAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetSelectedLocaleAsync_Public_Virtual_New_AsyncOperationHandle_1_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<Locale>(intPtr);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002744C File Offset: 0x0002564C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075688, XrefRangeEnd = 1075695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetSelectedLocale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_GetSelectedLocale_Public_Virtual_New_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00027498 File Offset: 0x00025698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075695, XrefRangeEnd = 1075705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLocaleRemoved(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationSettings.NativeMethodInfoPtr_OnLocaleRemoved_Public_Virtual_New_Void_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000274E8 File Offset: 0x000256E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075705, XrefRangeEnd = 1075714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002751C File Offset: 0x0002571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075714, XrefRangeEnd = 1075747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00027550 File Offset: 0x00025750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1075755, RefRangeEnd = 1075758, XrefRangeStart = 1075747, XrefRangeEnd = 1075755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalizationSettings GetInstanceDontCreateDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_GetInstanceDontCreateDefault_Public_Static_LocalizationSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr3) : null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00027584 File Offset: 0x00025784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075758, XrefRangeEnd = 1075771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalizationSettings GetOrCreateSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr_GetOrCreateSettings_Private_Static_LocalizationSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr3) : null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000275B8 File Offset: 0x000257B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075771, XrefRangeEnd = 1075862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000275F4 File Offset: 0x000257F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075862, XrefRangeEnd = 1075867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<Locale> _GetSelectedLocaleAsync_b__87_0(AsyncOperationHandle op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings.NativeMethodInfoPtr__GetSelectedLocaleAsync_b__87_0_Private_AsyncOperationHandle_1_Locale_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<Locale>(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00004E28 File Offset: 0x00003028
		public LocalizationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00027644 File Offset: 0x00025844
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00004E31 File Offset: 0x00003031
		public unsafe static string ConfigName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_ConfigName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_ConfigName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00027664 File Offset: 0x00025864
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00004E43 File Offset: 0x00003043
		public unsafe static string ConfigEditorLocale
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_ConfigEditorLocale, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_ConfigEditorLocale, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00027684 File Offset: 0x00025884
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004E55 File Offset: 0x00003055
		public unsafe static string IgnoreSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_IgnoreSettings, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_IgnoreSettings, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x000276A4 File Offset: 0x000258A4
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00004E67 File Offset: 0x00003067
		public unsafe static string LocaleLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_LocaleLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_LocaleLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000276C4 File Offset: 0x000258C4
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00004E79 File Offset: 0x00003079
		public unsafe static string PreloadLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_PreloadLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_PreloadLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x000276E4 File Offset: 0x000258E4
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00004E8B File Offset: 0x0000308B
		public unsafe List<IStartupLocaleSelector> m_StartupSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_StartupSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IStartupLocaleSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_StartupSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00027714 File Offset: 0x00025914
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004EAA File Offset: 0x000030AA
		public unsafe ILocalesProvider m_AvailableLocales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_AvailableLocales);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_AvailableLocales), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00027744 File Offset: 0x00025944
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00004EC9 File Offset: 0x000030C9
		public unsafe LocalizedAssetDatabase m_AssetDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_AssetDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedAssetDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_AssetDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00027774 File Offset: 0x00025974
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00004EE8 File Offset: 0x000030E8
		public unsafe LocalizedStringDatabase m_StringDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_StringDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedStringDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_StringDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x000277A4 File Offset: 0x000259A4
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00004F07 File Offset: 0x00003107
		public unsafe MetadataCollection m_Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000277D4 File Offset: 0x000259D4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00004F26 File Offset: 0x00003126
		public LocaleIdentifier m_ProjectLocaleIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocaleIdentifier);
				return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocaleIdentifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00027804 File Offset: 0x00025A04
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004F54 File Offset: 0x00003154
		public unsafe PreloadBehavior m_PreloadBehavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_PreloadBehavior);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_PreloadBehavior)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x0002782C File Offset: 0x00025A2C
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00004F6F File Offset: 0x0000316F
		public unsafe bool m_InitializeSynchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_InitializeSynchronously);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_InitializeSynchronously)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00027854 File Offset: 0x00025A54
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00004F8A File Offset: 0x0000318A
		public AsyncOperationHandle<LocalizationSettings> m_InitializingOperationHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_InitializingOperationHandle);
				return new AsyncOperationHandle<LocalizationSettings>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LocalizationSettings>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_InitializingOperationHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LocalizationSettings>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00027884 File Offset: 0x00025A84
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00004FB8 File Offset: 0x000031B8
		public AsyncOperationHandle<Locale> m_SelectedLocaleAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleAsync);
				return new AsyncOperationHandle<Locale>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Locale>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleAsync), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Locale>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000278B4 File Offset: 0x00025AB4
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00004FE6 File Offset: 0x000031E6
		public unsafe Locale m_ProjectLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_ProjectLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000278E4 File Offset: 0x00025AE4
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00005005 File Offset: 0x00003205
		public CallbackArray<Action<Locale>> m_SelectedLocaleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleChanged);
				return new CallbackArray<Action<Locale>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Action<Locale>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr_m_SelectedLocaleChanged), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Action<Locale>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00027914 File Offset: 0x00025B14
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00005033 File Offset: 0x00003233
		public unsafe bool _IsChangingSelectedLocale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr__IsChangingSelectedLocale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings.NativeFieldInfoPtr__IsChangingSelectedLocale_k__BackingField)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0002793C File Offset: 0x00025B3C
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0000504E File Offset: 0x0000324E
		public unsafe static LocalizationSettings s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationSettings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationSettings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_ConfigName;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_ConfigEditorLocale;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreSettings;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_LocaleLabel;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_PreloadLabel;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_m_StartupSelectors;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableLocales;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetDatabase;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_m_StringDatabase;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectLocaleIdentifier;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadBehavior;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_m_InitializeSynchronously;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_m_InitializingOperationHandle;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocaleAsync;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectLocale;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocaleChanged;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr__IsChangingSelectedLocale_k__BackingField;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChangingSelectedLocale_Internal_get_Boolean_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_set_IsChangingSelectedLocale_Private_set_Void_Boolean_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSelectedLocaleChangedSubscribers_Internal_get_Boolean_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSelectedLocaleChanged_Public_add_Void_Action_1_Locale_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSelectedLocaleChanged_Public_rem_Void_Action_1_Locale_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSettings_Public_Static_get_Boolean_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializationOperation_Public_Static_get_AsyncOperationHandle_1_LocalizationSettings_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationSettings_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_LocalizationSettings_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_get_StartupLocaleSelectors_Public_Static_get_List_1_IStartupLocaleSelector_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableLocales_Public_Static_get_ILocalesProvider_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_set_AvailableLocales_Public_Static_set_Void_ILocalesProvider_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetDatabase_Public_Static_get_LocalizedAssetDatabase_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetDatabase_Public_Static_set_Void_LocalizedAssetDatabase_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_get_StringDatabase_Public_Static_get_LocalizedStringDatabase_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_set_StringDatabase_Public_Static_set_Void_LocalizedStringDatabase_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_Static_get_MetadataCollection_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedLocale_Public_Static_get_Locale_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedLocale_Public_Static_set_Void_Locale_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedLocaleAsync_Public_Static_get_AsyncOperationHandle_1_Locale_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_add_SelectedLocaleChanged_Public_Static_add_Void_Action_1_Locale_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_remove_SelectedLocaleChanged_Public_Static_rem_Void_Action_1_Locale_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectLocale_Public_Static_get_Locale_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectLocale_Public_Static_set_Void_Locale_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeSynchronously_Public_Static_get_Boolean_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_set_InitializeSynchronously_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadBehavior_Public_Static_get_PreloadBehavior_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_set_PreloadBehavior_Public_Static_set_Void_PreloadBehavior_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSettingsExist_Internal_Static_Void_String_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_GetInitializationOperation_Public_Virtual_New_AsyncOperationHandle_1_LocalizationSettings_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayingOrWillChangePlaymode_Internal_get_Boolean_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Internal_get_Boolean_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Internal_Virtual_New_get_RuntimePlatform_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocaleSelectors_Public_List_1_IStartupLocaleSelector_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_SetAvailableLocales_Public_Void_ILocalesProvider_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableLocales_Public_Virtual_New_ILocalesProvider_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_SetAssetDatabase_Public_Void_LocalizedAssetDatabase_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetDatabase_Public_Virtual_New_LocalizedAssetDatabase_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_SetStringDatabase_Public_Void_LocalizedStringDatabase_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_GetStringDatabase_Public_Virtual_New_LocalizedStringDatabase_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_MetadataCollection_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_SendLocaleChangedEvents_Internal_Void_Locale_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAndCallSelectedLocaleChangedCoroutine_Private_IEnumerator_Locale_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSelectedLocaleChanged_Private_Void_Locale_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_SelectActiveLocale_Private_Locale_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_SelectLocaleUsingStartupSelectors_FamOrAssem_Virtual_New_Locale_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedLocale_Public_Void_Locale_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedLocaleAsync_Public_Virtual_New_AsyncOperationHandle_1_Locale_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedLocale_Public_Virtual_New_Locale_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_OnLocaleRemoved_Public_Virtual_New_Void_Locale_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceDontCreateDefault_Public_Static_LocalizationSettings_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSettings_Private_Static_LocalizationSettings_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr__GetSelectedLocaleAsync_b__87_0_Private_AsyncOperationHandle_1_Locale_AsyncOperationHandle_0;

		// Token: 0x0200015F RID: 351
		[ObfuscatedName("UnityEngine.Localization.Settings.LocalizationSettings+<InitializeAndCallSelectedLocaleChangedCoroutine>d__82")]
		public sealed class _InitializeAndCallSelectedLocaleChangedCoroutine_d__82 : Object
		{
			// Token: 0x06000F26 RID: 3878 RVA: 0x00041138 File Offset: 0x0003F338
			// Note: this type is marked as 'beforefieldinit'.
			static _InitializeAndCallSelectedLocaleChangedCoroutine_d__82()
			{
				Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationSettings>.NativeClassPtr, "<InitializeAndCallSelectedLocaleChangedCoroutine>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, "<>1__state");
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, "<>2__current");
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, "<>4__this");
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, "locale");
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664696);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664697);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664698);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664699);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664700);
				LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr, 100664701);
			}

			// Token: 0x06000F27 RID: 3879 RVA: 0x0004122C File Offset: 0x0003F42C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitializeAndCallSelectedLocaleChangedCoroutine_d__82(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F28 RID: 3880 RVA: 0x00041274 File Offset: 0x0003F474
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F29 RID: 3881 RVA: 0x000412A8 File Offset: 0x0003F4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075236, XrefRangeEnd = 1075240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000412E4 File Offset: 0x0003F4E4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F2B RID: 3883 RVA: 0x00041324 File Offset: 0x0003F524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075240, XrefRangeEnd = 1075245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00041358 File Offset: 0x0003F558
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F2D RID: 3885 RVA: 0x0000858F File Offset: 0x0000678F
			public _InitializeAndCallSelectedLocaleChangedCoroutine_d__82(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00041398 File Offset: 0x0003F598
			// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00008598 File Offset: 0x00006798
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000413C0 File Offset: 0x0003F5C0
			// (set) Token: 0x06000F31 RID: 3889 RVA: 0x000085B3 File Offset: 0x000067B3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000F32 RID: 3890 RVA: 0x000413F0 File Offset: 0x0003F5F0
			// (set) Token: 0x06000F33 RID: 3891 RVA: 0x000085D2 File Offset: 0x000067D2
			public unsafe LocalizationSettings __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00041420 File Offset: 0x0003F620
			// (set) Token: 0x06000F35 RID: 3893 RVA: 0x000085F1 File Offset: 0x000067F1
			public unsafe Locale locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr_locale);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationSettings._InitializeAndCallSelectedLocaleChangedCoroutine_d__82.NativeFieldInfoPtr_locale), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A60 RID: 2656
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000A61 RID: 2657
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000A62 RID: 2658
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000A63 RID: 2659
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x04000A64 RID: 2660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000A65 RID: 2661
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000A66 RID: 2662
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000A67 RID: 2663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000A68 RID: 2664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000A69 RID: 2665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
