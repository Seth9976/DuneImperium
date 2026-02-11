using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B2 RID: 434
	public class ICredentials : Il2CppObjectBase
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x0000B871 File Offset: 0x00009A71
		// Note: this type is marked as 'beforefieldinit'.
		static ICredentials()
		{
			Il2CppClassPointerStore<ICredentials>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICredentials");
			ICredentials.NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICredentials>.NativeClassPtr, 100667476);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00085BC0 File Offset: 0x00083DC0
		[CallerCount(0)]
		public unsafe virtual NetworkCredential GetCredential(Uri uri, string authType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICredentials.NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		public ICredentials(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0;
	}
}
