using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200016D RID: 365
	public class TypeNames : Object
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x00007F56 File Offset: 0x00006156
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNames()
		{
			Il2CppClassPointerStore<TypeNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames>.NativeClassPtr);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00007F7B File Offset: 0x0000617B
		public TypeNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020005F8 RID: 1528
		public class ATypeName : Object
		{
			// Token: 0x060057D1 RID: 22481 RVA: 0x00194504 File Offset: 0x00192704
			// Note: this type is marked as 'beforefieldinit'.
			static ATypeName()
			{
				Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeNames>.NativeClassPtr, "ATypeName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr);
				TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667581);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667582);
				TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667583);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667584);
				TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667585);
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x060057D2 RID: 22482 RVA: 0x00194594 File Offset: 0x00192794
			public unsafe virtual string DisplayName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060057D3 RID: 22483 RVA: 0x001945D8 File Offset: 0x001927D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349566, XrefRangeEnd = 1349567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(TypeName other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057D4 RID: 22484 RVA: 0x00194628 File Offset: 0x00192828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349567, XrefRangeEnd = 1349568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057D5 RID: 22485 RVA: 0x00194670 File Offset: 0x00192870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349568, XrefRangeEnd = 1349572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057D6 RID: 22486 RVA: 0x001946C8 File Offset: 0x001928C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ATypeName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057D7 RID: 22487 RVA: 0x0001F3FA File Offset: 0x0001D5FA
			public ATypeName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400483D RID: 18493
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400483E RID: 18494
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0;

			// Token: 0x0400483F RID: 18495
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004840 RID: 18496
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004841 RID: 18497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}
	}
}
