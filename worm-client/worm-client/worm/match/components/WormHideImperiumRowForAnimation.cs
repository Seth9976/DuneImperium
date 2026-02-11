using System;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001FA RID: 506
	public class WormHideImperiumRowForAnimation : MonoBehaviour
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x0005C168 File Offset: 0x0005A368
		// Note: this type is marked as 'beforefieldinit'.
		static WormHideImperiumRowForAnimation()
		{
			Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormHideImperiumRowForAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr);
			WormHideImperiumRowForAnimation.NativeMethodInfoPtr_Event_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr, 100666397);
			WormHideImperiumRowForAnimation.NativeMethodInfoPtr_RestoreAtSelection_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr, 100666398);
			WormHideImperiumRowForAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr, 100666399);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0005C1D4 File Offset: 0x0005A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716451, XrefRangeEnd = 716457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation.NativeMethodInfoPtr_Event_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0005C208 File Offset: 0x0005A408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716457, XrefRangeEnd = 716461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RestoreAtSelection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation.NativeMethodInfoPtr_RestoreAtSelection_Private_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0005C23C File Offset: 0x0005A43C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHideImperiumRowForAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0000D7E6 File Offset: 0x0000B9E6
		public WormHideImperiumRowForAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_Event_Hide_Public_Void_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_RestoreAtSelection_Private_Static_IEnumerator_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F2 RID: 1010
		[ObfuscatedName("worm.match.components.WormHideImperiumRowForAnimation+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600291A RID: 10522 RVA: 0x00094910 File Offset: 0x00092B10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr);
				WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr, "entities");
				WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr, 100666400);
				WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeMethodInfoPtr__RestoreAtSelection_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr, 100666401);
			}

			// Token: 0x0600291B RID: 10523 RVA: 0x00094978 File Offset: 0x00092B78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHideImperiumRowForAnimation.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600291C RID: 10524 RVA: 0x000949B4 File Offset: 0x00092BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716436, XrefRangeEnd = 716437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RestoreAtSelection_b__0(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeMethodInfoPtr__RestoreAtSelection_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600291D RID: 10525 RVA: 0x0001684B File Offset: 0x00014A4B
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x0600291E RID: 10526 RVA: 0x00094A04 File Offset: 0x00092C04
			// (set) Token: 0x0600291F RID: 10527 RVA: 0x00016854 File Offset: 0x00014A54
			public unsafe WormEntities entities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeFieldInfoPtr_entities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation.__c__DisplayClass1_0.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeFieldInfoPtr_entities;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeMethodInfoPtr__RestoreAtSelection_b__0_Internal_Boolean_EntityID_0;
		}

		// Token: 0x020003F3 RID: 1011
		[ObfuscatedName("worm.match.components.WormHideImperiumRowForAnimation+<RestoreAtSelection>d__1")]
		public sealed class _RestoreAtSelection_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002920 RID: 10528 RVA: 0x00094A34 File Offset: 0x00092C34
			// Note: this type is marked as 'beforefieldinit'.
			static _RestoreAtSelection_d__1()
			{
				Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHideImperiumRowForAnimation>.NativeClassPtr, "<RestoreAtSelection>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, "<>1__state");
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, "<>2__current");
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, "<selectionResponder>5__2");
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666402);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666403);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666404);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666405);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666406);
				WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr, 100666407);
			}

			// Token: 0x06002921 RID: 10529 RVA: 0x00094B14 File Offset: 0x00092D14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RestoreAtSelection_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHideImperiumRowForAnimation._RestoreAtSelection_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002922 RID: 10530 RVA: 0x00094B5C File Offset: 0x00092D5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002923 RID: 10531 RVA: 0x00094B90 File Offset: 0x00092D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716437, XrefRangeEnd = 716446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x06002924 RID: 10532 RVA: 0x00094BCC File Offset: 0x00092DCC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002925 RID: 10533 RVA: 0x00094C0C File Offset: 0x00092E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716446, XrefRangeEnd = 716451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06002926 RID: 10534 RVA: 0x00094C40 File Offset: 0x00092E40
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002927 RID: 10535 RVA: 0x00016873 File Offset: 0x00014A73
			public _RestoreAtSelection_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x06002928 RID: 10536 RVA: 0x00094C80 File Offset: 0x00092E80
			// (set) Token: 0x06002929 RID: 10537 RVA: 0x0001687C File Offset: 0x00014A7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x0600292A RID: 10538 RVA: 0x00094CA8 File Offset: 0x00092EA8
			// (set) Token: 0x0600292B RID: 10539 RVA: 0x00016897 File Offset: 0x00014A97
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x0600292C RID: 10540 RVA: 0x00094CD8 File Offset: 0x00092ED8
			// (set) Token: 0x0600292D RID: 10541 RVA: 0x000168B6 File Offset: 0x00014AB6
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideImperiumRowForAnimation._RestoreAtSelection_d__1.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
