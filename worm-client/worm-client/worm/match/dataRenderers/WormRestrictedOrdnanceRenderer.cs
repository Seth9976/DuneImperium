using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015B RID: 347
	public class WormRestrictedOrdnanceRenderer : VersionedView<WormRestrictedOrdnanceData>
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x00046AB8 File Offset: 0x00044CB8
		// Note: this type is marked as 'beforefieldinit'.
		static WormRestrictedOrdnanceRenderer()
		{
			Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormRestrictedOrdnanceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr);
			WormRestrictedOrdnanceRenderer.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, "icon");
			WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, 100665388);
			WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, 100665389);
			WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, 100665390);
			WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, 100665391);
			WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr___n__0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, 100665392);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00046B60 File Offset: 0x00044D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707890, XrefRangeEnd = 707896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00046B9C File Offset: 0x00044D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707896, XrefRangeEnd = 707901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00046BDC File Offset: 0x00044DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707901, XrefRangeEnd = 707912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00046C18 File Offset: 0x00044E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707912, XrefRangeEnd = 707915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRestrictedOrdnanceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00046C54 File Offset: 0x00044E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707915, XrefRangeEnd = 707918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer.NativeMethodInfoPtr___n__0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0000A2E8 File Offset: 0x000084E8
		public WormRestrictedOrdnanceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00046C88 File Offset: 0x00044E88
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0000A2F1 File Offset: 0x000084F1
		public unsafe GameObject icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Void_0;

		// Token: 0x020003A0 RID: 928
		[ObfuscatedName("worm.match.dataRenderers.WormRestrictedOrdnanceRenderer+<Init>d__2")]
		public sealed class _Init_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x0600255C RID: 9564 RVA: 0x00088F74 File Offset: 0x00087174
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__2()
			{
				Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer>.NativeClassPtr, "<Init>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, "<>1__state");
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, "<>2__current");
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, "<>4__this");
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__parent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, "<parent>5__3");
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665393);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665394);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665395);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665396);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665397);
				WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr, 100665398);
			}

			// Token: 0x0600255D RID: 9565 RVA: 0x0008907C File Offset: 0x0008727C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRestrictedOrdnanceRenderer._Init_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600255E RID: 9566 RVA: 0x000890C4 File Offset: 0x000872C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600255F RID: 9567 RVA: 0x000890F8 File Offset: 0x000872F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707875, XrefRangeEnd = 707885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06002560 RID: 9568 RVA: 0x00089134 File Offset: 0x00087334
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002561 RID: 9569 RVA: 0x00089174 File Offset: 0x00087374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707885, XrefRangeEnd = 707890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06002562 RID: 9570 RVA: 0x000891A8 File Offset: 0x000873A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRestrictedOrdnanceRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002563 RID: 9571 RVA: 0x00014CF1 File Offset: 0x00012EF1
			public _Init_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06002564 RID: 9572 RVA: 0x000891E8 File Offset: 0x000873E8
			// (set) Token: 0x06002565 RID: 9573 RVA: 0x00014CFA File Offset: 0x00012EFA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06002566 RID: 9574 RVA: 0x00089210 File Offset: 0x00087410
			// (set) Token: 0x06002567 RID: 9575 RVA: 0x00014D15 File Offset: 0x00012F15
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06002568 RID: 9576 RVA: 0x00089240 File Offset: 0x00087440
			// (set) Token: 0x06002569 RID: 9577 RVA: 0x00014D34 File Offset: 0x00012F34
			public unsafe WormRestrictedOrdnanceRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRestrictedOrdnanceRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x0600256A RID: 9578 RVA: 0x00089270 File Offset: 0x00087470
			// (set) Token: 0x0600256B RID: 9579 RVA: 0x00014D53 File Offset: 0x00012F53
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x0600256C RID: 9580 RVA: 0x000892A0 File Offset: 0x000874A0
			// (set) Token: 0x0600256D RID: 9581 RVA: 0x00014D72 File Offset: 0x00012F72
			public unsafe EntityView _parent_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__parent_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRestrictedOrdnanceRenderer._Init_d__2.NativeFieldInfoPtr__parent_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001573 RID: 5491
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001574 RID: 5492
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001575 RID: 5493
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__3;

			// Token: 0x04001576 RID: 5494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001577 RID: 5495
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
