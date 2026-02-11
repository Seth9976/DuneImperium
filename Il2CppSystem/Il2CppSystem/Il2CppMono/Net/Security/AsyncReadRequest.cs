using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000017 RID: 23
	public class AsyncReadRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0001E708 File Offset: 0x0001C908
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadRequest()
		{
			Il2CppClassPointerStore<AsyncReadRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncReadRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadRequest>.NativeClassPtr);
			AsyncReadRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadRequest>.NativeClassPtr, 100663502);
			AsyncReadRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadRequest>.NativeClassPtr, 100663503);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001E760 File Offset: 0x0001C960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427906, XrefRangeEnd = 427907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427907, XrefRangeEnd = 427908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncReadRequest.NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000026A1 File Offset: 0x000008A1
		public AsyncReadRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Virtual_AsyncOperationStatus_AsyncOperationStatus_0;
	}
}
