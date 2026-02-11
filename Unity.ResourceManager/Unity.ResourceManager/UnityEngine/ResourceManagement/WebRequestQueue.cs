using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	// Token: 0x0200000D RID: 13
	public static class WebRequestQueue : Object
	{
		// Token: 0x06000115 RID: 277 RVA: 0x000094B8 File Offset: 0x000076B8
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestQueue()
		{
			Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "WebRequestQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr);
			WebRequestQueue.NativeFieldInfoPtr_s_MaxRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, "s_MaxRequest");
			WebRequestQueue.NativeFieldInfoPtr_s_QueuedOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, "s_QueuedOperations");
			WebRequestQueue.NativeFieldInfoPtr_s_ActiveRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, "s_ActiveRequests");
			WebRequestQueue.NativeMethodInfoPtr_SetMaxConcurrentRequests_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663468);
			WebRequestQueue.NativeMethodInfoPtr_QueueRequest_Public_Static_WebRequestQueueOperation_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663469);
			WebRequestQueue.NativeMethodInfoPtr_WaitForRequestToBeActive_Public_Static_Void_WebRequestQueueOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663470);
			WebRequestQueue.NativeMethodInfoPtr_DequeueRequest_Internal_Static_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663471);
			WebRequestQueue.NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663472);
			WebRequestQueue.NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663473);
			WebRequestQueue.NativeMethodInfoPtr_BeginWebRequest_Private_Static_Void_WebRequestQueueOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, 100663474);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000095B0 File Offset: 0x000077B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137199, RefRangeEnd = 1137200, XrefRangeStart = 1137195, XrefRangeEnd = 1137199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaxConcurrentRequests(int maxRequests)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxRequests;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_SetMaxConcurrentRequests_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000095E4 File Offset: 0x000077E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1137215, RefRangeEnd = 1137218, XrefRangeStart = 1137200, XrefRangeEnd = 1137215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequestQueueOperation QueueRequest(UnityWebRequest request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_QueueRequest_Public_Static_WebRequestQueueOperation_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00009628 File Offset: 0x00007828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137289, RefRangeEnd = 1137290, XrefRangeStart = 1137218, XrefRangeEnd = 1137289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_WaitForRequestToBeActive_Public_Static_Void_WebRequestQueueOperation_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000966C File Offset: 0x0000786C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137290, XrefRangeEnd = 1137307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DequeueRequest(UnityWebRequestAsyncOperation operation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_DequeueRequest_Internal_Static_Void_UnityWebRequestAsyncOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000096A4 File Offset: 0x000078A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137307, XrefRangeEnd = 1137315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnWebAsyncOpComplete(AsyncOperation operation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_AsyncOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000096DC File Offset: 0x000078DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1137332, RefRangeEnd = 1137339, XrefRangeStart = 1137315, XrefRangeEnd = 1137332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_UnityWebRequestAsyncOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00009714 File Offset: 0x00007914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137373, RefRangeEnd = 1137374, XrefRangeStart = 1137339, XrefRangeEnd = 1137373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginWebRequest(WebRequestQueueOperation queueOperation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queueOperation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueue.NativeMethodInfoPtr_BeginWebRequest_Private_Static_Void_WebRequestQueueOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000027D2 File Offset: 0x000009D2
		public WebRequestQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000974C File Offset: 0x0000794C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe static int s_MaxRequest
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebRequestQueue.NativeFieldInfoPtr_s_MaxRequest, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestQueue.NativeFieldInfoPtr_s_MaxRequest, (void*)(&value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00009768 File Offset: 0x00007968
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000027E9 File Offset: 0x000009E9
		public unsafe static Queue<WebRequestQueueOperation> s_QueuedOperations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestQueue.NativeFieldInfoPtr_s_QueuedOperations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<WebRequestQueueOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestQueue.NativeFieldInfoPtr_s_QueuedOperations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00009790 File Offset: 0x00007990
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe static List<UnityWebRequestAsyncOperation> s_ActiveRequests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestQueue.NativeFieldInfoPtr_s_ActiveRequests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityWebRequestAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestQueue.NativeFieldInfoPtr_s_ActiveRequests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_s_MaxRequest;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_s_QueuedOperations;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_s_ActiveRequests;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxConcurrentRequests_Public_Static_Void_Int32_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_QueueRequest_Public_Static_WebRequestQueueOperation_UnityWebRequest_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRequestToBeActive_Public_Static_Void_WebRequestQueueOperation_Int32_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_DequeueRequest_Internal_Static_Void_UnityWebRequestAsyncOperation_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_AsyncOperation_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_OnWebAsyncOpComplete_Private_Static_Void_UnityWebRequestAsyncOperation_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_BeginWebRequest_Private_Static_Void_WebRequestQueueOperation_0;

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("UnityEngine.ResourceManagement.WebRequestQueue+<>O")]
		public static class __O : Object
		{
			// Token: 0x060005B9 RID: 1465 RVA: 0x00004290 File Offset: 0x00002490
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WebRequestQueue.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestQueue>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestQueue.__O>.NativeClassPtr);
				WebRequestQueue.__O.NativeFieldInfoPtr__0___OnWebAsyncOpComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueue.__O>.NativeClassPtr, "<0>__OnWebAsyncOpComplete");
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x000042C4 File Offset: 0x000024C4
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001B930 File Offset: 0x00019B30
			// (set) Token: 0x060005BC RID: 1468 RVA: 0x000042CD File Offset: 0x000024CD
			public unsafe static Action<AsyncOperation> _0___OnWebAsyncOpComplete
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebRequestQueue.__O.NativeFieldInfoPtr__0___OnWebAsyncOpComplete, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebRequestQueue.__O.NativeFieldInfoPtr__0___OnWebAsyncOpComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000414 RID: 1044
			private static readonly IntPtr NativeFieldInfoPtr__0___OnWebAsyncOpComplete;
		}
	}
}
