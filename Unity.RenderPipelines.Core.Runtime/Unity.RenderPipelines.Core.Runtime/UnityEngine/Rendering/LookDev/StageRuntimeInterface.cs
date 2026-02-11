using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.LookDev
{
	// Token: 0x0200011C RID: 284
	public class StageRuntimeInterface : Object
	{
		// Token: 0x06001267 RID: 4711 RVA: 0x000536E8 File Offset: 0x000518E8
		// Note: this type is marked as 'beforefieldinit'.
		static StageRuntimeInterface()
		{
			Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "StageRuntimeInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr);
			StageRuntimeInterface.NativeFieldInfoPtr_m_AddGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_AddGameObject");
			StageRuntimeInterface.NativeFieldInfoPtr_m_GetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_GetCamera");
			StageRuntimeInterface.NativeFieldInfoPtr_m_GetSunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "m_GetSunLight");
			StageRuntimeInterface.NativeFieldInfoPtr_SRPData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, "SRPData");
			StageRuntimeInterface.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100665992);
			StageRuntimeInterface.NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100665993);
			StageRuntimeInterface.NativeMethodInfoPtr_get_camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100665994);
			StageRuntimeInterface.NativeMethodInfoPtr_get_sunLight_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr, 100665995);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000537B8 File Offset: 0x000519B8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StageRuntimeInterface>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(AddGameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(GetCamera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(GetSunLight);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StageRuntimeInterface.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00053828 File Offset: 0x00051A28
		[CallerCount(0)]
		public unsafe GameObject AddGameObject(bool persistent = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref persistent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StageRuntimeInterface.NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00053874 File Offset: 0x00051A74
		public unsafe Camera camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StageRuntimeInterface.NativeMethodInfoPtr_get_camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000538B4 File Offset: 0x00051AB4
		public unsafe Light sunLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StageRuntimeInterface.NativeMethodInfoPtr_get_sunLight_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000096B1 File Offset: 0x000078B1
		public StageRuntimeInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000538F4 File Offset: 0x00051AF4
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x000096BA File Offset: 0x000078BA
		public unsafe Func<bool, GameObject> m_AddGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_AddGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_AddGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00053924 File Offset: 0x00051B24
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000096D9 File Offset: 0x000078D9
		public unsafe Func<Camera> m_GetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_GetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_GetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00053954 File Offset: 0x00051B54
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000096F8 File Offset: 0x000078F8
		public unsafe Func<Light> m_GetSunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_GetSunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_m_GetSunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00053984 File Offset: 0x00051B84
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00009717 File Offset: 0x00007917
		public unsafe Object SRPData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_SRPData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StageRuntimeInterface.NativeFieldInfoPtr_SRPData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_m_AddGameObject;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeFieldInfoPtr_m_GetCamera;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeFieldInfoPtr_m_GetSunLight;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeFieldInfoPtr_SRPData;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_GameObject_Func_1_Camera_Func_1_Light_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_AddGameObject_Public_GameObject_Boolean_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_get_camera_Public_get_Camera_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_get_sunLight_Public_get_Light_0;
	}
}
