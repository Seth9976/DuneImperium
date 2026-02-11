using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030C RID: 780
	public class ResolveGuildChiefAdministrator : global::Canis.actions.Action
	{
		// Token: 0x06001FEB RID: 8171 RVA: 0x000D5CE8 File Offset: 0x000D3EE8
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveGuildChiefAdministrator()
		{
			Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "ResolveGuildChiefAdministrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr);
			ResolveGuildChiefAdministrator.NativeFieldInfoPtr_discardCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, "discardCard");
			ResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_WormImperiumPlayable_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, 100671039);
			ResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveGuildChiefAdministrator_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, 100671040);
			ResolveGuildChiefAdministrator.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, 100671041);
			ResolveGuildChiefAdministrator.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, 100671042);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x000D5D7C File Offset: 0x000D3F7C
		[CallerCount(106)]
		[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139275, XrefRangeEnd = 139381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveGuildChiefAdministrator(WormImperiumPlayable discardCard, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(discardCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_WormImperiumPlayable_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000D5DDC File Offset: 0x000D3FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174569, XrefRangeEnd = 174574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveGuildChiefAdministrator(SerializedResolveGuildChiefAdministrator serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveGuildChiefAdministrator_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000D5E3C File Offset: 0x000D403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174574, XrefRangeEnd = 174580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveGuildChiefAdministrator.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000D5E88 File Offset: 0x000D4088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174580, XrefRangeEnd = 174585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveGuildChiefAdministrator.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0000D40E File Offset: 0x0000B60E
		public ResolveGuildChiefAdministrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x000D5EE4 File Offset: 0x000D40E4
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0000D417 File Offset: 0x0000B617
		public unsafe WormImperiumPlayable discardCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator.NativeFieldInfoPtr_discardCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator.NativeFieldInfoPtr_discardCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_discardCard;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormImperiumPlayable_Match_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveGuildChiefAdministrator_Match_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020007C4 RID: 1988
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveGuildChiefAdministrator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06007090 RID: 28816 RVA: 0x0020C53C File Offset: 0x0020A73C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr);
				ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr, "<>9");
				ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr, "<>9__3_1");
				ResolveGuildChiefAdministrator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr, 100671044);
				ResolveGuildChiefAdministrator.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr, 100671045);
			}

			// Token: 0x06007091 RID: 28817 RVA: 0x0020C5B8 File Offset: 0x0020A7B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007092 RID: 28818 RVA: 0x0020C5F4 File Offset: 0x0020A7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174518, XrefRangeEnd = 174524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _execute_b__3_1(GameLogBuilder glb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(glb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06007093 RID: 28819 RVA: 0x0002CB3C File Offset: 0x0002AD3C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EEB RID: 7915
			// (get) Token: 0x06007094 RID: 28820 RVA: 0x0020C644 File Offset: 0x0020A844
			// (set) Token: 0x06007095 RID: 28821 RVA: 0x0002CB45 File Offset: 0x0002AD45
			public unsafe static ResolveGuildChiefAdministrator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveGuildChiefAdministrator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EEC RID: 7916
			// (get) Token: 0x06007096 RID: 28822 RVA: 0x0020C66C File Offset: 0x0020A86C
			// (set) Token: 0x06007097 RID: 28823 RVA: 0x0002CB57 File Offset: 0x0002AD57
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveGuildChiefAdministrator.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048BA RID: 18618
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040048BB RID: 18619
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040048BC RID: 18620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048BD RID: 18621
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x020007C5 RID: 1989
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveGuildChiefAdministrator+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06007098 RID: 28824 RVA: 0x0020C694 File Offset: 0x0020A894
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr);
				ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeFieldInfoPtr_selectedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr, "selectedCard");
				ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr, 100671046);
				ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr, 100671047);
			}

			// Token: 0x06007099 RID: 28825 RVA: 0x0020C6FC File Offset: 0x0020A8FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600709A RID: 28826 RVA: 0x0020C738 File Offset: 0x0020A938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174524, XrefRangeEnd = 174528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _execute_b__0(GameLogBuilder glb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(glb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600709B RID: 28827 RVA: 0x0002CB69 File Offset: 0x0002AD69
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EED RID: 7917
			// (get) Token: 0x0600709C RID: 28828 RVA: 0x0020C788 File Offset: 0x0020A988
			// (set) Token: 0x0600709D RID: 28829 RVA: 0x0002CB72 File Offset: 0x0002AD72
			public unsafe WormImperiumPlayable selectedCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeFieldInfoPtr_selectedCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator.__c__DisplayClass3_0.NativeFieldInfoPtr_selectedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048BE RID: 18622
			private static readonly IntPtr NativeFieldInfoPtr_selectedCard;

			// Token: 0x040048BF RID: 18623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048C0 RID: 18624
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x020007C6 RID: 1990
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveGuildChiefAdministrator+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600709E RID: 28830 RVA: 0x0020C7B8 File Offset: 0x0020A9B8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveGuildChiefAdministrator>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr);
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<>1__state");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<>2__current");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<>4__this");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<>8__1");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__wormMatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<wormMatch>5__2");
				ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, "<sequenceHelper>5__3");
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671048);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671049);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671050);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671051);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671052);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671053);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671054);
				ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr, 100671055);
			}

			// Token: 0x0600709F RID: 28831 RVA: 0x0020C910 File Offset: 0x0020AB10
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveGuildChiefAdministrator._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060070A0 RID: 28832 RVA: 0x0020C958 File Offset: 0x0020AB58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060070A1 RID: 28833 RVA: 0x0020C98C File Offset: 0x0020AB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174528, XrefRangeEnd = 174562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EF5 RID: 7925
			// (get) Token: 0x060070A2 RID: 28834 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060070A3 RID: 28835 RVA: 0x0020CA08 File Offset: 0x0020AC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174562, XrefRangeEnd = 174567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EF6 RID: 7926
			// (get) Token: 0x060070A4 RID: 28836 RVA: 0x0020CA3C File Offset: 0x0020AC3C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060070A5 RID: 28837 RVA: 0x0020CA7C File Offset: 0x0020AC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174567, XrefRangeEnd = 174569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060070A6 RID: 28838 RVA: 0x0020CABC File Offset: 0x0020ACBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveGuildChiefAdministrator._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060070A7 RID: 28839 RVA: 0x0002CB91 File Offset: 0x0002AD91
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EEE RID: 7918
			// (get) Token: 0x060070A8 RID: 28840 RVA: 0x0020CAFC File Offset: 0x0020ACFC
			// (set) Token: 0x060070A9 RID: 28841 RVA: 0x0002CB9A File Offset: 0x0002AD9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EEF RID: 7919
			// (get) Token: 0x060070AA RID: 28842 RVA: 0x0020CB24 File Offset: 0x0020AD24
			// (set) Token: 0x060070AB RID: 28843 RVA: 0x0002CBB5 File Offset: 0x0002ADB5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EF0 RID: 7920
			// (get) Token: 0x060070AC RID: 28844 RVA: 0x0020CB54 File Offset: 0x0020AD54
			// (set) Token: 0x060070AD RID: 28845 RVA: 0x0002CBD4 File Offset: 0x0002ADD4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001EF1 RID: 7921
			// (get) Token: 0x060070AE RID: 28846 RVA: 0x0020CB7C File Offset: 0x0020AD7C
			// (set) Token: 0x060070AF RID: 28847 RVA: 0x0002CBEF File Offset: 0x0002ADEF
			public unsafe ResolveGuildChiefAdministrator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveGuildChiefAdministrator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EF2 RID: 7922
			// (get) Token: 0x060070B0 RID: 28848 RVA: 0x0020CBAC File Offset: 0x0020ADAC
			// (set) Token: 0x060070B1 RID: 28849 RVA: 0x0002CC0E File Offset: 0x0002AE0E
			public unsafe ResolveGuildChiefAdministrator.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveGuildChiefAdministrator.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EF3 RID: 7923
			// (get) Token: 0x060070B2 RID: 28850 RVA: 0x0020CBDC File Offset: 0x0020ADDC
			// (set) Token: 0x060070B3 RID: 28851 RVA: 0x0002CC2D File Offset: 0x0002AE2D
			public unsafe WormMatch _wormMatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__wormMatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__wormMatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EF4 RID: 7924
			// (get) Token: 0x060070B4 RID: 28852 RVA: 0x0020CC0C File Offset: 0x0020AE0C
			// (set) Token: 0x060070B5 RID: 28853 RVA: 0x0002CC4C File Offset: 0x0002AE4C
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveGuildChiefAdministrator._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048C1 RID: 18625
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040048C2 RID: 18626
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040048C3 RID: 18627
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040048C4 RID: 18628
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040048C5 RID: 18629
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040048C6 RID: 18630
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__2;

			// Token: 0x040048C7 RID: 18631
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x040048C8 RID: 18632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040048C9 RID: 18633
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048CA RID: 18634
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040048CB RID: 18635
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040048CC RID: 18636
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048CD RID: 18637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040048CE RID: 18638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040048CF RID: 18639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
