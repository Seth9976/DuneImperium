using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x02000023 RID: 35
	public class SimulationEntity : ObjectAttributes
	{
		// Token: 0x06000243 RID: 579 RVA: 0x0000B4FC File Offset: 0x000096FC
		// Note: this type is marked as 'beforefieldinit'.
		static SimulationEntity()
		{
			Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "SimulationEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr);
			SimulationEntity.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, "children");
			SimulationEntity.NativeFieldInfoPtr__EntityName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, "<EntityName>k__BackingField");
			SimulationEntity.NativeFieldInfoPtr__EntityID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, "<EntityID>k__BackingField");
			SimulationEntity.NativeFieldInfoPtr__OwningPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, "<OwningPlayerID>k__BackingField");
			SimulationEntity.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, "<Parent>k__BackingField");
			SimulationEntity.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663560);
			SimulationEntity.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663561);
			SimulationEntity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663562);
			SimulationEntity.NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663563);
			SimulationEntity.NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663564);
			SimulationEntity.NativeMethodInfoPtr_set_Parent_Public_set_Void_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663565);
			SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663566);
			SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663567);
			SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663568);
			SimulationEntity.NativeMethodInfoPtr_AddChild_Private_Void_SimulationEntity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663569);
			SimulationEntity.NativeMethodInfoPtr_RemoveChild_Private_Void_SimulationEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663570);
			SimulationEntity.NativeMethodInfoPtr_MoveTo_Public_SimulationEntity_SimulationEntity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr, 100663571);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000B680 File Offset: 0x00009880
		public unsafe virtual string EntityName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public unsafe virtual EntityID EntityID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public unsafe virtual AccountID OwningPlayerID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000B738 File Offset: 0x00009938
		public unsafe virtual IEnumerable<IEntity> Children
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000B778 File Offset: 0x00009978
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public unsafe virtual IEntity Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_set_Parent_Public_set_Void_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000B7FC File Offset: 0x000099FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218842, XrefRangeEnd = 1218907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimulationEntity(IEntity entityToCopy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityToCopy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000B848 File Offset: 0x00009A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218907, XrefRangeEnd = 1218918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimulationEntity(string name, EntityID entityID, AccountID owningPlayerID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218918, XrefRangeEnd = 1218972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimulationEntity(string name, EntityID entityID, AccountID owningPlayerID, IHasAttributes attrsToCopy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimulationEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrsToCopy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000B93C File Offset: 0x00009B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218972, XrefRangeEnd = 1218984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(SimulationEntity child, Nullable<int> position = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_AddChild_Private_Void_SimulationEntity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000B998 File Offset: 0x00009B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218984, XrefRangeEnd = 1218988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(SimulationEntity child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_RemoveChild_Private_Void_SimulationEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000B9DC File Offset: 0x00009BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218988, XrefRangeEnd = 1219002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimulationEntity MoveTo(SimulationEntity newParent, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimulationEntity.NativeMethodInfoPtr_MoveTo_Public_SimulationEntity_SimulationEntity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimulationEntity>(intPtr3) : null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002D92 File Offset: 0x00000F92
		public SimulationEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000BA44 File Offset: 0x00009C44
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002D9B File Offset: 0x00000F9B
		public unsafe List<SimulationEntity> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SimulationEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000BA74 File Offset: 0x00009C74
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002DBA File Offset: 0x00000FBA
		public unsafe string _EntityName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__EntityName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__EntityName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000BA9C File Offset: 0x00009C9C
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002DD9 File Offset: 0x00000FD9
		public unsafe EntityID _EntityID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__EntityID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__EntityID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000BACC File Offset: 0x00009CCC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002DF8 File Offset: 0x00000FF8
		public unsafe AccountID _OwningPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__OwningPlayerID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__OwningPlayerID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000BAFC File Offset: 0x00009CFC
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002E17 File Offset: 0x00001017
		public unsafe IEntity _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimulationEntity.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr__EntityName_k__BackingField;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__EntityID_k__BackingField;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__OwningPlayerID_k__BackingField;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Virtual_Final_New_get_IEnumerable_1_IEntity_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_Final_New_get_IEntity_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_IEntity_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEntity_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EntityID_AccountID_IHasAttributes_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Private_Void_SimulationEntity_Nullable_1_Int32_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Private_Void_SimulationEntity_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_SimulationEntity_SimulationEntity_Nullable_1_Int32_0;
	}
}
