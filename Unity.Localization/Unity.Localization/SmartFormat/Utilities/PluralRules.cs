using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x0200003D RID: 61
	public static class PluralRules : Object
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00017F60 File Offset: 0x00016160
		// Note: this type is marked as 'beforefieldinit'.
		static PluralRules()
		{
			Il2CppClassPointerStore<PluralRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "PluralRules");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluralRules>.NativeClassPtr);
			PluralRules.NativeFieldInfoPtr_IsoLangToDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, "IsoLangToDelegate");
			PluralRules.NativeMethodInfoPtr_get_Singular_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663987);
			PluralRules.NativeMethodInfoPtr_get_DualOneOther_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663988);
			PluralRules.NativeMethodInfoPtr_get_DualWithZero_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663989);
			PluralRules.NativeMethodInfoPtr_get_DualFromZeroToTwo_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663990);
			PluralRules.NativeMethodInfoPtr_get_TripleOneTwoOther_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663991);
			PluralRules.NativeMethodInfoPtr_get_RussianSerboCroatian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663992);
			PluralRules.NativeMethodInfoPtr_get_Arabic_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663993);
			PluralRules.NativeMethodInfoPtr_get_Breton_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663994);
			PluralRules.NativeMethodInfoPtr_get_Czech_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663995);
			PluralRules.NativeMethodInfoPtr_get_Welsh_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663996);
			PluralRules.NativeMethodInfoPtr_get_Manx_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663997);
			PluralRules.NativeMethodInfoPtr_get_Langi_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663998);
			PluralRules.NativeMethodInfoPtr_get_Lithuanian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100663999);
			PluralRules.NativeMethodInfoPtr_get_Latvian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664000);
			PluralRules.NativeMethodInfoPtr_get_Macedonian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664001);
			PluralRules.NativeMethodInfoPtr_get_Moldavian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664002);
			PluralRules.NativeMethodInfoPtr_get_Maltese_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664003);
			PluralRules.NativeMethodInfoPtr_get_Polish_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664004);
			PluralRules.NativeMethodInfoPtr_get_Romanian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664005);
			PluralRules.NativeMethodInfoPtr_get_Tachelhit_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664006);
			PluralRules.NativeMethodInfoPtr_get_Slovak_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664007);
			PluralRules.NativeMethodInfoPtr_get_Slovenian_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664008);
			PluralRules.NativeMethodInfoPtr_get_CentralMoroccoTamazight_Private_Static_get_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664009);
			PluralRules.NativeMethodInfoPtr_GetPluralRule_Public_Static_PluralRuleDelegate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664010);
			PluralRules.NativeMethodInfoPtr_Between_Private_Static_Boolean_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, 100664011);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00018198 File Offset: 0x00016398
		public unsafe static PluralRules.PluralRuleDelegate Singular
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069974, XrefRangeEnd = 1069991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Singular_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003BD RID: 957 RVA: 0x000181CC File Offset: 0x000163CC
		public unsafe static PluralRules.PluralRuleDelegate DualOneOther
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069991, XrefRangeEnd = 1070008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_DualOneOther_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00018200 File Offset: 0x00016400
		public unsafe static PluralRules.PluralRuleDelegate DualWithZero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070008, XrefRangeEnd = 1070025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_DualWithZero_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00018234 File Offset: 0x00016434
		public unsafe static PluralRules.PluralRuleDelegate DualFromZeroToTwo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070025, XrefRangeEnd = 1070042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_DualFromZeroToTwo_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00018268 File Offset: 0x00016468
		public unsafe static PluralRules.PluralRuleDelegate TripleOneTwoOther
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070042, XrefRangeEnd = 1070059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_TripleOneTwoOther_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0001829C File Offset: 0x0001649C
		public unsafe static PluralRules.PluralRuleDelegate RussianSerboCroatian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070059, XrefRangeEnd = 1070076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_RussianSerboCroatian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000182D0 File Offset: 0x000164D0
		public unsafe static PluralRules.PluralRuleDelegate Arabic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070076, XrefRangeEnd = 1070093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Arabic_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00018304 File Offset: 0x00016504
		public unsafe static PluralRules.PluralRuleDelegate Breton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070093, XrefRangeEnd = 1070110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Breton_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00018338 File Offset: 0x00016538
		public unsafe static PluralRules.PluralRuleDelegate Czech
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070110, XrefRangeEnd = 1070127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Czech_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0001836C File Offset: 0x0001656C
		public unsafe static PluralRules.PluralRuleDelegate Welsh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070127, XrefRangeEnd = 1070144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Welsh_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000183A0 File Offset: 0x000165A0
		public unsafe static PluralRules.PluralRuleDelegate Manx
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070144, XrefRangeEnd = 1070161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Manx_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000183D4 File Offset: 0x000165D4
		public unsafe static PluralRules.PluralRuleDelegate Langi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070161, XrefRangeEnd = 1070178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Langi_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00018408 File Offset: 0x00016608
		public unsafe static PluralRules.PluralRuleDelegate Lithuanian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070178, XrefRangeEnd = 1070195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Lithuanian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0001843C File Offset: 0x0001663C
		public unsafe static PluralRules.PluralRuleDelegate Latvian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070195, XrefRangeEnd = 1070212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Latvian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00018470 File Offset: 0x00016670
		public unsafe static PluralRules.PluralRuleDelegate Macedonian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070212, XrefRangeEnd = 1070229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Macedonian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000184A4 File Offset: 0x000166A4
		public unsafe static PluralRules.PluralRuleDelegate Moldavian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070229, XrefRangeEnd = 1070246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Moldavian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000184D8 File Offset: 0x000166D8
		public unsafe static PluralRules.PluralRuleDelegate Maltese
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070246, XrefRangeEnd = 1070263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Maltese_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0001850C File Offset: 0x0001670C
		public unsafe static PluralRules.PluralRuleDelegate Polish
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070263, XrefRangeEnd = 1070280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Polish_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00018540 File Offset: 0x00016740
		public unsafe static PluralRules.PluralRuleDelegate Romanian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070280, XrefRangeEnd = 1070297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Romanian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00018574 File Offset: 0x00016774
		public unsafe static PluralRules.PluralRuleDelegate Tachelhit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070297, XrefRangeEnd = 1070314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Tachelhit_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000185A8 File Offset: 0x000167A8
		public unsafe static PluralRules.PluralRuleDelegate Slovak
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070314, XrefRangeEnd = 1070331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Slovak_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000185DC File Offset: 0x000167DC
		public unsafe static PluralRules.PluralRuleDelegate Slovenian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070331, XrefRangeEnd = 1070348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_Slovenian_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00018610 File Offset: 0x00016810
		public unsafe static PluralRules.PluralRuleDelegate CentralMoroccoTamazight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070348, XrefRangeEnd = 1070365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_get_CentralMoroccoTamazight_Private_Static_get_PluralRuleDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00018644 File Offset: 0x00016844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1070372, RefRangeEnd = 1070374, XrefRangeStart = 1070365, XrefRangeEnd = 1070372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PluralRules.PluralRuleDelegate GetPluralRule(string twoLetterIsoLanguageName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(twoLetterIsoLanguageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_GetPluralRule_Public_Static_PluralRuleDelegate_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00018688 File Offset: 0x00016888
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1070387, RefRangeEnd = 1070395, XrefRangeStart = 1070374, XrefRangeEnd = 1070387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Between(this Decimal value, Decimal min, Decimal max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.NativeMethodInfoPtr_Between_Private_Static_Boolean_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000347D File Offset: 0x0000167D
		public PluralRules(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000186E4 File Offset: 0x000168E4
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003486 File Offset: 0x00001686
		public unsafe static Dictionary<string, PluralRules.PluralRuleDelegate> IsoLangToDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluralRules.NativeFieldInfoPtr_IsoLangToDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PluralRules.PluralRuleDelegate>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluralRules.NativeFieldInfoPtr_IsoLangToDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_IsoLangToDelegate;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_Singular_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_DualOneOther_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_DualWithZero_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_DualFromZeroToTwo_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_TripleOneTwoOther_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_RussianSerboCroatian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_Arabic_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_Breton_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_Czech_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_Welsh_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_Manx_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_get_Langi_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_Lithuanian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_get_Latvian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_Macedonian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_Moldavian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_Maltese_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_Polish_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_Romanian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_Tachelhit_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_Slovak_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_Slovenian_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralMoroccoTamazight_Private_Static_get_PluralRuleDelegate_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralRule_Public_Static_PluralRuleDelegate_String_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_Between_Private_Static_Boolean_Decimal_Decimal_Decimal_0;

		// Token: 0x02000138 RID: 312
		public sealed class PluralRuleDelegate : MulticastDelegate
		{
			// Token: 0x06000D95 RID: 3477 RVA: 0x0003C03C File Offset: 0x0003A23C
			// Note: this type is marked as 'beforefieldinit'.
			static PluralRuleDelegate()
			{
				Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, "PluralRuleDelegate");
				PluralRules.PluralRuleDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr, 100664013);
				PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr, 100664014);
				PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Decimal_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr, 100664015);
				PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr, 100664016);
			}

			// Token: 0x06000D96 RID: 3478 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069746, XrefRangeEnd = 1069749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PluralRuleDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PluralRules.PluralRuleDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.PluralRuleDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D97 RID: 3479 RVA: 0x0003C10C File Offset: 0x0003A30C
			[CallerCount(0)]
			public unsafe int Invoke(Decimal value, int pluralCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pluralCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D98 RID: 3480 RVA: 0x0003C164 File Offset: 0x0003A364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069749, XrefRangeEnd = 1069756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Decimal value, int pluralCount, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pluralCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Decimal_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D99 RID: 3481 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.PluralRuleDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D9A RID: 3482 RVA: 0x00007A62 File Offset: 0x00005C62
			public PluralRuleDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D9B RID: 3483 RVA: 0x00007A6B File Offset: 0x00005C6B
			public static implicit operator PluralRules.PluralRuleDelegate(Func<Decimal, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<PluralRules.PluralRuleDelegate>(A_0);
			}

			// Token: 0x06000D9C RID: 3484 RVA: 0x00007A73 File Offset: 0x00005C73
			public static PluralRules.PluralRuleDelegate operator +(PluralRules.PluralRuleDelegate A_0, PluralRules.PluralRuleDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PluralRules.PluralRuleDelegate>();
			}

			// Token: 0x06000D9D RID: 3485 RVA: 0x00007A81 File Offset: 0x00005C81
			public static PluralRules.PluralRuleDelegate operator -(PluralRules.PluralRuleDelegate A_0, PluralRules.PluralRuleDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PluralRules.PluralRuleDelegate>();
				}
				return delegate2;
			}

			// Token: 0x0400096B RID: 2411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400096C RID: 2412
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Decimal_Int32_0;

			// Token: 0x0400096D RID: 2413
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Decimal_Int32_AsyncCallback_Object_0;

			// Token: 0x0400096E RID: 2414
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x02000139 RID: 313
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.PluralRules+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D9E RID: 3486 RVA: 0x0003C234 File Offset: 0x0003A434
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PluralRules>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr);
				PluralRules.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9");
				PluralRules.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__2_0");
				PluralRules.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__4_0");
				PluralRules.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__6_0");
				PluralRules.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__8_0");
				PluralRules.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__10_0");
				PluralRules.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__12_0");
				PluralRules.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__14_0");
				PluralRules.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__16_0");
				PluralRules.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__18_0");
				PluralRules.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__20_0");
				PluralRules.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__22_0");
				PluralRules.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__24_0");
				PluralRules.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__26_0");
				PluralRules.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__28_0");
				PluralRules.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__30_0");
				PluralRules.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__32_0");
				PluralRules.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__34_0");
				PluralRules.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__36_0");
				PluralRules.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__38_0");
				PluralRules.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__40_0");
				PluralRules.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__42_0");
				PluralRules.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__44_0");
				PluralRules.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, "<>9__46_0");
				PluralRules.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664018);
				PluralRules.__c.NativeMethodInfoPtr__get_Singular_b__2_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664019);
				PluralRules.__c.NativeMethodInfoPtr__get_DualOneOther_b__4_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664020);
				PluralRules.__c.NativeMethodInfoPtr__get_DualWithZero_b__6_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664021);
				PluralRules.__c.NativeMethodInfoPtr__get_DualFromZeroToTwo_b__8_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664022);
				PluralRules.__c.NativeMethodInfoPtr__get_TripleOneTwoOther_b__10_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664023);
				PluralRules.__c.NativeMethodInfoPtr__get_RussianSerboCroatian_b__12_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664024);
				PluralRules.__c.NativeMethodInfoPtr__get_Arabic_b__14_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664025);
				PluralRules.__c.NativeMethodInfoPtr__get_Breton_b__16_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664026);
				PluralRules.__c.NativeMethodInfoPtr__get_Czech_b__18_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664027);
				PluralRules.__c.NativeMethodInfoPtr__get_Welsh_b__20_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664028);
				PluralRules.__c.NativeMethodInfoPtr__get_Manx_b__22_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664029);
				PluralRules.__c.NativeMethodInfoPtr__get_Langi_b__24_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664030);
				PluralRules.__c.NativeMethodInfoPtr__get_Lithuanian_b__26_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664031);
				PluralRules.__c.NativeMethodInfoPtr__get_Latvian_b__28_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664032);
				PluralRules.__c.NativeMethodInfoPtr__get_Macedonian_b__30_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664033);
				PluralRules.__c.NativeMethodInfoPtr__get_Moldavian_b__32_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664034);
				PluralRules.__c.NativeMethodInfoPtr__get_Maltese_b__34_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664035);
				PluralRules.__c.NativeMethodInfoPtr__get_Polish_b__36_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664036);
				PluralRules.__c.NativeMethodInfoPtr__get_Romanian_b__38_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664037);
				PluralRules.__c.NativeMethodInfoPtr__get_Tachelhit_b__40_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664038);
				PluralRules.__c.NativeMethodInfoPtr__get_Slovak_b__42_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664039);
				PluralRules.__c.NativeMethodInfoPtr__get_Slovenian_b__44_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664040);
				PluralRules.__c.NativeMethodInfoPtr__get_CentralMoroccoTamazight_b__46_0_Internal_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr, 100664041);
			}

			// Token: 0x06000D9F RID: 3487 RVA: 0x0003C620 File Offset: 0x0003A820
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PluralRules.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DA0 RID: 3488 RVA: 0x0003C65C File Offset: 0x0003A85C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Singular_b__2_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Singular_b__2_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA1 RID: 3489 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069756, XrefRangeEnd = 1069757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_DualOneOther_b__4_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_DualOneOther_b__4_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA2 RID: 3490 RVA: 0x0003C70C File Offset: 0x0003A90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069757, XrefRangeEnd = 1069766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_DualWithZero_b__6_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_DualWithZero_b__6_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA3 RID: 3491 RVA: 0x0003C764 File Offset: 0x0003A964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069766, XrefRangeEnd = 1069775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_DualFromZeroToTwo_b__8_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_DualFromZeroToTwo_b__8_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x0003C7BC File Offset: 0x0003A9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069775, XrefRangeEnd = 1069780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_TripleOneTwoOther_b__10_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_TripleOneTwoOther_b__10_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x0003C814 File Offset: 0x0003AA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069780, XrefRangeEnd = 1069814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_RussianSerboCroatian_b__12_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_RussianSerboCroatian_b__12_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA6 RID: 3494 RVA: 0x0003C86C File Offset: 0x0003AA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069814, XrefRangeEnd = 1069820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Arabic_b__14_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Arabic_b__14_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA7 RID: 3495 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069820, XrefRangeEnd = 1069825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Breton_b__16_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Breton_b__16_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA8 RID: 3496 RVA: 0x0003C91C File Offset: 0x0003AB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069825, XrefRangeEnd = 1069831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Czech_b__18_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Czech_b__18_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DA9 RID: 3497 RVA: 0x0003C974 File Offset: 0x0003AB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069831, XrefRangeEnd = 1069836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Welsh_b__20_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Welsh_b__20_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAA RID: 3498 RVA: 0x0003C9CC File Offset: 0x0003ABCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069836, XrefRangeEnd = 1069854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Manx_b__22_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Manx_b__22_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAB RID: 3499 RVA: 0x0003CA24 File Offset: 0x0003AC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069854, XrefRangeEnd = 1069859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Langi_b__24_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Langi_b__24_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAC RID: 3500 RVA: 0x0003CA7C File Offset: 0x0003AC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069859, XrefRangeEnd = 1069896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Lithuanian_b__26_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Lithuanian_b__26_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069896, XrefRangeEnd = 1069901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Latvian_b__28_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Latvian_b__28_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x0003CB2C File Offset: 0x0003AD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069901, XrefRangeEnd = 1069912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Macedonian_b__30_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Macedonian_b__30_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAF RID: 3503 RVA: 0x0003CB84 File Offset: 0x0003AD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069912, XrefRangeEnd = 1069918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Moldavian_b__32_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Moldavian_b__32_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB0 RID: 3504 RVA: 0x0003CBDC File Offset: 0x0003ADDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069918, XrefRangeEnd = 1069924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Maltese_b__34_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Maltese_b__34_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB1 RID: 3505 RVA: 0x0003CC34 File Offset: 0x0003AE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069924, XrefRangeEnd = 1069930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Polish_b__36_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Polish_b__36_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB2 RID: 3506 RVA: 0x0003CC8C File Offset: 0x0003AE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069930, XrefRangeEnd = 1069936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Romanian_b__38_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Romanian_b__38_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB3 RID: 3507 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069936, XrefRangeEnd = 1069946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Tachelhit_b__40_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Tachelhit_b__40_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB4 RID: 3508 RVA: 0x0003CD3C File Offset: 0x0003AF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069946, XrefRangeEnd = 1069952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Slovak_b__42_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Slovak_b__42_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB5 RID: 3509 RVA: 0x0003CD94 File Offset: 0x0003AF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069952, XrefRangeEnd = 1069960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_Slovenian_b__44_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_Slovenian_b__44_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB6 RID: 3510 RVA: 0x0003CDEC File Offset: 0x0003AFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069960, XrefRangeEnd = 1069974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_CentralMoroccoTamazight_b__46_0(Decimal n, int c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralRules.__c.NativeMethodInfoPtr__get_CentralMoroccoTamazight_b__46_0_Internal_Int32_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DB7 RID: 3511 RVA: 0x00007A92 File Offset: 0x00005C92
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0003CE44 File Offset: 0x0003B044
			// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00007A9B File Offset: 0x00005C9B
			public unsafe static PluralRules.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0003CE6C File Offset: 0x0003B06C
			// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00007AAD File Offset: 0x00005CAD
			public unsafe static PluralRules.PluralRuleDelegate __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0003CE94 File Offset: 0x0003B094
			// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00007ABF File Offset: 0x00005CBF
			public unsafe static PluralRules.PluralRuleDelegate __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0003CEBC File Offset: 0x0003B0BC
			// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00007AD1 File Offset: 0x00005CD1
			public unsafe static PluralRules.PluralRuleDelegate __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0003CEE4 File Offset: 0x0003B0E4
			// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00007AE3 File Offset: 0x00005CE3
			public unsafe static PluralRules.PluralRuleDelegate __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0003CF0C File Offset: 0x0003B10C
			// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00007AF5 File Offset: 0x00005CF5
			public unsafe static PluralRules.PluralRuleDelegate __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0003CF34 File Offset: 0x0003B134
			// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00007B07 File Offset: 0x00005D07
			public unsafe static PluralRules.PluralRuleDelegate __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0003CF5C File Offset: 0x0003B15C
			// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00007B19 File Offset: 0x00005D19
			public unsafe static PluralRules.PluralRuleDelegate __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0003CF84 File Offset: 0x0003B184
			// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00007B2B File Offset: 0x00005D2B
			public unsafe static PluralRules.PluralRuleDelegate __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0003CFAC File Offset: 0x0003B1AC
			// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00007B3D File Offset: 0x00005D3D
			public unsafe static PluralRules.PluralRuleDelegate __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0003CFD4 File Offset: 0x0003B1D4
			// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00007B4F File Offset: 0x00005D4F
			public unsafe static PluralRules.PluralRuleDelegate __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0003CFFC File Offset: 0x0003B1FC
			// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00007B61 File Offset: 0x00005D61
			public unsafe static PluralRules.PluralRuleDelegate __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0003D024 File Offset: 0x0003B224
			// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00007B73 File Offset: 0x00005D73
			public unsafe static PluralRules.PluralRuleDelegate __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0003D04C File Offset: 0x0003B24C
			// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00007B85 File Offset: 0x00005D85
			public unsafe static PluralRules.PluralRuleDelegate __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0003D074 File Offset: 0x0003B274
			// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00007B97 File Offset: 0x00005D97
			public unsafe static PluralRules.PluralRuleDelegate __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0003D09C File Offset: 0x0003B29C
			// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00007BA9 File Offset: 0x00005DA9
			public unsafe static PluralRules.PluralRuleDelegate __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0003D0C4 File Offset: 0x0003B2C4
			// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00007BBB File Offset: 0x00005DBB
			public unsafe static PluralRules.PluralRuleDelegate __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0003D0EC File Offset: 0x0003B2EC
			// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00007BCD File Offset: 0x00005DCD
			public unsafe static PluralRules.PluralRuleDelegate __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0003D114 File Offset: 0x0003B314
			// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00007BDF File Offset: 0x00005DDF
			public unsafe static PluralRules.PluralRuleDelegate __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0003D13C File Offset: 0x0003B33C
			// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00007BF1 File Offset: 0x00005DF1
			public unsafe static PluralRules.PluralRuleDelegate __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0003D164 File Offset: 0x0003B364
			// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00007C03 File Offset: 0x00005E03
			public unsafe static PluralRules.PluralRuleDelegate __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0003D18C File Offset: 0x0003B38C
			// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00007C15 File Offset: 0x00005E15
			public unsafe static PluralRules.PluralRuleDelegate __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0003D1B4 File Offset: 0x0003B3B4
			// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00007C27 File Offset: 0x00005E27
			public unsafe static PluralRules.PluralRuleDelegate __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0003D1DC File Offset: 0x0003B3DC
			// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00007C39 File Offset: 0x00005E39
			public unsafe static PluralRules.PluralRuleDelegate __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PluralRules.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PluralRules.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400096F RID: 2415
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000970 RID: 2416
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04000971 RID: 2417
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04000972 RID: 2418
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000973 RID: 2419
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04000974 RID: 2420
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04000975 RID: 2421
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04000976 RID: 2422
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04000977 RID: 2423
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04000978 RID: 2424
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04000979 RID: 2425
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400097A RID: 2426
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400097B RID: 2427
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400097C RID: 2428
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x0400097D RID: 2429
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400097E RID: 2430
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x0400097F RID: 2431
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04000980 RID: 2432
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04000981 RID: 2433
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04000982 RID: 2434
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x04000983 RID: 2435
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04000984 RID: 2436
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04000985 RID: 2437
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x04000986 RID: 2438
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04000987 RID: 2439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000988 RID: 2440
			private static readonly IntPtr NativeMethodInfoPtr__get_Singular_b__2_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000989 RID: 2441
			private static readonly IntPtr NativeMethodInfoPtr__get_DualOneOther_b__4_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098A RID: 2442
			private static readonly IntPtr NativeMethodInfoPtr__get_DualWithZero_b__6_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098B RID: 2443
			private static readonly IntPtr NativeMethodInfoPtr__get_DualFromZeroToTwo_b__8_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098C RID: 2444
			private static readonly IntPtr NativeMethodInfoPtr__get_TripleOneTwoOther_b__10_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098D RID: 2445
			private static readonly IntPtr NativeMethodInfoPtr__get_RussianSerboCroatian_b__12_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098E RID: 2446
			private static readonly IntPtr NativeMethodInfoPtr__get_Arabic_b__14_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400098F RID: 2447
			private static readonly IntPtr NativeMethodInfoPtr__get_Breton_b__16_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000990 RID: 2448
			private static readonly IntPtr NativeMethodInfoPtr__get_Czech_b__18_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000991 RID: 2449
			private static readonly IntPtr NativeMethodInfoPtr__get_Welsh_b__20_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000992 RID: 2450
			private static readonly IntPtr NativeMethodInfoPtr__get_Manx_b__22_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000993 RID: 2451
			private static readonly IntPtr NativeMethodInfoPtr__get_Langi_b__24_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000994 RID: 2452
			private static readonly IntPtr NativeMethodInfoPtr__get_Lithuanian_b__26_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000995 RID: 2453
			private static readonly IntPtr NativeMethodInfoPtr__get_Latvian_b__28_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000996 RID: 2454
			private static readonly IntPtr NativeMethodInfoPtr__get_Macedonian_b__30_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000997 RID: 2455
			private static readonly IntPtr NativeMethodInfoPtr__get_Moldavian_b__32_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000998 RID: 2456
			private static readonly IntPtr NativeMethodInfoPtr__get_Maltese_b__34_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x04000999 RID: 2457
			private static readonly IntPtr NativeMethodInfoPtr__get_Polish_b__36_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400099A RID: 2458
			private static readonly IntPtr NativeMethodInfoPtr__get_Romanian_b__38_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400099B RID: 2459
			private static readonly IntPtr NativeMethodInfoPtr__get_Tachelhit_b__40_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400099C RID: 2460
			private static readonly IntPtr NativeMethodInfoPtr__get_Slovak_b__42_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400099D RID: 2461
			private static readonly IntPtr NativeMethodInfoPtr__get_Slovenian_b__44_0_Internal_Int32_Decimal_Int32_0;

			// Token: 0x0400099E RID: 2462
			private static readonly IntPtr NativeMethodInfoPtr__get_CentralMoroccoTamazight_b__46_0_Internal_Int32_Decimal_Int32_0;
		}
	}
}
