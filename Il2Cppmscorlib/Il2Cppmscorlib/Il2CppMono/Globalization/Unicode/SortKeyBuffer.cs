using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000028 RID: 40
	public class SortKeyBuffer : Object
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x0002C52C File Offset: 0x0002A72C
		// Note: this type is marked as 'beforefieldinit'.
		static SortKeyBuffer()
		{
			Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SortKeyBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr);
			SortKeyBuffer.NativeFieldInfoPtr_l1b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l1b");
			SortKeyBuffer.NativeFieldInfoPtr_l2b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l2b");
			SortKeyBuffer.NativeFieldInfoPtr_l3b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l3b");
			SortKeyBuffer.NativeFieldInfoPtr_l4sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4sb");
			SortKeyBuffer.NativeFieldInfoPtr_l4tb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4tb");
			SortKeyBuffer.NativeFieldInfoPtr_l4kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4kb");
			SortKeyBuffer.NativeFieldInfoPtr_l4wb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4wb");
			SortKeyBuffer.NativeFieldInfoPtr_l5b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l5b");
			SortKeyBuffer.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "source");
			SortKeyBuffer.NativeFieldInfoPtr_l1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l1");
			SortKeyBuffer.NativeFieldInfoPtr_l2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l2");
			SortKeyBuffer.NativeFieldInfoPtr_l3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l3");
			SortKeyBuffer.NativeFieldInfoPtr_l4s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4s");
			SortKeyBuffer.NativeFieldInfoPtr_l4t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4t");
			SortKeyBuffer.NativeFieldInfoPtr_l4k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4k");
			SortKeyBuffer.NativeFieldInfoPtr_l4w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4w");
			SortKeyBuffer.NativeFieldInfoPtr_l5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l5");
			SortKeyBuffer.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "lcid");
			SortKeyBuffer.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "options");
			SortKeyBuffer.NativeFieldInfoPtr_processLevel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "processLevel2");
			SortKeyBuffer.NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "frenchSort");
			SortKeyBuffer.NativeFieldInfoPtr_frenchSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "frenchSorted");
			SortKeyBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663572);
			SortKeyBuffer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663573);
			SortKeyBuffer.NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663574);
			SortKeyBuffer.NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663575);
			SortKeyBuffer.NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663576);
			SortKeyBuffer.NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663577);
			SortKeyBuffer.NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663578);
			SortKeyBuffer.NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663579);
			SortKeyBuffer.NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663580);
			SortKeyBuffer.NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663581);
			SortKeyBuffer.NativeMethodInfoPtr_GetResult_Public_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663582);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKeyBuffer(int lcid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0002C838 File Offset: 0x0002AA38
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0002C86C File Offset: 0x0002AA6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277509, RefRangeEnd = 1277511, XrefRangeStart = 1277483, XrefRangeEnd = 1277509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CompareOptions options, int lcid, string s, bool frenchSort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frenchSort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277511, XrefRangeEnd = 1277517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lv1msb;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1lsb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0002C924 File Offset: 0x0002AB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277517, XrefRangeEnd = 1277523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSmallKana;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref markType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKatakana;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHalfWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0002C9C4 File Offset: 0x0002ABC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1277534, RefRangeEnd = 1277539, XrefRangeStart = 1277523, XrefRangeEnd = 1277534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002CA2C File Offset: 0x0002AC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277539, XrefRangeEnd = 1277543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLevel5(byte category, byte lv1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0002CA78 File Offset: 0x0002AC78
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1277548, RefRangeEnd = 1277569, XrefRangeStart = 1277543, XrefRangeEnd = 1277548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendBufferPrimitive(byte value, ref Il2CppStructArray<byte> buf, ref int bidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bidx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buf = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0002CAEC File Offset: 0x0002ACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277569, XrefRangeEnd = 1277570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetResultAndReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0002CB2C File Offset: 0x0002AD2C
		[CallerCount(0)]
		public unsafe int GetOptimizedLength(Il2CppStructArray<byte> data, int len, byte defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002CB98 File Offset: 0x0002AD98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1277589, RefRangeEnd = 1277592, XrefRangeStart = 1277570, XrefRangeEnd = 1277589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetResult_Public_SortKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002AED File Offset: 0x00000CED
		public SortKeyBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public unsafe Il2CppStructArray<byte> l1b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0002CC08 File Offset: 0x0002AE08
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002B15 File Offset: 0x00000D15
		public unsafe Il2CppStructArray<byte> l2b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0002CC38 File Offset: 0x0002AE38
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002B34 File Offset: 0x00000D34
		public unsafe Il2CppStructArray<byte> l3b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0002CC68 File Offset: 0x0002AE68
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002B53 File Offset: 0x00000D53
		public unsafe Il2CppStructArray<byte> l4sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0002CC98 File Offset: 0x0002AE98
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002B72 File Offset: 0x00000D72
		public unsafe Il2CppStructArray<byte> l4tb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4tb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4tb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0002CCC8 File Offset: 0x0002AEC8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002B91 File Offset: 0x00000D91
		public unsafe Il2CppStructArray<byte> l4kb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4kb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4kb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public unsafe Il2CppStructArray<byte> l4wb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4wb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4wb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0002CD28 File Offset: 0x0002AF28
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002BCF File Offset: 0x00000DCF
		public unsafe Il2CppStructArray<byte> l5b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0002CD58 File Offset: 0x0002AF58
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002BEE File Offset: 0x00000DEE
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0002CD80 File Offset: 0x0002AF80
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002C0D File Offset: 0x00000E0D
		public unsafe int l1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002C28 File Offset: 0x00000E28
		public unsafe int l2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002C43 File Offset: 0x00000E43
		public unsafe int l3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002C5E File Offset: 0x00000E5E
		public unsafe int l4s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4s);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4s)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0002CE20 File Offset: 0x0002B020
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002C79 File Offset: 0x00000E79
		public unsafe int l4t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4t);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4t)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0002CE48 File Offset: 0x0002B048
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe int l4k
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4k);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4k)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0002CE70 File Offset: 0x0002B070
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002CAF File Offset: 0x00000EAF
		public unsafe int l4w
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4w);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4w)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0002CE98 File Offset: 0x0002B098
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002CCA File Offset: 0x00000ECA
		public unsafe int l5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002D00 File Offset: 0x00000F00
		public unsafe CompareOptions options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_options)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0002CF10 File Offset: 0x0002B110
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002D1B File Offset: 0x00000F1B
		public unsafe bool processLevel2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_processLevel2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_processLevel2)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0002CF38 File Offset: 0x0002B138
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002D36 File Offset: 0x00000F36
		public unsafe bool frenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSort)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0002CF60 File Offset: 0x0002B160
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002D51 File Offset: 0x00000F51
		public unsafe bool frenchSorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSorted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSorted)) = value;
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_l1b;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_l2b;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_l3b;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_l4sb;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_l4tb;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_l4kb;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_l4wb;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_l5b;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_l1;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_l2;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_l3;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_l4s;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_l4t;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_l4k;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_l4w;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_l5;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_processLevel2;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_frenchSort;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_frenchSorted;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_SortKey_0;
	}
}
