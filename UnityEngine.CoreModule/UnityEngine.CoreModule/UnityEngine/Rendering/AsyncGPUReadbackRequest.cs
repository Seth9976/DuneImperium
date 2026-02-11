using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x020001DD RID: 477
	[StructLayout(2)]
	public struct AsyncGPUReadbackRequest
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x0009358C File Offset: 0x0009178C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncGPUReadbackRequest()
		{
			Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadbackRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr);
			AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Ptr");
			AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Version");
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667821);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667822);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667823);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667824);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667825);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667826);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667827);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667828);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667829);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667830);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667831);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667832);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667833);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667834);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667835);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667836);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667837);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667838);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667839);
			AsyncGPUReadbackRequest.Update_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.Update_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::Update_Injected");
			AsyncGPUReadbackRequest.GetWidth_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetWidth_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetWidth_Injected");
			AsyncGPUReadbackRequest.GetHeight_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetHeight_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetHeight_Injected");
			AsyncGPUReadbackRequest.GetDepth_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetDepth_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDepth_Injected");
			AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetForcePlayerLoopUpdate_Injected");
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::SetForcePlayerLoopUpdate_Injected");
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000937BC File Offset: 0x000919BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681375, RefRangeEnd = 681376, XrefRangeStart = 681373, XrefRangeEnd = 681375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCompletion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000937E4 File Offset: 0x000919E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681384, RefRangeEnd = 681385, XrefRangeStart = 681376, XrefRangeEnd = 681384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetData<T>(int layer = 0) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Unity.Collections.NativeArray<T>(intPtr);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0009381C File Offset: 0x00091A1C
		public unsafe bool done
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 681387, RefRangeEnd = 681389, XrefRangeStart = 681385, XrefRangeEnd = 681387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x0009384C File Offset: 0x00091A4C
		public unsafe bool hasError
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 681391, RefRangeEnd = 681393, XrefRangeStart = 681389, XrefRangeEnd = 681391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0009387C File Offset: 0x00091A7C
		public unsafe int layerCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681395, RefRangeEnd = 681396, XrefRangeStart = 681393, XrefRangeEnd = 681395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000938AC File Offset: 0x00091AAC
		public unsafe int layerDataSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681398, RefRangeEnd = 681399, XrefRangeStart = 681396, XrefRangeEnd = 681398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000938DC File Offset: 0x00091ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681387, RefRangeEnd = 681389, XrefRangeStart = 681387, XrefRangeEnd = 681389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0009390C File Offset: 0x00091B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681391, RefRangeEnd = 681393, XrefRangeStart = 681391, XrefRangeEnd = 681393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0009393C File Offset: 0x00091B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681395, RefRangeEnd = 681396, XrefRangeStart = 681395, XrefRangeEnd = 681396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLayerCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0009396C File Offset: 0x00091B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681398, RefRangeEnd = 681399, XrefRangeStart = 681398, XrefRangeEnd = 681399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLayerDataSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0009399C File Offset: 0x00091B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681399, XrefRangeEnd = 681401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000939D4 File Offset: 0x00091BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681403, RefRangeEnd = 681404, XrefRangeStart = 681401, XrefRangeEnd = 681403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetDataRaw(int layer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00093A14 File Offset: 0x00091C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681375, RefRangeEnd = 681376, XrefRangeStart = 681375, XrefRangeEnd = 681376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00093A48 File Offset: 0x00091C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681387, RefRangeEnd = 681389, XrefRangeStart = 681387, XrefRangeEnd = 681389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00093A88 File Offset: 0x00091C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681391, RefRangeEnd = 681393, XrefRangeStart = 681391, XrefRangeEnd = 681393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00093AC8 File Offset: 0x00091CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681395, RefRangeEnd = 681396, XrefRangeStart = 681395, XrefRangeEnd = 681396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00093B08 File Offset: 0x00091D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681398, RefRangeEnd = 681399, XrefRangeStart = 681398, XrefRangeEnd = 681399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00093B48 File Offset: 0x00091D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00093B8C File Offset: 0x00091D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681403, RefRangeEnd = 681404, XrefRangeStart = 681403, XrefRangeEnd = 681404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0000CD3B File Offset: 0x0000AF3B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, ref this));
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0000CD4D File Offset: 0x0000AF4D
		public void Update()
		{
			AsyncGPUReadbackRequest.Update_Injected(ref this);
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x00093BD8 File Offset: 0x00091DD8
		public int width
		{
			get
			{
				return this.GetWidth();
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00093BF0 File Offset: 0x00091DF0
		public int height
		{
			get
			{
				return this.GetHeight();
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00093C08 File Offset: 0x00091E08
		public int depth
		{
			get
			{
				return this.GetDepth();
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x00093C20 File Offset: 0x00091E20
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x0000CD55 File Offset: 0x0000AF55
		public bool forcePlayerLoopUpdate
		{
			get
			{
				return this.GetForcePlayerLoopUpdate();
			}
			set
			{
				this.SetForcePlayerLoopUpdate(value);
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0000CD60 File Offset: 0x0000AF60
		public int GetWidth()
		{
			return AsyncGPUReadbackRequest.GetWidth_Injected(ref this);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0000CD68 File Offset: 0x0000AF68
		public int GetHeight()
		{
			return AsyncGPUReadbackRequest.GetHeight_Injected(ref this);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public int GetDepth()
		{
			return AsyncGPUReadbackRequest.GetDepth_Injected(ref this);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0000CD78 File Offset: 0x0000AF78
		public bool GetForcePlayerLoopUpdate()
		{
			return AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_Injected(ref this);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0000CD80 File Offset: 0x0000AF80
		public void SetForcePlayerLoopUpdate(bool b)
		{
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_Injected(ref this, b);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0000CD89 File Offset: 0x0000AF89
		public static void Update_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			AsyncGPUReadbackRequest.Update_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0000CD96 File Offset: 0x0000AF96
		public static int GetWidth_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetWidth_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0000CDA3 File Offset: 0x0000AFA3
		public static int GetHeight_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetHeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public static int GetDepth_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetDepth_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0000CDBD File Offset: 0x0000AFBD
		public static bool GetForcePlayerLoopUpdate_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		public static void SetForcePlayerLoopUpdate_Injected(ref AsyncGPUReadbackRequest _unity_self, bool b)
		{
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegateField(ref _unity_self, b);
		}

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_get_done_Public_get_Boolean_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Private_Boolean_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_HasError_Private_Boolean_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCount_Private_Int32_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0;

		// Token: 0x04001C95 RID: 7317
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04001C96 RID: 7318
		[FieldOffset(8)]
		public int m_Version;

		// Token: 0x04001C97 RID: 7319
		private static readonly AsyncGPUReadbackRequest.Update_InjectedDelegate Update_InjectedDelegateField;

		// Token: 0x04001C98 RID: 7320
		private static readonly AsyncGPUReadbackRequest.GetWidth_InjectedDelegate GetWidth_InjectedDelegateField;

		// Token: 0x04001C99 RID: 7321
		private static readonly AsyncGPUReadbackRequest.GetHeight_InjectedDelegate GetHeight_InjectedDelegateField;

		// Token: 0x04001C9A RID: 7322
		private static readonly AsyncGPUReadbackRequest.GetDepth_InjectedDelegate GetDepth_InjectedDelegateField;

		// Token: 0x04001C9B RID: 7323
		private static readonly AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegate GetForcePlayerLoopUpdate_InjectedDelegateField;

		// Token: 0x04001C9C RID: 7324
		private static readonly AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegate SetForcePlayerLoopUpdate_InjectedDelegateField;

		// Token: 0x0200092A RID: 2346
		private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04002D1C RID: 11548
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200092B RID: 2347
		// (Invoke) Token: 0x06003B73 RID: 15219
		private delegate void Update_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200092C RID: 2348
		// (Invoke) Token: 0x06003B75 RID: 15221
		private delegate int GetWidth_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200092D RID: 2349
		// (Invoke) Token: 0x06003B77 RID: 15223
		private delegate int GetHeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200092E RID: 2350
		// (Invoke) Token: 0x06003B79 RID: 15225
		private delegate int GetDepth_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200092F RID: 2351
		// (Invoke) Token: 0x06003B7B RID: 15227
		private delegate bool GetForcePlayerLoopUpdate_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000930 RID: 2352
		// (Invoke) Token: 0x06003B7D RID: 15229
		private delegate void SetForcePlayerLoopUpdate_InjectedDelegate(IntPtr _unity_self, bool b);
	}
}
