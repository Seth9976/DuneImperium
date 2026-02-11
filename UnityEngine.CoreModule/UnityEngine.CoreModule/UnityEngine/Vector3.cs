using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FE RID: 254
	[StructLayout(2)]
	public struct Vector3
	{
		// Token: 0x060013F0 RID: 5104 RVA: 0x000637F8 File Offset: 0x000619F8
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3()
		{
			Il2CppClassPointerStore<Vector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3>.NativeClassPtr);
			Vector3.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilon");
			Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "x");
			Vector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "y");
			Vector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "z");
			Vector3.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "zeroVector");
			Vector3.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "oneVector");
			Vector3.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "upVector");
			Vector3.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "downVector");
			Vector3.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "leftVector");
			Vector3.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "rightVector");
			Vector3.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "forwardVector");
			Vector3.NativeFieldInfoPtr_backVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "backVector");
			Vector3.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "positiveInfinityVector");
			Vector3.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "negativeInfinityVector");
			Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666113);
			Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666114);
			Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666115);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666116);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666117);
			Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666118);
			Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666119);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666120);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666121);
			Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666122);
			Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666123);
			Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666124);
			Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666125);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666126);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666127);
			Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666128);
			Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666129);
			Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666130);
			Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666131);
			Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666132);
			Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666133);
			Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666134);
			Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666135);
			Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666136);
			Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666137);
			Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666138);
			Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666139);
			Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666140);
			Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666141);
			Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666142);
			Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666143);
			Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666144);
			Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666145);
			Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666146);
			Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666147);
			Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666148);
			Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666149);
			Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666150);
			Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666151);
			Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666152);
			Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666153);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666154);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666155);
			Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666156);
			Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666157);
			Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666158);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666159);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100666160);
			Vector3.OrthoNormalize2DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize2Delegate>("UnityEngine.Vector3::OrthoNormalize2");
			Vector3.OrthoNormalize3DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize3Delegate>("UnityEngine.Vector3::OrthoNormalize3");
			Vector3.Slerp_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.Slerp_InjectedDelegate>("UnityEngine.Vector3::Slerp_Injected");
			Vector3.SlerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.SlerpUnclamped_InjectedDelegate>("UnityEngine.Vector3::SlerpUnclamped_Injected");
			Vector3.RotateTowards_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.RotateTowards_InjectedDelegate>("UnityEngine.Vector3::RotateTowards_Injected");
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00063D60 File Offset: 0x00061F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658746, XrefRangeEnd = 658747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Lerp(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00063DBC File Offset: 0x00061FBC
		[CallerCount(0)]
		public unsafe static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00063E18 File Offset: 0x00062018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658747, XrefRangeEnd = 658753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistanceDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00063E74 File Offset: 0x00062074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658753, XrefRangeEnd = 658756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00063EDC File Offset: 0x000620DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 658761, RefRangeEnd = 658765, XrefRangeStart = 658756, XrefRangeEnd = 658761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000430 RID: 1072
		public unsafe float this[int index]
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 658765, RefRangeEnd = 658780, XrefRangeStart = 658765, XrefRangeEnd = 658765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00063FE0 File Offset: 0x000621E0
		[CallerCount(0)]
		public unsafe Vector3(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00064030 File Offset: 0x00062230
		[CallerCount(0)]
		public unsafe Vector3(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00064070 File Offset: 0x00062270
		[CallerCount(0)]
		public unsafe static Vector3 Scale(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000640BC File Offset: 0x000622BC
		[CallerCount(0)]
		public unsafe void Scale(Vector3 scale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000640F0 File Offset: 0x000622F0
		[CallerCount(0)]
		public unsafe static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0006413C File Offset: 0x0006233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658780, XrefRangeEnd = 658783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0006416C File Offset: 0x0006236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658783, XrefRangeEnd = 658786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000641B0 File Offset: 0x000623B0
		[CallerCount(0)]
		public unsafe bool Equals(Vector3 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000641F0 File Offset: 0x000623F0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 658793, RefRangeEnd = 658809, XrefRangeStart = 658786, XrefRangeEnd = 658793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Normalize(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00064230 File Offset: 0x00062430
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 658816, RefRangeEnd = 658823, XrefRangeStart = 658809, XrefRangeEnd = 658816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00064258 File Offset: 0x00062458
		public unsafe Vector3 normalized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658823, XrefRangeEnd = 658824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00064288 File Offset: 0x00062488
		[CallerCount(0)]
		public unsafe static float Dot(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000642D4 File Offset: 0x000624D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658824, XrefRangeEnd = 658827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref planeNormal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00064320 File Offset: 0x00062520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658827, XrefRangeEnd = 658836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0006436C File Offset: 0x0006256C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658836, XrefRangeEnd = 658838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000643C8 File Offset: 0x000625C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658838, XrefRangeEnd = 658843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00064414 File Offset: 0x00062614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658843, XrefRangeEnd = 658849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00064460 File Offset: 0x00062660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658849, XrefRangeEnd = 658854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Magnitude(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000644A0 File Offset: 0x000626A0
		public unsafe float magnitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658854, XrefRangeEnd = 658859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000644D0 File Offset: 0x000626D0
		[CallerCount(0)]
		public unsafe static float SqrMagnitude(Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00064510 File Offset: 0x00062710
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00064540 File Offset: 0x00062740
		[CallerCount(0)]
		public unsafe static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0006458C File Offset: 0x0006278C
		[CallerCount(0)]
		public unsafe static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000645D8 File Offset: 0x000627D8
		public unsafe static Vector3 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658859, XrefRangeEnd = 658861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00064608 File Offset: 0x00062808
		public unsafe static Vector3 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658861, XrefRangeEnd = 658863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00064638 File Offset: 0x00062838
		public unsafe static Vector3 forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658863, XrefRangeEnd = 658865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00064668 File Offset: 0x00062868
		public unsafe static Vector3 back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658865, XrefRangeEnd = 658867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00064698 File Offset: 0x00062898
		public unsafe static Vector3 up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658867, XrefRangeEnd = 658869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000646C8 File Offset: 0x000628C8
		public unsafe static Vector3 down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658869, XrefRangeEnd = 658871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000646F8 File Offset: 0x000628F8
		public unsafe static Vector3 left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658871, XrefRangeEnd = 658873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00064728 File Offset: 0x00062928
		public unsafe static Vector3 right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658873, XrefRangeEnd = 658875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00064758 File Offset: 0x00062958
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 658875, RefRangeEnd = 658944, XrefRangeStart = 658875, XrefRangeEnd = 658875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator +(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000647A4 File Offset: 0x000629A4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 658944, RefRangeEnd = 658970, XrefRangeStart = 658944, XrefRangeEnd = 658944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator -(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000647F0 File Offset: 0x000629F0
		[CallerCount(0)]
		public unsafe static Vector3 operator -(Vector3 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00064830 File Offset: 0x00062A30
		[CallerCount(0)]
		public unsafe static Vector3 operator *(Vector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0006487C File Offset: 0x00062A7C
		[CallerCount(0)]
		public unsafe static Vector3 operator *(float d, Vector3 a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000648C8 File Offset: 0x00062AC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 658970, RefRangeEnd = 658974, XrefRangeStart = 658970, XrefRangeEnd = 658970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator /(Vector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00064914 File Offset: 0x00062B14
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00064960 File Offset: 0x00062B60
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000649AC File Offset: 0x00062BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000649D8 File Offset: 0x00062BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658974, XrefRangeEnd = 659015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0000821A File Offset: 0x0000641A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00064A28 File Offset: 0x00062C28
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000822C File Offset: 0x0000642C
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00064A44 File Offset: 0x00062C44
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000823A File Offset: 0x0000643A
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00064A60 File Offset: 0x00062C60
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00008248 File Offset: 0x00006448
		public unsafe static Vector3 zeroVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00064A7C File Offset: 0x00062C7C
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x00008256 File Offset: 0x00006456
		public unsafe static Vector3 oneVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00064A98 File Offset: 0x00062C98
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00008264 File Offset: 0x00006464
		public unsafe static Vector3 upVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00064AB4 File Offset: 0x00062CB4
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00008272 File Offset: 0x00006472
		public unsafe static Vector3 downVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00064AD0 File Offset: 0x00062CD0
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00008280 File Offset: 0x00006480
		public unsafe static Vector3 leftVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00064AEC File Offset: 0x00062CEC
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000828E File Offset: 0x0000648E
		public unsafe static Vector3 rightVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x00064B08 File Offset: 0x00062D08
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000829C File Offset: 0x0000649C
		public unsafe static Vector3 forwardVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00064B24 File Offset: 0x00062D24
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x000082AA File Offset: 0x000064AA
		public unsafe static Vector3 backVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00064B40 File Offset: 0x00062D40
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x000082B8 File Offset: 0x000064B8
		public unsafe static Vector3 positiveInfinityVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00064B5C File Offset: 0x00062D5C
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x000082C6 File Offset: 0x000064C6
		public unsafe static Vector3 negativeInfinityVector
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00064B78 File Offset: 0x00062D78
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			Vector3 vector;
			Vector3.Slerp_Injected(ref a, ref b, t, out vector);
			return vector;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00064B94 File Offset: 0x00062D94
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			Vector3 vector;
			Vector3.SlerpUnclamped_Injected(ref a, ref b, t, out vector);
			return vector;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000082D4 File Offset: 0x000064D4
		public static void OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
			Vector3.OrthoNormalize2DelegateField(ref a, ref b);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000082E2 File Offset: 0x000064E2
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
			Vector3.OrthoNormalize2(ref normal, ref tangent);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000082ED File Offset: 0x000064ED
		public static void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
		{
			Vector3.OrthoNormalize3DelegateField(ref a, ref b, ref c);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000082FC File Offset: 0x000064FC
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.OrthoNormalize3(ref normal, ref tangent, ref binormal);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00064BB0 File Offset: 0x00062DB0
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			Vector3 vector;
			Vector3.RotateTowards_Injected(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out vector);
			return vector;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00064BCC File Offset: 0x00062DCC
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00008308 File Offset: 0x00006508
		public void Set(float newX, float newY, float newZ)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00064BF0 File Offset: 0x00062DF0
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			float num = -2f * Vector3.Dot(inNormal, inDirection);
			return new Vector3(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y, num * inNormal.z + inDirection.z);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00064C44 File Offset: 0x00062E44
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			float num = Vector3.Dot(onNormal, onNormal);
			bool flag = num < Mathf.Epsilon;
			Vector3 vector2;
			if (flag)
			{
				vector2 = Vector3.zero;
			}
			else
			{
				float num2 = Vector3.Dot(vector, onNormal);
				vector2 = new Vector3(onNormal.x * num2 / num, onNormal.y * num2 / num, onNormal.z * num2 / num);
			}
			return vector2;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00064CA0 File Offset: 0x00062EA0
		public static Vector3 positiveInfinity
		{
			get
			{
				return Vector3.positiveInfinityVector;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00064CB8 File Offset: 0x00062EB8
		public static Vector3 negativeInfinity
		{
			get
			{
				return Vector3.negativeInfinityVector;
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00064CD0 File Offset: 0x00062ED0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00064CEC File Offset: 0x00062EEC
		public static Vector3 fwd
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00064D14 File Offset: 0x00062F14
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return (float)Math.Acos((double)Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00064D50 File Offset: 0x00062F50
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return Vector3.ProjectOnPlane(fromThat, excludeThis);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00008320 File Offset: 0x00006520
		public static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			Vector3.Slerp_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00008330 File Offset: 0x00006530
		public static void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			Vector3.SlerpUnclamped_InjectedDelegateField(ref a, ref b, t, out ret);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00008340 File Offset: 0x00006540
		public static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret)
		{
			Vector3.RotateTowards_InjectedDelegateField(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out ret);
		}

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_forwardVector;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_backVector;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector3_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400134A RID: 4938
		[FieldOffset(0)]
		public float x;

		// Token: 0x0400134B RID: 4939
		[FieldOffset(4)]
		public float y;

		// Token: 0x0400134C RID: 4940
		[FieldOffset(8)]
		public float z;

		// Token: 0x0400134D RID: 4941
		private static readonly Vector3.OrthoNormalize2Delegate OrthoNormalize2DelegateField;

		// Token: 0x0400134E RID: 4942
		private static readonly Vector3.OrthoNormalize3Delegate OrthoNormalize3DelegateField;

		// Token: 0x0400134F RID: 4943
		private static readonly Vector3.Slerp_InjectedDelegate Slerp_InjectedDelegateField;

		// Token: 0x04001350 RID: 4944
		private static readonly Vector3.SlerpUnclamped_InjectedDelegate SlerpUnclamped_InjectedDelegateField;

		// Token: 0x04001351 RID: 4945
		private static readonly Vector3.RotateTowards_InjectedDelegate RotateTowards_InjectedDelegateField;

		// Token: 0x020006EC RID: 1772
		// (Invoke) Token: 0x060036B7 RID: 14007
		private delegate void OrthoNormalize2Delegate(IntPtr a, IntPtr b);

		// Token: 0x020006ED RID: 1773
		// (Invoke) Token: 0x060036B9 RID: 14009
		private delegate void OrthoNormalize3Delegate(IntPtr a, IntPtr b, IntPtr c);

		// Token: 0x020006EE RID: 1774
		// (Invoke) Token: 0x060036BB RID: 14011
		private delegate void Slerp_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x020006EF RID: 1775
		// (Invoke) Token: 0x060036BD RID: 14013
		private delegate void SlerpUnclamped_InjectedDelegate(IntPtr a, IntPtr b, float t, [Out] IntPtr ret);

		// Token: 0x020006F0 RID: 1776
		// (Invoke) Token: 0x060036BF RID: 14015
		private delegate void RotateTowards_InjectedDelegate(IntPtr current, IntPtr target, float maxRadiansDelta, float maxMagnitudeDelta, [Out] IntPtr ret);
	}
}
