using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000170 RID: 368
	public class ArraySpec : Object
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x0009ADA4 File Offset: 0x00098FA4
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySpec()
		{
			Il2CppClassPointerStore<ArraySpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArraySpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr);
			ArraySpec.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, "dimensions");
			ArraySpec.NativeFieldInfoPtr_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, "bound");
			ArraySpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667593);
			ArraySpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667594);
			ArraySpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667595);
			ArraySpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667596);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0009AE4C File Offset: 0x0009904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349602, XrefRangeEnd = 1349603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySpec(int dimensions, bool bound)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimensions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0009AEA4 File Offset: 0x000990A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349603, XrefRangeEnd = 1349604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0009AEF4 File Offset: 0x000990F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349604, XrefRangeEnd = 1349611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0009AF44 File Offset: 0x00099144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349611, XrefRangeEnd = 1349623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArraySpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00007FCF File Offset: 0x000061CF
		public ArraySpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0009AF88 File Offset: 0x00099188
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00007FD8 File Offset: 0x000061D8
		public unsafe int dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0009AFB0 File Offset: 0x000991B0
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00007FF3 File Offset: 0x000061F3
		public unsafe bool bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_bound)) = value;
			}
		}

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeFieldInfoPtr_bound;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
