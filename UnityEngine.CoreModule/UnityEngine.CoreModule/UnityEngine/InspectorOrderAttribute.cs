using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200013F RID: 319
	public sealed class InspectorOrderAttribute : PropertyAttribute
	{
		// Token: 0x060018B1 RID: 6321 RVA: 0x00074654 File Offset: 0x00072854
		// Note: this type is marked as 'beforefieldinit'.
		static InspectorOrderAttribute()
		{
			Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InspectorOrderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr);
			InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_inspectorSort>k__BackingField");
			InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_sortDirection>k__BackingField");
			InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100666697);
			InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100666698);
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000746D4 File Offset: 0x000728D4
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00009B32 File Offset: 0x00007D32
		public unsafe InspectorSort m_inspectorSort
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._m_inspectorSort_k__BackingField = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00074710 File Offset: 0x00072910
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x00009B3B File Offset: 0x00007D3B
		public unsafe InspectorSortDirection m_sortDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._m_sortDirection_k__BackingField = value;
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00009AF3 File Offset: 0x00007CF3
		public InspectorOrderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0007474C File Offset: 0x0007294C
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00009AFC File Offset: 0x00007CFC
		public unsafe InspectorSort _m_inspectorSort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x00074774 File Offset: 0x00072974
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00009B17 File Offset: 0x00007D17
		public unsafe InspectorSortDirection _m_sortDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeFieldInfoPtr__m_inspectorSort_k__BackingField;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeFieldInfoPtr__m_sortDirection_k__BackingField;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0;
	}
}
