using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C1 RID: 705
	public class IContributeDynamicSink : Il2CppObjectBase
	{
		// Token: 0x06002CDB RID: 11483 RVA: 0x0000F010 File Offset: 0x0000D210
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeDynamicSink()
		{
			Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeDynamicSink");
			IContributeDynamicSink.NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr, 100670520);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000EAAA8 File Offset: 0x000E8CA8
		[CallerCount(0)]
		public unsafe virtual IDynamicMessageSink GetDynamicSink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeDynamicSink.NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0000F03F File Offset: 0x0000D23F
		public IContributeDynamicSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0;
	}
}
