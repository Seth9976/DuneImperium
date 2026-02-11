using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000F5 RID: 245
	public static class IHasAbilityStateStackExtensions : Object
	{
		// Token: 0x06000AD2 RID: 2770 RVA: 0x00005EB4 File Offset: 0x000040B4
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAbilityStateStackExtensions()
		{
			Il2CppClassPointerStore<IHasAbilityStateStackExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAbilityStateStackExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IHasAbilityStateStackExtensions>.NativeClassPtr);
			IHasAbilityStateStackExtensions.NativeMethodInfoPtr_StackTrace_Public_Static_String_IEnumerable_1_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilityStateStackExtensions>.NativeClassPtr, 100665663);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00047BCC File Offset: 0x00045DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567929, XrefRangeEnd = 567938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StackTrace(this IEnumerable<ActiveAbility> abilityStack)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IHasAbilityStateStackExtensions.NativeMethodInfoPtr_StackTrace_Public_Static_String_IEnumerable_1_ActiveAbility_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00005EED File Offset: 0x000040ED
		public IHasAbilityStateStackExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_StackTrace_Public_Static_String_IEnumerable_1_ActiveAbility_0;
	}
}
