using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.datarenderers
{
	// Token: 0x02000174 RID: 372
	public sealed class SafeSubscriberDescriptionRenderer : VersionedSubscriber<BasicDescription>
	{
		// Token: 0x06001078 RID: 4216 RVA: 0x000518C0 File Offset: 0x0004FAC0
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSubscriberDescriptionRenderer()
		{
			Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "SafeSubscriberDescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr);
			SafeSubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, "nameText");
			SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, 100665603);
			SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, 100665604);
			SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, 100665605);
			SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, 100665606);
			SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr, 100665607);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00051968 File Offset: 0x0004FB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514043, XrefRangeEnd = 514050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0005199C File Offset: 0x0004FB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514050, XrefRangeEnd = 514054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000519D0 File Offset: 0x0004FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514054, XrefRangeEnd = 514057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00051A04 File Offset: 0x0004FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514057, XrefRangeEnd = 514064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00051A38 File Offset: 0x0004FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514064, XrefRangeEnd = 514067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSubscriberDescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSubscriberDescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00009FD6 File Offset: 0x000081D6
		public SafeSubscriberDescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00051A74 File Offset: 0x0004FC74
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00009FDF File Offset: 0x000081DF
		public unsafe TMP_Text nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_clear_Private_Void_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
