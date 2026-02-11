using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core
{
	// Token: 0x02000084 RID: 132
	public class IEntitiesProvider : Il2CppObjectBase
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x0003918C File Offset: 0x0003738C
		// Note: this type is marked as 'beforefieldinit'.
		static IEntitiesProvider()
		{
			Il2CppClassPointerStore<IEntitiesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core", "IEntitiesProvider");
			IEntitiesProvider.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntitiesProvider>.NativeClassPtr, 100664664);
			IEntitiesProvider.NativeMethodInfoPtr_get_Entities_Public_Abstract_Virtual_New_get_Entities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntitiesProvider>.NativeClassPtr, 100664665);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000391DC File Offset: 0x000373DC
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntitiesProvider.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00039224 File Offset: 0x00037424
		public unsafe virtual Entities Entities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntitiesProvider.NativeMethodInfoPtr_get_Entities_Public_Abstract_Virtual_New_get_Entities_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr3) : null;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0000574E File Offset: 0x0000394E
		public IEntitiesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Public_Abstract_Virtual_New_get_Entities_0;
	}
}
