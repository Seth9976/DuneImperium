using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000100 RID: 256
	public class WormCanVisitSpaceRenderer : VersionedView<IAttribute<List<EntityID>>>
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x0003ABA0 File Offset: 0x00038DA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormCanVisitSpaceRenderer()
		{
			Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCanVisitSpaceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr);
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "blocker");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_secondaryBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "secondaryBlocker");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_currentTurnAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "currentTurnAttribute");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_tutorialDisabledAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "tutorialDisabledAttribute");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "selectionResponder");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "entitiesProvider");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_spaceView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "spaceView");
			WormCanVisitSpaceRenderer.NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "locked");
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664871);
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664872);
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664873);
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664874);
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664875);
			WormCanVisitSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, 100664876);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703153, XrefRangeEnd = 703167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCanVisitSpaceRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0003AD30 File Offset: 0x00038F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703167, XrefRangeEnd = 703176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCanVisitSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0003AD6C File Offset: 0x00038F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703176, XrefRangeEnd = 703181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0003ADAC File Offset: 0x00038FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703181, XrefRangeEnd = 703270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCanVisitSpaceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0003ADE8 File Offset: 0x00038FE8
		[CallerCount(0)]
		public unsafe void SetLock(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer.NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003AE28 File Offset: 0x00039028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703270, XrefRangeEnd = 703273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCanVisitSpaceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0000804E File Offset: 0x0000624E
		public WormCanVisitSpaceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0003AE64 File Offset: 0x00039064
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00008057 File Offset: 0x00006257
		public unsafe GameObject blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0003AE94 File Offset: 0x00039094
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00008076 File Offset: 0x00006276
		public unsafe GameObject secondaryBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_secondaryBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_secondaryBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003AEC4 File Offset: 0x000390C4
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00008095 File Offset: 0x00006295
		public unsafe IAttribute<AccountID> currentTurnAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_currentTurnAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_currentTurnAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003AEF4 File Offset: 0x000390F4
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000080B4 File Offset: 0x000062B4
		public unsafe IAttribute<List<string>> tutorialDisabledAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_tutorialDisabledAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_tutorialDisabledAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003AF24 File Offset: 0x00039124
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000080D3 File Offset: 0x000062D3
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003AF54 File Offset: 0x00039154
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x000080F2 File Offset: 0x000062F2
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0003AF84 File Offset: 0x00039184
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00008111 File Offset: 0x00006311
		public unsafe EntityView spaceView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_spaceView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_spaceView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0003AFB4 File Offset: 0x000391B4
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00008130 File Offset: 0x00006330
		public unsafe bool locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer.NativeFieldInfoPtr_locked)) = value;
			}
		}

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_secondaryBlocker;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_currentTurnAttribute;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_tutorialDisabledAttribute;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_spaceView;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_locked;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("worm.match.dataRenderers.WormCanVisitSpaceRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002304 RID: 8964 RVA: 0x000826FC File Offset: 0x000808FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr);
				WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr, "<>9");
				WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr, "<>9__12_0");
				WormCanVisitSpaceRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr, 100664878);
				WormCanVisitSpaceRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__12_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr, 100664879);
			}

			// Token: 0x06002305 RID: 8965 RVA: 0x00082778 File Offset: 0x00080978
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanVisitSpaceRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x000827B4 File Offset: 0x000809B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703128, XrefRangeEnd = 703135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__12_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__12_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x0001394E File Offset: 0x00011B4E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x06002308 RID: 8968 RVA: 0x00082804 File Offset: 0x00080A04
			// (set) Token: 0x06002309 RID: 8969 RVA: 0x00013957 File Offset: 0x00011B57
			public unsafe static WormCanVisitSpaceRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCanVisitSpaceRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x0600230A RID: 8970 RVA: 0x0008282C File Offset: 0x00080A2C
			// (set) Token: 0x0600230B RID: 8971 RVA: 0x00013969 File Offset: 0x00011B69
			public unsafe static Func<EntityComponent, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormCanVisitSpaceRenderer.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001420 RID: 5152
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001421 RID: 5153
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001422 RID: 5154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001423 RID: 5155
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__12_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("worm.match.dataRenderers.WormCanVisitSpaceRenderer+<Init>d__11")]
		public sealed class _Init_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x0600230C RID: 8972 RVA: 0x00082854 File Offset: 0x00080A54
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__11()
			{
				Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCanVisitSpaceRenderer>.NativeClassPtr, "<Init>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr);
				WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, "<>1__state");
				WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, "<>2__current");
				WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, "<>4__this");
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664880);
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664881);
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664882);
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664883);
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664884);
				WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr, 100664885);
			}

			// Token: 0x0600230D RID: 8973 RVA: 0x00082934 File Offset: 0x00080B34
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanVisitSpaceRenderer._Init_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600230E RID: 8974 RVA: 0x0008297C File Offset: 0x00080B7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600230F RID: 8975 RVA: 0x000829B0 File Offset: 0x00080BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703135, XrefRangeEnd = 703148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x06002310 RID: 8976 RVA: 0x000829EC File Offset: 0x00080BEC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002311 RID: 8977 RVA: 0x00082A2C File Offset: 0x00080C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703148, XrefRangeEnd = 703153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x06002312 RID: 8978 RVA: 0x00082A60 File Offset: 0x00080C60
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanVisitSpaceRenderer._Init_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002313 RID: 8979 RVA: 0x0001397B File Offset: 0x00011B7B
			public _Init_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x06002314 RID: 8980 RVA: 0x00082AA0 File Offset: 0x00080CA0
			// (set) Token: 0x06002315 RID: 8981 RVA: 0x00013984 File Offset: 0x00011B84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x06002316 RID: 8982 RVA: 0x00082AC8 File Offset: 0x00080CC8
			// (set) Token: 0x06002317 RID: 8983 RVA: 0x0001399F File Offset: 0x00011B9F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x06002318 RID: 8984 RVA: 0x00082AF8 File Offset: 0x00080CF8
			// (set) Token: 0x06002319 RID: 8985 RVA: 0x000139BE File Offset: 0x00011BBE
			public unsafe WormCanVisitSpaceRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCanVisitSpaceRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanVisitSpaceRenderer._Init_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001424 RID: 5156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001425 RID: 5157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001426 RID: 5158
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001427 RID: 5159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001428 RID: 5160
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001429 RID: 5161
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400142A RID: 5162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400142B RID: 5163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400142C RID: 5164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
