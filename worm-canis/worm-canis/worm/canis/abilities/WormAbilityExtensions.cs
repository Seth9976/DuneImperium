using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace worm.canis.abilities
{
	// Token: 0x0200031B RID: 795
	public static class WormAbilityExtensions : Object
	{
		// Token: 0x06002074 RID: 8308 RVA: 0x000D84CC File Offset: 0x000D66CC
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityExtensions()
		{
			Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities", "WormAbilityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr);
			WormAbilityExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityType_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr, 100671236);
			WormAbilityExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_WormMatch_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr, 100671237);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000D8524 File Offset: 0x000D6724
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 175986, RefRangeEnd = 176014, XrefRangeStart = 175984, XrefRangeEnd = 175986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AbilityType> GetAbilities<AbilityType>(this IHasAbilities<WormMatch, WormAbilityDefinition> hasAbilities) where AbilityType : WormAbilityDefinition
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityExtensions.MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_AbilityType_IHasAbilities_2_WormMatch_WormAbilityDefinition_0<AbilityType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityType>>(intPtr3) : null;
			}
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000D8568 File Offset: 0x000D6768
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 175986, RefRangeEnd = 176014, XrefRangeStart = 175986, XrefRangeEnd = 176014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TAbilityType> GetAbilities<TAbilityType>(this IHasAbilities<WormMatch, AbilityDefinitionForGame<WormMatch>> hasAbilities) where TAbilityType : AbilityDefinitionForGame<WormMatch>
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityExtensions.MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_WormMatch_AbilityDefinitionForGame_1_WormMatch_0<TAbilityType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityType>>(intPtr3) : null;
			}
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x0000D65D File Offset: 0x0000B85D
		public WormAbilityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityType_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_WormMatch_AbilityDefinitionForGame_1_WormMatch_0;

		// Token: 0x020007D8 RID: 2008
		private sealed class MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_AbilityType_IHasAbilities_2_WormMatch_WormAbilityDefinition_0<AbilityType>
		{
			// Token: 0x04004971 RID: 18801
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormAbilityExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityType_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbilityType>.NativeClassPtr)) }))));
		}

		// Token: 0x020007D9 RID: 2009
		private sealed class MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_WormMatch_AbilityDefinitionForGame_1_WormMatch_0<TAbilityType>
		{
			// Token: 0x04004972 RID: 18802
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormAbilityExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_WormMatch_AbilityDefinitionForGame_1_WormMatch_0, Il2CppClassPointerStore<WormAbilityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr)) }))));
		}
	}
}
