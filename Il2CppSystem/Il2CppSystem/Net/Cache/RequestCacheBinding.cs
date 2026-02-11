using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200022C RID: 556
	public class RequestCacheBinding : Object
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x000A9950 File Offset: 0x000A7B50
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheBinding()
		{
			Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr);
			RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_RequestCache");
			RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_CacheValidator");
			RequestCacheBinding.NativeFieldInfoPtr_m_Policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_Policy");
			RequestCacheBinding.NativeMethodInfoPtr__ctor_Internal_Void_RequestCache_RequestCacheValidator_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100668758);
			RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100668759);
			RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100668760);
			RequestCacheBinding.NativeMethodInfoPtr_get_Policy_Internal_get_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100668761);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000A9A0C File Offset: 0x000A7C0C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487190, XrefRangeEnd = 487194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestCache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cacheValidator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(policy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr__ctor_Internal_Void_RequestCache_RequestCacheValidator_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000A9A7C File Offset: 0x000A7C7C
		public unsafe RequestCache Cache
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr3) : null;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x000A9ABC File Offset: 0x000A7CBC
		public unsafe RequestCacheValidator Validator
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr3) : null;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000A9AFC File Offset: 0x000A7CFC
		public unsafe RequestCachePolicy Policy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Policy_Internal_get_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr3) : null;
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0001011E File Offset: 0x0000E31E
		public RequestCacheBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000A9B3C File Offset: 0x000A7D3C
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00010127 File Offset: 0x0000E327
		public unsafe RequestCache m_RequestCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000A9B6C File Offset: 0x000A7D6C
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00010146 File Offset: 0x0000E346
		public unsafe RequestCacheValidator m_CacheValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000A9B9C File Offset: 0x000A7D9C
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x00010165 File Offset: 0x0000E365
		public unsafe RequestCachePolicy m_Policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_Policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_Policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestCache;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheValidator;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_m_Policy;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RequestCache_RequestCacheValidator_RequestCachePolicy_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_get_Policy_Internal_get_RequestCachePolicy_0;
	}
}
