using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003A RID: 58
	public class InvitationRemoval : TypedMessage
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0000BA5C File Offset: 0x00009C5C
		// Note: this type is marked as 'beforefieldinit'.
		static InvitationRemoval()
		{
			Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "InvitationRemoval");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr);
			InvitationRemoval.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr, "To");
			InvitationRemoval.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr, "From");
			InvitationRemoval.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr, 100663619);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvitationRemoval()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvitationRemoval>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationRemoval.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002FD0 File Offset: 0x000011D0
		public InvitationRemoval(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000BB04 File Offset: 0x00009D04
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002FD9 File Offset: 0x000011D9
		public unsafe string To
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationRemoval.NativeFieldInfoPtr_To);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationRemoval.NativeFieldInfoPtr_To), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000BB2C File Offset: 0x00009D2C
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002FF8 File Offset: 0x000011F8
		public unsafe string From
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationRemoval.NativeFieldInfoPtr_From);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationRemoval.NativeFieldInfoPtr_From), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_To;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_From;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
