using System;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace dwd
{
	// Token: 0x02000044 RID: 68
	public class DefaultGameInit : GameInit
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00025DB4 File Offset: 0x00023FB4
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultGameInit()
		{
			Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd", "DefaultGameInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr);
			DefaultGameInit.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr, 100663711);
			DefaultGameInit.NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr, 100663712);
			DefaultGameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr, 100663713);
			DefaultGameInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr, 100663714);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00025E34 File Offset: 0x00024034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498910, XrefRangeEnd = 498914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Archetypes getArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultGameInit.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00025E80 File Offset: 0x00024080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498914, XrefRangeEnd = 498918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initClientVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultGameInit.NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00025EBC File Offset: 0x000240BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void configureSharedPrefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultGameInit.NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00025EF8 File Offset: 0x000240F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497280, RefRangeEnd = 497281, XrefRangeStart = 497280, XrefRangeEnd = 497281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultGameInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultGameInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGameInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003292 File Offset: 0x00001492
		public DefaultGameInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Protected_Virtual_Archetypes_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_initClientVersion_Protected_Virtual_Void_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_configureSharedPrefs_Protected_Virtual_Void_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
