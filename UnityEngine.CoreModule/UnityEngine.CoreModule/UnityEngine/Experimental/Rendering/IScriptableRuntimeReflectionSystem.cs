using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027F RID: 639
	public class IScriptableRuntimeReflectionSystem : Il2CppObjectBase
	{
		// Token: 0x06002B7A RID: 11130 RVA: 0x00010F63 File Offset: 0x0000F163
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptableRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "IScriptableRuntimeReflectionSystem");
			IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr, 100668634);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000AFF1C File Offset: 0x000AE11C
		[CallerCount(0)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00010F92 File Offset: 0x0000F192
		public IScriptableRuntimeReflectionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0;
	}
}
