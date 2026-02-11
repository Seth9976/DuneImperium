using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetresponse
{
	// Token: 0x02000060 RID: 96
	public class HexCoordsWithOrientationTargetResponse : TargetResponse
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		// Note: this type is marked as 'beforefieldinit'.
		static HexCoordsWithOrientationTargetResponse()
		{
			Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "HexCoordsWithOrientationTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr);
			HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_RCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, "RCoord");
			HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_SCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, "SCoord");
			HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, "Orientation");
			HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, "name");
			HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663454);
			HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663455);
			HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663456);
			HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663457);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000DC4C File Offset: 0x0000BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193970, XrefRangeEnd = 1193975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoordsWithOrientationTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000DC88 File Offset: 0x0000BE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193980, RefRangeEnd = 1193981, XrefRangeStart = 1193975, XrefRangeEnd = 1193980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoordsWithOrientationTargetResponse(int rCoord, int sCoord, int orientation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HexCoordsWithOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rCoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sCoord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193981, XrefRangeEnd = 1193984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000DD44 File Offset: 0x0000BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193984, XrefRangeEnd = 1193990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HexCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000404B File Offset: 0x0000224B
		public HexCoordsWithOrientationTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00004054 File Offset: 0x00002254
		public unsafe int RCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_RCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_RCoord)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0000406F File Offset: 0x0000226F
		public unsafe int SCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_SCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_SCoord)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0000408A File Offset: 0x0000228A
		public unsafe int Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000DE04 File Offset: 0x0000C004
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000040A5 File Offset: 0x000022A5
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HexCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_RCoord;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_SCoord;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
