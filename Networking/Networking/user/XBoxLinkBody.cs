using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.user
{
	// Token: 0x0200004C RID: 76
	public class XBoxLinkBody : Object
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000C574 File Offset: 0x0000A774
		// Note: this type is marked as 'beforefieldinit'.
		static XBoxLinkBody()
		{
			Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "XBoxLinkBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr);
			XBoxLinkBody.NativeFieldInfoPtr_encodedXstsToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr, "encodedXstsToken");
			XBoxLinkBody.NativeFieldInfoPtr_dwdUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr, "dwdUsername");
			XBoxLinkBody.NativeFieldInfoPtr_dwdPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr, "dwdPassword");
			XBoxLinkBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr, 100663425);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XBoxLinkBody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XBoxLinkBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XBoxLinkBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003A46 File Offset: 0x00001C46
		public XBoxLinkBody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000C630 File Offset: 0x0000A830
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003A4F File Offset: 0x00001C4F
		public unsafe string encodedXstsToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_encodedXstsToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_encodedXstsToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000C658 File Offset: 0x0000A858
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003A6E File Offset: 0x00001C6E
		public unsafe string dwdUsername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_dwdUsername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_dwdUsername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000C680 File Offset: 0x0000A880
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003A8D File Offset: 0x00001C8D
		public unsafe string dwdPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_dwdPassword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxLinkBody.NativeFieldInfoPtr_dwdPassword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_encodedXstsToken;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_dwdUsername;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_dwdPassword;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
