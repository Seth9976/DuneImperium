using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002FA RID: 762
	public class IInternalMessage : Il2CppObjectBase
	{
		// Token: 0x06002F0E RID: 12046 RVA: 0x000F22AC File Offset: 0x000F04AC
		// Note: this type is marked as 'beforefieldinit'.
		static IInternalMessage()
		{
			Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IInternalMessage");
			IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100670765);
			IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100670766);
			IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100670767);
			IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100670768);
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000F2324 File Offset: 0x000F0524
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x000F2370 File Offset: 0x000F0570
		public unsafe virtual Identity TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000F23C0 File Offset: 0x000F05C0
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x000F2404 File Offset: 0x000F0604
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x0001003D File Offset: 0x0000E23D
		public IInternalMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
