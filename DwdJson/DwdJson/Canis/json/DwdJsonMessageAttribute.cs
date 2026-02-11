using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x0200000E RID: 14
	public class DwdJsonMessageAttribute : Attribute
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003F00 File Offset: 0x00002100
		// Note: this type is marked as 'beforefieldinit'.
		static DwdJsonMessageAttribute()
		{
			Il2CppClassPointerStore<DwdJsonMessageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdJsonMessageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonMessageAttribute>.NativeClassPtr);
			DwdJsonMessageAttribute.NativeFieldInfoPtr_UseUnityJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdJsonMessageAttribute>.NativeClassPtr, "UseUnityJson");
			DwdJsonMessageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonMessageAttribute>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003F58 File Offset: 0x00002158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonMessageAttribute(bool useUnityJson = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonMessageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useUnityJson;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonMessageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022F2 File Offset: 0x000004F2
		public DwdJsonMessageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003FA0 File Offset: 0x000021A0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022FB File Offset: 0x000004FB
		public unsafe bool UseUnityJson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdJsonMessageAttribute.NativeFieldInfoPtr_UseUnityJson);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdJsonMessageAttribute.NativeFieldInfoPtr_UseUnityJson)) = value;
			}
		}

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_UseUnityJson;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
