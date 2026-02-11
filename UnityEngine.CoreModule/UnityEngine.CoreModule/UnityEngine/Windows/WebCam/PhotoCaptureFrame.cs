using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200019D RID: 413
	public sealed class PhotoCaptureFrame : Object
	{
		// Token: 0x06001EBA RID: 7866 RVA: 0x00089E48 File Offset: 0x00088048
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCaptureFrame()
		{
			Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCaptureFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr);
			PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "m_NativePtr");
			PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<dataLength>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<hasLocationData>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<pixelFormat>k__BackingField");
			PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667516);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667517);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667518);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667519);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667520);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667521);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667522);
			PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667524);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667525);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667526);
			PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100667527);
			PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::UploadImageDataToTexture_Internal");
			PhotoCaptureFrame.GetUnsafePointerToBufferDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetUnsafePointerToBufferDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetUnsafePointerToBuffer");
			PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::CopyRawImageDataIntoBuffer_Internal");
			PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCameraToWorldMatrix_Injected");
			PhotoCaptureFrame.GetProjection_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetProjection_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetProjection_Injected");
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00089FF0 File Offset: 0x000881F0
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0008A02C File Offset: 0x0008822C
		public unsafe int dataLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0008A06C File Offset: 0x0008826C
		public unsafe bool hasLocationData
		{
			get
			{
				return this._hasLocationData_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0000BABC File Offset: 0x00009CBC
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x0008A0AC File Offset: 0x000882AC
		public unsafe CapturePixelFormat pixelFormat
		{
			get
			{
				return this._pixelFormat_k__BackingField;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0008A0EC File Offset: 0x000882EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678006, XrefRangeEnd = 678008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0008A128 File Offset: 0x00088328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678008, XrefRangeEnd = 678021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHasLocationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0008A164 File Offset: 0x00088364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678021, XrefRangeEnd = 678023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapturePixelFormat GetCapturePixelFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0008A1A0 File Offset: 0x000883A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 678030, RefRangeEnd = 678032, XrefRangeStart = 678023, XrefRangeEnd = 678030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0008A1D4 File Offset: 0x000883D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678032, XrefRangeEnd = 678034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0008A208 File Offset: 0x00088408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678034, XrefRangeEnd = 678039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0008A23C File Offset: 0x0008843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678039, XrefRangeEnd = 678043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0000BA3F File Offset: 0x00009C3F
		public PhotoCaptureFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0008A270 File Offset: 0x00088470
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x0000BA48 File Offset: 0x00009C48
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0008A298 File Offset: 0x00088498
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0000BA63 File Offset: 0x00009C63
		public unsafe int _dataLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0008A2C0 File Offset: 0x000884C0
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x0000BA7E File Offset: 0x00009C7E
		public unsafe bool _hasLocationData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0008A2E8 File Offset: 0x000884E8
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0000BA99 File Offset: 0x00009C99
		public unsafe CapturePixelFormat _pixelFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0008A310 File Offset: 0x00088510
		public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix)
		{
			cameraToWorldMatrix = Matrix4x4.identity;
			return false;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0008A330 File Offset: 0x00088530
		public Matrix4x4 GetCameraToWorldMatrix()
		{
			Matrix4x4 matrix4x;
			this.GetCameraToWorldMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0008A348 File Offset: 0x00088548
		public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix)
		{
			projectionMatrix = Matrix4x4.identity;
			return false;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0008A368 File Offset: 0x00088568
		public bool TryGetProjectionMatrix(float nearClipPlane, float farClipPlane, out Matrix4x4 projectionMatrix)
		{
			bool hasLocationData = this.hasLocationData;
			bool flag3;
			if (hasLocationData)
			{
				float num = 0.01f;
				bool flag = nearClipPlane < num;
				if (flag)
				{
					nearClipPlane = num;
				}
				bool flag2 = farClipPlane < nearClipPlane + num;
				if (flag2)
				{
					farClipPlane = nearClipPlane + num;
				}
				projectionMatrix = this.GetProjection();
				float num2 = 1f / (farClipPlane - nearClipPlane);
				float num3 = -(farClipPlane + nearClipPlane) * num2;
				float num4 = -(2f * farClipPlane * nearClipPlane) * num2;
				projectionMatrix.m22 = num3;
				projectionMatrix.m23 = num4;
				flag3 = true;
			}
			else
			{
				projectionMatrix = Matrix4x4.identity;
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0008A3FC File Offset: 0x000885FC
		public Matrix4x4 GetProjection()
		{
			Matrix4x4 matrix4x;
			this.GetProjection_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0008A414 File Offset: 0x00088614
		public void UploadImageDataToTexture(Texture2D targetTexture)
		{
			bool flag = targetTexture == null;
			if (flag)
			{
				throw new ArgumentNullException("targetTexture");
			}
			bool flag2 = this.pixelFormat > CapturePixelFormat.BGRA32;
			if (flag2)
			{
				throw new ArgumentException("Uploading PhotoCaptureFrame to a texture is only supported with BGRA32 CameraFrameFormat!");
			}
			this.UploadImageDataToTexture_Internal(targetTexture);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		public void UploadImageDataToTexture_Internal(Texture2D targetTexture)
		{
			PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetTexture));
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0000BADC File Offset: 0x00009CDC
		public IntPtr GetUnsafePointerToBuffer()
		{
			return PhotoCaptureFrame.GetUnsafePointerToBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0000BAEE File Offset: 0x00009CEE
		public void CopyRawImageDataIntoBuffer(List<byte> byteBuffer)
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0000BAF1 File Offset: 0x00009CF1
		public void CopyRawImageDataIntoBuffer_Internal([Out] Il2CppStructArray<byte> byteArray)
		{
			PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(byteArray));
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0000BB09 File Offset: 0x00009D09
		public void GetCameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public void GetProjection_Injected(out Matrix4x4 ret)
		{
			PhotoCaptureFrame.GetProjection_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeFieldInfoPtr__dataLength_k__BackingField;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeFieldInfoPtr__hasLocationData_k__BackingField;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr__pixelFormat_k__BackingField;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_GetDataLength_Private_Int32_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly PhotoCaptureFrame.UploadImageDataToTexture_InternalDelegate UploadImageDataToTexture_InternalDelegateField;

		// Token: 0x04001AF3 RID: 6899
		private static readonly PhotoCaptureFrame.GetUnsafePointerToBufferDelegate GetUnsafePointerToBufferDelegateField;

		// Token: 0x04001AF4 RID: 6900
		private static readonly PhotoCaptureFrame.CopyRawImageDataIntoBuffer_InternalDelegate CopyRawImageDataIntoBuffer_InternalDelegateField;

		// Token: 0x04001AF5 RID: 6901
		private static readonly PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate GetCameraToWorldMatrix_InjectedDelegateField;

		// Token: 0x04001AF6 RID: 6902
		private static readonly PhotoCaptureFrame.GetProjection_InjectedDelegate GetProjection_InjectedDelegateField;

		// Token: 0x02000868 RID: 2152
		// (Invoke) Token: 0x060039BD RID: 14781
		private delegate void UploadImageDataToTexture_InternalDelegate(IntPtr @this, IntPtr targetTexture);

		// Token: 0x02000869 RID: 2153
		// (Invoke) Token: 0x060039BF RID: 14783
		private delegate IntPtr GetUnsafePointerToBufferDelegate(IntPtr @this);

		// Token: 0x0200086A RID: 2154
		// (Invoke) Token: 0x060039C1 RID: 14785
		private delegate void CopyRawImageDataIntoBuffer_InternalDelegate(IntPtr @this, [Out] IntPtr byteArray);

		// Token: 0x0200086B RID: 2155
		// (Invoke) Token: 0x060039C3 RID: 14787
		private delegate void GetCameraToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200086C RID: 2156
		// (Invoke) Token: 0x060039C5 RID: 14789
		private delegate void GetProjection_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
