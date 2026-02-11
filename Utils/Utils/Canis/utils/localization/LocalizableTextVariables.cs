using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.localization
{
	// Token: 0x02000011 RID: 17
	public class LocalizableTextVariables : LocalizableText
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00006F20 File Offset: 0x00005120
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizableTextVariables()
		{
			Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "LocalizableTextVariables");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr);
			LocalizableTextVariables.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, "Empty");
			LocalizableTextVariables.NativeFieldInfoPtr_TextVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, "TextVars");
			LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663394);
			LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_TextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663395);
			LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663396);
			LocalizableTextVariables.NativeMethodInfoPtr_WithNumber_Public_LocalizableTextVariables_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663397);
			LocalizableTextVariables.NativeMethodInfoPtr_WithVar_Public_LocalizableTextVariables_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663398);
			LocalizableTextVariables.NativeMethodInfoPtr_WithObject_Public_LocalizableTextVariables_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663399);
			LocalizableTextVariables.NativeMethodInfoPtr_get_DisplayText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663400);
			LocalizableTextVariables.NativeMethodInfoPtr_TryLocalize_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663401);
			LocalizableTextVariables.NativeMethodInfoPtr_Clone_Public_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663402);
			LocalizableTextVariables.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizableTextVariables_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr, 100663403);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007040 File Offset: 0x00005240
		[CallerCount(137)]
		[CachedScanResults(RefRangeStart = 1177745, RefRangeEnd = 1177882, XrefRangeStart = 1177728, XrefRangeEnd = 1177745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000708C File Offset: 0x0000528C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1177899, RefRangeEnd = 1177908, XrefRangeStart = 1177882, XrefRangeEnd = 1177899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables(string id, TextVariables textVars)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textVars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_TextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000070EC File Offset: 0x000052EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177944, RefRangeEnd = 1177945, XrefRangeStart = 1177908, XrefRangeEnd = 1177944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables(LocalizableTextVariables original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizableTextVariables>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr__ctor_Public_Void_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007138 File Offset: 0x00005338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177945, XrefRangeEnd = 1177960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables WithNumber(string key, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr_WithNumber_Public_LocalizableTextVariables_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007198 File Offset: 0x00005398
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1177975, RefRangeEnd = 1177991, XrefRangeStart = 1177960, XrefRangeEnd = 1177975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables WithVar(string key, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr_WithVar_Public_LocalizableTextVariables_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000071FC File Offset: 0x000053FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177991, XrefRangeEnd = 1178006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables WithObject(string key, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr_WithObject_Public_LocalizableTextVariables_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00007260 File Offset: 0x00005460
		public unsafe override string DisplayText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178006, XrefRangeEnd = 1178011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizableTextVariables.NativeMethodInfoPtr_get_DisplayText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000072A4 File Offset: 0x000054A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178011, XrefRangeEnd = 1178024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string TryLocalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizableTextVariables.NativeMethodInfoPtr_TryLocalize_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000072E8 File Offset: 0x000054E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178024, XrefRangeEnd = 1178028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableTextVariables Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr_Clone_Public_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007328 File Offset: 0x00005528
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 1178032, RefRangeEnd = 1178102, XrefRangeStart = 1178028, XrefRangeEnd = 1178032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator LocalizableTextVariables(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableTextVariables.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizableTextVariables_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000235F File Offset: 0x0000055F
		public LocalizableTextVariables(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000736C File Offset: 0x0000556C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002368 File Offset: 0x00000568
		public new unsafe static LocalizableTextVariables Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizableTextVariables.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizableTextVariables.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000237A File Offset: 0x0000057A
		public unsafe TextVariables TextVars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizableTextVariables.NativeFieldInfoPtr_TextVars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizableTextVariables.NativeFieldInfoPtr_TextVars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_TextVars;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TextVariables_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizableTextVariables_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_WithNumber_Public_LocalizableTextVariables_String_Int32_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_WithVar_Public_LocalizableTextVariables_String_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_WithObject_Public_LocalizableTextVariables_String_Object_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayText_Public_Virtual_get_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Virtual_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_LocalizableTextVariables_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizableTextVariables_String_0;
	}
}
