using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000086 RID: 134
	public class IIncludeSentToPlayer : Il2CppObjectBase
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00012038 File Offset: 0x00010238
		// Note: this type is marked as 'beforefieldinit'.
		static IIncludeSentToPlayer()
		{
			Il2CppClassPointerStore<IIncludeSentToPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "IIncludeSentToPlayer");
			IIncludeSentToPlayer.NativeMethodInfoPtr_get_PlayerAccountID_Public_Abstract_Virtual_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIncludeSentToPlayer>.NativeClassPtr, 100663590);
			IIncludeSentToPlayer.NativeMethodInfoPtr_set_PlayerAccountID_Public_Abstract_Virtual_New_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIncludeSentToPlayer>.NativeClassPtr, 100663591);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00012088 File Offset: 0x00010288
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000120D4 File Offset: 0x000102D4
		public unsafe virtual AccountID PlayerAccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIncludeSentToPlayer.NativeMethodInfoPtr_get_PlayerAccountID_Public_Abstract_Virtual_New_get_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIncludeSentToPlayer.NativeMethodInfoPtr_set_PlayerAccountID_Public_Abstract_Virtual_New_set_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00004CDB File Offset: 0x00002EDB
		public IIncludeSentToPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAccountID_Public_Abstract_Virtual_New_get_AccountID_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerAccountID_Public_Abstract_Virtual_New_set_Void_AccountID_0;
	}
}
