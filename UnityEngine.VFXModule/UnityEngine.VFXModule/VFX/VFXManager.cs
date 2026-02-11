using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x02000007 RID: 7
	public static class VFXManager : Object
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000040F8 File Offset: 0x000022F8
		// Note: this type is marked as 'beforefieldinit'.
		static VFXManager()
		{
			Il2CppClassPointerStore<VFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager>.NativeClassPtr);
			VFXManager.NativeFieldInfoPtr_kDefaultCameraXRSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, "kDefaultCameraXRSettings");
			VFXManager.NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663309);
			VFXManager.NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663310);
			VFXManager.NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_Camera_CommandBuffer_byref_VFXCameraXRSettings_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663312);
			VFXManager.GetComponentsDelegateField = IL2CPP.ResolveICall<VFXManager.GetComponentsDelegate>("UnityEngine.VFX.VFXManager::GetComponents");
			VFXManager.get_runtimeResourcesDelegateField = IL2CPP.ResolveICall<VFXManager.get_runtimeResourcesDelegate>("UnityEngine.VFX.VFXManager::get_runtimeResources");
			VFXManager.get_fixedTimeStepDelegateField = IL2CPP.ResolveICall<VFXManager.get_fixedTimeStepDelegate>("UnityEngine.VFX.VFXManager::get_fixedTimeStep");
			VFXManager.set_fixedTimeStepDelegateField = IL2CPP.ResolveICall<VFXManager.set_fixedTimeStepDelegate>("UnityEngine.VFX.VFXManager::set_fixedTimeStep");
			VFXManager.get_maxDeltaTimeDelegateField = IL2CPP.ResolveICall<VFXManager.get_maxDeltaTimeDelegate>("UnityEngine.VFX.VFXManager::get_maxDeltaTime");
			VFXManager.set_maxDeltaTimeDelegateField = IL2CPP.ResolveICall<VFXManager.set_maxDeltaTimeDelegate>("UnityEngine.VFX.VFXManager::set_maxDeltaTime");
			VFXManager.get_maxScrubTimeDelegateField = IL2CPP.ResolveICall<VFXManager.get_maxScrubTimeDelegate>("UnityEngine.VFX.VFXManager::get_maxScrubTime");
			VFXManager.set_maxScrubTimeDelegateField = IL2CPP.ResolveICall<VFXManager.set_maxScrubTimeDelegate>("UnityEngine.VFX.VFXManager::set_maxScrubTime");
			VFXManager.get_renderPipeSettingsPathDelegateField = IL2CPP.ResolveICall<VFXManager.get_renderPipeSettingsPathDelegate>("UnityEngine.VFX.VFXManager::get_renderPipeSettingsPath");
			VFXManager.get_batchEmptyLifetimeDelegateField = IL2CPP.ResolveICall<VFXManager.get_batchEmptyLifetimeDelegate>("UnityEngine.VFX.VFXManager::get_batchEmptyLifetime");
			VFXManager.set_batchEmptyLifetimeDelegateField = IL2CPP.ResolveICall<VFXManager.set_batchEmptyLifetimeDelegate>("UnityEngine.VFX.VFXManager::set_batchEmptyLifetime");
			VFXManager.CleanupEmptyBatchesDelegateField = IL2CPP.ResolveICall<VFXManager.CleanupEmptyBatchesDelegate>("UnityEngine.VFX.VFXManager::CleanupEmptyBatches");
			VFXManager.GetBatchedEffectInfosDelegateField = IL2CPP.ResolveICall<VFXManager.GetBatchedEffectInfosDelegate>("UnityEngine.VFX.VFXManager::GetBatchedEffectInfos");
			VFXManager.IsCameraBufferNeededDelegateField = IL2CPP.ResolveICall<VFXManager.IsCameraBufferNeededDelegate>("UnityEngine.VFX.VFXManager::IsCameraBufferNeeded");
			VFXManager.SetCameraBufferDelegateField = IL2CPP.ResolveICall<VFXManager.SetCameraBufferDelegate>("UnityEngine.VFX.VFXManager::SetCameraBuffer");
			VFXManager.GetBatchedEffectInfo_InjectedDelegateField = IL2CPP.ResolveICall<VFXManager.GetBatchedEffectInfo_InjectedDelegate>("UnityEngine.VFX.VFXManager::GetBatchedEffectInfo_Injected");
			VFXManager.GetBatchInfo_InjectedDelegateField = IL2CPP.ResolveICall<VFXManager.GetBatchInfo_InjectedDelegate>("UnityEngine.VFX.VFXManager::GetBatchInfo_Injected");
			VFXManager.PrepareCamera_InjectedDelegateField = IL2CPP.ResolveICall<VFXManager.PrepareCamera_InjectedDelegate>("UnityEngine.VFX.VFXManager::PrepareCamera_Injected");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004288 File Offset: 0x00002488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269753, RefRangeEnd = 1269754, XrefRangeStart = 1269745, XrefRangeEnd = 1269753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref camXRSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref results;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000042EC File Offset: 0x000024EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269754, XrefRangeEnd = 1269759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref camXRSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004350 File Offset: 0x00002550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269759, XrefRangeEnd = 1269761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ProcessCameraCommand_Injected(Camera cam, CommandBuffer cmd, ref VFXCameraXRSettings camXRSettings, IntPtr cullResults)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &camXRSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullResults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_Camera_CommandBuffer_byref_VFXCameraXRSettings_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000258E File Offset: 0x0000078E
		public VFXManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000043B4 File Offset: 0x000025B4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002597 File Offset: 0x00000797
		public unsafe static VFXCameraXRSettings kDefaultCameraXRSettings
		{
			get
			{
				VFXCameraXRSettings vfxcameraXRSettings;
				IL2CPP.il2cpp_field_static_get_value(VFXManager.NativeFieldInfoPtr_kDefaultCameraXRSettings, (void*)(&vfxcameraXRSettings));
				return vfxcameraXRSettings;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VFXManager.NativeFieldInfoPtr_kDefaultCameraXRSettings, (void*)(&value));
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000043D0 File Offset: 0x000025D0
		public static Il2CppReferenceArray<VisualEffect> GetComponents()
		{
			IntPtr intPtr = VFXManager.GetComponentsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualEffect>>(intPtr2) : null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000043F8 File Offset: 0x000025F8
		public static ScriptableObject runtimeResources
		{
			get
			{
				IntPtr intPtr = VFXManager.get_runtimeResourcesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000025A5 File Offset: 0x000007A5
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000025B1 File Offset: 0x000007B1
		public static float fixedTimeStep
		{
			get
			{
				return VFXManager.get_fixedTimeStepDelegateField();
			}
			set
			{
				VFXManager.set_fixedTimeStepDelegateField(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000025BE File Offset: 0x000007BE
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000025CA File Offset: 0x000007CA
		public static float maxDeltaTime
		{
			get
			{
				return VFXManager.get_maxDeltaTimeDelegateField();
			}
			set
			{
				VFXManager.set_maxDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000025D7 File Offset: 0x000007D7
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000025E3 File Offset: 0x000007E3
		public static float maxScrubTime
		{
			get
			{
				return VFXManager.get_maxScrubTimeDelegateField();
			}
			set
			{
				VFXManager.set_maxScrubTimeDelegateField(value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004420 File Offset: 0x00002620
		public static string renderPipeSettingsPath
		{
			get
			{
				IntPtr intPtr = VFXManager.get_renderPipeSettingsPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000025FC File Offset: 0x000007FC
		public static uint batchEmptyLifetime
		{
			get
			{
				return VFXManager.get_batchEmptyLifetimeDelegateField();
			}
			set
			{
				VFXManager.set_batchEmptyLifetimeDelegateField(value);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002609 File Offset: 0x00000809
		public static void CleanupEmptyBatches([Optional] bool force)
		{
			VFXManager.CleanupEmptyBatchesDelegateField(force);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002616 File Offset: 0x00000816
		public static void FlushEmptyBatches()
		{
			VFXManager.CleanupEmptyBatches(true);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004440 File Offset: 0x00002640
		public static VFXBatchedEffectInfo GetBatchedEffectInfo(VisualEffectAsset vfx)
		{
			VFXBatchedEffectInfo vfxbatchedEffectInfo;
			VFXManager.GetBatchedEffectInfo_Injected(vfx, out vfxbatchedEffectInfo);
			return vfxbatchedEffectInfo;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002620 File Offset: 0x00000820
		public static void GetBatchedEffectInfos(List<VFXBatchedEffectInfo> infos)
		{
			VFXManager.GetBatchedEffectInfosDelegateField(IL2CPP.Il2CppObjectBaseToPtr(infos));
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004458 File Offset: 0x00002658
		public static VFXBatchInfo GetBatchInfo(VisualEffectAsset vfx, uint batchIndex)
		{
			VFXBatchInfo vfxbatchInfo;
			VFXManager.GetBatchInfo_Injected(vfx, batchIndex, out vfxbatchInfo);
			return vfxbatchInfo;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002632 File Offset: 0x00000832
		public static void ProcessCamera(Camera cam)
		{
			VFXManager.PrepareCamera(cam, VFXManager.kDefaultCameraXRSettings);
			VFXManager.Internal_ProcessCameraCommand(cam, null, VFXManager.kDefaultCameraXRSettings, IntPtr.Zero);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002653 File Offset: 0x00000853
		public static void PrepareCamera(Camera cam)
		{
			VFXManager.PrepareCamera(cam, VFXManager.kDefaultCameraXRSettings);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002662 File Offset: 0x00000862
		public static void PrepareCamera(Camera cam, VFXCameraXRSettings camXRSettings)
		{
			VFXManager.PrepareCamera_Injected(cam, ref camXRSettings);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000266C File Offset: 0x0000086C
		public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd)
		{
			VFXManager.Internal_ProcessCameraCommand(cam, cmd, VFXManager.kDefaultCameraXRSettings, IntPtr.Zero);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002681 File Offset: 0x00000881
		public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings)
		{
			VFXManager.Internal_ProcessCameraCommand(cam, cmd, camXRSettings, IntPtr.Zero);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002692 File Offset: 0x00000892
		public static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam)
		{
			return VFXManager.IsCameraBufferNeededDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000026A4 File Offset: 0x000008A4
		public static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height)
		{
			VFXManager.SetCameraBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam), type, IL2CPP.Il2CppObjectBaseToPtr(buffer), x, y, width, height);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004470 File Offset: 0x00002670
		public unsafe static void GetBatchedEffectInfo_Injected(VisualEffectAsset vfx, out VFXBatchedEffectInfo ret)
		{
			VFXManager.GetBatchedEffectInfo_InjectedDelegate getBatchedEffectInfo_InjectedDelegateField = VFXManager.GetBatchedEffectInfo_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(vfx);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			getBatchedEffectInfo_InjectedDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000026C4 File Offset: 0x000008C4
		public static void GetBatchInfo_Injected(VisualEffectAsset vfx, uint batchIndex, out VFXBatchInfo ret)
		{
			VFXManager.GetBatchInfo_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(vfx), batchIndex, out ret);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026D8 File Offset: 0x000008D8
		public static void PrepareCamera_Injected(Camera cam, ref VFXCameraXRSettings camXRSettings)
		{
			VFXManager.PrepareCamera_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam), ref camXRSettings);
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultCameraXRSettings;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_Camera_CommandBuffer_byref_VFXCameraXRSettings_IntPtr_0;

		// Token: 0x0400004E RID: 78
		private static readonly VFXManager.GetComponentsDelegate GetComponentsDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly VFXManager.get_runtimeResourcesDelegate get_runtimeResourcesDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly VFXManager.get_fixedTimeStepDelegate get_fixedTimeStepDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly VFXManager.set_fixedTimeStepDelegate set_fixedTimeStepDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly VFXManager.get_maxDeltaTimeDelegate get_maxDeltaTimeDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly VFXManager.set_maxDeltaTimeDelegate set_maxDeltaTimeDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly VFXManager.get_maxScrubTimeDelegate get_maxScrubTimeDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly VFXManager.set_maxScrubTimeDelegate set_maxScrubTimeDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly VFXManager.get_renderPipeSettingsPathDelegate get_renderPipeSettingsPathDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly VFXManager.get_batchEmptyLifetimeDelegate get_batchEmptyLifetimeDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly VFXManager.set_batchEmptyLifetimeDelegate set_batchEmptyLifetimeDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly VFXManager.CleanupEmptyBatchesDelegate CleanupEmptyBatchesDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly VFXManager.GetBatchedEffectInfosDelegate GetBatchedEffectInfosDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly VFXManager.IsCameraBufferNeededDelegate IsCameraBufferNeededDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly VFXManager.SetCameraBufferDelegate SetCameraBufferDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly VFXManager.GetBatchedEffectInfo_InjectedDelegate GetBatchedEffectInfo_InjectedDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly VFXManager.GetBatchInfo_InjectedDelegate GetBatchInfo_InjectedDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly VFXManager.PrepareCamera_InjectedDelegate PrepareCamera_InjectedDelegateField;

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001E3 RID: 483
		private delegate IntPtr GetComponentsDelegate();

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate IntPtr get_runtimeResourcesDelegate();

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060001E7 RID: 487
		private delegate float get_fixedTimeStepDelegate();

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate void set_fixedTimeStepDelegate(float value);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001EB RID: 491
		private delegate float get_maxDeltaTimeDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001ED RID: 493
		private delegate void set_maxDeltaTimeDelegate(float value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001EF RID: 495
		private delegate float get_maxScrubTimeDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001F1 RID: 497
		private delegate void set_maxScrubTimeDelegate(float value);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001F3 RID: 499
		private delegate IntPtr get_renderPipeSettingsPathDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001F5 RID: 501
		private delegate uint get_batchEmptyLifetimeDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001F7 RID: 503
		private delegate void set_batchEmptyLifetimeDelegate(uint value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001F9 RID: 505
		private delegate void CleanupEmptyBatchesDelegate(bool force);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001FB RID: 507
		private delegate void GetBatchedEffectInfosDelegate(IntPtr infos);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001FD RID: 509
		private delegate VFXCameraBufferTypes IsCameraBufferNeededDelegate(IntPtr cam);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001FF RID: 511
		private delegate void SetCameraBufferDelegate(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000201 RID: 513
		private delegate void GetBatchedEffectInfo_InjectedDelegate(IntPtr vfx, [Out] IntPtr ret);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000203 RID: 515
		private delegate void GetBatchInfo_InjectedDelegate(IntPtr vfx, uint batchIndex, [Out] IntPtr ret);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000205 RID: 517
		private delegate void PrepareCamera_InjectedDelegate(IntPtr cam, IntPtr camXRSettings);
	}
}
