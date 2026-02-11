using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	// Token: 0x0200000C RID: 12
	public class WebRequestQueueOperation : Object
	{
		// Token: 0x06000106 RID: 262 RVA: 0x000091CC File Offset: 0x000073CC
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestQueueOperation()
		{
			Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "WebRequestQueueOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr);
			WebRequestQueueOperation.NativeFieldInfoPtr_m_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, "m_Completed");
			WebRequestQueueOperation.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, "Result");
			WebRequestQueueOperation.NativeFieldInfoPtr_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, "OnComplete");
			WebRequestQueueOperation.NativeFieldInfoPtr_m_WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, "m_WebRequest");
			WebRequestQueueOperation.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, 100663463);
			WebRequestQueueOperation.NativeMethodInfoPtr_get_WebRequest_Public_get_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, 100663464);
			WebRequestQueueOperation.NativeMethodInfoPtr_set_WebRequest_Internal_set_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, 100663465);
			WebRequestQueueOperation.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, 100663466);
			WebRequestQueueOperation.NativeMethodInfoPtr_Complete_Internal_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr, 100663467);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000092B0 File Offset: 0x000074B0
		public unsafe bool IsDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueueOperation.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000092EC File Offset: 0x000074EC
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000932C File Offset: 0x0000752C
		public unsafe UnityWebRequest WebRequest
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueueOperation.NativeMethodInfoPtr_get_WebRequest_Public_get_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueueOperation.NativeMethodInfoPtr_set_WebRequest_Internal_set_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00009370 File Offset: 0x00007570
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 467666, RefRangeEnd = 467673, XrefRangeStart = 467666, XrefRangeEnd = 467673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestQueueOperation(UnityWebRequest request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestQueueOperation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueueOperation.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000093BC File Offset: 0x000075BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137194, XrefRangeEnd = 1137195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(UnityWebRequestAsyncOperation asyncOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestQueueOperation.NativeMethodInfoPtr_Complete_Internal_Void_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002751 File Offset: 0x00000951
		public WebRequestQueueOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00009400 File Offset: 0x00007600
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000275A File Offset: 0x0000095A
		public unsafe bool m_Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_m_Completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_m_Completed)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00009428 File Offset: 0x00007628
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe UnityWebRequestAsyncOperation Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00009458 File Offset: 0x00007658
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe Action<UnityWebRequestAsyncOperation> OnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_OnComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequestAsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00009488 File Offset: 0x00007688
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000027B3 File Offset: 0x000009B3
		public unsafe UnityWebRequest m_WebRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_m_WebRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestQueueOperation.NativeFieldInfoPtr_m_WebRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_m_Completed;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_OnComplete;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_m_WebRequest;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequest_Public_get_UnityWebRequest_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_set_WebRequest_Internal_set_Void_UnityWebRequest_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_UnityWebRequestAsyncOperation_0;
	}
}
