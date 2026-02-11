using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.interfaces
{
	// Token: 0x020000AA RID: 170
	public class IEntityViewDataProvider : Il2CppObjectBase
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x00006B11 File Offset: 0x00004D11
		// Note: this type is marked as 'beforefieldinit'.
		static IEntityViewDataProvider()
		{
			Il2CppClassPointerStore<IEntityViewDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.interfaces", "IEntityViewDataProvider");
			IEntityViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityViewDataProvider>.NativeClassPtr, 100664694);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00029B90 File Offset: 0x00027D90
		[CallerCount(0)]
		public unsafe virtual EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00006B40 File Offset: 0x00004D40
		public IEntityViewDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_EntityComponent_EntityInitializationContext_0;
	}
}
