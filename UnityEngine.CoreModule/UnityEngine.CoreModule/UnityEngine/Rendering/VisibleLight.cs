using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000250 RID: 592
	[StructLayout(2)]
	public struct VisibleLight
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x000A95E8 File Offset: 0x000A77E8
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleLight()
		{
			Il2CppClassPointerStore<VisibleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr);
			VisibleLight.NativeFieldInfoPtr_m_LightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LightType");
			VisibleLight.NativeFieldInfoPtr_m_FinalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_FinalColor");
			VisibleLight.NativeFieldInfoPtr_m_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_ScreenRect");
			VisibleLight.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LocalToWorldMatrix");
			VisibleLight.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Range");
			VisibleLight.NativeFieldInfoPtr_m_SpotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_SpotAngle");
			VisibleLight.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_InstanceId");
			VisibleLight.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Flags");
			VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668460);
			VisibleLight.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668461);
			VisibleLight.NativeMethodInfoPtr_get_finalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668462);
			VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668463);
			VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668464);
			VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668465);
			VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668466);
			VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668467);
			VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668468);
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000A976C File Offset: 0x000A796C
		public unsafe Light light
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 685329, RefRangeEnd = 685363, XrefRangeStart = 685323, XrefRangeEnd = 685329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000A97A0 File Offset: 0x000A79A0
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0000FB5B File Offset: 0x0000DD5B
		public unsafe LightType lightType
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LightType = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x000A97D0 File Offset: 0x000A79D0
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x0000FB65 File Offset: 0x0000DD65
		public unsafe Color finalColor
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 685363, RefRangeEnd = 685371, XrefRangeStart = 685363, XrefRangeEnd = 685363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_finalColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FinalColor = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000A9800 File Offset: 0x000A7A00
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0000FB79 File Offset: 0x0000DD79
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 685371, RefRangeEnd = 685382, XrefRangeStart = 685371, XrefRangeEnd = 685371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LocalToWorldMatrix = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x000A9830 File Offset: 0x000A7A30
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x0000FB83 File Offset: 0x0000DD83
		public unsafe float range
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 685382, RefRangeEnd = 685397, XrefRangeStart = 685382, XrefRangeEnd = 685382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Range = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000A9860 File Offset: 0x000A7A60
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public unsafe float spotAngle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 685397, RefRangeEnd = 685404, XrefRangeStart = 685397, XrefRangeEnd = 685397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SpotAngle = value;
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000A9890 File Offset: 0x000A7A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685416, RefRangeEnd = 685417, XrefRangeStart = 685404, XrefRangeEnd = 685416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisibleLight other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000A98D0 File Offset: 0x000A7AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685417, XrefRangeEnd = 685421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000A9914 File Offset: 0x000A7B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685421, XrefRangeEnd = 685429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0000FB49 File Offset: 0x0000DD49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x000A9944 File Offset: 0x000A7B44
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x0000FB6F File Offset: 0x0000DD6F
		public Rect screenRect
		{
			get
			{
				return this.m_ScreenRect;
			}
			set
			{
				this.m_ScreenRect = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000A995C File Offset: 0x000A7B5C
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x000A997C File Offset: 0x000A7B7C
		public bool intersectsNearPlane
		{
			get
			{
				return (this.m_Flags & VisibleLightFlags.IntersectsNearPlane) > (VisibleLightFlags)0;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= VisibleLightFlags.IntersectsNearPlane;
				}
				else
				{
					this.m_Flags &= ~VisibleLightFlags.IntersectsNearPlane;
				}
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000A99B0 File Offset: 0x000A7BB0
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x000A99D0 File Offset: 0x000A7BD0
		public bool intersectsFarPlane
		{
			get
			{
				return (this.m_Flags & VisibleLightFlags.IntersectsFarPlane) > (VisibleLightFlags)0;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= VisibleLightFlags.IntersectsFarPlane;
				}
				else
				{
					this.m_Flags &= ~VisibleLightFlags.IntersectsFarPlane;
				}
			}
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000A9A04 File Offset: 0x000A7C04
		public static bool operator ==(VisibleLight left, VisibleLight right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000A9A20 File Offset: 0x000A7C20
		public static bool operator !=(VisibleLight left, VisibleLight right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeFieldInfoPtr_m_LightType;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalColor;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenRect;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotAngle;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceId;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr_get_light_Public_get_Light_0;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeMethodInfoPtr_get_lightType_Public_get_LightType_0;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr_get_finalColor_Public_get_Color_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400240F RID: 9231
		[FieldOffset(0)]
		public LightType m_LightType;

		// Token: 0x04002410 RID: 9232
		[FieldOffset(4)]
		public Color m_FinalColor;

		// Token: 0x04002411 RID: 9233
		[FieldOffset(20)]
		public Rect m_ScreenRect;

		// Token: 0x04002412 RID: 9234
		[FieldOffset(36)]
		public Matrix4x4 m_LocalToWorldMatrix;

		// Token: 0x04002413 RID: 9235
		[FieldOffset(100)]
		public float m_Range;

		// Token: 0x04002414 RID: 9236
		[FieldOffset(104)]
		public float m_SpotAngle;

		// Token: 0x04002415 RID: 9237
		[FieldOffset(108)]
		public int m_InstanceId;

		// Token: 0x04002416 RID: 9238
		[FieldOffset(112)]
		public VisibleLightFlags m_Flags;
	}
}
