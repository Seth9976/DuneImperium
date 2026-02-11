using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000C3 RID: 195
	public class IZenDragHandler : Il2CppObjectBase
	{
		// Token: 0x060009B8 RID: 2488 RVA: 0x000301A4 File Offset: 0x0002E3A4
		// Note: this type is marked as 'beforefieldinit'.
		static IZenDragHandler()
		{
			Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IZenDragHandler");
			IZenDragHandler.NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664884);
			IZenDragHandler.NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664885);
			IZenDragHandler.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664886);
			IZenDragHandler.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664887);
			IZenDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664888);
			IZenDragHandler.NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenDragHandler>.NativeClassPtr, 100664889);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00030244 File Offset: 0x0002E444
		public unsafe virtual int Priority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0003028C File Offset: 0x0002E48C
		[CallerCount(0)]
		public unsafe virtual bool HandleDrag(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000302E4 File Offset: 0x0002E4E4
		[CallerCount(0)]
		public unsafe virtual bool HandleEnvironmentDrag(Transform hitTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hitTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003033C File Offset: 0x0002E53C
		[CallerCount(0)]
		public unsafe virtual void StartDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00030388 File Offset: 0x0002E588
		[CallerCount(0)]
		public unsafe virtual void OnDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000303D4 File Offset: 0x0002E5D4
		[CallerCount(0)]
		public unsafe virtual void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenDragHandler.NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000066B8 File Offset: 0x000048B8
		public IZenDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_HandleDrag_Public_Abstract_Virtual_New_Boolean_UnitView_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Abstract_Virtual_New_Boolean_Transform_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Public_Abstract_Virtual_New_Void_0;
	}
}
