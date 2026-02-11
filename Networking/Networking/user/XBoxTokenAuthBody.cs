using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.user
{
	// Token: 0x0200004D RID: 77
	public class XBoxTokenAuthBody : Object
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// Note: this type is marked as 'beforefieldinit'.
		static XBoxTokenAuthBody()
		{
			Il2CppClassPointerStore<XBoxTokenAuthBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.user", "XBoxTokenAuthBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XBoxTokenAuthBody>.NativeClassPtr);
			XBoxTokenAuthBody.NativeFieldInfoPtr_encodedXstsToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XBoxTokenAuthBody>.NativeClassPtr, "encodedXstsToken");
			XBoxTokenAuthBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XBoxTokenAuthBody>.NativeClassPtr, 100663426);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000C700 File Offset: 0x0000A900
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XBoxTokenAuthBody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XBoxTokenAuthBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XBoxTokenAuthBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003AAC File Offset: 0x00001CAC
		public XBoxTokenAuthBody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000C73C File Offset: 0x0000A93C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003AB5 File Offset: 0x00001CB5
		public unsafe string encodedXstsToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxTokenAuthBody.NativeFieldInfoPtr_encodedXstsToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XBoxTokenAuthBody.NativeFieldInfoPtr_encodedXstsToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_encodedXstsToken;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
