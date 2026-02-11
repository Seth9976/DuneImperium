using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000006 RID: 6
	public class ILocalUser : Il2CppObjectBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000021FF File Offset: 0x000003FF
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalUser()
		{
			Il2CppClassPointerStore<ILocalUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms", "ILocalUser");
			ILocalUser.NativeMethodInfoPtr_get_authenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalUser>.NativeClassPtr, 100663311);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000032F0 File Offset: 0x000014F0
		public unsafe virtual bool authenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalUser.NativeMethodInfoPtr_get_authenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000222E File Offset: 0x0000042E
		public ILocalUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_authenticated_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
