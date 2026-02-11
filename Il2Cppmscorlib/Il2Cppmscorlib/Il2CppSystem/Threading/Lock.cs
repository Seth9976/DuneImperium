using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A2 RID: 418
	public class Lock : Object
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x000A418C File Offset: 0x000A238C
		// Note: this type is marked as 'beforefieldinit'.
		static Lock()
		{
			Il2CppClassPointerStore<Lock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Lock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lock>.NativeClassPtr);
			Lock.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lock>.NativeClassPtr, "_lock");
			Lock.NativeMethodInfoPtr_Acquire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lock>.NativeClassPtr, 100667981);
			Lock.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lock>.NativeClassPtr, 100667982);
			Lock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lock>.NativeClassPtr, 100667983);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000A420C File Offset: 0x000A240C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353018, RefRangeEnd = 1353019, XrefRangeStart = 1353017, XrefRangeEnd = 1353018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lock.NativeMethodInfoPtr_Acquire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000A4240 File Offset: 0x000A2440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353020, RefRangeEnd = 1353022, XrefRangeStart = 1353019, XrefRangeEnd = 1353020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lock.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000A4274 File Offset: 0x000A2474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353022, XrefRangeEnd = 1353028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00008B78 File Offset: 0x00006D78
		public Lock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x000A42B0 File Offset: 0x000A24B0
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00008B81 File Offset: 0x00006D81
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lock.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lock.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Void_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
