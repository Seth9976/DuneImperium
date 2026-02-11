using System;
using boardgames.voodoo.data;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000052 RID: 82
	public class EntityView : VoodooView
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x00019444 File Offset: 0x00017644
		// Note: this type is marked as 'beforefieldinit'.
		static EntityView()
		{
			Il2CppClassPointerStore<EntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityView>.NativeClassPtr);
			EntityView.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "parent");
			EntityView.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "data");
			EntityView.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "Layer");
			EntityView.NativeFieldInfoPtr_dataObserver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "dataObserver");
			EntityView.NativeFieldInfoPtr_dataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "dataProvider");
			EntityView.NativeFieldInfoPtr_OnDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "OnDataChanged");
			EntityView.NativeFieldInfoPtr_initStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "initStrategy");
			EntityView.NativeFieldInfoPtr_unselectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityView>.NativeClassPtr, "unselectable");
			EntityView.NativeMethodInfoPtr_add_OnDataChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663891);
			EntityView.NativeMethodInfoPtr_remove_OnDataChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663892);
			EntityView.NativeMethodInfoPtr_get_Unselectable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663893);
			EntityView.NativeMethodInfoPtr_set_Unselectable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663894);
			EntityView.NativeMethodInfoPtr_EntityId_Public_Virtual_Final_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663895);
			EntityView.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663896);
			EntityView.NativeMethodInfoPtr_initProvider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663897);
			EntityView.NativeMethodInfoPtr_subInitialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663898);
			EntityView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663899);
			EntityView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663900);
			EntityView.NativeMethodInfoPtr_SetLayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663901);
			EntityView.NativeMethodInfoPtr_AddDataObserver_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663902);
			EntityView.NativeMethodInfoPtr_MarkObserverDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663903);
			EntityView.NativeMethodInfoPtr_RemoveDataObserver_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663904);
			EntityView.NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663905);
			EntityView.NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663906);
			EntityView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663907);
			EntityView.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663908);
			EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663909);
			EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_RegisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663910);
			EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_UnregisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663911);
			EntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityView>.NativeClassPtr, 100663912);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000196CC File Offset: 0x000178CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111039, XrefRangeEnd = 1111043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDataChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_add_OnDataChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00019710 File Offset: 0x00017910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111043, XrefRangeEnd = 1111047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDataChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_remove_OnDataChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00019754 File Offset: 0x00017954
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00019790 File Offset: 0x00017990
		public unsafe bool Unselectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_get_Unselectable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_set_Unselectable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000197D0 File Offset: 0x000179D0
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1111047, RefRangeEnd = 1111113, XrefRangeStart = 1111047, XrefRangeEnd = 1111047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityID EntityId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_EntityId_Public_Virtual_Final_New_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00019810 File Offset: 0x00017A10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1111148, RefRangeEnd = 1111153, XrefRangeStart = 1111113, XrefRangeEnd = 1111148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityView.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00019870 File Offset: 0x00017A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111153, XrefRangeEnd = 1111166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_initProvider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000198A4 File Offset: 0x00017AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111166, XrefRangeEnd = 1111170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void subInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_subInitialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000198D8 File Offset: 0x00017AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111174, RefRangeEnd = 1111176, XrefRangeStart = 1111170, XrefRangeEnd = 1111174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00019928 File Offset: 0x00017B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111176, XrefRangeEnd = 1111184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFromContext(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00019978 File Offset: 0x00017B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111184, XrefRangeEnd = 1111185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_SetLayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000199B8 File Offset: 0x00017BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111189, RefRangeEnd = 1111190, XrefRangeStart = 1111185, XrefRangeEnd = 1111189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataObserver(IAmDirty observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_AddDataObserver_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000199FC File Offset: 0x00017BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111190, XrefRangeEnd = 1111192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkObserverDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_MarkObserverDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00019A30 File Offset: 0x00017C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111192, XrefRangeEnd = 1111196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDataObserver(IAmDirty observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_RemoveDataObserver_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00019A74 File Offset: 0x00017C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111196, XrefRangeEnd = 1111219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObserveParentAndChildren(EntityComponent parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111219, XrefRangeEnd = 1111224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObserveEntity(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00019AFC File Offset: 0x00017CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111224, XrefRangeEnd = 1111226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00019B30 File Offset: 0x00017D30
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityView.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00019B6C File Offset: 0x00017D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes boardgames_attributes_IAttributesProvider_GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00019BAC File Offset: 0x00017DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void boardgames_attributes_IAttributesProvider_RegisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_RegisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void boardgames_attributes_IAttributesProvider_UnregisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_UnregisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00019C34 File Offset: 0x00017E34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1111253, RefRangeEnd = 1111260, XrefRangeStart = 1111226, XrefRangeEnd = 1111253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000476A File Offset: 0x0000296A
		public EntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00019C70 File Offset: 0x00017E70
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004773 File Offset: 0x00002973
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00019CA0 File Offset: 0x00017EA0
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004792 File Offset: 0x00002992
		public unsafe EntityComponent data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00019CD0 File Offset: 0x00017ED0
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x000047B1 File Offset: 0x000029B1
		public unsafe int Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00019CF8 File Offset: 0x00017EF8
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x000047CC File Offset: 0x000029CC
		public unsafe EntitiesObserver dataObserver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_dataObserver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesObserver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_dataObserver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00019D28 File Offset: 0x00017F28
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x000047EB File Offset: 0x000029EB
		public unsafe ManagedDataProvider dataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_dataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagedDataProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_dataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00019D58 File Offset: 0x00017F58
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000480A File Offset: 0x00002A0A
		public unsafe Action OnDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_OnDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_OnDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00019D88 File Offset: 0x00017F88
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00004829 File Offset: 0x00002A29
		public unsafe EntityViewInitializationStrategy initStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_initStrategy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityViewInitializationStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_initStrategy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00019DB8 File Offset: 0x00017FB8
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00004848 File Offset: 0x00002A48
		public unsafe bool unselectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_unselectable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityView.NativeFieldInfoPtr_unselectable)) = value;
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_dataObserver;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_dataProvider;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_OnDataChanged;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_initStrategy;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_unselectable;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDataChanged_Private_add_Void_Action_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDataChanged_Private_rem_Void_Action_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_Unselectable_Public_get_Boolean_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_set_Unselectable_Public_set_Void_Boolean_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_EntityId_Public_Virtual_Final_New_EntityID_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_EntityComponent_EntityView_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_initProvider_Private_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_subInitialize_Private_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Public_Void_Int32_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_AddDataObserver_Public_Void_IAmDirty_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_MarkObserverDirty_Public_Void_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDataObserver_Public_Void_IAmDirty_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_RegisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_UnregisterOnAttributesChanged_Private_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
