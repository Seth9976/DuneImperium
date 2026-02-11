using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000070 RID: 112
	[Serializable]
	[StructLayout(2)]
	public struct HexCoords
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000F8BC File Offset: 0x0000DABC
		// Note: this type is marked as 'beforefieldinit'.
		static HexCoords()
		{
			Il2CppClassPointerStore<HexCoords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "HexCoords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexCoords>.NativeClassPtr);
			HexCoords.NativeFieldInfoPtr_coordsRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, "coordsRegex");
			HexCoords.NativeFieldInfoPtr_RCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, "RCoord");
			HexCoords.NativeFieldInfoPtr_SCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, "SCoord");
			HexCoords.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663515);
			HexCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663516);
			HexCoords.NativeMethodInfoPtr_op_Addition_Public_Static_HexCoords_HexCoords_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663517);
			HexCoords.NativeMethodInfoPtr_op_Subtraction_Public_Static_HexCoords_HexCoords_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663518);
			HexCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663519);
			HexCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663520);
			HexCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663521);
			HexCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663522);
			HexCoords.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoords_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663523);
			HexCoords.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoords_HexCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, 100663524);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoords(int rcoord, int scoord)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rcoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scoord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000FA30 File Offset: 0x0000DC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194341, XrefRangeEnd = 1194350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoords(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[CallerCount(0)]
		public unsafe static HexCoords operator +(HexCoords a, HexCoords b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_op_Addition_Public_Static_HexCoords_HexCoords_HexCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
		[CallerCount(0)]
		public unsafe static HexCoords operator -(HexCoords a, HexCoords b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_op_Subtraction_Public_Static_HexCoords_HexCoords_HexCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000FB00 File Offset: 0x0000DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194350, XrefRangeEnd = 1194355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000FB44 File Offset: 0x0000DD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194355, XrefRangeEnd = 1194361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000FB74 File Offset: 0x0000DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194361, XrefRangeEnd = 1194369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[CallerCount(0)]
		public unsafe bool Equals(HexCoords other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoords_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000FBE0 File Offset: 0x0000DDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194369, XrefRangeEnd = 1194372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HexCoords left, HexCoords right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoords_HexCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194372, XrefRangeEnd = 1194375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HexCoords left, HexCoords right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoords.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoords_HexCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000045B3 File Offset: 0x000027B3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HexCoords>.NativeClassPtr, ref this));
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000FC78 File Offset: 0x0000DE78
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x000045C5 File Offset: 0x000027C5
		public unsafe static Regex coordsRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HexCoords.NativeFieldInfoPtr_coordsRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HexCoords.NativeFieldInfoPtr_coordsRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_coordsRegex;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_RCoord;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_SCoord;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_HexCoords_HexCoords_HexCoords_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_HexCoords_HexCoords_HexCoords_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HexCoords_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HexCoords_HexCoords_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HexCoords_HexCoords_0;

		// Token: 0x040001ED RID: 493
		[FieldOffset(0)]
		public readonly int RCoord;

		// Token: 0x040001EE RID: 494
		[FieldOffset(4)]
		public readonly int SCoord;
	}
}
