using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001DE RID: 478
	public class DescriptionLookup : VersionedDataComponent
	{
		// Token: 0x06001A66 RID: 6758 RVA: 0x0007D260 File Offset: 0x0007B460
		// Note: this type is marked as 'beforefieldinit'.
		static DescriptionLookup()
		{
			Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "DescriptionLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr);
			DescriptionLookup.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667485);
			DescriptionLookup.NativeMethodInfoPtr_get_DescriptionKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667486);
			DescriptionLookup.NativeMethodInfoPtr_description_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667487);
			DescriptionLookup.NativeMethodInfoPtr_descriptionKey_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667488);
			DescriptionLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667489);
			DescriptionLookup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr, 100667490);
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0007D308 File Offset: 0x0007B508
		public unsafe string Description
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionLookup.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0007D340 File Offset: 0x0007B540
		public unsafe string DescriptionKey
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionLookup.NativeMethodInfoPtr_get_DescriptionKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0007D378 File Offset: 0x0007B578
		[CallerCount(0)]
		public unsafe virtual string description()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescriptionLookup.NativeMethodInfoPtr_description_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0007D3BC File Offset: 0x0007B5BC
		[CallerCount(0)]
		public unsafe virtual string descriptionKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescriptionLookup.NativeMethodInfoPtr_descriptionKey_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0007D400 File Offset: 0x0007B600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883560, XrefRangeEnd = 883579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DescriptionLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0007D444 File Offset: 0x0007B644
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 883581, RefRangeEnd = 883678, XrefRangeStart = 883579, XrefRangeEnd = 883581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DescriptionLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriptionLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionLookup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0000B6C3 File Offset: 0x000098C3
		public DescriptionLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_get_DescriptionKey_Public_get_String_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_description_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_descriptionKey_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
