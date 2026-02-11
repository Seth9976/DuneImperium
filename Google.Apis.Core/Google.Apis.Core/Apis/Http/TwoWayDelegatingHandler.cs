using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000038 RID: 56
	public sealed class TwoWayDelegatingHandler : DelegatingHandler
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0000CF6C File Offset: 0x0000B16C
		// Note: this type is marked as 'beforefieldinit'.
		static TwoWayDelegatingHandler()
		{
			Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "TwoWayDelegatingHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr);
			TwoWayDelegatingHandler.NativeFieldInfoPtr__alternativeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, "_alternativeHandler");
			TwoWayDelegatingHandler.NativeFieldInfoPtr__useAlternative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, "_useAlternative");
			TwoWayDelegatingHandler.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, "disposed");
			TwoWayDelegatingHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_HttpMessageHandler_Func_2_HttpRequestMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, 100663684);
			TwoWayDelegatingHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, 100663685);
			TwoWayDelegatingHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, 100663686);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000D014 File Offset: 0x0000B214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212650, XrefRangeEnd = 1212657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwoWayDelegatingHandler(HttpMessageHandler normalHandler, HttpMessageHandler alternativeHandler, Func<HttpRequestMessage, bool> useAlternative)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alternativeHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useAlternative);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoWayDelegatingHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_HttpMessageHandler_Func_2_HttpRequestMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000D084 File Offset: 0x0000B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212657, XrefRangeEnd = 1212659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoWayDelegatingHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212659, XrefRangeEnd = 1212662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoWayDelegatingHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002FC9 File Offset: 0x000011C9
		public TwoWayDelegatingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000D12C File Offset: 0x0000B32C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002FD2 File Offset: 0x000011D2
		public unsafe TwoWayDelegatingHandler.AccessibleDelegatingHandler _alternativeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr__alternativeHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoWayDelegatingHandler.AccessibleDelegatingHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr__alternativeHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000D15C File Offset: 0x0000B35C
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002FF1 File Offset: 0x000011F1
		public unsafe Func<HttpRequestMessage, bool> _useAlternative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr__useAlternative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpRequestMessage, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr__useAlternative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000D18C File Offset: 0x0000B38C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003010 File Offset: 0x00001210
		public new unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoWayDelegatingHandler.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr__alternativeHandler;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr__useAlternative;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_HttpMessageHandler_Func_2_HttpRequestMessage_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x02000062 RID: 98
		public sealed class AccessibleDelegatingHandler : DelegatingHandler
		{
			// Token: 0x060003DB RID: 987 RVA: 0x000115AC File Offset: 0x0000F7AC
			// Note: this type is marked as 'beforefieldinit'.
			static AccessibleDelegatingHandler()
			{
				Il2CppClassPointerStore<TwoWayDelegatingHandler.AccessibleDelegatingHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwoWayDelegatingHandler>.NativeClassPtr, "AccessibleDelegatingHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoWayDelegatingHandler.AccessibleDelegatingHandler>.NativeClassPtr);
				TwoWayDelegatingHandler.AccessibleDelegatingHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayDelegatingHandler.AccessibleDelegatingHandler>.NativeClassPtr, 100663687);
				TwoWayDelegatingHandler.AccessibleDelegatingHandler.NativeMethodInfoPtr_InternalSendAsync_Internal_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoWayDelegatingHandler.AccessibleDelegatingHandler>.NativeClassPtr, 100663688);
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00011600 File Offset: 0x0000F800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessibleDelegatingHandler(HttpMessageHandler innerHandler)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoWayDelegatingHandler.AccessibleDelegatingHandler>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerHandler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoWayDelegatingHandler.AccessibleDelegatingHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003DD RID: 989 RVA: 0x0001164C File Offset: 0x0000F84C
			[CallerCount(0)]
			public unsafe Task<HttpResponseMessage> InternalSendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoWayDelegatingHandler.AccessibleDelegatingHandler.NativeMethodInfoPtr_InternalSendAsync_Internal_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00003D65 File Offset: 0x00001F65
			public AccessibleDelegatingHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr_InternalSendAsync_Internal_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;
		}
	}
}
