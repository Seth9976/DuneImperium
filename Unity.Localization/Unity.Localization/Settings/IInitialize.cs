using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000096 RID: 150
	public class IInitialize : Il2CppObjectBase
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00004D21 File Offset: 0x00002F21
		// Note: this type is marked as 'beforefieldinit'.
		static IInitialize()
		{
			Il2CppClassPointerStore<IInitialize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "IInitialize");
			IInitialize.NativeMethodInfoPtr_PostInitialization_Public_Abstract_Virtual_New_Void_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitialize>.NativeClassPtr, 100664620);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00025B14 File Offset: 0x00023D14
		[CallerCount(0)]
		public unsafe virtual void PostInitialization(LocalizationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitialize.NativeMethodInfoPtr_PostInitialization_Public_Abstract_Virtual_New_Void_LocalizationSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004D50 File Offset: 0x00002F50
		public IInitialize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_PostInitialization_Public_Abstract_Virtual_New_Void_LocalizationSettings_0;
	}
}
