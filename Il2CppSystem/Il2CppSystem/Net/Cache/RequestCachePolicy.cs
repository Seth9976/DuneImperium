using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022E RID: 558
	public class RequestCachePolicy : Object
	{
		// Token: 0x060024F0 RID: 9456 RVA: 0x000A9BCC File Offset: 0x000A7DCC
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCachePolicy()
		{
			Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCachePolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr);
			RequestCachePolicy.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, "m_Level");
			RequestCachePolicy.NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100668762);
			RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100668763);
			RequestCachePolicy.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100668764);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x000A9C4C File Offset: 0x000A7E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487225, XrefRangeEnd = 487226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCachePolicy(RequestCacheLevel level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCachePolicy.NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000A9C94 File Offset: 0x000A7E94
		public unsafe RequestCacheLevel Level
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000A9CD0 File Offset: 0x000A7ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487226, XrefRangeEnd = 487232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestCachePolicy.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00010184 File Offset: 0x0000E384
		public RequestCachePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000A9D14 File Offset: 0x000A7F14
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x0001018D File Offset: 0x0000E38D
		public unsafe RequestCacheLevel m_Level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level)) = value;
			}
		}

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr_m_Level;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
