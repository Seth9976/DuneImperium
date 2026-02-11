using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200016E RID: 366
	public class TypeIdentifiers : Object
	{
		// Token: 0x060018CB RID: 6347 RVA: 0x00007F84 File Offset: 0x00006184
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifiers()
		{
			Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr);
			TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, 100667586);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0009AC58 File Offset: 0x00098E58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1349599, RefRangeEnd = 1349602, XrefRangeStart = 1349593, XrefRangeEnd = 1349599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier FromDisplay(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00007FBD File Offset: 0x000061BD
		public TypeIdentifiers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0;

		// Token: 0x020005F9 RID: 1529
		public class Display : TypeNames.ATypeName
		{
			// Token: 0x060057D8 RID: 22488 RVA: 0x00194704 File Offset: 0x00192904
			// Note: this type is marked as 'beforefieldinit'.
			static Display()
			{
				Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, "Display");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr);
				TypeIdentifiers.Display.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "displayName");
				TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "internal_name");
				TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667587);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667588);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667589);
				TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667590);
			}

			// Token: 0x060057D9 RID: 22489 RVA: 0x001947A8 File Offset: 0x001929A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349572, XrefRangeEnd = 1349575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Display(string displayName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x060057DA RID: 22490 RVA: 0x001947F4 File Offset: 0x001929F4
			public unsafe override string DisplayName
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x060057DB RID: 22491 RVA: 0x00194838 File Offset: 0x00192A38
			public unsafe virtual string InternalName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349575, XrefRangeEnd = 1349584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060057DC RID: 22492 RVA: 0x00194870 File Offset: 0x00192A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349584, XrefRangeEnd = 1349593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetInternalName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060057DD RID: 22493 RVA: 0x0001F403 File Offset: 0x0001D603
			public Display(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x060057DE RID: 22494 RVA: 0x001948A8 File Offset: 0x00192AA8
			// (set) Token: 0x060057DF RID: 22495 RVA: 0x0001F40C File Offset: 0x0001D60C
			public unsafe string displayName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x060057E0 RID: 22496 RVA: 0x001948D0 File Offset: 0x00192AD0
			// (set) Token: 0x060057E1 RID: 22497 RVA: 0x0001F42B File Offset: 0x0001D62B
			public unsafe string internal_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004842 RID: 18498
			private static readonly IntPtr NativeFieldInfoPtr_displayName;

			// Token: 0x04004843 RID: 18499
			private static readonly IntPtr NativeFieldInfoPtr_internal_name;

			// Token: 0x04004844 RID: 18500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x04004845 RID: 18501
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;

			// Token: 0x04004846 RID: 18502
			private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04004847 RID: 18503
			private static readonly IntPtr NativeMethodInfoPtr_GetInternalName_Private_String_0;
		}
	}
}
