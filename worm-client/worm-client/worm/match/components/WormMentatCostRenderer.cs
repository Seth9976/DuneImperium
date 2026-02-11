using System;
using boardgames.match.behaviours;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000205 RID: 517
	public class WormMentatCostRenderer : MonoBehaviour
	{
		// Token: 0x060016DF RID: 5855 RVA: 0x0005D7C4 File Offset: 0x0005B9C4
		// Note: this type is marked as 'beforefieldinit'.
		static WormMentatCostRenderer()
		{
			Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormMentatCostRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr);
			WormMentatCostRenderer.NativeFieldInfoPtr_normalCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, "normalCost");
			WormMentatCostRenderer.NativeFieldInfoPtr_skirmishCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, "skirmishCost");
			WormMentatCostRenderer.NativeFieldInfoPtr_tooltipSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, "tooltipSource");
			WormMentatCostRenderer.NativeFieldInfoPtr_mentatRuleMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, "mentatRuleMod");
			WormMentatCostRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, 100666473);
			WormMentatCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, 100666474);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0005D86C File Offset: 0x0005BA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716964, XrefRangeEnd = 716969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716969, XrefRangeEnd = 716970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMentatCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0000DBC1 File Offset: 0x0000BDC1
		public WormMentatCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0000DBCA File Offset: 0x0000BDCA
		public unsafe GameObject normalCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_normalCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_normalCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0005D918 File Offset: 0x0005BB18
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x0000DBE9 File Offset: 0x0000BDE9
		public unsafe GameObject skirmishCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_skirmishCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_skirmishCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0005D948 File Offset: 0x0005BB48
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000DC08 File Offset: 0x0000BE08
		public unsafe WormSolariCostTooltipSource tooltipSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_tooltipSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSolariCostTooltipSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_tooltipSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0005D978 File Offset: 0x0005BB78
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000DC27 File Offset: 0x0000BE27
		public unsafe int mentatRuleMod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_mentatRuleMod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer.NativeFieldInfoPtr_mentatRuleMod)) = value;
			}
		}

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeFieldInfoPtr_normalCost;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_skirmishCost;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_tooltipSource;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_mentatRuleMod;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F8 RID: 1016
		[ObfuscatedName("worm.match.components.WormMentatCostRenderer+<Start>d__4")]
		public sealed class _Start_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600296C RID: 10604 RVA: 0x00095924 File Offset: 0x00093B24
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMentatCostRenderer>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr);
				WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, "<>1__state");
				WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, "<>2__current");
				WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, "<>4__this");
				WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, "<matchHub>5__2");
				WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__entitiesProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, "<entitiesProvider>5__3");
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666475);
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666476);
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666477);
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666478);
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666479);
				WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr, 100666480);
			}

			// Token: 0x0600296D RID: 10605 RVA: 0x00095A2C File Offset: 0x00093C2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatCostRenderer._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600296E RID: 10606 RVA: 0x00095A74 File Offset: 0x00093C74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600296F RID: 10607 RVA: 0x00095AA8 File Offset: 0x00093CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716948, XrefRangeEnd = 716959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002970 RID: 10608 RVA: 0x00095AE4 File Offset: 0x00093CE4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002971 RID: 10609 RVA: 0x00095B24 File Offset: 0x00093D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716959, XrefRangeEnd = 716964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x06002972 RID: 10610 RVA: 0x00095B58 File Offset: 0x00093D58
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatCostRenderer._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002973 RID: 10611 RVA: 0x00016ABA File Offset: 0x00014CBA
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x06002974 RID: 10612 RVA: 0x00095B98 File Offset: 0x00093D98
			// (set) Token: 0x06002975 RID: 10613 RVA: 0x00016AC3 File Offset: 0x00014CC3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002976 RID: 10614 RVA: 0x00095BC0 File Offset: 0x00093DC0
			// (set) Token: 0x06002977 RID: 10615 RVA: 0x00016ADE File Offset: 0x00014CDE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002978 RID: 10616 RVA: 0x00095BF0 File Offset: 0x00093DF0
			// (set) Token: 0x06002979 RID: 10617 RVA: 0x00016AFD File Offset: 0x00014CFD
			public unsafe WormMentatCostRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMentatCostRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x0600297A RID: 10618 RVA: 0x00095C20 File Offset: 0x00093E20
			// (set) Token: 0x0600297B RID: 10619 RVA: 0x00016B1C File Offset: 0x00014D1C
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x0600297C RID: 10620 RVA: 0x00095C50 File Offset: 0x00093E50
			// (set) Token: 0x0600297D RID: 10621 RVA: 0x00016B3B File Offset: 0x00014D3B
			public unsafe EntitiesProvider _entitiesProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__entitiesProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatCostRenderer._Start_d__4.NativeFieldInfoPtr__entitiesProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__3;

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
