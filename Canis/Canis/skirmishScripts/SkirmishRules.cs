using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004C RID: 76
	public static class SkirmishRules : Object
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishRules()
		{
			Il2CppClassPointerStore<SkirmishRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishRules");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishRules>.NativeClassPtr);
			SkirmishRules.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRules>.NativeClassPtr, "_collection");
			SkirmishRules.NativeMethodInfoPtr_setCollection_Public_Static_Void_Func_1_SkirmishCollections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRules>.NativeClassPtr, 100664270);
			SkirmishRules.NativeMethodInfoPtr_getCollection_Public_Static_SkirmishCollections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRules>.NativeClassPtr, 100664271);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002C154 File Offset: 0x0002A354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553682, XrefRangeEnd = 553687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setCollection(Func<SkirmishCollections> collection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRules.NativeMethodInfoPtr_setCollection_Public_Static_Void_Func_1_SkirmishCollections_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002C18C File Offset: 0x0002A38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553687, XrefRangeEnd = 553689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SkirmishCollections getCollection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRules.NativeMethodInfoPtr_getCollection_Public_Static_SkirmishCollections_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishCollections>(intPtr3) : null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00004237 File Offset: 0x00002437
		public SkirmishRules(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004240 File Offset: 0x00002440
		public unsafe static SkirmishCollections _collection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishRules.NativeFieldInfoPtr__collection, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishCollections>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishRules.NativeFieldInfoPtr__collection, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr__collection;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_setCollection_Public_Static_Void_Func_1_SkirmishCollections_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_getCollection_Public_Static_SkirmishCollections_0;
	}
}
