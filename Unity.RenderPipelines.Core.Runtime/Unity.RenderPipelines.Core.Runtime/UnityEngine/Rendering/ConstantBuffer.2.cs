using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000039 RID: 57
	public class ConstantBuffer<CBType> : ConstantBufferBase where CBType : new()
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x0001EB18 File Offset: 0x0001CD18
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantBuffer()
		{
			Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ConstantBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr);
			ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GlobalBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, "m_GlobalBindings");
			ConstantBuffer<CBType>.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, "m_Data");
			ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GPUConstantBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, "m_GPUConstantBuffer");
			ConstantBuffer<CBType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663875);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_UpdateData_Public_Void_CommandBuffer_byref_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663876);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_UpdateData_Public_Void_byref_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663877);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_SetGlobal_Public_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663878);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_SetGlobal_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663879);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_CommandBuffer_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663880);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663881);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663882);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_PushGlobal_Public_Void_CommandBuffer_byref_CBType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663883);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_PushGlobal_Public_Void_byref_CBType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663884);
			ConstantBuffer<CBType>.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr, 100663885);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959144, XrefRangeEnd = 959160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantBuffer<CBType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959258, RefRangeEnd = 959259, XrefRangeStart = 959160, XrefRangeEnd = 959258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData(CommandBuffer cmd, [In] ref CBType data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_UpdateData_Public_Void_CommandBuffer_byref_CBType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001ED44 File Offset: 0x0001CF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959259, XrefRangeEnd = 959268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData([In] ref CBType data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_UpdateData_Public_Void_byref_CBType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959273, RefRangeEnd = 959274, XrefRangeStart = 959268, XrefRangeEnd = 959273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobal(CommandBuffer cmd, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_SetGlobal_Public_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959274, XrefRangeEnd = 959279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobal(int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_SetGlobal_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001EE30 File Offset: 0x0001D030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959281, RefRangeEnd = 959282, XrefRangeStart = 959279, XrefRangeEnd = 959281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(CommandBuffer cmd, ComputeShader cs, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_CommandBuffer_ComputeShader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001EE94 File Offset: 0x0001D094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959282, XrefRangeEnd = 959284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(ComputeShader cs, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_ComputeShader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959284, XrefRangeEnd = 959286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Material mat, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_Set_Public_Void_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001EF34 File Offset: 0x0001D134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959286, XrefRangeEnd = 959292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGlobal(CommandBuffer cmd, [In] ref CBType data, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_PushGlobal_Public_Void_CommandBuffer_byref_CBType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959292, XrefRangeEnd = 959298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGlobal([In] ref CBType data, int shaderId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer<CBType>.NativeMethodInfoPtr_PushGlobal_Public_Void_byref_CBType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001F018 File Offset: 0x0001D218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959320, RefRangeEnd = 959321, XrefRangeStart = 959298, XrefRangeEnd = 959320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantBuffer<CBType>.NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003F73 File Offset: 0x00002173
		public ConstantBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001F054 File Offset: 0x0001D254
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003F7C File Offset: 0x0000217C
		public unsafe HashSet<int> m_GlobalBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GlobalBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GlobalBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001F084 File Offset: 0x0001D284
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003F9B File Offset: 0x0000219B
		public unsafe Il2CppArrayBase<CBType> m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_Data);
				return Il2CppArrayBase<CBType>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003FBA File Offset: 0x000021BA
		public unsafe ComputeBuffer m_GPUConstantBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GPUConstantBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantBuffer<CBType>.NativeFieldInfoPtr_m_GPUConstantBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalBindings;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_m_GPUConstantBuffer;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Void_CommandBuffer_byref_CBType_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Void_byref_CBType_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobal_Public_Void_CommandBuffer_Int32_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobal_Public_Void_Int32_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_CommandBuffer_ComputeShader_Int32_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_ComputeShader_Int32_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Material_Int32_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_PushGlobal_Public_Void_CommandBuffer_byref_CBType_Int32_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_PushGlobal_Public_Void_byref_CBType_Int32_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;
	}
}
