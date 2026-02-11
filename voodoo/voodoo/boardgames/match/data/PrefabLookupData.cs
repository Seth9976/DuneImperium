using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x020000A8 RID: 168
	public class PrefabLookupData : DataComponent
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x000297EC File Offset: 0x000279EC
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookupData()
		{
			Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.match.data", "PrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr);
			PrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Abstract_Virtual_New_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr, 100664687);
			PrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr, 100664688);
			PrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr, 100664689);
			PrefabLookupData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr, 100664690);
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002986C File Offset: 0x00027A6C
		public unsafe virtual HashSet<string> Flavors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Abstract_Virtual_New_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000298B8 File Offset: 0x00027AB8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00029900 File Offset: 0x00027B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117624, XrefRangeEnd = 1117635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00029944 File Offset: 0x00027B44
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookupData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookupData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookupData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public PrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Abstract_Virtual_New_get_HashSet_1_String_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
