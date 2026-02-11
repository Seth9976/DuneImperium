using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A2 RID: 418
	public class FtpWebRequestCreator : Object
	{
		// Token: 0x06001A46 RID: 6726 RVA: 0x000832D4 File Offset: 0x000814D4
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebRequestCreator()
		{
			Il2CppClassPointerStore<FtpWebRequestCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebRequestCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequestCreator>.NativeClassPtr);
			FtpWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequestCreator>.NativeClassPtr, 100667393);
			FtpWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequestCreator>.NativeClassPtr, 100667394);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0008332C File Offset: 0x0008152C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebRequestCreator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequestCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00083368 File Offset: 0x00081568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473881, XrefRangeEnd = 473885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000B483 File Offset: 0x00009683
		public FtpWebRequestCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;
	}
}
