using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000DD RID: 221
	public sealed class ReflectionProbeMinMaxZJob : ValueType
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x0005066C File Offset: 0x0004E86C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeMinMaxZJob()
		{
			Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ReflectionProbeMinMaxZJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr);
			ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_worldToViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr, "worldToViews");
			ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_reflectionProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr, "reflectionProbes");
			ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_minMaxZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr, "minMaxZs");
			ReflectionProbeMinMaxZJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr, 100665474);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000506EC File Offset: 0x0004E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617958, XrefRangeEnd = 617965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeMinMaxZJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0000A0BA File Offset: 0x000082BA
		public ReflectionProbeMinMaxZJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0000A0C3 File Offset: 0x000082C3
		public ReflectionProbeMinMaxZJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeMinMaxZJob>.NativeClassPtr))
		{
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00050730 File Offset: 0x0004E930
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x0000A0D5 File Offset: 0x000082D5
		public Fixed2<float4x4> worldToViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_worldToViews);
				return new Fixed2<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_worldToViews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00050760 File Offset: 0x0004E960
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x0000A103 File Offset: 0x00008303
		public NativeArray<VisibleReflectionProbe> reflectionProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_reflectionProbes);
				return new NativeArray<VisibleReflectionProbe>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_reflectionProbes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00050790 File Offset: 0x0004E990
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0000A131 File Offset: 0x00008331
		public NativeArray<float2> minMaxZs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_minMaxZs);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeMinMaxZJob.NativeFieldInfoPtr_minMaxZs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_worldToViews;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbes;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_minMaxZs;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
	}
}
