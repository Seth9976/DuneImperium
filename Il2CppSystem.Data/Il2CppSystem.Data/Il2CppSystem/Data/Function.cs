using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200001B RID: 27
	public sealed class Function : Object
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0001B994 File Offset: 0x00019B94
		// Note: this type is marked as 'beforefieldinit'.
		static Function()
		{
			Il2CppClassPointerStore<Function>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Function");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Function>.NativeClassPtr);
			Function.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_name");
			Function.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_id");
			Function.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_result");
			Function.NativeFieldInfoPtr__isValidateArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_isValidateArguments");
			Function.NativeFieldInfoPtr__isVariantArgumentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_isVariantArgumentList");
			Function.NativeFieldInfoPtr__argumentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_argumentCount");
			Function.NativeFieldInfoPtr__parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_parameters");
			Function.NativeFieldInfoPtr_s_functionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "s_functionName");
			Function.NativeMethodInfoPtr__ctor_Internal_Void_String_FunctionId_Type_Boolean_Boolean_Int32_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100664058);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001BA78 File Offset: 0x00019C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897455, XrefRangeEnd = 897478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsValidateArguments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsVariantArgumentList;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a1);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a2);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Internal_Void_String_FunctionId_Type_Boolean_Boolean_Int32_Type_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000032DE File Offset: 0x000014DE
		public Function(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0001BB48 File Offset: 0x00019D48
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000032E7 File Offset: 0x000014E7
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0001BB70 File Offset: 0x00019D70
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00003306 File Offset: 0x00001506
		public unsafe FunctionId _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0001BB98 File Offset: 0x00019D98
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00003321 File Offset: 0x00001521
		public unsafe Type _result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003340 File Offset: 0x00001540
		public unsafe bool _isValidateArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__isValidateArguments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__isValidateArguments)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x0000335B File Offset: 0x0000155B
		public unsafe bool _isVariantArgumentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__isVariantArgumentList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__isVariantArgumentList)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0001BC18 File Offset: 0x00019E18
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003376 File Offset: 0x00001576
		public unsafe int _argumentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__argumentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__argumentCount)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0001BC40 File Offset: 0x00019E40
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00003391 File Offset: 0x00001591
		public unsafe Il2CppReferenceArray<Type> _parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0001BC70 File Offset: 0x00019E70
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000033B0 File Offset: 0x000015B0
		public unsafe static Il2CppStringArray s_functionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Function.NativeFieldInfoPtr_s_functionName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Function.NativeFieldInfoPtr_s_functionName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr__result;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr__isValidateArguments;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr__isVariantArgumentList;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr__argumentCount;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__parameters;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_s_functionName;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FunctionId_Type_Boolean_Boolean_Int32_Type_Type_Type_0;
	}
}
