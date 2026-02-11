using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000AD RID: 173
	public static class TypicalCharacterSets : Object
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x0002A680 File Offset: 0x00028880
		// Note: this type is marked as 'beforefieldinit'.
		static TypicalCharacterSets()
		{
			Il2CppClassPointerStore<TypicalCharacterSets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "TypicalCharacterSets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypicalCharacterSets>.NativeClassPtr);
			TypicalCharacterSets.NativeFieldInfoPtr_s_TypicalCharacterSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypicalCharacterSets>.NativeClassPtr, "s_TypicalCharacterSets");
			TypicalCharacterSets.NativeMethodInfoPtr_GetTypicalCharactersForLanguage_Public_Static_Il2CppStructArray_1_Char_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypicalCharacterSets>.NativeClassPtr, 100664826);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076974, XrefRangeEnd = 1076981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> GetTypicalCharactersForLanguage(SystemLanguage language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref language;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypicalCharacterSets.NativeMethodInfoPtr_GetTypicalCharactersForLanguage_Public_Static_Il2CppStructArray_1_Char_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00005447 File Offset: 0x00003647
		public TypicalCharacterSets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0002A718 File Offset: 0x00028918
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe static Dictionary<SystemLanguage, Il2CppStructArray<char>> s_TypicalCharacterSets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypicalCharacterSets.NativeFieldInfoPtr_s_TypicalCharacterSets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SystemLanguage, Il2CppStructArray<char>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypicalCharacterSets.NativeFieldInfoPtr_s_TypicalCharacterSets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_s_TypicalCharacterSets;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_GetTypicalCharactersForLanguage_Public_Static_Il2CppStructArray_1_Char_SystemLanguage_0;
	}
}
