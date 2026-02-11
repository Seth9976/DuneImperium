using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.match.voodoo
{
	// Token: 0x02000249 RID: 585
	public class EntityOwnerLayout : MonoBehaviour
	{
		// Token: 0x06001A84 RID: 6788 RVA: 0x00073FD4 File Offset: 0x000721D4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityOwnerLayout()
		{
			Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.voodoo", "EntityOwnerLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr);
			EntityOwnerLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "slots");
			EntityOwnerLayout.NativeFieldInfoPtr_disableSlotOnEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "disableSlotOnEmpty");
			EntityOwnerLayout.NativeFieldInfoPtr_containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "containers");
			EntityOwnerLayout.NativeMethodInfoPtr_Layout_Public_Virtual_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, 100667521);
			EntityOwnerLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, 100667522);
			EntityOwnerLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, 100667523);
			EntityOwnerLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, 100667524);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00074090 File Offset: 0x00072290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532114, XrefRangeEnd = 532230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOwnerLayout.NativeMethodInfoPtr_Layout_Public_Virtual_New_Void_List_1_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000740E0 File Offset: 0x000722E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532230, XrefRangeEnd = 532279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00074140 File Offset: 0x00072340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532279, XrefRangeEnd = 532307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00074184 File Offset: 0x00072384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532307, XrefRangeEnd = 532319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOwnerLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0000E7D3 File Offset: 0x0000C9D3
		public EntityOwnerLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x000741C0 File Offset: 0x000723C0
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0000E7DC File Offset: 0x0000C9DC
		public unsafe Il2CppReferenceArray<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x000741F0 File Offset: 0x000723F0
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0000E7FB File Offset: 0x0000C9FB
		public unsafe bool disableSlotOnEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_disableSlotOnEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_disableSlotOnEmpty)) = value;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00074218 File Offset: 0x00072418
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0000E816 File Offset: 0x0000CA16
		public unsafe List<EntityOwnerLayout.Container> containers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_containers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityOwnerLayout.Container>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.NativeFieldInfoPtr_containers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeFieldInfoPtr_disableSlotOnEmpty;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeFieldInfoPtr_containers;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_New_Void_List_1_UnitView_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000438 RID: 1080
		public class Container : global::Il2CppSystem.Object
		{
			// Token: 0x06003313 RID: 13075 RVA: 0x000C0E20 File Offset: 0x000BF020
			// Note: this type is marked as 'beforefieldinit'.
			static Container()
			{
				Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "Container");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr);
				EntityOwnerLayout.Container.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, "<Owner>k__BackingField");
				EntityOwnerLayout.Container.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, "<Slot>k__BackingField");
				EntityOwnerLayout.Container.NativeFieldInfoPtr__Layout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, "<Layout>k__BackingField");
				EntityOwnerLayout.Container.NativeFieldInfoPtr__Views_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, "<Views>k__BackingField");
				EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Owner_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667525);
				EntityOwnerLayout.Container.NativeMethodInfoPtr_set_Owner_Public_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667526);
				EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Slot_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667527);
				EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Layout_Public_get_IViewLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667528);
				EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Views_Public_get_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667529);
				EntityOwnerLayout.Container.NativeMethodInfoPtr__ctor_Public_Void_AccountID_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667530);
				EntityOwnerLayout.Container.NativeMethodInfoPtr_GetSlotFor_Public_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr, 100667531);
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x06003314 RID: 13076 RVA: 0x000C0F28 File Offset: 0x000BF128
			// (set) Token: 0x06003315 RID: 13077 RVA: 0x000C0F68 File Offset: 0x000BF168
			public unsafe AccountID Owner
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Owner_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_set_Owner_Public_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x06003316 RID: 13078 RVA: 0x000C0FAC File Offset: 0x000BF1AC
			public unsafe Transform Slot
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Slot_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x06003317 RID: 13079 RVA: 0x000C0FEC File Offset: 0x000BF1EC
			public unsafe IViewLayout Layout
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Layout_Public_get_IViewLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IViewLayout>(intPtr3) : null;
				}
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x06003318 RID: 13080 RVA: 0x000C102C File Offset: 0x000BF22C
			public unsafe List<UnitView> Views
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_get_Views_Public_get_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr3) : null;
				}
			}

			// Token: 0x06003319 RID: 13081 RVA: 0x000C106C File Offset: 0x000BF26C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 532037, RefRangeEnd = 532039, XrefRangeStart = 532022, XrefRangeEnd = 532037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Container(AccountID owner, Transform slot)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerLayout.Container>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr__ctor_Public_Void_AccountID_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600331A RID: 13082 RVA: 0x000C10CC File Offset: 0x000BF2CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 532040, RefRangeEnd = 532041, XrefRangeStart = 532039, XrefRangeEnd = 532040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transform GetSlotFor(UnitView view, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.Container.NativeMethodInfoPtr_GetSlotFor_Public_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}

			// Token: 0x0600331B RID: 13083 RVA: 0x0001A600 File Offset: 0x00018800
			public Container(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EE3 RID: 3811
			// (get) Token: 0x0600331C RID: 13084 RVA: 0x000C112C File Offset: 0x000BF32C
			// (set) Token: 0x0600331D RID: 13085 RVA: 0x0001A609 File Offset: 0x00018809
			public unsafe AccountID _Owner_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Owner_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE4 RID: 3812
			// (get) Token: 0x0600331E RID: 13086 RVA: 0x000C115C File Offset: 0x000BF35C
			// (set) Token: 0x0600331F RID: 13087 RVA: 0x0001A628 File Offset: 0x00018828
			public unsafe Transform _Slot_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Slot_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Slot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE5 RID: 3813
			// (get) Token: 0x06003320 RID: 13088 RVA: 0x000C118C File Offset: 0x000BF38C
			// (set) Token: 0x06003321 RID: 13089 RVA: 0x0001A647 File Offset: 0x00018847
			public unsafe IViewLayout _Layout_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Layout_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewLayout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Layout_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x06003322 RID: 13090 RVA: 0x000C11BC File Offset: 0x000BF3BC
			// (set) Token: 0x06003323 RID: 13091 RVA: 0x0001A666 File Offset: 0x00018866
			public unsafe List<UnitView> _Views_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Views_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.Container.NativeFieldInfoPtr__Views_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F84 RID: 8068
			private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

			// Token: 0x04001F85 RID: 8069
			private static readonly IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

			// Token: 0x04001F86 RID: 8070
			private static readonly IntPtr NativeFieldInfoPtr__Layout_k__BackingField;

			// Token: 0x04001F87 RID: 8071
			private static readonly IntPtr NativeFieldInfoPtr__Views_k__BackingField;

			// Token: 0x04001F88 RID: 8072
			private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_AccountID_0;

			// Token: 0x04001F89 RID: 8073
			private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Public_set_Void_AccountID_0;

			// Token: 0x04001F8A RID: 8074
			private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Public_get_Transform_0;

			// Token: 0x04001F8B RID: 8075
			private static readonly IntPtr NativeMethodInfoPtr_get_Layout_Public_get_IViewLayout_0;

			// Token: 0x04001F8C RID: 8076
			private static readonly IntPtr NativeMethodInfoPtr_get_Views_Public_get_List_1_UnitView_0;

			// Token: 0x04001F8D RID: 8077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_Transform_0;

			// Token: 0x04001F8E RID: 8078
			private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Transform_UnitView_Int32_0;
		}

		// Token: 0x02000439 RID: 1081
		[ObfuscatedName("boardgames.match.voodoo.EntityOwnerLayout+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06003324 RID: 13092 RVA: 0x000C11EC File Offset: 0x000BF3EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr);
				EntityOwnerLayout.__c__DisplayClass4_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr, "owner");
				EntityOwnerLayout.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr, 100667532);
				EntityOwnerLayout.__c__DisplayClass4_0.NativeMethodInfoPtr__Layout_b__0_Internal_Boolean_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr, 100667533);
			}

			// Token: 0x06003325 RID: 13093 RVA: 0x000C1254 File Offset: 0x000BF454
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003326 RID: 13094 RVA: 0x000C1290 File Offset: 0x000BF490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532041, XrefRangeEnd = 532046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Layout_b__0(EntityOwnerLayout.Container c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.__c__DisplayClass4_0.NativeMethodInfoPtr__Layout_b__0_Internal_Boolean_Container_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003327 RID: 13095 RVA: 0x0001A685 File Offset: 0x00018885
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EEB RID: 3819
			// (get) Token: 0x06003328 RID: 13096 RVA: 0x000C12E0 File Offset: 0x000BF4E0
			// (set) Token: 0x06003329 RID: 13097 RVA: 0x0001A68E File Offset: 0x0001888E
			public unsafe AccountID owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.__c__DisplayClass4_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.__c__DisplayClass4_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F8F RID: 8079
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04001F90 RID: 8080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F91 RID: 8081
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__0_Internal_Boolean_Container_0;
		}

		// Token: 0x0200043A RID: 1082
		[ObfuscatedName("boardgames.match.voodoo.EntityOwnerLayout+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600332A RID: 13098 RVA: 0x000C1310 File Offset: 0x000BF510
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityOwnerLayout>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr);
				EntityOwnerLayout.__c__DisplayClass5_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr, "owner");
				EntityOwnerLayout.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr, 100667534);
				EntityOwnerLayout.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr, 100667535);
			}

			// Token: 0x0600332B RID: 13099 RVA: 0x000C1378 File Offset: 0x000BF578
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerLayout.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600332C RID: 13100 RVA: 0x000C13B4 File Offset: 0x000BF5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532046, XrefRangeEnd = 532114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSlotFor_b__0(EntityOwnerLayout.Container c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerLayout.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_Container_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600332D RID: 13101 RVA: 0x0001A6AD File Offset: 0x000188AD
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x0600332E RID: 13102 RVA: 0x000C1404 File Offset: 0x000BF604
			// (set) Token: 0x0600332F RID: 13103 RVA: 0x0001A6B6 File Offset: 0x000188B6
			public unsafe AccountID owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.__c__DisplayClass5_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerLayout.__c__DisplayClass5_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F92 RID: 8082
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04001F93 RID: 8083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F94 RID: 8084
			private static readonly IntPtr NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_Container_0;
		}
	}
}
