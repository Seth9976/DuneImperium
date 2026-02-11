using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F9 RID: 505
	public class WormHelenaReserveDarkener : MonoBehaviour
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x0005BF88 File Offset: 0x0005A188
		// Note: this type is marked as 'beforefieldinit'.
		static WormHelenaReserveDarkener()
		{
			Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormHelenaReserveDarkener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr);
			WormHelenaReserveDarkener.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, "animator");
			WormHelenaReserveDarkener.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, "entities");
			WormHelenaReserveDarkener.NativeFieldInfoPtr_DarkenParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, "DarkenParam");
			WormHelenaReserveDarkener.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, 100666387);
			WormHelenaReserveDarkener.NativeMethodInfoPtr_OnInHelenaReserve_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, 100666388);
			WormHelenaReserveDarkener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, 100666389);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0005C030 File Offset: 0x0005A230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716404, XrefRangeEnd = 716409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0005C070 File Offset: 0x0005A270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716409, XrefRangeEnd = 716436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInHelenaReserve(bool inReserve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inReserve;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener.NativeMethodInfoPtr_OnInHelenaReserve_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0005C0B0 File Offset: 0x0005A2B0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHelenaReserveDarkener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0000D791 File Offset: 0x0000B991
		public WormHelenaReserveDarkener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000D79A File Offset: 0x0000B99A
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x0005C11C File Offset: 0x0005A31C
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x0000D7B9 File Offset: 0x0000B9B9
		public unsafe WormEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x0005C14C File Offset: 0x0005A34C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		public unsafe static int DarkenParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormHelenaReserveDarkener.NativeFieldInfoPtr_DarkenParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormHelenaReserveDarkener.NativeFieldInfoPtr_DarkenParam, (void*)(&value));
			}
		}

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_DarkenParam;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_OnInHelenaReserve_Public_Void_Boolean_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F1 RID: 1009
		[ObfuscatedName("worm.match.components.WormHelenaReserveDarkener+<Start>d__3")]
		public sealed class _Start_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x0600290A RID: 10506 RVA: 0x000945F8 File Offset: 0x000927F8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__3()
			{
				Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHelenaReserveDarkener>.NativeClassPtr, "<Start>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr);
				WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, "<>1__state");
				WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, "<>2__current");
				WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, "<>4__this");
				WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, "<entitiesProvider>5__2");
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666391);
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666392);
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666393);
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666394);
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666395);
				WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr, 100666396);
			}

			// Token: 0x0600290B RID: 10507 RVA: 0x000946EC File Offset: 0x000928EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHelenaReserveDarkener._Start_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600290C RID: 10508 RVA: 0x00094734 File Offset: 0x00092934
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600290D RID: 10509 RVA: 0x00094768 File Offset: 0x00092968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716388, XrefRangeEnd = 716399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x0600290E RID: 10510 RVA: 0x000947A4 File Offset: 0x000929A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600290F RID: 10511 RVA: 0x000947E4 File Offset: 0x000929E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716399, XrefRangeEnd = 716404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06002910 RID: 10512 RVA: 0x00094818 File Offset: 0x00092A18
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHelenaReserveDarkener._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002911 RID: 10513 RVA: 0x000167CA File Offset: 0x000149CA
			public _Start_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06002912 RID: 10514 RVA: 0x00094858 File Offset: 0x00092A58
			// (set) Token: 0x06002913 RID: 10515 RVA: 0x000167D3 File Offset: 0x000149D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06002914 RID: 10516 RVA: 0x00094880 File Offset: 0x00092A80
			// (set) Token: 0x06002915 RID: 10517 RVA: 0x000167EE File Offset: 0x000149EE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x06002916 RID: 10518 RVA: 0x000948B0 File Offset: 0x00092AB0
			// (set) Token: 0x06002917 RID: 10519 RVA: 0x0001680D File Offset: 0x00014A0D
			public unsafe WormHelenaReserveDarkener __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHelenaReserveDarkener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x06002918 RID: 10520 RVA: 0x000948E0 File Offset: 0x00092AE0
			// (set) Token: 0x06002919 RID: 10521 RVA: 0x0001682C File Offset: 0x00014A2C
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHelenaReserveDarkener._Start_d__3.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
