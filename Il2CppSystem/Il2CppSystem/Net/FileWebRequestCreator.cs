using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E1 RID: 481
	public class FileWebRequestCreator : Object
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x00090D30 File Offset: 0x0008EF30
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebRequestCreator()
		{
			Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebRequestCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr);
			FileWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr, 100667883);
			FileWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr, 100667884);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00090D88 File Offset: 0x0008EF88
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequestCreator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00090DC4 File Offset: 0x0008EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478053, XrefRangeEnd = 478081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000CD16 File Offset: 0x0000AF16
		public FileWebRequestCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;
	}
}
