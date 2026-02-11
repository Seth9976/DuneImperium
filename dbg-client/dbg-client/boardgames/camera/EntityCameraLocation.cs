using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.camera
{
	// Token: 0x0200029E RID: 670
	public class EntityCameraLocation : Observer
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x00087EF0 File Offset: 0x000860F0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityCameraLocation()
		{
			Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "EntityCameraLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr);
			EntityCameraLocation.NativeFieldInfoPtr_flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, "flavor");
			EntityCameraLocation.NativeFieldInfoPtr__EntityID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, "<EntityID>k__BackingField");
			EntityCameraLocation.NativeFieldInfoPtr_locationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, "locationManager");
			EntityCameraLocation.NativeMethodInfoPtr_get_Flavor_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668604);
			EntityCameraLocation.NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668605);
			EntityCameraLocation.NativeMethodInfoPtr_set_EntityID_Private_set_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668606);
			EntityCameraLocation.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668607);
			EntityCameraLocation.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668608);
			EntityCameraLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr, 100668609);
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00087FD4 File Offset: 0x000861D4
		public unsafe string Flavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541828, XrefRangeEnd = 541831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityCameraLocation.NativeMethodInfoPtr_get_Flavor_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0008800C File Offset: 0x0008620C
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x0008804C File Offset: 0x0008624C
		public unsafe EntityID EntityID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityCameraLocation.NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityCameraLocation.NativeMethodInfoPtr_set_EntityID_Private_set_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00088090 File Offset: 0x00086290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541831, XrefRangeEnd = 541835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityCameraLocation.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000880CC File Offset: 0x000862CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541835, XrefRangeEnd = 541886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityCameraLocation.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00088108 File Offset: 0x00086308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541886, XrefRangeEnd = 541890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityCameraLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityCameraLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityCameraLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00010CBB File Offset: 0x0000EEBB
		public EntityCameraLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00088144 File Offset: 0x00086344
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		public unsafe string flavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr_flavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr_flavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0008816C File Offset: 0x0008636C
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x00010CE3 File Offset: 0x0000EEE3
		public unsafe EntityID _EntityID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr__EntityID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr__EntityID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0008819C File Offset: 0x0008639C
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x00010D02 File Offset: 0x0000EF02
		public unsafe CameraLocationManager locationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr_locationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLocationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityCameraLocation.NativeFieldInfoPtr_locationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_flavor;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr__EntityID_k__BackingField;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_locationManager;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavor_Public_get_String_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityID_Private_set_Void_EntityID_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
