using System;
using boardgames.match;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013C RID: 316
	public class WormHighCouncilRenderer : VersionedView<WormBonusPersuasionData>
	{
		// Token: 0x06000E31 RID: 3633 RVA: 0x00042EF8 File Offset: 0x000410F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormHighCouncilRenderer()
		{
			Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHighCouncilRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr);
			WormHighCouncilRenderer.NativeFieldInfoPtr_Occupied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "Occupied");
			WormHighCouncilRenderer.NativeFieldInfoPtr_PersuasionFXParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "PersuasionFXParam");
			WormHighCouncilRenderer.NativeFieldInfoPtr_seatAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "seatAnimators");
			WormHighCouncilRenderer.NativeFieldInfoPtr_playerViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "playerViews");
			WormHighCouncilRenderer.NativeFieldInfoPtr_persuasionFXAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "persuasionFXAnimator");
			WormHighCouncilRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "entities");
			WormHighCouncilRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, 100665221);
			WormHighCouncilRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, 100665222);
			WormHighCouncilRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, 100665223);
			WormHighCouncilRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, 100665224);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00042FF0 File Offset: 0x000411F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706337, XrefRangeEnd = 706355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHighCouncilRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0004302C File Offset: 0x0004122C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706355, XrefRangeEnd = 706360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0004306C File Offset: 0x0004126C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706360, XrefRangeEnd = 706400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHighCouncilRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000430A8 File Offset: 0x000412A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706400, XrefRangeEnd = 706417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHighCouncilRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0000976F File Offset: 0x0000796F
		public WormHighCouncilRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000430E4 File Offset: 0x000412E4
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00009778 File Offset: 0x00007978
		public unsafe static int Occupied
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormHighCouncilRenderer.NativeFieldInfoPtr_Occupied, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormHighCouncilRenderer.NativeFieldInfoPtr_Occupied, (void*)(&value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00043100 File Offset: 0x00041300
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00009786 File Offset: 0x00007986
		public unsafe static int PersuasionFXParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormHighCouncilRenderer.NativeFieldInfoPtr_PersuasionFXParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormHighCouncilRenderer.NativeFieldInfoPtr_PersuasionFXParam, (void*)(&value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0004311C File Offset: 0x0004131C
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00009794 File Offset: 0x00007994
		public unsafe List<Animator> seatAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_seatAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_seatAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0004314C File Offset: 0x0004134C
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x000097B3 File Offset: 0x000079B3
		public unsafe List<EntityView> playerViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_playerViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_playerViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0004317C File Offset: 0x0004137C
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000097D2 File Offset: 0x000079D2
		public unsafe Animator persuasionFXAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_persuasionFXAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_persuasionFXAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000431AC File Offset: 0x000413AC
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000097F1 File Offset: 0x000079F1
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_Occupied;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_PersuasionFXParam;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_seatAnimators;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_playerViews;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_persuasionFXAnimator;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038E RID: 910
		[ObfuscatedName("worm.match.dataRenderers.WormHighCouncilRenderer+<Init>d__7")]
		public sealed class _Init_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002491 RID: 9361 RVA: 0x00086B28 File Offset: 0x00084D28
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__7()
			{
				Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHighCouncilRenderer>.NativeClassPtr, "<Init>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr);
				WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, "<>1__state");
				WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, "<>2__current");
				WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, "<>4__this");
				WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, "<entitiesProvider>5__2");
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665226);
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665227);
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665228);
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665229);
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665230);
				WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr, 100665231);
			}

			// Token: 0x06002492 RID: 9362 RVA: 0x00086C1C File Offset: 0x00084E1C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHighCouncilRenderer._Init_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x00086C64 File Offset: 0x00084E64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x00086C98 File Offset: 0x00084E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706325, XrefRangeEnd = 706332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06002495 RID: 9365 RVA: 0x00086CD4 File Offset: 0x00084ED4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002496 RID: 9366 RVA: 0x00086D14 File Offset: 0x00084F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706332, XrefRangeEnd = 706337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06002497 RID: 9367 RVA: 0x00086D48 File Offset: 0x00084F48
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighCouncilRenderer._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002498 RID: 9368 RVA: 0x0001466B File Offset: 0x0001286B
			public _Init_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06002499 RID: 9369 RVA: 0x00086D88 File Offset: 0x00084F88
			// (set) Token: 0x0600249A RID: 9370 RVA: 0x00014674 File Offset: 0x00012874
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x0600249B RID: 9371 RVA: 0x00086DB0 File Offset: 0x00084FB0
			// (set) Token: 0x0600249C RID: 9372 RVA: 0x0001468F File Offset: 0x0001288F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x0600249D RID: 9373 RVA: 0x00086DE0 File Offset: 0x00084FE0
			// (set) Token: 0x0600249E RID: 9374 RVA: 0x000146AE File Offset: 0x000128AE
			public unsafe WormHighCouncilRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHighCouncilRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x0600249F RID: 9375 RVA: 0x00086E10 File Offset: 0x00085010
			// (set) Token: 0x060024A0 RID: 9376 RVA: 0x000146CD File Offset: 0x000128CD
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighCouncilRenderer._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001502 RID: 5378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001503 RID: 5379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001504 RID: 5380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
