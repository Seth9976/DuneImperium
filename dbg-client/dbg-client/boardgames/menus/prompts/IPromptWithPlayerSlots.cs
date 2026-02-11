using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F4 RID: 500
	public class IPromptWithPlayerSlots : Il2CppObjectBase
	{
		// Token: 0x0600174E RID: 5966 RVA: 0x0000D016 File Offset: 0x0000B216
		// Note: this type is marked as 'beforefieldinit'.
		static IPromptWithPlayerSlots()
		{
			Il2CppClassPointerStore<IPromptWithPlayerSlots>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "IPromptWithPlayerSlots");
			IPromptWithPlayerSlots.NativeMethodInfoPtr_get_PlayerSlots_Public_Abstract_Virtual_New_get_IReadOnlyList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPromptWithPlayerSlots>.NativeClassPtr, 100666712);
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x00069450 File Offset: 0x00067650
		public unsafe virtual IReadOnlyList<DataComposition> PlayerSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPromptWithPlayerSlots.NativeMethodInfoPtr_get_PlayerSlots_Public_Abstract_Virtual_New_get_IReadOnlyList_1_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0000D045 File Offset: 0x0000B245
		public IPromptWithPlayerSlots(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerSlots_Public_Abstract_Virtual_New_get_IReadOnlyList_1_DataComposition_0;
	}
}
