using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x02000282 RID: 642
	public class IIdentity : Il2CppObjectBase
	{
		// Token: 0x06002965 RID: 10597 RVA: 0x000DDB94 File Offset: 0x000DBD94
		// Note: this type is marked as 'beforefieldinit'.
		static IIdentity()
		{
			Il2CppClassPointerStore<IIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "IIdentity");
			IIdentity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIdentity>.NativeClassPtr, 100670071);
			IIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIdentity>.NativeClassPtr, 100670072);
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000DDBE4 File Offset: 0x000DBDE4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIdentity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x000DDC28 File Offset: 0x000DBE28
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0000DA7F File Offset: 0x0000BC7F
		public IIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;
	}
}
