using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D9 RID: 473
	public class CookieParser : Object
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x0008E404 File Offset: 0x0008C604
		// Note: this type is marked as 'beforefieldinit'.
		static CookieParser()
		{
			Il2CppClassPointerStore<CookieParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieParser>.NativeClassPtr);
			CookieParser.NativeFieldInfoPtr_m_tokenizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, "m_tokenizer");
			CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100667796);
			CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100667797);
			CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100667798);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0008E484 File Offset: 0x0008C684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477015, XrefRangeEnd = 477023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieParser(string cookieString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cookieString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0008E4D0 File Offset: 0x0008C6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477058, RefRangeEnd = 477059, XrefRangeStart = 477023, XrefRangeEnd = 477058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cookie Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0008E510 File Offset: 0x0008C710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477063, RefRangeEnd = 477065, XrefRangeStart = 477059, XrefRangeEnd = 477063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckQuoted(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0000C867 File Offset: 0x0000AA67
		public CookieParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0008E54C File Offset: 0x0008C74C
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0000C870 File Offset: 0x0000AA70
		public unsafe CookieTokenizer m_tokenizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieTokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenizer;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Cookie_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0;
	}
}
