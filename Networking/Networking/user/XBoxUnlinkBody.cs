using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.user
{
	// Token: 0x0200004E RID: 78
	public class XBoxUnlinkBody : Object
	{
		// Token: 0x06000290 RID: 656 RVA: 0x0000C764 File Offset: 0x0000A964
		// Note: this type is marked as 'beforefieldinit'.
		static XBoxUnlinkBody()
		{
			Il2CppClassPointerStore<XBoxUnlinkBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "XBoxUnlinkBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XBoxUnlinkBody>.NativeClassPtr);
			XBoxUnlinkBody.NativeFieldInfoPtr_encodedXstsToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XBoxUnlinkBody>.NativeClassPtr, "encodedXstsToken");
			XBoxUnlinkBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XBoxUnlinkBody>.NativeClassPtr, 100663427);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XBoxUnlinkBody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XBoxUnlinkBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XBoxUnlinkBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public XBoxUnlinkBody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00003ADD File Offset: 0x00001CDD
		public unsafe string encodedXstsToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxUnlinkBody.NativeFieldInfoPtr_encodedXstsToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxUnlinkBody.NativeFieldInfoPtr_encodedXstsToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_encodedXstsToken;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
