using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x0200000C RID: 12
	public class ILinkProvider : Il2CppObjectBase
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000486C File Offset: 0x00002A6C
		// Note: this type is marked as 'beforefieldinit'.
		static ILinkProvider()
		{
			Il2CppClassPointerStore<ILinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "ILinkProvider");
			ILinkProvider.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILinkProvider>.NativeClassPtr, 100663404);
			ILinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILinkProvider>.NativeClassPtr, 100663405);
			ILinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILinkProvider>.NativeClassPtr, 100663406);
			ILinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILinkProvider>.NativeClassPtr, 100663407);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000048E4 File Offset: 0x00002AE4
		[CallerCount(0)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILinkProvider.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000492C File Offset: 0x00002B2C
		[CallerCount(0)]
		public unsafe virtual void add_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000497C File Offset: 0x00002B7C
		[CallerCount(0)]
		public unsafe virtual void remove_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000049CC File Offset: 0x00002BCC
		[CallerCount(0)]
		public unsafe virtual void PollInfoAfterPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000233E File Offset: 0x0000053E
		public ILinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0;
	}
}
