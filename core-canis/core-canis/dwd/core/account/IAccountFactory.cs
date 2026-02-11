using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account
{
	// Token: 0x0200021F RID: 543
	public class IAccountFactory : Il2CppObjectBase
	{
		// Token: 0x06001DB3 RID: 7603 RVA: 0x0000CA1E File Offset: 0x0000AC1E
		// Note: this type is marked as 'beforefieldinit'.
		static IAccountFactory()
		{
			Il2CppClassPointerStore<IAccountFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account", "IAccountFactory");
			IAccountFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_AccountComponent_SerializableAccount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccountFactory>.NativeClassPtr, 100668076);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00089354 File Offset: 0x00087554
		[CallerCount(0)]
		public unsafe virtual AccountComponent Create(SerializableAccount account)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccountFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_AccountComponent_SerializableAccount_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0000CA4D File Offset: 0x0000AC4D
		public IAccountFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_AccountComponent_SerializableAccount_0;
	}
}
