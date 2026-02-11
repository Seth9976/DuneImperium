using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000027 RID: 39
	public class UrlData : DataComponent
	{
		// Token: 0x060001BE RID: 446 RVA: 0x0000860C File Offset: 0x0000680C
		// Note: this type is marked as 'beforefieldinit'.
		static UrlData()
		{
			Il2CppClassPointerStore<UrlData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "UrlData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UrlData>.NativeClassPtr);
			UrlData.NativeFieldInfoPtr_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UrlData>.NativeClassPtr, "Url");
			UrlData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UrlData>.NativeClassPtr, 100663465);
			UrlData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UrlData>.NativeClassPtr, 100663466);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008678 File Offset: 0x00006878
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UrlData(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UrlData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UrlData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000086C4 File Offset: 0x000068C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235184, XrefRangeEnd = 1235194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UrlData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002F65 File Offset: 0x00001165
		public UrlData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00008708 File Offset: 0x00006908
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002F6E File Offset: 0x0000116E
		public unsafe string Url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UrlData.NativeFieldInfoPtr_Url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UrlData.NativeFieldInfoPtr_Url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_Url;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
