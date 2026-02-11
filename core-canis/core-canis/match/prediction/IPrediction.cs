using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace match.prediction
{
	// Token: 0x0200007E RID: 126
	public class IPrediction : Il2CppObjectBase
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x00038084 File Offset: 0x00036284
		// Note: this type is marked as 'beforefieldinit'.
		static IPrediction()
		{
			Il2CppClassPointerStore<IPrediction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "match.prediction", "IPrediction");
			IPrediction.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrediction>.NativeClassPtr, 100664607);
			IPrediction.NativeMethodInfoPtr_GetRewindCommand_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrediction>.NativeClassPtr, 100664608);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x000380D4 File Offset: 0x000362D4
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrediction.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0003811C File Offset: 0x0003631C
		[CallerCount(0)]
		public unsafe virtual Command GetRewindCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrediction.NativeMethodInfoPtr_GetRewindCommand_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000054FE File Offset: 0x000036FE
		public IPrediction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_GetRewindCommand_Public_Abstract_Virtual_New_Command_0;
	}
}
