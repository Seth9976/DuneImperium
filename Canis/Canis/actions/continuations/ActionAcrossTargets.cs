using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.actions.continuations
{
	// Token: 0x02000221 RID: 545
	public class ActionAcrossTargets : Object
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x00074518 File Offset: 0x00072718
		// Note: this type is marked as 'beforefieldinit'.
		static ActionAcrossTargets()
		{
			Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ActionAcrossTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr);
			ActionAcrossTargets.NativeMethodInfoPtr_Match_Public_A_Func_2_Noop_A_Func_2_Skip_A_Func_2_Targeted_A_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr, 100668433);
			ActionAcrossTargets.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr, 100668434);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00074570 File Offset: 0x00072770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593694, RefRangeEnd = 593696, XrefRangeStart = 593676, XrefRangeEnd = 593694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe A Match<A>(Func<ActionAcrossTargets.Noop, A> handleNoop, Func<ActionAcrossTargets.Skip, A> handleSkip, Func<ActionAcrossTargets.Targeted, A> handleTargeted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handleNoop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleSkip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleTargeted);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.MethodInfoStoreGeneric_Match_Public_A_Func_2_Noop_A_Func_2_Skip_A_Func_2_Targeted_A_0<A>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<A>(intPtr, false, true);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000745E0 File Offset: 0x000727E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionAcrossTargets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public ActionAcrossTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_A_Func_2_Noop_A_Func_2_Skip_A_Func_2_Targeted_A_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000460 RID: 1120
		public sealed class Noop : ActionAcrossTargets
		{
			// Token: 0x06003213 RID: 12819 RVA: 0x000CE424 File Offset: 0x000CC624
			// Note: this type is marked as 'beforefieldinit'.
			static Noop()
			{
				Il2CppClassPointerStore<ActionAcrossTargets.Noop>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr, "Noop");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionAcrossTargets.Noop>.NativeClassPtr);
				ActionAcrossTargets.Noop.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Noop>.NativeClassPtr, "Instance");
				ActionAcrossTargets.Noop.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Noop>.NativeClassPtr, 100668435);
			}

			// Token: 0x06003214 RID: 12820 RVA: 0x000CE478 File Offset: 0x000CC678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Noop()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionAcrossTargets.Noop>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Noop.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003215 RID: 12821 RVA: 0x00017FE5 File Offset: 0x000161E5
			public Noop(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x06003216 RID: 12822 RVA: 0x000CE4B4 File Offset: 0x000CC6B4
			// (set) Token: 0x06003217 RID: 12823 RVA: 0x00017FEE File Offset: 0x000161EE
			public unsafe static ActionAcrossTargets.Noop Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActionAcrossTargets.Noop.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets.Noop>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActionAcrossTargets.Noop.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F54 RID: 8020
			private static readonly IntPtr NativeFieldInfoPtr_Instance;

			// Token: 0x04001F55 RID: 8021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
		}

		// Token: 0x02000461 RID: 1121
		public sealed class Skip : ActionAcrossTargets
		{
			// Token: 0x06003218 RID: 12824 RVA: 0x000CE4DC File Offset: 0x000CC6DC
			// Note: this type is marked as 'beforefieldinit'.
			static Skip()
			{
				Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr, "Skip");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr);
				ActionAcrossTargets.Skip.NativeFieldInfoPtr_SkipAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr, "SkipAction");
				ActionAcrossTargets.Skip.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr, "Context");
				ActionAcrossTargets.Skip.NativeMethodInfoPtr__ctor_Public_Void_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr, 100668437);
			}

			// Token: 0x06003219 RID: 12825 RVA: 0x000CE544 File Offset: 0x000CC744
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Skip(Action act, Context context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionAcrossTargets.Skip>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Skip.NativeMethodInfoPtr__ctor_Public_Void_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600321A RID: 12826 RVA: 0x00018000 File Offset: 0x00016200
			public Skip(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x0600321B RID: 12827 RVA: 0x000CE5A4 File Offset: 0x000CC7A4
			// (set) Token: 0x0600321C RID: 12828 RVA: 0x00018009 File Offset: 0x00016209
			public unsafe Action SkipAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Skip.NativeFieldInfoPtr_SkipAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Skip.NativeFieldInfoPtr_SkipAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x0600321D RID: 12829 RVA: 0x000CE5D4 File Offset: 0x000CC7D4
			// (set) Token: 0x0600321E RID: 12830 RVA: 0x00018028 File Offset: 0x00016228
			public unsafe Context Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Skip.NativeFieldInfoPtr_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Skip.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F56 RID: 8022
			private static readonly IntPtr NativeFieldInfoPtr_SkipAction;

			// Token: 0x04001F57 RID: 8023
			private static readonly IntPtr NativeFieldInfoPtr_Context;

			// Token: 0x04001F58 RID: 8024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Context_0;
		}

		// Token: 0x02000462 RID: 1122
		public sealed class Targeted : ActionAcrossTargets
		{
			// Token: 0x0600321F RID: 12831 RVA: 0x000CE604 File Offset: 0x000CC804
			// Note: this type is marked as 'beforefieldinit'.
			static Targeted()
			{
				Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr, "Targeted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr);
				ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, "Action");
				ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, "Context");
				ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, "Targets");
				ActionAcrossTargets.Targeted.NativeMethodInfoPtr__ctor_Public_Void_Action_Context_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, 100668438);
				ActionAcrossTargets.Targeted.NativeMethodInfoPtr_Serialize_Public_SerializedActionAcrossTargets_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, 100668439);
			}

			// Token: 0x06003220 RID: 12832 RVA: 0x000CE694 File Offset: 0x000CC894
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 593645, RefRangeEnd = 593649, XrefRangeStart = 593625, XrefRangeEnd = 593645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Targeted(Action act, Context context, Object first, Il2CppReferenceArray<Object> rest)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(first);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Targeted.NativeMethodInfoPtr__ctor_Public_Void_Action_Context_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003221 RID: 12833 RVA: 0x000CE718 File Offset: 0x000CC918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593649, XrefRangeEnd = 593676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedActionAcrossTargets Serialize(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Targeted.NativeMethodInfoPtr_Serialize_Public_SerializedActionAcrossTargets_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedActionAcrossTargets>(intPtr3) : null;
				}
			}

			// Token: 0x06003222 RID: 12834 RVA: 0x00018047 File Offset: 0x00016247
			public Targeted(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D40 RID: 3392
			// (get) Token: 0x06003223 RID: 12835 RVA: 0x000CE768 File Offset: 0x000CC968
			// (set) Token: 0x06003224 RID: 12836 RVA: 0x00018050 File Offset: 0x00016250
			public unsafe Action Action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x06003225 RID: 12837 RVA: 0x000CE798 File Offset: 0x000CC998
			// (set) Token: 0x06003226 RID: 12838 RVA: 0x0001806F File Offset: 0x0001626F
			public unsafe Context Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x06003227 RID: 12839 RVA: 0x000CE7C8 File Offset: 0x000CC9C8
			// (set) Token: 0x06003228 RID: 12840 RVA: 0x0001808E File Offset: 0x0001628E
			public unsafe Il2CppReferenceArray<Object> Targets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Targets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F59 RID: 8025
			private static readonly IntPtr NativeFieldInfoPtr_Action;

			// Token: 0x04001F5A RID: 8026
			private static readonly IntPtr NativeFieldInfoPtr_Context;

			// Token: 0x04001F5B RID: 8027
			private static readonly IntPtr NativeFieldInfoPtr_Targets;

			// Token: 0x04001F5C RID: 8028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Context_Object_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04001F5D RID: 8029
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_SerializedActionAcrossTargets_Match_0;

			// Token: 0x02000493 RID: 1171
			[ObfuscatedName("Canis.actions.continuations.ActionAcrossTargets+Targeted+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x06003568 RID: 13672 RVA: 0x000D8334 File Offset: 0x000D6534
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionAcrossTargets.Targeted>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr);
					ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr, "match");
					ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr, 100668440);
					ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeMethodInfoPtr__Serialize_b__0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr, 100668441);
				}

				// Token: 0x06003569 RID: 13673 RVA: 0x000D839C File Offset: 0x000D659C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionAcrossTargets.Targeted.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600356A RID: 13674 RVA: 0x000D83D8 File Offset: 0x000D65D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593624, XrefRangeEnd = 593625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Serialize_b__0(Object unknown)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(unknown);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeMethodInfoPtr__Serialize_b__0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0600356B RID: 13675 RVA: 0x00019D65 File Offset: 0x00017F65
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E5D RID: 3677
				// (get) Token: 0x0600356C RID: 13676 RVA: 0x000D8420 File Offset: 0x000D6620
				// (set) Token: 0x0600356D RID: 13677 RVA: 0x00019D6E File Offset: 0x00017F6E
				public unsafe Match match
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeFieldInfoPtr_match);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionAcrossTargets.Targeted.__c__DisplayClass4_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002155 RID: 8533
				private static readonly IntPtr NativeFieldInfoPtr_match;

				// Token: 0x04002156 RID: 8534
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002157 RID: 8535
				private static readonly IntPtr NativeMethodInfoPtr__Serialize_b__0_Internal_String_Object_0;
			}
		}

		// Token: 0x02000463 RID: 1123
		private sealed class MethodInfoStoreGeneric_Match_Public_A_Func_2_Noop_A_Func_2_Skip_A_Func_2_Targeted_A_0<A>
		{
			// Token: 0x04001F5E RID: 8030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionAcrossTargets.NativeMethodInfoPtr_Match_Public_A_Func_2_Noop_A_Func_2_Skip_A_Func_2_Targeted_A_0, Il2CppClassPointerStore<ActionAcrossTargets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)) }))));
		}
	}
}
