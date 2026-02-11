using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200019E RID: 414
	public class VideoCapture : Object
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x0008A45C File Offset: 0x0008865C
		// Note: this type is marked as 'beforefieldinit'.
		static VideoCapture()
		{
			Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "VideoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
			VideoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "m_NativePtr");
			VideoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "HR_SUCCESS");
			VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667528);
			VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667529);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667531);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667532);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667533);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667534);
			VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667535);
			VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667536);
			VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667537);
			VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667538);
			VideoCapture.GetSupportedResolutions_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedResolutions_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedResolutions_Internal");
			VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedFrameRatesForResolution_Internal");
			VideoCapture.get_IsRecordingDelegateField = IL2CPP.ResolveICall<VideoCapture.get_IsRecordingDelegate>("UnityEngine.Windows.WebCam.VideoCapture::get_IsRecording");
			VideoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::Instantiate_Internal");
			VideoCapture.StopVideoModeAsyncDelegateField = IL2CPP.ResolveICall<VideoCapture.StopVideoModeAsyncDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopVideoModeAsync");
			VideoCapture.StartRecordingVideoToDisk_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.StartRecordingVideoToDisk_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StartRecordingVideoToDisk_Internal");
			VideoCapture.StopRecordingAsyncDelegateField = IL2CPP.ResolveICall<VideoCapture.StopRecordingAsyncDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopRecordingAsync");
			VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField = IL2CPP.ResolveICall<VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetUnsafePointerToVideoDeviceController");
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0008A5F4 File Offset: 0x000887F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678043, XrefRangeEnd = 678045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0008A634 File Offset: 0x00088834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678045, XrefRangeEnd = 678050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0008A678 File Offset: 0x00088878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678050, XrefRangeEnd = 678052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0008A6BC File Offset: 0x000888BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0008A700 File Offset: 0x00088900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0008A744 File Offset: 0x00088944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0008A788 File Offset: 0x00088988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678052, XrefRangeEnd = 678059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0008A7BC File Offset: 0x000889BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678059, XrefRangeEnd = 678061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0008A7F0 File Offset: 0x000889F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678061, XrefRangeEnd = 678067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0008A82C File Offset: 0x00088A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678067, XrefRangeEnd = 678069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0000BB2F File Offset: 0x00009D2F
		public VideoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0008A860 File Offset: 0x00088A60
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0000BB38 File Offset: 0x00009D38
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0008A888 File Offset: 0x00088A88
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x0000BB53 File Offset: 0x00009D53
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0008A8A4 File Offset: 0x00088AA4
		public static VideoCapture.VideoCaptureResult MakeCaptureResult(VideoCapture.CaptureResultType resultType, long hResult)
		{
			return new VideoCapture.VideoCaptureResult
			{
				resultType = resultType,
				hResult = hResult
			};
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0000BB61 File Offset: 0x00009D61
		public static IEnumerable<Resolution> SupportedResolutions
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		public static Il2CppStructArray<Resolution> GetSupportedResolutions_Internal()
		{
			IntPtr intPtr = VideoCapture.GetSupportedResolutions_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0000BB6E File Offset: 0x00009D6E
		public static IEnumerable<float> GetSupportedFrameRatesForResolution(Resolution resolution)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0008A8F8 File Offset: 0x00088AF8
		public static Il2CppStructArray<float> GetSupportedFrameRatesForResolution_Internal(int resolutionWidth, int resolutionHeight)
		{
			IntPtr intPtr = VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegateField(resolutionWidth, resolutionHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0000BB7B File Offset: 0x00009D7B
		public bool IsRecording
		{
			get
			{
				return VideoCapture.get_IsRecordingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0008A920 File Offset: 0x00088B20
		public static void CreateAsync(bool showHolograms, VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			VideoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0008A94C File Offset: 0x00088B4C
		public static void CreateAsync(VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			VideoCapture.Instantiate_Internal(false, onCreatedCallback);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0000BB8D File Offset: 0x00009D8D
		public static void Instantiate_Internal(bool showHolograms, VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
		{
			VideoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr(onCreatedCallback));
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		public void StopVideoModeAsync(VideoCapture.OnVideoModeStoppedCallback onVideoModeStoppedCallback)
		{
			VideoCapture.StopVideoModeAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onVideoModeStoppedCallback));
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0008A978 File Offset: 0x00088B78
		public void StartRecordingAsync(string filename, VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
		{
			bool flag = onStartedRecordingVideoCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onStartedRecordingVideoCallback");
			}
			bool flag2 = String.IsNullOrEmpty(filename);
			if (flag2)
			{
				throw new ArgumentNullException("filename");
			}
			string directoryName = Path.GetDirectoryName(filename);
			bool flag3 = !String.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName);
			if (flag3)
			{
				throw new ArgumentException("The specified directory does not exist.", "filename");
			}
			FileInfo fileInfo = new FileInfo(filename);
			bool flag4 = fileInfo.Exists && fileInfo.IsReadOnly;
			if (flag4)
			{
				throw new ArgumentException("Cannot write to the file because it is read-only.", "filename");
			}
			this.StartRecordingVideoToDisk_Internal(fileInfo.FullName, onStartedRecordingVideoCallback);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		public void StartRecordingVideoToDisk_Internal(string filename, VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
		{
			VideoCapture.StartRecordingVideoToDisk_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(filename), IL2CPP.Il2CppObjectBaseToPtr(onStartedRecordingVideoCallback));
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0000BBD6 File Offset: 0x00009DD6
		public void StopRecordingAsync(VideoCapture.OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback)
		{
			VideoCapture.StopRecordingAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onStoppedRecordingVideoCallback));
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0000BBEE File Offset: 0x00009DEE
		public IntPtr GetUnsafePointerToVideoDeviceController()
		{
			return VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly VideoCapture.GetSupportedResolutions_InternalDelegate GetSupportedResolutions_InternalDelegateField;

		// Token: 0x04001B04 RID: 6916
		private static readonly VideoCapture.GetSupportedFrameRatesForResolution_InternalDelegate GetSupportedFrameRatesForResolution_InternalDelegateField;

		// Token: 0x04001B05 RID: 6917
		private static readonly VideoCapture.get_IsRecordingDelegate get_IsRecordingDelegateField;

		// Token: 0x04001B06 RID: 6918
		private static readonly VideoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;

		// Token: 0x04001B07 RID: 6919
		private static readonly VideoCapture.StopVideoModeAsyncDelegate StopVideoModeAsyncDelegateField;

		// Token: 0x04001B08 RID: 6920
		private static readonly VideoCapture.StartRecordingVideoToDisk_InternalDelegate StartRecordingVideoToDisk_InternalDelegateField;

		// Token: 0x04001B09 RID: 6921
		private static readonly VideoCapture.StopRecordingAsyncDelegate StopRecordingAsyncDelegateField;

		// Token: 0x04001B0A RID: 6922
		private static readonly VideoCapture.GetUnsafePointerToVideoDeviceControllerDelegate GetUnsafePointerToVideoDeviceControllerDelegateField;

		// Token: 0x0200086D RID: 2157
		public enum CaptureResultType
		{
			// Token: 0x04002CDE RID: 11486
			Success,
			// Token: 0x04002CDF RID: 11487
			UnknownError
		}

		// Token: 0x0200086E RID: 2158
		[StructLayout(2)]
		public struct VideoCaptureResult
		{
			// Token: 0x060039C6 RID: 14790 RVA: 0x000BD9B4 File Offset: 0x000BBBB4
			// Note: this type is marked as 'beforefieldinit'.
			static VideoCaptureResult()
			{
				Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "VideoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr);
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "resultType");
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x060039C7 RID: 14791 RVA: 0x000146AA File Offset: 0x000128AA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04002CE0 RID: 11488
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04002CE1 RID: 11489
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04002CE2 RID: 11490
			[FieldOffset(0)]
			public VideoCapture.CaptureResultType resultType;

			// Token: 0x04002CE3 RID: 11491
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x0200086F RID: 2159
		public sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x060039C8 RID: 14792 RVA: 0x000146BC File Offset: 0x000128BC
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoCaptureResourceCreatedCallback");
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100667539);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100667540);
			}

			// Token: 0x060039C9 RID: 14793 RVA: 0x000BDA08 File Offset: 0x000BBC08
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039CA RID: 14794 RVA: 0x000BDA64 File Offset: 0x000BBC64
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039CB RID: 14795 RVA: 0x000146FA File Offset: 0x000128FA
			public OnVideoCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039CC RID: 14796 RVA: 0x00014703 File Offset: 0x00012903
			public static implicit operator VideoCapture.OnVideoCaptureResourceCreatedCallback(Action<VideoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x060039CD RID: 14797 RVA: 0x0001470B File Offset: 0x0001290B
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator +(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
			}

			// Token: 0x060039CE RID: 14798 RVA: 0x00014719 File Offset: 0x00012919
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator -(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CE4 RID: 11492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CE5 RID: 11493
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;
		}

		// Token: 0x02000870 RID: 2160
		public sealed class OnVideoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x060039CF RID: 14799 RVA: 0x0001472A File Offset: 0x0001292A
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStartedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStartedCallback");
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100667541);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100667542);
			}

			// Token: 0x060039D0 RID: 14800 RVA: 0x000BDAA8 File Offset: 0x000BBCA8
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039D1 RID: 14801 RVA: 0x000BDB04 File Offset: 0x000BBD04
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039D2 RID: 14802 RVA: 0x00014768 File Offset: 0x00012968
			public OnVideoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039D3 RID: 14803 RVA: 0x00014771 File Offset: 0x00012971
			public static implicit operator VideoCapture.OnVideoModeStartedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStartedCallback>(A_0);
			}

			// Token: 0x060039D4 RID: 14804 RVA: 0x00014779 File Offset: 0x00012979
			public static VideoCapture.OnVideoModeStartedCallback operator +(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStartedCallback>();
			}

			// Token: 0x060039D5 RID: 14805 RVA: 0x00014787 File Offset: 0x00012987
			public static VideoCapture.OnVideoModeStartedCallback operator -(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CE6 RID: 11494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CE7 RID: 11495
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000871 RID: 2161
		public sealed class OnVideoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x060039D6 RID: 14806 RVA: 0x00014798 File Offset: 0x00012998
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStoppedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStoppedCallback");
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100667543);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100667544);
			}

			// Token: 0x060039D7 RID: 14807 RVA: 0x000BDB44 File Offset: 0x000BBD44
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039D8 RID: 14808 RVA: 0x000BDBA0 File Offset: 0x000BBDA0
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039D9 RID: 14809 RVA: 0x000147D6 File Offset: 0x000129D6
			public OnVideoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039DA RID: 14810 RVA: 0x000147DF File Offset: 0x000129DF
			public static implicit operator VideoCapture.OnVideoModeStoppedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStoppedCallback>(A_0);
			}

			// Token: 0x060039DB RID: 14811 RVA: 0x000147E7 File Offset: 0x000129E7
			public static VideoCapture.OnVideoModeStoppedCallback operator +(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStoppedCallback>();
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x000147F5 File Offset: 0x000129F5
			public static VideoCapture.OnVideoModeStoppedCallback operator -(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnVideoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CE8 RID: 11496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CE9 RID: 11497
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000872 RID: 2162
		public sealed class OnStartedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x060039DD RID: 14813 RVA: 0x00014806 File Offset: 0x00012A06
			// Note: this type is marked as 'beforefieldinit'.
			static OnStartedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStartedRecordingVideoCallback");
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100667545);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100667546);
			}

			// Token: 0x060039DE RID: 14814 RVA: 0x000BDBE0 File Offset: 0x000BBDE0
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStartedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DF RID: 14815 RVA: 0x000BDC3C File Offset: 0x000BBE3C
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039E0 RID: 14816 RVA: 0x00014844 File Offset: 0x00012A44
			public OnStartedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039E1 RID: 14817 RVA: 0x0001484D File Offset: 0x00012A4D
			public static implicit operator VideoCapture.OnStartedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStartedRecordingVideoCallback>(A_0);
			}

			// Token: 0x060039E2 RID: 14818 RVA: 0x00014855 File Offset: 0x00012A55
			public static VideoCapture.OnStartedRecordingVideoCallback operator +(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStartedRecordingVideoCallback>();
			}

			// Token: 0x060039E3 RID: 14819 RVA: 0x00014863 File Offset: 0x00012A63
			public static VideoCapture.OnStartedRecordingVideoCallback operator -(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStartedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CEA RID: 11498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CEB RID: 11499
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000873 RID: 2163
		public sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x060039E4 RID: 14820 RVA: 0x00014874 File Offset: 0x00012A74
			// Note: this type is marked as 'beforefieldinit'.
			static OnStoppedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStoppedRecordingVideoCallback");
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100667547);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100667548);
			}

			// Token: 0x060039E5 RID: 14821 RVA: 0x000BDC7C File Offset: 0x000BBE7C
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStoppedRecordingVideoCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039E6 RID: 14822 RVA: 0x000BDCD8 File Offset: 0x000BBED8
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039E7 RID: 14823 RVA: 0x000148B2 File Offset: 0x00012AB2
			public OnStoppedRecordingVideoCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039E8 RID: 14824 RVA: 0x000148BB File Offset: 0x00012ABB
			public static implicit operator VideoCapture.OnStoppedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStoppedRecordingVideoCallback>(A_0);
			}

			// Token: 0x060039E9 RID: 14825 RVA: 0x000148C3 File Offset: 0x00012AC3
			public static VideoCapture.OnStoppedRecordingVideoCallback operator +(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
			}

			// Token: 0x060039EA RID: 14826 RVA: 0x000148D1 File Offset: 0x00012AD1
			public static VideoCapture.OnStoppedRecordingVideoCallback operator -(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CEC RID: 11500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CED RID: 11501
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000874 RID: 2164
		public enum AudioState
		{
			// Token: 0x04002CEF RID: 11503
			MicAudio,
			// Token: 0x04002CF0 RID: 11504
			ApplicationAudio,
			// Token: 0x04002CF1 RID: 11505
			ApplicationAndMicAudio,
			// Token: 0x04002CF2 RID: 11506
			None
		}

		// Token: 0x02000875 RID: 2165
		// (Invoke) Token: 0x060039EC RID: 14828
		private delegate IntPtr GetSupportedResolutions_InternalDelegate();

		// Token: 0x02000876 RID: 2166
		// (Invoke) Token: 0x060039EE RID: 14830
		private delegate IntPtr GetSupportedFrameRatesForResolution_InternalDelegate(int resolutionWidth, int resolutionHeight);

		// Token: 0x02000877 RID: 2167
		// (Invoke) Token: 0x060039F0 RID: 14832
		private delegate bool get_IsRecordingDelegate(IntPtr @this);

		// Token: 0x02000878 RID: 2168
		// (Invoke) Token: 0x060039F2 RID: 14834
		private delegate void Instantiate_InternalDelegate(bool showHolograms, IntPtr onCreatedCallback);

		// Token: 0x02000879 RID: 2169
		// (Invoke) Token: 0x060039F4 RID: 14836
		private delegate void StopVideoModeAsyncDelegate(IntPtr @this, IntPtr onVideoModeStoppedCallback);

		// Token: 0x0200087A RID: 2170
		// (Invoke) Token: 0x060039F6 RID: 14838
		private delegate void StartRecordingVideoToDisk_InternalDelegate(IntPtr @this, IntPtr filename, IntPtr onStartedRecordingVideoCallback);

		// Token: 0x0200087B RID: 2171
		// (Invoke) Token: 0x060039F8 RID: 14840
		private delegate void StopRecordingAsyncDelegate(IntPtr @this, IntPtr onStoppedRecordingVideoCallback);

		// Token: 0x0200087C RID: 2172
		// (Invoke) Token: 0x060039FA RID: 14842
		private delegate IntPtr GetUnsafePointerToVideoDeviceControllerDelegate(IntPtr @this);
	}
}
