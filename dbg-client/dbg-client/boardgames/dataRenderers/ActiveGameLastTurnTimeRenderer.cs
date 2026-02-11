using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.datarenderers
{
	// Token: 0x02000165 RID: 357
	public class ActiveGameLastTurnTimeRenderer : VersionedSubscriber<ReconnectableGameData>
	{
		// Token: 0x06000FFA RID: 4090 RVA: 0x00050294 File Offset: 0x0004E494
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveGameLastTurnTimeRenderer()
		{
			Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ActiveGameLastTurnTimeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr);
			ActiveGameLastTurnTimeRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr, "text");
			ActiveGameLastTurnTimeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr, 100665558);
			ActiveGameLastTurnTimeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr, 100665559);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00050300 File Offset: 0x0004E500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513735, XrefRangeEnd = 513746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveGameLastTurnTimeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0005033C File Offset: 0x0004E53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513746, XrefRangeEnd = 513749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveGameLastTurnTimeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveGameLastTurnTimeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveGameLastTurnTimeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00009BC1 File Offset: 0x00007DC1
		public ActiveGameLastTurnTimeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00050378 File Offset: 0x0004E578
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00009BCA File Offset: 0x00007DCA
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameLastTurnTimeRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameLastTurnTimeRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
