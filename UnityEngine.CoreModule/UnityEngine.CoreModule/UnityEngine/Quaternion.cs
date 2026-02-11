using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FF RID: 255
	[StructLayout(2)]
	public struct Quaternion
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x00064D6C File Offset: 0x00062F6C
		// Note: this type is marked as 'beforefieldinit'.
		static Quaternion()
		{
			Il2CppClassPointerStore<Quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Quaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quaternion>.NativeClassPtr);
			Quaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "x");
			Quaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "y");
			Quaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "z");
			Quaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "w");
			Quaternion.NativeFieldInfoPtr_identityQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "identityQuaternion");
			Quaternion.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "kEpsilon");
			Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666162);
			Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666163);
			Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666164);
			Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666165);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666166);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666167);
			Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666168);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666169);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666170);
			Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666171);
			Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666172);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666173);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666174);
			Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666175);
			Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666176);
			Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666177);
			Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666178);
			Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666179);
			Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666180);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666181);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666182);
			Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666183);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666184);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666185);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666186);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666187);
			Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666189);
			Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666190);
			Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666191);
			Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666192);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666193);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666194);
			Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666195);
			Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100666196);
			Quaternion.SlerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.SlerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::SlerpUnclamped_Injected");
			Quaternion.LerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.LerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::LerpUnclamped_Injected");
			Quaternion.Internal_ToAxisAngleRad_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.Internal_ToAxisAngleRad_InjectedDelegate>("UnityEngine.Quaternion::Internal_ToAxisAngleRad_Injected");
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000650EC File Offset: 0x000632EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 659017, RefRangeEnd = 659020, XrefRangeStart = 659015, XrefRangeEnd = 659017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromDirection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00065138 File Offset: 0x00063338
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 659022, RefRangeEnd = 659034, XrefRangeStart = 659020, XrefRangeEnd = 659022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Inverse(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00065178 File Offset: 0x00063378
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 659036, RefRangeEnd = 659055, XrefRangeStart = 659034, XrefRangeEnd = 659036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000651D4 File Offset: 0x000633D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659055, XrefRangeEnd = 659057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00065230 File Offset: 0x00063430
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 659059, RefRangeEnd = 659084, XrefRangeStart = 659057, XrefRangeEnd = 659059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00065270 File Offset: 0x00063470
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 659086, RefRangeEnd = 659102, XrefRangeStart = 659084, XrefRangeEnd = 659086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000652B0 File Offset: 0x000634B0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 659104, RefRangeEnd = 659122, XrefRangeStart = 659102, XrefRangeEnd = 659104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x000652FC File Offset: 0x000634FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659124, RefRangeEnd = 659132, XrefRangeStart = 659122, XrefRangeEnd = 659124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upwards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00065348 File Offset: 0x00063548
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659136, RefRangeEnd = 659144, XrefRangeStart = 659132, XrefRangeEnd = 659136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00065388 File Offset: 0x00063588
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000653E4 File Offset: 0x000635E4
		public unsafe static Quaternion identity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659144, XrefRangeEnd = 659146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00065414 File Offset: 0x00063614
		[CallerCount(0)]
		public unsafe static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00065460 File Offset: 0x00063660
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 659146, RefRangeEnd = 659181, XrefRangeStart = 659146, XrefRangeEnd = 659146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000654AC File Offset: 0x000636AC
		[CallerCount(0)]
		public unsafe static bool IsEqualUsingDot(float dot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000654EC File Offset: 0x000636EC
		[CallerCount(0)]
		public unsafe static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00065538 File Offset: 0x00063738
		[CallerCount(0)]
		public unsafe static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00065584 File Offset: 0x00063784
		[CallerCount(0)]
		public unsafe static float Dot(Quaternion a, Quaternion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000655D0 File Offset: 0x000637D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 659184, RefRangeEnd = 659197, XrefRangeStart = 659181, XrefRangeEnd = 659184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_MakePositive(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00065610 File Offset: 0x00063810
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x000083BB File Offset: 0x000065BB
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659197, XrefRangeEnd = 659202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this = Quaternion.Internal_FromEulerRad(value * 0.017453292f);
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00065640 File Offset: 0x00063840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659202, XrefRangeEnd = 659204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006569C File Offset: 0x0006389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659204, XrefRangeEnd = 659206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(Vector3 euler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref euler;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000656DC File Offset: 0x000638DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659210, RefRangeEnd = 659218, XrefRangeStart = 659206, XrefRangeEnd = 659210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0006570C File Offset: 0x0006390C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659218, XrefRangeEnd = 659225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00065750 File Offset: 0x00063950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Quaternion other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00065790 File Offset: 0x00063990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659225, XrefRangeEnd = 659228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000657BC File Offset: 0x000639BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659228, XrefRangeEnd = 659263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0006580C File Offset: 0x00063A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659263, XrefRangeEnd = 659265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fromDirection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &toDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0006585C File Offset: 0x00063A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659265, XrefRangeEnd = 659267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0006589C File Offset: 0x00063A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659267, XrefRangeEnd = 659269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000658F8 File Offset: 0x00063AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659269, XrefRangeEnd = 659271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00065954 File Offset: 0x00063B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659271, XrefRangeEnd = 659273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &euler;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00065994 File Offset: 0x00063B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659273, XrefRangeEnd = 659275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000659D4 File Offset: 0x00063BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659275, XrefRangeEnd = 659277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00065A24 File Offset: 0x00063C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659277, XrefRangeEnd = 659279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &upwards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00008352 File Offset: 0x00006552
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00065A74 File Offset: 0x00063C74
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00008364 File Offset: 0x00006564
		public unsafe static Quaternion identityQuaternion
		{
			get
			{
				Quaternion quaternion;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&quaternion));
				return quaternion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00065A90 File Offset: 0x00063C90
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00008372 File Offset: 0x00006572
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00065AAC File Offset: 0x00063CAC
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.SlerpUnclamped_Injected(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00065AC8 File Offset: 0x00063CC8
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.LerpUnclamped_Injected(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00008380 File Offset: 0x00006580
		public static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad_Injected(ref q, out axis, out angle);
		}

		// Token: 0x17000443 RID: 1091
		public float this[int index]
		{
			get
			{
				float num;
				switch (index)
				{
				case 0:
					num = this.x;
					break;
				case 1:
					num = this.y;
					break;
				case 2:
					num = this.z;
					break;
				case 3:
					num = this.w;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
				return num;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.x = value;
					break;
				case 1:
					this.y = value;
					break;
				case 2:
					this.z = value;
					break;
				case 3:
					this.w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000838B File Offset: 0x0000658B
		public void Set(float newX, float newY, float newZ, float newW)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
			this.w = newW;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00065B9C File Offset: 0x00063D9C
		public void SetLookRotation(Vector3 view)
		{
			Vector3 up = Vector3.up;
			this.SetLookRotation(view, up);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000083AB File Offset: 0x000065AB
		public void SetLookRotation(Vector3 view, Vector3 up)
		{
			this = Quaternion.LookRotation(view, up);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00065BBC File Offset: 0x00063DBC
		public static float Angle(Quaternion a, Quaternion b)
		{
			float num = Mathf.Min(Mathf.Abs(Quaternion.Dot(a, b)), 1f);
			return Quaternion.IsEqualUsingDot(num) ? 0f : (Mathf.Acos(num) * 2f * 57.29578f);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000083D4 File Offset: 0x000065D4
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
			angle *= 57.29578f;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000083EF File Offset: 0x000065EF
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00065C08 File Offset: 0x00063E08
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			float num = Quaternion.Angle(from, to);
			bool flag = num == 0f;
			Quaternion quaternion;
			if (flag)
			{
				quaternion = to;
			}
			else
			{
				quaternion = Quaternion.SlerpUnclamped(from, to, Mathf.Min(1f, maxDegreesDelta / num));
			}
			return quaternion;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00065C48 File Offset: 0x00063E48
		public static Quaternion Normalize(Quaternion q)
		{
			float num = Mathf.Sqrt(Quaternion.Dot(q, q));
			bool flag = num < Mathf.Epsilon;
			Quaternion quaternion;
			if (flag)
			{
				quaternion = Quaternion.identity;
			}
			else
			{
				quaternion = new Quaternion(q.x / num, q.y / num, q.z / num, q.w / num);
			}
			return quaternion;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000083FF File Offset: 0x000065FF
		public void Normalize()
		{
			this = Quaternion.Normalize(this);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00065CA0 File Offset: 0x00063EA0
		public Quaternion normalized
		{
			get
			{
				return Quaternion.Normalize(this);
			}
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00065CC0 File Offset: 0x00063EC0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00065CDC File Offset: 0x00063EDC
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00065CFC File Offset: 0x00063EFC
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00008413 File Offset: 0x00006613
		public void SetEulerRotation(float x, float y, float z)
		{
			this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00008429 File Offset: 0x00006629
		public void SetEulerRotation(Vector3 euler)
		{
			this = Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00065D14 File Offset: 0x00063F14
		public Vector3 ToEuler()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00065D34 File Offset: 0x00063F34
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00065D54 File Offset: 0x00063F54
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00008438 File Offset: 0x00006638
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00008449 File Offset: 0x00006649
		public void SetEulerAngles(float x, float y, float z)
		{
			this.SetEulerRotation(new Vector3(x, y, z));
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0000845B File Offset: 0x0000665B
		public void SetEulerAngles(Vector3 euler)
		{
			this = Quaternion.EulerRotation(euler);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00065D6C File Offset: 0x00063F6C
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return Quaternion.Internal_ToEulerRad(rotation);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00065D84 File Offset: 0x00063F84
		public Vector3 ToEulerAngles()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0000846A File Offset: 0x0000666A
		public void SetAxisAngle(Vector3 axis, float angle)
		{
			this = Quaternion.AxisAngle(axis, angle);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00065DA4 File Offset: 0x00063FA4
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return Quaternion.AngleAxis(57.29578f * angle, axis);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0000847A File Offset: 0x0000667A
		public static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			Quaternion.SlerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0000848A File Offset: 0x0000668A
		public static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			Quaternion.LerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000849A File Offset: 0x0000669A
		public static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad_InjectedDelegateField(ref q, out axis, out angle);
		}

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr_identityQuaternion;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400137A RID: 4986
		[FieldOffset(0)]
		public float x;

		// Token: 0x0400137B RID: 4987
		[FieldOffset(4)]
		public float y;

		// Token: 0x0400137C RID: 4988
		[FieldOffset(8)]
		public float z;

		// Token: 0x0400137D RID: 4989
		[FieldOffset(12)]
		public float w;

		// Token: 0x0400137E RID: 4990
		private static readonly Quaternion.SlerpUnclamped_InjectedDelegate SlerpUnclamped_InjectedDelegateField;

		// Token: 0x0400137F RID: 4991
		private static readonly Quaternion.LerpUnclamped_InjectedDelegate LerpUnclamped_InjectedDelegateField;

		// Token: 0x04001380 RID: 4992
		private static readonly Quaternion.Internal_ToAxisAngleRad_InjectedDelegate Internal_ToAxisAngleRad_InjectedDelegateField;

		// Token: 0x020006F1 RID: 1777
		// (Invoke) Token: 0x060036C1 RID: 14017
		private delegate void SlerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x020006F2 RID: 1778
		// (Invoke) Token: 0x060036C3 RID: 14019
		private delegate void LerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x020006F3 RID: 1779
		// (Invoke) Token: 0x060036C5 RID: 14021
		private delegate void Internal_ToAxisAngleRad_InjectedDelegate(IntPtr q, [Out] IntPtr axis, [Out] IntPtr angle);
	}
}
