using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace dwd.core.session
{
	// Token: 0x020000F4 RID: 244
	public class IAccountSessionWriter : Il2CppObjectBase
	{
		// Token: 0x06000E70 RID: 3696 RVA: 0x00006E61 File Offset: 0x00005061
		// Note: this type is marked as 'beforefieldinit'.
		static IAccountSessionWriter()
		{
			Il2CppClassPointerStore<IAccountSessionWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session", "IAccountSessionWriter");
			IAccountSessionWriter.NativeMethodInfoPtr_WriteFromAccount_Public_Abstract_Virtual_New_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccountSessionWriter>.NativeClassPtr, 100665385);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0004CE24 File Offset: 0x0004B024
		[CallerCount(0)]
		public unsafe virtual void WriteFromAccount(Object message, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccountSessionWriter.NativeMethodInfoPtr_WriteFromAccount_Public_Abstract_Virtual_New_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00006E90 File Offset: 0x00005090
		public IAccountSessionWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_WriteFromAccount_Public_Abstract_Virtual_New_Void_Object_AccountID_0;
	}
}
