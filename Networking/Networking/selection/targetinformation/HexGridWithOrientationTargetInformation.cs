using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006F RID: 111
	public class HexGridWithOrientationTargetInformation : TargetInformation
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		// Note: this type is marked as 'beforefieldinit'.
		static HexGridWithOrientationTargetInformation()
		{
			Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "HexGridWithOrientationTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr);
			HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, "ValidCoords");
			HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, "Forced");
			HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, 100663511);
			HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_Clone_Public_HexGridWithOrientationTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, 100663512);
			HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, 100663513);
			HexGridWithOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr, 100663514);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000F75C File Offset: 0x0000D95C
		public unsafe override bool ForcedSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194327, XrefRangeEnd = 1194330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexGridWithOrientationTargetInformation Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_Clone_Public_HexGridWithOrientationTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HexGridWithOrientationTargetInformation>(intPtr3) : null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194330, XrefRangeEnd = 1194341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HexGridWithOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000F828 File Offset: 0x0000DA28
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexGridWithOrientationTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HexGridWithOrientationTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexGridWithOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00004570 File Offset: 0x00002770
		public HexGridWithOrientationTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000F864 File Offset: 0x0000DA64
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00004579 File Offset: 0x00002779
		public unsafe Il2CppStructArray<HexCoords> ValidCoords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HexCoords>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000F894 File Offset: 0x0000DA94
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00004598 File Offset: 0x00002798
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_ValidCoords;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_HexGridWithOrientationTargetInformation_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
