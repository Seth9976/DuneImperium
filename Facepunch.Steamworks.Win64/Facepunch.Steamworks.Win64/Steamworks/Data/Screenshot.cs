using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000209 RID: 521
	[StructLayout(2)]
	public struct Screenshot
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x0007D984 File Offset: 0x0007BB84
		// Note: this type is marked as 'beforefieldinit'.
		static Screenshot()
		{
			Il2CppClassPointerStore<Screenshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Screenshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screenshot>.NativeClassPtr);
			Screenshot.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Screenshot>.NativeClassPtr, "Value");
			Screenshot.NativeMethodInfoPtr_TagUser_Public_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screenshot>.NativeClassPtr, 100668055);
			Screenshot.NativeMethodInfoPtr_SetLocation_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screenshot>.NativeClassPtr, 100668056);
			Screenshot.NativeMethodInfoPtr_TagPublishedFile_Public_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screenshot>.NativeClassPtr, 100668057);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0007DA04 File Offset: 0x0007BC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952773, XrefRangeEnd = 952776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TagUser(SteamId user)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screenshot.NativeMethodInfoPtr_TagUser_Public_Boolean_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0007DA44 File Offset: 0x0007BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952776, XrefRangeEnd = 952779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLocation(string location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screenshot.NativeMethodInfoPtr_SetLocation_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0007DA88 File Offset: 0x0007BC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952779, XrefRangeEnd = 952782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TagPublishedFile(PublishedFileId file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref file;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screenshot.NativeMethodInfoPtr_TagPublishedFile_Public_Boolean_PublishedFileId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00008806 File Offset: 0x00006A06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Screenshot>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_TagUser_Public_Boolean_SteamId_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_SetLocation_Public_Boolean_String_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_TagPublishedFile_Public_Boolean_PublishedFileId_0;

		// Token: 0x04001F36 RID: 7990
		[FieldOffset(0)]
		public ScreenshotHandle Value;
	}
}
