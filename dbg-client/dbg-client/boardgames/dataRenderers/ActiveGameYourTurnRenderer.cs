using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.datarenderers
{
	// Token: 0x02000169 RID: 361
	public class ActiveGameYourTurnRenderer : VersionedSubscriber<CurrentTurnPlayerData>
	{
		// Token: 0x06001018 RID: 4120 RVA: 0x000507AC File Offset: 0x0004E9AC
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveGameYourTurnRenderer()
		{
			Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ActiveGameYourTurnRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr);
			ActiveGameYourTurnRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr, "image");
			ActiveGameYourTurnRenderer.NativeFieldInfoPtr_localPlayerOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr, "localPlayerOnly");
			ActiveGameYourTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr, 100665566);
			ActiveGameYourTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr, 100665567);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0005082C File Offset: 0x0004EA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513818, XrefRangeEnd = 513821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveGameYourTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00050868 File Offset: 0x0004EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513821, XrefRangeEnd = 513824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveGameYourTurnRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveGameYourTurnRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveGameYourTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00009CBE File Offset: 0x00007EBE
		public ActiveGameYourTurnRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x000508A4 File Offset: 0x0004EAA4
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00009CC7 File Offset: 0x00007EC7
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameYourTurnRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameYourTurnRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x000508D4 File Offset: 0x0004EAD4
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00009CE6 File Offset: 0x00007EE6
		public unsafe bool localPlayerOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameYourTurnRenderer.NativeFieldInfoPtr_localPlayerOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameYourTurnRenderer.NativeFieldInfoPtr_localPlayerOnly)) = value;
			}
		}

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerOnly;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
