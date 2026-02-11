using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000032 RID: 50
	public class CameraSwitcher : MonoBehaviour
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0001D3D8 File Offset: 0x0001B5D8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraSwitcher()
		{
			Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CameraSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr);
			CameraSwitcher.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_Cameras");
			CameraSwitcher.NativeFieldInfoPtr_m_CurrentCameraIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_CurrentCameraIndex");
			CameraSwitcher.NativeFieldInfoPtr_m_OriginalCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_OriginalCamera");
			CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_OriginalCameraPosition");
			CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_OriginalCameraRotation");
			CameraSwitcher.NativeFieldInfoPtr_m_CurrentCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_CurrentCamera");
			CameraSwitcher.NativeFieldInfoPtr_m_CameraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_CameraNames");
			CameraSwitcher.NativeFieldInfoPtr_m_CameraIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_CameraIndices");
			CameraSwitcher.NativeFieldInfoPtr_m_DebugEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_DebugEntry");
			CameraSwitcher.NativeFieldInfoPtr_m_DebugEntryEnumIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, "m_DebugEntryEnumIndex");
			CameraSwitcher.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663831);
			CameraSwitcher.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663832);
			CameraSwitcher.NativeMethodInfoPtr_GetCameraCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663833);
			CameraSwitcher.NativeMethodInfoPtr_GetNextCamera_Private_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663834);
			CameraSwitcher.NativeMethodInfoPtr_SetCameraIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663835);
			CameraSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663836);
			CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_0_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663837);
			CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663838);
			CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663839);
			CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr, 100663840);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001D598 File Offset: 0x0001B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958761, XrefRangeEnd = 958878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958878, XrefRangeEnd = 958881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001D600 File Offset: 0x0001B800
		[CallerCount(0)]
		public unsafe int GetCameraCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr_GetCameraCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001D63C File Offset: 0x0001B83C
		[CallerCount(0)]
		public unsafe Camera GetNextCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr_GetNextCamera_Private_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001D67C File Offset: 0x0001B87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958909, RefRangeEnd = 958910, XrefRangeStart = 958881, XrefRangeEnd = 958909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr_SetCameraIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958910, XrefRangeEnd = 958911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraSwitcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraSwitcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001D6F8 File Offset: 0x0001B8F8
		[CallerCount(0)]
		public unsafe int _OnEnable_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_0_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001D734 File Offset: 0x0001B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958911, XrefRangeEnd = 958912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__10_1(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001D774 File Offset: 0x0001B974
		[CallerCount(0)]
		public unsafe int _OnEnable_b__10_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001D7B0 File Offset: 0x0001B9B0
		[CallerCount(0)]
		public unsafe void _OnEnable_b__10_3(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraSwitcher.NativeMethodInfoPtr__OnEnable_b__10_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003BDB File Offset: 0x00001DDB
		public CameraSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public unsafe Il2CppReferenceArray<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_Cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_Cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001D820 File Offset: 0x0001BA20
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003C03 File Offset: 0x00001E03
		public unsafe int m_CurrentCameraIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CurrentCameraIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CurrentCameraIndex)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001D848 File Offset: 0x0001BA48
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003C1E File Offset: 0x00001E1E
		public unsafe Camera m_OriginalCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001D878 File Offset: 0x0001BA78
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00003C3D File Offset: 0x00001E3D
		public unsafe Vector3 m_OriginalCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraPosition)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00003C58 File Offset: 0x00001E58
		public unsafe Quaternion m_OriginalCameraRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_OriginalCameraRotation)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00003C73 File Offset: 0x00001E73
		public unsafe Camera m_CurrentCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CurrentCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CurrentCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00003C92 File Offset: 0x00001E92
		public unsafe Il2CppReferenceArray<GUIContent> m_CameraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CameraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CameraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0001D928 File Offset: 0x0001BB28
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public unsafe Il2CppStructArray<int> m_CameraIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CameraIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_CameraIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001D958 File Offset: 0x0001BB58
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public unsafe DebugUI.EnumField m_DebugEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_DebugEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.EnumField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_DebugEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0001D988 File Offset: 0x0001BB88
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00003CEF File Offset: 0x00001EEF
		public unsafe int m_DebugEntryEnumIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_DebugEntryEnumIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraSwitcher.NativeFieldInfoPtr_m_DebugEntryEnumIndex)) = value;
			}
		}

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraIndex;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCamera;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraRotation;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCamera;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraNames;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraIndices;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugEntry;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugEntryEnumIndex;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraCount_Private_Int32_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_GetNextCamera_Private_Camera_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraIndex_Private_Void_Int32_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__10_0_Private_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__10_1_Private_Void_Int32_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__10_2_Private_Int32_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__10_3_Private_Void_Int32_0;
	}
}
