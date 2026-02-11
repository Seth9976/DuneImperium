using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.authentication
{
	// Token: 0x02000057 RID: 87
	public class AuthResponseError : Exception
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		// Note: this type is marked as 'beforefieldinit'.
		static AuthResponseError()
		{
			Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.authentication", "AuthResponseError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr);
			AuthResponseError.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, "Code");
			AuthResponseError.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, "Text");
			AuthResponseError.NativeFieldInfoPtr_LocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, "LocKey");
			AuthResponseError.NativeFieldInfoPtr_InfoUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, "InfoUrl");
			AuthResponseError.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, 100663828);
			AuthResponseError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr, 100663829);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00010C78 File Offset: 0x0000EE78
		public unsafe override string Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthResponseError.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00010CBC File Offset: 0x0000EEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170114, XrefRangeEnd = 1170118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthResponseError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthResponseError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthResponseError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000393A File Offset: 0x00001B3A
		public AuthResponseError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00003943 File Offset: 0x00001B43
		public unsafe int Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_Code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_Code)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00010D20 File Offset: 0x0000EF20
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000395E File Offset: 0x00001B5E
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00010D48 File Offset: 0x0000EF48
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000397D File Offset: 0x00001B7D
		public unsafe string LocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_LocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_LocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00010D70 File Offset: 0x0000EF70
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe string InfoUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_InfoUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseError.NativeFieldInfoPtr_InfoUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_Code;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_LocKey;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_InfoUrl;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
