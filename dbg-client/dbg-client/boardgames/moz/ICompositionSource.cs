using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.moz
{
	// Token: 0x02000115 RID: 277
	public class ICompositionSource : Il2CppObjectBase
	{
		// Token: 0x06000C85 RID: 3205 RVA: 0x000080EA File Offset: 0x000062EA
		// Note: this type is marked as 'beforefieldinit'.
		static ICompositionSource()
		{
			Il2CppClassPointerStore<ICompositionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "ICompositionSource");
			ICompositionSource.NativeMethodInfoPtr_GetComposition_Public_Abstract_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICompositionSource>.NativeClassPtr, 100665124);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000451E8 File Offset: 0x000433E8
		[CallerCount(0)]
		public unsafe virtual DataComposition GetComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICompositionSource.NativeMethodInfoPtr_GetComposition_Public_Abstract_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00008119 File Offset: 0x00006319
		public ICompositionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_GetComposition_Public_Abstract_Virtual_New_DataComposition_0;
	}
}
