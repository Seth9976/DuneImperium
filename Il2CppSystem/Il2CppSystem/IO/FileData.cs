using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017C RID: 380
	public class FileData : Object
	{
		// Token: 0x0600173A RID: 5946 RVA: 0x00077150 File Offset: 0x00075350
		// Note: this type is marked as 'beforefieldinit'.
		static FileData()
		{
			Il2CppClassPointerStore<FileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "FileData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileData>.NativeClassPtr);
			FileData.NativeFieldInfoPtr_Directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileData>.NativeClassPtr, "Directory");
			FileData.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileData>.NativeClassPtr, "Attributes");
			FileData.NativeFieldInfoPtr_NotExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileData>.NativeClassPtr, "NotExists");
			FileData.NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileData>.NativeClassPtr, "CreationTime");
			FileData.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileData>.NativeClassPtr, "LastWriteTime");
			FileData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileData>.NativeClassPtr, 100666972);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000771F8 File Offset: 0x000753F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0000A0CD File Offset: 0x000082CD
		public FileData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00077234 File Offset: 0x00075434
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000A0D6 File Offset: 0x000082D6
		public unsafe string Directory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_Directory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_Directory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0007725C File Offset: 0x0007545C
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000A0F5 File Offset: 0x000082F5
		public unsafe FileAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_Attributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_Attributes)) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00077284 File Offset: 0x00075484
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0000A110 File Offset: 0x00008310
		public unsafe bool NotExists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_NotExists);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_NotExists)) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000772AC File Offset: 0x000754AC
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0000A12B File Offset: 0x0000832B
		public unsafe DateTime CreationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_CreationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_CreationTime)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000772D4 File Offset: 0x000754D4
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x0000A146 File Offset: 0x00008346
		public unsafe DateTime LastWriteTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_LastWriteTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileData.NativeFieldInfoPtr_LastWriteTime)) = value;
			}
		}

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_Directory;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_NotExists;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_CreationTime;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_LastWriteTime;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
