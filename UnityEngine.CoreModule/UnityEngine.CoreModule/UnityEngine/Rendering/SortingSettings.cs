using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024D RID: 589
	[StructLayout(2)]
	public struct SortingSettings
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x000A7678 File Offset: 0x000A5878
		// Note: this type is marked as 'beforefieldinit'.
		static SortingSettings()
		{
			Il2CppClassPointerStore<SortingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr);
			SortingSettings.NativeFieldInfoPtr_m_WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_WorldToCameraMatrix");
			SortingSettings.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CameraPosition");
			SortingSettings.NativeFieldInfoPtr_m_CustomAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CustomAxis");
			SortingSettings.NativeFieldInfoPtr_m_Criteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_Criteria");
			SortingSettings.NativeFieldInfoPtr_m_DistanceMetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_DistanceMetric");
			SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668391);
			SortingSettings.NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668392);
			SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668393);
			SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668394);
			SortingSettings.NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668395);
			SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668396);
			SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668397);
			SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668398);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000A77AC File Offset: 0x000A59AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685046, RefRangeEnd = 685049, XrefRangeStart = 685041, XrefRangeEnd = 685046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingSettings(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x000A7994 File Offset: 0x000A5B94
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x000A77E4 File Offset: 0x000A59E4
		public unsafe Vector3 customAxis
		{
			get
			{
				return this.m_CustomAxis;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685049, RefRangeEnd = 685052, XrefRangeStart = 685049, XrefRangeEnd = 685049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000A7818 File Offset: 0x000A5A18
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x000A7848 File Offset: 0x000A5A48
		public unsafe SortingCriteria criteria
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000A79AC File Offset: 0x000A5BAC
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x000A787C File Offset: 0x000A5A7C
		public unsafe DistanceMetric distanceMetric
		{
			get
			{
				return this.m_DistanceMetric;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 403825, RefRangeEnd = 403834, XrefRangeStart = 403825, XrefRangeEnd = 403834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000A78B0 File Offset: 0x000A5AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 685054, RefRangeEnd = 685056, XrefRangeStart = 685052, XrefRangeEnd = 685054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SortingSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000A78F0 File Offset: 0x000A5AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685056, XrefRangeEnd = 685060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000A7934 File Offset: 0x000A5B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 685067, RefRangeEnd = 685069, XrefRangeStart = 685060, XrefRangeEnd = 685067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0000F632 File Offset: 0x0000D832
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000A7964 File Offset: 0x000A5B64
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x0000F644 File Offset: 0x0000D844
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return this.m_WorldToCameraMatrix;
			}
			set
			{
				this.m_WorldToCameraMatrix = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000A797C File Offset: 0x000A5B7C
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x0000F64E File Offset: 0x0000D84E
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000A79C4 File Offset: 0x000A5BC4
		public static bool operator ==(SortingSettings left, SortingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000A79E0 File Offset: 0x000A5BE0
		public static bool operator !=(SortingSettings left, SortingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldToCameraMatrix;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomAxis;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeFieldInfoPtr_m_Criteria;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeFieldInfoPtr_m_DistanceMetric;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002386 RID: 9094
		[FieldOffset(0)]
		public Matrix4x4 m_WorldToCameraMatrix;

		// Token: 0x04002387 RID: 9095
		[FieldOffset(64)]
		public Vector3 m_CameraPosition;

		// Token: 0x04002388 RID: 9096
		[FieldOffset(76)]
		public Vector3 m_CustomAxis;

		// Token: 0x04002389 RID: 9097
		[FieldOffset(88)]
		public SortingCriteria m_Criteria;

		// Token: 0x0400238A RID: 9098
		[FieldOffset(92)]
		public DistanceMetric m_DistanceMetric;
	}
}
