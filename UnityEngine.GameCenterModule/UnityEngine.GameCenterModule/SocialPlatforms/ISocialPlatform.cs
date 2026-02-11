using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000005 RID: 5
	public class ISocialPlatform : Il2CppObjectBase
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003194 File Offset: 0x00001394
		// Note: this type is marked as 'beforefieldinit'.
		static ISocialPlatform()
		{
			Il2CppClassPointerStore<ISocialPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms", "ISocialPlatform");
			ISocialPlatform.NativeMethodInfoPtr_get_localUser_Public_Abstract_Virtual_New_get_ILocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocialPlatform>.NativeClassPtr, 100663308);
			ISocialPlatform.NativeMethodInfoPtr_ReportProgress_Public_Abstract_Virtual_New_Void_String_Double_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocialPlatform>.NativeClassPtr, 100663309);
			ISocialPlatform.NativeMethodInfoPtr_ShowAchievementsUI_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocialPlatform>.NativeClassPtr, 100663310);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000031F8 File Offset: 0x000013F8
		public unsafe virtual ILocalUser localUser
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocialPlatform.NativeMethodInfoPtr_get_localUser_Public_Abstract_Virtual_New_get_ILocalUser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalUser>(intPtr3) : null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003244 File Offset: 0x00001444
		[CallerCount(0)]
		public unsafe virtual void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocialPlatform.NativeMethodInfoPtr_ReportProgress_Public_Abstract_Virtual_New_Void_String_Double_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000032B4 File Offset: 0x000014B4
		[CallerCount(0)]
		public unsafe virtual void ShowAchievementsUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocialPlatform.NativeMethodInfoPtr_ShowAchievementsUI_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021F6 File Offset: 0x000003F6
		public ISocialPlatform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_localUser_Public_Abstract_Virtual_New_get_ILocalUser_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Abstract_Virtual_New_Void_String_Double_Action_1_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementsUI_Public_Abstract_Virtual_New_Void_0;
	}
}
