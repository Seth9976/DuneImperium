using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.effect
{
	// Token: 0x02000046 RID: 70
	public class PlayFX : EffectMessage
	{
		// Token: 0x06000255 RID: 597 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayFX()
		{
			Il2CppClassPointerStore<PlayFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "PlayFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFX>.NativeClassPtr);
			PlayFX.NativeFieldInfoPtr_LocationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFX>.NativeClassPtr, "LocationID");
			PlayFX.NativeFieldInfoPtr_FXName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFX>.NativeClassPtr, "FXName");
			PlayFX.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFX>.NativeClassPtr, "Attributes");
			PlayFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFX>.NativeClassPtr, 100663414);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000BE74 File Offset: 0x0000A074
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000038DD File Offset: 0x00001ADD
		public PlayFX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000038E6 File Offset: 0x00001AE6
		public unsafe EntityID LocationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_LocationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_LocationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00003905 File Offset: 0x00001B05
		public unsafe string FXName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_FXName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_FXName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000BF08 File Offset: 0x0000A108
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00003924 File Offset: 0x00001B24
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFX.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_LocationID;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_FXName;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
