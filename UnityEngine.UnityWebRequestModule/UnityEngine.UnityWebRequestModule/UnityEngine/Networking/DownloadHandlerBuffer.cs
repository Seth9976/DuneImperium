using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000007 RID: 7
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00004448 File Offset: 0x00002648
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerBuffer()
		{
			Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandlerBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr);
			DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, "m_NativeData");
			DownloadHandlerBuffer.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663353);
			DownloadHandlerBuffer.NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663354);
			DownloadHandlerBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663355);
			DownloadHandlerBuffer.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663356);
			DownloadHandlerBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663357);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000044F0 File Offset: 0x000026F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247193, XrefRangeEnd = 1247195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(DownloadHandlerBuffer obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004534 File Offset: 0x00002734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247195, XrefRangeEnd = 1247197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004568 File Offset: 0x00002768
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1247200, RefRangeEnd = 1247205, XrefRangeStart = 1247197, XrefRangeEnd = 1247200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000045A4 File Offset: 0x000027A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247205, XrefRangeEnd = 1247212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NativeArray<byte> GetNativeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000045DC File Offset: 0x000027DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247212, XrefRangeEnd = 1247216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000022F2 File Offset: 0x000004F2
		public DownloadHandlerBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004610 File Offset: 0x00002810
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022FB File Offset: 0x000004FB
		public NativeArray<byte> m_NativeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004640 File Offset: 0x00002840
		public static string GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerBuffer>(www).text;
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_NativeData;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
