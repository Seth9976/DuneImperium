using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A7 RID: 167
	public class IListDragAndDropArgs : Il2CppObjectBase
	{
		// Token: 0x0600103F RID: 4159 RVA: 0x00056208 File Offset: 0x00054408
		// Note: this type is marked as 'beforefieldinit'.
		static IListDragAndDropArgs()
		{
			Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IListDragAndDropArgs");
			IListDragAndDropArgs.NativeMethodInfoPtr_get_insertAtIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr, 100665637);
			IListDragAndDropArgs.NativeMethodInfoPtr_get_parentId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr, 100665638);
			IListDragAndDropArgs.NativeMethodInfoPtr_get_childIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr, 100665639);
			IListDragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropData_Public_Abstract_Virtual_New_get_DragAndDropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr, 100665640);
			IListDragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropPosition_Public_Abstract_Virtual_New_get_DragAndDropPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListDragAndDropArgs>.NativeClassPtr, 100665641);
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00056294 File Offset: 0x00054494
		public unsafe virtual int insertAtIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IListDragAndDropArgs.NativeMethodInfoPtr_get_insertAtIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x000562DC File Offset: 0x000544DC
		public unsafe virtual int parentId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IListDragAndDropArgs.NativeMethodInfoPtr_get_parentId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00056324 File Offset: 0x00054524
		public unsafe virtual int childIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IListDragAndDropArgs.NativeMethodInfoPtr_get_childIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0005636C File Offset: 0x0005456C
		public unsafe virtual DragAndDropData dragAndDropData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IListDragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropData_Public_Abstract_Virtual_New_get_DragAndDropData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragAndDropData>(intPtr3) : null;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000563B8 File Offset: 0x000545B8
		public unsafe virtual DragAndDropPosition dragAndDropPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IListDragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropPosition_Public_Abstract_Virtual_New_get_DragAndDropPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000082BA File Offset: 0x000064BA
		public IListDragAndDropArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_get_insertAtIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_get_parentId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_get_childIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDropData_Public_Abstract_Virtual_New_get_DragAndDropData_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDropPosition_Public_Abstract_Virtual_New_get_DragAndDropPosition_0;
	}
}
