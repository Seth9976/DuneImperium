using System;
using boardgames.notifications;
using Canis.skirmishScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.game.messages.pbm;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class WormNotifications : MonoBehaviour
{
	// Token: 0x060001E9 RID: 489 RVA: 0x0001EF24 File Offset: 0x0001D124
	// Note: this type is marked as 'beforefieldinit'.
	static WormNotifications()
	{
		Il2CppClassPointerStore<WormNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormNotifications");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormNotifications>.NativeClassPtr);
		WormNotifications.NativeMethodInfoPtr_AddMessageHandlers_Public_Virtual_Final_New_Void_INotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNotifications>.NativeClassPtr, 100663638);
		WormNotifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNotifications>.NativeClassPtr, 100663639);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0001EF7C File Offset: 0x0001D17C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689773, XrefRangeEnd = 689813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddMessageHandlers(INotifications notifications)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(notifications);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNotifications.NativeMethodInfoPtr_AddMessageHandlers_Public_Virtual_Final_New_Void_INotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormNotifications()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormNotifications>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNotifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002E47 File Offset: 0x00001047
	public WormNotifications(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeMethodInfoPtr_AddMessageHandlers_Public_Virtual_Final_New_Void_INotifications_0;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002CD RID: 717
	[ObfuscatedName("WormNotifications+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x000722A4 File Offset: 0x000704A4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormNotifications>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr);
			WormNotifications.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, "<>9");
			WormNotifications.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, "<>9__0_0");
			WormNotifications.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, "<>9__0_1");
			WormNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, 100663641);
			WormNotifications.__c.NativeMethodInfoPtr__AddMessageHandlers_b__0_0_Internal_IEnumerator_PBMGameResigned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, 100663642);
			WormNotifications.__c.NativeMethodInfoPtr__AddMessageHandlers_b__0_1_Internal_IEnumerator_DailyChallengeBadgeEarned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr, 100663643);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00072348 File Offset: 0x00070548
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormNotifications.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNotifications.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00072384 File Offset: 0x00070584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689765, XrefRangeEnd = 689769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator _AddMessageHandlers_b__0_0(PBMGameResigned _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNotifications.__c.NativeMethodInfoPtr__AddMessageHandlers_b__0_0_Internal_IEnumerator_PBMGameResigned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000723D4 File Offset: 0x000705D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689769, XrefRangeEnd = 689773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator _AddMessageHandlers_b__0_1(DailyChallengeBadgeEarned message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNotifications.__c.NativeMethodInfoPtr__AddMessageHandlers_b__0_1_Internal_IEnumerator_DailyChallengeBadgeEarned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00010C41 File Offset: 0x0000EE41
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00072424 File Offset: 0x00070624
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00010C4A File Offset: 0x0000EE4A
		public unsafe static WormNotifications.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormNotifications.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormNotifications.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormNotifications.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0007244C File Offset: 0x0007064C
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00010C5C File Offset: 0x0000EE5C
		public unsafe static Func<PBMGameResigned, IEnumerator> __9__0_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormNotifications.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PBMGameResigned, IEnumerator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormNotifications.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00072474 File Offset: 0x00070674
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00010C6E File Offset: 0x0000EE6E
		public unsafe static Func<DailyChallengeBadgeEarned, IEnumerator> __9__0_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormNotifications.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DailyChallengeBadgeEarned, IEnumerator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormNotifications.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr__AddMessageHandlers_b__0_0_Internal_IEnumerator_PBMGameResigned_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr__AddMessageHandlers_b__0_1_Internal_IEnumerator_DailyChallengeBadgeEarned_0;
	}
}
