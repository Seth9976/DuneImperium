using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B4 RID: 180
	public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x0005889C File Offset: 0x00056A9C
		// Note: this type is marked as 'beforefieldinit'.
		static ListViewReorderableDragAndDropController()
		{
			Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListViewReorderableDragAndDropController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr);
			ListViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ListView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr, "m_ListView");
			ListViewReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Public_Void_BaseListView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr, 100665713);
			ListViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr, 100665714);
			ListViewReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr, 100665715);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005891C File Offset: 0x00056B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311170, RefRangeEnd = 311171, XrefRangeStart = 311168, XrefRangeEnd = 311170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListViewReorderableDragAndDropController(BaseListView view)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListViewReorderableDragAndDropController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Public_Void_BaseListView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00058968 File Offset: 0x00056B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311171, XrefRangeEnd = 311176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000589C0 File Offset: 0x00056BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311176, XrefRangeEnd = 311190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000087D0 File Offset: 0x000069D0
		public ListViewReorderableDragAndDropController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00058A10 File Offset: 0x00056C10
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x000087D9 File Offset: 0x000069D9
		public unsafe BaseListView m_ListView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ListView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseListView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ListView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_m_ListView;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseListView_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0;
	}
}
