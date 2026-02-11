using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000252 RID: 594
	[StructLayout(2)]
	public struct VisibleReflectionProbe
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x000A9A40 File Offset: 0x000A7C40
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleReflectionProbe()
		{
			Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr);
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Bounds");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_LocalToWorldMatrix");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_HdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_HdrData");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Center");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_BlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BlendDistance");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Importance");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_BoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BoxProjection");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_InstanceId");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_TextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_TextureId");
			VisibleReflectionProbe.NativeMethodInfoPtr_get_texture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668469);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668470);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668471);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668472);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668473);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668474);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_importance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668475);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668476);
			VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668477);
			VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668478);
			VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668479);
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x000A9C00 File Offset: 0x000A7E00
		public unsafe Texture texture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685435, RefRangeEnd = 685437, XrefRangeStart = 685429, XrefRangeEnd = 685435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_texture_Public_get_Texture_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000A9C34 File Offset: 0x000A7E34
		public unsafe ReflectionProbe reflectionProbe
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685443, RefRangeEnd = 685446, XrefRangeStart = 685437, XrefRangeEnd = 685443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr3) : null;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000A9C68 File Offset: 0x000A7E68
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0000FBA9 File Offset: 0x0000DDA9
		public unsafe Bounds bounds
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 685446, RefRangeEnd = 685456, XrefRangeStart = 685446, XrefRangeEnd = 685446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Bounds = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000A9C98 File Offset: 0x000A7E98
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685456, RefRangeEnd = 685459, XrefRangeStart = 685456, XrefRangeEnd = 685456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LocalToWorldMatrix = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000A9CC8 File Offset: 0x000A7EC8
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0000FBBD File Offset: 0x0000DDBD
		public unsafe Vector4 hdrData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685459, RefRangeEnd = 685461, XrefRangeStart = 685459, XrefRangeEnd = 685459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HdrData = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000A9CF8 File Offset: 0x000A7EF8
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x0000FBD1 File Offset: 0x0000DDD1
		public unsafe float blendDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685461, RefRangeEnd = 685462, XrefRangeStart = 685461, XrefRangeEnd = 685461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BlendDistance = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000A9D28 File Offset: 0x000A7F28
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0000FBDB File Offset: 0x0000DDDB
		public unsafe int importance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685462, RefRangeEnd = 685465, XrefRangeStart = 685462, XrefRangeEnd = 685462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_importance_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Importance = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000A9D58 File Offset: 0x000A7F58
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0000FBE5 File Offset: 0x0000DDE5
		public unsafe bool isBoxProjection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685469, RefRangeEnd = 685470, XrefRangeStart = 685465, XrefRangeEnd = 685469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoxProjection = Convert.ToInt32(value);
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000A9D88 File Offset: 0x000A7F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685473, RefRangeEnd = 685474, XrefRangeStart = 685470, XrefRangeEnd = 685473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisibleReflectionProbe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000A9DC8 File Offset: 0x000A7FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685474, XrefRangeEnd = 685478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000A9E0C File Offset: 0x000A800C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685478, XrefRangeEnd = 685493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0000FB97 File Offset: 0x0000DD97
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, ref this));
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000A9E3C File Offset: 0x000A803C
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0000FBC7 File Offset: 0x0000DDC7
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000A9E54 File Offset: 0x000A8054
		public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return left.Equals(right);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000A9E70 File Offset: 0x000A8070
		public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeFieldInfoPtr_m_Bounds;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeFieldInfoPtr_m_HdrData;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendDistance;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeFieldInfoPtr_m_Importance;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeFieldInfoPtr_m_BoxProjection;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceId;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureId;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeMethodInfoPtr_get_importance_Public_get_Int32_0;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400242E RID: 9262
		[FieldOffset(0)]
		public Bounds m_Bounds;

		// Token: 0x0400242F RID: 9263
		[FieldOffset(24)]
		public Matrix4x4 m_LocalToWorldMatrix;

		// Token: 0x04002430 RID: 9264
		[FieldOffset(88)]
		public Vector4 m_HdrData;

		// Token: 0x04002431 RID: 9265
		[FieldOffset(104)]
		public Vector3 m_Center;

		// Token: 0x04002432 RID: 9266
		[FieldOffset(116)]
		public float m_BlendDistance;

		// Token: 0x04002433 RID: 9267
		[FieldOffset(120)]
		public int m_Importance;

		// Token: 0x04002434 RID: 9268
		[FieldOffset(124)]
		public int m_BoxProjection;

		// Token: 0x04002435 RID: 9269
		[FieldOffset(128)]
		public int m_InstanceId;

		// Token: 0x04002436 RID: 9270
		[FieldOffset(132)]
		public int m_TextureId;
	}
}
