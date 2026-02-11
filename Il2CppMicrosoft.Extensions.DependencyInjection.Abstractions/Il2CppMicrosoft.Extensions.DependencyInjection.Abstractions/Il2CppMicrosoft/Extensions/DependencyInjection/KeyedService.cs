using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000E RID: 14
	public static class KeyedService : Object
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002F44 File Offset: 0x00001144
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedService()
		{
			Il2CppClassPointerStore<KeyedService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "KeyedService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedService>.NativeClassPtr);
			KeyedService.NativeFieldInfoPtr__AnyKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedService>.NativeClassPtr, "<AnyKey>k__BackingField");
			KeyedService.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedService>.NativeClassPtr, 100663319);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002F9C File Offset: 0x0000119C
		public unsafe static Object AnyKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265095, XrefRangeEnd = 1265099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedService.NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021FA File Offset: 0x000003FA
		public KeyedService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002203 File Offset: 0x00000403
		public unsafe static Object _AnyKey_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyedService.NativeFieldInfoPtr__AnyKey_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyedService.NativeFieldInfoPtr__AnyKey_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__AnyKey_k__BackingField;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKey_Public_Static_get_Object_0;

		// Token: 0x0200001C RID: 28
		public sealed class AnyKeyObj : Object
		{
			// Token: 0x060000A1 RID: 161 RVA: 0x0000476C File Offset: 0x0000296C
			// Note: this type is marked as 'beforefieldinit'.
			static AnyKeyObj()
			{
				Il2CppClassPointerStore<KeyedService.AnyKeyObj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedService>.NativeClassPtr, "AnyKeyObj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedService.AnyKeyObj>.NativeClassPtr);
				KeyedService.AnyKeyObj.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedService.AnyKeyObj>.NativeClassPtr, 100663321);
				KeyedService.AnyKeyObj.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedService.AnyKeyObj>.NativeClassPtr, 100663322);
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000047C0 File Offset: 0x000029C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265093, XrefRangeEnd = 1265095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedService.AnyKeyObj.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x000047F8 File Offset: 0x000029F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AnyKeyObj()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedService.AnyKeyObj>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedService.AnyKeyObj.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002488 File Offset: 0x00000688
			public AnyKeyObj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
