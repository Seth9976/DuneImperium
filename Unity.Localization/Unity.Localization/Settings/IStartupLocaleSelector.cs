using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000099 RID: 153
	public class IStartupLocaleSelector : Il2CppObjectBase
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00004D9A File Offset: 0x00002F9A
		// Note: this type is marked as 'beforefieldinit'.
		static IStartupLocaleSelector()
		{
			Il2CppClassPointerStore<IStartupLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "IStartupLocaleSelector");
			IStartupLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Abstract_Virtual_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStartupLocaleSelector>.NativeClassPtr, 100664626);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00025D6C File Offset: 0x00023F6C
		[CallerCount(0)]
		public unsafe virtual Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStartupLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Abstract_Virtual_New_Locale_ILocalesProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00004DC9 File Offset: 0x00002FC9
		public IStartupLocaleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Abstract_Virtual_New_Locale_ILocalesProvider_0;
	}
}
