using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200003D RID: 61
	public class ChartData : Object
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001CED0 File Offset: 0x0001B0D0
		// Note: this type is marked as 'beforefieldinit'.
		static ChartData()
		{
			Il2CppClassPointerStore<ChartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ChartData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartData>.NativeClassPtr);
			ChartData.NativeFieldInfoPtr__SourceRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "<SourceRange>k__BackingField");
			ChartData.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "<ETag>k__BackingField");
			ChartData.NativeMethodInfoPtr_get_SourceRange_Public_Virtual_New_get_ChartSourceRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100664091);
			ChartData.NativeMethodInfoPtr_set_SourceRange_Public_Virtual_New_set_Void_ChartSourceRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100664092);
			ChartData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100664093);
			ChartData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100664094);
			ChartData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100664095);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001CF8C File Offset: 0x0001B18C
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		public unsafe virtual ChartSourceRange SourceRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartData.NativeMethodInfoPtr_get_SourceRange_Public_Virtual_New_get_ChartSourceRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartSourceRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartData.NativeMethodInfoPtr_set_SourceRange_Public_Virtual_New_set_Void_ChartSourceRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0001D028 File Offset: 0x0001B228
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0001D06C File Offset: 0x0001B26C
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001D0BC File Offset: 0x0001B2BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChartData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChartData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004327 File Offset: 0x00002527
		public ChartData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004330 File Offset: 0x00002530
		public unsafe ChartSourceRange _SourceRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartData.NativeFieldInfoPtr__SourceRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartSourceRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartData.NativeFieldInfoPtr__SourceRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001D128 File Offset: 0x0001B328
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x0000434F File Offset: 0x0000254F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartData.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartData.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr__SourceRange_k__BackingField;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceRange_Public_Virtual_New_get_ChartSourceRange_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceRange_Public_Virtual_New_set_Void_ChartSourceRange_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
