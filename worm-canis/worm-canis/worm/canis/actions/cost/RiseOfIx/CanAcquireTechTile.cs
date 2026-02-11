using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x02000309 RID: 777
	public class CanAcquireTechTile : CostAction
	{
		// Token: 0x06001FCF RID: 8143 RVA: 0x000D55A8 File Offset: 0x000D37A8
		// Note: this type is marked as 'beforefieldinit'.
		static CanAcquireTechTile()
		{
			Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "CanAcquireTechTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr);
			CanAcquireTechTile.NativeFieldInfoPtr_discount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, "discount");
			CanAcquireTechTile.NativeFieldInfoPtr_canUseSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, "canUseSolari");
			CanAcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, 100670989);
			CanAcquireTechTile.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, 100670990);
			CanAcquireTechTile.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, 100670991);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000D563C File Offset: 0x000D383C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174310, RefRangeEnd = 174313, XrefRangeStart = 174309, XrefRangeEnd = 174310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanAcquireTechTile(int discount, Match m, bool canUseSolari = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref discount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canUseSolari;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000D56A4 File Offset: 0x000D38A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174313, XrefRangeEnd = 174317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanAcquireTechTile.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000D56F0 File Offset: 0x000D38F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174317, XrefRangeEnd = 174375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanAcquireTechTile.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0000D383 File Offset: 0x0000B583
		public CanAcquireTechTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000D5748 File Offset: 0x000D3948
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0000D38C File Offset: 0x0000B58C
		public unsafe int discount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.NativeFieldInfoPtr_discount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.NativeFieldInfoPtr_discount)) = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000D5770 File Offset: 0x000D3970
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x0000D3A7 File Offset: 0x0000B5A7
		public unsafe bool canUseSolari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.NativeFieldInfoPtr_canUseSolari);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.NativeFieldInfoPtr_canUseSolari)) = value;
			}
		}

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeFieldInfoPtr_discount;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeFieldInfoPtr_canUseSolari;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Boolean_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x020007BE RID: 1982
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.CanAcquireTechTile+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600703A RID: 28730 RVA: 0x0020B3EC File Offset: 0x002095EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr);
				CanAcquireTechTile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr, "<>9");
				CanAcquireTechTile.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr, "<>9__4_0");
				CanAcquireTechTile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr, 100670993);
				CanAcquireTechTile.__c.NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr, 100670994);
			}

			// Token: 0x0600703B RID: 28731 RVA: 0x0020B468 File Offset: 0x00209668
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAcquireTechTile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600703C RID: 28732 RVA: 0x0020B4A4 File Offset: 0x002096A4
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _CanBePaid_b__4_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile.__c.NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600703D RID: 28733 RVA: 0x0002C922 File Offset: 0x0002AB22
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ED1 RID: 7889
			// (get) Token: 0x0600703E RID: 28734 RVA: 0x0020B4F4 File Offset: 0x002096F4
			// (set) Token: 0x0600703F RID: 28735 RVA: 0x0002C92B File Offset: 0x0002AB2B
			public unsafe static CanAcquireTechTile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanAcquireTechTile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanAcquireTechTile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanAcquireTechTile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ED2 RID: 7890
			// (get) Token: 0x06007040 RID: 28736 RVA: 0x0020B51C File Offset: 0x0020971C
			// (set) Token: 0x06007041 RID: 28737 RVA: 0x0002C93D File Offset: 0x0002AB3D
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanAcquireTechTile.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanAcquireTechTile.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004884 RID: 18564
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004885 RID: 18565
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04004886 RID: 18566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004887 RID: 18567
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;
		}

		// Token: 0x020007BF RID: 1983
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.CanAcquireTechTile+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06007042 RID: 28738 RVA: 0x0020B544 File Offset: 0x00209744
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr);
				CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_resourceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr, "resourceCount");
				CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_negotiatorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr, "negotiatorCount");
				CanAcquireTechTile.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr, 100670995);
				CanAcquireTechTile.__c__DisplayClass4_0.NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr, 100670996);
			}

			// Token: 0x06007043 RID: 28739 RVA: 0x0020B5D4 File Offset: 0x002097D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAcquireTechTile.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007044 RID: 28740 RVA: 0x0020B610 File Offset: 0x00209810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174301, XrefRangeEnd = 174302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanBePaid_b__1(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile.__c__DisplayClass4_0.NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007045 RID: 28741 RVA: 0x0002C94F File Offset: 0x0002AB4F
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ED3 RID: 7891
			// (get) Token: 0x06007046 RID: 28742 RVA: 0x0020B660 File Offset: 0x00209860
			// (set) Token: 0x06007047 RID: 28743 RVA: 0x0002C958 File Offset: 0x0002AB58
			public unsafe CanAcquireTechTile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanAcquireTechTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ED4 RID: 7892
			// (get) Token: 0x06007048 RID: 28744 RVA: 0x0020B690 File Offset: 0x00209890
			// (set) Token: 0x06007049 RID: 28745 RVA: 0x0002C977 File Offset: 0x0002AB77
			public unsafe int resourceCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_resourceCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_resourceCount)) = value;
				}
			}

			// Token: 0x17001ED5 RID: 7893
			// (get) Token: 0x0600704A RID: 28746 RVA: 0x0020B6B8 File Offset: 0x002098B8
			// (set) Token: 0x0600704B RID: 28747 RVA: 0x0002C992 File Offset: 0x0002AB92
			public unsafe int negotiatorCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_negotiatorCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile.__c__DisplayClass4_0.NativeFieldInfoPtr_negotiatorCount)) = value;
				}
			}

			// Token: 0x04004888 RID: 18568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004889 RID: 18569
			private static readonly IntPtr NativeFieldInfoPtr_resourceCount;

			// Token: 0x0400488A RID: 18570
			private static readonly IntPtr NativeFieldInfoPtr_negotiatorCount;

			// Token: 0x0400488B RID: 18571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400488C RID: 18572
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormTechTilePlayable_0;
		}

		// Token: 0x020007C0 RID: 1984
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.CanAcquireTechTile+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600704C RID: 28748 RVA: 0x0020B6E0 File Offset: 0x002098E0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanAcquireTechTile>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr);
				CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, "<>1__state");
				CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, "<>2__current");
				CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100670997);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100670998);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100670999);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100671000);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100671001);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100671002);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100671003);
				CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr, 100671004);
			}

			// Token: 0x0600704D RID: 28749 RVA: 0x0020B7E8 File Offset: 0x002099E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAcquireTechTile._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600704E RID: 28750 RVA: 0x0020B830 File Offset: 0x00209A30
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600704F RID: 28751 RVA: 0x0020B864 File Offset: 0x00209A64
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001ED9 RID: 7897
			// (get) Token: 0x06007050 RID: 28752 RVA: 0x0020B8A0 File Offset: 0x00209AA0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007051 RID: 28753 RVA: 0x0020B8E0 File Offset: 0x00209AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174302, XrefRangeEnd = 174307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001EDA RID: 7898
			// (get) Token: 0x06007052 RID: 28754 RVA: 0x0020B914 File Offset: 0x00209B14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007053 RID: 28755 RVA: 0x0020B954 File Offset: 0x00209B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174307, XrefRangeEnd = 174309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007054 RID: 28756 RVA: 0x0020B994 File Offset: 0x00209B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAcquireTechTile._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007055 RID: 28757 RVA: 0x0002C9AD File Offset: 0x0002ABAD
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ED6 RID: 7894
			// (get) Token: 0x06007056 RID: 28758 RVA: 0x0020B9D4 File Offset: 0x00209BD4
			// (set) Token: 0x06007057 RID: 28759 RVA: 0x0002C9B6 File Offset: 0x0002ABB6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ED7 RID: 7895
			// (get) Token: 0x06007058 RID: 28760 RVA: 0x0020B9FC File Offset: 0x00209BFC
			// (set) Token: 0x06007059 RID: 28761 RVA: 0x0002C9D1 File Offset: 0x0002ABD1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ED8 RID: 7896
			// (get) Token: 0x0600705A RID: 28762 RVA: 0x0020BA2C File Offset: 0x00209C2C
			// (set) Token: 0x0600705B RID: 28763 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAcquireTechTile._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400488D RID: 18573
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400488E RID: 18574
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400488F RID: 18575
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004890 RID: 18576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004891 RID: 18577
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004892 RID: 18578
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004893 RID: 18579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004894 RID: 18580
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004895 RID: 18581
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004896 RID: 18582
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004897 RID: 18583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
