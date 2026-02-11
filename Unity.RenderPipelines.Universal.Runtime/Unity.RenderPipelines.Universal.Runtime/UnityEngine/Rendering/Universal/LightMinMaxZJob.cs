using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000DC RID: 220
	public sealed class LightMinMaxZJob : ValueType
	{
		// Token: 0x060010E4 RID: 4324 RVA: 0x00050518 File Offset: 0x0004E718
		// Note: this type is marked as 'beforefieldinit'.
		static LightMinMaxZJob()
		{
			Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightMinMaxZJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr);
			LightMinMaxZJob.NativeFieldInfoPtr_worldToViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "worldToViews");
			LightMinMaxZJob.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "lights");
			LightMinMaxZJob.NativeFieldInfoPtr_minMaxZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "minMaxZs");
			LightMinMaxZJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, 100665473);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00050598 File Offset: 0x0004E798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617957, RefRangeEnd = 617958, XrefRangeStart = 617927, XrefRangeEnd = 617957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightMinMaxZJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0000A015 File Offset: 0x00008215
		public LightMinMaxZJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0000A01E File Offset: 0x0000821E
		public LightMinMaxZJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr))
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x000505DC File Offset: 0x0004E7DC
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0000A030 File Offset: 0x00008230
		public Fixed2<float4x4> worldToViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_worldToViews);
				return new Fixed2<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_worldToViews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0005060C File Offset: 0x0004E80C
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x0000A05E File Offset: 0x0000825E
		public NativeArray<VisibleLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_lights);
				return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_lights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0005063C File Offset: 0x0004E83C
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x0000A08C File Offset: 0x0000828C
		public NativeArray<float2> minMaxZs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_minMaxZs);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMinMaxZJob.NativeFieldInfoPtr_minMaxZs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_worldToViews;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_minMaxZs;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
	}
}
