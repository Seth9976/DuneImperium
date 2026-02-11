using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class SkeletonBone : ValueType
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		// Note: this type is marked as 'beforefieldinit'.
		static SkeletonBone()
		{
			Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "SkeletonBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr);
			SkeletonBone.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "name");
			SkeletonBone.NativeFieldInfoPtr_parentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "parentName");
			SkeletonBone.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "position");
			SkeletonBone.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "rotation");
			SkeletonBone.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "scale");
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002625 File Offset: 0x00000825
		public SkeletonBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000262E File Offset: 0x0000082E
		public SkeletonBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr))
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000F540 File Offset: 0x0000D740
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002640 File Offset: 0x00000840
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000F568 File Offset: 0x0000D768
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000265F File Offset: 0x0000085F
		public unsafe string parentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000F590 File Offset: 0x0000D790
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000267E File Offset: 0x0000087E
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002699 File Offset: 0x00000899
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		// (set) Token: 0x0600025E RID: 606 RVA: 0x000026B4 File Offset: 0x000008B4
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000F608 File Offset: 0x0000D808
		// (set) Token: 0x06000260 RID: 608 RVA: 0x000026CF File Offset: 0x000008CF
		public int transformModified
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_parentName;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_scale;
	}
}
