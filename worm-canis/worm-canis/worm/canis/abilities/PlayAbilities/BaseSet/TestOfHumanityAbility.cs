using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000496 RID: 1174
	public class TestOfHumanityAbility : AgentAbility
	{
		// Token: 0x06003475 RID: 13429 RVA: 0x00138944 File Offset: 0x00136B44
		// Note: this type is marked as 'beforefieldinit'.
		static TestOfHumanityAbility()
		{
			Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "TestOfHumanityAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr);
			TestOfHumanityAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, "AbilityName");
			TestOfHumanityAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, "AbilityID");
			TestOfHumanityAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, 100679824);
			TestOfHumanityAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, 100679825);
			TestOfHumanityAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, 100679826);
			TestOfHumanityAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, 100679827);
			TestOfHumanityAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, 100679829);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00138A00 File Offset: 0x00136C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239383, XrefRangeEnd = 239387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TestOfHumanityAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00138A4C File Offset: 0x00136C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239387, XrefRangeEnd = 239403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestOfHumanityAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00138A98 File Offset: 0x00136C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239403, XrefRangeEnd = 239407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestOfHumanityAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00138B08 File Offset: 0x00136D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239407, XrefRangeEnd = 239416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TestOfHumanityAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00138B88 File Offset: 0x00136D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00011F4B File Offset: 0x0001014B
		public TestOfHumanityAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x00138BFC File Offset: 0x00136DFC
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x00011F54 File Offset: 0x00010154
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TestOfHumanityAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TestOfHumanityAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x00138C1C File Offset: 0x00136E1C
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x00011F66 File Offset: 0x00010166
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TestOfHumanityAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TestOfHumanityAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000B3F RID: 2879
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.TestOfHumanityAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600B616 RID: 46614 RVA: 0x002D8D18 File Offset: 0x002D6F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr);
				TestOfHumanityAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr, "<>9");
				TestOfHumanityAbility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr, "<>9__5_0");
				TestOfHumanityAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr, 100679831);
				TestOfHumanityAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__5_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr, 100679832);
			}

			// Token: 0x0600B617 RID: 46615 RVA: 0x002D8D94 File Offset: 0x002D6F94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestOfHumanityAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B618 RID: 46616 RVA: 0x002D8DD0 File Offset: 0x002D6FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239291, XrefRangeEnd = 239292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunImmediateEffects_b__5_0(WormAbilityDefinition a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__5_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B619 RID: 46617 RVA: 0x000540D7 File Offset: 0x000522D7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170037E9 RID: 14313
			// (get) Token: 0x0600B61A RID: 46618 RVA: 0x002D8E20 File Offset: 0x002D7020
			// (set) Token: 0x0600B61B RID: 46619 RVA: 0x000540E0 File Offset: 0x000522E0
			public unsafe static TestOfHumanityAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestOfHumanityAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TestOfHumanityAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestOfHumanityAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037EA RID: 14314
			// (get) Token: 0x0600B61C RID: 46620 RVA: 0x002D8E48 File Offset: 0x002D7048
			// (set) Token: 0x0600B61D RID: 46621 RVA: 0x000540F2 File Offset: 0x000522F2
			public unsafe static Func<WormAbilityDefinition, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TestOfHumanityAbility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TestOfHumanityAbility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040072A4 RID: 29348
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040072A5 RID: 29349
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040072A6 RID: 29350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040072A7 RID: 29351
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__5_0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000B40 RID: 2880
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.TestOfHumanityAbility+<RunImmediateEffects>d__5")]
		public sealed class _RunImmediateEffects_d__5 : Object
		{
			// Token: 0x0600B61E RID: 46622 RVA: 0x002D8E70 File Offset: 0x002D7070
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__5()
			{
				Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TestOfHumanityAbility>.NativeClassPtr, "<RunImmediateEffects>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>1__state");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>2__current");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>l__initialThreadId");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>4__this");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "match");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>3__match");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "activeAbility");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>3__activeAbility");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "context");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>3__context");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>7__wrap1");
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679833);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679834);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679835);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679836);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679837);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679838);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679839);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679840);
				TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100679841);
			}

			// Token: 0x0600B61F RID: 46623 RVA: 0x002D902C File Offset: 0x002D722C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestOfHumanityAbility._RunImmediateEffects_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B620 RID: 46624 RVA: 0x002D9074 File Offset: 0x002D7274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239292, XrefRangeEnd = 239297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B621 RID: 46625 RVA: 0x002D90A8 File Offset: 0x002D72A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239297, XrefRangeEnd = 239364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B622 RID: 46626 RVA: 0x002D90E4 File Offset: 0x002D72E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239364, XrefRangeEnd = 239367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037F6 RID: 14326
			// (get) Token: 0x0600B623 RID: 46627 RVA: 0x002D9118 File Offset: 0x002D7318
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B624 RID: 46628 RVA: 0x002D9158 File Offset: 0x002D7358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239367, XrefRangeEnd = 239372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037F7 RID: 14327
			// (get) Token: 0x0600B625 RID: 46629 RVA: 0x002D918C File Offset: 0x002D738C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B626 RID: 46630 RVA: 0x002D91CC File Offset: 0x002D73CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239372, XrefRangeEnd = 239383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B627 RID: 46631 RVA: 0x002D920C File Offset: 0x002D740C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B628 RID: 46632 RVA: 0x00054104 File Offset: 0x00052304
			public _RunImmediateEffects_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170037EB RID: 14315
			// (get) Token: 0x0600B629 RID: 46633 RVA: 0x002D924C File Offset: 0x002D744C
			// (set) Token: 0x0600B62A RID: 46634 RVA: 0x0005410D File Offset: 0x0005230D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170037EC RID: 14316
			// (get) Token: 0x0600B62B RID: 46635 RVA: 0x002D9274 File Offset: 0x002D7474
			// (set) Token: 0x0600B62C RID: 46636 RVA: 0x00054128 File Offset: 0x00052328
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037ED RID: 14317
			// (get) Token: 0x0600B62D RID: 46637 RVA: 0x002D92A4 File Offset: 0x002D74A4
			// (set) Token: 0x0600B62E RID: 46638 RVA: 0x00054147 File Offset: 0x00052347
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170037EE RID: 14318
			// (get) Token: 0x0600B62F RID: 46639 RVA: 0x002D92CC File Offset: 0x002D74CC
			// (set) Token: 0x0600B630 RID: 46640 RVA: 0x00054162 File Offset: 0x00052362
			public unsafe TestOfHumanityAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TestOfHumanityAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037EF RID: 14319
			// (get) Token: 0x0600B631 RID: 46641 RVA: 0x002D92FC File Offset: 0x002D74FC
			// (set) Token: 0x0600B632 RID: 46642 RVA: 0x00054181 File Offset: 0x00052381
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F0 RID: 14320
			// (get) Token: 0x0600B633 RID: 46643 RVA: 0x002D932C File Offset: 0x002D752C
			// (set) Token: 0x0600B634 RID: 46644 RVA: 0x000541A0 File Offset: 0x000523A0
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F1 RID: 14321
			// (get) Token: 0x0600B635 RID: 46645 RVA: 0x002D935C File Offset: 0x002D755C
			// (set) Token: 0x0600B636 RID: 46646 RVA: 0x000541BF File Offset: 0x000523BF
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F2 RID: 14322
			// (get) Token: 0x0600B637 RID: 46647 RVA: 0x002D938C File Offset: 0x002D758C
			// (set) Token: 0x0600B638 RID: 46648 RVA: 0x000541DE File Offset: 0x000523DE
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F3 RID: 14323
			// (get) Token: 0x0600B639 RID: 46649 RVA: 0x002D93BC File Offset: 0x002D75BC
			// (set) Token: 0x0600B63A RID: 46650 RVA: 0x000541FD File Offset: 0x000523FD
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F4 RID: 14324
			// (get) Token: 0x0600B63B RID: 46651 RVA: 0x002D93EC File Offset: 0x002D75EC
			// (set) Token: 0x0600B63C RID: 46652 RVA: 0x0005421C File Offset: 0x0005241C
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F5 RID: 14325
			// (get) Token: 0x0600B63D RID: 46653 RVA: 0x002D941C File Offset: 0x002D761C
			// (set) Token: 0x0600B63E RID: 46654 RVA: 0x0005423B File Offset: 0x0005243B
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestOfHumanityAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040072A8 RID: 29352
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040072A9 RID: 29353
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040072AA RID: 29354
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040072AB RID: 29355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040072AC RID: 29356
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040072AD RID: 29357
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040072AE RID: 29358
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040072AF RID: 29359
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040072B0 RID: 29360
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040072B1 RID: 29361
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040072B2 RID: 29362
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040072B3 RID: 29363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040072B4 RID: 29364
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040072B5 RID: 29365
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040072B6 RID: 29366
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040072B7 RID: 29367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040072B8 RID: 29368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040072B9 RID: 29369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040072BA RID: 29370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040072BB RID: 29371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
