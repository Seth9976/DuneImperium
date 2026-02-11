using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.loader.loaders
{
	// Token: 0x02000195 RID: 405
	public sealed class AssetName : ValueType
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x0006F448 File Offset: 0x0006D648
		// Note: this type is marked as 'beforefieldinit'.
		static AssetName()
		{
			Il2CppClassPointerStore<AssetName>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "AssetName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetName>.NativeClassPtr);
			AssetName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetName>.NativeClassPtr, "Name");
			AssetName.NativeFieldInfoPtr_BaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetName>.NativeClassPtr, "BaseName");
			AssetName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetName>.NativeClassPtr, 100666791);
			AssetName.NativeMethodInfoPtr_get_RequestName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetName>.NativeClassPtr, 100666792);
			AssetName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetName>.NativeClassPtr, 100666793);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0006F4DC File Offset: 0x0006D6DC
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetName(string name, string baseName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0006F540 File Offset: 0x0006D740
		public unsafe string RequestName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 878481, RefRangeEnd = 878482, XrefRangeStart = 878481, XrefRangeEnd = 878481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetName.NativeMethodInfoPtr_get_RequestName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0006F57C File Offset: 0x0006D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878482, XrefRangeEnd = 878484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0000A014 File Offset: 0x00008214
		public AssetName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0000A01D File Offset: 0x0000821D
		public AssetName()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetName>.NativeClassPtr))
		{
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0000A02F File Offset: 0x0000822F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetName.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetName.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0006F5E0 File Offset: 0x0006D7E0
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000A04E File Offset: 0x0000824E
		public unsafe string BaseName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetName.NativeFieldInfoPtr_BaseName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetName.NativeFieldInfoPtr_BaseName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeFieldInfoPtr_BaseName;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestName_Public_get_String_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
