using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000248 RID: 584
	public class MeshHandle : LinkedPoolItem<MeshHandle>
	{
		// Token: 0x06002B05 RID: 11013 RVA: 0x000BAC9C File Offset: 0x000B8E9C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshHandle()
		{
			Il2CppClassPointerStore<MeshHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "MeshHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr);
			MeshHandle.NativeFieldInfoPtr_allocVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocVerts");
			MeshHandle.NativeFieldInfoPtr_allocIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocIndices");
			MeshHandle.NativeFieldInfoPtr_triangleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "triangleCount");
			MeshHandle.NativeFieldInfoPtr_allocPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocPage");
			MeshHandle.NativeFieldInfoPtr_allocTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocTime");
			MeshHandle.NativeFieldInfoPtr_updateAllocID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "updateAllocID");
			MeshHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, 100669724);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000BAD58 File Offset: 0x000B8F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348311, XrefRangeEnd = 348314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00011514 File Offset: 0x0000F714
		public MeshHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000BAD94 File Offset: 0x000B8F94
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0001151D File Offset: 0x0000F71D
		public Alloc allocVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocVerts);
				return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocVerts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x000BADC4 File Offset: 0x000B8FC4
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x0001154B File Offset: 0x0000F74B
		public Alloc allocIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocIndices);
				return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x000BADF4 File Offset: 0x000B8FF4
		// (set) Token: 0x06002B0D RID: 11021 RVA: 0x00011579 File Offset: 0x0000F779
		public unsafe uint triangleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_triangleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_triangleCount)) = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000BAE1C File Offset: 0x000B901C
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x00011594 File Offset: 0x0000F794
		public unsafe Page allocPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000BAE4C File Offset: 0x000B904C
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x000115B3 File Offset: 0x0000F7B3
		public unsafe uint allocTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocTime)) = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000BAE74 File Offset: 0x000B9074
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x000115CE File Offset: 0x0000F7CE
		public unsafe uint updateAllocID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_updateAllocID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_updateAllocID)) = value;
			}
		}

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_allocVerts;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_allocIndices;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_triangleCount;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_allocPage;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_allocTime;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr_updateAllocID;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
