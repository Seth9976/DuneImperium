using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000097 RID: 151
	public class ILocalesProvider : Il2CppObjectBase
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00025B64 File Offset: 0x00023D64
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalesProvider()
		{
			Il2CppClassPointerStore<ILocalesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "ILocalesProvider");
			ILocalesProvider.NativeMethodInfoPtr_get_Locales_Public_Abstract_Virtual_New_get_List_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalesProvider>.NativeClassPtr, 100664621);
			ILocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Abstract_Virtual_New_Locale_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalesProvider>.NativeClassPtr, 100664622);
			ILocalesProvider.NativeMethodInfoPtr_AddLocale_Public_Abstract_Virtual_New_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalesProvider>.NativeClassPtr, 100664623);
			ILocalesProvider.NativeMethodInfoPtr_RemoveLocale_Public_Abstract_Virtual_New_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalesProvider>.NativeClassPtr, 100664624);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00025BDC File Offset: 0x00023DDC
		public unsafe virtual List<Locale> Locales
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalesProvider.NativeMethodInfoPtr_get_Locales_Public_Abstract_Virtual_New_get_List_1_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Locale>>(intPtr3) : null;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00025C28 File Offset: 0x00023E28
		[CallerCount(0)]
		public unsafe virtual Locale GetLocale(LocaleIdentifier id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalesProvider.NativeMethodInfoPtr_GetLocale_Public_Abstract_Virtual_New_Locale_LocaleIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00025C88 File Offset: 0x00023E88
		[CallerCount(0)]
		public unsafe virtual void AddLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalesProvider.NativeMethodInfoPtr_AddLocale_Public_Abstract_Virtual_New_Void_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00025CD8 File Offset: 0x00023ED8
		[CallerCount(0)]
		public unsafe virtual bool RemoveLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalesProvider.NativeMethodInfoPtr_RemoveLocale_Public_Abstract_Virtual_New_Boolean_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00004D59 File Offset: 0x00002F59
		public ILocalesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_get_Locales_Public_Abstract_Virtual_New_get_List_1_Locale_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_GetLocale_Public_Abstract_Virtual_New_Locale_LocaleIdentifier_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_AddLocale_Public_Abstract_Virtual_New_Void_Locale_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocale_Public_Abstract_Virtual_New_Boolean_Locale_0;
	}
}
