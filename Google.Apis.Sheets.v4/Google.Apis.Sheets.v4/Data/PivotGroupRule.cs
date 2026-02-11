using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000091 RID: 145
	public class PivotGroupRule : Object
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00034C34 File Offset: 0x00032E34
		// Note: this type is marked as 'beforefieldinit'.
		static PivotGroupRule()
		{
			Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotGroupRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr);
			PivotGroupRule.NativeFieldInfoPtr__DateTimeRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, "<DateTimeRule>k__BackingField");
			PivotGroupRule.NativeFieldInfoPtr__HistogramRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, "<HistogramRule>k__BackingField");
			PivotGroupRule.NativeFieldInfoPtr__ManualRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, "<ManualRule>k__BackingField");
			PivotGroupRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, "<ETag>k__BackingField");
			PivotGroupRule.NativeMethodInfoPtr_get_DateTimeRule_Public_Virtual_New_get_DateTimeRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664853);
			PivotGroupRule.NativeMethodInfoPtr_set_DateTimeRule_Public_Virtual_New_set_Void_DateTimeRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664854);
			PivotGroupRule.NativeMethodInfoPtr_get_HistogramRule_Public_Virtual_New_get_HistogramRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664855);
			PivotGroupRule.NativeMethodInfoPtr_set_HistogramRule_Public_Virtual_New_set_Void_HistogramRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664856);
			PivotGroupRule.NativeMethodInfoPtr_get_ManualRule_Public_Virtual_New_get_ManualRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664857);
			PivotGroupRule.NativeMethodInfoPtr_set_ManualRule_Public_Virtual_New_set_Void_ManualRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664858);
			PivotGroupRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664859);
			PivotGroupRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664860);
			PivotGroupRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr, 100664861);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00034D68 File Offset: 0x00032F68
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00034DB4 File Offset: 0x00032FB4
		public unsafe virtual DateTimeRule DateTimeRule
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_get_DateTimeRule_Public_Virtual_New_get_DateTimeRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeRule>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_set_DateTimeRule_Public_Virtual_New_set_Void_DateTimeRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00034E04 File Offset: 0x00033004
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00034E50 File Offset: 0x00033050
		public unsafe virtual HistogramRule HistogramRule
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_get_HistogramRule_Public_Virtual_New_get_HistogramRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HistogramRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_set_HistogramRule_Public_Virtual_New_set_Void_HistogramRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00034EA0 File Offset: 0x000330A0
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00034EEC File Offset: 0x000330EC
		public unsafe virtual ManualRule ManualRule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_get_ManualRule_Public_Virtual_New_get_ManualRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_set_ManualRule_Public_Virtual_New_set_Void_ManualRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00034F3C File Offset: 0x0003313C
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00034F80 File Offset: 0x00033180
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00034FD0 File Offset: 0x000331D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotGroupRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotGroupRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotGroupRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0000749B File Offset: 0x0000569B
		public PivotGroupRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0003500C File Offset: 0x0003320C
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x000074A4 File Offset: 0x000056A4
		public unsafe DateTimeRule _DateTimeRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__DateTimeRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__DateTimeRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0003503C File Offset: 0x0003323C
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x000074C3 File Offset: 0x000056C3
		public unsafe HistogramRule _HistogramRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__HistogramRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HistogramRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__HistogramRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0003506C File Offset: 0x0003326C
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x000074E2 File Offset: 0x000056E2
		public unsafe ManualRule _ManualRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__ManualRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__ManualRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0003509C File Offset: 0x0003329C
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00007501 File Offset: 0x00005701
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr__DateTimeRule_k__BackingField;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr__HistogramRule_k__BackingField;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr__ManualRule_k__BackingField;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeRule_Public_Virtual_New_get_DateTimeRule_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeRule_Public_Virtual_New_set_Void_DateTimeRule_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_HistogramRule_Public_Virtual_New_get_HistogramRule_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_set_HistogramRule_Public_Virtual_New_set_Void_HistogramRule_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_get_ManualRule_Public_Virtual_New_get_ManualRule_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_set_ManualRule_Public_Virtual_New_set_Void_ManualRule_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
