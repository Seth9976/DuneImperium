using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200017B RID: 379
	public class AvatarDataComponent : VersionedDataComponent
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x00052398 File Offset: 0x00050598
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarDataComponent()
		{
			Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "AvatarDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr);
			AvatarDataComponent.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr, "avatar");
			AvatarDataComponent.NativeMethodInfoPtr_get_Avatar_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr, 100665639);
			AvatarDataComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr, 100665640);
			AvatarDataComponent.NativeMethodInfoPtr_UpdateAvatar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr, 100665641);
			AvatarDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr, 100665642);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0005242C File Offset: 0x0005062C
		public unsafe string Avatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarDataComponent.NativeMethodInfoPtr_get_Avatar_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00052464 File Offset: 0x00050664
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarDataComponent(string avatar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarDataComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x000524B0 File Offset: 0x000506B0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514281, XrefRangeEnd = 514283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvatar(string avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarDataComponent.NativeMethodInfoPtr_UpdateAvatar_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000524F4 File Offset: 0x000506F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514296, XrefRangeEnd = 514299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000A0EE File Offset: 0x000082EE
		public AvatarDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00052538 File Offset: 0x00050738
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0000A0F7 File Offset: 0x000082F7
		public unsafe string avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarDataComponent.NativeFieldInfoPtr_avatar);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarDataComponent.NativeFieldInfoPtr_avatar), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_get_Avatar_Public_get_String_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvatar_Public_Void_String_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
