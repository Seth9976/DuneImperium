using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000008 RID: 8
	public class IUserProfile : Il2CppObjectBase
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002237 File Offset: 0x00000437
		// Note: this type is marked as 'beforefieldinit'.
		static IUserProfile()
		{
			Il2CppClassPointerStore<IUserProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms", "IUserProfile");
			IUserProfile.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserProfile>.NativeClassPtr, 100663312);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003338 File Offset: 0x00001538
		public unsafe virtual string id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserProfile.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002266 File Offset: 0x00000466
		public IUserProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0;
	}
}
