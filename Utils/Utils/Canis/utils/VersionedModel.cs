using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.utils
{
	// Token: 0x0200000B RID: 11
	public class VersionedModel : Object
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000052A4 File Offset: 0x000034A4
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedModel()
		{
			Il2CppClassPointerStore<VersionedModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils", "VersionedModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr);
			VersionedModel.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr, "version");
			VersionedModel.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr, "dirty");
			VersionedModel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr, 100663328);
			VersionedModel.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr, 100663329);
			VersionedModel.NativeMethodInfoPtr_markDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr, 100663330);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005338 File Offset: 0x00003538
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1176436, RefRangeEnd = 1176465, XrefRangeStart = 1176435, XrefRangeEnd = 1176436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedModel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005374 File Offset: 0x00003574
		public unsafe virtual ulong Version
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1176465, RefRangeEnd = 1176473, XrefRangeStart = 1176465, XrefRangeEnd = 1176465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedModel.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000053BC File Offset: 0x000035BC
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void markDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedModel.NativeMethodInfoPtr_markDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021A9 File Offset: 0x000003A9
		public VersionedModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000053F0 File Offset: 0x000035F0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021B2 File Offset: 0x000003B2
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedModel.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedModel.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005418 File Offset: 0x00003618
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021CD File Offset: 0x000003CD
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedModel.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedModel.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_markDirty_Protected_Void_0;
	}
}
