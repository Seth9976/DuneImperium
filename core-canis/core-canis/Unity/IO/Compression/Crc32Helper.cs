using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000066 RID: 102
	public static class Crc32Helper : Object
	{
		// Token: 0x06000722 RID: 1826 RVA: 0x00030618 File Offset: 0x0002E818
		// Note: this type is marked as 'beforefieldinit'.
		static Crc32Helper()
		{
			Il2CppClassPointerStore<Crc32Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "Crc32Helper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crc32Helper>.NativeClassPtr);
			Crc32Helper.NativeFieldInfoPtr_crcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crc32Helper>.NativeClassPtr, "crcTable");
			Crc32Helper.NativeMethodInfoPtr_UpdateCrc32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crc32Helper>.NativeClassPtr, 100664386);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00030670 File Offset: 0x0002E870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860688, XrefRangeEnd = 860692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint UpdateCrc32(uint crc32, Il2CppStructArray<byte> buffer, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref crc32;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crc32Helper.NativeMethodInfoPtr_UpdateCrc32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00004473 File Offset: 0x00002673
		public Crc32Helper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000306DC File Offset: 0x0002E8DC
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x0000447C File Offset: 0x0000267C
		public unsafe static Il2CppStructArray<uint> crcTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Crc32Helper.NativeFieldInfoPtr_crcTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Crc32Helper.NativeFieldInfoPtr_crcTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_crcTable;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCrc32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
