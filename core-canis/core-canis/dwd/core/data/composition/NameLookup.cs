using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001E2 RID: 482
	public class NameLookup : VersionedDataComponent
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x0007D810 File Offset: 0x0007BA10
		// Note: this type is marked as 'beforefieldinit'.
		static NameLookup()
		{
			Il2CppClassPointerStore<NameLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "NameLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameLookup>.NativeClassPtr);
			NameLookup.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookup>.NativeClassPtr, 100667500);
			NameLookup.NativeMethodInfoPtr_name_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookup>.NativeClassPtr, 100667501);
			NameLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookup>.NativeClassPtr, 100667502);
			NameLookup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookup>.NativeClassPtr, 100667503);
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0007D890 File Offset: 0x0007BA90
		public unsafe string Name
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameLookup.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		[CallerCount(0)]
		public unsafe virtual string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameLookup.NativeMethodInfoPtr_name_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0007D90C File Offset: 0x0007BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883714, XrefRangeEnd = 883720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0007D950 File Offset: 0x0007BB50
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 883581, RefRangeEnd = 883678, XrefRangeStart = 883581, XrefRangeEnd = 883678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameLookup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0000B716 File Offset: 0x00009916
		public NameLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
