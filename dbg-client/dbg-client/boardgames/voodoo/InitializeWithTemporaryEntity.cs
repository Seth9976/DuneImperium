using System;
using boardgames.match;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace boardgames.voodoo
{
	// Token: 0x020000EB RID: 235
	public class InitializeWithTemporaryEntity : MonoBehaviour
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x0003D844 File Offset: 0x0003BA44
		// Note: this type is marked as 'beforefieldinit'.
		static InitializeWithTemporaryEntity()
		{
			Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.voodoo", "InitializeWithTemporaryEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr);
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "view");
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_optionalParentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "optionalParentView");
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "temporaryEntityName");
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_viewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "viewLayer");
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "temporaryEntity");
			InitializeWithTemporaryEntity.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "entities");
			InitializeWithTemporaryEntity.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, 100664771);
			InitializeWithTemporaryEntity.NativeMethodInfoPtr_createTempEntity_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, 100664772);
			InitializeWithTemporaryEntity.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, 100664773);
			InitializeWithTemporaryEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, 100664774);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0003D93C File Offset: 0x0003BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506649, XrefRangeEnd = 506655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0003D970 File Offset: 0x0003BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506655, XrefRangeEnd = 506660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator createTempEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity.NativeMethodInfoPtr_createTempEntity_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506660, XrefRangeEnd = 506661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506661, XrefRangeEnd = 506666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializeWithTemporaryEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00006DDE File Offset: 0x00004FDE
		public InitializeWithTemporaryEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0003DA20 File Offset: 0x0003BC20
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00006DE7 File Offset: 0x00004FE7
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0003DA50 File Offset: 0x0003BC50
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00006E06 File Offset: 0x00005006
		public unsafe EntityView optionalParentView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_optionalParentView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_optionalParentView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0003DA80 File Offset: 0x0003BC80
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00006E25 File Offset: 0x00005025
		public unsafe string temporaryEntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00006E44 File Offset: 0x00005044
		public unsafe int viewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_viewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_viewLayer)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00006E5F File Offset: 0x0000505F
		public unsafe EntityComponent temporaryEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_temporaryEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003DB00 File Offset: 0x0003BD00
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00006E7E File Offset: 0x0000507E
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_optionalParentView;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_temporaryEntityName;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_viewLayer;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_temporaryEntity;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_createTempEntity_Private_IEnumerator_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("boardgames.voodoo.InitializeWithTemporaryEntity+<createTempEntity>d__7")]
		public sealed class _createTempEntity_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060026D6 RID: 9942 RVA: 0x0009CB4C File Offset: 0x0009AD4C
			// Note: this type is marked as 'beforefieldinit'.
			static _createTempEntity_d__7()
			{
				Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeWithTemporaryEntity>.NativeClassPtr, "<createTempEntity>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, "<>1__state");
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, "<>2__current");
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, "<>4__this");
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, "<entitiesProvider>5__2");
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664775);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664776);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664777);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664778);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664779);
				InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr, 100664780);
			}

			// Token: 0x060026D7 RID: 9943 RVA: 0x0009CC40 File Offset: 0x0009AE40
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _createTempEntity_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeWithTemporaryEntity._createTempEntity_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026D8 RID: 9944 RVA: 0x0009CC88 File Offset: 0x0009AE88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026D9 RID: 9945 RVA: 0x0009CCBC File Offset: 0x0009AEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506638, XrefRangeEnd = 506644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x060026DA RID: 9946 RVA: 0x0009CCF8 File Offset: 0x0009AEF8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026DB RID: 9947 RVA: 0x0009CD38 File Offset: 0x0009AF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506644, XrefRangeEnd = 506649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x060026DC RID: 9948 RVA: 0x0009CD6C File Offset: 0x0009AF6C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026DD RID: 9949 RVA: 0x000141DA File Offset: 0x000123DA
			public _createTempEntity_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x060026DE RID: 9950 RVA: 0x0009CDAC File Offset: 0x0009AFAC
			// (set) Token: 0x060026DF RID: 9951 RVA: 0x000141E3 File Offset: 0x000123E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x060026E0 RID: 9952 RVA: 0x0009CDD4 File Offset: 0x0009AFD4
			// (set) Token: 0x060026E1 RID: 9953 RVA: 0x000141FE File Offset: 0x000123FE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x060026E2 RID: 9954 RVA: 0x0009CE04 File Offset: 0x0009B004
			// (set) Token: 0x060026E3 RID: 9955 RVA: 0x0001421D File Offset: 0x0001241D
			public unsafe InitializeWithTemporaryEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializeWithTemporaryEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x060026E4 RID: 9956 RVA: 0x0009CE34 File Offset: 0x0009B034
			// (set) Token: 0x060026E5 RID: 9957 RVA: 0x0001423C File Offset: 0x0001243C
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeWithTemporaryEntity._createTempEntity_d__7.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
