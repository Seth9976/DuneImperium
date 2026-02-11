using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001E3 RID: 483
	public class VersionedDataComponent : DataComponent
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x0007D98C File Offset: 0x0007BB8C
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedDataComponent()
		{
			Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "VersionedDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr);
			VersionedDataComponent.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr, "version");
			VersionedDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr, 100667504);
			VersionedDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr, 100667505);
			VersionedDataComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr, 100667506);
			VersionedDataComponent.NativeMethodInfoPtr_markDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr, 100667507);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0007DA20 File Offset: 0x0007BC20
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 883581, RefRangeEnd = 883678, XrefRangeStart = 883581, XrefRangeEnd = 883678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedDataComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0007DA5C File Offset: 0x0007BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883720, XrefRangeEnd = 883722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedDataComponent(ulong version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0007DAA4 File Offset: 0x0007BCA4
		public unsafe virtual ulong Version
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedDataComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 883722, RefRangeEnd = 883793, XrefRangeStart = 883722, XrefRangeEnd = 883722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void markDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedDataComponent.NativeMethodInfoPtr_markDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000B71F File Offset: 0x0000991F
		public VersionedDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0007DB20 File Offset: 0x0007BD20
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000B728 File Offset: 0x00009928
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponent.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponent.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt64_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_markDirty_Protected_Void_0;
	}
}
