using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class LightAnchor : MonoBehaviour
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000E424 File Offset: 0x0000C624
		// Note: this type is marked as 'beforefieldinit'.
		static LightAnchor()
		{
			Il2CppClassPointerStore<LightAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine", "LightAnchor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr);
			LightAnchor.NativeFieldInfoPtr_k_ArcRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "k_ArcRadius");
			LightAnchor.NativeFieldInfoPtr_k_AxisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "k_AxisLength");
			LightAnchor.NativeFieldInfoPtr_k_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "k_MaxDistance");
			LightAnchor.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_Distance");
			LightAnchor.NativeFieldInfoPtr_m_FrameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_FrameSpace");
			LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_AnchorPositionOverride");
			LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_AnchorPositionOffset");
			LightAnchor.NativeFieldInfoPtr_m_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_Yaw");
			LightAnchor.NativeFieldInfoPtr_m_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_Pitch");
			LightAnchor.NativeFieldInfoPtr_m_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "m_Roll");
			LightAnchor.NativeMethodInfoPtr_get_yaw_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663301);
			LightAnchor.NativeMethodInfoPtr_set_yaw_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663302);
			LightAnchor.NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663303);
			LightAnchor.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663304);
			LightAnchor.NativeMethodInfoPtr_get_roll_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663305);
			LightAnchor.NativeMethodInfoPtr_set_roll_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663306);
			LightAnchor.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663307);
			LightAnchor.NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663308);
			LightAnchor.NativeMethodInfoPtr_get_frameSpace_Public_get_UpDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663309);
			LightAnchor.NativeMethodInfoPtr_set_frameSpace_Public_set_Void_UpDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663310);
			LightAnchor.NativeMethodInfoPtr_get_anchorPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663311);
			LightAnchor.NativeMethodInfoPtr_get_anchorPositionOverride_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663312);
			LightAnchor.NativeMethodInfoPtr_set_anchorPositionOverride_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663313);
			LightAnchor.NativeMethodInfoPtr_get_anchorPositionOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663314);
			LightAnchor.NativeMethodInfoPtr_set_anchorPositionOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663315);
			LightAnchor.NativeMethodInfoPtr_NormalizeAngleDegree_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663316);
			LightAnchor.NativeMethodInfoPtr_SynchronizeOnTransform_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663317);
			LightAnchor.NativeMethodInfoPtr_UpdateTransform_Public_Void_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663318);
			LightAnchor.NativeMethodInfoPtr_GetWorldSpaceAxes_Private_Axes_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663319);
			LightAnchor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663320);
			LightAnchor.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663321);
			LightAnchor.NativeMethodInfoPtr_UpdateTransform_Private_Void_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663322);
			LightAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, 100663323);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000E724 File Offset: 0x0000C924
		public unsafe float yaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_yaw_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953088, XrefRangeEnd = 953089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_yaw_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000E764 File Offset: 0x0000C964
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		public unsafe float pitch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953089, XrefRangeEnd = 953090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000E81C File Offset: 0x0000CA1C
		public unsafe float roll
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_roll_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953090, XrefRangeEnd = 953091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_roll_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000E85C File Offset: 0x0000CA5C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000E898 File Offset: 0x0000CA98
		public unsafe float distance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000E914 File Offset: 0x0000CB14
		public unsafe LightAnchor.UpDirection frameSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_frameSpace_Public_get_UpDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_frameSpace_Public_set_Void_UpDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000E954 File Offset: 0x0000CB54
		public unsafe Vector3 anchorPosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 953099, RefRangeEnd = 953103, XrefRangeStart = 953091, XrefRangeEnd = 953099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_anchorPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000E990 File Offset: 0x0000CB90
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public unsafe Transform anchorPositionOverride
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_anchorPositionOverride_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_anchorPositionOverride_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000EA14 File Offset: 0x0000CC14
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000EA50 File Offset: 0x0000CC50
		public unsafe Vector3 anchorPositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_get_anchorPositionOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_set_anchorPositionOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953103, XrefRangeEnd = 953104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float NormalizeAngleDegree(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_NormalizeAngleDegree_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953104, XrefRangeEnd = 953139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizeOnTransform(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_SynchronizeOnTransform_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000EB14 File Offset: 0x0000CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953139, XrefRangeEnd = 953141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform(Camera camera, Vector3 anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_UpdateTransform_Public_Void_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000EB64 File Offset: 0x0000CD64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 953183, RefRangeEnd = 953187, XrefRangeStart = 953141, XrefRangeEnd = 953183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightAnchor.Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_GetWorldSpaceAxes_Private_Axes_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953187, XrefRangeEnd = 953203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953203, XrefRangeEnd = 953213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 953225, RefRangeEnd = 953227, XrefRangeStart = 953213, XrefRangeEnd = 953225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref up;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr_UpdateTransform_Private_Void_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000EC90 File Offset: 0x0000CE90
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightAnchor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020DD File Offset: 0x000002DD
		public LightAnchor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000ECCC File Offset: 0x0000CECC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000020E6 File Offset: 0x000002E6
		public unsafe static float k_ArcRadius
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(LightAnchor.NativeFieldInfoPtr_k_ArcRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightAnchor.NativeFieldInfoPtr_k_ArcRadius, (void*)(&value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020F4 File Offset: 0x000002F4
		public unsafe static float k_AxisLength
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(LightAnchor.NativeFieldInfoPtr_k_AxisLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightAnchor.NativeFieldInfoPtr_k_AxisLength, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000ED04 File Offset: 0x0000CF04
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002102 File Offset: 0x00000302
		public unsafe static float k_MaxDistance
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(LightAnchor.NativeFieldInfoPtr_k_MaxDistance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightAnchor.NativeFieldInfoPtr_k_MaxDistance, (void*)(&value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000ED20 File Offset: 0x0000CF20
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002110 File Offset: 0x00000310
		public unsafe float m_Distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Distance)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000ED48 File Offset: 0x0000CF48
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000212B File Offset: 0x0000032B
		public unsafe LightAnchor.UpDirection m_FrameSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_FrameSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_FrameSpace)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000ED70 File Offset: 0x0000CF70
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe Transform m_AnchorPositionOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002165 File Offset: 0x00000365
		public unsafe Vector3 m_AnchorPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_AnchorPositionOffset)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002180 File Offset: 0x00000380
		public unsafe float m_Yaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Yaw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Yaw)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000219B File Offset: 0x0000039B
		public unsafe float m_Pitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Pitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Pitch)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000EE18 File Offset: 0x0000D018
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe float m_Roll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Roll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightAnchor.NativeFieldInfoPtr_m_Roll)) = value;
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_k_ArcRadius;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_k_AxisLength;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxDistance;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameSpace;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_AnchorPositionOverride;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_AnchorPositionOffset;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_Yaw;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_Pitch;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_m_Roll;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_yaw_Public_get_Single_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_yaw_Public_set_Void_Single_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_roll_Public_get_Single_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_roll_Public_set_Void_Single_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_frameSpace_Public_get_UpDirection_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_frameSpace_Public_set_Void_UpDirection_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPosition_Public_get_Vector3_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPositionOverride_Public_get_Transform_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorPositionOverride_Public_set_Void_Transform_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPositionOffset_Public_get_Vector3_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorPositionOffset_Public_set_Void_Vector3_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeAngleDegree_Public_Static_Single_Single_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizeOnTransform_Public_Void_Camera_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_Camera_Vector3_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldSpaceAxes_Private_Axes_Camera_Vector3_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Private_Void_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000142 RID: 322
		public enum UpDirection
		{
			// Token: 0x04000F87 RID: 3975
			World,
			// Token: 0x04000F88 RID: 3976
			Local
		}

		// Token: 0x02000143 RID: 323
		[StructLayout(2)]
		public struct Axes
		{
			// Token: 0x0600151C RID: 5404 RVA: 0x0005CE18 File Offset: 0x0005B018
			// Note: this type is marked as 'beforefieldinit'.
			static Axes()
			{
				Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightAnchor>.NativeClassPtr, "Axes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr);
				LightAnchor.Axes.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr, "up");
				LightAnchor.Axes.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr, "right");
				LightAnchor.Axes.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr, "forward");
			}

			// Token: 0x0600151D RID: 5405 RVA: 0x0000AA1D File Offset: 0x00008C1D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightAnchor.Axes>.NativeClassPtr, ref this));
			}

			// Token: 0x04000F89 RID: 3977
			private static readonly IntPtr NativeFieldInfoPtr_up;

			// Token: 0x04000F8A RID: 3978
			private static readonly IntPtr NativeFieldInfoPtr_right;

			// Token: 0x04000F8B RID: 3979
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x04000F8C RID: 3980
			[FieldOffset(0)]
			public Vector3 up;

			// Token: 0x04000F8D RID: 3981
			[FieldOffset(12)]
			public Vector3 right;

			// Token: 0x04000F8E RID: 3982
			[FieldOffset(24)]
			public Vector3 forward;
		}
	}
}
