using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x02000137 RID: 311
	public class IDraggable : Il2CppObjectBase
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x0004A43C File Offset: 0x0004863C
		// Note: this type is marked as 'beforefieldinit'.
		static IDraggable()
		{
			Il2CppClassPointerStore<IDraggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "IDraggable");
			IDraggable.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDraggable>.NativeClassPtr, 100665344);
			IDraggable.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Boolean_Camera_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDraggable>.NativeClassPtr, 100665345);
			IDraggable.NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDraggable>.NativeClassPtr, 100665346);
			IDraggable.NativeMethodInfoPtr_StopDrag_Public_Abstract_Virtual_New_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDraggable>.NativeClassPtr, 100665347);
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0004A4B4 File Offset: 0x000486B4
		public unsafe virtual bool AllowSelectOnClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDraggable.NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0004A4FC File Offset: 0x000486FC
		[CallerCount(0)]
		public unsafe virtual bool StartDrag(Camera camera, PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDraggable.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Boolean_Camera_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0004A568 File Offset: 0x00048768
		[CallerCount(0)]
		public unsafe virtual bool UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDraggable.NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Boolean_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0004A5C0 File Offset: 0x000487C0
		[CallerCount(0)]
		public unsafe virtual IEnumerator StopDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDraggable.NativeMethodInfoPtr_StopDrag_Public_Abstract_Virtual_New_IEnumerator_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00008CE6 File Offset: 0x00006EE6
		public IDraggable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowSelectOnClick_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Boolean_Camera_PointerEventData_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Boolean_PointerEventData_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Public_Abstract_Virtual_New_IEnumerator_PointerEventData_0;
	}
}
