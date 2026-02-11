using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace lib.match
{
	// Token: 0x02000080 RID: 128
	public class IHasEntityComponent : Il2CppObjectBase
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x00005569 File Offset: 0x00003769
		// Note: this type is marked as 'beforefieldinit'.
		static IHasEntityComponent()
		{
			Il2CppClassPointerStore<IHasEntityComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "lib.match", "IHasEntityComponent");
			IHasEntityComponent.NativeMethodInfoPtr_EntityId_Public_Abstract_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasEntityComponent>.NativeClassPtr, 100664629);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000384FC File Offset: 0x000366FC
		[CallerCount(0)]
		public unsafe virtual EntityID EntityId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasEntityComponent.NativeMethodInfoPtr_EntityId_Public_Abstract_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00005598 File Offset: 0x00003798
		public IHasEntityComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_EntityId_Public_Abstract_Virtual_New_EntityID_0;
	}
}
