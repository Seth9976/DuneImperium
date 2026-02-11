using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.validators
{
	// Token: 0x020000EF RID: 239
	public class PlayerTypeValidator : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x0003E01C File Offset: 0x0003C21C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTypeValidator()
		{
			Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.validators", "PlayerTypeValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr);
			PlayerTypeValidator.NativeFieldInfoPtr_validPlayerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, "validPlayerTypes");
			PlayerTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, "<Valid>k__BackingField");
			PlayerTypeValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, 100664790);
			PlayerTypeValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, 100664791);
			PlayerTypeValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, 100664792);
			PlayerTypeValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, 100664793);
			PlayerTypeValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr, 100664794);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0003E114 File Offset: 0x0003C314
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0003E154 File Offset: 0x0003C354
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0003E190 File Offset: 0x0003C390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506704, XrefRangeEnd = 506708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506708, XrefRangeEnd = 506718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTypeValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTypeValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00006F62 File Offset: 0x00005162
		public PlayerTypeValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0003E208 File Offset: 0x0003C408
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006F6B File Offset: 0x0000516B
		public unsafe Il2CppStructArray<PlayerTypeData.PlayerType> validPlayerTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeValidator.NativeFieldInfoPtr_validPlayerTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PlayerTypeData.PlayerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeValidator.NativeFieldInfoPtr_validPlayerTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0003E238 File Offset: 0x0003C438
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00006F8A File Offset: 0x0000518A
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_validPlayerTypes;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
