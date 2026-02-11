using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000277 RID: 631
	[StructLayout(2)]
	public struct LightDataGI
	{
		// Token: 0x06002B1A RID: 11034 RVA: 0x000AEBD4 File Offset: 0x000ACDD4
		// Note: this type is marked as 'beforefieldinit'.
		static LightDataGI()
		{
			Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightDataGI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
			LightDataGI.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "instanceID");
			LightDataGI.NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieID");
			LightDataGI.NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieScale");
			LightDataGI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "color");
			LightDataGI.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "indirectColor");
			LightDataGI.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "orientation");
			LightDataGI.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "position");
			LightDataGI.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "range");
			LightDataGI.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "coneAngle");
			LightDataGI.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "innerConeAngle");
			LightDataGI.NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape0");
			LightDataGI.NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape1");
			LightDataGI.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "type");
			LightDataGI.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "mode");
			LightDataGI.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shadow");
			LightDataGI.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "falloff");
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668592);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668593);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668594);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668595);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668596);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668597);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668598);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668599);
			LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668600);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000AEDF8 File Offset: 0x000ACFF8
		[CallerCount(0)]
		public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000AEE38 File Offset: 0x000AD038
		[CallerCount(0)]
		public unsafe void Init(ref PointLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000AEE78 File Offset: 0x000AD078
		[CallerCount(0)]
		public unsafe void Init(ref SpotLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000AEEB8 File Offset: 0x000AD0B8
		[CallerCount(0)]
		public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000AEEF8 File Offset: 0x000AD0F8
		[CallerCount(0)]
		public unsafe void Init(ref DiscLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000AEF38 File Offset: 0x000AD138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685962, RefRangeEnd = 685963, XrefRangeStart = 685962, XrefRangeEnd = 685962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref DirectionalLight light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000AEF6C File Offset: 0x000AD16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685963, RefRangeEnd = 685964, XrefRangeStart = 685963, XrefRangeEnd = 685963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref PointLight light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000AEFA0 File Offset: 0x000AD1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685964, RefRangeEnd = 685965, XrefRangeStart = 685964, XrefRangeEnd = 685964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref SpotLight light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000AEFD4 File Offset: 0x000AD1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 685965, RefRangeEnd = 685967, XrefRangeStart = 685965, XrefRangeEnd = 685965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoBake(int lightInstanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightInstanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00010DE5 File Offset: 0x0000EFE5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000AF008 File Offset: 0x000AD208
		public void Init(ref RectangleLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000AF028 File Offset: 0x000AD228
		public void Init(ref DiscLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeFieldInfoPtr_cookieID;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeFieldInfoPtr_cookieScale;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeFieldInfoPtr_shape0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeFieldInfoPtr_shape1;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;

		// Token: 0x04002639 RID: 9785
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x0400263A RID: 9786
		[FieldOffset(4)]
		public int cookieID;

		// Token: 0x0400263B RID: 9787
		[FieldOffset(8)]
		public float cookieScale;

		// Token: 0x0400263C RID: 9788
		[FieldOffset(12)]
		public LinearColor color;

		// Token: 0x0400263D RID: 9789
		[FieldOffset(28)]
		public LinearColor indirectColor;

		// Token: 0x0400263E RID: 9790
		[FieldOffset(44)]
		public Quaternion orientation;

		// Token: 0x0400263F RID: 9791
		[FieldOffset(60)]
		public Vector3 position;

		// Token: 0x04002640 RID: 9792
		[FieldOffset(72)]
		public float range;

		// Token: 0x04002641 RID: 9793
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x04002642 RID: 9794
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x04002643 RID: 9795
		[FieldOffset(84)]
		public float shape0;

		// Token: 0x04002644 RID: 9796
		[FieldOffset(88)]
		public float shape1;

		// Token: 0x04002645 RID: 9797
		[FieldOffset(92)]
		public LightType type;

		// Token: 0x04002646 RID: 9798
		[FieldOffset(93)]
		public LightMode mode;

		// Token: 0x04002647 RID: 9799
		[FieldOffset(94)]
		public byte shadow;

		// Token: 0x04002648 RID: 9800
		[FieldOffset(95)]
		public FalloffType falloff;
	}
}
