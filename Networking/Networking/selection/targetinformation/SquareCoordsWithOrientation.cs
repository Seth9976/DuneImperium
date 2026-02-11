using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000079 RID: 121
	[StructLayout(2)]
	public struct SquareCoordsWithOrientation
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x00010A14 File Offset: 0x0000EC14
		// Note: this type is marked as 'beforefieldinit'.
		static SquareCoordsWithOrientation()
		{
			Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "SquareCoordsWithOrientation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr);
			SquareCoordsWithOrientation.NativeFieldInfoPtr_XCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, "XCoord");
			SquareCoordsWithOrientation.NativeFieldInfoPtr_YCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, "YCoord");
			SquareCoordsWithOrientation.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, "Orientation");
			SquareCoordsWithOrientation.NativeMethodInfoPtr_get_SquareCoords_Public_get_SquareCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, 100663553);
			SquareCoordsWithOrientation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, 100663554);
			SquareCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, 100663555);
			SquareCoordsWithOrientation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, 100663556);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public unsafe SquareCoords SquareCoords
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientation.NativeMethodInfoPtr_get_SquareCoords_Public_get_SquareCoords_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00010B00 File Offset: 0x0000ED00
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoordsWithOrientation(int xcoord, int ycoord, int orientation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xcoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ycoord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00010B50 File Offset: 0x0000ED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194468, XrefRangeEnd = 1194471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00010B94 File Offset: 0x0000ED94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194471, XrefRangeEnd = 1194477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsWithOrientation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000047EC File Offset: 0x000029EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SquareCoordsWithOrientation>.NativeClassPtr, ref this));
		}

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_XCoord;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_YCoord;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_SquareCoords_Public_get_SquareCoords_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400022D RID: 557
		[FieldOffset(0)]
		public readonly int XCoord;

		// Token: 0x0400022E RID: 558
		[FieldOffset(4)]
		public readonly int YCoord;

		// Token: 0x0400022F RID: 559
		[FieldOffset(8)]
		public readonly int Orientation;
	}
}
