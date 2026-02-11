using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018B RID: 395
	public class ISceneReference : Il2CppObjectBase
	{
		// Token: 0x0600164D RID: 5709 RVA: 0x00009BDE File Offset: 0x00007DDE
		// Note: this type is marked as 'beforefieldinit'.
		static ISceneReference()
		{
			Il2CppClassPointerStore<ISceneReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "ISceneReference");
			ISceneReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneReference>.NativeClassPtr, 100666711);
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0006D880 File Offset: 0x0006BA80
		public unsafe virtual string Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00009C0D File Offset: 0x00007E0D
		public ISceneReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_String_0;
	}
}
