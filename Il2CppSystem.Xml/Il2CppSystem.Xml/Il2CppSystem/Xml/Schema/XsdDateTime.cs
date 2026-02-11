using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001FB RID: 507
	[StructLayout(2)]
	public struct XsdDateTime
	{
		// Token: 0x06002C51 RID: 11345 RVA: 0x000CD220 File Offset: 0x000CB420
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDateTime()
		{
			Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr);
			XsdDateTime.NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "dt");
			XsdDateTime.NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "extra");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_dd");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_ddT");
			XsdDateTime.NativeFieldInfoPtr_LzHH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH");
			XsdDateTime.NativeFieldInfoPtr_LzHH_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_ss");
			XsdDateTime.NativeFieldInfoPtr_Lz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_dd");
			XsdDateTime.NativeFieldInfoPtr_Lz___ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___");
			XsdDateTime.NativeFieldInfoPtr_Lz___dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___dd");
			XsdDateTime.NativeFieldInfoPtr_typeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "typeCodes");
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669712);
			XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669713);
			XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669714);
			XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669715);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669716);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669717);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669718);
			XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669719);
			XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669720);
			XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669721);
			XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669722);
			XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669723);
			XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669724);
			XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669725);
			XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669726);
			XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669727);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669728);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669729);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669730);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669731);
			XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669732);
			XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669733);
			XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669734);
			XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669735);
			XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669736);
			XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100669737);
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000CD64C File Offset: 0x000CB84C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 424182, RefRangeEnd = 424202, XrefRangeStart = 424174, XrefRangeEnd = 424182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000CD690 File Offset: 0x000CB890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424202, XrefRangeEnd = 424206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000CD6CC File Offset: 0x000CB8CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 424211, RefRangeEnd = 424214, XrefRangeStart = 424206, XrefRangeEnd = 424211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000CD708 File Offset: 0x000CB908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424223, RefRangeEnd = 424224, XrefRangeStart = 424214, XrefRangeEnd = 424223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000CD768 File Offset: 0x000CB968
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 424250, RefRangeEnd = 424259, XrefRangeStart = 424224, XrefRangeEnd = 424250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000CD7A8 File Offset: 0x000CB9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424263, RefRangeEnd = 424264, XrefRangeStart = 424259, XrefRangeEnd = 424263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTimeOffset dateTimeOffset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000CD7DC File Offset: 0x000CB9DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 424287, RefRangeEnd = 424296, XrefRangeStart = 424264, XrefRangeEnd = 424287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000CD81C File Offset: 0x000CBA1C
		public unsafe XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000CD84C File Offset: 0x000CBA4C
		public unsafe XsdDateTime.XsdDateTimeKind InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000CD87C File Offset: 0x000CBA7C
		public unsafe int Year
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 424300, RefRangeEnd = 424302, XrefRangeStart = 424296, XrefRangeEnd = 424300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x000CD8AC File Offset: 0x000CBAAC
		public unsafe int Month
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 424306, RefRangeEnd = 424309, XrefRangeStart = 424302, XrefRangeEnd = 424306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000CD8DC File Offset: 0x000CBADC
		public unsafe int Day
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 424313, RefRangeEnd = 424315, XrefRangeStart = 424309, XrefRangeEnd = 424313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000CD90C File Offset: 0x000CBB0C
		public unsafe int Hour
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424315, XrefRangeEnd = 424319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000CD93C File Offset: 0x000CBB3C
		public unsafe int Minute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424319, XrefRangeEnd = 424323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000CD96C File Offset: 0x000CBB6C
		public unsafe int Second
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424323, XrefRangeEnd = 424327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000CD99C File Offset: 0x000CBB9C
		public unsafe int Fraction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 424339, RefRangeEnd = 424340, XrefRangeStart = 424327, XrefRangeEnd = 424339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000CD9CC File Offset: 0x000CBBCC
		public unsafe int ZoneHour
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000CD9FC File Offset: 0x000CBBFC
		public unsafe int ZoneMinute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000CDA2C File Offset: 0x000CBC2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 424448, RefRangeEnd = 424459, XrefRangeStart = 424340, XrefRangeEnd = 424448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTime(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000CDA6C File Offset: 0x000CBC6C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 424526, RefRangeEnd = 424536, XrefRangeStart = 424459, XrefRangeEnd = 424526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000CDAAC File Offset: 0x000CBCAC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 424611, RefRangeEnd = 424629, XrefRangeStart = 424536, XrefRangeEnd = 424611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000CDAD8 File Offset: 0x000CBCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424655, RefRangeEnd = 424657, XrefRangeStart = 424629, XrefRangeEnd = 424655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintDate(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000CDB10 File Offset: 0x000CBD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424687, RefRangeEnd = 424688, XrefRangeStart = 424657, XrefRangeEnd = 424687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintTime(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000CDB48 File Offset: 0x000CBD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424709, RefRangeEnd = 424710, XrefRangeStart = 424688, XrefRangeEnd = 424709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintZone(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000CDB80 File Offset: 0x000CBD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424710, RefRangeEnd = 424712, XrefRangeStart = 424710, XrefRangeEnd = 424710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntToCharArray(Il2CppStructArray<char> text, int start, int value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000CDBE0 File Offset: 0x000CBDE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 424712, RefRangeEnd = 424715, XrefRangeStart = 424712, XrefRangeEnd = 424712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShortToCharArray(Il2CppStructArray<char> text, int start, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0001254E File Offset: 0x0001074E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x000CDC34 File Offset: 0x000CBE34
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00012560 File Offset: 0x00010760
		public unsafe static int Lzyyyy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x000CDC50 File Offset: 0x000CBE50
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x0001256E File Offset: 0x0001076E
		public unsafe static int Lzyyyy_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000CDC6C File Offset: 0x000CBE6C
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x0001257C File Offset: 0x0001077C
		public unsafe static int Lzyyyy_MM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000CDC88 File Offset: 0x000CBE88
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x0001258A File Offset: 0x0001078A
		public unsafe static int Lzyyyy_MM_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000CDCA4 File Offset: 0x000CBEA4
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00012598 File Offset: 0x00010798
		public unsafe static int Lzyyyy_MM_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000CDCC0 File Offset: 0x000CBEC0
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x000125A6 File Offset: 0x000107A6
		public unsafe static int Lzyyyy_MM_ddT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000CDCDC File Offset: 0x000CBEDC
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x000125B4 File Offset: 0x000107B4
		public unsafe static int LzHH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&value));
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x000CDCF8 File Offset: 0x000CBEF8
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x000125C2 File Offset: 0x000107C2
		public unsafe static int LzHH_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&value));
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x000CDD14 File Offset: 0x000CBF14
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x000125D0 File Offset: 0x000107D0
		public unsafe static int LzHH_mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x000CDD30 File Offset: 0x000CBF30
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x000125DE File Offset: 0x000107DE
		public unsafe static int LzHH_mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&value));
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x000CDD4C File Offset: 0x000CBF4C
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x000125EC File Offset: 0x000107EC
		public unsafe static int LzHH_mm_ss
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&value));
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x000CDD68 File Offset: 0x000CBF68
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x000125FA File Offset: 0x000107FA
		public unsafe static int Lz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x000CDD84 File Offset: 0x000CBF84
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x00012608 File Offset: 0x00010808
		public unsafe static int Lz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000CDDA0 File Offset: 0x000CBFA0
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x00012616 File Offset: 0x00010816
		public unsafe static int Lz_zz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x000CDDBC File Offset: 0x000CBFBC
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00012624 File Offset: 0x00010824
		public unsafe static int Lz_zz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x000CDDD8 File Offset: 0x000CBFD8
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x00012632 File Offset: 0x00010832
		public unsafe static int Lz__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x000CDDF4 File Offset: 0x000CBFF4
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x00012640 File Offset: 0x00010840
		public unsafe static int Lz__mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000CDE10 File Offset: 0x000CC010
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x0001264E File Offset: 0x0001084E
		public unsafe static int Lz__mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x000CDE2C File Offset: 0x000CC02C
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x0001265C File Offset: 0x0001085C
		public unsafe static int Lz__mm__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x000CDE48 File Offset: 0x000CC048
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x0001266A File Offset: 0x0001086A
		public unsafe static int Lz__mm_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000CDE64 File Offset: 0x000CC064
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00012678 File Offset: 0x00010878
		public unsafe static int Lz___
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000CDE80 File Offset: 0x000CC080
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00012686 File Offset: 0x00010886
		public unsafe static int Lz___dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000CDE9C File Offset: 0x000CC09C
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00012694 File Offset: 0x00010894
		public unsafe static Il2CppStructArray<XmlTypeCode> typeCodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeFieldInfoPtr_dt;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeFieldInfoPtr_extra;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_dd;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_ddT;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeFieldInfoPtr_LzHH;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_ss;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeFieldInfoPtr_Lz_;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_zz;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeFieldInfoPtr_Lz__;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm__;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_dd;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeFieldInfoPtr_Lz___;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeFieldInfoPtr_Lz___dd;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeFieldInfoPtr_typeCodes;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Parser_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04002201 RID: 8705
		[FieldOffset(0)]
		public DateTime dt;

		// Token: 0x04002202 RID: 8706
		[FieldOffset(8)]
		public uint extra;

		// Token: 0x0200027B RID: 635
		public enum DateTimeTypeCode
		{
			// Token: 0x040027B3 RID: 10163
			DateTime,
			// Token: 0x040027B4 RID: 10164
			Time,
			// Token: 0x040027B5 RID: 10165
			Date,
			// Token: 0x040027B6 RID: 10166
			GYearMonth,
			// Token: 0x040027B7 RID: 10167
			GYear,
			// Token: 0x040027B8 RID: 10168
			GMonthDay,
			// Token: 0x040027B9 RID: 10169
			GDay,
			// Token: 0x040027BA RID: 10170
			GMonth,
			// Token: 0x040027BB RID: 10171
			XdrDateTime
		}

		// Token: 0x0200027C RID: 636
		public enum XsdDateTimeKind
		{
			// Token: 0x040027BD RID: 10173
			Unspecified,
			// Token: 0x040027BE RID: 10174
			Zulu,
			// Token: 0x040027BF RID: 10175
			LocalWestOfZulu,
			// Token: 0x040027C0 RID: 10176
			LocalEastOfZulu
		}

		// Token: 0x0200027D RID: 637
		public sealed class Parser : ValueType
		{
			// Token: 0x060032B2 RID: 12978 RVA: 0x000E0618 File Offset: 0x000DE818
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr);
				XsdDateTime.Parser.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "typeCode");
				XsdDateTime.Parser.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "year");
				XsdDateTime.Parser.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "month");
				XsdDateTime.Parser.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "day");
				XsdDateTime.Parser.NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "hour");
				XsdDateTime.Parser.NativeFieldInfoPtr_minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "minute");
				XsdDateTime.Parser.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "second");
				XsdDateTime.Parser.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "fraction");
				XsdDateTime.Parser.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "kind");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneHour");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneMinute");
				XsdDateTime.Parser.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "text");
				XsdDateTime.Parser.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "length");
				XsdDateTime.Parser.NativeFieldInfoPtr_Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "Power10");
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669739);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669740);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669741);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669742);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669743);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669744);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669745);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669746);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669747);
				XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100669748);
			}

			// Token: 0x060032B3 RID: 12979 RVA: 0x000E0824 File Offset: 0x000DEA24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 424028, RefRangeEnd = 424030, XrefRangeStart = 423994, XrefRangeEnd = 424028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse(string text, XsdDateTimeFlags kinds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032B4 RID: 12980 RVA: 0x000E0884 File Offset: 0x000DEA84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 424065, RefRangeEnd = 424066, XrefRangeStart = 424030, XrefRangeEnd = 424065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseDate(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032B5 RID: 12981 RVA: 0x000E08D4 File Offset: 0x000DEAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424066, XrefRangeEnd = 424073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032B6 RID: 12982 RVA: 0x000E0924 File Offset: 0x000DEB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424073, XrefRangeEnd = 424077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032B7 RID: 12983 RVA: 0x000E0974 File Offset: 0x000DEB74
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 424121, RefRangeEnd = 424124, XrefRangeStart = 424077, XrefRangeEnd = 424121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTime(ref int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032B8 RID: 12984 RVA: 0x000E09C4 File Offset: 0x000DEBC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 424158, RefRangeEnd = 424160, XrefRangeStart = 424124, XrefRangeEnd = 424158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032B9 RID: 12985 RVA: 0x000E0A14 File Offset: 0x000DEC14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 424165, RefRangeEnd = 424166, XrefRangeStart = 424160, XrefRangeEnd = 424165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse4Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032BA RID: 12986 RVA: 0x000E0A70 File Offset: 0x000DEC70
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 424169, RefRangeEnd = 424174, XrefRangeStart = 424166, XrefRangeEnd = 424169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse2Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032BB RID: 12987 RVA: 0x000E0ACC File Offset: 0x000DECCC
			[CallerCount(0)]
			public unsafe bool ParseChar(int start, char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032BC RID: 12988 RVA: 0x000E0B28 File Offset: 0x000DED28
			[CallerCount(0)]
			public unsafe static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032BD RID: 12989 RVA: 0x00015CB3 File Offset: 0x00013EB3
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060032BE RID: 12990 RVA: 0x00015CBC File Offset: 0x00013EBC
			public Parser()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr))
			{
			}

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x060032BF RID: 12991 RVA: 0x000E0B74 File Offset: 0x000DED74
			// (set) Token: 0x060032C0 RID: 12992 RVA: 0x00015CCE File Offset: 0x00013ECE
			public unsafe XsdDateTime.DateTimeTypeCode typeCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode)) = value;
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000E0B9C File Offset: 0x000DED9C
			// (set) Token: 0x060032C2 RID: 12994 RVA: 0x00015CE9 File Offset: 0x00013EE9
			public unsafe int year
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year)) = value;
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x060032C3 RID: 12995 RVA: 0x000E0BC4 File Offset: 0x000DEDC4
			// (set) Token: 0x060032C4 RID: 12996 RVA: 0x00015D04 File Offset: 0x00013F04
			public unsafe int month
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month)) = value;
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x060032C5 RID: 12997 RVA: 0x000E0BEC File Offset: 0x000DEDEC
			// (set) Token: 0x060032C6 RID: 12998 RVA: 0x00015D1F File Offset: 0x00013F1F
			public unsafe int day
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day)) = value;
				}
			}

			// Token: 0x1700110B RID: 4363
			// (get) Token: 0x060032C7 RID: 12999 RVA: 0x000E0C14 File Offset: 0x000DEE14
			// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00015D3A File Offset: 0x00013F3A
			public unsafe int hour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour)) = value;
				}
			}

			// Token: 0x1700110C RID: 4364
			// (get) Token: 0x060032C9 RID: 13001 RVA: 0x000E0C3C File Offset: 0x000DEE3C
			// (set) Token: 0x060032CA RID: 13002 RVA: 0x00015D55 File Offset: 0x00013F55
			public unsafe int minute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute)) = value;
				}
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x060032CB RID: 13003 RVA: 0x000E0C64 File Offset: 0x000DEE64
			// (set) Token: 0x060032CC RID: 13004 RVA: 0x00015D70 File Offset: 0x00013F70
			public unsafe int second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x060032CD RID: 13005 RVA: 0x000E0C8C File Offset: 0x000DEE8C
			// (set) Token: 0x060032CE RID: 13006 RVA: 0x00015D8B File Offset: 0x00013F8B
			public unsafe int fraction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction)) = value;
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x060032CF RID: 13007 RVA: 0x000E0CB4 File Offset: 0x000DEEB4
			// (set) Token: 0x060032D0 RID: 13008 RVA: 0x00015DA6 File Offset: 0x00013FA6
			public unsafe XsdDateTime.XsdDateTimeKind kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind)) = value;
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x060032D1 RID: 13009 RVA: 0x000E0CDC File Offset: 0x000DEEDC
			// (set) Token: 0x060032D2 RID: 13010 RVA: 0x00015DC1 File Offset: 0x00013FC1
			public unsafe int zoneHour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour)) = value;
				}
			}

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x060032D3 RID: 13011 RVA: 0x000E0D04 File Offset: 0x000DEF04
			// (set) Token: 0x060032D4 RID: 13012 RVA: 0x00015DDC File Offset: 0x00013FDC
			public unsafe int zoneMinute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute)) = value;
				}
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x060032D5 RID: 13013 RVA: 0x000E0D2C File Offset: 0x000DEF2C
			// (set) Token: 0x060032D6 RID: 13014 RVA: 0x00015DF7 File Offset: 0x00013FF7
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x060032D7 RID: 13015 RVA: 0x000E0D54 File Offset: 0x000DEF54
			// (set) Token: 0x060032D8 RID: 13016 RVA: 0x00015E16 File Offset: 0x00014016
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x060032D9 RID: 13017 RVA: 0x000E0D7C File Offset: 0x000DEF7C
			// (set) Token: 0x060032DA RID: 13018 RVA: 0x00015E31 File Offset: 0x00014031
			public unsafe static Il2CppStructArray<int> Power10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027C1 RID: 10177
			private static readonly IntPtr NativeFieldInfoPtr_typeCode;

			// Token: 0x040027C2 RID: 10178
			private static readonly IntPtr NativeFieldInfoPtr_year;

			// Token: 0x040027C3 RID: 10179
			private static readonly IntPtr NativeFieldInfoPtr_month;

			// Token: 0x040027C4 RID: 10180
			private static readonly IntPtr NativeFieldInfoPtr_day;

			// Token: 0x040027C5 RID: 10181
			private static readonly IntPtr NativeFieldInfoPtr_hour;

			// Token: 0x040027C6 RID: 10182
			private static readonly IntPtr NativeFieldInfoPtr_minute;

			// Token: 0x040027C7 RID: 10183
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x040027C8 RID: 10184
			private static readonly IntPtr NativeFieldInfoPtr_fraction;

			// Token: 0x040027C9 RID: 10185
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x040027CA RID: 10186
			private static readonly IntPtr NativeFieldInfoPtr_zoneHour;

			// Token: 0x040027CB RID: 10187
			private static readonly IntPtr NativeFieldInfoPtr_zoneMinute;

			// Token: 0x040027CC RID: 10188
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040027CD RID: 10189
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x040027CE RID: 10190
			private static readonly IntPtr NativeFieldInfoPtr_Power10;

			// Token: 0x040027CF RID: 10191
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0;

			// Token: 0x040027D0 RID: 10192
			private static readonly IntPtr NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0;

			// Token: 0x040027D1 RID: 10193
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x040027D2 RID: 10194
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x040027D3 RID: 10195
			private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0;

			// Token: 0x040027D4 RID: 10196
			private static readonly IntPtr NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x040027D5 RID: 10197
			private static readonly IntPtr NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x040027D6 RID: 10198
			private static readonly IntPtr NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x040027D7 RID: 10199
			private static readonly IntPtr NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0;

			// Token: 0x040027D8 RID: 10200
			private static readonly IntPtr NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0;
		}
	}
}
