using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E3 RID: 483
	public class IUIElementsUtility : Il2CppObjectBase
	{
		// Token: 0x06002643 RID: 9795 RVA: 0x000AA564 File Offset: 0x000A8764
		// Note: this type is marked as 'beforefieldinit'.
		static IUIElementsUtility()
		{
			Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IUIElementsUtility");
			IUIElementsUtility.NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669096);
			IUIElementsUtility.NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669097);
			IUIElementsUtility.NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669098);
			IUIElementsUtility.NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669099);
			IUIElementsUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669100);
			IUIElementsUtility.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIElementsUtility>.NativeClassPtr, 100669101);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000AA604 File Offset: 0x000A8804
		[CallerCount(0)]
		public unsafe virtual bool TakeCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000AA64C File Offset: 0x000A884C
		[CallerCount(0)]
		public unsafe virtual bool ReleaseCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000AA694 File Offset: 0x000A8894
		[CallerCount(0)]
		public unsafe virtual bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000AA704 File Offset: 0x000A8904
		[CallerCount(0)]
		public unsafe virtual bool CleanupRoots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000AA74C File Offset: 0x000A894C
		[CallerCount(0)]
		public unsafe virtual bool EndContainerGUIFromException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000AA7A4 File Offset: 0x000A89A4
		[CallerCount(0)]
		public unsafe virtual bool MakeCurrentIMGUIContainerDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIElementsUtility.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0000F8E2 File Offset: 0x0000DAE2
		public IUIElementsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCapture_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Abstract_Virtual_New_Boolean_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Public_Abstract_Virtual_New_Boolean_Exception_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Public_Abstract_Virtual_New_Boolean_0;
	}
}
