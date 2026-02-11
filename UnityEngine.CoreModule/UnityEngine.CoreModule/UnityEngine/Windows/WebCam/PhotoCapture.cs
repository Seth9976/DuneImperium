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
	// Token: 0x0200019C RID: 412
	public class PhotoCapture : Object
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x0008987C File Offset: 0x00087A7C
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCapture()
		{
			Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
			PhotoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "m_NativePtr");
			PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "HR_SUCCESS");
			PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667495);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667496);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667498);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667499);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667500);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667501);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667502);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667503);
			PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667504);
			PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667505);
			PhotoCapture.GetSupportedResolutions_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetSupportedResolutions_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetSupportedResolutions_Internal");
			PhotoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::Instantiate_Internal");
			PhotoCapture.StopPhotoModeAsyncDelegateField = IL2CPP.ResolveICall<PhotoCapture.StopPhotoModeAsyncDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::StopPhotoModeAsync");
			PhotoCapture.CapturePhotoToDisk_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToDisk_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToDisk_Internal");
			PhotoCapture.CapturePhotoToMemory_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToMemory_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToMemory_Internal");
			PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetUnsafePointerToVideoDeviceController");
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000899F8 File Offset: 0x00087BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677963, XrefRangeEnd = 677965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00089A38 File Offset: 0x00087C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677965, XrefRangeEnd = 677970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00089A7C File Offset: 0x00087C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677970, XrefRangeEnd = 677972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00089AC0 File Offset: 0x00087CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00089B04 File Offset: 0x00087D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00089B48 File Offset: 0x00087D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677972, XrefRangeEnd = 677989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref photoCaptureFramePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00089B9C File Offset: 0x00087D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677989, XrefRangeEnd = 677996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00089BD0 File Offset: 0x00087DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677996, XrefRangeEnd = 677998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00089C04 File Offset: 0x00087E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677998, XrefRangeEnd = 678004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00089C40 File Offset: 0x00087E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678004, XrefRangeEnd = 678006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0000B98C File Offset: 0x00009B8C
		public PhotoCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00089C74 File Offset: 0x00087E74
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0000B995 File Offset: 0x00009B95
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00089C9C File Offset: 0x00087E9C
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00089CB8 File Offset: 0x00087EB8
		public static PhotoCapture.PhotoCaptureResult MakeCaptureResult(PhotoCapture.CaptureResultType resultType, long hResult)
		{
			return new PhotoCapture.PhotoCaptureResult
			{
				resultType = resultType,
				hResult = hResult
			};
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x0000B9BE File Offset: 0x00009BBE
		public static IEnumerable<Resolution> SupportedResolutions
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00089CE4 File Offset: 0x00087EE4
		public static Il2CppStructArray<Resolution> GetSupportedResolutions_Internal()
		{
			IntPtr intPtr = PhotoCapture.GetSupportedResolutions_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00089D0C File Offset: 0x00087F0C
		public static void CreateAsync(bool showHolograms, PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			PhotoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00089D38 File Offset: 0x00087F38
		public static void CreateAsync(PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			bool flag = onCreatedCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCreatedCallback");
			}
			PhotoCapture.Instantiate_Internal(false, onCreatedCallback);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0000B9CB File Offset: 0x00009BCB
		public static IntPtr Instantiate_Internal(bool showHolograms, PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
		{
			return PhotoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr(onCreatedCallback));
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0000B9DE File Offset: 0x00009BDE
		public void StopPhotoModeAsync(PhotoCapture.OnPhotoModeStoppedCallback onPhotoModeStoppedCallback)
		{
			PhotoCapture.StopPhotoModeAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onPhotoModeStoppedCallback));
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00089D64 File Offset: 0x00087F64
		public void TakePhotoAsync(string filename, PhotoCaptureFileOutputFormat fileOutputFormat, PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
		{
			bool flag = onCapturedPhotoToDiskCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCapturedPhotoToDiskCallback");
			}
			bool flag2 = String.IsNullOrEmpty(filename);
			if (flag2)
			{
				throw new ArgumentNullException("filename");
			}
			filename = filename.Replace("/", "\\");
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
			this.CapturePhotoToDisk_Internal(filename, fileOutputFormat, onCapturedPhotoToDiskCallback);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0000B9F6 File Offset: 0x00009BF6
		public void CapturePhotoToDisk_Internal(string filename, PhotoCaptureFileOutputFormat fileOutputFormat, PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
		{
			PhotoCapture.CapturePhotoToDisk_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(filename), fileOutputFormat, IL2CPP.Il2CppObjectBaseToPtr(onCapturedPhotoToDiskCallback));
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00089E1C File Offset: 0x0008801C
		public void TakePhotoAsync(PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
		{
			bool flag = onCapturedPhotoToMemoryCallback == null;
			if (flag)
			{
				throw new ArgumentNullException("onCapturedPhotoToMemoryCallback");
			}
			this.CapturePhotoToMemory_Internal(onCapturedPhotoToMemoryCallback);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000BA15 File Offset: 0x00009C15
		public void CapturePhotoToMemory_Internal(PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
		{
			PhotoCapture.CapturePhotoToMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(onCapturedPhotoToMemoryCallback));
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0000BA2D File Offset: 0x00009C2D
		public IntPtr GetUnsafePointerToVideoDeviceController()
		{
			return PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly PhotoCapture.GetSupportedResolutions_InternalDelegate GetSupportedResolutions_InternalDelegateField;

		// Token: 0x04001ADE RID: 6878
		private static readonly PhotoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;

		// Token: 0x04001ADF RID: 6879
		private static readonly PhotoCapture.StopPhotoModeAsyncDelegate StopPhotoModeAsyncDelegateField;

		// Token: 0x04001AE0 RID: 6880
		private static readonly PhotoCapture.CapturePhotoToDisk_InternalDelegate CapturePhotoToDisk_InternalDelegateField;

		// Token: 0x04001AE1 RID: 6881
		private static readonly PhotoCapture.CapturePhotoToMemory_InternalDelegate CapturePhotoToMemory_InternalDelegateField;

		// Token: 0x04001AE2 RID: 6882
		private static readonly PhotoCapture.GetUnsafePointerToVideoDeviceControllerDelegate GetUnsafePointerToVideoDeviceControllerDelegateField;

		// Token: 0x0200085B RID: 2139
		public enum CaptureResultType
		{
			// Token: 0x04002CCD RID: 11469
			Success,
			// Token: 0x04002CCE RID: 11470
			UnknownError
		}

		// Token: 0x0200085C RID: 2140
		[StructLayout(2)]
		public struct PhotoCaptureResult
		{
			// Token: 0x0600398B RID: 14731 RVA: 0x000BD640 File Offset: 0x000BB840
			// Note: this type is marked as 'beforefieldinit'.
			static PhotoCaptureResult()
			{
				Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "PhotoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr);
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "resultType");
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x0600398C RID: 14732 RVA: 0x00014472 File Offset: 0x00012672
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04002CCF RID: 11471
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04002CD0 RID: 11472
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04002CD1 RID: 11473
			[FieldOffset(0)]
			public PhotoCapture.CaptureResultType resultType;

			// Token: 0x04002CD2 RID: 11474
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x0200085D RID: 2141
		public sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x0600398D RID: 14733 RVA: 0x00014484 File Offset: 0x00012684
			// Note: this type is marked as 'beforefieldinit'.
			static OnCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCaptureResourceCreatedCallback");
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100667506);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100667507);
			}

			// Token: 0x0600398E RID: 14734 RVA: 0x000BD694 File Offset: 0x000BB894
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCaptureResourceCreatedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600398F RID: 14735 RVA: 0x000BD6F0 File Offset: 0x000BB8F0
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003990 RID: 14736 RVA: 0x000144C2 File Offset: 0x000126C2
			public OnCaptureResourceCreatedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003991 RID: 14737 RVA: 0x000144CB File Offset: 0x000126CB
			public static implicit operator PhotoCapture.OnCaptureResourceCreatedCallback(Action<PhotoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06003992 RID: 14738 RVA: 0x000144D3 File Offset: 0x000126D3
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator +(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
			}

			// Token: 0x06003993 RID: 14739 RVA: 0x000144E1 File Offset: 0x000126E1
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator -(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CD3 RID: 11475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CD4 RID: 11476
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;
		}

		// Token: 0x0200085E RID: 2142
		public sealed class OnPhotoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06003994 RID: 14740 RVA: 0x000144F2 File Offset: 0x000126F2
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStartedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStartedCallback");
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100667508);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100667509);
			}

			// Token: 0x06003995 RID: 14741 RVA: 0x000BD734 File Offset: 0x000BB934
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677888, XrefRangeEnd = 677891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStartedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003996 RID: 14742 RVA: 0x000BD790 File Offset: 0x000BB990
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003997 RID: 14743 RVA: 0x00014530 File Offset: 0x00012730
			public OnPhotoModeStartedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003998 RID: 14744 RVA: 0x00014539 File Offset: 0x00012739
			public static implicit operator PhotoCapture.OnPhotoModeStartedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStartedCallback>(A_0);
			}

			// Token: 0x06003999 RID: 14745 RVA: 0x00014541 File Offset: 0x00012741
			public static PhotoCapture.OnPhotoModeStartedCallback operator +(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStartedCallback>();
			}

			// Token: 0x0600399A RID: 14746 RVA: 0x0001454F File Offset: 0x0001274F
			public static PhotoCapture.OnPhotoModeStartedCallback operator -(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStartedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CD5 RID: 11477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CD6 RID: 11478
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x0200085F RID: 2143
		public sealed class OnPhotoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x0600399B RID: 14747 RVA: 0x00014560 File Offset: 0x00012760
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStoppedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStoppedCallback");
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100667510);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100667511);
			}

			// Token: 0x0600399C RID: 14748 RVA: 0x000BD7D0 File Offset: 0x000BB9D0
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStoppedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x000BD82C File Offset: 0x000BBA2C
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600399E RID: 14750 RVA: 0x0001459E File Offset: 0x0001279E
			public OnPhotoModeStoppedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600399F RID: 14751 RVA: 0x000145A7 File Offset: 0x000127A7
			public static implicit operator PhotoCapture.OnPhotoModeStoppedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStoppedCallback>(A_0);
			}

			// Token: 0x060039A0 RID: 14752 RVA: 0x000145AF File Offset: 0x000127AF
			public static PhotoCapture.OnPhotoModeStoppedCallback operator +(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
			}

			// Token: 0x060039A1 RID: 14753 RVA: 0x000145BD File Offset: 0x000127BD
			public static PhotoCapture.OnPhotoModeStoppedCallback operator -(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CD7 RID: 11479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CD8 RID: 11480
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x02000860 RID: 2144
		public sealed class OnCapturedToDiskCallback : MulticastDelegate
		{
			// Token: 0x060039A2 RID: 14754 RVA: 0x000145CE File Offset: 0x000127CE
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToDiskCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToDiskCallback");
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100667512);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100667513);
			}

			// Token: 0x060039A3 RID: 14755 RVA: 0x000BD86C File Offset: 0x000BBA6C
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToDiskCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039A4 RID: 14756 RVA: 0x000BD8C8 File Offset: 0x000BBAC8
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039A5 RID: 14757 RVA: 0x0001460C File Offset: 0x0001280C
			public OnCapturedToDiskCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039A6 RID: 14758 RVA: 0x00014615 File Offset: 0x00012815
			public static implicit operator PhotoCapture.OnCapturedToDiskCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToDiskCallback>(A_0);
			}

			// Token: 0x060039A7 RID: 14759 RVA: 0x0001461D File Offset: 0x0001281D
			public static PhotoCapture.OnCapturedToDiskCallback operator +(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToDiskCallback>();
			}

			// Token: 0x060039A8 RID: 14760 RVA: 0x0001462B File Offset: 0x0001282B
			public static PhotoCapture.OnCapturedToDiskCallback operator -(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToDiskCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CD9 RID: 11481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CDA RID: 11482
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x02000861 RID: 2145
		public sealed class OnCapturedToMemoryCallback : MulticastDelegate
		{
			// Token: 0x060039A9 RID: 14761 RVA: 0x0001463C File Offset: 0x0001283C
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToMemoryCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToMemoryCallback");
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100667514);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100667515);
			}

			// Token: 0x060039AA RID: 14762 RVA: 0x000BD908 File Offset: 0x000BBB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677960, XrefRangeEnd = 677963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x000BD964 File Offset: 0x000BBB64
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(photoCaptureFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039AC RID: 14764 RVA: 0x0001467A File Offset: 0x0001287A
			public OnCapturedToMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x00014683 File Offset: 0x00012883
			public static implicit operator PhotoCapture.OnCapturedToMemoryCallback(Action<PhotoCapture.PhotoCaptureResult, PhotoCaptureFrame> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToMemoryCallback>(A_0);
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x0001468B File Offset: 0x0001288B
			public static PhotoCapture.OnCapturedToMemoryCallback operator +(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToMemoryCallback>();
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x00014699 File Offset: 0x00012899
			public static PhotoCapture.OnCapturedToMemoryCallback operator -(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhotoCapture.OnCapturedToMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002CDB RID: 11483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CDC RID: 11484
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;
		}

		// Token: 0x02000862 RID: 2146
		// (Invoke) Token: 0x060039B1 RID: 14769
		private delegate IntPtr GetSupportedResolutions_InternalDelegate();

		// Token: 0x02000863 RID: 2147
		// (Invoke) Token: 0x060039B3 RID: 14771
		private delegate IntPtr Instantiate_InternalDelegate(bool showHolograms, IntPtr onCreatedCallback);

		// Token: 0x02000864 RID: 2148
		// (Invoke) Token: 0x060039B5 RID: 14773
		private delegate void StopPhotoModeAsyncDelegate(IntPtr @this, IntPtr onPhotoModeStoppedCallback);

		// Token: 0x02000865 RID: 2149
		// (Invoke) Token: 0x060039B7 RID: 14775
		private delegate void CapturePhotoToDisk_InternalDelegate(IntPtr @this, IntPtr filename, PhotoCaptureFileOutputFormat fileOutputFormat, IntPtr onCapturedPhotoToDiskCallback);

		// Token: 0x02000866 RID: 2150
		// (Invoke) Token: 0x060039B9 RID: 14777
		private delegate void CapturePhotoToMemory_InternalDelegate(IntPtr @this, IntPtr onCapturedPhotoToMemoryCallback);

		// Token: 0x02000867 RID: 2151
		// (Invoke) Token: 0x060039BB RID: 14779
		private delegate IntPtr GetUnsafePointerToVideoDeviceControllerDelegate(IntPtr @this);
	}
}
