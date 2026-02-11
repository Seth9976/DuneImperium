using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003F0 RID: 1008
	public sealed class ResourceLocator : ValueType
	{
		// Token: 0x06003B0E RID: 15118 RVA: 0x0011C068 File Offset: 0x0011A268
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocator()
		{
			Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr);
			ResourceLocator.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_value");
			ResourceLocator.NativeFieldInfoPtr__dataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_dataPos");
			ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100672114);
			ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100672115);
			ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100672116);
			ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100672117);
			ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100672118);
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x0011C124 File Offset: 0x0011A324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387074, RefRangeEnd = 1387077, XrefRangeStart = 1387074, XrefRangeEnd = 1387077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocator(int dataPos, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0011C184 File Offset: 0x0011A384
		public unsafe int DataPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x0011C1C8 File Offset: 0x0011A3C8
		// (set) Token: 0x06003B12 RID: 15122 RVA: 0x0011C20C File Offset: 0x0011A40C
		public unsafe Object Value
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x0011C254 File Offset: 0x0011A454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397568, RefRangeEnd = 1397570, XrefRangeStart = 1397568, XrefRangeEnd = 1397568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCache(ResourceTypeCode value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00015F91 File Offset: 0x00014191
		public ResourceLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00015F9A File Offset: 0x0001419A
		public ResourceLocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x0011C294 File Offset: 0x0011A494
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x00015FAC File Offset: 0x000141AC
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x0011C2C4 File Offset: 0x0011A4C4
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00015FCB File Offset: 0x000141CB
		public unsafe int _dataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos)) = value;
			}
		}

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeFieldInfoPtr__dataPos;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_Object_0;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0;
	}
}
