using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000037 RID: 55
	public class ConstantBuffer : Object
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x0001E34C File Offset: 0x0001C54C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantBuffer()
		{
			Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ConstantBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr);
			ConstantBuffer.NativeFieldInfoPtr_m_RegisteredConstantBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, "m_RegisteredConstantBuffers");
			ConstantBuffer.NativeMethodInfoPtr_PushGlobal_Public_Static_Void_CommandBuffer_byref_CBType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663856);
			ConstantBuffer.NativeMethodInfoPtr_PushGlobal_Public_Static_Void_byref_CBType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663857);
			ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663858);
			ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663859);
			ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663860);
			ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663861);
			ConstantBuffer.NativeMethodInfoPtr_UpdateData_Public_Static_Void_CommandBuffer_byref_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663862);
			ConstantBuffer.NativeMethodInfoPtr_UpdateData_Public_Static_Void_byref_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663863);
			ConstantBuffer.NativeMethodInfoPtr_SetGlobal_Public_Static_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663864);
			ConstantBuffer.NativeMethodInfoPtr_SetGlobal_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663865);
			ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_CommandBuffer_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663866);
			ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663867);
			ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663868);
			ConstantBuffer.NativeMethodInfoPtr_ReleaseAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663869);
			ConstantBuffer.NativeMethodInfoPtr_Register_Internal_Static_Void_ConstantBufferBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663870);
			ConstantBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr, 100663871);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959082, RefRangeEnd = 959083, XrefRangeStart = 959077, XrefRangeEnd = 959082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushGlobal<CBType>(CommandBuffer cmd, [In] ref CBType data, int shaderId) where CBType : new()
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_PushGlobal_Public_Static_Void_CommandBuffer_byref_CBType_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001E540 File Offset: 0x0001C740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959083, XrefRangeEnd = 959085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushGlobal<CBType>([In] ref CBType data, int shaderId) where CBType : new()
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_PushGlobal_Public_Static_Void_byref_CBType_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001E59C File Offset: 0x0001C79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959085, XrefRangeEnd = 959087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Push<CBType>(CommandBuffer cmd, [In] ref CBType data, ComputeShader cs, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Push_Public_Static_Void_CommandBuffer_byref_CBType_ComputeShader_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001E61C File Offset: 0x0001C81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959087, XrefRangeEnd = 959089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Push<CBType>([In] ref CBType data, ComputeShader cs, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Push_Public_Static_Void_byref_CBType_ComputeShader_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001E68C File Offset: 0x0001C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959089, XrefRangeEnd = 959091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Push<CBType>(CommandBuffer cmd, [In] ref CBType data, Material mat, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Push_Public_Static_Void_CommandBuffer_byref_CBType_Material_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001E70C File Offset: 0x0001C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Push<CBType>([In] ref CBType data, Material mat, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Push_Public_Static_Void_byref_CBType_Material_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001E77C File Offset: 0x0001C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959091, XrefRangeEnd = 959100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateData<CBType>(CommandBuffer cmd, [In] ref CBType data) where CBType : new()
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_UpdateData_Public_Static_Void_CommandBuffer_byref_CBType_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001E7DC File Offset: 0x0001C9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959100, XrefRangeEnd = 959102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateData<CBType>([In] ref CBType data) where CBType : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_UpdateData_Public_Static_Void_byref_CBType_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<CBType>(intPtr4, false, false));
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001E82C File Offset: 0x0001CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959102, XrefRangeEnd = 959104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_SetGlobal_Public_Static_Void_CommandBuffer_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001E870 File Offset: 0x0001CA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959104, XrefRangeEnd = 959109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobal<CBType>(int shaderId) where CBType : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_SetGlobal_Public_Static_Void_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001E8A4 File Offset: 0x0001CAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959109, XrefRangeEnd = 959110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Set_Public_Static_Void_CommandBuffer_ComputeShader_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Set<CBType>(ComputeShader cs, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Set_Public_Static_Void_ComputeShader_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001E940 File Offset: 0x0001CB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Set<CBType>(Material mat, int shaderId) where CBType : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.MethodInfoStoreGeneric_Set_Public_Static_Void_Material_Int32_0<CBType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001E984 File Offset: 0x0001CB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959110, XrefRangeEnd = 959133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.NativeMethodInfoPtr_ReleaseAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959143, RefRangeEnd = 959144, XrefRangeStart = 959133, XrefRangeEnd = 959143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(ConstantBufferBase cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.NativeMethodInfoPtr_Register_Internal_Static_Void_ConstantBufferBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003F4F File Offset: 0x0000214F
		public ConstantBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001EA20 File Offset: 0x0001CC20
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00003F58 File Offset: 0x00002158
		public unsafe static List<ConstantBufferBase> m_RegisteredConstantBuffers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstantBuffer.NativeFieldInfoPtr_m_RegisteredConstantBuffers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantBufferBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstantBuffer.NativeFieldInfoPtr_m_RegisteredConstantBuffers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredConstantBuffers;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_PushGlobal_Public_Static_Void_CommandBuffer_byref_CBType_Int32_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_PushGlobal_Public_Static_Void_byref_CBType_Int32_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_ComputeShader_Int32_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_ComputeShader_Int32_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_Material_Int32_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_Material_Int32_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Static_Void_CommandBuffer_byref_CBType_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Public_Static_Void_byref_CBType_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobal_Public_Static_Void_CommandBuffer_Int32_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobal_Public_Static_Void_Int32_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_CommandBuffer_ComputeShader_Int32_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_ComputeShader_Int32_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_Material_Int32_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAll_Public_Static_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_ConstantBufferBase_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200015D RID: 349
		private sealed class MethodInfoStoreGeneric_PushGlobal_Public_Static_Void_CommandBuffer_byref_CBType_Int32_0<CBType>
		{
			// Token: 0x04000FF5 RID: 4085
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_PushGlobal_Public_Static_Void_CommandBuffer_byref_CBType_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200015E RID: 350
		private sealed class MethodInfoStoreGeneric_PushGlobal_Public_Static_Void_byref_CBType_Int32_0<CBType>
		{
			// Token: 0x04000FF6 RID: 4086
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_PushGlobal_Public_Static_Void_byref_CBType_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200015F RID: 351
		private sealed class MethodInfoStoreGeneric_Push_Public_Static_Void_CommandBuffer_byref_CBType_ComputeShader_Int32_0<CBType>
		{
			// Token: 0x04000FF7 RID: 4087
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_ComputeShader_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000160 RID: 352
		private sealed class MethodInfoStoreGeneric_Push_Public_Static_Void_byref_CBType_ComputeShader_Int32_0<CBType>
		{
			// Token: 0x04000FF8 RID: 4088
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_ComputeShader_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000161 RID: 353
		private sealed class MethodInfoStoreGeneric_Push_Public_Static_Void_CommandBuffer_byref_CBType_Material_Int32_0<CBType>
		{
			// Token: 0x04000FF9 RID: 4089
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_CommandBuffer_byref_CBType_Material_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000162 RID: 354
		private sealed class MethodInfoStoreGeneric_Push_Public_Static_Void_byref_CBType_Material_Int32_0<CBType>
		{
			// Token: 0x04000FFA RID: 4090
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Push_Public_Static_Void_byref_CBType_Material_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000163 RID: 355
		private sealed class MethodInfoStoreGeneric_UpdateData_Public_Static_Void_CommandBuffer_byref_CBType_0<CBType>
		{
			// Token: 0x04000FFB RID: 4091
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_UpdateData_Public_Static_Void_CommandBuffer_byref_CBType_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000164 RID: 356
		private sealed class MethodInfoStoreGeneric_UpdateData_Public_Static_Void_byref_CBType_0<CBType>
		{
			// Token: 0x04000FFC RID: 4092
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_UpdateData_Public_Static_Void_byref_CBType_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000165 RID: 357
		private sealed class MethodInfoStoreGeneric_SetGlobal_Public_Static_Void_CommandBuffer_Int32_0<CBType>
		{
			// Token: 0x04000FFD RID: 4093
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_SetGlobal_Public_Static_Void_CommandBuffer_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000166 RID: 358
		private sealed class MethodInfoStoreGeneric_SetGlobal_Public_Static_Void_Int32_0<CBType>
		{
			// Token: 0x04000FFE RID: 4094
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_SetGlobal_Public_Static_Void_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000167 RID: 359
		private sealed class MethodInfoStoreGeneric_Set_Public_Static_Void_CommandBuffer_ComputeShader_Int32_0<CBType>
		{
			// Token: 0x04000FFF RID: 4095
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_CommandBuffer_ComputeShader_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000168 RID: 360
		private sealed class MethodInfoStoreGeneric_Set_Public_Static_Void_ComputeShader_Int32_0<CBType>
		{
			// Token: 0x04001000 RID: 4096
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_ComputeShader_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000169 RID: 361
		private sealed class MethodInfoStoreGeneric_Set_Public_Static_Void_Material_Int32_0<CBType>
		{
			// Token: 0x04001001 RID: 4097
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConstantBuffer.NativeMethodInfoPtr_Set_Public_Static_Void_Material_Int32_0, Il2CppClassPointerStore<ConstantBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) }))));
		}
	}
}
