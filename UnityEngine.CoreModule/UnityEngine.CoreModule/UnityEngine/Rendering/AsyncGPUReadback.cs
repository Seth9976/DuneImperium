using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020001DF RID: 479
	public static class AsyncGPUReadback : Object
	{
		// Token: 0x060021A7 RID: 8615 RVA: 0x00093D34 File Offset: 0x00091F34
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncGPUReadback()
		{
			Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667840);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667841);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667842);
			AsyncGPUReadback.WaitAllRequestsDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");
			AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_1_Injected");
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_2_Injected");
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_GraphicsBuffer_2_Injected");
			AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_1_Injected");
			AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_2_Injected");
			AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_3_Injected");
			AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_4_Injected");
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00093E18 File Offset: 0x00092018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681408, RefRangeEnd = 681409, XrefRangeStart = 681404, XrefRangeEnd = 681408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00093E6C File Offset: 0x0009206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681409, XrefRangeEnd = 681411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00093EBC File Offset: 0x000920BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681411, XrefRangeEnd = 681413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Request_Internal_GraphicsBuffer_1_Injected(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0000CDEA File Offset: 0x0000AFEA
		public AsyncGPUReadback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00093F10 File Offset: 0x00092110
		public static void ValidateFormat(Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat)
		{
			UnityEngine.Experimental.Rendering.GraphicsFormat format = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormat(src);
			bool flag = !SystemInfo.IsFormatSupported(format, UnityEngine.Experimental.Rendering.FormatUsage.ReadPixels);
			if (flag)
			{
				Debug.LogError(String.Format("'{0}' doesn't support ReadPixels usage on this platform. Async GPU readback failed.", format));
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0000CDF3 File Offset: 0x0000AFF3
		public static void WaitAllRequests()
		{
			AsyncGPUReadback.WaitAllRequestsDelegateField();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00093F4C File Offset: 0x0009214C
		public static AsyncGPUReadbackRequest Request(ComputeBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00093F74 File Offset: 0x00092174
		public static AsyncGPUReadbackRequest Request(ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00093F9C File Offset: 0x0009219C
		public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00093FC4 File Offset: 0x000921C4
		public static AsyncGPUReadbackRequest Request(Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00093FEC File Offset: 0x000921EC
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			return AsyncGPUReadback.Request(src, mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00094014 File Offset: 0x00092214
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00094044 File Offset: 0x00092244
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_3(src, mipIndex, x, width, y, height, z, depth, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00094078 File Offset: 0x00092278
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			return AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000940AC File Offset: 0x000922AC
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, null);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x000940EC File Offset: 0x000922EC
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, ComputeBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00094120 File Offset: 0x00092320
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00094158 File Offset: 0x00092358
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, GraphicsBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0009418C File Offset: 0x0009238C
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000941C4 File Offset: 0x000923C4
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000941F8 File Offset: 0x000923F8
		public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00094224 File Offset: 0x00092424
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00094264 File Offset: 0x00092464
		public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0009429C File Offset: 0x0009249C
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000942E8 File Offset: 0x000924E8
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, ComputeBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0009431C File Offset: 0x0009251C
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00094354 File Offset: 0x00092554
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, GraphicsBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00094388 File Offset: 0x00092588
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000943C0 File Offset: 0x000925C0
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000943F4 File Offset: 0x000925F4
		public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00094420 File Offset: 0x00092620
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00094460 File Offset: 0x00092660
		public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00094498 File Offset: 0x00092698
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest asyncGPUReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
			asyncGPUReadbackRequest.SetScriptingCallback(callback);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000944E4 File Offset: 0x000926E4
		public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_ComputeBuffer_1_Injected(buffer, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000944FC File Offset: 0x000926FC
		public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_2(ComputeBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_Injected(src, size, offset, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00094518 File Offset: 0x00092718
		public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_Injected(src, size, offset, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00094534 File Offset: 0x00092734
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_Texture_1_Injected(src, mipIndex, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0009454C File Offset: 0x0009274C
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_2(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_Texture_2_Injected(src, mipIndex, dstFormat, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00094568 File Offset: 0x00092768
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_3(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_Texture_3_Injected(src, mipIndex, x, width, y, height, z, depth, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0009458C File Offset: 0x0009278C
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_4(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest asyncGPUReadbackRequest;
			AsyncGPUReadback.Request_Internal_Texture_4_Injected(src, mipIndex, x, width, y, height, z, depth, dstFormat, data, out asyncGPUReadbackRequest);
			return asyncGPUReadbackRequest;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0000CDFF File Offset: 0x0000AFFF
		public unsafe static void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer), data, out ret);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0000CE13 File Offset: 0x0000B013
		public unsafe static void Request_Internal_ComputeBuffer_2_Injected(ComputeBuffer src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), size, offset, data, out ret);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0000CE2A File Offset: 0x0000B02A
		public unsafe static void Request_Internal_GraphicsBuffer_2_Injected(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), size, offset, data, out ret);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0000CE41 File Offset: 0x0000B041
		public unsafe static void Request_Internal_Texture_1_Injected(Texture src, int mipIndex, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, data, out ret);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0000CE56 File Offset: 0x0000B056
		public unsafe static void Request_Internal_Texture_2_Injected(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, dstFormat, data, out ret);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000945B4 File Offset: 0x000927B4
		public unsafe static void Request_Internal_Texture_3_Injected(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, x, width, y, height, z, depth, data, out ret);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000945E0 File Offset: 0x000927E0
		public unsafe static void Request_Internal_Texture_4_Injected(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, x, width, y, height, z, depth, dstFormat, data, out ret);
		}

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly AsyncGPUReadback.WaitAllRequestsDelegate WaitAllRequestsDelegateField;

		// Token: 0x04001CA5 RID: 7333
		private static readonly AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegate Request_Internal_ComputeBuffer_1_InjectedDelegateField;

		// Token: 0x04001CA6 RID: 7334
		private static readonly AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate Request_Internal_ComputeBuffer_2_InjectedDelegateField;

		// Token: 0x04001CA7 RID: 7335
		private static readonly AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate Request_Internal_GraphicsBuffer_2_InjectedDelegateField;

		// Token: 0x04001CA8 RID: 7336
		private static readonly AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate Request_Internal_Texture_1_InjectedDelegateField;

		// Token: 0x04001CA9 RID: 7337
		private static readonly AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegate Request_Internal_Texture_2_InjectedDelegateField;

		// Token: 0x04001CAA RID: 7338
		private static readonly AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate Request_Internal_Texture_3_InjectedDelegateField;

		// Token: 0x04001CAB RID: 7339
		private static readonly AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate Request_Internal_Texture_4_InjectedDelegateField;

		// Token: 0x02000931 RID: 2353
		// (Invoke) Token: 0x06003B7F RID: 15231
		private delegate void WaitAllRequestsDelegate();

		// Token: 0x02000932 RID: 2354
		// (Invoke) Token: 0x06003B81 RID: 15233
		private delegate void Request_Internal_ComputeBuffer_1_InjectedDelegate(IntPtr buffer, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000933 RID: 2355
		// (Invoke) Token: 0x06003B83 RID: 15235
		private delegate void Request_Internal_ComputeBuffer_2_InjectedDelegate(IntPtr src, int size, int offset, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000934 RID: 2356
		// (Invoke) Token: 0x06003B85 RID: 15237
		private delegate void Request_Internal_GraphicsBuffer_2_InjectedDelegate(IntPtr src, int size, int offset, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000935 RID: 2357
		// (Invoke) Token: 0x06003B87 RID: 15239
		private delegate void Request_Internal_Texture_1_InjectedDelegate(IntPtr src, int mipIndex, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000936 RID: 2358
		// (Invoke) Token: 0x06003B89 RID: 15241
		private delegate void Request_Internal_Texture_2_InjectedDelegate(IntPtr src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000937 RID: 2359
		// (Invoke) Token: 0x06003B8B RID: 15243
		private delegate void Request_Internal_Texture_3_InjectedDelegate(IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000938 RID: 2360
		// (Invoke) Token: 0x06003B8D RID: 15245
		private delegate void Request_Internal_Texture_4_InjectedDelegate(IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, IntPtr data, [Out] IntPtr ret);
	}
}
