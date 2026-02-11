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
	// Token: 0x020001F5 RID: 501
	public class WormGarrisonDreadnoughtTooltipSource : MonoBehaviour
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x0005B794 File Offset: 0x00059994
		// Note: this type is marked as 'beforefieldinit'.
		static WormGarrisonDreadnoughtTooltipSource()
		{
			Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormGarrisonDreadnoughtTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr);
			WormGarrisonDreadnoughtTooltipSource.NativeFieldInfoPtr_playerSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, "playerSupply");
			WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, 100666355);
			WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, 100666356);
			WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, 100666357);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0005B814 File Offset: 0x00059A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716152, XrefRangeEnd = 716157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0005B854 File Offset: 0x00059A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716157, XrefRangeEnd = 716189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0005B88C File Offset: 0x00059A8C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGarrisonDreadnoughtTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0000D61C File Offset: 0x0000B81C
		public WormGarrisonDreadnoughtTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0005B8C8 File Offset: 0x00059AC8
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0000D625 File Offset: 0x0000B825
		public unsafe EntityComponent playerSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource.NativeFieldInfoPtr_playerSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource.NativeFieldInfoPtr_playerSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr_playerSupply;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003ED RID: 1005
		[ObfuscatedName("worm.match.components.WormGarrisonDreadnoughtTooltipSource+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060028D6 RID: 10454 RVA: 0x00093C90 File Offset: 0x00091E90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr);
				WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr, "<>9");
				WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr, "<>9__2_0");
				WormGarrisonDreadnoughtTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr, 100666359);
				WormGarrisonDreadnoughtTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr, 100666360);
			}

			// Token: 0x060028D7 RID: 10455 RVA: 0x00093D0C File Offset: 0x00091F0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028D8 RID: 10456 RVA: 0x00093D48 File Offset: 0x00091F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716130, XrefRangeEnd = 716137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLocalizedTooltip_b__2_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028D9 RID: 10457 RVA: 0x00016630 File Offset: 0x00014830
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x060028DA RID: 10458 RVA: 0x00093D98 File Offset: 0x00091F98
			// (set) Token: 0x060028DB RID: 10459 RVA: 0x00016639 File Offset: 0x00014839
			public unsafe static WormGarrisonDreadnoughtTooltipSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGarrisonDreadnoughtTooltipSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x060028DC RID: 10460 RVA: 0x00093DC0 File Offset: 0x00091FC0
			// (set) Token: 0x060028DD RID: 10461 RVA: 0x0001664B File Offset: 0x0001484B
			public unsafe static Func<EntityComponent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGarrisonDreadnoughtTooltipSource.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003EE RID: 1006
		[ObfuscatedName("worm.match.components.WormGarrisonDreadnoughtTooltipSource+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x060028DE RID: 10462 RVA: 0x00093DE8 File Offset: 0x00091FE8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, "<>1__state");
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, "<>2__current");
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, "<>4__this");
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, "<entitiesProvider>5__2");
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__parentView_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, "<parentView>5__3");
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666361);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666362);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666363);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666364);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666365);
				WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr, 100666366);
			}

			// Token: 0x060028DF RID: 10463 RVA: 0x00093EF0 File Offset: 0x000920F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGarrisonDreadnoughtTooltipSource._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028E0 RID: 10464 RVA: 0x00093F38 File Offset: 0x00092138
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028E1 RID: 10465 RVA: 0x00093F6C File Offset: 0x0009216C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716137, XrefRangeEnd = 716147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00093FA8 File Offset: 0x000921A8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028E3 RID: 10467 RVA: 0x00093FE8 File Offset: 0x000921E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716147, XrefRangeEnd = 716152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0009401C File Offset: 0x0009221C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028E5 RID: 10469 RVA: 0x0001665D File Offset: 0x0001485D
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x060028E6 RID: 10470 RVA: 0x0009405C File Offset: 0x0009225C
			// (set) Token: 0x060028E7 RID: 10471 RVA: 0x00016666 File Offset: 0x00014866
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x060028E8 RID: 10472 RVA: 0x00094084 File Offset: 0x00092284
			// (set) Token: 0x060028E9 RID: 10473 RVA: 0x00016681 File Offset: 0x00014881
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x060028EA RID: 10474 RVA: 0x000940B4 File Offset: 0x000922B4
			// (set) Token: 0x060028EB RID: 10475 RVA: 0x000166A0 File Offset: 0x000148A0
			public unsafe WormGarrisonDreadnoughtTooltipSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGarrisonDreadnoughtTooltipSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x060028EC RID: 10476 RVA: 0x000940E4 File Offset: 0x000922E4
			// (set) Token: 0x060028ED RID: 10477 RVA: 0x000166BF File Offset: 0x000148BF
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x060028EE RID: 10478 RVA: 0x00094114 File Offset: 0x00092314
			// (set) Token: 0x060028EF RID: 10479 RVA: 0x000166DE File Offset: 0x000148DE
			public unsafe EntityView _parentView_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__parentView_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGarrisonDreadnoughtTooltipSource._Start_d__1.NativeFieldInfoPtr__parentView_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeFieldInfoPtr__parentView_5__3;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
