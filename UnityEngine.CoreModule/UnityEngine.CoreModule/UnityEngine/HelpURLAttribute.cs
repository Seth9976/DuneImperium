using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012C RID: 300
	public class HelpURLAttribute : Attribute
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x00070058 File Offset: 0x0006E258
		// Note: this type is marked as 'beforefieldinit'.
		static HelpURLAttribute()
		{
			Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr);
			HelpURLAttribute.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Url");
			HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Dispatcher");
			HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_DispatchingFieldName");
			HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100666528);
			HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100666529);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000700EC File Offset: 0x0006E2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660744, RefRangeEnd = 660746, XrefRangeStart = 660738, XrefRangeEnd = 660744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpURLAttribute(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00070138 File Offset: 0x0006E338
		public unsafe string URL
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000095F4 File Offset: 0x000077F4
		public HelpURLAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00070170 File Offset: 0x0006E370
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x000095FD File Offset: 0x000077FD
		public unsafe string m_Url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00070198 File Offset: 0x0006E398
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000961C File Offset: 0x0000781C
		public unsafe bool m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x000701C0 File Offset: 0x0006E3C0
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x00009637 File Offset: 0x00007837
		public unsafe string m_DispatchingFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_m_Url;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingFieldName;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_get_URL_Public_get_String_0;
	}
}
