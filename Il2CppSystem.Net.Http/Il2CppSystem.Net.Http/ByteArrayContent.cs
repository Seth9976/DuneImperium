using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000007 RID: 7
	public class ByteArrayContent : HttpContent
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00005B78 File Offset: 0x00003D78
		// Note: this type is marked as 'beforefieldinit'.
		static ByteArrayContent()
		{
			Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "ByteArrayContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr);
			ByteArrayContent.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, "content");
			ByteArrayContent.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, "offset");
			ByteArrayContent.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, "count");
			ByteArrayContent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, 100663352);
			ByteArrayContent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, 100663353);
			ByteArrayContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, 100663354);
			ByteArrayContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, 100663355);
			ByteArrayContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr, 100663356);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005C48 File Offset: 0x00003E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1170996, RefRangeEnd = 1170997, XrefRangeStart = 1170994, XrefRangeEnd = 1170996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteArrayContent(Il2CppStructArray<byte> content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteArrayContent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005C94 File Offset: 0x00003E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1170999, RefRangeEnd = 1171000, XrefRangeStart = 1170997, XrefRangeEnd = 1170999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteArrayContent(Il2CppStructArray<byte> content, int offset, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteArrayContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteArrayContent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005CFC File Offset: 0x00003EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171000, XrefRangeEnd = 1171010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Stream> CreateContentReadStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteArrayContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005D48 File Offset: 0x00003F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171010, XrefRangeEnd = 1171011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteArrayContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005DB8 File Offset: 0x00003FB8
		[CallerCount(0)]
		public unsafe override bool TryComputeLength(out long length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteArrayContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000237C File Offset: 0x0000057C
		public ByteArrayContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00005E0C File Offset: 0x0000400C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002385 File Offset: 0x00000585
		public unsafe Il2CppStructArray<byte> content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00005E3C File Offset: 0x0000403C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000023A4 File Offset: 0x000005A4
		public unsafe int offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00005E64 File Offset: 0x00004064
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteArrayContent.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0;
	}
}
