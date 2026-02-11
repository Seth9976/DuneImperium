using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F6 RID: 502
	public class WormGarrisonTroopTooltipSource : MonoBehaviour
	{
		// Token: 0x06001635 RID: 5685 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		// Note: this type is marked as 'beforefieldinit'.
		static WormGarrisonTroopTooltipSource()
		{
			Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormGarrisonTroopTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr);
			WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, "locKey");
			WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_playerSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, "playerSupply");
			WormGarrisonTroopTooltipSource.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, 100666367);
			WormGarrisonTroopTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, 100666368);
			WormGarrisonTroopTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, 100666369);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0005B98C File Offset: 0x00059B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716216, XrefRangeEnd = 716221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0005B9CC File Offset: 0x00059BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716221, XrefRangeEnd = 716251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0005BA04 File Offset: 0x00059C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716251, XrefRangeEnd = 716256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGarrisonTroopTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0000D644 File Offset: 0x0000B844
		public WormGarrisonTroopTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x0005BA40 File Offset: 0x00059C40
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x0000D64D File Offset: 0x0000B84D
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0005BA68 File Offset: 0x00059C68
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x0000D66C File Offset: 0x0000B86C
		public unsafe EntityComponent playerSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_playerSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource.NativeFieldInfoPtr_playerSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeFieldInfoPtr_playerSupply;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EF RID: 1007
		[ObfuscatedName("worm.match.components.WormGarrisonTroopTooltipSource+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060028F0 RID: 10480 RVA: 0x00094144 File Offset: 0x00092344
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr);
				WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr, "<>9");
				WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr, "<>9__3_0");
				WormGarrisonTroopTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr, 100666371);
				WormGarrisonTroopTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__3_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr, 100666372);
			}

			// Token: 0x060028F1 RID: 10481 RVA: 0x000941C0 File Offset: 0x000923C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028F2 RID: 10482 RVA: 0x000941FC File Offset: 0x000923FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716189, XrefRangeEnd = 716196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLocalizedTooltip_b__3_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__3_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028F3 RID: 10483 RVA: 0x000166FD File Offset: 0x000148FD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x060028F4 RID: 10484 RVA: 0x0009424C File Offset: 0x0009244C
			// (set) Token: 0x060028F5 RID: 10485 RVA: 0x00016706 File Offset: 0x00014906
			public unsafe static WormGarrisonTroopTooltipSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGarrisonTroopTooltipSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x060028F6 RID: 10486 RVA: 0x00094274 File Offset: 0x00092474
			// (set) Token: 0x060028F7 RID: 10487 RVA: 0x00016718 File Offset: 0x00014918
			public unsafe static Func<EntityComponent, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGarrisonTroopTooltipSource.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeMethodInfoPtr__GetLocalizedTooltip_b__3_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003F0 RID: 1008
		[ObfuscatedName("worm.match.components.WormGarrisonTroopTooltipSource+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x060028F8 RID: 10488 RVA: 0x0009429C File Offset: 0x0009249C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, "<>1__state");
				WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, "<>2__current");
				WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, "<>4__this");
				WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__parentView_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, "<parentView>5__3");
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666373);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666374);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666375);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666376);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666377);
				WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr, 100666378);
			}

			// Token: 0x060028F9 RID: 10489 RVA: 0x000943A4 File Offset: 0x000925A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonTroopTooltipSource._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028FA RID: 10490 RVA: 0x000943EC File Offset: 0x000925EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028FB RID: 10491 RVA: 0x00094420 File Offset: 0x00092620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716196, XrefRangeEnd = 716211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x060028FC RID: 10492 RVA: 0x0009445C File Offset: 0x0009265C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028FD RID: 10493 RVA: 0x0009449C File Offset: 0x0009269C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716211, XrefRangeEnd = 716216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x060028FE RID: 10494 RVA: 0x000944D0 File Offset: 0x000926D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonTroopTooltipSource._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028FF RID: 10495 RVA: 0x0001672A File Offset: 0x0001492A
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06002900 RID: 10496 RVA: 0x00094510 File Offset: 0x00092710
			// (set) Token: 0x06002901 RID: 10497 RVA: 0x00016733 File Offset: 0x00014933
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06002902 RID: 10498 RVA: 0x00094538 File Offset: 0x00092738
			// (set) Token: 0x06002903 RID: 10499 RVA: 0x0001674E File Offset: 0x0001494E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06002904 RID: 10500 RVA: 0x00094568 File Offset: 0x00092768
			// (set) Token: 0x06002905 RID: 10501 RVA: 0x0001676D File Offset: 0x0001496D
			public unsafe WormGarrisonTroopTooltipSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGarrisonTroopTooltipSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06002906 RID: 10502 RVA: 0x00094598 File Offset: 0x00092798
			// (set) Token: 0x06002907 RID: 10503 RVA: 0x0001678C File Offset: 0x0001498C
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06002908 RID: 10504 RVA: 0x000945C8 File Offset: 0x000927C8
			// (set) Token: 0x06002909 RID: 10505 RVA: 0x000167AB File Offset: 0x000149AB
			public unsafe EntityView _parentView_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__parentView_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonTroopTooltipSource._Start_d__2.NativeFieldInfoPtr__parentView_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeFieldInfoPtr__parentView_5__3;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
