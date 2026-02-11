using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.messages.effect
{
	// Token: 0x02000044 RID: 68
	public class EffectMessage : Object
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000BB68 File Offset: 0x00009D68
		// Note: this type is marked as 'beforefieldinit'.
		static EffectMessage()
		{
			Il2CppClassPointerStore<EffectMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "EffectMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr);
			EffectMessage.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr, "<GameID>k__BackingField");
			EffectMessage.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr, 100663409);
			EffectMessage.NativeMethodInfoPtr_set_GameID_Public_set_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr, 100663410);
			EffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr, 100663411);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000BC28 File Offset: 0x00009E28
		public unsafe virtual GameID GameID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMessage.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMessage.NativeMethodInfoPtr_set_GameID_Public_set_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000388D File Offset: 0x00001A8D
		public EffectMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00003896 File Offset: 0x00001A96
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMessage.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMessage.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_set_GameID_Public_set_Void_GameID_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
