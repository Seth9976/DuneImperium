using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace boardgames.voodoo.data
{
	// Token: 0x020000A1 RID: 161
	public class ManagedDataObserver : DirtyBehaviour
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x00028450 File Offset: 0x00026650
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedDataObserver()
		{
			Il2CppClassPointerStore<ManagedDataObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo.data", "ManagedDataObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedDataObserver>.NativeClassPtr);
			ManagedDataObserver.NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataObserver>.NativeClassPtr, 100664649);
			ManagedDataObserver.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataObserver>.NativeClassPtr, 100664650);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000284A8 File Offset: 0x000266A8
		[CallerCount(0)]
		public unsafe virtual void Republish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagedDataObserver.NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000284E4 File Offset: 0x000266E4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagedDataObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedDataObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataObserver.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000068A6 File Offset: 0x00004AA6
		public ManagedDataObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
