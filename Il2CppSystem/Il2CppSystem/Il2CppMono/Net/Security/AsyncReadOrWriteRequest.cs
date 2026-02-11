using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000016 RID: 22
	public class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0001E46C File Offset: 0x0001C66C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadOrWriteRequest()
		{
			Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncReadOrWriteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr);
			AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, "<UserBuffer>k__BackingField");
			AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, "<CurrentSize>k__BackingField");
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663497);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663498);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663499);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663500);
			AsyncReadOrWriteRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr, 100663501);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0001E528 File Offset: 0x0001C728
		public unsafe BufferOffsetSize UserBuffer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0001E568 File Offset: 0x0001C768
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
		public unsafe int CurrentSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001E5E4 File Offset: 0x0001C7E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 427895, RefRangeEnd = 427901, XrefRangeStart = 427889, XrefRangeEnd = 427895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadOrWriteRequest>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncReadOrWriteRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001E66C File Offset: 0x0001C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427901, XrefRangeEnd = 427906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncReadOrWriteRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000265E File Offset: 0x0000085E
		public AsyncReadOrWriteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002667 File Offset: 0x00000867
		public unsafe BufferOffsetSize _UserBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__UserBuffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0001E6E0 File Offset: 0x0001C8E0
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002686 File Offset: 0x00000886
		public unsafe int _CurrentSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadOrWriteRequest.NativeFieldInfoPtr__CurrentSize_k__BackingField)) = value;
			}
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr__UserBuffer_k__BackingField;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSize_k__BackingField;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_UserBuffer_Protected_get_BufferOffsetSize_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSize_Protected_get_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSize_Protected_set_Void_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
