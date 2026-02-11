using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000030 RID: 48
	public class AssetBundleResource : Object
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000E638 File Offset: 0x0000C838
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleResource()
		{
			Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "AssetBundleResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr);
			AssetBundleResource.NativeFieldInfoPtr_m_AssetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_AssetBundle");
			AssetBundleResource.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_RequestOperation");
			AssetBundleResource.NativeFieldInfoPtr_m_WebRequestQueueOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_WebRequestQueueOperation");
			AssetBundleResource.NativeFieldInfoPtr_m_ProvideHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_ProvideHandle");
			AssetBundleResource.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_Options");
			AssetBundleResource.NativeFieldInfoPtr_m_RequestCompletedCallbackCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_RequestCompletedCallbackCalled");
			AssetBundleResource.NativeFieldInfoPtr_m_Retries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_Retries");
			AssetBundleResource.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_Source");
			AssetBundleResource.NativeFieldInfoPtr_m_BytesToDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_BytesToDownload");
			AssetBundleResource.NativeFieldInfoPtr_m_DownloadedBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_DownloadedBytes");
			AssetBundleResource.NativeFieldInfoPtr_m_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_Completed");
			AssetBundleResource.NativeFieldInfoPtr_m_UnloadOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_UnloadOperation");
			AssetBundleResource.NativeFieldInfoPtr_k_WaitForWebRequestMainThreadSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "k_WaitForWebRequestMainThreadSleep");
			AssetBundleResource.NativeFieldInfoPtr_m_TransformedInternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_TransformedInternalId");
			AssetBundleResource.NativeFieldInfoPtr_m_PreloadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_PreloadRequest");
			AssetBundleResource.NativeFieldInfoPtr_m_PreloadCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_PreloadCompleted");
			AssetBundleResource.NativeFieldInfoPtr_m_LastDownloadedByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_LastDownloadedByteCount");
			AssetBundleResource.NativeFieldInfoPtr_m_TimeoutTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_TimeoutTimer");
			AssetBundleResource.NativeFieldInfoPtr_m_TimeoutOverFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_TimeoutOverFrames");
			AssetBundleResource.NativeFieldInfoPtr_m_LastFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_LastFrameCount");
			AssetBundleResource.NativeFieldInfoPtr_m_TimeSecSinceLastUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, "m_TimeSecSinceLastUpdate");
			AssetBundleResource.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663702);
			AssetBundleResource.NativeMethodInfoPtr_get_BytesToDownload_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663703);
			AssetBundleResource.NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663704);
			AssetBundleResource.NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663705);
			AssetBundleResource.NativeMethodInfoPtr_GetAssetPreloadRequest_Public_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663706);
			AssetBundleResource.NativeMethodInfoPtr_PercentComplete_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663707);
			AssetBundleResource.NativeMethodInfoPtr_GetDownloadStatus_Private_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663708);
			AssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663709);
			AssetBundleResource.NativeMethodInfoPtr_OnUnloadOperationComplete_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663710);
			AssetBundleResource.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_AssetBundleUnloadOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663711);
			AssetBundleResource.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663712);
			AssetBundleResource.NativeMethodInfoPtr_AddCallbackInvokeIfDone_Private_Void_AsyncOperation_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663713);
			AssetBundleResource.NativeMethodInfoPtr_GetLoadInfo_Public_Static_Void_ProvideHandle_byref_LoadType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663714);
			AssetBundleResource.NativeMethodInfoPtr_GetLoadInfo_Internal_Static_Void_IResourceLocation_ResourceManager_byref_LoadType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663715);
			AssetBundleResource.NativeMethodInfoPtr_BeginOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663716);
			AssetBundleResource.NativeMethodInfoPtr_LoadLocalBundle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663717);
			AssetBundleResource.NativeMethodInfoPtr_EnqueueWebRequest_Internal_WebRequestQueueOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663718);
			AssetBundleResource.NativeMethodInfoPtr_AddBeginWebRequestHandler_Internal_Void_WebRequestQueueOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663719);
			AssetBundleResource.NativeMethodInfoPtr_BeginWebRequestOperation_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663720);
			AssetBundleResource.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663721);
			AssetBundleResource.NativeMethodInfoPtr_LocalRequestOperationCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663722);
			AssetBundleResource.NativeMethodInfoPtr_CompleteBundleLoad_Private_Void_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663723);
			AssetBundleResource.NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663724);
			AssetBundleResource.NativeMethodInfoPtr_Unload_Public_Boolean_byref_AssetBundleUnloadOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663725);
			AssetBundleResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663726);
			AssetBundleResource.NativeMethodInfoPtr__GetAssetPreloadRequest_b__28_0_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663727);
			AssetBundleResource.NativeMethodInfoPtr__AddBeginWebRequestHandler_b__41_0_Private_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr, 100663728);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000EA28 File Offset: 0x0000CC28
		public unsafe bool HasTimedOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public unsafe long BytesToDownload
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1139279, RefRangeEnd = 1139281, XrefRangeStart = 1139279, XrefRangeEnd = 1139279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_get_BytesToDownload_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139281, XrefRangeEnd = 1139287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest CreateWebRequest(IResourceLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1139309, RefRangeEnd = 1139311, XrefRangeStart = 1139287, XrefRangeEnd = 1139309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest CreateWebRequest(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000EB40 File Offset: 0x0000CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139311, XrefRangeEnd = 1139320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest GetAssetPreloadRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_GetAssetPreloadRequest_Public_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139320, XrefRangeEnd = 1139321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PercentComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_PercentComplete_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139321, XrefRangeEnd = 1139334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadStatus GetDownloadStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_GetDownloadStatus_Private_DownloadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139334, XrefRangeEnd = 1139337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AssetBundle GetAssetBundle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000EC38 File Offset: 0x0000CE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139337, XrefRangeEnd = 1139339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnloadOperationComplete(AsyncOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_OnUnloadOperationComplete_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139386, RefRangeEnd = 1139387, XrefRangeStart = 1139339, XrefRangeEnd = 1139386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unloadOp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_AssetBundleUnloadOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139387, XrefRangeEnd = 1139461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitForCompletionHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000ED14 File Offset: 0x0000CF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139461, XrefRangeEnd = 1139464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_AddCallbackInvokeIfDone_Private_Void_AsyncOperation_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000ED68 File Offset: 0x0000CF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139464, XrefRangeEnd = 1139469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLoadInfo(ProvideHandle handle, out AssetBundleResource.LoadType loadType, out string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loadType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_GetLoadInfo_Public_Static_Void_ProvideHandle_byref_LoadType_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			path = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1139501, RefRangeEnd = 1139504, XrefRangeStart = 1139469, XrefRangeEnd = 1139501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out AssetBundleResource.LoadType loadType, out string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loadType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_GetLoadInfo_Internal_Static_Void_IResourceLocation_ResourceManager_byref_LoadType_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			path = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000EE3C File Offset: 0x0000D03C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1139527, RefRangeEnd = 1139531, XrefRangeStart = 1139504, XrefRangeEnd = 1139527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_BeginOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000EE70 File Offset: 0x0000D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139531, XrefRangeEnd = 1139543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLocalBundle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_LoadLocalBundle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139543, XrefRangeEnd = 1139562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestQueueOperation EnqueueWebRequest(string internalId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(internalId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_EnqueueWebRequest_Internal_WebRequestQueueOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139562, XrefRangeEnd = 1139579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequestQueueOperation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_AddBeginWebRequestHandler_Internal_Void_WebRequestQueueOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000EF38 File Offset: 0x0000D138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1139593, RefRangeEnd = 1139595, XrefRangeStart = 1139579, XrefRangeEnd = 1139593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginWebRequestOperation(AsyncOperation asyncOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_BeginWebRequestOperation_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000EF7C File Offset: 0x0000D17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139595, XrefRangeEnd = 1139605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update(float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledDeltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139630, RefRangeEnd = 1139631, XrefRangeStart = 1139605, XrefRangeEnd = 1139630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalRequestOperationCompleted(AsyncOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_LocalRequestOperationCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F000 File Offset: 0x0000D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139631, XrefRangeEnd = 1139653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteBundleLoad(AssetBundle bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bundle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_CompleteBundleLoad_Private_Void_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000F044 File Offset: 0x0000D244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1139728, RefRangeEnd = 1139730, XrefRangeStart = 1139653, XrefRangeEnd = 1139728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WebRequestOperationCompleted(AsyncOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000F088 File Offset: 0x0000D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139730, XrefRangeEnd = 1139739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Unload(out AssetBundleUnloadOperation unloadOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr_Unload_Public_Boolean_byref_AssetBundleUnloadOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				unloadOp = ((intPtr4 == 0) ? null : new AssetBundleUnloadOperation(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139739, XrefRangeEnd = 1139740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000F124 File Offset: 0x0000D324
		[CallerCount(0)]
		public unsafe void _GetAssetPreloadRequest_b__28_0(AsyncOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr__GetAssetPreloadRequest_b__28_0_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000F168 File Offset: 0x0000D368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139740, XrefRangeEnd = 1139741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddBeginWebRequestHandler_b__41_0(UnityWebRequestAsyncOperation asyncOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleResource.NativeMethodInfoPtr__AddBeginWebRequestHandler_b__41_0_Private_Void_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000300A File Offset: 0x0000120A
		public AssetBundleResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003013 File Offset: 0x00001213
		public unsafe AssetBundle m_AssetBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_AssetBundle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_AssetBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00003032 File Offset: 0x00001232
		public unsafe AsyncOperation m_RequestOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_RequestOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000F20C File Offset: 0x0000D40C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003051 File Offset: 0x00001251
		public unsafe WebRequestQueueOperation m_WebRequestQueueOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_WebRequestQueueOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_WebRequestQueueOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000F23C File Offset: 0x0000D43C
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003070 File Offset: 0x00001270
		public ProvideHandle m_ProvideHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_ProvideHandle);
				return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_ProvideHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000F26C File Offset: 0x0000D46C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000309E File Offset: 0x0000129E
		public unsafe AssetBundleRequestOptions m_Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequestOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000F29C File Offset: 0x0000D49C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000030BD File Offset: 0x000012BD
		public unsafe bool m_RequestCompletedCallbackCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_RequestCompletedCallbackCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_RequestCompletedCallbackCalled)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000030D8 File Offset: 0x000012D8
		public unsafe int m_Retries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Retries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Retries)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000030F3 File Offset: 0x000012F3
		public unsafe BundleSource m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Source)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000F314 File Offset: 0x0000D514
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000310E File Offset: 0x0000130E
		public unsafe long m_BytesToDownload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_BytesToDownload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_BytesToDownload)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000F33C File Offset: 0x0000D53C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003129 File Offset: 0x00001329
		public unsafe long m_DownloadedBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_DownloadedBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_DownloadedBytes)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000F364 File Offset: 0x0000D564
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003144 File Offset: 0x00001344
		public unsafe bool m_Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_Completed)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000F38C File Offset: 0x0000D58C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000315F File Offset: 0x0000135F
		public unsafe AssetBundleUnloadOperation m_UnloadOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_UnloadOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleUnloadOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_UnloadOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000317E File Offset: 0x0000137E
		public unsafe static int k_WaitForWebRequestMainThreadSleep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleResource.NativeFieldInfoPtr_k_WaitForWebRequestMainThreadSleep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleResource.NativeFieldInfoPtr_k_WaitForWebRequestMainThreadSleep, (void*)(&value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe string m_TransformedInternalId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TransformedInternalId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TransformedInternalId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000F400 File Offset: 0x0000D600
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000031AB File Offset: 0x000013AB
		public unsafe AssetBundleRequest m_PreloadRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_PreloadRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_PreloadRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000F430 File Offset: 0x0000D630
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000031CA File Offset: 0x000013CA
		public unsafe bool m_PreloadCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_PreloadCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_PreloadCompleted)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000F458 File Offset: 0x0000D658
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000031E5 File Offset: 0x000013E5
		public unsafe ulong m_LastDownloadedByteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_LastDownloadedByteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_LastDownloadedByteCount)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000F480 File Offset: 0x0000D680
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00003200 File Offset: 0x00001400
		public unsafe float m_TimeoutTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeoutTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeoutTimer)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000321B File Offset: 0x0000141B
		public unsafe int m_TimeoutOverFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeoutOverFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeoutOverFrames)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003236 File Offset: 0x00001436
		public unsafe int m_LastFrameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_LastFrameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_LastFrameCount)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00003251 File Offset: 0x00001451
		public unsafe float m_TimeSecSinceLastUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeSecSinceLastUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleResource.NativeFieldInfoPtr_m_TimeSecSinceLastUpdate)) = value;
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetBundle;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_WebRequestQueueOperation;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_m_ProvideHandle;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_m_Options;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestCompletedCallbackCalled;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_m_Retries;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_m_BytesToDownload;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_m_DownloadedBytes;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_Completed;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_UnloadOperation;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_k_WaitForWebRequestMainThreadSleep;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformedInternalId;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadRequest;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadCompleted;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_m_LastDownloadedByteCount;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeoutTimer;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeoutOverFrames;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameCount;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeSecSinceLastUpdate;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesToDownload_Internal_get_Int64_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_IResourceLocation_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_CreateWebRequest_Internal_UnityWebRequest_String_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPreloadRequest_Public_AssetBundleRequest_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_PercentComplete_Private_Single_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Private_DownloadStatus_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_OnUnloadOperationComplete_Private_Void_AsyncOperation_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_AssetBundleUnloadOperation_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionHandler_Private_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_AddCallbackInvokeIfDone_Private_Void_AsyncOperation_Action_1_AsyncOperation_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadInfo_Public_Static_Void_ProvideHandle_byref_LoadType_byref_String_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadInfo_Internal_Static_Void_IResourceLocation_ResourceManager_byref_LoadType_byref_String_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_BeginOperation_Private_Void_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_LoadLocalBundle_Private_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueWebRequest_Internal_WebRequestQueueOperation_String_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_AddBeginWebRequestHandler_Internal_Void_WebRequestQueueOperation_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_BeginWebRequestOperation_Private_Void_AsyncOperation_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_LocalRequestOperationCompleted_Private_Void_AsyncOperation_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_CompleteBundleLoad_Private_Void_AssetBundle_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Boolean_byref_AssetBundleUnloadOperation_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__GetAssetPreloadRequest_b__28_0_Private_Void_AsyncOperation_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr__AddBeginWebRequestHandler_b__41_0_Private_Void_UnityWebRequestAsyncOperation_0;

		// Token: 0x0200007F RID: 127
		public enum LoadType
		{
			// Token: 0x04000471 RID: 1137
			None,
			// Token: 0x04000472 RID: 1138
			Local,
			// Token: 0x04000473 RID: 1139
			Web
		}
	}
}
