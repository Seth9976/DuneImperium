using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200012C RID: 300
	public class RestrictionFacets : Object
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x00083914 File Offset: 0x00081B14
		// Note: this type is marked as 'beforefieldinit'.
		static RestrictionFacets()
		{
			Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RestrictionFacets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr);
			RestrictionFacets.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Length");
			RestrictionFacets.NativeFieldInfoPtr_MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinLength");
			RestrictionFacets.NativeFieldInfoPtr_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxLength");
			RestrictionFacets.NativeFieldInfoPtr_Patterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Patterns");
			RestrictionFacets.NativeFieldInfoPtr_Enumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Enumeration");
			RestrictionFacets.NativeFieldInfoPtr_WhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "WhiteSpace");
			RestrictionFacets.NativeFieldInfoPtr_MaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxExclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinExclusive");
			RestrictionFacets.NativeFieldInfoPtr_TotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "TotalDigits");
			RestrictionFacets.NativeFieldInfoPtr_FractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FractionDigits");
			RestrictionFacets.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Flags");
			RestrictionFacets.NativeFieldInfoPtr_FixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FixedFlags");
			RestrictionFacets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, 100667248);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00083A70 File Offset: 0x00081C70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestrictionFacets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestrictionFacets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0000AFEA File Offset: 0x000091EA
		public RestrictionFacets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00083AAC File Offset: 0x00081CAC
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0000AFF3 File Offset: 0x000091F3
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00083AD4 File Offset: 0x00081CD4
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x0000B00E File Offset: 0x0000920E
		public unsafe int MinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength)) = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00083AFC File Offset: 0x00081CFC
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0000B029 File Offset: 0x00009229
		public unsafe int MaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength)) = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00083B24 File Offset: 0x00081D24
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0000B044 File Offset: 0x00009244
		public unsafe ArrayList Patterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00083B54 File Offset: 0x00081D54
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x0000B063 File Offset: 0x00009263
		public unsafe ArrayList Enumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00083B84 File Offset: 0x00081D84
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x0000B082 File Offset: 0x00009282
		public unsafe XmlSchemaWhiteSpace WhiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace)) = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00083BAC File Offset: 0x00081DAC
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x0000B09D File Offset: 0x0000929D
		public unsafe Object MaxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00083BDC File Offset: 0x00081DDC
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0000B0BC File Offset: 0x000092BC
		public unsafe Object MaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00083C0C File Offset: 0x00081E0C
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0000B0DB File Offset: 0x000092DB
		public unsafe Object MinInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00083C3C File Offset: 0x00081E3C
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x0000B0FA File Offset: 0x000092FA
		public unsafe Object MinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00083C6C File Offset: 0x00081E6C
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x0000B119 File Offset: 0x00009319
		public unsafe int TotalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits)) = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x00083C94 File Offset: 0x00081E94
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x0000B134 File Offset: 0x00009334
		public unsafe int FractionDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits)) = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00083CBC File Offset: 0x00081EBC
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0000B14F File Offset: 0x0000934F
		public unsafe RestrictionFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00083CE4 File Offset: 0x00081EE4
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0000B16A File Offset: 0x0000936A
		public unsafe RestrictionFlags FixedFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FixedFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FixedFlags)) = value;
			}
		}

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeFieldInfoPtr_MinLength;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeFieldInfoPtr_MaxLength;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_Patterns;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_Enumeration;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpace;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_MaxInclusive;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeFieldInfoPtr_MaxExclusive;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeFieldInfoPtr_MinInclusive;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeFieldInfoPtr_MinExclusive;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeFieldInfoPtr_TotalDigits;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeFieldInfoPtr_FractionDigits;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_FixedFlags;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
