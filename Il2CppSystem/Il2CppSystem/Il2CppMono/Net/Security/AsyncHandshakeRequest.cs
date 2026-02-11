using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000015 RID: 21
	public class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x0001E364 File Offset: 0x0001C564
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncHandshakeRequest()
		{
			Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncHandshakeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr);
			AsyncHandshakeRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr, 100663495);
			AsyncHandshakeRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr, 100663496);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001E3BC File Offset: 0x0001C5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427886, XrefRangeEnd = 427887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncHandshakeRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncHandshakeRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001E418 File Offset: 0x0001C618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427887, XrefRangeEnd = 427889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncHandshakeRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002655 File Offset: 0x00000855
		public AsyncHandshakeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0;
	}
}
