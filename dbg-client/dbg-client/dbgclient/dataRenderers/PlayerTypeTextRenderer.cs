using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000C0 RID: 192
	public class PlayerTypeTextRenderer : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x00036010 File Offset: 0x00034210
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTypeTextRenderer()
		{
			Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "PlayerTypeTextRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr);
			PlayerTypeTextRenderer.NativeFieldInfoPtr_playerTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr, "playerTypeText");
			PlayerTypeTextRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr, 100664463);
			PlayerTypeTextRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr, 100664464);
			PlayerTypeTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr, 100664465);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00036090 File Offset: 0x00034290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504578, XrefRangeEnd = 504582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeTextRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000360CC File Offset: 0x000342CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504582, XrefRangeEnd = 504599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeTextRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00036108 File Offset: 0x00034308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504599, XrefRangeEnd = 504602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTypeTextRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTypeTextRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeTextRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00005A99 File Offset: 0x00003C99
		public PlayerTypeTextRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00036144 File Offset: 0x00034344
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00005AA2 File Offset: 0x00003CA2
		public unsafe TMP_Text playerTypeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeTextRenderer.NativeFieldInfoPtr_playerTypeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeTextRenderer.NativeFieldInfoPtr_playerTypeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_playerTypeText;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
