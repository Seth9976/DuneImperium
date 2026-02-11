using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000066 RID: 102
	public class IDebugData : Il2CppObjectBase
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00004E66 File Offset: 0x00003066
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugData()
		{
			Il2CppClassPointerStore<IDebugData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IDebugData");
			IDebugData.NativeMethodInfoPtr_GetReset_Public_Abstract_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugData>.NativeClassPtr, 100664297);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000290C4 File Offset: 0x000272C4
		[CallerCount(0)]
		public unsafe virtual Action GetReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugData.NativeMethodInfoPtr_GetReset_Public_Abstract_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00004E95 File Offset: 0x00003095
		public IDebugData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_GetReset_Public_Abstract_Virtual_New_Action_0;
	}
}
