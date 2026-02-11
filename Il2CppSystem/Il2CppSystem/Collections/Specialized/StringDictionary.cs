using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x0200015D RID: 349
	[DefaultMember("Item")]
	[Serializable]
	public class StringDictionary : Object
	{
		// Token: 0x06001531 RID: 5425 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		// Note: this type is marked as 'beforefieldinit'.
		static StringDictionary()
		{
			Il2CppClassPointerStore<StringDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "StringDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr);
			StringDictionary.NativeFieldInfoPtr_contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr, "contents");
			StringDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr, 100666528);
			StringDictionary.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr, 100666529);
			StringDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr, 100666530);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0006EA3C File Offset: 0x0006CC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466905, RefRangeEnd = 466906, XrefRangeStart = 466890, XrefRangeEnd = 466905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0006EA78 File Offset: 0x0006CC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466906, XrefRangeEnd = 466914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string key, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringDictionary.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0006EAD8 File Offset: 0x0006CCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000953E File Offset: 0x0000773E
		public StringDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0006EB24 File Offset: 0x0006CD24
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00009547 File Offset: 0x00007747
		public unsafe Hashtable contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDictionary.NativeFieldInfoPtr_contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDictionary.NativeFieldInfoPtr_contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr_contents;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;
	}
}
