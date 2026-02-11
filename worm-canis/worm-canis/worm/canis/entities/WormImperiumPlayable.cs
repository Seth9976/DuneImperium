using System;
using Canis;
using canis.archetypes;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai;
using worm.canis.data.enums;

namespace worm.canis.entities
{
	// Token: 0x0200002C RID: 44
	public class WormImperiumPlayable : WormPlayable
	{
		// Token: 0x06000389 RID: 905 RVA: 0x000773BC File Offset: 0x000755BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumPlayable()
		{
			Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormImperiumPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr);
			WormImperiumPlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664091);
			WormImperiumPlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664092);
			WormImperiumPlayable.NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664093);
			WormImperiumPlayable.NativeMethodInfoPtr_CheckAndGetConditionalIcons_Public_IEnumerable_1_AgentIcons_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664094);
			WormImperiumPlayable.NativeMethodInfoPtr_GetGraftedCard_Public_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664095);
			WormImperiumPlayable.NativeMethodInfoPtr_GetControllingPlayer_Public_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664096);
			WormImperiumPlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, 100664097);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00077478 File Offset: 0x00075678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38359, RefRangeEnd = 38361, XrefRangeStart = 38353, XrefRangeEnd = 38359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumPlayable(Match m, PlayerEntity owner, Archetype arch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000774E8 File Offset: 0x000756E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 35608, RefRangeEnd = 35618, XrefRangeStart = 35608, XrefRangeEnd = 35618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumPlayable(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00077558 File Offset: 0x00075758
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 38508, RefRangeEnd = 38536, XrefRangeStart = 38361, XrefRangeEnd = 38508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> AcquireValue(WormPlayer forPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000775A8 File Offset: 0x000757A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 38614, RefRangeEnd = 38618, XrefRangeStart = 38536, XrefRangeEnd = 38614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AgentIcons> CheckAndGetConditionalIcons(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr_CheckAndGetConditionalIcons_Public_IEnumerable_1_AgentIcons_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AgentIcons>>(intPtr3) : null;
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000775F8 File Offset: 0x000757F8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 38633, RefRangeEnd = 38656, XrefRangeStart = 38618, XrefRangeEnd = 38633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumPlayable GetGraftedCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr_GetGraftedCard_Public_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00077638 File Offset: 0x00075838
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 38661, RefRangeEnd = 38670, XrefRangeStart = 38656, XrefRangeEnd = 38661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer GetControllingPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.NativeMethodInfoPtr_GetControllingPlayer_Public_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00077678 File Offset: 0x00075878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38670, XrefRangeEnd = 38674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumPlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00003733 File Offset: 0x00001933
		public WormImperiumPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndGetConditionalIcons_Public_IEnumerable_1_AgentIcons_WormPlayer_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_GetGraftedCard_Public_WormImperiumPlayable_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_GetControllingPlayer_Public_WormPlayer_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0;

		// Token: 0x0200059B RID: 1435
		[ObfuscatedName("worm.canis.entities.WormImperiumPlayable+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060044E0 RID: 17632 RVA: 0x00183794 File Offset: 0x00181994
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr);
				WormImperiumPlayable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, "<>9");
				WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, "<>9__2_0");
				WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, "<>9__2_1");
				WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, "<>9__2_2");
				WormImperiumPlayable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, 100664099);
				WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, 100664100);
				WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, 100664101);
				WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_2_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr, 100664102);
			}

			// Token: 0x060044E1 RID: 17633 RVA: 0x00183860 File Offset: 0x00181A60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumPlayable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060044E2 RID: 17634 RVA: 0x0018389C File Offset: 0x00181A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38329, XrefRangeEnd = 38334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AcquireValue_b__2_0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044E3 RID: 17635 RVA: 0x001838EC File Offset: 0x00181AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38334, XrefRangeEnd = 38339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AcquireValue_b__2_1(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044E4 RID: 17636 RVA: 0x0018393C File Offset: 0x00181B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38339, XrefRangeEnd = 38344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AcquireValue_b__2_2(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c.NativeMethodInfoPtr__AcquireValue_b__2_2_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044E5 RID: 17637 RVA: 0x00016C90 File Offset: 0x00014E90
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001067 RID: 4199
			// (get) Token: 0x060044E6 RID: 17638 RVA: 0x0018398C File Offset: 0x00181B8C
			// (set) Token: 0x060044E7 RID: 17639 RVA: 0x00016C99 File Offset: 0x00014E99
			public unsafe static WormImperiumPlayable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001068 RID: 4200
			// (get) Token: 0x060044E8 RID: 17640 RVA: 0x001839B4 File Offset: 0x00181BB4
			// (set) Token: 0x060044E9 RID: 17641 RVA: 0x00016CAB File Offset: 0x00014EAB
			public unsafe static Func<WormImperiumPlayable, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001069 RID: 4201
			// (get) Token: 0x060044EA RID: 17642 RVA: 0x001839DC File Offset: 0x00181BDC
			// (set) Token: 0x060044EB RID: 17643 RVA: 0x00016CBD File Offset: 0x00014EBD
			public unsafe static Func<WormImperiumPlayable, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106A RID: 4202
			// (get) Token: 0x060044EC RID: 17644 RVA: 0x00183A04 File Offset: 0x00181C04
			// (set) Token: 0x060044ED RID: 17645 RVA: 0x00016CCF File Offset: 0x00014ECF
			public unsafe static Func<WormImperiumPlayable, bool> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormImperiumPlayable.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D70 RID: 11632
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D71 RID: 11633
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04002D72 RID: 11634
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04002D73 RID: 11635
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04002D74 RID: 11636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D75 RID: 11637
			private static readonly IntPtr NativeMethodInfoPtr__AcquireValue_b__2_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04002D76 RID: 11638
			private static readonly IntPtr NativeMethodInfoPtr__AcquireValue_b__2_1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04002D77 RID: 11639
			private static readonly IntPtr NativeMethodInfoPtr__AcquireValue_b__2_2_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x0200059C RID: 1436
		[ObfuscatedName("worm.canis.entities.WormImperiumPlayable+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060044EE RID: 17646 RVA: 0x00183A2C File Offset: 0x00181C2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr);
				WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_constants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr, "constants");
				WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_deckIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr, "deckIcons");
				WormImperiumPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr, 100664103);
				WormImperiumPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__AcquireValue_b__3_Internal_Double_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr, 100664104);
			}

			// Token: 0x060044EF RID: 17647 RVA: 0x00183AA8 File Offset: 0x00181CA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060044F0 RID: 17648 RVA: 0x00183AE4 File Offset: 0x00181CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38344, XrefRangeEnd = 38350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _AcquireValue_b__3(AgentIcons _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__AcquireValue_b__3_Internal_Double_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044F1 RID: 17649 RVA: 0x00016CE1 File Offset: 0x00014EE1
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106B RID: 4203
			// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00183B30 File Offset: 0x00181D30
			// (set) Token: 0x060044F3 RID: 17651 RVA: 0x00016CEA File Offset: 0x00014EEA
			public unsafe AIConstantsRef constants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_constants);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIConstantsRef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_constants), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106C RID: 4204
			// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00183B60 File Offset: 0x00181D60
			// (set) Token: 0x060044F5 RID: 17653 RVA: 0x00016D09 File Offset: 0x00014F09
			public unsafe Dictionary<AgentIcons, int> deckIcons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_deckIcons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AgentIcons, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_deckIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D78 RID: 11640
			private static readonly IntPtr NativeFieldInfoPtr_constants;

			// Token: 0x04002D79 RID: 11641
			private static readonly IntPtr NativeFieldInfoPtr_deckIcons;

			// Token: 0x04002D7A RID: 11642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D7B RID: 11643
			private static readonly IntPtr NativeMethodInfoPtr__AcquireValue_b__3_Internal_Double_AgentIcons_0;
		}

		// Token: 0x0200059D RID: 1437
		[ObfuscatedName("worm.canis.entities.WormImperiumPlayable+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060044F6 RID: 17654 RVA: 0x00183B90 File Offset: 0x00181D90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormImperiumPlayable>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr);
				WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr, "player");
				WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr, 100664105);
				WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr, 100664106);
				WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr, 100664107);
			}

			// Token: 0x060044F7 RID: 17655 RVA: 0x00183C20 File Offset: 0x00181E20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumPlayable.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060044F8 RID: 17656 RVA: 0x00183C5C File Offset: 0x00181E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38350, XrefRangeEnd = 38351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckAndGetConditionalIcons_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044F9 RID: 17657 RVA: 0x00183CAC File Offset: 0x00181EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38351, XrefRangeEnd = 38353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckAndGetConditionalIcons_b__1(WormPlayer opp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060044FA RID: 17658 RVA: 0x00016D28 File Offset: 0x00014F28
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106D RID: 4205
			// (get) Token: 0x060044FB RID: 17659 RVA: 0x00183CFC File Offset: 0x00181EFC
			// (set) Token: 0x060044FC RID: 17660 RVA: 0x00016D31 File Offset: 0x00014F31
			public unsafe WormImperiumPlayable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106E RID: 4206
			// (get) Token: 0x060044FD RID: 17661 RVA: 0x00183D2C File Offset: 0x00181F2C
			// (set) Token: 0x060044FE RID: 17662 RVA: 0x00016D50 File Offset: 0x00014F50
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D7C RID: 11644
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D7D RID: 11645
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D7E RID: 11646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D7F RID: 11647
			private static readonly IntPtr NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002D80 RID: 11648
			private static readonly IntPtr NativeMethodInfoPtr__CheckAndGetConditionalIcons_b__1_Internal_Boolean_WormPlayer_0;
		}
	}
}
