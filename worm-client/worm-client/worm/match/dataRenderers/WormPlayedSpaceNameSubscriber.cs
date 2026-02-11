using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.boardgames.src.match;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014B RID: 331
	public class WormPlayedSpaceNameSubscriber : Subscriber<WormPlayedSpaceData>
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00044C7C File Offset: 0x00042E7C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayedSpaceNameSubscriber()
		{
			Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayedSpaceNameSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr);
			WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr, "display");
			WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr, "archetypeProvider");
			WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr, 100665299);
			WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr, 100665300);
			WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr, 100665301);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00044D10 File Offset: 0x00042F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707050, XrefRangeEnd = 707058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00044D4C File Offset: 0x00042F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707058, XrefRangeEnd = 707075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00044D88 File Offset: 0x00042F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707075, XrefRangeEnd = 707078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayedSpaceNameSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayedSpaceNameSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayedSpaceNameSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00009D1D File Offset: 0x00007F1D
		public WormPlayedSpaceNameSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00044DC4 File Offset: 0x00042FC4
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00009D26 File Offset: 0x00007F26
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00044DF4 File Offset: 0x00042FF4
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00009D45 File Offset: 0x00007F45
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceNameSubscriber.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
