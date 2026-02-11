using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000086 RID: 134
	public sealed class ProbeVolumeSystemParameters : ValueType
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00030724 File Offset: 0x0002E924
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeSystemParameters()
		{
			Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeSystemParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr);
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_memoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "memoryBudget");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_blendingMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "blendingMemoryBudget");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeDebugMesh");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeDebugShader");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "offsetDebugMesh");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "offsetDebugShader");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_scenarioBlendingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "scenarioBlendingShader");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_sceneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "sceneData");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_shBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "shBands");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportsRuntimeDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportsRuntimeDebug");
			ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportStreaming");
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00005C5B File Offset: 0x00003E5B
		public ProbeVolumeSystemParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00005C64 File Offset: 0x00003E64
		public ProbeVolumeSystemParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr))
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00030830 File Offset: 0x0002EA30
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005C76 File Offset: 0x00003E76
		public unsafe ProbeVolumeTextureMemoryBudget memoryBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_memoryBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_memoryBudget)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00030858 File Offset: 0x0002EA58
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00005C91 File Offset: 0x00003E91
		public unsafe ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_blendingMemoryBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_blendingMemoryBudget)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00030880 File Offset: 0x0002EA80
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00005CAC File Offset: 0x00003EAC
		public unsafe Mesh probeDebugMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000308B0 File Offset: 0x0002EAB0
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00005CCB File Offset: 0x00003ECB
		public unsafe Shader probeDebugShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_probeDebugShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000308E0 File Offset: 0x0002EAE0
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00005CEA File Offset: 0x00003EEA
		public unsafe Mesh offsetDebugMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00030910 File Offset: 0x0002EB10
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00005D09 File Offset: 0x00003F09
		public unsafe Shader offsetDebugShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_offsetDebugShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00030940 File Offset: 0x0002EB40
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00005D28 File Offset: 0x00003F28
		public unsafe ComputeShader scenarioBlendingShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_scenarioBlendingShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_scenarioBlendingShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00030970 File Offset: 0x0002EB70
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00005D47 File Offset: 0x00003F47
		public unsafe ProbeVolumeSceneData sceneData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_sceneData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_sceneData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000309A0 File Offset: 0x0002EBA0
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00005D66 File Offset: 0x00003F66
		public unsafe ProbeVolumeSHBands shBands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_shBands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_shBands)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000309C8 File Offset: 0x0002EBC8
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00005D81 File Offset: 0x00003F81
		public unsafe bool supportsRuntimeDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportsRuntimeDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportsRuntimeDebug)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000309F0 File Offset: 0x0002EBF0
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00005D9C File Offset: 0x00003F9C
		public unsafe bool supportStreaming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportStreaming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSystemParameters.NativeFieldInfoPtr_supportStreaming)) = value;
			}
		}

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_memoryBudget;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_blendingMemoryBudget;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_probeDebugMesh;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_probeDebugShader;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_offsetDebugMesh;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_offsetDebugShader;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_scenarioBlendingShader;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_sceneData;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_shBands;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_supportsRuntimeDebug;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_supportStreaming;
	}
}
