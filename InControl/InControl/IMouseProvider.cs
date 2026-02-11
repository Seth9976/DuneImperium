using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000044 RID: 68
	public class IMouseProvider : Il2CppObjectBase
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x0001ED4C File Offset: 0x0001CF4C
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseProvider()
		{
			Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "IMouseProvider");
			IMouseProvider.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664171);
			IMouseProvider.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664172);
			IMouseProvider.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664173);
			IMouseProvider.NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664174);
			IMouseProvider.NativeMethodInfoPtr_GetDeltaX_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664175);
			IMouseProvider.NativeMethodInfoPtr_GetDeltaY_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664176);
			IMouseProvider.NativeMethodInfoPtr_GetDeltaScroll_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664177);
			IMouseProvider.NativeMethodInfoPtr_GetButtonIsPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664178);
			IMouseProvider.NativeMethodInfoPtr_GetButtonWasPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664179);
			IMouseProvider.NativeMethodInfoPtr_GetButtonWasReleased_Public_Abstract_Virtual_New_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664180);
			IMouseProvider.NativeMethodInfoPtr_HasMousePresent_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseProvider>.NativeClassPtr, 100664181);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001EE50 File Offset: 0x0001D050
		[CallerCount(0)]
		public unsafe virtual void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001EE8C File Offset: 0x0001D08C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001EF04 File Offset: 0x0001D104
		[CallerCount(0)]
		public unsafe virtual Vector2 GetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001EF4C File Offset: 0x0001D14C
		[CallerCount(0)]
		public unsafe virtual float GetDeltaX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetDeltaX_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001EF94 File Offset: 0x0001D194
		[CallerCount(0)]
		public unsafe virtual float GetDeltaY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetDeltaY_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001EFDC File Offset: 0x0001D1DC
		[CallerCount(0)]
		public unsafe virtual float GetDeltaScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetDeltaScroll_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0001F024 File Offset: 0x0001D224
		[CallerCount(0)]
		public unsafe virtual bool GetButtonIsPressed(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetButtonIsPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001F078 File Offset: 0x0001D278
		[CallerCount(0)]
		public unsafe virtual bool GetButtonWasPressed(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetButtonWasPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001F0CC File Offset: 0x0001D2CC
		[CallerCount(0)]
		public unsafe virtual bool GetButtonWasReleased(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_GetButtonWasReleased_Public_Abstract_Virtual_New_Boolean_Mouse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001F120 File Offset: 0x0001D320
		[CallerCount(0)]
		public unsafe virtual bool HasMousePresent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseProvider.NativeMethodInfoPtr_HasMousePresent_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000466F File Offset: 0x0000286F
		public IMouseProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaX_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaY_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaScroll_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIsPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonWasPressed_Public_Abstract_Virtual_New_Boolean_Mouse_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonWasReleased_Public_Abstract_Virtual_New_Boolean_Mouse_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_HasMousePresent_Public_Abstract_Virtual_New_Boolean_0;
	}
}
