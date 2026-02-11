using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.dataRenderers
{
	// Token: 0x02000153 RID: 339
	public class PendingGamePlayerNameRenderer : VersionedSubscriber<PendingGamePlayerAccountData>
	{
		// Token: 0x06000F48 RID: 3912 RVA: 0x0004E358 File Offset: 0x0004C558
		// Note: this type is marked as 'beforefieldinit'.
		static PendingGamePlayerNameRenderer()
		{
			Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "PendingGamePlayerNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr);
			PendingGamePlayerNameRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr, "nameText");
			PendingGamePlayerNameRenderer.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr, "format");
			PendingGamePlayerNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr, 100665504);
			PendingGamePlayerNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr, 100665505);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513271, XrefRangeEnd = 513279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGamePlayerNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004E414 File Offset: 0x0004C614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513279, XrefRangeEnd = 513285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingGamePlayerNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGamePlayerNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000095A6 File Offset: 0x000077A6
		public PendingGamePlayerNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0004E450 File Offset: 0x0004C650
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x000095AF File Offset: 0x000077AF
		public unsafe TMP_Text nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerNameRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerNameRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0004E480 File Offset: 0x0004C680
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x000095CE File Offset: 0x000077CE
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerNameRenderer.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerNameRenderer.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
