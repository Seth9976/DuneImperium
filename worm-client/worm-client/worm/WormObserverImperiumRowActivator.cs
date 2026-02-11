using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using voodoo;
using worm.match.data;

namespace worm
{
	// Token: 0x02000057 RID: 87
	public class WormObserverImperiumRowActivator : VersionedDataComponentObserver<WormPlayerTurnTypesData>
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00023F88 File Offset: 0x00022188
		// Note: this type is marked as 'beforefieldinit'.
		static WormObserverImperiumRowActivator()
		{
			Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormObserverImperiumRowActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr);
			WormObserverImperiumRowActivator.NativeFieldInfoPtr_showImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr, "showImperiumRow");
			WormObserverImperiumRowActivator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr, 100663889);
			WormObserverImperiumRowActivator.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr, 100663890);
			WormObserverImperiumRowActivator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr, 100663891);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00024008 File Offset: 0x00022208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692858, XrefRangeEnd = 692871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormObserverImperiumRowActivator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00024044 File Offset: 0x00022244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692871, XrefRangeEnd = 692878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormObserverImperiumRowActivator.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00024080 File Offset: 0x00022280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692878, XrefRangeEnd = 692881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormObserverImperiumRowActivator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormObserverImperiumRowActivator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormObserverImperiumRowActivator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003943 File Offset: 0x00001B43
		public WormObserverImperiumRowActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000240BC File Offset: 0x000222BC
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000394C File Offset: 0x00001B4C
		public unsafe WormShowImperiumRow showImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormObserverImperiumRowActivator.NativeFieldInfoPtr_showImperiumRow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormObserverImperiumRowActivator.NativeFieldInfoPtr_showImperiumRow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_showImperiumRow;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
