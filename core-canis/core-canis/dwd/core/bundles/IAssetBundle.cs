using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.bundles
{
	// Token: 0x020001FF RID: 511
	public class IAssetBundle : Il2CppObjectBase
	{
		// Token: 0x06001C6D RID: 7277 RVA: 0x000841E8 File Offset: 0x000823E8
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetBundle()
		{
			Il2CppClassPointerStore<IAssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "IAssetBundle");
			IAssetBundle.NativeMethodInfoPtr_get_versionings_Public_Abstract_Virtual_New_get_IEnumerable_1_ListingPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundle>.NativeClassPtr, 100667819);
			IAssetBundle.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundle>.NativeClassPtr, 100667820);
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00084238 File Offset: 0x00082438
		public unsafe virtual IEnumerable<ListingPlatformVersioning> versionings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundle.NativeMethodInfoPtr_get_versionings_Public_Abstract_Virtual_New_get_IEnumerable_1_ListingPlatformVersioning_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ListingPlatformVersioning>>(intPtr3) : null;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00084284 File Offset: 0x00082484
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundle.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0000C3EA File Offset: 0x0000A5EA
		public IAssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_get_versionings_Public_Abstract_Virtual_New_get_IEnumerable_1_ListingPlatformVersioning_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
