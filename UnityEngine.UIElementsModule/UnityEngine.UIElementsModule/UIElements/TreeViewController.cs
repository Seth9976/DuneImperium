using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000030 RID: 48
	public class TreeViewController : BaseTreeViewController
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00029EF0 File Offset: 0x000280F0
		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewController()
		{
			Il2CppClassPointerStore<TreeViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr);
			TreeViewController.NativeMethodInfoPtr_get_treeView_Protected_get_TreeView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663801);
			TreeViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663802);
			TreeViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663803);
			TreeViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663804);
			TreeViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663805);
			TreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr, 100663806);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00029F98 File Offset: 0x00028198
		public unsafe TreeView treeView
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 286408, RefRangeEnd = 286415, XrefRangeStart = 286407, XrefRangeEnd = 286408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewController.NativeMethodInfoPtr_get_treeView_Protected_get_TreeView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TreeView>(intPtr3) : null;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00029FD8 File Offset: 0x000281D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286415, XrefRangeEnd = 286422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0002A024 File Offset: 0x00028224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286422, XrefRangeEnd = 286426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0002A080 File Offset: 0x00028280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286426, XrefRangeEnd = 286427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0002A0DC File Offset: 0x000282DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286427, XrefRangeEnd = 286428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0002A12C File Offset: 0x0002832C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286432, RefRangeEnd = 286433, XrefRangeStart = 286428, XrefRangeEnd = 286432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002EB1 File Offset: 0x000010B1
		public TreeViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0002A168 File Offset: 0x00028368
		public override Object GetItemForId(int id)
		{
			IDefaultTreeViewController defaultTreeViewController = base.TryCast<IDefaultTreeViewController>();
			bool flag = defaultTreeViewController != null;
			Object @object;
			if (flag)
			{
				@object = defaultTreeViewController.GetItemDataForId(id);
			}
			else
			{
				@object = base.GetItemForId(id);
			}
			return @object;
		}

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_treeView_Protected_get_TreeView_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
