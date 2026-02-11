using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetresponse
{
	// Token: 0x0200005F RID: 95
	public class EntityOrientationTargetResponse : TargetResponse
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityOrientationTargetResponse()
		{
			Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "EntityOrientationTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr);
			EntityOrientationTargetResponse.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, "Entity");
			EntityOrientationTargetResponse.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, "Orientation");
			EntityOrientationTargetResponse.NativeFieldInfoPtr_Flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, "Flipped");
			EntityOrientationTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, "name");
			EntityOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, 100663450);
			EntityOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, 100663451);
			EntityOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, 100663452);
			EntityOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr, 100663453);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000D990 File Offset: 0x0000BB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193944, XrefRangeEnd = 1193949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOrientationTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193955, RefRangeEnd = 1193957, XrefRangeStart = 1193949, XrefRangeEnd = 1193955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOrientationTargetResponse(EntityID entity, int orientation, bool flipped = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000DA34 File Offset: 0x0000BC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193957, XrefRangeEnd = 1193964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000DA8C File Offset: 0x0000BC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193964, XrefRangeEnd = 1193970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003FCE File Offset: 0x000021CE
		public EntityOrientationTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003FD7 File Offset: 0x000021D7
		public unsafe EntityID Entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000DB04 File Offset: 0x0000BD04
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003FF6 File Offset: 0x000021F6
		public unsafe int Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Orientation)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00004011 File Offset: 0x00002211
		public unsafe bool Flipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Flipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_Flipped)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000DB54 File Offset: 0x0000BD54
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0000402C File Offset: 0x0000222C
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_Entity;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_Flipped;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_Boolean_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
