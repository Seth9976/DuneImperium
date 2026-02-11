using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000217 RID: 535
	[StructLayout(2)]
	public struct SphericalHarmonicsL2
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x0009C374 File Offset: 0x0009A574
		// Note: this type is marked as 'beforefieldinit'.
		static SphericalHarmonicsL2()
		{
			Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SphericalHarmonicsL2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr);
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr8");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg8");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb8");
			SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668047);
			SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668048);
			SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668049);
			SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668050);
			SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668051);
			SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668052);
			SphericalHarmonicsL2.EvaluateInternalDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.EvaluateInternalDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::EvaluateInternal");
			SphericalHarmonicsL2.SetZero_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.SetZero_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::SetZero_Injected");
			SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddAmbientLight_Injected");
			SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddDirectionalLightInternal_Injected");
		}

		// Token: 0x1700071F RID: 1823
		public unsafe float this[int rgb, int coefficient]
		{
			[CallerCount(72)]
			[CachedScanResults(RefRangeStart = 683105, RefRangeEnd = 683177, XrefRangeStart = 683105, XrefRangeEnd = 683105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rgb;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficient;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 683177, RefRangeEnd = 683201, XrefRangeStart = 683177, XrefRangeEnd = 683177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rgb;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficient;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0009C710 File Offset: 0x0009A910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683201, XrefRangeEnd = 683228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0009C740 File Offset: 0x0009A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683228, XrefRangeEnd = 683232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0009C784 File Offset: 0x0009A984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683232, XrefRangeEnd = 683233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SphericalHarmonicsL2 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0009C7C4 File Offset: 0x0009A9C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683233, RefRangeEnd = 683235, XrefRangeStart = 683233, XrefRangeEnd = 683233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0000E494 File Offset: 0x0000C694
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, ref this));
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0000E4A6 File Offset: 0x0000C6A6
		public void Clear()
		{
			this.SetZero();
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public void SetZero()
		{
			SphericalHarmonicsL2.SetZero_Injected(ref this);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		public void AddAmbientLight(Color color)
		{
			SphericalHarmonicsL2.AddAmbientLight_Injected(ref this, ref color);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0009C810 File Offset: 0x0009AA10
		public void AddDirectionalLight(Vector3 direction, Color color, float intensity)
		{
			Color color2 = color * (2f * intensity);
			SphericalHarmonicsL2.AddDirectionalLightInternal(ref this, direction, color2);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0000E4C2 File Offset: 0x0000C6C2
		public static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color)
		{
			SphericalHarmonicsL2.AddDirectionalLightInternal_Injected(ref sh, ref direction, ref color);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0009C838 File Offset: 0x0009AA38
		public void Evaluate(Il2CppStructArray<Vector3> directions, Il2CppStructArray<Color> results)
		{
			bool flag = directions == null;
			if (flag)
			{
				throw new ArgumentNullException("directions");
			}
			bool flag2 = results == null;
			if (flag2)
			{
				throw new ArgumentNullException("results");
			}
			bool flag3 = directions.Length == 0;
			if (!flag3)
			{
				bool flag4 = directions.Length != results.Length;
				if (flag4)
				{
					throw new ArgumentException("Length of the directions array and the results array must match.");
				}
				SphericalHarmonicsL2.EvaluateInternal(ref this, directions, results);
			}
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0000E4CE File Offset: 0x0000C6CE
		public static void EvaluateInternal(ref SphericalHarmonicsL2 sh, Il2CppStructArray<Vector3> directions, [Out] Il2CppStructArray<Color> results)
		{
			SphericalHarmonicsL2.EvaluateInternalDelegateField(ref sh, IL2CPP.Il2CppObjectBaseToPtr(directions), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0009C8A8 File Offset: 0x0009AAA8
		public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = lhs.shr0 * rhs,
				shr1 = lhs.shr1 * rhs,
				shr2 = lhs.shr2 * rhs,
				shr3 = lhs.shr3 * rhs,
				shr4 = lhs.shr4 * rhs,
				shr5 = lhs.shr5 * rhs,
				shr6 = lhs.shr6 * rhs,
				shr7 = lhs.shr7 * rhs,
				shr8 = lhs.shr8 * rhs,
				shg0 = lhs.shg0 * rhs,
				shg1 = lhs.shg1 * rhs,
				shg2 = lhs.shg2 * rhs,
				shg3 = lhs.shg3 * rhs,
				shg4 = lhs.shg4 * rhs,
				shg5 = lhs.shg5 * rhs,
				shg6 = lhs.shg6 * rhs,
				shg7 = lhs.shg7 * rhs,
				shg8 = lhs.shg8 * rhs,
				shb0 = lhs.shb0 * rhs,
				shb1 = lhs.shb1 * rhs,
				shb2 = lhs.shb2 * rhs,
				shb3 = lhs.shb3 * rhs,
				shb4 = lhs.shb4 * rhs,
				shb5 = lhs.shb5 * rhs,
				shb6 = lhs.shb6 * rhs,
				shb7 = lhs.shb7 * rhs,
				shb8 = lhs.shb8 * rhs
			};
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0009CA58 File Offset: 0x0009AC58
		public static SphericalHarmonicsL2 operator *(float lhs, SphericalHarmonicsL2 rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = rhs.shr0 * lhs,
				shr1 = rhs.shr1 * lhs,
				shr2 = rhs.shr2 * lhs,
				shr3 = rhs.shr3 * lhs,
				shr4 = rhs.shr4 * lhs,
				shr5 = rhs.shr5 * lhs,
				shr6 = rhs.shr6 * lhs,
				shr7 = rhs.shr7 * lhs,
				shr8 = rhs.shr8 * lhs,
				shg0 = rhs.shg0 * lhs,
				shg1 = rhs.shg1 * lhs,
				shg2 = rhs.shg2 * lhs,
				shg3 = rhs.shg3 * lhs,
				shg4 = rhs.shg4 * lhs,
				shg5 = rhs.shg5 * lhs,
				shg6 = rhs.shg6 * lhs,
				shg7 = rhs.shg7 * lhs,
				shg8 = rhs.shg8 * lhs,
				shb0 = rhs.shb0 * lhs,
				shb1 = rhs.shb1 * lhs,
				shb2 = rhs.shb2 * lhs,
				shb3 = rhs.shb3 * lhs,
				shb4 = rhs.shb4 * lhs,
				shb5 = rhs.shb5 * lhs,
				shb6 = rhs.shb6 * lhs,
				shb7 = rhs.shb7 * lhs,
				shb8 = rhs.shb8 * lhs
			};
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0009CC08 File Offset: 0x0009AE08
		public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = lhs.shr0 + rhs.shr0,
				shr1 = lhs.shr1 + rhs.shr1,
				shr2 = lhs.shr2 + rhs.shr2,
				shr3 = lhs.shr3 + rhs.shr3,
				shr4 = lhs.shr4 + rhs.shr4,
				shr5 = lhs.shr5 + rhs.shr5,
				shr6 = lhs.shr6 + rhs.shr6,
				shr7 = lhs.shr7 + rhs.shr7,
				shr8 = lhs.shr8 + rhs.shr8,
				shg0 = lhs.shg0 + rhs.shg0,
				shg1 = lhs.shg1 + rhs.shg1,
				shg2 = lhs.shg2 + rhs.shg2,
				shg3 = lhs.shg3 + rhs.shg3,
				shg4 = lhs.shg4 + rhs.shg4,
				shg5 = lhs.shg5 + rhs.shg5,
				shg6 = lhs.shg6 + rhs.shg6,
				shg7 = lhs.shg7 + rhs.shg7,
				shg8 = lhs.shg8 + rhs.shg8,
				shb0 = lhs.shb0 + rhs.shb0,
				shb1 = lhs.shb1 + rhs.shb1,
				shb2 = lhs.shb2 + rhs.shb2,
				shb3 = lhs.shb3 + rhs.shb3,
				shb4 = lhs.shb4 + rhs.shb4,
				shb5 = lhs.shb5 + rhs.shb5,
				shb6 = lhs.shb6 + rhs.shb6,
				shb7 = lhs.shb7 + rhs.shb7,
				shb8 = lhs.shb8 + rhs.shb8
			};
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0009CE40 File Offset: 0x0009B040
		public static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0000E4E7 File Offset: 0x0000C6E7
		public static void SetZero_Injected(ref SphericalHarmonicsL2 _unity_self)
		{
			SphericalHarmonicsL2.SetZero_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, ref Color color)
		{
			SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField(ref _unity_self, ref color);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0000E502 File Offset: 0x0000C702
		public static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, ref Vector3 direction, ref Color color)
		{
			SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField(ref sh, ref direction, ref color);
		}

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_shr0;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr_shr1;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_shr2;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_shr3;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_shr4;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_shr5;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr_shr6;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr_shr7;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeFieldInfoPtr_shr8;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeFieldInfoPtr_shg0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeFieldInfoPtr_shg1;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr_shg2;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_shg3;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_shg4;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_shg5;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_shg6;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr_shg7;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_shg8;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_shb0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_shb1;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_shb2;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_shb3;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_shb4;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_shb5;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_shb6;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeFieldInfoPtr_shb7;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_shb8;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0;

		// Token: 0x04001FCB RID: 8139
		[FieldOffset(0)]
		public float shr0;

		// Token: 0x04001FCC RID: 8140
		[FieldOffset(4)]
		public float shr1;

		// Token: 0x04001FCD RID: 8141
		[FieldOffset(8)]
		public float shr2;

		// Token: 0x04001FCE RID: 8142
		[FieldOffset(12)]
		public float shr3;

		// Token: 0x04001FCF RID: 8143
		[FieldOffset(16)]
		public float shr4;

		// Token: 0x04001FD0 RID: 8144
		[FieldOffset(20)]
		public float shr5;

		// Token: 0x04001FD1 RID: 8145
		[FieldOffset(24)]
		public float shr6;

		// Token: 0x04001FD2 RID: 8146
		[FieldOffset(28)]
		public float shr7;

		// Token: 0x04001FD3 RID: 8147
		[FieldOffset(32)]
		public float shr8;

		// Token: 0x04001FD4 RID: 8148
		[FieldOffset(36)]
		public float shg0;

		// Token: 0x04001FD5 RID: 8149
		[FieldOffset(40)]
		public float shg1;

		// Token: 0x04001FD6 RID: 8150
		[FieldOffset(44)]
		public float shg2;

		// Token: 0x04001FD7 RID: 8151
		[FieldOffset(48)]
		public float shg3;

		// Token: 0x04001FD8 RID: 8152
		[FieldOffset(52)]
		public float shg4;

		// Token: 0x04001FD9 RID: 8153
		[FieldOffset(56)]
		public float shg5;

		// Token: 0x04001FDA RID: 8154
		[FieldOffset(60)]
		public float shg6;

		// Token: 0x04001FDB RID: 8155
		[FieldOffset(64)]
		public float shg7;

		// Token: 0x04001FDC RID: 8156
		[FieldOffset(68)]
		public float shg8;

		// Token: 0x04001FDD RID: 8157
		[FieldOffset(72)]
		public float shb0;

		// Token: 0x04001FDE RID: 8158
		[FieldOffset(76)]
		public float shb1;

		// Token: 0x04001FDF RID: 8159
		[FieldOffset(80)]
		public float shb2;

		// Token: 0x04001FE0 RID: 8160
		[FieldOffset(84)]
		public float shb3;

		// Token: 0x04001FE1 RID: 8161
		[FieldOffset(88)]
		public float shb4;

		// Token: 0x04001FE2 RID: 8162
		[FieldOffset(92)]
		public float shb5;

		// Token: 0x04001FE3 RID: 8163
		[FieldOffset(96)]
		public float shb6;

		// Token: 0x04001FE4 RID: 8164
		[FieldOffset(100)]
		public float shb7;

		// Token: 0x04001FE5 RID: 8165
		[FieldOffset(104)]
		public float shb8;

		// Token: 0x04001FE6 RID: 8166
		private static readonly SphericalHarmonicsL2.EvaluateInternalDelegate EvaluateInternalDelegateField;

		// Token: 0x04001FE7 RID: 8167
		private static readonly SphericalHarmonicsL2.SetZero_InjectedDelegate SetZero_InjectedDelegateField;

		// Token: 0x04001FE8 RID: 8168
		private static readonly SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate AddAmbientLight_InjectedDelegateField;

		// Token: 0x04001FE9 RID: 8169
		private static readonly SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate AddDirectionalLightInternal_InjectedDelegateField;

		// Token: 0x020009B7 RID: 2487
		// (Invoke) Token: 0x06003C88 RID: 15496
		private delegate void EvaluateInternalDelegate(IntPtr sh, IntPtr directions, [Out] IntPtr results);

		// Token: 0x020009B8 RID: 2488
		// (Invoke) Token: 0x06003C8A RID: 15498
		private delegate void SetZero_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B9 RID: 2489
		// (Invoke) Token: 0x06003C8C RID: 15500
		private delegate void AddAmbientLight_InjectedDelegate(IntPtr _unity_self, IntPtr color);

		// Token: 0x020009BA RID: 2490
		// (Invoke) Token: 0x06003C8E RID: 15502
		private delegate void AddDirectionalLightInternal_InjectedDelegate(IntPtr sh, IntPtr direction, IntPtr color);
	}
}
