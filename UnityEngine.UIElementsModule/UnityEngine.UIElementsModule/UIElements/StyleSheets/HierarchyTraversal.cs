using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200027D RID: 637
	public class HierarchyTraversal : Object
	{
		// Token: 0x06002FA9 RID: 12201 RVA: 0x000CA770 File Offset: 0x000C8970
		// Note: this type is marked as 'beforefieldinit'.
		static HierarchyTraversal()
		{
			Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "HierarchyTraversal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr);
			HierarchyTraversal.NativeMethodInfoPtr_Traverse_Public_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr, 100670186);
			HierarchyTraversal.NativeMethodInfoPtr_TraverseRecursive_Public_Abstract_Virtual_New_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr, 100670187);
			HierarchyTraversal.NativeMethodInfoPtr_Recurse_Protected_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr, 100670188);
			HierarchyTraversal.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr, 100670189);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000CA7F0 File Offset: 0x000C89F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355325, RefRangeEnd = 355326, XrefRangeStart = 355325, XrefRangeEnd = 355325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Traverse(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HierarchyTraversal.NativeMethodInfoPtr_Traverse_Public_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000CA840 File Offset: 0x000C8A40
		[CallerCount(0)]
		public unsafe virtual void TraverseRecursive(VisualElement element, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HierarchyTraversal.NativeMethodInfoPtr_TraverseRecursive_Public_Abstract_Virtual_New_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000CA89C File Offset: 0x000C8A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355330, RefRangeEnd = 355332, XrefRangeStart = 355326, XrefRangeEnd = 355330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recurse(VisualElement element, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyTraversal.NativeMethodInfoPtr_Recurse_Protected_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x000CA8EC File Offset: 0x000C8AEC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HierarchyTraversal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyTraversal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyTraversal.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00013A93 File Offset: 0x00011C93
		public HierarchyTraversal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_Traverse_Public_Virtual_New_Void_VisualElement_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_TraverseRecursive_Public_Abstract_Virtual_New_Void_VisualElement_Int32_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_Recurse_Protected_Void_VisualElement_Int32_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
