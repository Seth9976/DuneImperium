using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020AC File Offset: 0x000002AC
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerTexture()
		{
			Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestTextureModule.dll", "UnityEngine.Networking", "DownloadHandlerTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr);
			DownloadHandlerTexture.NativeFieldInfoPtr_m_NativeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, "m_NativeData");
			DownloadHandlerTexture.NativeFieldInfoPtr_mNonReadable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, "mNonReadable");
			DownloadHandlerTexture.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerTexture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663297);
			DownloadHandlerTexture.NativeMethodInfoPtr_InternalCreateTexture_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663298);
			DownloadHandlerTexture.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663299);
			DownloadHandlerTexture.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663300);
			DownloadHandlerTexture.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663301);
			DownloadHandlerTexture.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663302);
			DownloadHandlerTexture.NativeMethodInfoPtr_InternalGetTextureNative_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002190 File Offset: 0x00000390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273037, XrefRangeEnd = 1273039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(DownloadHandlerTexture obj, bool readable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerTexture_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021E0 File Offset: 0x000003E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273039, XrefRangeEnd = 1273041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateTexture(bool readable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_InternalCreateTexture_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002220 File Offset: 0x00000420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273041, XrefRangeEnd = 1273044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerTexture(bool readable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002268 File Offset: 0x00000468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273044, XrefRangeEnd = 1273045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NativeArray<byte> GetNativeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022A0 File Offset: 0x000004A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273045, XrefRangeEnd = 1273047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022D4 File Offset: 0x000004D4
		public unsafe Texture2D texture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1273049, RefRangeEnd = 1273050, XrefRangeStart = 1273047, XrefRangeEnd = 1273049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002314 File Offset: 0x00000514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273049, RefRangeEnd = 1273050, XrefRangeStart = 1273049, XrefRangeEnd = 1273050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D InternalGetTextureNative()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerTexture.NativeMethodInfoPtr_InternalGetTextureNative_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		public DownloadHandlerTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002059 File Offset: 0x00000259
		public NativeArray<byte> m_NativeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerTexture.NativeFieldInfoPtr_m_NativeData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerTexture.NativeFieldInfoPtr_m_NativeData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002087 File Offset: 0x00000287
		public unsafe bool mNonReadable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerTexture.NativeFieldInfoPtr_mNonReadable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerTexture.NativeFieldInfoPtr_mNonReadable)) = value;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000023AC File Offset: 0x000005AC
		public static Texture2D GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_NativeData;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_mNonReadable;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerTexture_Boolean_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateTexture_Private_Void_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetTextureNative_Private_Texture2D_0;
	}
}
