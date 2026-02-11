using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002B0 RID: 688
	public class MultiColumnHeaderColumnSortIndicator : VisualElement
	{
		// Token: 0x06003347 RID: 13127 RVA: 0x000D88A8 File Offset: 0x000D6AA8
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnSortIndicator()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnSortIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr);
			MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_arrowUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, "arrowUssClassName");
			MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_indexLabelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, "indexLabelUssClassName");
			MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_m_IndexLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, "m_IndexLabel");
			MultiColumnHeaderColumnSortIndicator.NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, 100670745);
			MultiColumnHeaderColumnSortIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr, 100670746);
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x00014C49 File Offset: 0x00012E49
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x000D8950 File Offset: 0x000D6B50
		public unsafe string sortOrderLabel
		{
			get
			{
				return this.m_IndexLabel.text;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361611, XrefRangeEnd = 361612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnSortIndicator.NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000D8994 File Offset: 0x000D6B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361612, XrefRangeEnd = 361639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnSortIndicator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnSortIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnSortIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00014BEB File Offset: 0x00012DEB
		public MultiColumnHeaderColumnSortIndicator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x000D89D0 File Offset: 0x000D6BD0
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x00014BF4 File Offset: 0x00012DF4
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x000D89F0 File Offset: 0x000D6BF0
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x00014C06 File Offset: 0x00012E06
		public unsafe static string arrowUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_arrowUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_arrowUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x000D8A10 File Offset: 0x000D6C10
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x00014C18 File Offset: 0x00012E18
		public unsafe static string indexLabelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_indexLabelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_indexLabelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x000D8A30 File Offset: 0x000D6C30
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x00014C2A File Offset: 0x00012E2A
		public unsafe Label m_IndexLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_m_IndexLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnSortIndicator.NativeFieldInfoPtr_m_IndexLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeFieldInfoPtr_arrowUssClassName;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeFieldInfoPtr_indexLabelUssClassName;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexLabel;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
