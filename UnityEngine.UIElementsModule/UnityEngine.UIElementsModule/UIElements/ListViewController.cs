using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002C RID: 44
	public class ListViewController : BaseListViewController
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00028EF0 File Offset: 0x000270F0
		// Note: this type is marked as 'beforefieldinit'.
		static ListViewController()
		{
			Il2CppClassPointerStore<ListViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewController>.NativeClassPtr);
			ListViewController.NativeMethodInfoPtr_get_listView_Protected_get_ListView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663747);
			ListViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663748);
			ListViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663749);
			ListViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663750);
			ListViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663751);
			ListViewController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewController>.NativeClassPtr, 100663752);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00028F98 File Offset: 0x00027198
		public unsafe ListView listView
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 286126, RefRangeEnd = 286133, XrefRangeStart = 286125, XrefRangeEnd = 286126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewController.NativeMethodInfoPtr_get_listView_Protected_get_ListView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListView>(intPtr3) : null;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00028FD8 File Offset: 0x000271D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286133, XrefRangeEnd = 286140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00029024 File Offset: 0x00027224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286140, XrefRangeEnd = 286145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00029080 File Offset: 0x00027280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286145, XrefRangeEnd = 286146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnbindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000290DC File Offset: 0x000272DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286146, XrefRangeEnd = 286147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002912C File Offset: 0x0002732C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListViewController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002DDB File Offset: 0x00000FDB
		public ListViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_listView_Protected_get_ListView_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
