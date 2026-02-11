using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.moz
{
	// Token: 0x02000122 RID: 290
	public class SubscriberCardMoz : CardMoz
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x00046630 File Offset: 0x00044830
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberCardMoz()
		{
			Il2CppClassPointerStore<SubscriberCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "SubscriberCardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberCardMoz>.NativeClassPtr);
			SubscriberCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberCardMoz>.NativeClassPtr, 100665174);
			SubscriberCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberCardMoz>.NativeClassPtr, 100665175);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00046688 File Offset: 0x00044888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510298, XrefRangeEnd = 510309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getUnitViewData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscriberCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000466D4 File Offset: 0x000448D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510310, RefRangeEnd = 510311, XrefRangeStart = 510309, XrefRangeEnd = 510310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberCardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberCardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00008471 File Offset: 0x00006671
		public SubscriberCardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
