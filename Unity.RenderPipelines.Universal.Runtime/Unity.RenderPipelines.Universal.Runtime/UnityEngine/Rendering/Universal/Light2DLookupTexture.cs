using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000032 RID: 50
	public static class Light2DLookupTexture : Object
	{
		// Token: 0x060003AA RID: 938 RVA: 0x00022C20 File Offset: 0x00020E20
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DLookupTexture()
		{
			Il2CppClassPointerStore<Light2DLookupTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Light2DLookupTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DLookupTexture>.NativeClassPtr);
			Light2DLookupTexture.NativeFieldInfoPtr_s_PointLightLookupTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DLookupTexture>.NativeClassPtr, "s_PointLightLookupTexture");
			Light2DLookupTexture.NativeMethodInfoPtr_GetLightLookupTexture_Public_Static_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DLookupTexture>.NativeClassPtr, 100663762);
			Light2DLookupTexture.NativeMethodInfoPtr_CreatePointLightLookupTexture_Private_Static_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DLookupTexture>.NativeClassPtr, 100663763);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00022C8C File Offset: 0x00020E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600999, XrefRangeEnd = 601010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture GetLightLookupTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DLookupTexture.NativeMethodInfoPtr_GetLightLookupTexture_Public_Static_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00022CC0 File Offset: 0x00020EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601033, RefRangeEnd = 601035, XrefRangeStart = 601010, XrefRangeEnd = 601033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D CreatePointLightLookupTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DLookupTexture.NativeMethodInfoPtr_CreatePointLightLookupTexture_Private_Static_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000038DD File Offset: 0x00001ADD
		public Light2DLookupTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00022CF4 File Offset: 0x00020EF4
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000038E6 File Offset: 0x00001AE6
		public unsafe static Texture2D s_PointLightLookupTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Light2DLookupTexture.NativeFieldInfoPtr_s_PointLightLookupTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Light2DLookupTexture.NativeFieldInfoPtr_s_PointLightLookupTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_s_PointLightLookupTexture;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_GetLightLookupTexture_Public_Static_Texture_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_CreatePointLightLookupTexture_Private_Static_Texture2D_0;
	}
}
