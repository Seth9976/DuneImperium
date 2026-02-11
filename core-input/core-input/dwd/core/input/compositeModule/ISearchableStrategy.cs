using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008E RID: 142
	public class ISearchableStrategy : Il2CppObjectBase
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x0000557E File Offset: 0x0000377E
		// Note: this type is marked as 'beforefieldinit'.
		static ISearchableStrategy()
		{
			Il2CppClassPointerStore<ISearchableStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "ISearchableStrategy");
			ISearchableStrategy.NativeMethodInfoPtr_get_StrategyName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISearchableStrategy>.NativeClassPtr, 100664057);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001A58C File Offset: 0x0001878C
		public unsafe virtual string StrategyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISearchableStrategy.NativeMethodInfoPtr_get_StrategyName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000055AD File Offset: 0x000037AD
		public ISearchableStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyName_Public_Abstract_Virtual_New_get_String_0;
	}
}
