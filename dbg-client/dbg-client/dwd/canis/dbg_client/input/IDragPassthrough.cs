using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.EventSystems;

namespace dwd.canis.dbg_client.input
{
	// Token: 0x02000073 RID: 115
	public class IDragPassthrough : Il2CppObjectBase
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x0002AEF8 File Offset: 0x000290F8
		// Note: this type is marked as 'beforefieldinit'.
		static IDragPassthrough()
		{
			Il2CppClassPointerStore<IDragPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.input", "IDragPassthrough");
			IDragPassthrough.NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragPassthrough>.NativeClassPtr, 100663932);
			IDragPassthrough.NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragPassthrough>.NativeClassPtr, 100663933);
			IDragPassthrough.NativeMethodInfoPtr_OnEndDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragPassthrough>.NativeClassPtr, 100663934);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0002AF5C File Offset: 0x0002915C
		[CallerCount(0)]
		public unsafe virtual void OnBeginDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragPassthrough.NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0002AFAC File Offset: 0x000291AC
		[CallerCount(0)]
		public unsafe virtual void OnUpdateDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragPassthrough.NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0002AFFC File Offset: 0x000291FC
		[CallerCount(0)]
		public unsafe virtual void OnEndDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragPassthrough.NativeMethodInfoPtr_OnEndDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003F4A File Offset: 0x0000214A
		public IDragPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDragPassthrough_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
