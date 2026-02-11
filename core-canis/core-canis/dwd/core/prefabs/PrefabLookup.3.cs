using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs
{
	// Token: 0x0200010A RID: 266
	public class PrefabLookup<MetaType, MonoType> : PrefabLookup<MetaType> where MetaType : new() where MonoType : class
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x000506F4 File Offset: 0x0004E8F4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookup()
		{
			Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLookup`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MetaType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MonoType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr);
			PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr_GetMonoType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr, 100665529);
			PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr_SetEntries_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_MonoType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr, 100665530);
			PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr, 100665531);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000507B0 File Offset: 0x0004E9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868198, XrefRangeEnd = 868202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetMonoType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr_GetMonoType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000507FC File Offset: 0x0004E9FC
		[CallerCount(0)]
		public unsafe virtual void SetEntries(IEnumerable<KeyValuePair<MonoType, string>> newEntries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr_SetEntries_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_MonoType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0005084C File Offset: 0x0004EA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868197, RefRangeEnd = 868198, XrefRangeStart = 868197, XrefRangeEnd = 868198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookup<MetaType, MonoType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookup<MetaType, MonoType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00007289 File Offset: 0x00005489
		public PrefabLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoType_Public_Virtual_Type_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_SetEntries_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_MonoType_String_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
