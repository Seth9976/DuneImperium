using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000330 RID: 816
	public class TypeLoadExceptionHolder : Object
	{
		// Token: 0x060031FF RID: 12799 RVA: 0x000FD444 File Offset: 0x000FB644
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLoadExceptionHolder()
		{
			Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "TypeLoadExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr);
			TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, "m_typeName");
			TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671139);
			TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671140);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000FD4B0 File Offset: 0x000FB6B0
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadExceptionHolder(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x000FD4FC File Offset: 0x000FB6FC
		public unsafe string TypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00011433 File Offset: 0x0000F633
		public TypeLoadExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x000FD534 File Offset: 0x000FB734
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x0001143C File Offset: 0x0000F63C
		public unsafe string m_typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr_m_typeName;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Internal_get_String_0;
	}
}
