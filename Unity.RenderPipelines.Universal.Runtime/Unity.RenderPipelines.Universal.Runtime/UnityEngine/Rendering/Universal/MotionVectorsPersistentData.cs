using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200008B RID: 139
	public sealed class MotionVectorsPersistentData : Object
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x00041564 File Offset: 0x0003F764
		// Note: this type is marked as 'beforefieldinit'.
		static MotionVectorsPersistentData()
		{
			Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionVectorsPersistentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr);
			MotionVectorsPersistentData.NativeFieldInfoPtr_k_EyeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, "k_EyeCount");
			MotionVectorsPersistentData.NativeFieldInfoPtr_m_ViewProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, "m_ViewProjection");
			MotionVectorsPersistentData.NativeFieldInfoPtr_m_PreviousViewProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, "m_PreviousViewProjection");
			MotionVectorsPersistentData.NativeFieldInfoPtr_m_LastFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, "m_LastFrameIndex");
			MotionVectorsPersistentData.NativeFieldInfoPtr_m_PrevAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, "m_PrevAspectRatio");
			MotionVectorsPersistentData.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664991);
			MotionVectorsPersistentData.NativeMethodInfoPtr_get_lastFrameIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664992);
			MotionVectorsPersistentData.NativeMethodInfoPtr_get_viewProjection_Internal_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664993);
			MotionVectorsPersistentData.NativeMethodInfoPtr_get_previousViewProjection_Internal_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664994);
			MotionVectorsPersistentData.NativeMethodInfoPtr_get_viewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664995);
			MotionVectorsPersistentData.NativeMethodInfoPtr_get_previousViewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664996);
			MotionVectorsPersistentData.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664997);
			MotionVectorsPersistentData.NativeMethodInfoPtr_GetXRMultiPassId_Internal_Int32_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664998);
			MotionVectorsPersistentData.NativeMethodInfoPtr_Update_Public_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr, 100664999);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000416AC File Offset: 0x0003F8AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611851, RefRangeEnd = 611853, XrefRangeStart = 611830, XrefRangeEnd = 611851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionVectorsPersistentData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionVectorsPersistentData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000416E8 File Offset: 0x0003F8E8
		public unsafe int lastFrameIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_get_lastFrameIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00041724 File Offset: 0x0003F924
		public unsafe Matrix4x4 viewProjection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_get_viewProjection_Internal_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00041760 File Offset: 0x0003F960
		public unsafe Matrix4x4 previousViewProjection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_get_previousViewProjection_Internal_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0004179C File Offset: 0x0003F99C
		public unsafe Il2CppStructArray<Matrix4x4> viewProjectionStereo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_get_viewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000417DC File Offset: 0x0003F9DC
		public unsafe Il2CppStructArray<Matrix4x4> previousViewProjectionStereo
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_get_previousViewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0004181C File Offset: 0x0003FA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611858, RefRangeEnd = 611859, XrefRangeStart = 611853, XrefRangeEnd = 611858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00041850 File Offset: 0x0003FA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611860, RefRangeEnd = 611861, XrefRangeStart = 611859, XrefRangeEnd = 611860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXRMultiPassId(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_GetXRMultiPassId_Internal_Int32_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000418A0 File Offset: 0x0003FAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611861, XrefRangeEnd = 611884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionVectorsPersistentData.NativeMethodInfoPtr_Update_Public_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00007A00 File Offset: 0x00005C00
		public MotionVectorsPersistentData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000418E4 File Offset: 0x0003FAE4
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007A09 File Offset: 0x00005C09
		public unsafe static int k_EyeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MotionVectorsPersistentData.NativeFieldInfoPtr_k_EyeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MotionVectorsPersistentData.NativeFieldInfoPtr_k_EyeCount, (void*)(&value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00041900 File Offset: 0x0003FB00
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x00007A17 File Offset: 0x00005C17
		public unsafe Il2CppStructArray<Matrix4x4> m_ViewProjection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_ViewProjection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_ViewProjection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00041930 File Offset: 0x0003FB30
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00007A36 File Offset: 0x00005C36
		public unsafe Il2CppStructArray<Matrix4x4> m_PreviousViewProjection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_PreviousViewProjection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_PreviousViewProjection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00041960 File Offset: 0x0003FB60
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00007A55 File Offset: 0x00005C55
		public unsafe Il2CppStructArray<int> m_LastFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_LastFrameIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_LastFrameIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00041990 File Offset: 0x0003FB90
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00007A74 File Offset: 0x00005C74
		public unsafe Il2CppStructArray<float> m_PrevAspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_PrevAspectRatio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionVectorsPersistentData.NativeFieldInfoPtr_m_PrevAspectRatio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_k_EyeCount;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewProjection;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousViewProjection;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameIndex;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevAspectRatio;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_get_lastFrameIndex_Internal_get_Int32_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_get_viewProjection_Internal_get_Matrix4x4_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_get_previousViewProjection_Internal_get_Matrix4x4_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_get_viewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_get_previousViewProjectionStereo_Internal_get_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_GetXRMultiPassId_Internal_Int32_byref_CameraData_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_byref_CameraData_0;
	}
}
