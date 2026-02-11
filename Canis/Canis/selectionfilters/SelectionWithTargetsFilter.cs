using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.selectionfilters
{
	// Token: 0x02000058 RID: 88
	public class SelectionWithTargetsFilter : SelectionMessageFilter
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x0002D620 File Offset: 0x0002B820
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargetsFilter()
		{
			Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SelectionWithTargetsFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr);
			SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr, "FirstSelectionID");
			SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionForced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr, "FirstSelectionForced");
			SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionCanCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr, "FirstSelectionCanCancel");
			SelectionWithTargetsFilter.NativeFieldInfoPtr_TargetFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr, "TargetFilters");
			SelectionWithTargetsFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr, 100664352);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00004426 File Offset: 0x00002626
		public SelectionWithTargetsFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000442F File Offset: 0x0000262F
		public unsafe EntityID FirstSelectionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0002D720 File Offset: 0x0002B920
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000444E File Offset: 0x0000264E
		public unsafe bool FirstSelectionForced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionForced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionForced)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0002D748 File Offset: 0x0002B948
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004469 File Offset: 0x00002669
		public unsafe bool FirstSelectionCanCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionCanCancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_FirstSelectionCanCancel)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0002D770 File Offset: 0x0002B970
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004484 File Offset: 0x00002684
		public unsafe Il2CppReferenceArray<SelectionNodeFilterData> TargetFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_TargetFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SelectionNodeFilterData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsFilter.NativeFieldInfoPtr_TargetFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_FirstSelectionID;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_FirstSelectionForced;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_FirstSelectionCanCancel;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_TargetFilters;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
