using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	[StructLayout(2)]
	public struct HexCoordsWithOrientation
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		// Note: this type is marked as 'beforefieldinit'.
		static HexCoordsWithOrientation()
		{
			Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "HexCoordsWithOrientation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr);
			HexCoordsWithOrientation.NativeFieldInfoPtr_RCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, "RCoord");
			HexCoordsWithOrientation.NativeFieldInfoPtr_SCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, "SCoord");
			HexCoordsWithOrientation.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, "Orientation");
			HexCoordsWithOrientation.NativeMethodInfoPtr_get_HexCoords_Public_get_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663526);
			HexCoordsWithOrientation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663527);
			HexCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663528);
			HexCoordsWithOrientation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663529);
			HexCoordsWithOrientation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663530);
			HexCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoordsWithOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663531);
			HexCoordsWithOrientation.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663532);
			HexCoordsWithOrientation.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, 100663533);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		public unsafe HexCoords HexCoords
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_get_HexCoords_Public_get_HexCoords_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoordsWithOrientation(int rcoord, int scoord, int orientation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rcoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scoord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000FE2C File Offset: 0x0000E02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194375, XrefRangeEnd = 1194378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000FE70 File Offset: 0x0000E070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194378, XrefRangeEnd = 1194384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194384, XrefRangeEnd = 1194394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000FECC File Offset: 0x0000E0CC
		[CallerCount(0)]
		public unsafe bool Equals(HexCoordsWithOrientation other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoordsWithOrientation_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000FF0C File Offset: 0x0000E10C
		[CallerCount(0)]
		public unsafe static bool operator ==(HexCoordsWithOrientation left, HexCoordsWithOrientation right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000FF58 File Offset: 0x0000E158
		[CallerCount(0)]
		public unsafe static bool operator !=(HexCoordsWithOrientation left, HexCoordsWithOrientation right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsWithOrientation.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000045D7 File Offset: 0x000027D7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HexCoordsWithOrientation>.NativeClassPtr, ref this));
		}

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_RCoord;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_SCoord;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_get_HexCoords_Public_get_HexCoords_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoordsWithOrientation_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoordsWithOrientation_HexCoordsWithOrientation_0;

		// Token: 0x040001FA RID: 506
		[FieldOffset(0)]
		public readonly int RCoord;

		// Token: 0x040001FB RID: 507
		[FieldOffset(4)]
		public readonly int SCoord;

		// Token: 0x040001FC RID: 508
		[FieldOffset(8)]
		public readonly int Orientation;
	}
}
