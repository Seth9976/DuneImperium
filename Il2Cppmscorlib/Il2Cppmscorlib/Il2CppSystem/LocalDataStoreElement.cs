using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000127 RID: 295
	public sealed class LocalDataStoreElement : Object
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x00084C40 File Offset: 0x00082E40
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreElement()
		{
			Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr);
			LocalDataStoreElement.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, "m_value");
			LocalDataStoreElement.NativeFieldInfoPtr_m_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, "m_cookie");
			LocalDataStoreElement.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100666780);
			LocalDataStoreElement.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100666781);
			LocalDataStoreElement.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100666782);
			LocalDataStoreElement.NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr, 100666783);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00084CE8 File Offset: 0x00082EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338069, XrefRangeEnd = 1338070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreElement(long cookie)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cookie;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00084D30 File Offset: 0x00082F30
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00084D70 File Offset: 0x00082F70
		public unsafe Object Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00084DB4 File Offset: 0x00082FB4
		public unsafe long Cookie
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreElement.NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00006427 File Offset: 0x00004627
		public LocalDataStoreElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00084DF0 File Offset: 0x00082FF0
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00006430 File Offset: 0x00004630
		public unsafe Object m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00084E20 File Offset: 0x00083020
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x0000644F File Offset: 0x0000464F
		public unsafe long m_cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_cookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreElement.NativeFieldInfoPtr_m_cookie)) = value;
			}
		}

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_m_cookie;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookie_Public_get_Int64_0;
	}
}
