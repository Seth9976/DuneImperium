using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.selection
{
	// Token: 0x02000136 RID: 310
	public class IForced : Il2CppObjectBase
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00008112 File Offset: 0x00006312
		// Note: this type is marked as 'beforefieldinit'.
		static IForced()
		{
			Il2CppClassPointerStore<IForced>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IForced");
			IForced.NativeMethodInfoPtr_get_Forced_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IForced>.NativeClassPtr, 100665866);
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00059928 File Offset: 0x00057B28
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IForced.NativeMethodInfoPtr_get_Forced_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00008141 File Offset: 0x00006341
		public IForced(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
