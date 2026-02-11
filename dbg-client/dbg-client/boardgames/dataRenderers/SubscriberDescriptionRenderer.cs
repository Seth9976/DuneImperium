using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.datarenderers
{
	// Token: 0x02000175 RID: 373
	public sealed class SubscriberDescriptionRenderer : VersionedSubscriber<BasicDescription>
	{
		// Token: 0x06001081 RID: 4225 RVA: 0x00051AA4 File Offset: 0x0004FCA4
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberDescriptionRenderer()
		{
			Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "SubscriberDescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr);
			SubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, "nameText");
			SubscriberDescriptionRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, 100665608);
			SubscriberDescriptionRenderer.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, 100665609);
			SubscriberDescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, 100665610);
			SubscriberDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, 100665611);
			SubscriberDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr, 100665612);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00051B4C File Offset: 0x0004FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514067, XrefRangeEnd = 514074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberDescriptionRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00051B80 File Offset: 0x0004FD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514074, XrefRangeEnd = 514078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberDescriptionRenderer.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00051BB4 File Offset: 0x0004FDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514078, XrefRangeEnd = 514081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberDescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514081, XrefRangeEnd = 514087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberDescriptionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00051C1C File Offset: 0x0004FE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514087, XrefRangeEnd = 514090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberDescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberDescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberDescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00009FFE File Offset: 0x000081FE
		public SubscriberDescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00051C58 File Offset: 0x0004FE58
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x0000A007 File Offset: 0x00008207
		public unsafe TMP_Text nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberDescriptionRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_clear_Private_Void_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
