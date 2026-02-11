using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace InControl
{
	// Token: 0x02000042 RID: 66
	public class IKeyboardProvider : Il2CppObjectBase
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x0001E870 File Offset: 0x0001CA70
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyboardProvider()
		{
			Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "IKeyboardProvider");
			IKeyboardProvider.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664151);
			IKeyboardProvider.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664152);
			IKeyboardProvider.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664153);
			IKeyboardProvider.NativeMethodInfoPtr_AnyKeyIsPressed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664154);
			IKeyboardProvider.NativeMethodInfoPtr_GetKeyIsPressed_Public_Abstract_Virtual_New_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664155);
			IKeyboardProvider.NativeMethodInfoPtr_GetNameForKey_Public_Abstract_Virtual_New_String_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardProvider>.NativeClassPtr, 100664156);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001E910 File Offset: 0x0001CB10
		[CallerCount(0)]
		public unsafe virtual void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001E94C File Offset: 0x0001CB4C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001E988 File Offset: 0x0001CB88
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
		[CallerCount(0)]
		public unsafe virtual bool AnyKeyIsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_AnyKeyIsPressed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		[CallerCount(0)]
		public unsafe virtual bool GetKeyIsPressed(Key control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_GetKeyIsPressed_Public_Abstract_Virtual_New_Boolean_Key_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001EA60 File Offset: 0x0001CC60
		[CallerCount(0)]
		public unsafe virtual string GetNameForKey(Key control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardProvider.NativeMethodInfoPtr_GetNameForKey_Public_Abstract_Virtual_New_String_Key_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000464B File Offset: 0x0000284B
		public IKeyboardProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_AnyKeyIsPressed_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyIsPressed_Public_Abstract_Virtual_New_Boolean_Key_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_GetNameForKey_Public_Abstract_Virtual_New_String_Key_0;
	}
}
