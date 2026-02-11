using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000013 RID: 19
	public static class Bits : Object
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		// Note: this type is marked as 'beforefieldinit'.
		static Bits()
		{
			Il2CppClassPointerStore<Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Bits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bits>.NativeClassPtr);
			Bits.NativeFieldInfoPtr_MASK_0101010101010101 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0101010101010101");
			Bits.NativeFieldInfoPtr_MASK_0011001100110011 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0011001100110011");
			Bits.NativeFieldInfoPtr_MASK_0000111100001111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000111100001111");
			Bits.NativeFieldInfoPtr_MASK_0000000011111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000000011111111");
			Bits.NativeFieldInfoPtr_MASK_1111111111111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_1111111111111111");
			Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663518);
			Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663519);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364133, XrefRangeEnd = 364137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364145, RefRangeEnd = 364147, XrefRangeStart = 364137, XrefRangeEnd = 364145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeastPosition(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public Bits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0001C124 File Offset: 0x0001A324
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002AC9 File Offset: 0x00000CC9
		public unsafe static uint MASK_0101010101010101
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0001C140 File Offset: 0x0001A340
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe static uint MASK_0011001100110011
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0001C15C File Offset: 0x0001A35C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public unsafe static uint MASK_0000111100001111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0001C178 File Offset: 0x0001A378
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public unsafe static uint MASK_0000000011111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0001C194 File Offset: 0x0001A394
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002B01 File Offset: 0x00000D01
		public unsafe static uint MASK_1111111111111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&value));
			}
		}

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0101010101010101;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0011001100110011;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000111100001111;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000000011111111;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_MASK_1111111111111111;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0;
	}
}
