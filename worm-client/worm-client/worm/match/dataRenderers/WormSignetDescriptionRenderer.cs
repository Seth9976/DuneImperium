using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000160 RID: 352
	public class WormSignetDescriptionRenderer : Observer
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x000475D0 File Offset: 0x000457D0
		// Note: this type is marked as 'beforefieldinit'.
		static WormSignetDescriptionRenderer()
		{
			Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSignetDescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr);
			WormSignetDescriptionRenderer.NativeFieldInfoPtr_abilityIDLeaderPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "abilityIDLeaderPairs");
			WormSignetDescriptionRenderer.NativeFieldInfoPtr_textRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "textRoot");
			WormSignetDescriptionRenderer.NativeFieldInfoPtr_iconRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "iconRoot");
			WormSignetDescriptionRenderer.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "locKey");
			WormSignetDescriptionRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, 100665431);
			WormSignetDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, 100665432);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00047678 File Offset: 0x00045878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708193, XrefRangeEnd = 708310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSignetDescriptionRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000476B4 File Offset: 0x000458B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708310, XrefRangeEnd = 708318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSignetDescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000A46A File Offset: 0x0000866A
		public WormSignetDescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000476F0 File Offset: 0x000458F0
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0000A473 File Offset: 0x00008673
		public unsafe Il2CppReferenceArray<WormSignetDescriptionRenderer.AbilityIDLeaderPair> abilityIDLeaderPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_abilityIDLeaderPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormSignetDescriptionRenderer.AbilityIDLeaderPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_abilityIDLeaderPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00047720 File Offset: 0x00045920
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0000A492 File Offset: 0x00008692
		public unsafe GameObject textRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_textRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_textRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00047750 File Offset: 0x00045950
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0000A4B1 File Offset: 0x000086B1
		public unsafe GameObject iconRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_iconRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.NativeFieldInfoPtr_iconRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00047780 File Offset: 0x00045980
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public unsafe static string locKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormSignetDescriptionRenderer.NativeFieldInfoPtr_locKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormSignetDescriptionRenderer.NativeFieldInfoPtr_locKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_abilityIDLeaderPairs;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_textRoot;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_iconRoot;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A5 RID: 933
		[Serializable]
		public sealed class AbilityIDLeaderPair : ValueType
		{
			// Token: 0x06002596 RID: 9622 RVA: 0x000899F8 File Offset: 0x00087BF8
			// Note: this type is marked as 'beforefieldinit'.
			static AbilityIDLeaderPair()
			{
				Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "AbilityIDLeaderPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr);
				WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr, "abilityID");
				WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_leaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr, "leaderName");
				WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_iconOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr, "iconOnly");
			}

			// Token: 0x06002597 RID: 9623 RVA: 0x00014EAF File Offset: 0x000130AF
			public AbilityIDLeaderPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002598 RID: 9624 RVA: 0x00014EB8 File Offset: 0x000130B8
			public AbilityIDLeaderPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSignetDescriptionRenderer.AbilityIDLeaderPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06002599 RID: 9625 RVA: 0x00089A60 File Offset: 0x00087C60
			// (set) Token: 0x0600259A RID: 9626 RVA: 0x00014ECA File Offset: 0x000130CA
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x0600259B RID: 9627 RVA: 0x00089A90 File Offset: 0x00087C90
			// (set) Token: 0x0600259C RID: 9628 RVA: 0x00014EE9 File Offset: 0x000130E9
			public unsafe string leaderName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_leaderName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_leaderName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x0600259D RID: 9629 RVA: 0x00089AB8 File Offset: 0x00087CB8
			// (set) Token: 0x0600259E RID: 9630 RVA: 0x00014F08 File Offset: 0x00013108
			public unsafe bool iconOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_iconOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.AbilityIDLeaderPair.NativeFieldInfoPtr_iconOnly)) = value;
				}
			}

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeFieldInfoPtr_leaderName;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeFieldInfoPtr_iconOnly;
		}

		// Token: 0x020003A6 RID: 934
		[ObfuscatedName("worm.match.dataRenderers.WormSignetDescriptionRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600259F RID: 9631 RVA: 0x00089AE0 File Offset: 0x00087CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr);
				WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr, "<>9");
				WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr, "<>9__5_0");
				WormSignetDescriptionRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr, 100665434);
				WormSignetDescriptionRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr, 100665435);
			}

			// Token: 0x060025A0 RID: 9632 RVA: 0x00089B5C File Offset: 0x00087D5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetDescriptionRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025A1 RID: 9633 RVA: 0x00089B98 File Offset: 0x00087D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708182, XrefRangeEnd = 708189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__5_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetDescriptionRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025A2 RID: 9634 RVA: 0x00014F23 File Offset: 0x00013123
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00089BE8 File Offset: 0x00087DE8
			// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00014F2C File Offset: 0x0001312C
			public unsafe static WormSignetDescriptionRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSignetDescriptionRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00089C10 File Offset: 0x00087E10
			// (set) Token: 0x060025A6 RID: 9638 RVA: 0x00014F3E File Offset: 0x0001313E
			public unsafe static Func<EntityComponent, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSignetDescriptionRenderer.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003A7 RID: 935
		[ObfuscatedName("worm.match.dataRenderers.WormSignetDescriptionRenderer+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060025A7 RID: 9639 RVA: 0x00089C38 File Offset: 0x00087E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSignetDescriptionRenderer>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr);
				WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr, "id");
				WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100665436);
				WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDLeaderPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100665437);
			}

			// Token: 0x060025A8 RID: 9640 RVA: 0x00089CA0 File Offset: 0x00087EA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSignetDescriptionRenderer.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025A9 RID: 9641 RVA: 0x00089CDC File Offset: 0x00087EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708189, XrefRangeEnd = 708193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__1(WormSignetDescriptionRenderer.AbilityIDLeaderPair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDLeaderPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025AA RID: 9642 RVA: 0x00014F50 File Offset: 0x00013150
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x060025AB RID: 9643 RVA: 0x00089D30 File Offset: 0x00087F30
			// (set) Token: 0x060025AC RID: 9644 RVA: 0x00014F59 File Offset: 0x00013159
			public unsafe AbilityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSignetDescriptionRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDLeaderPair_0;
		}
	}
}
