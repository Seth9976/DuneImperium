using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	[StructLayout(2)]
	public struct OptionalFloat
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00028E68 File Offset: 0x00027068
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalFloat()
		{
			Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr);
			OptionalFloat.NativeFieldInfoPtr_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, "hasValue");
			OptionalFloat.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, "value");
			OptionalFloat.NativeFieldInfoPtr_epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, "epsilon");
			OptionalFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664511);
			OptionalFloat.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664512);
			OptionalFloat.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664513);
			OptionalFloat.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664514);
			OptionalFloat.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664515);
			OptionalFloat.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664516);
			OptionalFloat.NativeMethodInfoPtr_GetValueOrDefault_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664517);
			OptionalFloat.NativeMethodInfoPtr_GetValueOrZero_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664518);
			OptionalFloat.NativeMethodInfoPtr_SetValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664519);
			OptionalFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664520);
			OptionalFloat.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664521);
			OptionalFloat.NativeMethodInfoPtr_Equals_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664522);
			OptionalFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664523);
			OptionalFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664524);
			OptionalFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664525);
			OptionalFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664526);
			OptionalFloat.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664527);
			OptionalFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664528);
			OptionalFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664529);
			OptionalFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664530);
			OptionalFloat.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_OptionalFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664531);
			OptionalFloat.NativeMethodInfoPtr_IsApproximatelyEqual_Private_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664532);
			OptionalFloat.NativeMethodInfoPtr_ApproximatelyEquals_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, 100664533);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000290A0 File Offset: 0x000272A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 786801, RefRangeEnd = 786806, XrefRangeStart = 786801, XrefRangeEnd = 786801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalFloat(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x000290D4 File Offset: 0x000272D4
		public unsafe bool HasValue
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00029104 File Offset: 0x00027304
		public unsafe bool HasNoValue
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00029134 File Offset: 0x00027334
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00029164 File Offset: 0x00027364
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_get_Value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 786801, RefRangeEnd = 786806, XrefRangeStart = 786801, XrefRangeEnd = 786806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00029198 File Offset: 0x00027398
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000291C0 File Offset: 0x000273C0
		[CallerCount(0)]
		public unsafe float GetValueOrDefault(float defaultValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_GetValueOrDefault_Public_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00029200 File Offset: 0x00027400
		[CallerCount(0)]
		public unsafe float GetValueOrZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_GetValueOrZero_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00029230 File Offset: 0x00027430
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 786801, RefRangeEnd = 786806, XrefRangeStart = 786801, XrefRangeEnd = 786806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_SetValue_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00029264 File Offset: 0x00027464
		[CallerCount(0)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000292A8 File Offset: 0x000274A8
		[CallerCount(0)]
		public unsafe bool Equals(OptionalFloat other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalFloat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000292E8 File Offset: 0x000274E8
		[CallerCount(0)]
		public unsafe bool Equals(float other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_Equals_Public_Boolean_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00029328 File Offset: 0x00027528
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalFloat a, OptionalFloat b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00029374 File Offset: 0x00027574
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalFloat a, OptionalFloat b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000293C0 File Offset: 0x000275C0
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalFloat a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002940C File Offset: 0x0002760C
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalFloat a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00029458 File Offset: 0x00027658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000294A4 File Offset: 0x000276A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786825, XrefRangeEnd = 786830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000294D4 File Offset: 0x000276D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786830, XrefRangeEnd = 786837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00029500 File Offset: 0x00027700
		[CallerCount(0)]
		public unsafe static implicit operator OptionalFloat(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalFloat_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00029540 File Offset: 0x00027740
		[CallerCount(0)]
		public unsafe static explicit operator float(OptionalFloat optional)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optional;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_OptionalFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00029580 File Offset: 0x00027780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786837, RefRangeEnd = 786838, XrefRangeStart = 786837, XrefRangeEnd = 786837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsApproximatelyEqual(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_IsApproximatelyEqual_Private_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000295CC File Offset: 0x000277CC
		[CallerCount(0)]
		public unsafe bool ApproximatelyEquals(float other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFloat.NativeMethodInfoPtr_ApproximatelyEquals_Public_Boolean_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00005CF5 File Offset: 0x00003EF5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalFloat>.NativeClassPtr, ref this));
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002960C File Offset: 0x0002780C
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00005D07 File Offset: 0x00003F07
		public unsafe static float epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(OptionalFloat.NativeFieldInfoPtr_epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptionalFloat.NativeFieldInfoPtr_epsilon, (void*)(&value));
			}
		}

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_hasValue;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_epsilon;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Single_Single_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrZero_Public_Single_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_OptionalFloat_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Single_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_OptionalFloat_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalFloat_Single_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalFloat_Single_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalFloat_Single_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_OptionalFloat_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_IsApproximatelyEqual_Private_Static_Boolean_Single_Single_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_ApproximatelyEquals_Public_Boolean_Single_0;

		// Token: 0x040008DB RID: 2267
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool hasValue;

		// Token: 0x040008DC RID: 2268
		[FieldOffset(4)]
		public float value;
	}
}
