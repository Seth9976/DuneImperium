using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B9 RID: 441
	public class WebRequestPrefixElement : Object
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x000865CC File Offset: 0x000847CC
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestPrefixElement()
		{
			Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestPrefixElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr);
			WebRequestPrefixElement.NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "Prefix");
			WebRequestPrefixElement.NativeFieldInfoPtr_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creator");
			WebRequestPrefixElement.NativeFieldInfoPtr_creatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creatorType");
			WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100667499);
			WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100667500);
			WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100667501);
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00086674 File Offset: 0x00084874
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x000866B4 File Offset: 0x000848B4
		public unsafe IWebRequestCreate Creator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 474615, RefRangeEnd = 474616, XrefRangeStart = 474592, XrefRangeEnd = 474615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000866F8 File Offset: 0x000848F8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestPrefixElement(string P, IWebRequestCreate C)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(P);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(C);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0000BA2B File Offset: 0x00009C2B
		public WebRequestPrefixElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00086758 File Offset: 0x00084958
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0000BA34 File Offset: 0x00009C34
		public unsafe string Prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00086780 File Offset: 0x00084980
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0000BA53 File Offset: 0x00009C53
		public unsafe IWebRequestCreate creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x000867B0 File Offset: 0x000849B0
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0000BA72 File Offset: 0x00009C72
		public unsafe Type creatorType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeFieldInfoPtr_Prefix;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeFieldInfoPtr_creator;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeFieldInfoPtr_creatorType;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0;
	}
}
