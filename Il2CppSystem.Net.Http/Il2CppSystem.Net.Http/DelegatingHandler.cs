using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000009 RID: 9
	public class DelegatingHandler : HttpMessageHandler
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00005E8C File Offset: 0x0000408C
		// Note: this type is marked as 'beforefieldinit'.
		static DelegatingHandler()
		{
			Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "DelegatingHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr);
			DelegatingHandler.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, "disposed");
			DelegatingHandler.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, "handler");
			DelegatingHandler.NativeMethodInfoPtr__ctor_Protected_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, 100663357);
			DelegatingHandler.NativeMethodInfoPtr_get_InnerHandler_Public_get_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, 100663358);
			DelegatingHandler.NativeMethodInfoPtr_set_InnerHandler_Public_set_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, 100663359);
			DelegatingHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, 100663360);
			DelegatingHandler.NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr, 100663361);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005F48 File Offset: 0x00004148
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1171019, RefRangeEnd = 1171029, XrefRangeStart = 1171011, XrefRangeEnd = 1171019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegatingHandler(HttpMessageHandler innerHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegatingHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingHandler.NativeMethodInfoPtr__ctor_Protected_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005F94 File Offset: 0x00004194
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00005FD4 File Offset: 0x000041D4
		public unsafe HttpMessageHandler InnerHandler
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingHandler.NativeMethodInfoPtr_get_InnerHandler_Public_get_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMessageHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171029, XrefRangeEnd = 1171036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingHandler.NativeMethodInfoPtr_set_InnerHandler_Public_set_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00006018 File Offset: 0x00004218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171036, RefRangeEnd = 1171037, XrefRangeStart = 1171036, XrefRangeEnd = 1171036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegatingHandler.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006064 File Offset: 0x00004264
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1171043, RefRangeEnd = 1171049, XrefRangeStart = 1171037, XrefRangeEnd = 1171043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegatingHandler.NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000023DA File Offset: 0x000005DA
		public DelegatingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000023E3 File Offset: 0x000005E3
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingHandler.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingHandler.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00006100 File Offset: 0x00004300
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000023FE File Offset: 0x000005FE
		public unsafe HttpMessageHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingHandler.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMessageHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingHandler.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_HttpMessageHandler_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerHandler_Public_get_HttpMessageHandler_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerHandler_Public_set_Void_HttpMessageHandler_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_FamOrAssem_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;
	}
}
