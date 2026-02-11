using System;
using dwd.core.data;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.validators
{
	// Token: 0x020000F0 RID: 240
	public class RemoveFriendSelectableValidator : VersionedSubscriber<SelectedData<DataComposition>>
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x0003E260 File Offset: 0x0003C460
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveFriendSelectableValidator()
		{
			Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.validators", "RemoveFriendSelectableValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr);
			RemoveFriendSelectableValidator.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr, "isValid");
			RemoveFriendSelectableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr, 100664795);
			RemoveFriendSelectableValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr, 100664796);
			RemoveFriendSelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr, 100664797);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0003E2E0 File Offset: 0x0003C4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506718, XrefRangeEnd = 506722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemoveFriendSelectableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0003E31C File Offset: 0x0003C51C
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveFriendSelectableValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0003E358 File Offset: 0x0003C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506722, XrefRangeEnd = 506725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveFriendSelectableValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveFriendSelectableValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveFriendSelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00006FA5 File Offset: 0x000051A5
		public RemoveFriendSelectableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0003E394 File Offset: 0x0003C594
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00006FAE File Offset: 0x000051AE
		public unsafe bool isValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveFriendSelectableValidator.NativeFieldInfoPtr_isValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveFriendSelectableValidator.NativeFieldInfoPtr_isValid)) = value;
			}
		}

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_isValid;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
