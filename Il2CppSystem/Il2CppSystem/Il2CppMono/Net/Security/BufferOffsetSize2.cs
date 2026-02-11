using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000011 RID: 17
	public class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize2()
		{
			Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "BufferOffsetSize2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr);
			BufferOffsetSize2.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, "InitialSize");
			BufferOffsetSize2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663468);
			BufferOffsetSize2.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663469);
			BufferOffsetSize2.NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663470);
			BufferOffsetSize2.NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663471);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001D988 File Offset: 0x0001BB88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 427613, RefRangeEnd = 427619, XrefRangeStart = 427608, XrefRangeEnd = 427613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize2(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 427623, RefRangeEnd = 427628, XrefRangeStart = 427619, XrefRangeEnd = 427623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001DA04 File Offset: 0x0001BC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427628, XrefRangeEnd = 427632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeRoom(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001DA44 File Offset: 0x0001BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427632, XrefRangeEnd = 427641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendData(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002520 File Offset: 0x00000720
		public BufferOffsetSize2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002529 File Offset: 0x00000729
		public unsafe int InitialSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize2.NativeFieldInfoPtr_InitialSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize2.NativeFieldInfoPtr_InitialSize)) = value;
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
