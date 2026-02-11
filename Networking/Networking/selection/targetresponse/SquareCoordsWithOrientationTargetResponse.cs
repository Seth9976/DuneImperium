using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetresponse
{
	// Token: 0x02000063 RID: 99
	public class SquareCoordsWithOrientationTargetResponse : TargetResponse
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000E324 File Offset: 0x0000C524
		// Note: this type is marked as 'beforefieldinit'.
		static SquareCoordsWithOrientationTargetResponse()
		{
			Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "SquareCoordsWithOrientationTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr);
			SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_XCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, "XCoord");
			SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_YCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, "YCoord");
			SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, "Orientation");
			SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, "name");
			SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663468);
			SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663469);
			SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663470);
			SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr, 100663471);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194124, XrefRangeEnd = 1194129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoordsWithOrientationTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000E430 File Offset: 0x0000C630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1194134, RefRangeEnd = 1194135, XrefRangeStart = 1194129, XrefRangeEnd = 1194134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoordsWithOrientationTargetResponse(int xCoord, int yCoord, int orientation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquareCoordsWithOrientationTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xCoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yCoord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000E494 File Offset: 0x0000C694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194135, XrefRangeEnd = 1194138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194138, XrefRangeEnd = 1194144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareCoordsWithOrientationTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000414E File Offset: 0x0000234E
		public SquareCoordsWithOrientationTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000E534 File Offset: 0x0000C734
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00004157 File Offset: 0x00002357
		public unsafe int XCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_XCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_XCoord)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000E55C File Offset: 0x0000C75C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00004172 File Offset: 0x00002372
		public unsafe int YCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_YCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_YCoord)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000E584 File Offset: 0x0000C784
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000418D File Offset: 0x0000238D
		public unsafe int Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_Orientation)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000041A8 File Offset: 0x000023A8
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquareCoordsWithOrientationTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_XCoord;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_YCoord;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
