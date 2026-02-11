using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.camera
{
	// Token: 0x020002A0 RID: 672
	public class IStrategicViewCamera : Il2CppObjectBase
	{
		// Token: 0x06001FFF RID: 8191 RVA: 0x00010D2A File Offset: 0x0000EF2A
		// Note: this type is marked as 'beforefieldinit'.
		static IStrategicViewCamera()
		{
			Il2CppClassPointerStore<IStrategicViewCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "IStrategicViewCamera");
			IStrategicViewCamera.NativeMethodInfoPtr_get_ZoomPercent_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStrategicViewCamera>.NativeClassPtr, 100668612);
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x000882BC File Offset: 0x000864BC
		public unsafe virtual float ZoomPercent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStrategicViewCamera.NativeMethodInfoPtr_get_ZoomPercent_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00010D59 File Offset: 0x0000EF59
		public IStrategicViewCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomPercent_Public_Abstract_Virtual_New_get_Single_0;
	}
}
