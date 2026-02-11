using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.camera
{
	// Token: 0x02000062 RID: 98
	public class ICameraBoundsProvider : Il2CppObjectBase
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x000039CE File Offset: 0x00001BCE
		// Note: this type is marked as 'beforefieldinit'.
		static ICameraBoundsProvider()
		{
			Il2CppClassPointerStore<ICameraBoundsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.camera", "ICameraBoundsProvider");
			ICameraBoundsProvider.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Nullable_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraBoundsProvider>.NativeClassPtr, 100663874);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000294E4 File Offset: 0x000276E4
		public unsafe virtual Nullable<Bounds> Bounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICameraBoundsProvider.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Nullable_1_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Bounds>(intPtr);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000039FD File Offset: 0x00001BFD
		public ICameraBoundsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Nullable_1_Bounds_0;
	}
}
