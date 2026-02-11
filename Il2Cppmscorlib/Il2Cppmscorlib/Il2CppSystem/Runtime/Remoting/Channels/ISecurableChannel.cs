using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002D2 RID: 722
	public class ISecurableChannel : Il2CppObjectBase
	{
		// Token: 0x06002D4A RID: 11594 RVA: 0x0000F34F File Offset: 0x0000D54F
		// Note: this type is marked as 'beforefieldinit'.
		static ISecurableChannel()
		{
			Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ISecurableChannel");
			ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr, 100670572);
		}

		// Token: 0x170009A6 RID: 2470
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x000EC200 File Offset: 0x000EA400
		public unsafe virtual bool IsSecured
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x0000F37E File Offset: 0x0000D57E
		public ISecurableChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
