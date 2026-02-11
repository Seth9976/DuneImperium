using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000E1 RID: 225
	public class IHasAbilities : Il2CppObjectBase
	{
		// Token: 0x06000A3D RID: 2621 RVA: 0x00044D90 File Offset: 0x00042F90
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAbilities()
		{
			Il2CppClassPointerStore<IHasAbilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAbilities");
			IHasAbilities.NativeMethodInfoPtr_get_BaseAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilities>.NativeClassPtr, 100665453);
			IHasAbilities.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Abstract_Virtual_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilities>.NativeClassPtr, 100665454);
			IHasAbilities.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilities>.NativeClassPtr, 100665455);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00044DF4 File Offset: 0x00042FF4
		public unsafe virtual IEnumerable<AbilityDefinition> BaseAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilities.NativeMethodInfoPtr_get_BaseAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_AbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00044E40 File Offset: 0x00043040
		public unsafe virtual Entity AbilitiesContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilities.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Abstract_Virtual_New_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00044E8C File Offset: 0x0004308C
		[CallerCount(0)]
		public unsafe virtual void SetSerializedChildAbilities(Entity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilities.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00005CE2 File Offset: 0x00003EE2
		public IHasAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_AbilityDefinition_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilitiesContainer_Public_Abstract_Virtual_New_get_Entity_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Abstract_Virtual_New_Void_Entity_0;
	}
}
