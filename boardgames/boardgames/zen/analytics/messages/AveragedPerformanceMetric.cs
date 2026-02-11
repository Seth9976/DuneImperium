using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace zen.analytics.messages
{
	// Token: 0x02000099 RID: 153
	public class AveragedPerformanceMetric : Object
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x0002803C File Offset: 0x0002623C
		// Note: this type is marked as 'beforefieldinit'.
		static AveragedPerformanceMetric()
		{
			Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AveragedPerformanceMetric");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr);
			AveragedPerformanceMetric.NativeFieldInfoPtr__NumSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<NumSamples>k__BackingField");
			AveragedPerformanceMetric.NativeFieldInfoPtr__Min_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<Min>k__BackingField");
			AveragedPerformanceMetric.NativeFieldInfoPtr__Max_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<Max>k__BackingField");
			AveragedPerformanceMetric.NativeFieldInfoPtr__Average_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<Average>k__BackingField");
			AveragedPerformanceMetric.NativeFieldInfoPtr__Variance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<Variance>k__BackingField");
			AveragedPerformanceMetric.NativeFieldInfoPtr__StdDev_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, "<StdDev>k__BackingField");
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664475);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_NumSamples_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664476);
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_Min_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664477);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_Min_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664478);
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_Max_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664479);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_Max_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664480);
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_Average_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664481);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_Average_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664482);
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_Variance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664483);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_Variance_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664484);
			AveragedPerformanceMetric.NativeMethodInfoPtr_get_StdDev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664485);
			AveragedPerformanceMetric.NativeMethodInfoPtr_set_StdDev_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664486);
			AveragedPerformanceMetric.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664487);
			AveragedPerformanceMetric.NativeMethodInfoPtr_Sample_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664488);
			AveragedPerformanceMetric.NativeMethodInfoPtr_Sample_Public_Void_AveragedPerformanceMetric_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664489);
			AveragedPerformanceMetric.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr, 100664490);
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00028224 File Offset: 0x00026424
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00028260 File Offset: 0x00026460
		public unsafe int NumSamples
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_NumSamples_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000282A0 File Offset: 0x000264A0
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x000282DC File Offset: 0x000264DC
		public unsafe int Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_Min_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_Min_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0002831C File Offset: 0x0002651C
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00028358 File Offset: 0x00026558
		public unsafe int Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_Max_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_Max_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00028398 File Offset: 0x00026598
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000283D4 File Offset: 0x000265D4
		public unsafe float Average
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_Average_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_Average_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00028414 File Offset: 0x00026614
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00028450 File Offset: 0x00026650
		public unsafe float Variance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_Variance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_Variance_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00028490 File Offset: 0x00026690
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x000284CC File Offset: 0x000266CC
		public unsafe float StdDev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_get_StdDev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604705, RefRangeEnd = 604706, XrefRangeStart = 604705, XrefRangeEnd = 604706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_set_StdDev_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0002850C File Offset: 0x0002670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990762, XrefRangeEnd = 990763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AveragedPerformanceMetric()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AveragedPerformanceMetric>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00028548 File Offset: 0x00026748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 990763, RefRangeEnd = 990766, XrefRangeStart = 990763, XrefRangeEnd = 990763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sample(int newSample)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSample;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_Sample_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00028588 File Offset: 0x00026788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990766, XrefRangeEnd = 990768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sample(AveragedPerformanceMetric other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_Sample_Public_Void_AveragedPerformanceMetric_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000285CC File Offset: 0x000267CC
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AveragedPerformanceMetric.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000054BB File Offset: 0x000036BB
		public AveragedPerformanceMetric(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00028600 File Offset: 0x00026800
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000054C4 File Offset: 0x000036C4
		public unsafe int _NumSamples_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__NumSamples_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__NumSamples_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00028628 File Offset: 0x00026828
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000054DF File Offset: 0x000036DF
		public unsafe int _Min_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Min_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Min_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00028650 File Offset: 0x00026850
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000054FA File Offset: 0x000036FA
		public unsafe int _Max_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Max_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Max_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00028678 File Offset: 0x00026878
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00005515 File Offset: 0x00003715
		public unsafe float _Average_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Average_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Average_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000286A0 File Offset: 0x000268A0
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00005530 File Offset: 0x00003730
		public unsafe float _Variance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Variance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__Variance_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x000286C8 File Offset: 0x000268C8
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0000554B File Offset: 0x0000374B
		public unsafe float _StdDev_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__StdDev_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AveragedPerformanceMetric.NativeFieldInfoPtr__StdDev_k__BackingField)) = value;
			}
		}

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr__NumSamples_k__BackingField;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr__Min_k__BackingField;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr__Max_k__BackingField;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr__Average_k__BackingField;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr__Variance_k__BackingField;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr__StdDev_k__BackingField;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSamples_Public_get_Int32_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_set_NumSamples_Private_set_Void_Int32_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Int32_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_set_Min_Private_set_Void_Int32_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Int32_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_Max_Private_set_Void_Int32_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_Average_Public_get_Single_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_set_Average_Private_set_Void_Single_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_get_Variance_Public_get_Single_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_set_Variance_Private_set_Void_Single_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_StdDev_Public_get_Single_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_set_StdDev_Private_set_Void_Single_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Void_Int32_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Void_AveragedPerformanceMetric_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
	}
}
