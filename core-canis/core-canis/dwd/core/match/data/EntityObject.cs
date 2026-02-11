using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.match.data
{
	// Token: 0x02000168 RID: 360
	public class EntityObject : MonoBehaviour
	{
		// Token: 0x060014FA RID: 5370 RVA: 0x000681E0 File Offset: 0x000663E0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityObject()
		{
			Il2CppClassPointerStore<EntityObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "EntityObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityObject>.NativeClassPtr);
			EntityObject.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, "entitiesProvider");
			EntityObject.NativeFieldInfoPtr__provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, "<provider>k__BackingField");
			EntityObject.NativeMethodInfoPtr_get_entities_Protected_get_Entities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666461);
			EntityObject.NativeMethodInfoPtr_get_provider_Protected_get_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666462);
			EntityObject.NativeMethodInfoPtr_set_provider_Private_set_Void_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666463);
			EntityObject.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666464);
			EntityObject.NativeMethodInfoPtr_getEntity_Protected_Abstract_Virtual_New_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666465);
			EntityObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, 100666466);
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000682B0 File Offset: 0x000664B0
		public unsafe Entities entities
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 875431, RefRangeEnd = 875435, XrefRangeStart = 875427, XrefRangeEnd = 875431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject.NativeMethodInfoPtr_get_entities_Protected_get_Entities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr3) : null;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000682F0 File Offset: 0x000664F0
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00068330 File Offset: 0x00066530
		public unsafe SubscriptionProvider provider
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject.NativeMethodInfoPtr_get_provider_Protected_get_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject.NativeMethodInfoPtr_set_provider_Private_set_Void_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00068374 File Offset: 0x00066574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875435, XrefRangeEnd = 875440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000683B4 File Offset: 0x000665B4
		[CallerCount(0)]
		public unsafe virtual EntityComponent getEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityObject.NativeMethodInfoPtr_getEntity_Protected_Abstract_Virtual_New_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00068400 File Offset: 0x00066600
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00009480 File Offset: 0x00007680
		public EntityObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0006843C File Offset: 0x0006663C
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x00009489 File Offset: 0x00007689
		public unsafe IEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0006846C File Offset: 0x0006666C
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000094A8 File Offset: 0x000076A8
		public unsafe SubscriptionProvider _provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject.NativeFieldInfoPtr__provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject.NativeFieldInfoPtr__provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr__provider_k__BackingField;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_get_entities_Protected_get_Entities_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_get_provider_Protected_get_SubscriptionProvider_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_set_provider_Private_set_Void_SubscriptionProvider_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_getEntity_Protected_Abstract_Virtual_New_EntityComponent_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002E6 RID: 742
		[ObfuscatedName("dwd.core.match.data.EntityObject+<Start>d__7")]
		public sealed class _Start_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002263 RID: 8803 RVA: 0x00098A14 File Offset: 0x00096C14
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__7()
			{
				Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityObject>.NativeClassPtr, "<Start>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr);
				EntityObject._Start_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, "<>1__state");
				EntityObject._Start_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, "<>2__current");
				EntityObject._Start_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, "<>4__this");
				EntityObject._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666467);
				EntityObject._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666468);
				EntityObject._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666469);
				EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666470);
				EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666471);
				EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr, 100666472);
			}

			// Token: 0x06002264 RID: 8804 RVA: 0x00098AF4 File Offset: 0x00096CF4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityObject._Start_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002265 RID: 8805 RVA: 0x00098B3C File Offset: 0x00096D3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002266 RID: 8806 RVA: 0x00098B70 File Offset: 0x00096D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875407, XrefRangeEnd = 875422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x00098BAC File Offset: 0x00096DAC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002268 RID: 8808 RVA: 0x00098BEC File Offset: 0x00096DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875422, XrefRangeEnd = 875427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x00098C20 File Offset: 0x00096E20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityObject._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600226A RID: 8810 RVA: 0x0000EC45 File Offset: 0x0000CE45
			public _Start_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x00098C60 File Offset: 0x00096E60
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x0000EC4E File Offset: 0x0000CE4E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x00098C88 File Offset: 0x00096E88
			// (set) Token: 0x0600226E RID: 8814 RVA: 0x0000EC69 File Offset: 0x0000CE69
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x0600226F RID: 8815 RVA: 0x00098CB8 File Offset: 0x00096EB8
			// (set) Token: 0x06002270 RID: 8816 RVA: 0x0000EC88 File Offset: 0x0000CE88
			public unsafe EntityObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityObject._Start_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
