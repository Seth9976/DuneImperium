using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000093 RID: 147
	public class XmlCachedStream : MemoryStream
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x000610E0 File Offset: 0x0005F2E0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCachedStream()
		{
			Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCachedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr);
			XmlCachedStream.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, "uri");
			XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, 100666128);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00061138 File Offset: 0x0005F338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381925, RefRangeEnd = 381927, XrefRangeStart = 381917, XrefRangeEnd = 381925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCachedStream(Uri uri, Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00007627 File Offset: 0x00005827
		public XmlCachedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00061198 File Offset: 0x0005F398
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x00007630 File Offset: 0x00005830
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0;
	}
}
