using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace canis.archetypes
{
	// Token: 0x02000011 RID: 17
	public class IHasArchetypes : Il2CppObjectBase
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000251E File Offset: 0x0000071E
		// Note: this type is marked as 'beforefieldinit'.
		static IHasArchetypes()
		{
			Il2CppClassPointerStore<IHasArchetypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "IHasArchetypes");
			IHasArchetypes.NativeMethodInfoPtr_get_SimpleArchetypes_Public_Abstract_Virtual_New_get_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasArchetypes>.NativeClassPtr, 100663358);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0001BC30 File Offset: 0x00019E30
		public unsafe virtual Archetypes SimpleArchetypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasArchetypes.NativeMethodInfoPtr_get_SimpleArchetypes_Public_Abstract_Virtual_New_get_Archetypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000254D File Offset: 0x0000074D
		public IHasArchetypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleArchetypes_Public_Abstract_Virtual_New_get_Archetypes_0;
	}
}
