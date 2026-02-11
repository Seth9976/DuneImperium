using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.input
{
	// Token: 0x02000138 RID: 312
	public class IDragTarget : Il2CppObjectBase
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x0004A61C File Offset: 0x0004881C
		// Note: this type is marked as 'beforefieldinit'.
		static IDragTarget()
		{
			Il2CppClassPointerStore<IDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "IDragTarget");
			IDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragTarget>.NativeClassPtr, 100665348);
			IDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Abstract_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragTarget>.NativeClassPtr, 100665349);
			IDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Abstract_Virtual_New_Boolean_DraggableCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragTarget>.NativeClassPtr, 100665350);
			IDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Abstract_Virtual_New_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragTarget>.NativeClassPtr, 100665351);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0004A694 File Offset: 0x00048894
		[CallerCount(0)]
		public unsafe virtual bool ExclusiveOption()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragTarget.NativeMethodInfoPtr_ExclusiveOption_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0004A6DC File Offset: 0x000488DC
		[CallerCount(0)]
		public unsafe virtual EntityID GetDragPileEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragTarget.NativeMethodInfoPtr_GetDragPileEntityID_Public_Abstract_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0004A728 File Offset: 0x00048928
		[CallerCount(0)]
		public unsafe virtual bool HandleDropOnTarget(DraggableCard draggableCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggableCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Abstract_Virtual_New_Boolean_DraggableCard_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0004A780 File Offset: 0x00048980
		[CallerCount(0)]
		public unsafe virtual bool GetIsSelectable(List<EntityID> selectableEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Abstract_Virtual_New_Boolean_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00008CEF File Offset: 0x00006EEF
		public IDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_ExclusiveOption_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_GetDragPileEntityID_Public_Abstract_Virtual_New_EntityID_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_HandleDropOnTarget_Public_Abstract_Virtual_New_Boolean_DraggableCard_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_GetIsSelectable_Public_Abstract_Virtual_New_Boolean_List_1_EntityID_0;
	}
}
