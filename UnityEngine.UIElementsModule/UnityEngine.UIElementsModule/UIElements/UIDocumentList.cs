using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000138 RID: 312
	public class UIDocumentList : Object
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x0006FBDC File Offset: 0x0006DDDC
		// Note: this type is marked as 'beforefieldinit'.
		static UIDocumentList()
		{
			Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIDocumentList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr);
			UIDocumentList.NativeFieldInfoPtr_m_AttachedUIDocuments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr, "m_AttachedUIDocuments");
			UIDocumentList.NativeMethodInfoPtr_RemoveFromListAndFromVisualTree_Internal_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr, 100666785);
			UIDocumentList.NativeMethodInfoPtr_AddToListAndToVisualTree_Internal_Void_UIDocument_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr, 100666786);
			UIDocumentList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr, 100666787);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0006FC5C File Offset: 0x0006DE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318811, XrefRangeEnd = 318815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromListAndFromVisualTree(UIDocument uiDocument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDocument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocumentList.NativeMethodInfoPtr_RemoveFromListAndFromVisualTree_Internal_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0006FCA0 File Offset: 0x0006DEA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318848, RefRangeEnd = 318850, XrefRangeStart = 318815, XrefRangeEnd = 318848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDocument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visualTree);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstInsertIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocumentList.NativeMethodInfoPtr_AddToListAndToVisualTree_Internal_Void_UIDocument_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0006FD04 File Offset: 0x0006DF04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318858, RefRangeEnd = 318860, XrefRangeStart = 318850, XrefRangeEnd = 318858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIDocumentList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDocumentList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocumentList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0000AC76 File Offset: 0x00008E76
		public UIDocumentList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x0006FD40 File Offset: 0x0006DF40
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x0000AC7F File Offset: 0x00008E7F
		public unsafe List<UIDocument> m_AttachedUIDocuments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocumentList.NativeFieldInfoPtr_m_AttachedUIDocuments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIDocument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocumentList.NativeFieldInfoPtr_m_AttachedUIDocuments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeFieldInfoPtr_m_AttachedUIDocuments;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromListAndFromVisualTree_Internal_Void_UIDocument_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_AddToListAndToVisualTree_Internal_Void_UIDocument_VisualElement_Int32_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
