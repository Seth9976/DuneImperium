using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E9 RID: 1001
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		// Token: 0x06003A96 RID: 14998 RVA: 0x0011A3C0 File Offset: 0x001185C0
		// Note: this type is marked as 'beforefieldinit'.
		static SatelliteContractVersionAttribute()
		{
			Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "SatelliteContractVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr);
			SatelliteContractVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, "<Version>k__BackingField");
			SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100672045);
			SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100672046);
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x0011A42C File Offset: 0x0011862C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396655, XrefRangeEnd = 1396663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SatelliteContractVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x0011A478 File Offset: 0x00118678
		public unsafe string Version
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00015C31 File Offset: 0x00013E31
		public SatelliteContractVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x0011A4B0 File Offset: 0x001186B0
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x00015C3A File Offset: 0x00013E3A
		public unsafe string _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;
	}
}
