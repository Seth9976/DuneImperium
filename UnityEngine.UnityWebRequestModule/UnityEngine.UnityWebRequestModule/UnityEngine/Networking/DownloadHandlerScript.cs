using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking
{
	// Token: 0x02000008 RID: 8
	public class DownloadHandlerScript : DownloadHandler
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00004660 File Offset: 0x00002860
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerScript()
		{
			Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandlerScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr);
			DownloadHandlerScript.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663358);
			DownloadHandlerScript.NativeMethodInfoPtr_CreatePreallocated_Private_Static_IntPtr_DownloadHandlerScript_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663359);
			DownloadHandlerScript.NativeMethodInfoPtr_InternalCreateScript_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663360);
			DownloadHandlerScript.NativeMethodInfoPtr_InternalCreateScript_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663361);
			DownloadHandlerScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663362);
			DownloadHandlerScript.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr, 100663363);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004708 File Offset: 0x00002908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247216, XrefRangeEnd = 1247218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(DownloadHandlerScript obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerScript_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000474C File Offset: 0x0000294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247218, XrefRangeEnd = 1247220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreatePreallocated(DownloadHandlerScript obj, Il2CppStructArray<byte> preallocatedBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr_CreatePreallocated_Private_Static_IntPtr_DownloadHandlerScript_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000047A0 File Offset: 0x000029A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247220, XrefRangeEnd = 1247222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr_InternalCreateScript_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000047D4 File Offset: 0x000029D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247222, XrefRangeEnd = 1247224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateScript(Il2CppStructArray<byte> preallocatedBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr_InternalCreateScript_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004818 File Offset: 0x00002A18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1247227, RefRangeEnd = 1247231, XrefRangeStart = 1247224, XrefRangeEnd = 1247227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004854 File Offset: 0x00002A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247234, RefRangeEnd = 1247236, XrefRangeStart = 1247231, XrefRangeEnd = 1247234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerScript(Il2CppStructArray<byte> preallocatedBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerScript>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerScript.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002329 File Offset: 0x00000529
		public DownloadHandlerScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerScript_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_CreatePreallocated_Private_Static_IntPtr_DownloadHandlerScript_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateScript_Private_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateScript_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
