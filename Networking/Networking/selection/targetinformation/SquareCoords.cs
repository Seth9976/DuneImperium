using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	[StructLayout(2)]
	public struct SquareCoords
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x000107A4 File Offset: 0x0000E9A4
		// Note: this type is marked as 'beforefieldinit'.
		static SquareCoords()
		{
			Il2CppClassPointerStore<SquareCoords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "SquareCoords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr);
			SquareCoords.NativeFieldInfoPtr_coordsRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, "coordsRegex");
			SquareCoords.NativeFieldInfoPtr_XCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, "XCoord");
			SquareCoords.NativeFieldInfoPtr_YCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, "YCoord");
			SquareCoords.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663546);
			SquareCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663547);
			SquareCoords.NativeMethodInfoPtr_op_Addition_Public_Static_SquareCoords_SquareCoords_SquareCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663548);
			SquareCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663549);
			SquareCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663550);
			SquareCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, 100663551);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00010888 File Offset: 0x0000EA88
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoords(int xcoord, int ycoord)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xcoord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ycoord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000108C8 File Offset: 0x0000EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194442, XrefRangeEnd = 1194451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoords(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00010900 File Offset: 0x0000EB00
		[CallerCount(0)]
		public unsafe static SquareCoords operator +(SquareCoords a, SquareCoords b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr_op_Addition_Public_Static_SquareCoords_SquareCoords_SquareCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001094C File Offset: 0x0000EB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194451, XrefRangeEnd = 1194454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00010990 File Offset: 0x0000EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194454, XrefRangeEnd = 1194460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000109C0 File Offset: 0x0000EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194460, XrefRangeEnd = 1194468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000047C8 File Offset: 0x000029C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SquareCoords>.NativeClassPtr, ref this));
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000109EC File Offset: 0x0000EBEC
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x000047DA File Offset: 0x000029DA
		public unsafe static Regex coordsRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SquareCoords.NativeFieldInfoPtr_coordsRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SquareCoords.NativeFieldInfoPtr_coordsRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_coordsRegex;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_XCoord;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_YCoord;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SquareCoords_SquareCoords_SquareCoords_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000224 RID: 548
		[FieldOffset(0)]
		public readonly int XCoord;

		// Token: 0x04000225 RID: 549
		[FieldOffset(4)]
		public readonly int YCoord;
	}
}
