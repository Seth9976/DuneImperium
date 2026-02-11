using System;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x02000184 RID: 388
	public static class NonSelectionPromptUtils : Object
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x0005E6B8 File Offset: 0x0005C8B8
		// Note: this type is marked as 'beforefieldinit'.
		static NonSelectionPromptUtils()
		{
			Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "NonSelectionPromptUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr);
			NonSelectionPromptUtils.NativeMethodInfoPtr_ShouldShowNonSelectionPromptForSelector_Private_Static_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr, 100666841);
			NonSelectionPromptUtils.NativeMethodInfoPtr_MakeNonPromptTextSetter_Public_Static_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr, 100666842);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0005E710 File Offset: 0x0005C910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582845, XrefRangeEnd = 582854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldShowNonSelectionPromptForSelector(PlayerEntity selectingPlayer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.NativeMethodInfoPtr_ShouldShowNonSelectionPromptForSelector_Private_Static_Boolean_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0005E754 File Offset: 0x0005C954
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 583030, RefRangeEnd = 583034, XrefRangeStart = 582854, XrefRangeEnd = 583030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Action> MakeNonPromptTextSetter(this Match match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.NativeMethodInfoPtr_MakeNonPromptTextSetter_Public_Static_IEnumerable_1_Action_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000088A8 File Offset: 0x00006AA8
		public NonSelectionPromptUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowNonSelectionPromptForSelector_Private_Static_Boolean_PlayerEntity_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_MakeNonPromptTextSetter_Public_Static_IEnumerable_1_Action_Match_0;

		// Token: 0x020003BE RID: 958
		[ObfuscatedName("Canis.actions.NonSelectionPromptUtils+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002855 RID: 10325 RVA: 0x00013489 File Offset: 0x00011689
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<NonSelectionPromptUtils.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSelectionPromptUtils.__O>.NativeClassPtr);
				NonSelectionPromptUtils.__O.NativeFieldInfoPtr__0___ShouldShowNonSelectionPromptForSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__O>.NativeClassPtr, "<0>__ShouldShowNonSelectionPromptForSelector");
			}

			// Token: 0x06002856 RID: 10326 RVA: 0x000134BD File Offset: 0x000116BD
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06002857 RID: 10327 RVA: 0x000AF5EC File Offset: 0x000AD7EC
			// (set) Token: 0x06002858 RID: 10328 RVA: 0x000134C6 File Offset: 0x000116C6
			public unsafe static Func<PlayerEntity, bool> _0___ShouldShowNonSelectionPromptForSelector
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__O.NativeFieldInfoPtr__0___ShouldShowNonSelectionPromptForSelector, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__O.NativeFieldInfoPtr__0___ShouldShowNonSelectionPromptForSelector, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001933 RID: 6451
			private static readonly IntPtr NativeFieldInfoPtr__0___ShouldShowNonSelectionPromptForSelector;
		}

		// Token: 0x020003BF RID: 959
		[ObfuscatedName("Canis.actions.NonSelectionPromptUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002859 RID: 10329 RVA: 0x000AF614 File Offset: 0x000AD814
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr);
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9");
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9__1_0");
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9__1_1");
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9__1_2");
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9__1_3");
				NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, "<>9__1_4");
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666844);
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666845);
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_1_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666846);
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666847);
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_3_Internal_String_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666848);
				NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_4_Internal_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr, 100666849);
			}

			// Token: 0x0600285A RID: 10330 RVA: 0x000AF730 File Offset: 0x000AD930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonSelectionPromptUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600285B RID: 10331 RVA: 0x000AF76C File Offset: 0x000AD96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582834, XrefRangeEnd = 582838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeNonPromptTextSetter_b__1_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600285C RID: 10332 RVA: 0x000AF7BC File Offset: 0x000AD9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PendingSelection> _MakeNonPromptTextSetter_b__1_1(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_1_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PendingSelection>>(intPtr3) : null;
				}
			}

			// Token: 0x0600285D RID: 10333 RVA: 0x000AF80C File Offset: 0x000ADA0C
			[CallerCount(0)]
			public unsafe bool _MakeNonPromptTextSetter_b__1_2(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600285E RID: 10334 RVA: 0x000AF85C File Offset: 0x000ADA5C
			[CallerCount(0)]
			public unsafe string _MakeNonPromptTextSetter_b__1_3(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_3_Internal_String_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600285F RID: 10335 RVA: 0x000AF8A4 File Offset: 0x000ADAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582838, XrefRangeEnd = 582839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MakeNonPromptTextSetter_b__1_4(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c.NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_4_Internal_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002860 RID: 10336 RVA: 0x000134D8 File Offset: 0x000116D8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06002861 RID: 10337 RVA: 0x000AF8EC File Offset: 0x000ADAEC
			// (set) Token: 0x06002862 RID: 10338 RVA: 0x000134E1 File Offset: 0x000116E1
			public unsafe static NonSelectionPromptUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NonSelectionPromptUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06002863 RID: 10339 RVA: 0x000AF914 File Offset: 0x000ADB14
			// (set) Token: 0x06002864 RID: 10340 RVA: 0x000134F3 File Offset: 0x000116F3
			public unsafe static Func<PlayerEntity, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06002865 RID: 10341 RVA: 0x000AF93C File Offset: 0x000ADB3C
			// (set) Token: 0x06002866 RID: 10342 RVA: 0x00013505 File Offset: 0x00011705
			public unsafe static Func<PlayerEntity, IEnumerable<PendingSelection>> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, IEnumerable<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06002867 RID: 10343 RVA: 0x000AF964 File Offset: 0x000ADB64
			// (set) Token: 0x06002868 RID: 10344 RVA: 0x00013517 File Offset: 0x00011717
			public unsafe static Func<PendingSelection, bool> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06002869 RID: 10345 RVA: 0x000AF98C File Offset: 0x000ADB8C
			// (set) Token: 0x0600286A RID: 10346 RVA: 0x00013529 File Offset: 0x00011729
			public unsafe static Func<PendingSelection, string> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x0600286B RID: 10347 RVA: 0x000AF9B4 File Offset: 0x000ADBB4
			// (set) Token: 0x0600286C RID: 10348 RVA: 0x0001353B File Offset: 0x0001173B
			public unsafe static Func<PlayerEntity, string> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NonSelectionPromptUtils.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001934 RID: 6452
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001935 RID: 6453
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001936 RID: 6454
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04001937 RID: 6455
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x04001938 RID: 6456
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x04001939 RID: 6457
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x0400193A RID: 6458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400193B RID: 6459
			private static readonly IntPtr NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400193C RID: 6460
			private static readonly IntPtr NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_1_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0;

			// Token: 0x0400193D RID: 6461
			private static readonly IntPtr NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_2_Internal_Boolean_PendingSelection_0;

			// Token: 0x0400193E RID: 6462
			private static readonly IntPtr NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_3_Internal_String_PendingSelection_0;

			// Token: 0x0400193F RID: 6463
			private static readonly IntPtr NativeMethodInfoPtr__MakeNonPromptTextSetter_b__1_4_Internal_String_PlayerEntity_0;
		}

		// Token: 0x020003C0 RID: 960
		[ObfuscatedName("Canis.actions.NonSelectionPromptUtils+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600286D RID: 10349 RVA: 0x000AF9DC File Offset: 0x000ADBDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NonSelectionPromptUtils>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr);
				NonSelectionPromptUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr, "selectingPlayer");
				NonSelectionPromptUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr, 100666850);
				NonSelectionPromptUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ShouldShowNonSelectionPromptForSelector_b__0_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr, 100666851);
			}

			// Token: 0x0600286E RID: 10350 RVA: 0x000AFA44 File Offset: 0x000ADC44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonSelectionPromptUtils.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600286F RID: 10351 RVA: 0x000AFA80 File Offset: 0x000ADC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582839, XrefRangeEnd = 582845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldShowNonSelectionPromptForSelector_b__0(PendingSelection s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSelectionPromptUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ShouldShowNonSelectionPromptForSelector_b__0_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002870 RID: 10352 RVA: 0x0001354D File Offset: 0x0001174D
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06002871 RID: 10353 RVA: 0x000AFAD0 File Offset: 0x000ADCD0
			// (set) Token: 0x06002872 RID: 10354 RVA: 0x00013556 File Offset: 0x00011756
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonSelectionPromptUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonSelectionPromptUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001940 RID: 6464
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04001941 RID: 6465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001942 RID: 6466
			private static readonly IntPtr NativeMethodInfoPtr__ShouldShowNonSelectionPromptForSelector_b__0_Internal_Boolean_PendingSelection_0;
		}
	}
}
