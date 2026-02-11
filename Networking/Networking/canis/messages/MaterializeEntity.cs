using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x02000026 RID: 38
	public class MaterializeEntity : GameMessage
	{
		// Token: 0x06000134 RID: 308 RVA: 0x000091D4 File Offset: 0x000073D4
		// Note: this type is marked as 'beforefieldinit'.
		static MaterializeEntity()
		{
			Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "MaterializeEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr);
			MaterializeEntity.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "EntityID");
			MaterializeEntity.NativeFieldInfoPtr_EntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "EntityName");
			MaterializeEntity.NativeFieldInfoPtr_AttributeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "AttributeMap");
			MaterializeEntity.NativeFieldInfoPtr_OwningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "OwningPlayerID");
			MaterializeEntity.NativeFieldInfoPtr_MaterializeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "MaterializeChildren");
			MaterializeEntity.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "SourceID");
			MaterializeEntity.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "DestinationID");
			MaterializeEntity.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, "PositionInParent");
			MaterializeEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, 100663360);
			MaterializeEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr, 100663361);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000092CC File Offset: 0x000074CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193575, XrefRangeEnd = 1193603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterializeEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00009310 File Offset: 0x00007510
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterializeEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterializeEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterializeEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002CDF File Offset: 0x00000EDF
		public MaterializeEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000934C File Offset: 0x0000754C
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000937C File Offset: 0x0000757C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002D07 File Offset: 0x00000F07
		public unsafe string EntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_EntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_EntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000093A4 File Offset: 0x000075A4
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002D26 File Offset: 0x00000F26
		public unsafe ReadOnlyAttributes AttributeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_AttributeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_AttributeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000093D4 File Offset: 0x000075D4
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002D45 File Offset: 0x00000F45
		public unsafe AccountID OwningPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_OwningPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_OwningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00009404 File Offset: 0x00007604
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002D64 File Offset: 0x00000F64
		public unsafe List<MaterializeEntity> MaterializeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_MaterializeChildren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterializeEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_MaterializeChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00009434 File Offset: 0x00007634
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002D83 File Offset: 0x00000F83
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00009464 File Offset: 0x00007664
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00009494 File Offset: 0x00007694
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public unsafe int PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_PositionInParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterializeEntity.NativeFieldInfoPtr_PositionInParent)) = value;
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_EntityName;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_AttributeMap;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_OwningPlayerID;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_MaterializeChildren;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
