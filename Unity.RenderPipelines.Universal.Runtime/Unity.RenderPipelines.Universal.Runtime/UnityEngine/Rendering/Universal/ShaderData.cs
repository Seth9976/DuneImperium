using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D2 RID: 210
	public class ShaderData : Object
	{
		// Token: 0x06001065 RID: 4197 RVA: 0x0004E15C File Offset: 0x0004C35C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderData()
		{
			Il2CppClassPointerStore<ShaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderData>.NativeClassPtr);
			ShaderData.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_Instance");
			ShaderData.NativeFieldInfoPtr_m_LightDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_LightDataBuffer");
			ShaderData.NativeFieldInfoPtr_m_LightIndicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_LightIndicesBuffer");
			ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_AdditionalLightShadowParamsStructuredBuffer");
			ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_AdditionalLightShadowSliceMatricesStructuredBuffer");
			ShaderData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665376);
			ShaderData.NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665377);
			ShaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665378);
			ShaderData.NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665379);
			ShaderData.NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665380);
			ShaderData.NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665381);
			ShaderData.NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665382);
			ShaderData.NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665383);
			ShaderData.NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665384);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0004E2A4 File Offset: 0x0004C4A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0004E2E0 File Offset: 0x0004C4E0
		public unsafe static ShaderData instance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 617043, RefRangeEnd = 617049, XrefRangeStart = 617035, XrefRangeEnd = 617043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShaderData>(intPtr3) : null;
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0004E314 File Offset: 0x0004C514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617057, RefRangeEnd = 617058, XrefRangeStart = 617049, XrefRangeEnd = 617057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0004E348 File Offset: 0x0004C548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617058, XrefRangeEnd = 617061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetLightDataBuffer(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0004E394 File Offset: 0x0004C594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617064, RefRangeEnd = 617065, XrefRangeStart = 617061, XrefRangeEnd = 617064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetLightIndicesBuffer(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617068, RefRangeEnd = 617071, XrefRangeStart = 617065, XrefRangeEnd = 617068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0004E42C File Offset: 0x0004C62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617074, RefRangeEnd = 617075, XrefRangeStart = 617071, XrefRangeEnd = 617074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0004E478 File Offset: 0x0004C678
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 617087, RefRangeEnd = 617091, XrefRangeStart = 617075, XrefRangeEnd = 617087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShaderData.MethodInfoStoreGeneric_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffer = ((intPtr4 == 0) ? null : new ComputeBuffer(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr5) : null;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0004E4F0 File Offset: 0x0004C6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617091, XrefRangeEnd = 617093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeBuffer(ref ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShaderData.NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				buffer = ((intPtr4 == 0) ? null : new ComputeBuffer(intPtr4));
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00009E02 File Offset: 0x00008002
		public ShaderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0004E548 File Offset: 0x0004C748
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00009E0B File Offset: 0x0000800B
		public unsafe static ShaderData m_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderData.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShaderData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderData.NativeFieldInfoPtr_m_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0004E570 File Offset: 0x0004C770
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00009E1D File Offset: 0x0000801D
		public unsafe ComputeBuffer m_LightDataBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_LightDataBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_LightDataBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00009E3C File Offset: 0x0000803C
		public unsafe ComputeBuffer m_LightIndicesBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_LightIndicesBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_LightIndicesBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00009E5B File Offset: 0x0000805B
		public unsafe ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0004E600 File Offset: 0x0004C800
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00009E7A File Offset: 0x0000807A
		public unsafe ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderData.NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr_m_LightDataBuffer;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr_m_LightIndicesBuffer;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0;

		// Token: 0x020001BE RID: 446
		private sealed class MethodInfoStoreGeneric_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0<T>
		{
			// Token: 0x040016C5 RID: 5829
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShaderData.NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0, Il2CppClassPointerStore<ShaderData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
