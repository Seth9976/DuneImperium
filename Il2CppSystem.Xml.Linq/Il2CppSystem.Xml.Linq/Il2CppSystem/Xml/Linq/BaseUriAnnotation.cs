using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000003 RID: 3
	public class BaseUriAnnotation : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002D4C File Offset: 0x00000F4C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseUriAnnotation()
		{
			Il2CppClassPointerStore<BaseUriAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "BaseUriAnnotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseUriAnnotation>.NativeClassPtr);
			BaseUriAnnotation.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseUriAnnotation>.NativeClassPtr, "baseUri");
			BaseUriAnnotation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUriAnnotation>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseUriAnnotation(string baseUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseUriAnnotation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseUriAnnotation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public BaseUriAnnotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe string baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUriAnnotation.NativeFieldInfoPtr_baseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUriAnnotation.NativeFieldInfoPtr_baseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
