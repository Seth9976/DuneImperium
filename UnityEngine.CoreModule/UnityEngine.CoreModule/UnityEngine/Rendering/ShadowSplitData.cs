using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000249 RID: 585
	[StructLayout(2)]
	public struct ShadowSplitData
	{
		// Token: 0x06002793 RID: 10131 RVA: 0x000A6FEC File Offset: 0x000A51EC
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowSplitData()
		{
			Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowSplitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr);
			ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "k_MaximumCullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "maximumCullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlanes");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingSphere");
			ShadowSplitData.NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_ShadowCascadeBlendCullingFactor");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingNearPlane");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingMatrix");
			ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668376);
			ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668377);
			ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668378);
			ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668379);
			ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668380);
			ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668381);
			ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668382);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000A7148 File Offset: 0x000A5348
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x000A7308 File Offset: 0x000A5508
		public unsafe int cullingPlaneCount
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0 || value > 10;
				if (flag)
				{
					throw new ArgumentException(String.Format("Value should range from {0} to ShadowSplitData.maximumCullingPlaneCount ({1}), but was {2}.", 0, 10, value));
				}
				this.m_CullingPlaneCount = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000A7178 File Offset: 0x000A5378
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0000F5E1 File Offset: 0x0000D7E1
		public unsafe Vector4 cullingSphere
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685000, RefRangeEnd = 685001, XrefRangeStart = 685000, XrefRangeEnd = 685000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CullingSphere = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000A7380 File Offset: 0x000A5580
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x000A71A8 File Offset: 0x000A53A8
		public unsafe float shadowCascadeBlendCullingFactor
		{
			get
			{
				return this.m_ShadowCascadeBlendCullingFactor;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685001, RefRangeEnd = 685003, XrefRangeStart = 685001, XrefRangeEnd = 685001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000A71DC File Offset: 0x000A53DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 685006, RefRangeEnd = 685008, XrefRangeStart = 685003, XrefRangeEnd = 685006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCullingPlane(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000A721C File Offset: 0x000A541C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 685021, RefRangeEnd = 685023, XrefRangeStart = 685008, XrefRangeEnd = 685021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ShadowSplitData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000A725C File Offset: 0x000A545C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685023, XrefRangeEnd = 685029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000A72A0 File Offset: 0x000A54A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685033, RefRangeEnd = 685034, XrefRangeStart = 685029, XrefRangeEnd = 685033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0000F5B3 File Offset: 0x0000D7B3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, ref this));
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000A72D0 File Offset: 0x000A54D0
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x0000F5C5 File Offset: 0x0000D7C5
		public unsafe static int k_MaximumCullingPlaneCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000A72EC File Offset: 0x000A54EC
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x0000F5D3 File Offset: 0x0000D7D3
		public unsafe static int maximumCullingPlaneCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000A7350 File Offset: 0x000A5550
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x0000F5EB File Offset: 0x0000D7EB
		public Matrix4x4 cullingMatrix
		{
			get
			{
				return this.m_CullingMatrix;
			}
			set
			{
				this.m_CullingMatrix = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000A7368 File Offset: 0x000A5568
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0000F5F5 File Offset: 0x0000D7F5
		public float cullingNearPlane
		{
			get
			{
				return this.m_CullingNearPlane;
			}
			set
			{
				this.m_CullingNearPlane = value;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0000F5FF File Offset: 0x0000D7FF
		public void SetCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000A7398 File Offset: 0x000A5598
		public static bool operator ==(ShadowSplitData left, ShadowSplitData right)
		{
			return left.Equals(right);
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000A73B4 File Offset: 0x000A55B4
		public static bool operator !=(ShadowSplitData left, ShadowSplitData right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlanes;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingSphere;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingNearPlane;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMatrix;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002359 RID: 9049
		[FieldOffset(0)]
		public int m_CullingPlaneCount;

		// Token: 0x0400235A RID: 9050
		[FieldOffset(4)]
		public ShadowSplitData._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

		// Token: 0x0400235B RID: 9051
		[FieldOffset(164)]
		public Vector4 m_CullingSphere;

		// Token: 0x0400235C RID: 9052
		[FieldOffset(180)]
		public float m_ShadowCascadeBlendCullingFactor;

		// Token: 0x0400235D RID: 9053
		[FieldOffset(184)]
		public float m_CullingNearPlane;

		// Token: 0x0400235E RID: 9054
		[FieldOffset(188)]
		public Matrix4x4 m_CullingMatrix;

		// Token: 0x020009E7 RID: 2535
		[ObfuscatedName("UnityEngine.Rendering.ShadowSplitData+<m_CullingPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CullingPlanes_e__FixedBuffer
		{
			// Token: 0x06003CEE RID: 15598 RVA: 0x0001675B File Offset: 0x0001495B
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CullingPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
				ShadowSplitData._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CEF RID: 15599 RVA: 0x0001678F File Offset: 0x0001498F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D3A RID: 11578
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D3B RID: 11579
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
