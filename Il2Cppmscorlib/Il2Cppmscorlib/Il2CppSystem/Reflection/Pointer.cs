using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000421 RID: 1057
	public sealed class Pointer : Object
	{
		// Token: 0x06003CBD RID: 15549 RVA: 0x00123074 File Offset: 0x00121274
		// Note: this type is marked as 'beforefieldinit'.
		static Pointer()
		{
			Il2CppClassPointerStore<Pointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Pointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pointer>.NativeClassPtr);
			Pointer.NativeFieldInfoPtr__ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pointer>.NativeClassPtr, "_ptr");
			Pointer.NativeFieldInfoPtr__ptrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pointer>.NativeClassPtr, "_ptrType");
			Pointer.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100672366);
			Pointer.NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100672367);
			Pointer.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100672368);
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00123108 File Offset: 0x00121308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pointer(void* ptr, Type ptrType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pointer>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptrType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00123160 File Offset: 0x00121360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399019, XrefRangeEnd = 1399030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Box(void* ptr, Type type)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001231B4 File Offset: 0x001213B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399030, XrefRangeEnd = 1399035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00016805 File Offset: 0x00014A05
		public Pointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x00123210 File Offset: 0x00121410
		// (set) Token: 0x06003CC3 RID: 15555 RVA: 0x0001680E File Offset: 0x00014A0E
		public unsafe void* _ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptr)) = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00123234 File Offset: 0x00121434
		// (set) Token: 0x06003CC5 RID: 15557 RVA: 0x00016829 File Offset: 0x00014A29
		public unsafe Type _ptrType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptrType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptrType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeFieldInfoPtr__ptr;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeFieldInfoPtr__ptrType;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_Type_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
