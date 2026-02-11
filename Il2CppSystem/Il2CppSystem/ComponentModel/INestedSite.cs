using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000113 RID: 275
	public class INestedSite : Il2CppObjectBase
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x000080BF File Offset: 0x000062BF
		// Note: this type is marked as 'beforefieldinit'.
		static INestedSite()
		{
			Il2CppClassPointerStore<INestedSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "INestedSite");
			INestedSite.NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INestedSite>.NativeClassPtr, 100665790);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0005D6B4 File Offset: 0x0005B8B4
		public unsafe virtual string FullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INestedSite.NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x000080EE File Offset: 0x000062EE
		public INestedSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0;
	}
}
