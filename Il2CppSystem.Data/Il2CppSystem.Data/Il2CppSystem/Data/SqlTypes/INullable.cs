using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200008B RID: 139
	public class INullable : Il2CppObjectBase
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x000063CF File Offset: 0x000045CF
		// Note: this type is marked as 'beforefieldinit'.
		static INullable()
		{
			Il2CppClassPointerStore<INullable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "INullable");
			INullable.NativeMethodInfoPtr_get_IsNull_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INullable>.NativeClassPtr, 100665502);
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00043684 File Offset: 0x00041884
		public unsafe virtual bool IsNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INullable.NativeMethodInfoPtr_get_IsNull_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000063FE File Offset: 0x000045FE
		public INullable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
