using System;
using dwd.core.commands;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using localization;
using UnityEngine;

namespace dwd.core.bundles
{
	// Token: 0x020001F5 RID: 501
	public class AssetBundleManager : MonoBehaviour
	{
		// Token: 0x06001B47 RID: 6983 RVA: 0x0007FBE8 File Offset: 0x0007DDE8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleManager()
		{
			Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetBundleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr);
			AssetBundleManager.NativeFieldInfoPtr_delayedDisposalQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "delayedDisposalQueue");
			AssetBundleManager.NativeFieldInfoPtr_currentQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "currentQueue");
			AssetBundleManager.NativeFieldInfoPtr_downloadingAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "downloadingAll");
			AssetBundleManager.NativeFieldInfoPtr_totalDownloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "totalDownloads");
			AssetBundleManager.NativeFieldInfoPtr_UseVerboseLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "UseVerboseLogging");
			AssetBundleManager.NativeFieldInfoPtr_UseReferenceLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "UseReferenceLogging");
			AssetBundleManager.NativeFieldInfoPtr__EncounteredError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<EncounteredError>k__BackingField");
			AssetBundleManager.NativeFieldInfoPtr_Configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "Configuration");
			AssetBundleManager.NativeFieldInfoPtr_pendingRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "pendingRequests");
			AssetBundleManager.NativeFieldInfoPtr_activeRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "activeRequests");
			AssetBundleManager.NativeFieldInfoPtr_downloadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "downloadComplete");
			AssetBundleManager.NativeFieldInfoPtr_changeResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "changeResolution");
			AssetBundleManager.NativeFieldInfoPtr__Resolution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<Resolution>k__BackingField");
			AssetBundleManager.NativeFieldInfoPtr__PreloadBundles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<PreloadBundles>k__BackingField");
			AssetBundleManager.NativeFieldInfoPtr__ManifestVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<ManifestVersion>k__BackingField");
			AssetBundleManager.NativeFieldInfoPtr_IsNewManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "IsNewManifest");
			AssetBundleManager.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<Initialized>k__BackingField");
			AssetBundleManager.NativeFieldInfoPtr_mainThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "mainThread");
			AssetBundleManager.NativeFieldInfoPtr_threadSafeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "threadSafeCleanup");
			AssetBundleManager.NativeFieldInfoPtr_forceLoadBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "forceLoadBundles");
			AssetBundleManager.NativeFieldInfoPtr_maxRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "maxRequestTime");
			AssetBundleManager.NativeMethodInfoPtr_get_EncounteredError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667611);
			AssetBundleManager.NativeMethodInfoPtr_set_EncounteredError_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667612);
			AssetBundleManager.NativeMethodInfoPtr_get_requester_Protected_Abstract_Virtual_New_get_IAssetManagerRequester_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667613);
			AssetBundleManager.NativeMethodInfoPtr_get_PendingRequests_Public_get_Il2CppReferenceArray_1_List_1_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667614);
			AssetBundleManager.NativeMethodInfoPtr_get_PendingRequestCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667615);
			AssetBundleManager.NativeMethodInfoPtr_get_ActiveRequests_Public_get_List_1_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667616);
			AssetBundleManager.NativeMethodInfoPtr_get_AssetURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667617);
			AssetBundleManager.NativeMethodInfoPtr_get_VersionURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667618);
			AssetBundleManager.NativeMethodInfoPtr_get_UseVersionedAssetNames_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667619);
			AssetBundleManager.NativeMethodInfoPtr_get_MaxConcurrentRequests_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667620);
			AssetBundleManager.NativeMethodInfoPtr_add_downloadComplete_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667621);
			AssetBundleManager.NativeMethodInfoPtr_remove_downloadComplete_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667622);
			AssetBundleManager.NativeMethodInfoPtr_add_changeResolution_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667623);
			AssetBundleManager.NativeMethodInfoPtr_remove_changeResolution_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667624);
			AssetBundleManager.NativeMethodInfoPtr_get_Resolution_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667625);
			AssetBundleManager.NativeMethodInfoPtr_set_Resolution_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667626);
			AssetBundleManager.NativeMethodInfoPtr_get_PlatformFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667627);
			AssetBundleManager.NativeMethodInfoPtr_get_PreloadBundles_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667628);
			AssetBundleManager.NativeMethodInfoPtr_set_PreloadBundles_Protected_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667629);
			AssetBundleManager.NativeMethodInfoPtr_get_ManifestVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667630);
			AssetBundleManager.NativeMethodInfoPtr_set_ManifestVersion_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667631);
			AssetBundleManager.NativeMethodInfoPtr_get_BundleCount_Protected_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667632);
			AssetBundleManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667633);
			AssetBundleManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667634);
			AssetBundleManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667635);
			AssetBundleManager.NativeMethodInfoPtr_ChangeResolution_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667636);
			AssetBundleManager.NativeMethodInfoPtr_InitConfig_Internal_Void_IAssetBundleConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667637);
			AssetBundleManager.NativeMethodInfoPtr_init_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667638);
			AssetBundleManager.NativeMethodInfoPtr_GetFullBundleName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667639);
			AssetBundleManager.NativeMethodInfoPtr_getFullBundleName_Protected_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667640);
			AssetBundleManager.NativeMethodInfoPtr_HandleError_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667641);
			AssetBundleManager.NativeMethodInfoPtr_HandleReattempt_Internal_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667642);
			AssetBundleManager.NativeMethodInfoPtr_CleanupAssetBundle_Private_Void_RefCounted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667643);
			AssetBundleManager.NativeMethodInfoPtr_mainThreadCleanup_Private_Void_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667644);
			AssetBundleManager.NativeMethodInfoPtr_DelayedAssetBundleRequestCleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667645);
			AssetBundleManager.NativeMethodInfoPtr_cacheManifest_Internal_Void_AssetBundleManifestV3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667646);
			AssetBundleManager.NativeMethodInfoPtr_GetForceLoadBundles_Private_IEnumerable_1_String_AssetBundleManifestV3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667647);
			AssetBundleManager.NativeMethodInfoPtr_setPathMap_Private_Static_Void_AssetBundleDescriptorV3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667648);
			AssetBundleManager.NativeMethodInfoPtr_setupDescriptor_Private_Void_AssetBundleDescriptorV3_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667649);
			AssetBundleManager.NativeMethodInfoPtr_setBundle_Protected_Abstract_Virtual_New_Void_AssetBundleDescriptorV3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667650);
			AssetBundleManager.NativeMethodInfoPtr_BeginCache_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667651);
			AssetBundleManager.NativeMethodInfoPtr_EndCache_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667652);
			AssetBundleManager.NativeMethodInfoPtr_ClearPreload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667653);
			AssetBundleManager.NativeMethodInfoPtr_ResetCurrentLocaleDescriptor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667654);
			AssetBundleManager.NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667655);
			AssetBundleManager.NativeMethodInfoPtr_requestManifestBundle_Internal_AssetBundleRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667656);
			AssetBundleManager.NativeMethodInfoPtr_GetBundleRef_Public_BundleReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667657);
			AssetBundleManager.NativeMethodInfoPtr_requestAsset_Internal_AssetBundleRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667658);
			AssetBundleManager.NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667659);
			AssetBundleManager.NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667660);
			AssetBundleManager.NativeMethodInfoPtr_doesBundleExitsInManifest_Protected_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667661);
			AssetBundleManager.NativeMethodInfoPtr_AssetsInBundle_Public_Virtual_Final_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667662);
			AssetBundleManager.NativeMethodInfoPtr_assetsInBundle_Protected_Abstract_Virtual_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667663);
			AssetBundleManager.NativeMethodInfoPtr_GetDescriptorForBundle_Public_IAssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667664);
			AssetBundleManager.NativeMethodInfoPtr_getDescriptorForBundle_Protected_Abstract_Virtual_New_IAssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667665);
			AssetBundleManager.NativeMethodInfoPtr_LoadAllBundles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667666);
			AssetBundleManager.NativeMethodInfoPtr_getAllBundleNames_Protected_Abstract_Virtual_New_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667667);
			AssetBundleManager.NativeMethodInfoPtr_GetLocales_Public_Virtual_Final_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667668);
			AssetBundleManager.NativeMethodInfoPtr_getLocales_Protected_Abstract_Virtual_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667669);
			AssetBundleManager.NativeMethodInfoPtr_Load_Internal_Void_AssetBundleRequest_RequestPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667670);
			AssetBundleManager.NativeMethodInfoPtr_LoadFull_Private_IEnumerator_String_RequestPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667671);
			AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Private_Static_Boolean_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667672);
			AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Public_Boolean_Uri_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667673);
			AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667674);
			AssetBundleManager.NativeMethodInfoPtr_LoadBundleList_Internal_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667675);
			AssetBundleManager.NativeMethodInfoPtr_LoadForceLoadBundleList_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667676);
			AssetBundleManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667677);
			AssetBundleManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667678);
			AssetBundleManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667679);
			AssetBundleManager.NativeMethodInfoPtr_GetNextRequest_Private_AssetBundleRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667680);
			AssetBundleManager.NativeMethodInfoPtr_downloadMonitor_Private_IEnumerator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667681);
			AssetBundleManager.NativeMethodInfoPtr_GetDownloadAllProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667682);
			AssetBundleManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, 100667683);
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00080370 File Offset: 0x0007E570
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x000803AC File Offset: 0x0007E5AC
		public unsafe bool EncounteredError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_EncounteredError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_set_EncounteredError_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000803EC File Offset: 0x0007E5EC
		public unsafe virtual IAssetManagerRequester requester
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_get_requester_Protected_Abstract_Virtual_New_get_IAssetManagerRequester_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetManagerRequester>(intPtr3) : null;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00080438 File Offset: 0x0007E638
		public unsafe Il2CppReferenceArray<List<AssetBundleRequest>> PendingRequests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_PendingRequests_Public_get_Il2CppReferenceArray_1_List_1_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<AssetBundleRequest>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00080478 File Offset: 0x0007E678
		public unsafe int PendingRequestCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 884425, RefRangeEnd = 884427, XrefRangeStart = 884423, XrefRangeEnd = 884425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_PendingRequestCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x000804B4 File Offset: 0x0007E6B4
		public unsafe List<AssetBundleRequest> ActiveRequests
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_ActiveRequests_Public_get_List_1_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AssetBundleRequest>>(intPtr3) : null;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000804F4 File Offset: 0x0007E6F4
		public unsafe string AssetURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884427, XrefRangeEnd = 884431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_AssetURL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0008052C File Offset: 0x0007E72C
		public unsafe string VersionURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884431, XrefRangeEnd = 884435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_VersionURL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00080564 File Offset: 0x0007E764
		public unsafe bool UseVersionedAssetNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884435, XrefRangeEnd = 884439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_UseVersionedAssetNames_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000805A0 File Offset: 0x0007E7A0
		public unsafe int MaxConcurrentRequests
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884439, XrefRangeEnd = 884443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_MaxConcurrentRequests_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000805DC File Offset: 0x0007E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884443, XrefRangeEnd = 884447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_downloadComplete(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_add_downloadComplete_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00080620 File Offset: 0x0007E820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884447, XrefRangeEnd = 884451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_downloadComplete(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_remove_downloadComplete_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00080664 File Offset: 0x0007E864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884451, XrefRangeEnd = 884455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_changeResolution(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_add_changeResolution_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000806A8 File Offset: 0x0007E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884455, XrefRangeEnd = 884459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_changeResolution(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_remove_changeResolution_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x000806EC File Offset: 0x0007E8EC
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x00080724 File Offset: 0x0007E924
		public unsafe string Resolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_Resolution_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_set_Resolution_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x00080768 File Offset: 0x0007E968
		public unsafe string PlatformFolder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884459, XrefRangeEnd = 884463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_PlatformFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000807A0 File Offset: 0x0007E9A0
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x000807E0 File Offset: 0x0007E9E0
		public unsafe IList<string> PreloadBundles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_PreloadBundles_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_set_PreloadBundles_Protected_set_Void_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00080824 File Offset: 0x0007EA24
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00080860 File Offset: 0x0007EA60
		public unsafe int ManifestVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_ManifestVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_set_ManifestVersion_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000808A0 File Offset: 0x0007EAA0
		public unsafe virtual int BundleCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_get_BundleCount_Protected_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000808E8 File Offset: 0x0007EAE8
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00080924 File Offset: 0x0007EB24
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00080964 File Offset: 0x0007EB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884463, XrefRangeEnd = 884501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00080998 File Offset: 0x0007EB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884501, XrefRangeEnd = 884502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeResolution(string newRes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newRes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_ChangeResolution_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000809DC File Offset: 0x0007EBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884526, RefRangeEnd = 884527, XrefRangeStart = 884502, XrefRangeEnd = 884526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitConfig(IAssetBundleConfig config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_InitConfig_Internal_Void_IAssetBundleConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00080A20 File Offset: 0x0007EC20
		[CallerCount(0)]
		public unsafe virtual void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_init_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00080A5C File Offset: 0x0007EC5C
		[CallerCount(0)]
		public unsafe string GetFullBundleName(string namePart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namePart);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetFullBundleName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00080AA4 File Offset: 0x0007ECA4
		[CallerCount(0)]
		public unsafe virtual string getFullBundleName(string namePart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namePart);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_getFullBundleName_Protected_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00080AF8 File Offset: 0x0007ECF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884527, XrefRangeEnd = 884532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleError(string Request, string Reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_HandleError_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00080B4C File Offset: 0x0007ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884532, XrefRangeEnd = 884537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleReattempt(string Request, int number, string status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_HandleReattempt_Internal_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00080BB0 File Offset: 0x0007EDB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884549, RefRangeEnd = 884551, XrefRangeStart = 884537, XrefRangeEnd = 884549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupAssetBundle(RefCounted req)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(req);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_CleanupAssetBundle_Private_Void_RefCounted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00080BF4 File Offset: 0x0007EDF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884569, RefRangeEnd = 884571, XrefRangeStart = 884551, XrefRangeEnd = 884569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mainThreadCleanup(AssetBundleRequest req)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(req);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_mainThreadCleanup_Private_Void_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00080C38 File Offset: 0x0007EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884571, XrefRangeEnd = 884583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedAssetBundleRequestCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_DelayedAssetBundleRequestCleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00080C6C File Offset: 0x0007EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884583, XrefRangeEnd = 884623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cacheManifest(AssetBundleManifestV3 manifest, bool isNewManifest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manifest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNewManifest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_cacheManifest_Internal_Void_AssetBundleManifestV3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00080CBC File Offset: 0x0007EEBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884687, RefRangeEnd = 884688, XrefRangeStart = 884623, XrefRangeEnd = 884687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> GetForceLoadBundles(AssetBundleManifestV3 manifest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manifest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetForceLoadBundles_Private_IEnumerable_1_String_AssetBundleManifestV3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00080D0C File Offset: 0x0007EF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884841, RefRangeEnd = 884842, XrefRangeStart = 884688, XrefRangeEnd = 884841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setPathMap(AssetBundleDescriptorV3 descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_setPathMap_Private_Static_Void_AssetBundleDescriptorV3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00080D44 File Offset: 0x0007EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884842, XrefRangeEnd = 884843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setupDescriptor(AssetBundleDescriptorV3 descriptor, TextLocalization.Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_setupDescriptor_Private_Void_AssetBundleDescriptorV3_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00080D94 File Offset: 0x0007EF94
		[CallerCount(0)]
		public unsafe virtual void setBundle(AssetBundleDescriptorV3 descriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_setBundle_Protected_Abstract_Virtual_New_Void_AssetBundleDescriptorV3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00080DE4 File Offset: 0x0007EFE4
		[CallerCount(0)]
		public unsafe virtual void BeginCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_BeginCache_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00080E20 File Offset: 0x0007F020
		[CallerCount(0)]
		public unsafe virtual void EndCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_EndCache_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00080E5C File Offset: 0x0007F05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_ClearPreload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00080E90 File Offset: 0x0007F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884843, XrefRangeEnd = 884847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCurrentLocaleDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_ResetCurrentLocaleDescriptor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00080EC4 File Offset: 0x0007F0C4
		[CallerCount(0)]
		public unsafe virtual void clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00080F00 File Offset: 0x0007F100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884858, RefRangeEnd = 884859, XrefRangeStart = 884847, XrefRangeEnd = 884858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest requestManifestBundle(string descriptorKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(descriptorKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_requestManifestBundle_Internal_AssetBundleRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00080F50 File Offset: 0x0007F150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884859, XrefRangeEnd = 884875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundleReference GetBundleRef(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetBundleRef_Public_BundleReference_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BundleReference>(intPtr3) : null;
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00080FA0 File Offset: 0x0007F1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884884, RefRangeEnd = 884885, XrefRangeStart = 884875, XrefRangeEnd = 884884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest requestAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_requestAsset_Internal_AssetBundleRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00080FF0 File Offset: 0x0007F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884885, XrefRangeEnd = 884890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesAssetExistInManifest(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00081040 File Offset: 0x0007F240
		[CallerCount(0)]
		public unsafe virtual bool DoesBundleExitsInManifest(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00081090 File Offset: 0x0007F290
		[CallerCount(0)]
		public unsafe virtual bool doesBundleExitsInManifest(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_doesBundleExitsInManifest_Protected_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000810E8 File Offset: 0x0007F2E8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 466517, RefRangeEnd = 466545, XrefRangeStart = 466517, XrefRangeEnd = 466545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<string> AssetsInBundle(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_AssetsInBundle_Public_Virtual_Final_New_IList_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00081138 File Offset: 0x0007F338
		[CallerCount(0)]
		public unsafe virtual IList<string> assetsInBundle(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_assetsInBundle_Protected_Abstract_Virtual_New_IList_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00081194 File Offset: 0x0007F394
		[CallerCount(0)]
		public unsafe IAssetBundle GetDescriptorForBundle(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetDescriptorForBundle_Public_IAssetBundle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000811E4 File Offset: 0x0007F3E4
		[CallerCount(0)]
		public unsafe virtual IAssetBundle getDescriptorForBundle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_getDescriptorForBundle_Protected_Abstract_Virtual_New_IAssetBundle_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00081240 File Offset: 0x0007F440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884890, XrefRangeEnd = 884912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAllBundles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_LoadAllBundles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00081274 File Offset: 0x0007F474
		[CallerCount(0)]
		public unsafe virtual IEnumerable<string> getAllBundleNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_getAllBundleNames_Protected_Abstract_Virtual_New_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000812C0 File Offset: 0x0007F4C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884912, RefRangeEnd = 884914, XrefRangeStart = 884912, XrefRangeEnd = 884912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<string> GetLocales(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetLocales_Public_Virtual_Final_New_IList_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00081310 File Offset: 0x0007F510
		[CallerCount(0)]
		public unsafe virtual IList<string> getLocales(string bundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleManager.NativeMethodInfoPtr_getLocales_Protected_Abstract_Virtual_New_IList_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0008136C File Offset: 0x0007F56C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 884921, RefRangeEnd = 884925, XrefRangeStart = 884914, XrefRangeEnd = 884921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(AssetBundleRequest request, RequestPriority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_Load_Internal_Void_AssetBundleRequest_RequestPriority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000813BC File Offset: 0x0007F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884925, XrefRangeEnd = 884929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadFull(string descriptorKey, RequestPriority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(descriptorKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_LoadFull_Private_IEnumerator_String_RequestPriority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0008141C File Offset: 0x0007F61C
		[CallerCount(0)]
		public unsafe static bool IsReRequest(AssetBundleRequest request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Private_Static_Boolean_AssetBundleRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00081460 File Offset: 0x0007F660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884929, XrefRangeEnd = 884932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReRequest(Uri uri, int version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Public_Boolean_Uri_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000814BC File Offset: 0x0007F6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884932, XrefRangeEnd = 884943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReRequest(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_IsReRequest_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0008150C File Offset: 0x0007F70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884965, RefRangeEnd = 884966, XrefRangeStart = 884943, XrefRangeEnd = 884965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadBundleList(IEnumerable<string> bundleList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundleList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_LoadBundleList_Internal_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00081550 File Offset: 0x0007F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884966, XrefRangeEnd = 884967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadForceLoadBundleList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_LoadForceLoadBundleList_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00081584 File Offset: 0x0007F784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884967, XrefRangeEnd = 884977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000815B8 File Offset: 0x0007F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884977, XrefRangeEnd = 884991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000815EC File Offset: 0x0007F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884991, XrefRangeEnd = 885011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00081620 File Offset: 0x0007F820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885011, XrefRangeEnd = 885014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest GetNextRequest(int minPriority, int maxPriority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minPriority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetNextRequest_Private_AssetBundleRequest_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0008167C File Offset: 0x0007F87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885014, XrefRangeEnd = 885019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator downloadMonitor(int minPriority, int maxPriority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minPriority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_downloadMonitor_Private_IEnumerator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000816D8 File Offset: 0x0007F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885019, XrefRangeEnd = 885025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDownloadAllProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr_GetDownloadAllProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00081714 File Offset: 0x0007F914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885025, XrefRangeEnd = 885043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000BCBF File Offset: 0x00009EBF
		public AssetBundleManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00081750 File Offset: 0x0007F950
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		public unsafe Queue<AssetBundleRequest> delayedDisposalQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_delayedDisposalQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<AssetBundleRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_delayedDisposalQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00081780 File Offset: 0x0007F980
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000BCE7 File Offset: 0x00009EE7
		public unsafe Queue<AssetBundleRequest> currentQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_currentQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<AssetBundleRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_currentQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000817B0 File Offset: 0x0007F9B0
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000BD06 File Offset: 0x00009F06
		public unsafe bool downloadingAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_downloadingAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_downloadingAll)) = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000817D8 File Offset: 0x0007F9D8
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000BD21 File Offset: 0x00009F21
		public unsafe float totalDownloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_totalDownloads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_totalDownloads)) = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00081800 File Offset: 0x0007FA00
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000BD3C File Offset: 0x00009F3C
		public unsafe bool UseVerboseLogging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_UseVerboseLogging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_UseVerboseLogging)) = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00081828 File Offset: 0x0007FA28
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000BD57 File Offset: 0x00009F57
		public unsafe bool UseReferenceLogging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_UseReferenceLogging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_UseReferenceLogging)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00081850 File Offset: 0x0007FA50
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000BD72 File Offset: 0x00009F72
		public unsafe bool _EncounteredError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__EncounteredError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__EncounteredError_k__BackingField)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00081878 File Offset: 0x0007FA78
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0000BD8D File Offset: 0x00009F8D
		public unsafe IAssetBundleConfig Configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_Configuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetBundleConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_Configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000818A8 File Offset: 0x0007FAA8
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0000BDAC File Offset: 0x00009FAC
		public unsafe Il2CppReferenceArray<List<AssetBundleRequest>> pendingRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_pendingRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<AssetBundleRequest>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_pendingRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000818D8 File Offset: 0x0007FAD8
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000BDCB File Offset: 0x00009FCB
		public unsafe List<AssetBundleRequest> activeRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_activeRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AssetBundleRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_activeRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00081908 File Offset: 0x0007FB08
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000BDEA File Offset: 0x00009FEA
		public unsafe Action downloadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_downloadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_downloadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00081938 File Offset: 0x0007FB38
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000BE09 File Offset: 0x0000A009
		public unsafe Action changeResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_changeResolution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_changeResolution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00081968 File Offset: 0x0007FB68
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000BE28 File Offset: 0x0000A028
		public unsafe string _Resolution_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__Resolution_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__Resolution_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00081990 File Offset: 0x0007FB90
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000BE47 File Offset: 0x0000A047
		public unsafe IList<string> _PreloadBundles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__PreloadBundles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__PreloadBundles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000819C0 File Offset: 0x0007FBC0
		// (set) Token: 0x06001BAF RID: 7087 RVA: 0x0000BE66 File Offset: 0x0000A066
		public unsafe int _ManifestVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__ManifestVersion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__ManifestVersion_k__BackingField)) = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x000819E8 File Offset: 0x0007FBE8
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0000BE81 File Offset: 0x0000A081
		public unsafe bool IsNewManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_IsNewManifest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_IsNewManifest)) = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00081A10 File Offset: 0x0007FC10
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00081A38 File Offset: 0x0007FC38
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0000BEB7 File Offset: 0x0000A0B7
		public unsafe Thread mainThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_mainThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_mainThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00081A68 File Offset: 0x0007FC68
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0000BED6 File Offset: 0x0000A0D6
		public unsafe Queue<AssetBundleRequest> threadSafeCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_threadSafeCleanup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<AssetBundleRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_threadSafeCleanup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00081A98 File Offset: 0x0007FC98
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
		public unsafe IEnumerable<string> forceLoadBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_forceLoadBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.NativeFieldInfoPtr_forceLoadBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00081AC8 File Offset: 0x0007FCC8
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0000BF14 File Offset: 0x0000A114
		public unsafe static float maxRequestTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleManager.NativeFieldInfoPtr_maxRequestTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleManager.NativeFieldInfoPtr_maxRequestTime, (void*)(&value));
			}
		}

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_delayedDisposalQueue;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_currentQueue;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_downloadingAll;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_totalDownloads;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_UseVerboseLogging;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_UseReferenceLogging;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr__EncounteredError_k__BackingField;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_Configuration;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_pendingRequests;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_activeRequests;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_downloadComplete;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_changeResolution;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr__Resolution_k__BackingField;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr__PreloadBundles_k__BackingField;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr__ManifestVersion_k__BackingField;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_IsNewManifest;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_mainThread;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_threadSafeCleanup;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_forceLoadBundles;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_maxRequestTime;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_get_EncounteredError_Public_get_Boolean_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_set_EncounteredError_Public_set_Void_Boolean_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_get_requester_Protected_Abstract_Virtual_New_get_IAssetManagerRequester_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingRequests_Public_get_Il2CppReferenceArray_1_List_1_AssetBundleRequest_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingRequestCount_Public_get_Int32_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveRequests_Public_get_List_1_AssetBundleRequest_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetURL_Public_get_String_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_get_VersionURL_Public_get_String_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_get_UseVersionedAssetNames_Protected_get_Boolean_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxConcurrentRequests_Private_get_Int32_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_add_downloadComplete_Public_add_Void_Action_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_remove_downloadComplete_Public_rem_Void_Action_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_add_changeResolution_Public_add_Void_Action_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_remove_changeResolution_Public_rem_Void_Action_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolution_Public_get_String_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolution_Private_set_Void_String_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformFolder_Public_get_String_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadBundles_Public_get_IList_1_String_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_set_PreloadBundles_Protected_set_Void_IList_1_String_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_get_ManifestVersion_Public_get_Int32_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_set_ManifestVersion_Private_set_Void_Int32_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_get_BundleCount_Protected_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_ChangeResolution_Public_Void_String_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_InitConfig_Internal_Void_IAssetBundleConfig_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_GetFullBundleName_Public_String_String_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_getFullBundleName_Protected_Abstract_Virtual_New_String_String_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Internal_Void_String_String_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_HandleReattempt_Internal_Void_String_Int32_String_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_CleanupAssetBundle_Private_Void_RefCounted_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_mainThreadCleanup_Private_Void_AssetBundleRequest_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_DelayedAssetBundleRequestCleanup_Private_Void_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_cacheManifest_Internal_Void_AssetBundleManifestV3_Boolean_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_GetForceLoadBundles_Private_IEnumerable_1_String_AssetBundleManifestV3_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_setPathMap_Private_Static_Void_AssetBundleDescriptorV3_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_setupDescriptor_Private_Void_AssetBundleDescriptorV3_Locale_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_setBundle_Protected_Abstract_Virtual_New_Void_AssetBundleDescriptorV3_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_BeginCache_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_EndCache_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_ClearPreload_Public_Void_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_ResetCurrentLocaleDescriptor_Public_Void_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_requestManifestBundle_Internal_AssetBundleRequest_String_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_GetBundleRef_Public_BundleReference_String_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_requestAsset_Internal_AssetBundleRequest_String_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Boolean_String_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_doesBundleExitsInManifest_Protected_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_AssetsInBundle_Public_Virtual_Final_New_IList_1_String_String_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_assetsInBundle_Protected_Abstract_Virtual_New_IList_1_String_String_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptorForBundle_Public_IAssetBundle_String_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_getDescriptorForBundle_Protected_Abstract_Virtual_New_IAssetBundle_String_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllBundles_Public_Void_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_getAllBundleNames_Protected_Abstract_Virtual_New_IEnumerable_1_String_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_GetLocales_Public_Virtual_Final_New_IList_1_String_String_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_getLocales_Protected_Abstract_Virtual_New_IList_1_String_String_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_AssetBundleRequest_RequestPriority_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_LoadFull_Private_IEnumerator_String_RequestPriority_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_IsReRequest_Private_Static_Boolean_AssetBundleRequest_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_IsReRequest_Public_Boolean_Uri_Int32_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_IsReRequest_Public_Boolean_String_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_LoadBundleList_Internal_Void_IEnumerable_1_String_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_LoadForceLoadBundleList_Internal_Void_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_GetNextRequest_Private_AssetBundleRequest_Int32_Int32_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_downloadMonitor_Private_IEnumerator_Int32_Int32_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadAllProgress_Public_Single_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000386 RID: 902
		[ObfuscatedName("dwd.core.bundles.AssetBundleManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002839 RID: 10297 RVA: 0x000A9FE4 File Offset: 0x000A81E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr);
				AssetBundleManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, "<>9");
				AssetBundleManager.__c.NativeFieldInfoPtr___9__70_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, "<>9__70_0");
				AssetBundleManager.__c.NativeFieldInfoPtr___9__70_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, "<>9__70_1");
				AssetBundleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, 100667685);
				AssetBundleManager.__c.NativeMethodInfoPtr__GetForceLoadBundles_b__70_0_Internal_Int64_AssetBundleDescriptorV3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, 100667686);
				AssetBundleManager.__c.NativeMethodInfoPtr__GetForceLoadBundles_b__70_1_Internal_String_AssetBundleDescriptorV3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr, 100667687);
			}

			// Token: 0x0600283A RID: 10298 RVA: 0x000AA088 File Offset: 0x000A8288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600283B RID: 10299 RVA: 0x000AA0C4 File Offset: 0x000A82C4
			[CallerCount(0)]
			public unsafe long _GetForceLoadBundles_b__70_0(AssetBundleDescriptorV3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c.NativeMethodInfoPtr__GetForceLoadBundles_b__70_0_Internal_Int64_AssetBundleDescriptorV3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600283C RID: 10300 RVA: 0x000AA114 File Offset: 0x000A8314
			[CallerCount(0)]
			public unsafe string _GetForceLoadBundles_b__70_1(AssetBundleDescriptorV3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c.NativeMethodInfoPtr__GetForceLoadBundles_b__70_1_Internal_String_AssetBundleDescriptorV3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600283D RID: 10301 RVA: 0x000123A4 File Offset: 0x000105A4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x0600283E RID: 10302 RVA: 0x000AA15C File Offset: 0x000A835C
			// (set) Token: 0x0600283F RID: 10303 RVA: 0x000123AD File Offset: 0x000105AD
			public unsafe static AssetBundleManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetBundleManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetBundleManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x06002840 RID: 10304 RVA: 0x000AA184 File Offset: 0x000A8384
			// (set) Token: 0x06002841 RID: 10305 RVA: 0x000123BF File Offset: 0x000105BF
			public unsafe static Func<AssetBundleDescriptorV3, long> __9__70_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetBundleManager.__c.NativeFieldInfoPtr___9__70_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AssetBundleDescriptorV3, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetBundleManager.__c.NativeFieldInfoPtr___9__70_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06002842 RID: 10306 RVA: 0x000AA1AC File Offset: 0x000A83AC
			// (set) Token: 0x06002843 RID: 10307 RVA: 0x000123D1 File Offset: 0x000105D1
			public unsafe static Func<AssetBundleDescriptorV3, string> __9__70_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetBundleManager.__c.NativeFieldInfoPtr___9__70_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AssetBundleDescriptorV3, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetBundleManager.__c.NativeFieldInfoPtr___9__70_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B4D RID: 6989
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B4E RID: 6990
			private static readonly IntPtr NativeFieldInfoPtr___9__70_0;

			// Token: 0x04001B4F RID: 6991
			private static readonly IntPtr NativeFieldInfoPtr___9__70_1;

			// Token: 0x04001B50 RID: 6992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B51 RID: 6993
			private static readonly IntPtr NativeMethodInfoPtr__GetForceLoadBundles_b__70_0_Internal_Int64_AssetBundleDescriptorV3_0;

			// Token: 0x04001B52 RID: 6994
			private static readonly IntPtr NativeMethodInfoPtr__GetForceLoadBundles_b__70_1_Internal_String_AssetBundleDescriptorV3_0;
		}

		// Token: 0x02000387 RID: 903
		[ObfuscatedName("dwd.core.bundles.AssetBundleManager+<>c__DisplayClass106_0")]
		public sealed class __c__DisplayClass106_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002844 RID: 10308 RVA: 0x000AA1D4 File Offset: 0x000A83D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass106_0()
			{
				Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<>c__DisplayClass106_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr);
				AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr, "<>4__this");
				AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_minPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr, "minPriority");
				AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_maxPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr, "maxPriority");
				AssetBundleManager.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr, 100667688);
			}

			// Token: 0x06002845 RID: 10309 RVA: 0x000AA250 File Offset: 0x000A8450
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass106_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002846 RID: 10310 RVA: 0x000123E3 File Offset: 0x000105E3
			public __c__DisplayClass106_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06002847 RID: 10311 RVA: 0x000AA28C File Offset: 0x000A848C
			// (set) Token: 0x06002848 RID: 10312 RVA: 0x000123EC File Offset: 0x000105EC
			public unsafe AssetBundleManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06002849 RID: 10313 RVA: 0x000AA2BC File Offset: 0x000A84BC
			// (set) Token: 0x0600284A RID: 10314 RVA: 0x0001240B File Offset: 0x0001060B
			public unsafe int minPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_minPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_minPriority)) = value;
				}
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x0600284B RID: 10315 RVA: 0x000AA2E4 File Offset: 0x000A84E4
			// (set) Token: 0x0600284C RID: 10316 RVA: 0x00012426 File Offset: 0x00010626
			public unsafe int maxPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_maxPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_0.NativeFieldInfoPtr_maxPriority)) = value;
				}
			}

			// Token: 0x04001B53 RID: 6995
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B54 RID: 6996
			private static readonly IntPtr NativeFieldInfoPtr_minPriority;

			// Token: 0x04001B55 RID: 6997
			private static readonly IntPtr NativeFieldInfoPtr_maxPriority;

			// Token: 0x04001B56 RID: 6998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000388 RID: 904
		[ObfuscatedName("dwd.core.bundles.AssetBundleManager+<>c__DisplayClass106_1")]
		public sealed class __c__DisplayClass106_1 : global::Il2CppSystem.Object
		{
			// Token: 0x0600284D RID: 10317 RVA: 0x000AA30C File Offset: 0x000A850C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass106_1()
			{
				Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<>c__DisplayClass106_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr);
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "request");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_currentRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "currentRequestTime");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_lastProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "lastProgress");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_field_Public___c__DisplayClass106_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "CS$<>8__locals1");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "<>9__3");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "<>9__4");
				AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, "<>9__5");
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667689);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667690);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667691);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__2_Internal_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667692);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667693);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__4_Internal_Void_InterruptCommandOnAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667694);
				AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__5_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr, 100667695);
			}

			// Token: 0x0600284E RID: 10318 RVA: 0x000AA450 File Offset: 0x000A8650
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass106_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager.__c__DisplayClass106_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600284F RID: 10319 RVA: 0x000AA48C File Offset: 0x000A868C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884278, XrefRangeEnd = 884282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _downloadMonitor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002850 RID: 10320 RVA: 0x000AA4C8 File Offset: 0x000A86C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884282, XrefRangeEnd = 884288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _downloadMonitor_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002851 RID: 10321 RVA: 0x000AA4FC File Offset: 0x000A86FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884288, XrefRangeEnd = 884320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _downloadMonitor_b__2(IEnumerator x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__2_Internal_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06002852 RID: 10322 RVA: 0x000AA54C File Offset: 0x000A874C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884320, XrefRangeEnd = 884331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _downloadMonitor_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002853 RID: 10323 RVA: 0x000AA588 File Offset: 0x000A8788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884331, XrefRangeEnd = 884348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _downloadMonitor_b__4(InterruptCommandOnAction previousCommand)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousCommand);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__4_Internal_Void_InterruptCommandOnAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002854 RID: 10324 RVA: 0x000AA5CC File Offset: 0x000A87CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884348, XrefRangeEnd = 884362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _downloadMonitor_b__5(ErrorInfo previousCommand)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(previousCommand));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager.__c__DisplayClass106_1.NativeMethodInfoPtr__downloadMonitor_b__5_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002855 RID: 10325 RVA: 0x00012441 File Offset: 0x00010641
			public __c__DisplayClass106_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06002856 RID: 10326 RVA: 0x000AA614 File Offset: 0x000A8814
			// (set) Token: 0x06002857 RID: 10327 RVA: 0x0001244A File Offset: 0x0001064A
			public unsafe AssetBundleRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06002858 RID: 10328 RVA: 0x000AA644 File Offset: 0x000A8844
			// (set) Token: 0x06002859 RID: 10329 RVA: 0x00012469 File Offset: 0x00010669
			public unsafe float currentRequestTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_currentRequestTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_currentRequestTime)) = value;
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x0600285A RID: 10330 RVA: 0x000AA66C File Offset: 0x000A886C
			// (set) Token: 0x0600285B RID: 10331 RVA: 0x00012484 File Offset: 0x00010684
			public unsafe float lastProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_lastProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_lastProgress)) = value;
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x0600285C RID: 10332 RVA: 0x000AA694 File Offset: 0x000A8894
			// (set) Token: 0x0600285D RID: 10333 RVA: 0x0001249F File Offset: 0x0001069F
			public unsafe AssetBundleManager.__c__DisplayClass106_0 field_Public___c__DisplayClass106_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_field_Public___c__DisplayClass106_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager.__c__DisplayClass106_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr_field_Public___c__DisplayClass106_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x0600285E RID: 10334 RVA: 0x000AA6C4 File Offset: 0x000A88C4
			// (set) Token: 0x0600285F RID: 10335 RVA: 0x000124BE File Offset: 0x000106BE
			public unsafe Func<bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06002860 RID: 10336 RVA: 0x000AA6F4 File Offset: 0x000A88F4
			// (set) Token: 0x06002861 RID: 10337 RVA: 0x000124DD File Offset: 0x000106DD
			public unsafe Action<InterruptCommandOnAction> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InterruptCommandOnAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06002862 RID: 10338 RVA: 0x000AA724 File Offset: 0x000A8924
			// (set) Token: 0x06002863 RID: 10339 RVA: 0x000124FC File Offset: 0x000106FC
			public unsafe Action<ErrorInfo> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager.__c__DisplayClass106_1.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B57 RID: 6999
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04001B58 RID: 7000
			private static readonly IntPtr NativeFieldInfoPtr_currentRequestTime;

			// Token: 0x04001B59 RID: 7001
			private static readonly IntPtr NativeFieldInfoPtr_lastProgress;

			// Token: 0x04001B5A RID: 7002
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass106_0_0;

			// Token: 0x04001B5B RID: 7003
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04001B5C RID: 7004
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04001B5D RID: 7005
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04001B5E RID: 7006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B5F RID: 7007
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__0_Internal_Boolean_0;

			// Token: 0x04001B60 RID: 7008
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__1_Internal_Void_0;

			// Token: 0x04001B61 RID: 7009
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__2_Internal_IEnumerator_IEnumerator_0;

			// Token: 0x04001B62 RID: 7010
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__3_Internal_Boolean_0;

			// Token: 0x04001B63 RID: 7011
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__4_Internal_Void_InterruptCommandOnAction_0;

			// Token: 0x04001B64 RID: 7012
			private static readonly IntPtr NativeMethodInfoPtr__downloadMonitor_b__5_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("dwd.core.bundles.AssetBundleManager+<LoadFull>d__94")]
		public sealed class _LoadFull_d__94 : global::Il2CppSystem.Object
		{
			// Token: 0x06002864 RID: 10340 RVA: 0x000AA754 File Offset: 0x000A8954
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadFull_d__94()
			{
				Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<LoadFull>d__94");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr);
				AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, "<>1__state");
				AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, "<>2__current");
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667696);
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667697);
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667698);
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667699);
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667700);
				AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr, 100667701);
			}

			// Token: 0x06002865 RID: 10341 RVA: 0x000AA820 File Offset: 0x000A8A20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadFull_d__94(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager._LoadFull_d__94>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002866 RID: 10342 RVA: 0x000AA868 File Offset: 0x000A8A68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002867 RID: 10343 RVA: 0x000AA89C File Offset: 0x000A8A9C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06002868 RID: 10344 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002869 RID: 10345 RVA: 0x000AA918 File Offset: 0x000A8B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884362, XrefRangeEnd = 884367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x0600286A RID: 10346 RVA: 0x000AA94C File Offset: 0x000A8B4C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._LoadFull_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600286B RID: 10347 RVA: 0x0001251B File Offset: 0x0001071B
			public _LoadFull_d__94(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x0600286C RID: 10348 RVA: 0x000AA98C File Offset: 0x000A8B8C
			// (set) Token: 0x0600286D RID: 10349 RVA: 0x00012524 File Offset: 0x00010724
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x0600286E RID: 10350 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
			// (set) Token: 0x0600286F RID: 10351 RVA: 0x0001253F File Offset: 0x0001073F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._LoadFull_d__94.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B65 RID: 7013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B66 RID: 7014
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B67 RID: 7015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B68 RID: 7016
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B69 RID: 7017
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B6A RID: 7018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B6B RID: 7019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B6C RID: 7020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038A RID: 906
		[ObfuscatedName("dwd.core.bundles.AssetBundleManager+<downloadMonitor>d__106")]
		public sealed class _downloadMonitor_d__106 : global::Il2CppSystem.Object
		{
			// Token: 0x06002870 RID: 10352 RVA: 0x000AA9E4 File Offset: 0x000A8BE4
			// Note: this type is marked as 'beforefieldinit'.
			static _downloadMonitor_d__106()
			{
				Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleManager>.NativeClassPtr, "<downloadMonitor>d__106");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr);
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "<>1__state");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "<>2__current");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "<>4__this");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_minPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "minPriority");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_maxPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "maxPriority");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "<>8__1");
				AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr__mainCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, "<mainCommand>5__2");
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667702);
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667703);
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667704);
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667705);
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667706);
				AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr, 100667707);
			}

			// Token: 0x06002871 RID: 10353 RVA: 0x000AAB14 File Offset: 0x000A8D14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _downloadMonitor_d__106(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManager._downloadMonitor_d__106>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002872 RID: 10354 RVA: 0x000AAB5C File Offset: 0x000A8D5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002873 RID: 10355 RVA: 0x000AAB90 File Offset: 0x000A8D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884367, XrefRangeEnd = 884418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06002874 RID: 10356 RVA: 0x000AABCC File Offset: 0x000A8DCC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002875 RID: 10357 RVA: 0x000AAC0C File Offset: 0x000A8E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884418, XrefRangeEnd = 884423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06002876 RID: 10358 RVA: 0x000AAC40 File Offset: 0x000A8E40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManager._downloadMonitor_d__106.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002877 RID: 10359 RVA: 0x0001255E File Offset: 0x0001075E
			public _downloadMonitor_d__106(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06002878 RID: 10360 RVA: 0x000AAC80 File Offset: 0x000A8E80
			// (set) Token: 0x06002879 RID: 10361 RVA: 0x00012567 File Offset: 0x00010767
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x0600287A RID: 10362 RVA: 0x000AACA8 File Offset: 0x000A8EA8
			// (set) Token: 0x0600287B RID: 10363 RVA: 0x00012582 File Offset: 0x00010782
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x0600287C RID: 10364 RVA: 0x000AACD8 File Offset: 0x000A8ED8
			// (set) Token: 0x0600287D RID: 10365 RVA: 0x000125A1 File Offset: 0x000107A1
			public unsafe AssetBundleManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x0600287E RID: 10366 RVA: 0x000AAD08 File Offset: 0x000A8F08
			// (set) Token: 0x0600287F RID: 10367 RVA: 0x000125C0 File Offset: 0x000107C0
			public unsafe int minPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_minPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_minPriority)) = value;
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06002880 RID: 10368 RVA: 0x000AAD30 File Offset: 0x000A8F30
			// (set) Token: 0x06002881 RID: 10369 RVA: 0x000125DB File Offset: 0x000107DB
			public unsafe int maxPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_maxPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr_maxPriority)) = value;
				}
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06002882 RID: 10370 RVA: 0x000AAD58 File Offset: 0x000A8F58
			// (set) Token: 0x06002883 RID: 10371 RVA: 0x000125F6 File Offset: 0x000107F6
			public unsafe AssetBundleManager.__c__DisplayClass106_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager.__c__DisplayClass106_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06002884 RID: 10372 RVA: 0x000AAD88 File Offset: 0x000A8F88
			// (set) Token: 0x06002885 RID: 10373 RVA: 0x00012615 File Offset: 0x00010815
			public unsafe IEnumerator _mainCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr__mainCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManager._downloadMonitor_d__106.NativeFieldInfoPtr__mainCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B6D RID: 7021
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B6E RID: 7022
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B6F RID: 7023
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B70 RID: 7024
			private static readonly IntPtr NativeFieldInfoPtr_minPriority;

			// Token: 0x04001B71 RID: 7025
			private static readonly IntPtr NativeFieldInfoPtr_maxPriority;

			// Token: 0x04001B72 RID: 7026
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001B73 RID: 7027
			private static readonly IntPtr NativeFieldInfoPtr__mainCommand_5__2;

			// Token: 0x04001B74 RID: 7028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B75 RID: 7029
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B76 RID: 7030
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B77 RID: 7031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B78 RID: 7032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B79 RID: 7033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
