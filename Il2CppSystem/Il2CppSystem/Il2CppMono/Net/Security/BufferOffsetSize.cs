using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000010 RID: 16
	public class BufferOffsetSize : Object
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0001D61C File Offset: 0x0001B81C
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize()
		{
			Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "BufferOffsetSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr);
			BufferOffsetSize.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Buffer");
			BufferOffsetSize.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Offset");
			BufferOffsetSize.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Size");
			BufferOffsetSize.NativeFieldInfoPtr_TotalBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "TotalBytes");
			BufferOffsetSize.NativeFieldInfoPtr_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Complete");
			BufferOffsetSize.NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663464);
			BufferOffsetSize.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663465);
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663466);
			BufferOffsetSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663467);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0001D700 File Offset: 0x0001B900
		public unsafe int EndOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0001D73C File Offset: 0x0001B93C
		public unsafe int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001D778 File Offset: 0x0001B978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427599, RefRangeEnd = 427600, XrefRangeStart = 427597, XrefRangeEnd = 427599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427600, XrefRangeEnd = 427608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BufferOffsetSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000248C File Offset: 0x0000068C
		public BufferOffsetSize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0001D824 File Offset: 0x0001BA24
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002495 File Offset: 0x00000695
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0001D854 File Offset: 0x0001BA54
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000024B4 File Offset: 0x000006B4
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0001D87C File Offset: 0x0001BA7C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000024CF File Offset: 0x000006CF
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001D8A4 File Offset: 0x0001BAA4
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000024EA File Offset: 0x000006EA
		public unsafe int TotalBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_TotalBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_TotalBytes)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001D8CC File Offset: 0x0001BACC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe bool Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Complete)) = value;
			}
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_TotalBytes;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_Complete;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
