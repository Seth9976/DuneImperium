using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000CD RID: 205
	[StructLayout(2)]
	public struct RenderTargetHandle
	{
		// Token: 0x06001011 RID: 4113 RVA: 0x0004CB90 File Offset: 0x0004AD90
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetHandle()
		{
			Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderTargetHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr);
			RenderTargetHandle.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "<id>k__BackingField");
			RenderTargetHandle.NativeFieldInfoPtr__rtid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "<rtid>k__BackingField");
			RenderTargetHandle.NativeFieldInfoPtr_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, "CameraTarget");
			RenderTargetHandle.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665321);
			RenderTargetHandle.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665322);
			RenderTargetHandle.NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665323);
			RenderTargetHandle.NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665324);
			RenderTargetHandle.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665325);
			RenderTargetHandle.NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665326);
			RenderTargetHandle.NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665327);
			RenderTargetHandle.NativeMethodInfoPtr_Init_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665328);
			RenderTargetHandle.NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665329);
			RenderTargetHandle.NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665330);
			RenderTargetHandle.NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665331);
			RenderTargetHandle.NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665332);
			RenderTargetHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665333);
			RenderTargetHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665334);
			RenderTargetHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665335);
			RenderTargetHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, 100665336);
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x0004CD70 File Offset: 0x0004AF70
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		public unsafe int id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_get_id_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		public unsafe RenderTargetIdentifier rtid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0004CE04 File Offset: 0x0004B004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616617, XrefRangeEnd = 616620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTargetIdentifier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004CE38 File Offset: 0x0004B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616620, XrefRangeEnd = 616644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetHandle(RTHandle rtHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rtHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0004CE70 File Offset: 0x0004B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616644, XrefRangeEnd = 616649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTargetHandle GetCameraTarget(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616649, XrefRangeEnd = 616653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string shaderProperty)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_Init_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0004CEEC File Offset: 0x0004B0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616653, XrefRangeEnd = 616656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(RenderTargetIdentifier renderTargetIdentifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTargetIdentifier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004CF20 File Offset: 0x0004B120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616664, RefRangeEnd = 616667, XrefRangeStart = 616656, XrefRangeEnd = 616664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier Identifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0004CF50 File Offset: 0x0004B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616667, XrefRangeEnd = 616670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasInternalRenderTargetId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0004CF80 File Offset: 0x0004B180
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616677, RefRangeEnd = 616680, XrefRangeStart = 616670, XrefRangeEnd = 616677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616680, XrefRangeEnd = 616686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0004D004 File Offset: 0x0004B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616686, XrefRangeEnd = 616689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0004D034 File Offset: 0x0004B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616689, XrefRangeEnd = 616693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004D080 File Offset: 0x0004B280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616693, XrefRangeEnd = 616697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00009CB1 File Offset: 0x00007EB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0004D0CC File Offset: 0x0004B2CC
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00009CC3 File Offset: 0x00007EC3
		public unsafe static RenderTargetHandle CameraTarget
		{
			get
			{
				RenderTargetHandle renderTargetHandle;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetHandle.NativeFieldInfoPtr_CameraTarget, (void*)(&renderTargetHandle));
				return renderTargetHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetHandle.NativeFieldInfoPtr_CameraTarget, (void*)(&value));
			}
		}

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr__rtid_k__BackingField;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_CameraTarget;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_set_rtid_Private_set_Void_RenderTargetIdentifier_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_get_rtid_Private_get_RenderTargetIdentifier_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RTHandle_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraTarget_Internal_Static_RenderTargetHandle_byref_CameraData_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_String_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_RenderTargetIdentifier_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_Identifier_Public_RenderTargetIdentifier_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_HasInternalRenderTargetId_Public_Boolean_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_RenderTargetHandle_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetHandle_RenderTargetHandle_0;

		// Token: 0x04000BB5 RID: 2997
		[FieldOffset(0)]
		public int _id_k__BackingField;

		// Token: 0x04000BB6 RID: 2998
		[FieldOffset(8)]
		public RenderTargetIdentifier _rtid_k__BackingField;
	}
}
