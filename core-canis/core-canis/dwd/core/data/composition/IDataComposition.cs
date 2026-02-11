using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001DF RID: 479
	public class IDataComposition : Il2CppObjectBase
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x0000B6CC File Offset: 0x000098CC
		// Note: this type is marked as 'beforefieldinit'.
		static IDataComposition()
		{
			Il2CppClassPointerStore<IDataComposition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "IDataComposition");
			IDataComposition.NativeMethodInfoPtr_get_Composition_Public_Abstract_Virtual_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataComposition>.NativeClassPtr, 100667491);
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0007D480 File Offset: 0x0007B680
		public unsafe virtual DataComposition Composition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataComposition.NativeMethodInfoPtr_get_Composition_Public_Abstract_Virtual_New_get_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000B6FB File Offset: 0x000098FB
		public IDataComposition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_get_Composition_Public_Abstract_Virtual_New_get_DataComposition_0;
	}
}
