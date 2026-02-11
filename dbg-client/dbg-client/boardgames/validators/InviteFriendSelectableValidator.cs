using System;
using dwd.core.data;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.validators
{
	// Token: 0x020000ED RID: 237
	public class InviteFriendSelectableValidator : VersionedSubscriber<SelectedData<DataComposition>>
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x0003DC98 File Offset: 0x0003BE98
		// Note: this type is marked as 'beforefieldinit'.
		static InviteFriendSelectableValidator()
		{
			Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.validators", "InviteFriendSelectableValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr);
			InviteFriendSelectableValidator.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr, "isValid");
			InviteFriendSelectableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr, 100664783);
			InviteFriendSelectableValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr, 100664784);
			InviteFriendSelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr, 100664785);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0003DD18 File Offset: 0x0003BF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506683, XrefRangeEnd = 506687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InviteFriendSelectableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0003DD54 File Offset: 0x0003BF54
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendSelectableValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0003DD90 File Offset: 0x0003BF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506687, XrefRangeEnd = 506690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InviteFriendSelectableValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InviteFriendSelectableValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendSelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00006EE0 File Offset: 0x000050E0
		public InviteFriendSelectableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0003DDCC File Offset: 0x0003BFCC
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00006EE9 File Offset: 0x000050E9
		public unsafe bool isValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendSelectableValidator.NativeFieldInfoPtr_isValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendSelectableValidator.NativeFieldInfoPtr_isValid)) = value;
			}
		}

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_isValid;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
