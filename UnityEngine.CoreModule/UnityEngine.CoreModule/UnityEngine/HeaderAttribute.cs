using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000111 RID: 273
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderAttribute()
		{
			Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HeaderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr);
			HeaderAttribute.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, "header");
			HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, 100666430);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0006CCF8 File Offset: 0x0006AEF8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00008E3F File Offset: 0x0000703F
		public HeaderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0006CD44 File Offset: 0x0006AF44
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00008E48 File Offset: 0x00007048
		public unsafe string header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
