using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000180 RID: 384
	public sealed class CustomStyleProperty<T> : ValueType
	{
		// Token: 0x06001CF2 RID: 7410 RVA: 0x00084250 File Offset: 0x00082450
		// Note: this type is marked as 'beforefieldinit'.
		static CustomStyleProperty()
		{
			Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CustomStyleProperty`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr);
			CustomStyleProperty<T>.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, "<name>k__BackingField");
			CustomStyleProperty<T>.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667555);
			CustomStyleProperty<T>.NativeMethodInfoPtr_set_name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667556);
			CustomStyleProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667557);
			CustomStyleProperty<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667558);
			CustomStyleProperty<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CustomStyleProperty_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667559);
			CustomStyleProperty<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr, 100667560);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00084348 File Offset: 0x00082548
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00084384 File Offset: 0x00082584
		public unsafe string name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr_set_name_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000843CC File Offset: 0x000825CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328339, XrefRangeEnd = 328409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomStyleProperty(string propertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0008441C File Offset: 0x0008261C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328409, XrefRangeEnd = 328419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00084470 File Offset: 0x00082670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328419, XrefRangeEnd = 328430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CustomStyleProperty<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CustomStyleProperty_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000844C8 File Offset: 0x000826C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328430, XrefRangeEnd = 328435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleProperty<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0000CDAD File Offset: 0x0000AFAD
		public CustomStyleProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0000CDB6 File Offset: 0x0000AFB6
		public CustomStyleProperty()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomStyleProperty<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0008450C File Offset: 0x0008270C
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomStyleProperty<T>.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomStyleProperty<T>.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00084534 File Offset: 0x00082734
		public static bool operator ==(CustomStyleProperty<T> a, CustomStyleProperty<T> b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00084550 File Offset: 0x00082750
		public static bool operator !=(CustomStyleProperty<T> a, CustomStyleProperty<T> b)
		{
			return !(a == b);
		}

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Private_set_Void_String_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CustomStyleProperty_1_T_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
