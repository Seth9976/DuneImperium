using System;
using System.Runtime.InteropServices;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetresponse
{
	// Token: 0x0200005E RID: 94
	public class EntityListTargetResponse : TargetResponse
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityListTargetResponse()
		{
			Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "EntityListTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr);
			EntityListTargetResponse.NativeFieldInfoPtr_EntityList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, "EntityList");
			EntityListTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, "name");
			EntityListTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663444);
			EntityListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663445);
			EntityListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663446);
			EntityListTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663447);
			EntityListTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663448);
			EntityListTargetResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr, 100663449);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193843, XrefRangeEnd = 1193852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1193865, RefRangeEnd = 1193872, XrefRangeStart = 1193852, XrefRangeEnd = 1193865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetResponse(IEnumerable<EntityID> EntityIDs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(EntityIDs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000D72C File Offset: 0x0000B92C
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1193881, RefRangeEnd = 1193926, XrefRangeStart = 1193872, XrefRangeEnd = 1193881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetResponse([Optional] Il2CppReferenceArray<EntityID> entityIds)
		{
			if (entityIds == null)
			{
				entityIds = new Il2CppReferenceArray<EntityID>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetResponse>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000D784 File Offset: 0x0000B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193926, XrefRangeEnd = 1193933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000D824 File Offset: 0x0000BA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193933, XrefRangeEnd = 1193944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003F79 File Offset: 0x00002179
		public EntityListTargetResponse(params EntityID[] entityIds)
			: this(new Il2CppReferenceArray<EntityID>(entityIds))
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003F87 File Offset: 0x00002187
		public EntityListTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000D868 File Offset: 0x0000BA68
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003F90 File Offset: 0x00002190
		public unsafe Il2CppReferenceArray<EntityID> EntityList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetResponse.NativeFieldInfoPtr_EntityList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetResponse.NativeFieldInfoPtr_EntityList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000D898 File Offset: 0x0000BA98
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003FAF File Offset: 0x000021AF
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_EntityList;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_EntityID_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
