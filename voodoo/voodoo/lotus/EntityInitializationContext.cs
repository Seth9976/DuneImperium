using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000051 RID: 81
	public class EntityInitializationContext : Object
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x000191EC File Offset: 0x000173EC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityInitializationContext()
		{
			Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityInitializationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr);
			EntityInitializationContext.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, "entities");
			EntityInitializationContext.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, "data");
			EntityInitializationContext.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, "parent");
			EntityInitializationContext.NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, 100663888);
			EntityInitializationContext.NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, 100663889);
			EntityInitializationContext.NativeMethodInfoPtr_WithData_Public_EntityInitializationContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr, 100663890);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00019294 File Offset: 0x00017494
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityInitializationContext(Entities e, EntityComponent d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityInitializationContext.NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000192F4 File Offset: 0x000174F4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityInitializationContext(Entities e, EntityComponent d, EntityView p)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityInitializationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityInitializationContext.NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00019364 File Offset: 0x00017564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111033, XrefRangeEnd = 1111039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityInitializationContext WithData(EntityComponent data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityInitializationContext.NativeMethodInfoPtr_WithData_Public_EntityInitializationContext_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityInitializationContext>(intPtr3) : null;
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00004704 File Offset: 0x00002904
		public EntityInitializationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000193B4 File Offset: 0x000175B4
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0000470D File Offset: 0x0000290D
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000193E4 File Offset: 0x000175E4
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0000472C File Offset: 0x0000292C
		public unsafe EntityComponent data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00019414 File Offset: 0x00017614
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000474B File Offset: 0x0000294B
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityInitializationContext.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entities_EntityComponent_EntityView_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_WithData_Public_EntityInitializationContext_EntityComponent_0;
	}
}
