using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct BinXmlSqlDecimal
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000170B8 File Offset: 0x000152B8
		// Note: this type is marked as 'beforefieldinit'.
		static BinXmlSqlDecimal()
		{
			Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinXmlSqlDecimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr);
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_bLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_bLen");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_bPrec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_bPrec");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_bScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_bScale");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_bSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_bSign");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_data1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_data1");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_data2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_data2");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_data3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_data3");
			BinXmlSqlDecimal.NativeFieldInfoPtr_m_data4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "m_data4");
			BinXmlSqlDecimal.NativeFieldInfoPtr_NUMERIC_MAX_PRECISION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "NUMERIC_MAX_PRECISION");
			BinXmlSqlDecimal.NativeFieldInfoPtr_MaxPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "MaxPrecision");
			BinXmlSqlDecimal.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "MaxScale");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_cNumeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_cNumeMax");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_lInt32Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_lInt32Base");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_ulInt32Base");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32BaseForMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_ulInt32BaseForMod");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_llMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_llMax");
			BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "DUINT_BASE");
			BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "DUINT_BASE2");
			BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "DUINT_BASE3");
			BinXmlSqlDecimal.NativeFieldInfoPtr_x_rgulShiftBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "x_rgulShiftBase");
			BinXmlSqlDecimal.NativeFieldInfoPtr_rgCLenFromPrec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, "rgCLenFromPrec");
			BinXmlSqlDecimal.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663318);
			BinXmlSqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663319);
			BinXmlSqlDecimal.NativeMethodInfoPtr_UIntFromByteArray_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663320);
			BinXmlSqlDecimal.NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663321);
			BinXmlSqlDecimal.NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663322);
			BinXmlSqlDecimal.NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663323);
			BinXmlSqlDecimal.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663324);
			BinXmlSqlDecimal.NativeMethodInfoPtr_TrimTrailingZeros_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663325);
			BinXmlSqlDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, 100663326);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00017340 File Offset: 0x00015540
		public unsafe bool IsPositive
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00017370 File Offset: 0x00015570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362268, RefRangeEnd = 362269, XrefRangeStart = 362249, XrefRangeEnd = 362268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlSqlDecimal(Il2CppStructArray<byte> data, int offset, bool trim)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000173C4 File Offset: 0x000155C4
		[CallerCount(0)]
		public unsafe static uint UIntFromByteArray(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_UIntFromByteArray_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00017414 File Offset: 0x00015614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362269, XrefRangeEnd = 362272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MpDiv1(Il2CppStructArray<uint> rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulU);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulU;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iulD;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iulR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00017474 File Offset: 0x00015674
		[CallerCount(0)]
		public unsafe static void MpNormalize(Il2CppStructArray<uint> rgulU, ref int ciulU)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulU);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulU;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000174B8 File Offset: 0x000156B8
		[CallerCount(0)]
		public unsafe static char ChFromDigit(uint uiDigit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uiDigit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000174F8 File Offset: 0x000156F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362272, XrefRangeEnd = 362276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ToDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00017528 File Offset: 0x00015728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362280, RefRangeEnd = 362281, XrefRangeStart = 362276, XrefRangeEnd = 362280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimTrailingZeros()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_TrimTrailingZeros_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00017550 File Offset: 0x00015750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362306, RefRangeEnd = 362307, XrefRangeStart = 362281, XrefRangeEnd = 362306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002301 File Offset: 0x00000501
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinXmlSqlDecimal>.NativeClassPtr, ref this));
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0001757C File Offset: 0x0001577C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002313 File Offset: 0x00000513
		public unsafe static byte NUMERIC_MAX_PRECISION
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_NUMERIC_MAX_PRECISION, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_NUMERIC_MAX_PRECISION, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00017598 File Offset: 0x00015798
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002321 File Offset: 0x00000521
		public unsafe static byte MaxPrecision
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_MaxPrecision, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_MaxPrecision, (void*)(&value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000175B4 File Offset: 0x000157B4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000232F File Offset: 0x0000052F
		public unsafe static byte MaxScale
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_MaxScale, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000175D0 File Offset: 0x000157D0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000233D File Offset: 0x0000053D
		public unsafe static int x_cNumeMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_cNumeMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_cNumeMax, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000175EC File Offset: 0x000157EC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000234B File Offset: 0x0000054B
		public unsafe static long x_lInt32Base
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_lInt32Base, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_lInt32Base, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00017608 File Offset: 0x00015808
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe static ulong x_ulInt32Base
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32Base, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32Base, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00017624 File Offset: 0x00015824
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002367 File Offset: 0x00000567
		public unsafe static ulong x_ulInt32BaseForMod
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32BaseForMod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_ulInt32BaseForMod, (void*)(&value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00017640 File Offset: 0x00015840
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002375 File Offset: 0x00000575
		public unsafe static ulong x_llMax
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_llMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_llMax, (void*)(&value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0001765C File Offset: 0x0001585C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002383 File Offset: 0x00000583
		public unsafe static double DUINT_BASE
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE, (void*)(&value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00017678 File Offset: 0x00015878
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002391 File Offset: 0x00000591
		public unsafe static double DUINT_BASE2
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE2, (void*)(&value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00017694 File Offset: 0x00015894
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000239F File Offset: 0x0000059F
		public unsafe static double DUINT_BASE3
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_DUINT_BASE3, (void*)(&value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000176B0 File Offset: 0x000158B0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000023AD File Offset: 0x000005AD
		public unsafe static Il2CppStructArray<uint> x_rgulShiftBase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_rgulShiftBase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_x_rgulShiftBase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000176D8 File Offset: 0x000158D8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe static Il2CppStructArray<byte> rgCLenFromPrec
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinXmlSqlDecimal.NativeFieldInfoPtr_rgCLenFromPrec, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlSqlDecimal.NativeFieldInfoPtr_rgCLenFromPrec, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_bLen;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_bPrec;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_bScale;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_bSign;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_data1;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_m_data2;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_m_data3;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_data4;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_NUMERIC_MAX_PRECISION;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrecision;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_x_cNumeMax;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_x_lInt32Base;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_x_ulInt32Base;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_x_ulInt32BaseForMod;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_x_llMax;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_DUINT_BASE;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_DUINT_BASE2;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_DUINT_BASE3;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_x_rgulShiftBase;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_rgCLenFromPrec;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_UIntFromByteArray_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Decimal_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_TrimTrailingZeros_Private_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000086 RID: 134
		[FieldOffset(0)]
		public byte m_bLen;

		// Token: 0x04000087 RID: 135
		[FieldOffset(1)]
		public byte m_bPrec;

		// Token: 0x04000088 RID: 136
		[FieldOffset(2)]
		public byte m_bScale;

		// Token: 0x04000089 RID: 137
		[FieldOffset(3)]
		public byte m_bSign;

		// Token: 0x0400008A RID: 138
		[FieldOffset(4)]
		public uint m_data1;

		// Token: 0x0400008B RID: 139
		[FieldOffset(8)]
		public uint m_data2;

		// Token: 0x0400008C RID: 140
		[FieldOffset(12)]
		public uint m_data3;

		// Token: 0x0400008D RID: 141
		[FieldOffset(16)]
		public uint m_data4;
	}
}
