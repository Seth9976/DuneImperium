using System;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities
{
	// Token: 0x02000430 RID: 1072
	public class StrengthIntrigueAbility : IntrigueAbility
	{
		// Token: 0x06002E6E RID: 11886 RVA: 0x0011A114 File Offset: 0x00118314
		// Note: this type is marked as 'beforefieldinit'.
		static StrengthIntrigueAbility()
		{
			Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities", "StrengthIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr);
			StrengthIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, 100677253);
			StrengthIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, 100677254);
			StrengthIntrigueAbility.NativeMethodInfoPtr_StrengthValue_Public_Virtual_New_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, 100677255);
			StrengthIntrigueAbility.NativeMethodInfoPtr_CombatValue_Public_Virtual_New_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, 100677256);
			StrengthIntrigueAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, 100677257);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x0011A1A8 File Offset: 0x001183A8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 216448, RefRangeEnd = 216462, XrefRangeStart = 216437, XrefRangeEnd = 216448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrengthIntrigueAbility(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0011A218 File Offset: 0x00118418
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrengthIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x0011A288 File Offset: 0x00118488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216462, XrefRangeEnd = 216463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int StrengthValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StrengthIntrigueAbility.NativeMethodInfoPtr_StrengthValue_Public_Virtual_New_Int32_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x0011A2E0 File Offset: 0x001184E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216463, XrefRangeEnd = 216472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double CombatValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StrengthIntrigueAbility.NativeMethodInfoPtr_CombatValue_Public_Virtual_New_Double_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x0011A338 File Offset: 0x00118538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216736, RefRangeEnd = 216739, XrefRangeStart = 216472, XrefRangeEnd = 216736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StrengthIntrigueAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00010B53 File Offset: 0x0000ED53
		public StrengthIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_StrengthValue_Public_Virtual_New_Int32_WormPlayer_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_CombatValue_Public_Virtual_New_Double_WormPlayer_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000A20 RID: 2592
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.StrengthIntrigueAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600A19A RID: 41370 RVA: 0x0029D3F8 File Offset: 0x0029B5F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr);
				StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, "<>9");
				StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, "<>9__4_0");
				StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, "<>9__4_3");
				StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, "<>9__4_1");
				StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, "<>9__4_2");
				StrengthIntrigueAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, 100677259);
				StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, 100677260);
				StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_3_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, 100677261);
				StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_1_Internal_WormPlayer_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, 100677262);
				StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_2_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr, 100677263);
			}

			// Token: 0x0600A19B RID: 41371 RVA: 0x0029D4EC File Offset: 0x0029B6EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrengthIntrigueAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A19C RID: 41372 RVA: 0x0029D528 File Offset: 0x0029B728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__4_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A19D RID: 41373 RVA: 0x0029D578 File Offset: 0x0029B778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216429, XrefRangeEnd = 216434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<StrengthIntrigueAbility> _Evaluate_b__4_3(WormIntriguePlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_3_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<StrengthIntrigueAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x0600A19E RID: 41374 RVA: 0x0029D5C8 File Offset: 0x0029B7C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormPlayer _Evaluate_b__4_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_1_Internal_WormPlayer_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x0600A19F RID: 41375 RVA: 0x0029D618 File Offset: 0x0029B818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__4_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c.NativeMethodInfoPtr__Evaluate_b__4_2_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A1A0 RID: 41376 RVA: 0x000486BC File Offset: 0x000468BC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170030B7 RID: 12471
			// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x0029D668 File Offset: 0x0029B868
			// (set) Token: 0x0600A1A2 RID: 41378 RVA: 0x000486C5 File Offset: 0x000468C5
			public unsafe static StrengthIntrigueAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrengthIntrigueAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030B8 RID: 12472
			// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x0029D690 File Offset: 0x0029B890
			// (set) Token: 0x0600A1A4 RID: 41380 RVA: 0x000486D7 File Offset: 0x000468D7
			public unsafe static Func<WormPlayer, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030B9 RID: 12473
			// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x0029D6B8 File Offset: 0x0029B8B8
			// (set) Token: 0x0600A1A6 RID: 41382 RVA: 0x000486E9 File Offset: 0x000468E9
			public unsafe static Func<WormIntriguePlayable, IEnumerable<StrengthIntrigueAbility>> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, IEnumerable<StrengthIntrigueAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BA RID: 12474
			// (get) Token: 0x0600A1A7 RID: 41383 RVA: 0x0029D6E0 File Offset: 0x0029B8E0
			// (set) Token: 0x0600A1A8 RID: 41384 RVA: 0x000486FB File Offset: 0x000468FB
			public unsafe static Func<WormPlayer, WormPlayer> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BB RID: 12475
			// (get) Token: 0x0600A1A9 RID: 41385 RVA: 0x0029D708 File Offset: 0x0029B908
			// (set) Token: 0x0600A1AA RID: 41386 RVA: 0x0004870D File Offset: 0x0004690D
			public unsafe static Func<WormPlayer, int> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrengthIntrigueAbility.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400668C RID: 26252
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400668D RID: 26253
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400668E RID: 26254
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x0400668F RID: 26255
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04006690 RID: 26256
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04006691 RID: 26257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006692 RID: 26258
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_0_Internal_Int32_WormPlayer_0;

			// Token: 0x04006693 RID: 26259
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_3_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0;

			// Token: 0x04006694 RID: 26260
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_1_Internal_WormPlayer_WormPlayer_0;

			// Token: 0x04006695 RID: 26261
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_2_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x02000A21 RID: 2593
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.StrengthIntrigueAbility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600A1AB RID: 41387 RVA: 0x0029D730 File Offset: 0x0029B930
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StrengthIntrigueAbility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr);
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, "context");
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, "choice");
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, "<>9__6");
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, "<>9__7");
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, 100677264);
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Int32_StrengthIntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, 100677265);
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_StrengthIntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, 100677266);
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__6_Internal_Int32_StrengthIntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, 100677267);
				StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__7_Internal_Double_StrengthIntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr, 100677268);
			}

			// Token: 0x0600A1AC RID: 41388 RVA: 0x0029D810 File Offset: 0x0029BA10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrengthIntrigueAbility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1AD RID: 41389 RVA: 0x0029D84C File Offset: 0x0029BA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216434, XrefRangeEnd = 216435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__4(StrengthIntrigueAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Int32_StrengthIntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A1AE RID: 41390 RVA: 0x0029D89C File Offset: 0x0029BA9C
			[CallerCount(0)]
			public unsafe bool _Evaluate_b__5(StrengthIntrigueAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_StrengthIntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A1AF RID: 41391 RVA: 0x0029D8EC File Offset: 0x0029BAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__6(StrengthIntrigueAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__6_Internal_Int32_StrengthIntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A1B0 RID: 41392 RVA: 0x0029D93C File Offset: 0x0029BB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216435, XrefRangeEnd = 216437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__7(StrengthIntrigueAbility c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeMethodInfoPtr__Evaluate_b__7_Internal_Double_StrengthIntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A1B1 RID: 41393 RVA: 0x0004871F File Offset: 0x0004691F
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170030BC RID: 12476
			// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x0029D98C File Offset: 0x0029BB8C
			// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x00048728 File Offset: 0x00046928
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BD RID: 12477
			// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x0029D9BC File Offset: 0x0029BBBC
			// (set) Token: 0x0600A1B5 RID: 41397 RVA: 0x00048747 File Offset: 0x00046947
			public unsafe WormAIChoiceSelectionWithTargets choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceSelectionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BE RID: 12478
			// (get) Token: 0x0600A1B6 RID: 41398 RVA: 0x0029D9EC File Offset: 0x0029BBEC
			// (set) Token: 0x0600A1B7 RID: 41399 RVA: 0x00048766 File Offset: 0x00046966
			public unsafe Func<StrengthIntrigueAbility, int> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StrengthIntrigueAbility, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BF RID: 12479
			// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x0029DA1C File Offset: 0x0029BC1C
			// (set) Token: 0x0600A1B9 RID: 41401 RVA: 0x00048785 File Offset: 0x00046985
			public unsafe Func<StrengthIntrigueAbility, double> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StrengthIntrigueAbility, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrengthIntrigueAbility.__c__DisplayClass4_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006696 RID: 26262
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006697 RID: 26263
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04006698 RID: 26264
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04006699 RID: 26265
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x0400669A RID: 26266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400669B RID: 26267
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_Internal_Int32_StrengthIntrigueAbility_0;

			// Token: 0x0400669C RID: 26268
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_StrengthIntrigueAbility_0;

			// Token: 0x0400669D RID: 26269
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__6_Internal_Int32_StrengthIntrigueAbility_0;

			// Token: 0x0400669E RID: 26270
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__7_Internal_Double_StrengthIntrigueAbility_0;
		}
	}
}
