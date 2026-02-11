using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.validators
{
	// Token: 0x0200002D RID: 45
	public class PlayerSlotEditableValidator : VersionedSubscriber<PlayerSlotLockData>
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlotEditableValidator()
		{
			Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "boardgames.validators", "PlayerSlotEditableValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr);
			PlayerSlotEditableValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, "<Valid>k__BackingField");
			PlayerSlotEditableValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, 100663646);
			PlayerSlotEditableValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, 100663647);
			PlayerSlotEditableValidator.NativeMethodInfoPtr_Validate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, 100663648);
			PlayerSlotEditableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, 100663649);
			PlayerSlotEditableValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr, 100663650);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001F184 File Offset: 0x0001D384
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotEditableValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotEditableValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001F200 File Offset: 0x0001D400
		[CallerCount(0)]
		public unsafe bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotEditableValidator.NativeMethodInfoPtr_Validate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001F23C File Offset: 0x0001D43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689826, XrefRangeEnd = 689831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSlotEditableValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001F278 File Offset: 0x0001D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689831, XrefRangeEnd = 689834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSlotEditableValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSlotEditableValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotEditableValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002EAD File Offset: 0x000010AD
		public PlayerSlotEditableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002EB6 File Offset: 0x000010B6
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotEditableValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotEditableValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Boolean_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
