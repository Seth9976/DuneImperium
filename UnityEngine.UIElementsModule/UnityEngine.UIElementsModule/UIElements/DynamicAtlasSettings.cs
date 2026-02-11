using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000131 RID: 305
	[Serializable]
	public class DynamicAtlasSettings : Object
	{
		// Token: 0x060016A4 RID: 5796 RVA: 0x0006D640 File Offset: 0x0006B840
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicAtlasSettings()
		{
			Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DynamicAtlasSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr);
			DynamicAtlasSettings.NativeFieldInfoPtr_m_MinAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, "m_MinAtlasSize");
			DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, "m_MaxAtlasSize");
			DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxSubTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, "m_MaxSubTextureSize");
			DynamicAtlasSettings.NativeFieldInfoPtr_m_ActiveFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, "m_ActiveFilters");
			DynamicAtlasSettings.NativeFieldInfoPtr_m_CustomFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, "m_CustomFilter");
			DynamicAtlasSettings.NativeMethodInfoPtr_get_minAtlasSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666683);
			DynamicAtlasSettings.NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666684);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666685);
			DynamicAtlasSettings.NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666686);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666687);
			DynamicAtlasSettings.NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666688);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_activeFilters_Public_get_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666689);
			DynamicAtlasSettings.NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666690);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666691);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_customFilter_Public_get_DynamicAtlasCustomFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666692);
			DynamicAtlasSettings.NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666693);
			DynamicAtlasSettings.NativeMethodInfoPtr_get_defaults_Public_Static_get_DynamicAtlasSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666694);
			DynamicAtlasSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr, 100666695);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0006D7D8 File Offset: 0x0006B9D8
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0006D814 File Offset: 0x0006BA14
		public unsafe int minAtlasSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_minAtlasSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0006D854 File Offset: 0x0006BA54
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0006D890 File Offset: 0x0006BA90
		public unsafe int maxAtlasSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0006D8D0 File Offset: 0x0006BAD0
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x0006D90C File Offset: 0x0006BB0C
		public unsafe int maxSubTextureSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0006D94C File Offset: 0x0006BB4C
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x0006D988 File Offset: 0x0006BB88
		public unsafe DynamicAtlasFilters activeFilters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_activeFilters_Public_get_DynamicAtlasFilters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0006D9C8 File Offset: 0x0006BBC8
		public unsafe static DynamicAtlasFilters defaultFilters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317883, XrefRangeEnd = 317884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x0006DA38 File Offset: 0x0006BC38
		public unsafe DynamicAtlasCustomFilter customFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_customFilter_Public_get_DynamicAtlasCustomFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicAtlasCustomFilter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0006DA7C File Offset: 0x0006BC7C
		public unsafe static DynamicAtlasSettings defaults
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317884, XrefRangeEnd = 317890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr_get_defaults_Public_Static_get_DynamicAtlasSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicAtlasSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicAtlasSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicAtlasSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000A769 File Offset: 0x00008969
		public DynamicAtlasSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0006DAEC File Offset: 0x0006BCEC
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0000A772 File Offset: 0x00008972
		public unsafe int m_MinAtlasSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MinAtlasSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MinAtlasSize)) = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0006DB14 File Offset: 0x0006BD14
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000A78D File Offset: 0x0000898D
		public unsafe int m_MaxAtlasSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxAtlasSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxAtlasSize)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0000A7A8 File Offset: 0x000089A8
		public unsafe int m_MaxSubTextureSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxSubTextureSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_MaxSubTextureSize)) = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0006DB64 File Offset: 0x0006BD64
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0000A7C3 File Offset: 0x000089C3
		public unsafe DynamicAtlasFilters m_ActiveFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_ActiveFilters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_ActiveFilters)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0006DB8C File Offset: 0x0006BD8C
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x0000A7DE File Offset: 0x000089DE
		public unsafe DynamicAtlasCustomFilter m_CustomFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_CustomFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasCustomFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlasSettings.NativeFieldInfoPtr_m_CustomFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr_m_MinAtlasSize;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxAtlasSize;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSubTextureSize;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveFilters;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomFilter;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_minAtlasSize_Public_get_Int32_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_activeFilters_Public_get_DynamicAtlasFilters_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_get_customFilter_Public_get_DynamicAtlasCustomFilter_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_get_defaults_Public_Static_get_DynamicAtlasSettings_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
