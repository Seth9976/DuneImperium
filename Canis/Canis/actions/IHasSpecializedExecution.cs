using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.actions
{
	// Token: 0x0200017F RID: 383
	public class IHasSpecializedExecution : Il2CppObjectBase
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x00008795 File Offset: 0x00006995
		// Note: this type is marked as 'beforefieldinit'.
		static IHasSpecializedExecution()
		{
			Il2CppClassPointerStore<IHasSpecializedExecution>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IHasSpecializedExecution");
			IHasSpecializedExecution.NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasSpecializedExecution>.NativeClassPtr, 100666815);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0005E1DC File Offset: 0x0005C3DC
		public unsafe virtual bool ShouldExecuteOnForcedEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasSpecializedExecution.NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000087C4 File Offset: 0x000069C4
		public IHasSpecializedExecution(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
