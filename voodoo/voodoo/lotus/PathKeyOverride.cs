using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class PathKeyOverride : Object
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x00021B0C File Offset: 0x0001FD0C
		// Note: this type is marked as 'beforefieldinit'.
		static PathKeyOverride()
		{
			Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PathKeyOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr);
			PathKeyOverride.NativeFieldInfoPtr_defaultKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr, "defaultKey");
			PathKeyOverride.NativeFieldInfoPtr_overrideKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr, "overrideKey");
			PathKeyOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr, 100664290);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00021B78 File Offset: 0x0001FD78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathKeyOverride()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathKeyOverride>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathKeyOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00005A15 File Offset: 0x00003C15
		public PathKeyOverride(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00005A1E File Offset: 0x00003C1E
		public unsafe string defaultKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathKeyOverride.NativeFieldInfoPtr_defaultKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathKeyOverride.NativeFieldInfoPtr_defaultKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00021BDC File Offset: 0x0001FDDC
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00005A3D File Offset: 0x00003C3D
		public unsafe string overrideKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathKeyOverride.NativeFieldInfoPtr_overrideKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathKeyOverride.NativeFieldInfoPtr_overrideKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_defaultKey;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_overrideKey;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
