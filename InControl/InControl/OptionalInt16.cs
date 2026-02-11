using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	[StructLayout(2)]
	public struct OptionalInt16
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x0002A3E0 File Offset: 0x000285E0
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalInt16()
		{
			Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalInt16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr);
			OptionalInt16.NativeFieldInfoPtr_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, "hasValue");
			OptionalInt16.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, "value");
			OptionalInt16.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664576);
			OptionalInt16.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664577);
			OptionalInt16.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664578);
			OptionalInt16.NativeMethodInfoPtr_get_Value_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664579);
			OptionalInt16.NativeMethodInfoPtr_set_Value_Public_set_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664580);
			OptionalInt16.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664581);
			OptionalInt16.NativeMethodInfoPtr_GetValueOrDefault_Public_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664582);
			OptionalInt16.NativeMethodInfoPtr_GetValueOrZero_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664583);
			OptionalInt16.NativeMethodInfoPtr_SetValue_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664584);
			OptionalInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664585);
			OptionalInt16.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664586);
			OptionalInt16.NativeMethodInfoPtr_Equals_Public_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664587);
			OptionalInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664588);
			OptionalInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664589);
			OptionalInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664590);
			OptionalInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664591);
			OptionalInt16.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664592);
			OptionalInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664593);
			OptionalInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664594);
			OptionalInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664595);
			OptionalInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_OptionalInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, 100664596);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002A5DC File Offset: 0x000287DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002A610 File Offset: 0x00028810
		public unsafe bool HasValue
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0002A640 File Offset: 0x00028840
		public unsafe bool HasNoValue
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0002A670 File Offset: 0x00028870
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0002A6A0 File Offset: 0x000288A0
		public unsafe short Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_get_Value_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_set_Value_Public_set_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002A6D4 File Offset: 0x000288D4
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0002A6FC File Offset: 0x000288FC
		[CallerCount(0)]
		public unsafe short GetValueOrDefault(short defaultValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_GetValueOrDefault_Public_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002A73C File Offset: 0x0002893C
		[CallerCount(0)]
		public unsafe short GetValueOrZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_GetValueOrZero_Public_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002A76C File Offset: 0x0002896C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_SetValue_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002A7A0 File Offset: 0x000289A0
		[CallerCount(0)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002A7E4 File Offset: 0x000289E4
		[CallerCount(0)]
		public unsafe bool Equals(OptionalInt16 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002A824 File Offset: 0x00028A24
		[CallerCount(0)]
		public unsafe bool Equals(short other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_Equals_Public_Boolean_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002A864 File Offset: 0x00028A64
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalInt16 a, OptionalInt16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002A8B0 File Offset: 0x00028AB0
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalInt16 a, OptionalInt16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0002A8FC File Offset: 0x00028AFC
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalInt16 a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0002A948 File Offset: 0x00028B48
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalInt16 a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0002A994 File Offset: 0x00028B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787560, XrefRangeEnd = 787565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0002AA10 File Offset: 0x00028C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787565, XrefRangeEnd = 787572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002AA3C File Offset: 0x00028C3C
		[CallerCount(691)]
		[CachedScanResults(RefRangeStart = 786858, RefRangeEnd = 787549, XrefRangeStart = 786858, XrefRangeEnd = 787549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator OptionalInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002AA7C File Offset: 0x00028C7C
		[CallerCount(0)]
		public unsafe static explicit operator short(OptionalInt16 optional)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optional;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_OptionalInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00005D39 File Offset: 0x00003F39
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalInt16>.NativeClassPtr, ref this));
		}

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_hasValue;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int16_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int16_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Int16_Int16_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrZero_Public_Int16_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int16_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt16_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Int16_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_OptionalInt16_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt16_Int16_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt16_Int16_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt16_Int16_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_OptionalInt16_0;

		// Token: 0x04000926 RID: 2342
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool hasValue;

		// Token: 0x04000927 RID: 2343
		[FieldOffset(2)]
		public short value;
	}
}
