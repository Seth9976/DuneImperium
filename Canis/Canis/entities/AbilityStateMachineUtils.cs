using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000C7 RID: 199
	public static class AbilityStateMachineUtils : Object
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x0000579D File Offset: 0x0000399D
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateMachineUtils()
		{
			Il2CppClassPointerStore<AbilityStateMachineUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateMachineUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineUtils>.NativeClassPtr);
			AbilityStateMachineUtils.NativeMethodInfoPtr_GetStateName_Public_Static_String_IAbilityStateMachineDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineUtils>.NativeClassPtr, 100665193);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0003F1D0 File Offset: 0x0003D3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 562049, RefRangeEnd = 562050, XrefRangeStart = 562036, XrefRangeEnd = 562049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStateName(this IAbilityStateMachineDefinition abilityStateMachine, int state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityStateMachine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineUtils.NativeMethodInfoPtr_GetStateName_Public_Static_String_IAbilityStateMachineDefinition_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000057D6 File Offset: 0x000039D6
		public AbilityStateMachineUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_GetStateName_Public_Static_String_IAbilityStateMachineDefinition_Int32_0;
	}
}
