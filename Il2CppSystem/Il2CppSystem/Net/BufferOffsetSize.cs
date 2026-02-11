using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001CB RID: 459
	public class BufferOffsetSize : Object
	{
		// Token: 0x06001C65 RID: 7269 RVA: 0x0008B13C File Offset: 0x0008933C
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize()
		{
			Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BufferOffsetSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr);
			BufferOffsetSize.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Buffer");
			BufferOffsetSize.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Offset");
			BufferOffsetSize.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Size");
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100667664);
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100667665);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0008B1D0 File Offset: 0x000893D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 476054, RefRangeEnd = 476058, XrefRangeStart = 476048, XrefRangeEnd = 476054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, int offset, int size, bool copyBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0008B248 File Offset: 0x00089448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476064, RefRangeEnd = 476065, XrefRangeStart = 476058, XrefRangeEnd = 476064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, bool copyBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0000C0DD File Offset: 0x0000A2DD
		public BufferOffsetSize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x0008B2A4 File Offset: 0x000894A4
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000C0E6 File Offset: 0x0000A2E6
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0008B2D4 File Offset: 0x000894D4
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0000C105 File Offset: 0x0000A305
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0008B2FC File Offset: 0x000894FC
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0000C120 File Offset: 0x0000A320
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0;
	}
}
