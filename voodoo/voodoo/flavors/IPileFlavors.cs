using System;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace voodoo.flavors
{
	// Token: 0x0200003D RID: 61
	public class IPileFlavors : Il2CppObjectBase
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x0000405B File Offset: 0x0000225B
		// Note: this type is marked as 'beforefieldinit'.
		static IPileFlavors()
		{
			Il2CppClassPointerStore<IPileFlavors>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.flavors", "IPileFlavors");
			IPileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Abstract_Virtual_New_get_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPileFlavors>.NativeClassPtr, 100663744);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00015BAC File Offset: 0x00013DAC
		public unsafe virtual PrefabFlavorsMetaData Metadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Abstract_Virtual_New_get_PrefabFlavorsMetaData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PrefabFlavorsMetaData(intPtr);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000408A File Offset: 0x0000228A
		public IPileFlavors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_Abstract_Virtual_New_get_PrefabFlavorsMetaData_0;
	}
}
