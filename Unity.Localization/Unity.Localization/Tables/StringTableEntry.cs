using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x0200002A RID: 42
	public class StringTableEntry : TableEntry
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00013390 File Offset: 0x00011590
		// Note: this type is marked as 'beforefieldinit'.
		static StringTableEntry()
		{
			Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "StringTableEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr);
			StringTableEntry.NativeFieldInfoPtr_m_FormatCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, "m_FormatCache");
			StringTableEntry.NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663766);
			StringTableEntry.NativeMethodInfoPtr_set_FormatCache_Public_set_Void_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663767);
			StringTableEntry.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663768);
			StringTableEntry.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663769);
			StringTableEntry.NativeMethodInfoPtr_get_IsSmart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663770);
			StringTableEntry.NativeMethodInfoPtr_set_IsSmart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663771);
			StringTableEntry.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663772);
			StringTableEntry.NativeMethodInfoPtr_RemoveFromTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663773);
			StringTableEntry.NativeMethodInfoPtr_GetOrCreateFormatCache_Internal_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663774);
			StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663775);
			StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663776);
			StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663777);
			StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663778);
			StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_PseudoLocale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr, 100663779);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000290 RID: 656 RVA: 0x000134EC File Offset: 0x000116EC
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0001352C File Offset: 0x0001172C
		public unsafe FormatCache FormatCache
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_set_FormatCache_Public_set_Void_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00013570 File Offset: 0x00011770
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000135A8 File Offset: 0x000117A8
		public unsafe string Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374429, RefRangeEnd = 374430, XrefRangeStart = 374429, XrefRangeEnd = 374430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067672, XrefRangeEnd = 1067678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000135EC File Offset: 0x000117EC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00013628 File Offset: 0x00011828
		public unsafe bool IsSmart
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1067682, RefRangeEnd = 1067684, XrefRangeStart = 1067678, XrefRangeEnd = 1067682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_get_IsSmart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067684, XrefRangeEnd = 1067695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_set_IsSmart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00013668 File Offset: 0x00011868
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringTableEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTableEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000136A4 File Offset: 0x000118A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067695, XrefRangeEnd = 1067718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_RemoveFromTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000136D8 File Offset: 0x000118D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1067729, RefRangeEnd = 1067733, XrefRangeStart = 1067718, XrefRangeEnd = 1067729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatCache GetOrCreateFormatCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetOrCreateFormatCache_Internal_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr3) : null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00013718 File Offset: 0x00011918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067733, XrefRangeEnd = 1067742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00013750 File Offset: 0x00011950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067742, XrefRangeEnd = 1067751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000137A8 File Offset: 0x000119A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067751, XrefRangeEnd = 1067760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(IList<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000137F0 File Offset: 0x000119F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067760, XrefRangeEnd = 1067769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(IFormatProvider formatProvider, IList<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001384C File Offset: 0x00011A4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1067804, RefRangeEnd = 1067809, XrefRangeStart = 1067769, XrefRangeEnd = 1067804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(IFormatProvider formatProvider, IList<Object> args, PseudoLocale pseudoLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pseudoLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTableEntry.NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_PseudoLocale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002ED7 File Offset: 0x000010D7
		public string GetLocalizedString(params Object[] args)
		{
			return this.GetLocalizedString(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002EE5 File Offset: 0x000010E5
		public StringTableEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000138B8 File Offset: 0x00011AB8
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002EEE File Offset: 0x000010EE
		public unsafe FormatCache m_FormatCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringTableEntry.NativeFieldInfoPtr_m_FormatCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringTableEntry.NativeFieldInfoPtr_m_FormatCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_m_FormatCache;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatCache_Public_set_Void_FormatCache_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSmart_Public_get_Boolean_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSmart_Public_set_Void_Boolean_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromTable_Public_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateFormatCache_Internal_FormatCache_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_IFormatProvider_IList_1_Object_PseudoLocale_0;
	}
}
