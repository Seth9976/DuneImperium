using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000073 RID: 115
	public class Capture : Object
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00037044 File Offset: 0x00035244
		// Note: this type is marked as 'beforefieldinit'.
		static Capture()
		{
			Il2CppClassPointerStore<Capture>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Capture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Capture>.NativeClassPtr);
			Capture.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "<Index>k__BackingField");
			Capture.NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "<Length>k__BackingField");
			Capture.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "<Text>k__BackingField");
			Capture.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664432);
			Capture.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664433);
			Capture.NativeMethodInfoPtr_set_Index_FamAndAssem_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664434);
			Capture.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664435);
			Capture.NativeMethodInfoPtr_set_Length_FamAndAssem_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664436);
			Capture.NativeMethodInfoPtr_get_Text_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664437);
			Capture.NativeMethodInfoPtr_set_Text_FamAndAssem_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664438);
			Capture.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664439);
			Capture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664440);
			Capture.NativeMethodInfoPtr_GetLeftSubstring_Internal_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664441);
			Capture.NativeMethodInfoPtr_GetRightSubstring_Internal_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664442);
			Capture.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100664443);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000371A0 File Offset: 0x000353A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437269, XrefRangeEnd = 437271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture(string text, int index, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Capture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00037208 File Offset: 0x00035408
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00037244 File Offset: 0x00035444
		public unsafe int Index
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_set_Index_FamAndAssem_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00037284 File Offset: 0x00035484
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x000372C0 File Offset: 0x000354C0
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_set_Length_FamAndAssem_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00037300 File Offset: 0x00035500
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00037338 File Offset: 0x00035538
		public unsafe string Text
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Text_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_set_Text_FamAndAssem_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0003737C File Offset: 0x0003557C
		public unsafe string Value
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 437273, RefRangeEnd = 437300, XrefRangeStart = 437271, XrefRangeEnd = 437273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000373B4 File Offset: 0x000355B4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 437273, RefRangeEnd = 437300, XrefRangeStart = 437273, XrefRangeEnd = 437300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Capture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000373F8 File Offset: 0x000355F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 437305, RefRangeEnd = 437309, XrefRangeStart = 437300, XrefRangeEnd = 437305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<char> GetLeftSubstring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_GetLeftSubstring_Internal_ReadOnlySpan_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<char>(intPtr);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00037430 File Offset: 0x00035630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 437312, RefRangeEnd = 437316, XrefRangeStart = 437309, XrefRangeEnd = 437312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<char> GetRightSubstring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_GetRightSubstring_Internal_ReadOnlySpan_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<char>(intPtr);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00037468 File Offset: 0x00035668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437316, XrefRangeEnd = 437319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Capture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000441D File Offset: 0x0000261D
		public Capture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000374A4 File Offset: 0x000356A4
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00004426 File Offset: 0x00002626
		public unsafe int _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Index_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x000374CC File Offset: 0x000356CC
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00004441 File Offset: 0x00002641
		public unsafe int _Length_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Length_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Length_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x000374F4 File Offset: 0x000356F4
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x0000445C File Offset: 0x0000265C
		public unsafe string _Text_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Text_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__Text_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr__Length_k__BackingField;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr__Text_k__BackingField;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_FamAndAssem_set_Void_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_FamAndAssem_set_Void_Int32_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Internal_get_String_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_FamAndAssem_set_Void_String_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftSubstring_Internal_ReadOnlySpan_1_Char_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_GetRightSubstring_Internal_ReadOnlySpan_1_Char_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
