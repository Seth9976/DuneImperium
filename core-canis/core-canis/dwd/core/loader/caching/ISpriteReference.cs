using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018A RID: 394
	public class ISpriteReference : Il2CppObjectBase
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x00009BA6 File Offset: 0x00007DA6
		// Note: this type is marked as 'beforefieldinit'.
		static ISpriteReference()
		{
			Il2CppClassPointerStore<ISpriteReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "ISpriteReference");
			ISpriteReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpriteReference>.NativeClassPtr, 100666710);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0006D834 File Offset: 0x0006BA34
		public unsafe virtual Sprite Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISpriteReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00009BD5 File Offset: 0x00007DD5
		public ISpriteReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Sprite_0;
	}
}
