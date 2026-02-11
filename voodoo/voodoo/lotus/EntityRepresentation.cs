using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000063 RID: 99
	public class EntityRepresentation : Object
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x0001CDA4 File Offset: 0x0001AFA4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityRepresentation()
		{
			Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityRepresentation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr);
			EntityRepresentation.NativeMethodInfoPtr_op_Implicit_Public_Static_EntityRepresentation_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr, 100664106);
			EntityRepresentation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr, 100664107);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001CDFC File Offset: 0x0001AFFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1112626, RefRangeEnd = 1112633, XrefRangeStart = 1112621, XrefRangeEnd = 1112626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator EntityRepresentation(EntityID entityID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.NativeMethodInfoPtr_op_Implicit_Public_Static_EntityRepresentation_EntityID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityRepresentation>(intPtr3) : null;
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001CE40 File Offset: 0x0001B040
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityRepresentation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004E62 File Offset: 0x00003062
		public EntityRepresentation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EntityRepresentation_EntityID_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000EA RID: 234
		public class EntityIDVariant : EntityRepresentation
		{
			// Token: 0x06000C4D RID: 3149 RVA: 0x00031590 File Offset: 0x0002F790
			// Note: this type is marked as 'beforefieldinit'.
			static EntityIDVariant()
			{
				Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr, "EntityIDVariant");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr);
				EntityRepresentation.EntityIDVariant.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr, "entityID");
				EntityRepresentation.EntityIDVariant.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr, 100664108);
				EntityRepresentation.EntityIDVariant.NativeMethodInfoPtr_op_Implicit_Public_Static_EntityID_EntityIDVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr, 100664109);
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x000315F8 File Offset: 0x0002F7F8
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityIDVariant(EntityID entityID)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityRepresentation.EntityIDVariant>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.EntityIDVariant.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x00031644 File Offset: 0x0002F844
			[CallerCount(0)]
			public unsafe static implicit operator EntityID(EntityRepresentation.EntityIDVariant entityIDVar)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIDVar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.EntityIDVariant.NativeMethodInfoPtr_op_Implicit_Public_Static_EntityID_EntityIDVariant_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x000080F7 File Offset: 0x000062F7
			public EntityIDVariant(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00031688 File Offset: 0x0002F888
			// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00008100 File Offset: 0x00006300
			public unsafe EntityID entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityRepresentation.EntityIDVariant.NativeFieldInfoPtr_entityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityRepresentation.EntityIDVariant.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007AB RID: 1963
			private static readonly IntPtr NativeFieldInfoPtr_entityID;

			// Token: 0x040007AC RID: 1964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_0;

			// Token: 0x040007AD RID: 1965
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EntityID_EntityIDVariant_0;
		}

		// Token: 0x020000EB RID: 235
		public sealed class DematerializeEntityIDVariant : EntityRepresentation.EntityIDVariant
		{
			// Token: 0x06000C53 RID: 3155 RVA: 0x0000811F File Offset: 0x0000631F
			// Note: this type is marked as 'beforefieldinit'.
			static DematerializeEntityIDVariant()
			{
				Il2CppClassPointerStore<EntityRepresentation.DematerializeEntityIDVariant>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr, "DematerializeEntityIDVariant");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityRepresentation.DematerializeEntityIDVariant>.NativeClassPtr);
				EntityRepresentation.DematerializeEntityIDVariant.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation.DematerializeEntityIDVariant>.NativeClassPtr, 100664110);
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x000316B8 File Offset: 0x0002F8B8
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DematerializeEntityIDVariant(EntityID entityID)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityRepresentation.DematerializeEntityIDVariant>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.DematerializeEntityIDVariant.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C55 RID: 3157 RVA: 0x00008153 File Offset: 0x00006353
			public DematerializeEntityIDVariant(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040007AE RID: 1966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_0;
		}

		// Token: 0x020000EC RID: 236
		public sealed class HiddenEntity : EntityRepresentation
		{
			// Token: 0x06000C56 RID: 3158 RVA: 0x00031704 File Offset: 0x0002F904
			// Note: this type is marked as 'beforefieldinit'.
			static HiddenEntity()
			{
				Il2CppClassPointerStore<EntityRepresentation.HiddenEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityRepresentation>.NativeClassPtr, "HiddenEntity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityRepresentation.HiddenEntity>.NativeClassPtr);
				EntityRepresentation.HiddenEntity.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityRepresentation.HiddenEntity>.NativeClassPtr, "Instance");
				EntityRepresentation.HiddenEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityRepresentation.HiddenEntity>.NativeClassPtr, 100664111);
			}

			// Token: 0x06000C57 RID: 3159 RVA: 0x00031758 File Offset: 0x0002F958
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HiddenEntity()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityRepresentation.HiddenEntity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityRepresentation.HiddenEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C58 RID: 3160 RVA: 0x0000815C File Offset: 0x0000635C
			public HiddenEntity(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00031794 File Offset: 0x0002F994
			// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00008165 File Offset: 0x00006365
			public unsafe static EntityRepresentation.HiddenEntity Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityRepresentation.HiddenEntity.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityRepresentation.HiddenEntity>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityRepresentation.HiddenEntity.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007AF RID: 1967
			private static readonly IntPtr NativeFieldInfoPtr_Instance;

			// Token: 0x040007B0 RID: 1968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
