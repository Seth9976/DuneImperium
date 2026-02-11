using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000163 RID: 355
	[DefaultMember("Item")]
	public class CaseSensitiveStringDictionary : StringDictionary
	{
		// Token: 0x0600156A RID: 5482 RVA: 0x0006F810 File Offset: 0x0006DA10
		// Note: this type is marked as 'beforefieldinit'.
		static CaseSensitiveStringDictionary()
		{
			Il2CppClassPointerStore<CaseSensitiveStringDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "CaseSensitiveStringDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseSensitiveStringDictionary>.NativeClassPtr);
			CaseSensitiveStringDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseSensitiveStringDictionary>.NativeClassPtr, 100666558);
			CaseSensitiveStringDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseSensitiveStringDictionary>.NativeClassPtr, 100666559);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0006F868 File Offset: 0x0006DA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466905, RefRangeEnd = 466906, XrefRangeStart = 466905, XrefRangeEnd = 466906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseSensitiveStringDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseSensitiveStringDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseSensitiveStringDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0006F8A4 File Offset: 0x0006DAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467074, XrefRangeEnd = 467081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CaseSensitiveStringDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0000967A File Offset: 0x0000787A
		public CaseSensitiveStringDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0;
	}
}
