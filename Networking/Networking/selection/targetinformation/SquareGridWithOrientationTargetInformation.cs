using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000077 RID: 119
	public class SquareGridWithOrientationTargetInformation : TargetInformation
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x0001059C File Offset: 0x0000E79C
		// Note: this type is marked as 'beforefieldinit'.
		static SquareGridWithOrientationTargetInformation()
		{
			Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "SquareGridWithOrientationTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr);
			SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, "ValidCoords");
			SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, "Forced");
			SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, 100663542);
			SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_Clone_Public_SquareGridWithOrientationTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, 100663543);
			SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, 100663544);
			SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr, 100663545);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00010644 File Offset: 0x0000E844
		public unsafe override bool ForcedSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001068C File Offset: 0x0000E88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194428, XrefRangeEnd = 1194431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareGridWithOrientationTargetInformation Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_Clone_Public_SquareGridWithOrientationTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SquareGridWithOrientationTargetInformation>(intPtr3) : null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000106CC File Offset: 0x0000E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194431, XrefRangeEnd = 1194442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00010710 File Offset: 0x0000E910
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareGridWithOrientationTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquareGridWithOrientationTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareGridWithOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00004785 File Offset: 0x00002985
		public SquareGridWithOrientationTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0001074C File Offset: 0x0000E94C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000478E File Offset: 0x0000298E
		public unsafe Il2CppStructArray<SquareCoords> ValidCoords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SquareCoords>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_ValidCoords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0001077C File Offset: 0x0000E97C
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000047AD File Offset: 0x000029AD
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareGridWithOrientationTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_ValidCoords;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SquareGridWithOrientationTargetInformation_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
