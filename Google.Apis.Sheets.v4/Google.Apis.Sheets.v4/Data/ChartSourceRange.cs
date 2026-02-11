using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200003E RID: 62
	public class ChartSourceRange : Object
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x0001D150 File Offset: 0x0001B350
		// Note: this type is marked as 'beforefieldinit'.
		static ChartSourceRange()
		{
			Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ChartSourceRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr);
			ChartSourceRange.NativeFieldInfoPtr__Sources_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, "<Sources>k__BackingField");
			ChartSourceRange.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, "<ETag>k__BackingField");
			ChartSourceRange.NativeMethodInfoPtr_get_Sources_Public_Virtual_New_get_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, 100664096);
			ChartSourceRange.NativeMethodInfoPtr_set_Sources_Public_Virtual_New_set_Void_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, 100664097);
			ChartSourceRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, 100664098);
			ChartSourceRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, 100664099);
			ChartSourceRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr, 100664100);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001D20C File Offset: 0x0001B40C
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0001D258 File Offset: 0x0001B458
		public unsafe virtual IList<GridRange> Sources
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartSourceRange.NativeMethodInfoPtr_get_Sources_Public_Virtual_New_get_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartSourceRange.NativeMethodInfoPtr_set_Sources_Public_Virtual_New_set_Void_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartSourceRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartSourceRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001D33C File Offset: 0x0001B53C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChartSourceRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartSourceRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChartSourceRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000436E File Offset: 0x0000256E
		public ChartSourceRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001D378 File Offset: 0x0001B578
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00004377 File Offset: 0x00002577
		public unsafe IList<GridRange> _Sources_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartSourceRange.NativeFieldInfoPtr__Sources_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartSourceRange.NativeFieldInfoPtr__Sources_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00004396 File Offset: 0x00002596
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartSourceRange.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartSourceRange.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr__Sources_k__BackingField;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_get_Sources_Public_Virtual_New_get_IList_1_GridRange_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_set_Sources_Public_Virtual_New_set_Void_IList_1_GridRange_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
