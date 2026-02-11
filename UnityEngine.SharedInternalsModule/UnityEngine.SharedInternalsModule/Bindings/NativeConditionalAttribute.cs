using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000A RID: 10
	public class NativeConditionalAttribute : Attribute
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002DE0 File Offset: 0x00000FE0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeConditionalAttribute()
		{
			Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr);
			NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, "<Condition>k__BackingField");
			NativeConditionalAttribute.NativeFieldInfoPtr__StubReturnStatement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, "<StubReturnStatement>k__BackingField");
			NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, "<Enabled>k__BackingField");
			NativeConditionalAttribute.NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663309);
			NativeConditionalAttribute.NativeMethodInfoPtr_set_StubReturnStatement_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663310);
			NativeConditionalAttribute.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663311);
			NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663312);
			NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663313);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022DE File Offset: 0x000004DE
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002EB0 File Offset: 0x000010B0
		public unsafe string Condition
		{
			get
			{
				return this._Condition_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000022E6 File Offset: 0x000004E6
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002EF4 File Offset: 0x000010F4
		public unsafe string StubReturnStatement
		{
			get
			{
				return this._StubReturnStatement_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr_set_StubReturnStatement_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000022EE File Offset: 0x000004EE
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002F38 File Offset: 0x00001138
		public unsafe bool Enabled
		{
			get
			{
				return this._Enabled_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002F78 File Offset: 0x00001178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269034, XrefRangeEnd = 1269036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeConditionalAttribute(string condition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002FC4 File Offset: 0x000011C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269036, XrefRangeEnd = 1269039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeConditionalAttribute(string condition, string stubReturnStatement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stubReturnStatement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000227C File Offset: 0x0000047C
		public NativeConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003024 File Offset: 0x00001224
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002285 File Offset: 0x00000485
		public unsafe string _Condition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000304C File Offset: 0x0000124C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000022A4 File Offset: 0x000004A4
		public unsafe string _StubReturnStatement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__StubReturnStatement_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__StubReturnStatement_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000022C3 File Offset: 0x000004C3
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__Condition_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__StubReturnStatement_k__BackingField;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_StubReturnStatement_Public_set_Void_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
