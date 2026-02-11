using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004B8 RID: 1208
	[Serializable]
	public sealed class DictionaryEntry : ValueType
	{
		// Token: 0x06004A3F RID: 19007 RVA: 0x001575A0 File Offset: 0x001557A0
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryEntry()
		{
			Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "DictionaryEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr);
			DictionaryEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_key");
			DictionaryEntry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_value");
			DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100674090);
			DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100674091);
			DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100674092);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00157634 File Offset: 0x00155834
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryEntry(Object key, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x00157698 File Offset: 0x00155898
		public unsafe Object Key
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x001576DC File Offset: 0x001558DC
		public unsafe Object Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0001B3E1 File Offset: 0x000195E1
		public DictionaryEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x0001B3EA File Offset: 0x000195EA
		public DictionaryEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x00157720 File Offset: 0x00155920
		// (set) Token: 0x06004A46 RID: 19014 RVA: 0x0001B3FC File Offset: 0x000195FC
		public unsafe Object _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004A47 RID: 19015 RVA: 0x00157750 File Offset: 0x00155950
		// (set) Token: 0x06004A48 RID: 19016 RVA: 0x0001B41B File Offset: 0x0001961B
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
	}
}
