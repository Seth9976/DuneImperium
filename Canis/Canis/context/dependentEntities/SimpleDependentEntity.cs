using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.dependentEntities
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public class SimpleDependentEntity : DependentEntity
	{
		// Token: 0x06000DCA RID: 3530 RVA: 0x00054184 File Offset: 0x00052384
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleDependentEntity()
		{
			Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.dependentEntities", "SimpleDependentEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr);
			SimpleDependentEntity.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr, "EntityID");
			SimpleDependentEntity.NativeMethodInfoPtr_For_Public_Virtual_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr, 100666354);
			SimpleDependentEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr, 100666355);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000541F0 File Offset: 0x000523F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577065, XrefRangeEnd = 577069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity For(Entity basedOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(basedOn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleDependentEntity.NativeMethodInfoPtr_For_Public_Virtual_Entity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0005424C File Offset: 0x0005244C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleDependentEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleDependentEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleDependentEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00007067 File Offset: 0x00005267
		public SimpleDependentEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00054288 File Offset: 0x00052488
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00007070 File Offset: 0x00005270
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleDependentEntity.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleDependentEntity.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_For_Public_Virtual_Entity_Entity_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
