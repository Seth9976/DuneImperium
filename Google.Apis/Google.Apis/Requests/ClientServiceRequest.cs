using System;
using Google.Apis.Http;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Requests
{
	// Token: 0x0200000F RID: 15
	public class ClientServiceRequest : Object
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000092C0 File Offset: 0x000074C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClientServiceRequest()
		{
			Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "ClientServiceRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr);
			ClientServiceRequest.NativeFieldInfoPtr__unsuccessfulResponseHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, "_unsuccessfulResponseHandlers");
			ClientServiceRequest.NativeFieldInfoPtr__exceptionHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, "_exceptionHandlers");
			ClientServiceRequest.NativeFieldInfoPtr__executeInterceptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, "_executeInterceptors");
			ClientServiceRequest.NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, 100663544);
			ClientServiceRequest.NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, 100663545);
			ClientServiceRequest.NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, 100663546);
			ClientServiceRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr, 100663547);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000937C File Offset: 0x0000757C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1197827, RefRangeEnd = 1197828, XrefRangeStart = 1197809, XrefRangeEnd = 1197827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnsuccessfulResponseHandler(IHttpUnsuccessfulResponseHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest.NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000093C0 File Offset: 0x000075C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197828, XrefRangeEnd = 1197846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExceptionHandler(IHttpExceptionHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest.NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00009404 File Offset: 0x00007604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1197864, RefRangeEnd = 1197865, XrefRangeStart = 1197846, XrefRangeEnd = 1197864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExecuteInterceptor(IHttpExecuteInterceptor handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest.NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00009448 File Offset: 0x00007648
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientServiceRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientServiceRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientServiceRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000263D File Offset: 0x0000083D
		public ClientServiceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00009484 File Offset: 0x00007684
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002646 File Offset: 0x00000846
		public unsafe List<IHttpUnsuccessfulResponseHandler> _unsuccessfulResponseHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__unsuccessfulResponseHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IHttpUnsuccessfulResponseHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__unsuccessfulResponseHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000094B4 File Offset: 0x000076B4
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002665 File Offset: 0x00000865
		public unsafe List<IHttpExceptionHandler> _exceptionHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__exceptionHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IHttpExceptionHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__exceptionHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000094E4 File Offset: 0x000076E4
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002684 File Offset: 0x00000884
		public unsafe List<IHttpExecuteInterceptor> _executeInterceptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__executeInterceptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IHttpExecuteInterceptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientServiceRequest.NativeFieldInfoPtr__executeInterceptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr__unsuccessfulResponseHandlers;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr__exceptionHandlers;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr__executeInterceptors;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
