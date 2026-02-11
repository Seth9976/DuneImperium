using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.dataProviders
{
	// Token: 0x02000033 RID: 51
	public class IAdditionalEntityProvider : Il2CppObjectBase
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00002CC1 File Offset: 0x00000EC1
		// Note: this type is marked as 'beforefieldinit'.
		static IAdditionalEntityProvider()
		{
			Il2CppClassPointerStore<IAdditionalEntityProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataProviders", "IAdditionalEntityProvider");
			IAdditionalEntityProvider.NativeMethodInfoPtr_AppendAdditionalEntityComponents_Public_Abstract_Virtual_New_List_1_EntityComponent_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAdditionalEntityProvider>.NativeClassPtr, 100663604);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000238DC File Offset: 0x00021ADC
		[CallerCount(0)]
		public unsafe virtual List<EntityComponent> AppendAdditionalEntityComponents(List<EntityComponent> includedEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(includedEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAdditionalEntityProvider.NativeMethodInfoPtr_AppendAdditionalEntityComponents_Public_Abstract_Virtual_New_List_1_EntityComponent_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public IAdditionalEntityProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_AppendAdditionalEntityComponents_Public_Abstract_Virtual_New_List_1_EntityComponent_List_1_EntityComponent_0;
	}
}
